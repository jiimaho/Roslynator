﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

namespace Roslynator.CSharp
{
    internal static class CompilerDiagnosticIdentifiers
    {
        public const string OperatorCannotBeAppliedToOperands = "CS0019";
        public const string OperatorCannotBeAppliedToOperandOfType = "CS0023";
        public const string CannotImplicitlyConvertType = "CS0029";
        public const string CannotConvertNullToTypeBecauseItIsNonNullableValueType = "CS0037";
        public const string EventInInterfaceCannotHaveAddOrRemoveAccessors = "CS0069";
        public const string ConstraintsAreNotAllowedOnNonGenericDeclarations = "CS0080";
        public const string NamespaceAlreadyContainsDefinition = "CS0101";
        public const string TypeAlreadyContainsDefinition = "CS0102";
        public const string ModifierIsNotValidForThisItem = "CS0106";
        public const string MoreThanOneProtectionModifier = "CS0107";
        public const string MemberHidesInheritedMemberUseNewKeywordIfHidingWasIntended = "CS0108";
        public const string MemberDoesNotHideAccessibleMember = "CS0109";
        public const string StaticMemberCannotBeMarkedOverrideVirtualOrAbstract = "CS0112";
        public const string MemberHidesInheritedMemberToMakeCurrentMethodOverrideThatImplementationAddOverrideKeyword = "CS0114";
        public const string NoSuitableMethodFoundToOverride = "CS0115";
        public const string ObjectReferenceIsRequiredForNonStaticMember = "CS0120";
        public const string NoOverloadMatchesDelegate = "CS0123";
        public const string SinceMethodReturnsVoidReturnKeywordMustNotBeFollowedByObjectExpression = "CS0127";
        public const string LocalVariableOrFunctionIsAlreadyDefinedInThisScope = "CS0128";
        public const string StaticConstructorMustBeParameterless = "CS0132";
        public const string ExpressionBeingAssignedMustBeConstant = "CS0133";
        public const string LocalOrParameterCannotBeDeclaredInThisScopeBecauseThatNameIsUsedInEnclosingScopeToDefineLocalOrParameter = "CS0136";
        public const string NotAllCodePathsReturnValue = "CS0161";
        public const string UnreachableCodeDetected = "CS0162";
        public const string ControlCannotFallThroughFromOneCaseLabelToAnother = "CS0163";
        public const string LabelHasNotBeenReferenced = "CS0164";
        public const string UseOfUnassignedLocalVariable = "CS0165";
        public const string VariableIsDeclaredButNeverUsed = "CS0168";
        public const string TypeOfConditionalExpressionCannotBeDetermined = "CS0173";
        public const string OutParameterMustBeAssignedToBeforeControlLeavesCurrentMethod = "CS0177";
        public const string OnlyAssignmentCallIncrementDecrementAndNewObjectExpressionsCanBeUsedAsStatement = "CS0201";
        public const string PointersAndFixedSizeBuffersMayOnlyBeUsedInUnsafeContext = "CS0214";
        public const string VariableIsAssignedButItsValueIsNeverUsed = "CS0219";
        public const string ConstantValueCannotBeConverted = "CS0221";
        public const string ParamsParameterMustBeSingleDimensionalArray = "CS0225";
        public const string MissingPartialModifier = "CS0260";
        public const string PartialDeclarationsHaveConfictingAccessibilityModifiers = "CS0262";
        public const string CannotImplicitlyConvertTypeExplicitConversionExists = "CS0266";
        public const string PartialModifierCanOnlyAppearImmediatelyBeforeClassStructInterfaceOrVoid = "CS0267";
        public const string AccessibilityModifiersMayNotBeUsedOnAccessorsInInterface = "CS0275";
        public const string UsingGenericTypeRequiresTypeArguments = "CS0305";
        public const string NewConstraintMustBeLastConstraintSpecified = "CS0401";
        public const string DuplicateConstraintForTypeParameter = "CS0405";
        public const string MethodHasWrongReturnType = "CS0407";
        public const string ConstraintClauseHasAlreadyBeenSpecified = "CS0409";
        public const string CannotConvertMethodGroupToNonDelegateType = "CS0428";
        public const string ClassCannotBeBothStaticAndSealed = "CS0441";
        public const string AbstractPropertiesCannotHavePrivateAccessors = "CS0442";
        public const string ClassOrStructConstraintMustComeBeforeAnyOtherConstraints = "CS0449";
        public const string CannotSpecifyBothConstraintClassAndClassOrStructConstraint = "CS0450";
        public const string NewConstraintCannotBeUsedWithStructConstraint = "CS0451";
        public const string MemberCannotDeclareBodyBecauseItIsMarkedAbstract = "CS0500";
        public const string MemberMustDeclareBodyBecauseItIsNotMarkedAbstractExternOrPartial = "CS0501";
        public const string CannotChangeAccessModifiersWhenOverridingInheritedMember = "CS0507";
        public const string MethodReturnTypeMustMatchOverriddenMethodReturnType = "CS0508";
        public const string MemberIsAbstractButItIsContainedInNonAbstractClass = "CS0513";
        public const string AccessModifiersAreNotAllowedOnStaticConstructors = "CS0515";
        public const string InterfaceMembersCannotHaveDefinition = "CS0531";
        public const string UserDefinedOperatorMustBeDeclaredStaticAndPublic = "CS0558";
        public const string CannotHaveInstancePropertyOrFieldInitializersInStruct = "CS0573";
        public const string DuplicateAttribute = "CS0579";
        public const string VirtualOrAbstractmembersCannotBePrivate  = "CS0621";
        public const string NewProtectedMemberDeclaredInSealedClass = "CS0628";
        public const string FieldCanNotBeBothVolatileAndReadOnly = "CS0678";
        public const string TypeParameterHasSameNameAsTypeParameterFromOuterType = "CS0693";
        public const string CannotDeclareInstanceMembersInStaticClass = "CS0708";
        public const string StaticClassesCannotHaveInstanceConstructors = "CS0710";
        public const string StaticTypesCannotBeUsedAsTypeArguments = "CS0718";
        public const string PartialMethodCannotHaveAccessModifiersOrVirtualAbstractOverrideNewSealedOrExternModifiers = "CS0750";
        public const string PartialMethodMustBeDeclaredWithinPartialClassOrPartialStruct = "CS0751";
        public const string OnlyMethodsClassesStructsOrInterfacesMayBePartial = "CS0753";
        public const string PartialMethodMayNotHaveMultipleDefiningDeclarations = "CS0756";
        public const string NoDefiningDeclarationFoundForImplementingDeclarationOfPartialMethod = "CS0759";
        public const string PartialMethodsMustHaveVoidReturnType = "CS0766";
        public const string CannotAssignMethodGroupToImplicitlyTypedVariable = "CS0815";
        public const string ImplicitlyTypedVariablesCannotHaveMultipleDeclarators = "CS0819";
        public const string ImplicitlyTypedVariablesCannotBeConstant = "CS0822";
        public const string SemicolonExpected = "CS1002";
        public const string DuplicateModifier = "CS1004";
        public const string EmbeddedStatementCannotBeDeclarationOrLabeledStatement = "CS1023";
        public const string StaticClassesCannotContainProtectedMembers = "CS1057";
        public const string TypeDoesNotContainDefinitionAndNoExtensionMethodCouldBeFound = "CS1061";
        public const string MethodHasParameterModifierThisWhichIsNotOnFirstParameter = "CS1100";
        public const string ExtensionMethodMustBeStatic = "CS1105";
        public const string CannotConvertArgumentType = "CS1503";
        public const string EmptySwitchBlock = "CS1522";
        public const string ElementsDefinedInNamespaceCannotBeExplicitlyDeclaredAsPrivateProtectedOrProtectedInternal = "CS1527";
        public const string MissingXmlCommentForPubliclyVisibleTypeOrMember = "CS1591";
        public const string ModifiersCannotBePlacedOnEventAccessorDeclarations = "CS1609";
        public const string ArgumentMayNotBePassedWithRefKeyword = "CS1615";
        public const string ArgumentMustBePassedWithOutKeyword = "CS1620";
        public const string YieldStatementCannotBeUsedInsideAnonymousMethodOrLambdaExpression = "CS1621";
        public const string CannotReturnValueFromIterator = "CS1622";
        public const string NotAllCodePathsReturnValueInAnonymousFunction = "CS1643";
        public const string TypeUsedInUsingStatementMustBeImplicitlyConvertibleToIDisposable = "CS1674";
        public const string MemberTypeMustMatchOverriddenMemberType = "CS1715";
        public const string AssignmentMadeToSameVariable = "CS1717";
        public const string BaseClassMustComeBeforeAnyInterface = "CS1722";
        public const string NonInvocableMemberCannotBeUsedLikeMethod = "CS1955";
        public const string AsyncModifierCanOnlyBeUsedInMethodsThatHaveBody = "CS1994";
        public const string SinceMethodIsAsyncMethodThatReturnsTaskReturnKeywordMustNotBeFollowedByObjectExpression = "CS1997";
        public const string ControlCannotFallOutOfSwitchFromFinalCaseLabel = "CS8070";
    }
}