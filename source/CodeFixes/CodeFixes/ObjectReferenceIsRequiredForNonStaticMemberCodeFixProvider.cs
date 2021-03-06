﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Immutable;
using System.Composition;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Roslynator.CSharp.CodeFixes
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ObjectReferenceIsRequiredForNonStaticMemberCodeFixProvider))]
    [Shared]
    public class ObjectReferenceIsRequiredForNonStaticMemberCodeFixProvider : BaseCodeFixProvider
    {
        public sealed override ImmutableArray<string> FixableDiagnosticIds
        {
            get { return ImmutableArray.Create(CompilerDiagnosticIdentifiers.ObjectReferenceIsRequiredForNonStaticMember); }
        }

        public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
        {
            if (!Settings.IsAnyCodeFixEnabled(
                CodeFixIdentifiers.AddStaticModifier,
                CodeFixIdentifiers.MakeMemberNonStatic))
            {
                return;
            }

            SyntaxNode root = await context.GetSyntaxRootAsync().ConfigureAwait(false);

            if (!TryFindNode(root, context.Span, out SyntaxNode node))
                return;

            Diagnostic diagnostic = context.Diagnostics[0];

            for (SyntaxNode parent = node.Parent; parent != null; parent = parent.Parent)
            {
                if (parent is MemberDeclarationSyntax memberDeclaration)
                {
                    Debug.Assert(memberDeclaration.GetModifiers().Contains(SyntaxKind.StaticKeyword), memberDeclaration.ToString());

                    if (memberDeclaration.GetModifiers().Contains(SyntaxKind.StaticKeyword))
                    {
                        if (Settings.IsCodeFixEnabled(CodeFixIdentifiers.MakeMemberNonStatic))
                        {
                            ModifiersCodeFixRegistrator.RemoveModifier(
                            context,
                            diagnostic,
                            memberDeclaration,
                            SyntaxKind.StaticKeyword,
                            title: $"Make containing {memberDeclaration.GetTitle()} non-static",
                            additionalKey: CodeFixIdentifiers.MakeMemberNonStatic);
                        }

                        if (Settings.IsCodeFixEnabled(CodeFixIdentifiers.AddStaticModifier))
                        {
                            SemanticModel semanticModel = await context.GetSemanticModelAsync().ConfigureAwait(false);

                            AddStaticModifier(context, diagnostic, node, semanticModel);
                        }
                    }

                    return;
                }
                else if (parent is ConstructorInitializerSyntax)
                {
                    if (Settings.IsCodeFixEnabled(CodeFixIdentifiers.AddStaticModifier))
                    {
                        SemanticModel semanticModel = await context.GetSemanticModelAsync().ConfigureAwait(false);

                        AddStaticModifier(context, diagnostic, node, semanticModel);
                    }

                    return;
                }
            }
        }

        private void AddStaticModifier(
            CodeFixContext context,
            Diagnostic diagnostic,
            SyntaxNode node,
            SemanticModel semanticModel)
        {
            ISymbol symbol = semanticModel.GetSymbol(node, context.CancellationToken);

            if (symbol == null)
                return;

            SyntaxNode syntax = symbol.GetSyntaxOrDefault(context.CancellationToken);

            if (syntax == null)
                return;

            if (syntax.Kind() == SyntaxKind.VariableDeclarator)
                syntax = syntax.Parent?.Parent;

            Debug.Assert(syntax.IsKind(SyntaxKind.EventDeclaration, SyntaxKind.EventFieldDeclaration, SyntaxKind.FieldDeclaration, SyntaxKind.MethodDeclaration, SyntaxKind.PropertyDeclaration), syntax.ToString());

            if (!(syntax is MemberDeclarationSyntax memberDeclaration))
                return;

            if (memberDeclaration.GetModifiers().Contains(SyntaxKind.StaticKeyword))
                return;

            Document document = context.Document;

            SyntaxTree tree = memberDeclaration.SyntaxTree;

            if (tree != node.SyntaxTree)
                document = context.Solution().GetDocument(tree);

            ModifiersCodeFixRegistrator.AddModifier(
                context,
                document,
                diagnostic,
                memberDeclaration,
                SyntaxKind.StaticKeyword,
                title: $"Make '{symbol.Name}' static",
                additionalKey: CodeFixIdentifiers.AddStaticModifier);
        }
    }
}
