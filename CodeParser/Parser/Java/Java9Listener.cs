using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Java9Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IJava9Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] Java9Parser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] Java9Parser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] Java9Parser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] Java9Parser.PrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.numericType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericType([NotNull] Java9Parser.NumericTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.numericType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericType([NotNull] Java9Parser.NumericTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.integralType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegralType([NotNull] Java9Parser.IntegralTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.integralType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegralType([NotNull] Java9Parser.IntegralTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.floatingPointType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatingPointType([NotNull] Java9Parser.FloatingPointTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.floatingPointType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatingPointType([NotNull] Java9Parser.FloatingPointTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.referenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferenceType([NotNull] Java9Parser.ReferenceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.referenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferenceType([NotNull] Java9Parser.ReferenceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassOrInterfaceType([NotNull] Java9Parser.ClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassOrInterfaceType([NotNull] Java9Parser.ClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType([NotNull] Java9Parser.ClassTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType([NotNull] Java9Parser.ClassTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType_lf_classOrInterfaceType([NotNull] Java9Parser.ClassType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType_lf_classOrInterfaceType([NotNull] Java9Parser.ClassType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType_lfno_classOrInterfaceType([NotNull] Java9Parser.ClassType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType_lfno_classOrInterfaceType([NotNull] Java9Parser.ClassType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType([NotNull] Java9Parser.InterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType([NotNull] Java9Parser.InterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType_lf_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType_lf_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType_lfno_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType_lfno_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeVariable([NotNull] Java9Parser.TypeVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeVariable([NotNull] Java9Parser.TypeVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayType([NotNull] Java9Parser.ArrayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayType([NotNull] Java9Parser.ArrayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dims"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDims([NotNull] Java9Parser.DimsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dims"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDims([NotNull] Java9Parser.DimsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameter([NotNull] Java9Parser.TypeParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameter([NotNull] Java9Parser.TypeParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterModifier([NotNull] Java9Parser.TypeParameterModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterModifier([NotNull] Java9Parser.TypeParameterModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeBound([NotNull] Java9Parser.TypeBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeBound([NotNull] Java9Parser.TypeBoundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.additionalBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionalBound([NotNull] Java9Parser.AdditionalBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.additionalBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionalBound([NotNull] Java9Parser.AdditionalBoundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArguments([NotNull] Java9Parser.TypeArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArguments([NotNull] Java9Parser.TypeArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgumentList([NotNull] Java9Parser.TypeArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgumentList([NotNull] Java9Parser.TypeArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgument([NotNull] Java9Parser.TypeArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgument([NotNull] Java9Parser.TypeArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.wildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWildcard([NotNull] Java9Parser.WildcardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.wildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWildcard([NotNull] Java9Parser.WildcardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.wildcardBounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWildcardBounds([NotNull] Java9Parser.WildcardBoundsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.wildcardBounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWildcardBounds([NotNull] Java9Parser.WildcardBoundsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModuleName([NotNull] Java9Parser.ModuleNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModuleName([NotNull] Java9Parser.ModuleNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageName([NotNull] Java9Parser.PackageNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageName([NotNull] Java9Parser.PackageNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] Java9Parser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] Java9Parser.TypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageOrTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageOrTypeName([NotNull] Java9Parser.PackageOrTypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageOrTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageOrTypeName([NotNull] Java9Parser.PackageOrTypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expressionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionName([NotNull] Java9Parser.ExpressionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expressionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionName([NotNull] Java9Parser.ExpressionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodName([NotNull] Java9Parser.MethodNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodName([NotNull] Java9Parser.MethodNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ambiguousName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAmbiguousName([NotNull] Java9Parser.AmbiguousNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ambiguousName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAmbiguousName([NotNull] Java9Parser.AmbiguousNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] Java9Parser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] Java9Parser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ordinaryCompilation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrdinaryCompilation([NotNull] Java9Parser.OrdinaryCompilationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ordinaryCompilation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrdinaryCompilation([NotNull] Java9Parser.OrdinaryCompilationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.modularCompilation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModularCompilation([NotNull] Java9Parser.ModularCompilationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.modularCompilation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModularCompilation([NotNull] Java9Parser.ModularCompilationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageDeclaration([NotNull] Java9Parser.PackageDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageDeclaration([NotNull] Java9Parser.PackageDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageModifier([NotNull] Java9Parser.PackageModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageModifier([NotNull] Java9Parser.PackageModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDeclaration([NotNull] Java9Parser.ImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDeclaration([NotNull] Java9Parser.ImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleTypeImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleTypeImportDeclaration([NotNull] Java9Parser.SingleTypeImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleTypeImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleTypeImportDeclaration([NotNull] Java9Parser.SingleTypeImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeImportOnDemandDeclaration([NotNull] Java9Parser.TypeImportOnDemandDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeImportOnDemandDeclaration([NotNull] Java9Parser.TypeImportOnDemandDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleStaticImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleStaticImportDeclaration([NotNull] Java9Parser.SingleStaticImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleStaticImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleStaticImportDeclaration([NotNull] Java9Parser.SingleStaticImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.staticImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticImportOnDemandDeclaration([NotNull] Java9Parser.StaticImportOnDemandDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.staticImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticImportOnDemandDeclaration([NotNull] Java9Parser.StaticImportOnDemandDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDeclaration([NotNull] Java9Parser.TypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDeclaration([NotNull] Java9Parser.TypeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModuleDeclaration([NotNull] Java9Parser.ModuleDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModuleDeclaration([NotNull] Java9Parser.ModuleDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModuleDirective([NotNull] Java9Parser.ModuleDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleDirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModuleDirective([NotNull] Java9Parser.ModuleDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.requiresModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRequiresModifier([NotNull] Java9Parser.RequiresModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.requiresModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRequiresModifier([NotNull] Java9Parser.RequiresModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] Java9Parser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] Java9Parser.ClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalClassDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalClassDeclaration([NotNull] Java9Parser.NormalClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalClassDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalClassDeclaration([NotNull] Java9Parser.NormalClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassModifier([NotNull] Java9Parser.ClassModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassModifier([NotNull] Java9Parser.ClassModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameters([NotNull] Java9Parser.TypeParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameters([NotNull] Java9Parser.TypeParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterList([NotNull] Java9Parser.TypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterList([NotNull] Java9Parser.TypeParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.superclass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuperclass([NotNull] Java9Parser.SuperclassContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.superclass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuperclass([NotNull] Java9Parser.SuperclassContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.superinterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuperinterfaces([NotNull] Java9Parser.SuperinterfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.superinterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuperinterfaces([NotNull] Java9Parser.SuperinterfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceTypeList([NotNull] Java9Parser.InterfaceTypeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceTypeList([NotNull] Java9Parser.InterfaceTypeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBody([NotNull] Java9Parser.ClassBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBody([NotNull] Java9Parser.ClassBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBodyDeclaration([NotNull] Java9Parser.ClassBodyDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBodyDeclaration([NotNull] Java9Parser.ClassBodyDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassMemberDeclaration([NotNull] Java9Parser.ClassMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassMemberDeclaration([NotNull] Java9Parser.ClassMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldModifier([NotNull] Java9Parser.FieldModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldModifier([NotNull] Java9Parser.FieldModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaratorList([NotNull] Java9Parser.VariableDeclaratorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaratorList([NotNull] Java9Parser.VariableDeclaratorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaratorId([NotNull] Java9Parser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaratorId([NotNull] Java9Parser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializer([NotNull] Java9Parser.VariableInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializer([NotNull] Java9Parser.VariableInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannType([NotNull] Java9Parser.UnannTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannType([NotNull] Java9Parser.UnannTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannPrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannPrimitiveType([NotNull] Java9Parser.UnannPrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannPrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannPrimitiveType([NotNull] Java9Parser.UnannPrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannReferenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannReferenceType([NotNull] Java9Parser.UnannReferenceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannReferenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannReferenceType([NotNull] Java9Parser.UnannReferenceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType([NotNull] Java9Parser.UnannClassTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType([NotNull] Java9Parser.UnannClassTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType([NotNull] Java9Parser.UnannInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType([NotNull] Java9Parser.UnannInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannTypeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannTypeVariable([NotNull] Java9Parser.UnannTypeVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannTypeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannTypeVariable([NotNull] Java9Parser.UnannTypeVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannArrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannArrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclaration([NotNull] Java9Parser.MethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclaration([NotNull] Java9Parser.MethodDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodModifier([NotNull] Java9Parser.MethodModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodModifier([NotNull] Java9Parser.MethodModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodHeader([NotNull] Java9Parser.MethodHeaderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodHeader([NotNull] Java9Parser.MethodHeaderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult([NotNull] Java9Parser.ResultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult([NotNull] Java9Parser.ResultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameters([NotNull] Java9Parser.FormalParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameters([NotNull] Java9Parser.FormalParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameter([NotNull] Java9Parser.FormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameter([NotNull] Java9Parser.FormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableModifier([NotNull] Java9Parser.VariableModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableModifier([NotNull] Java9Parser.VariableModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLastFormalParameter([NotNull] Java9Parser.LastFormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLastFormalParameter([NotNull] Java9Parser.LastFormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.receiverParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReceiverParameter([NotNull] Java9Parser.ReceiverParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.receiverParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReceiverParameter([NotNull] Java9Parser.ReceiverParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.throws_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrows_([NotNull] Java9Parser.Throws_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.throws_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrows_([NotNull] Java9Parser.Throws_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exceptionTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionTypeList([NotNull] Java9Parser.ExceptionTypeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exceptionTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionTypeList([NotNull] Java9Parser.ExceptionTypeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exceptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionType([NotNull] Java9Parser.ExceptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exceptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionType([NotNull] Java9Parser.ExceptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] Java9Parser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] Java9Parser.MethodBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.instanceInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceInitializer([NotNull] Java9Parser.InstanceInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.instanceInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceInitializer([NotNull] Java9Parser.InstanceInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.staticInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticInitializer([NotNull] Java9Parser.StaticInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.staticInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticInitializer([NotNull] Java9Parser.StaticInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDeclaration([NotNull] Java9Parser.ConstructorDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDeclaration([NotNull] Java9Parser.ConstructorDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorModifier([NotNull] Java9Parser.ConstructorModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorModifier([NotNull] Java9Parser.ConstructorModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDeclarator([NotNull] Java9Parser.ConstructorDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDeclarator([NotNull] Java9Parser.ConstructorDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.simpleTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleTypeName([NotNull] Java9Parser.SimpleTypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.simpleTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleTypeName([NotNull] Java9Parser.SimpleTypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorBody([NotNull] Java9Parser.ConstructorBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorBody([NotNull] Java9Parser.ConstructorBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.explicitConstructorInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicitConstructorInvocation([NotNull] Java9Parser.ExplicitConstructorInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.explicitConstructorInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicitConstructorInvocation([NotNull] Java9Parser.ExplicitConstructorInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumDeclaration([NotNull] Java9Parser.EnumDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumDeclaration([NotNull] Java9Parser.EnumDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBody([NotNull] Java9Parser.EnumBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBody([NotNull] Java9Parser.EnumBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantList([NotNull] Java9Parser.EnumConstantListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantList([NotNull] Java9Parser.EnumConstantListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstant([NotNull] Java9Parser.EnumConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstant([NotNull] Java9Parser.EnumConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantModifier([NotNull] Java9Parser.EnumConstantModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantModifier([NotNull] Java9Parser.EnumConstantModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumBodyDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBodyDeclarations([NotNull] Java9Parser.EnumBodyDeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumBodyDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBodyDeclarations([NotNull] Java9Parser.EnumBodyDeclarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDeclaration([NotNull] Java9Parser.InterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDeclaration([NotNull] Java9Parser.InterfaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalInterfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalInterfaceDeclaration([NotNull] Java9Parser.NormalInterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalInterfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalInterfaceDeclaration([NotNull] Java9Parser.NormalInterfaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceModifier([NotNull] Java9Parser.InterfaceModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceModifier([NotNull] Java9Parser.InterfaceModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.extendsInterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtendsInterfaces([NotNull] Java9Parser.ExtendsInterfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.extendsInterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtendsInterfaces([NotNull] Java9Parser.ExtendsInterfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceBody([NotNull] Java9Parser.InterfaceBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceBody([NotNull] Java9Parser.InterfaceBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMemberDeclaration([NotNull] Java9Parser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMemberDeclaration([NotNull] Java9Parser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantDeclaration([NotNull] Java9Parser.ConstantDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantDeclaration([NotNull] Java9Parser.ConstantDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantModifier([NotNull] Java9Parser.ConstantModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantModifier([NotNull] Java9Parser.ConstantModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMethodDeclaration([NotNull] Java9Parser.InterfaceMethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMethodDeclaration([NotNull] Java9Parser.InterfaceMethodDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMethodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMethodModifier([NotNull] Java9Parser.InterfaceMethodModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMethodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMethodModifier([NotNull] Java9Parser.InterfaceMethodModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeDeclaration([NotNull] Java9Parser.AnnotationTypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeDeclaration([NotNull] Java9Parser.AnnotationTypeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeBody([NotNull] Java9Parser.AnnotationTypeBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeBody([NotNull] Java9Parser.AnnotationTypeBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeMemberDeclaration([NotNull] Java9Parser.AnnotationTypeMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeMemberDeclaration([NotNull] Java9Parser.AnnotationTypeMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeElementDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeElementDeclaration([NotNull] Java9Parser.AnnotationTypeElementDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeElementDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeElementDeclaration([NotNull] Java9Parser.AnnotationTypeElementDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeElementModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeElementModifier([NotNull] Java9Parser.AnnotationTypeElementModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeElementModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeElementModifier([NotNull] Java9Parser.AnnotationTypeElementModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.defaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultValue([NotNull] Java9Parser.DefaultValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.defaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultValue([NotNull] Java9Parser.DefaultValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotation([NotNull] Java9Parser.AnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotation([NotNull] Java9Parser.AnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalAnnotation([NotNull] Java9Parser.NormalAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalAnnotation([NotNull] Java9Parser.NormalAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValuePairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValuePairList([NotNull] Java9Parser.ElementValuePairListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValuePairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValuePairList([NotNull] Java9Parser.ElementValuePairListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValuePair([NotNull] Java9Parser.ElementValuePairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValuePair([NotNull] Java9Parser.ElementValuePairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValue([NotNull] Java9Parser.ElementValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValue([NotNull] Java9Parser.ElementValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValueArrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValueArrayInitializer([NotNull] Java9Parser.ElementValueArrayInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValueArrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValueArrayInitializer([NotNull] Java9Parser.ElementValueArrayInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValueList([NotNull] Java9Parser.ElementValueListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValueList([NotNull] Java9Parser.ElementValueListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.markerAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMarkerAnnotation([NotNull] Java9Parser.MarkerAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.markerAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMarkerAnnotation([NotNull] Java9Parser.MarkerAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleElementAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleElementAnnotation([NotNull] Java9Parser.SingleElementAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleElementAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleElementAnnotation([NotNull] Java9Parser.SingleElementAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayInitializer([NotNull] Java9Parser.ArrayInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayInitializer([NotNull] Java9Parser.ArrayInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializerList([NotNull] Java9Parser.VariableInitializerListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializerList([NotNull] Java9Parser.VariableInitializerListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] Java9Parser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] Java9Parser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.blockStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatements([NotNull] Java9Parser.BlockStatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.blockStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatements([NotNull] Java9Parser.BlockStatementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatement([NotNull] Java9Parser.BlockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatement([NotNull] Java9Parser.BlockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.localVariableDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclarationStatement([NotNull] Java9Parser.LocalVariableDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.localVariableDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclarationStatement([NotNull] Java9Parser.LocalVariableDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclaration([NotNull] Java9Parser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclaration([NotNull] Java9Parser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] Java9Parser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] Java9Parser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementNoShortIf([NotNull] Java9Parser.StatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementNoShortIf([NotNull] Java9Parser.StatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementWithoutTrailingSubstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementWithoutTrailingSubstatement([NotNull] Java9Parser.StatementWithoutTrailingSubstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementWithoutTrailingSubstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementWithoutTrailingSubstatement([NotNull] Java9Parser.StatementWithoutTrailingSubstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.emptyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement([NotNull] Java9Parser.EmptyStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.emptyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement([NotNull] Java9Parser.EmptyStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledStatement([NotNull] Java9Parser.LabeledStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledStatement([NotNull] Java9Parser.LabeledStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.labeledStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledStatementNoShortIf([NotNull] Java9Parser.LabeledStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.labeledStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledStatementNoShortIf([NotNull] Java9Parser.LabeledStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] Java9Parser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] Java9Parser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpression([NotNull] Java9Parser.StatementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpression([NotNull] Java9Parser.StatementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenStatement([NotNull] Java9Parser.IfThenStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenStatement([NotNull] Java9Parser.IfThenStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenElseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenElseStatement([NotNull] Java9Parser.IfThenElseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenElseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenElseStatement([NotNull] Java9Parser.IfThenElseStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenElseStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenElseStatementNoShortIf([NotNull] Java9Parser.IfThenElseStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenElseStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenElseStatementNoShortIf([NotNull] Java9Parser.IfThenElseStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssertStatement([NotNull] Java9Parser.AssertStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssertStatement([NotNull] Java9Parser.AssertStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchStatement([NotNull] Java9Parser.SwitchStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchStatement([NotNull] Java9Parser.SwitchStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchBlock([NotNull] Java9Parser.SwitchBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchBlock([NotNull] Java9Parser.SwitchBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchBlockStatementGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchBlockStatementGroup([NotNull] Java9Parser.SwitchBlockStatementGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchBlockStatementGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchBlockStatementGroup([NotNull] Java9Parser.SwitchBlockStatementGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchLabels([NotNull] Java9Parser.SwitchLabelsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchLabels([NotNull] Java9Parser.SwitchLabelsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchLabel([NotNull] Java9Parser.SwitchLabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchLabel([NotNull] Java9Parser.SwitchLabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantName([NotNull] Java9Parser.EnumConstantNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantName([NotNull] Java9Parser.EnumConstantNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] Java9Parser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] Java9Parser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.whileStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatementNoShortIf([NotNull] Java9Parser.WhileStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.whileStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatementNoShortIf([NotNull] Java9Parser.WhileStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoStatement([NotNull] Java9Parser.DoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoStatement([NotNull] Java9Parser.DoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] Java9Parser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] Java9Parser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatementNoShortIf([NotNull] Java9Parser.ForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatementNoShortIf([NotNull] Java9Parser.ForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.basicForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicForStatement([NotNull] Java9Parser.BasicForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.basicForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicForStatement([NotNull] Java9Parser.BasicForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.basicForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicForStatementNoShortIf([NotNull] Java9Parser.BasicForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.basicForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicForStatementNoShortIf([NotNull] Java9Parser.BasicForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForInit([NotNull] Java9Parser.ForInitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForInit([NotNull] Java9Parser.ForInitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForUpdate([NotNull] Java9Parser.ForUpdateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForUpdate([NotNull] Java9Parser.ForUpdateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpressionList([NotNull] Java9Parser.StatementExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpressionList([NotNull] Java9Parser.StatementExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enhancedForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnhancedForStatement([NotNull] Java9Parser.EnhancedForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enhancedForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnhancedForStatement([NotNull] Java9Parser.EnhancedForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enhancedForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnhancedForStatementNoShortIf([NotNull] Java9Parser.EnhancedForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enhancedForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnhancedForStatementNoShortIf([NotNull] Java9Parser.EnhancedForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakStatement([NotNull] Java9Parser.BreakStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakStatement([NotNull] Java9Parser.BreakStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinueStatement([NotNull] Java9Parser.ContinueStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinueStatement([NotNull] Java9Parser.ContinueStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] Java9Parser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] Java9Parser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] Java9Parser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] Java9Parser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.synchronizedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSynchronizedStatement([NotNull] Java9Parser.SynchronizedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.synchronizedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSynchronizedStatement([NotNull] Java9Parser.SynchronizedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryStatement([NotNull] Java9Parser.TryStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryStatement([NotNull] Java9Parser.TryStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatches([NotNull] Java9Parser.CatchesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatches([NotNull] Java9Parser.CatchesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchClause([NotNull] Java9Parser.CatchClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchClause([NotNull] Java9Parser.CatchClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchFormalParameter([NotNull] Java9Parser.CatchFormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchFormalParameter([NotNull] Java9Parser.CatchFormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchType([NotNull] Java9Parser.CatchTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchType([NotNull] Java9Parser.CatchTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.finally_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFinally_([NotNull] Java9Parser.Finally_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.finally_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFinally_([NotNull] Java9Parser.Finally_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.tryWithResourcesStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryWithResourcesStatement([NotNull] Java9Parser.TryWithResourcesStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.tryWithResourcesStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryWithResourcesStatement([NotNull] Java9Parser.TryWithResourcesStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resourceSpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceSpecification([NotNull] Java9Parser.ResourceSpecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resourceSpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceSpecification([NotNull] Java9Parser.ResourceSpecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceList([NotNull] Java9Parser.ResourceListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceList([NotNull] Java9Parser.ResourceListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResource([NotNull] Java9Parser.ResourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResource([NotNull] Java9Parser.ResourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableAccess([NotNull] Java9Parser.VariableAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableAccess([NotNull] Java9Parser.VariableAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary([NotNull] Java9Parser.PrimaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary([NotNull] Java9Parser.PrimaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray([NotNull] Java9Parser.PrimaryNoNewArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray([NotNull] Java9Parser.PrimaryNoNewArrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lf_arrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lf_arrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lfno_arrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lfno_arrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassLiteral([NotNull] Java9Parser.ClassLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassLiteral([NotNull] Java9Parser.ClassLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression([NotNull] Java9Parser.ClassInstanceCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression([NotNull] Java9Parser.ClassInstanceCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression_lf_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression_lf_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression_lfno_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression_lfno_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgumentsOrDiamond([NotNull] Java9Parser.TypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgumentsOrDiamond([NotNull] Java9Parser.TypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess([NotNull] Java9Parser.FieldAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess([NotNull] Java9Parser.FieldAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess_lf_primary([NotNull] Java9Parser.FieldAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess_lf_primary([NotNull] Java9Parser.FieldAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess_lfno_primary([NotNull] Java9Parser.FieldAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess_lfno_primary([NotNull] Java9Parser.FieldAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess([NotNull] Java9Parser.ArrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess([NotNull] Java9Parser.ArrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess_lf_primary([NotNull] Java9Parser.ArrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess_lf_primary([NotNull] Java9Parser.ArrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess_lfno_primary([NotNull] Java9Parser.ArrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess_lfno_primary([NotNull] Java9Parser.ArrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation([NotNull] Java9Parser.MethodInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation([NotNull] Java9Parser.MethodInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation_lf_primary([NotNull] Java9Parser.MethodInvocation_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation_lf_primary([NotNull] Java9Parser.MethodInvocation_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation_lfno_primary([NotNull] Java9Parser.MethodInvocation_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation_lfno_primary([NotNull] Java9Parser.MethodInvocation_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] Java9Parser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] Java9Parser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference([NotNull] Java9Parser.MethodReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference([NotNull] Java9Parser.MethodReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference_lf_primary([NotNull] Java9Parser.MethodReference_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference_lf_primary([NotNull] Java9Parser.MethodReference_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference_lfno_primary([NotNull] Java9Parser.MethodReference_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference_lfno_primary([NotNull] Java9Parser.MethodReference_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayCreationExpression([NotNull] Java9Parser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayCreationExpression([NotNull] Java9Parser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dimExprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDimExprs([NotNull] Java9Parser.DimExprsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dimExprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDimExprs([NotNull] Java9Parser.DimExprsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dimExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDimExpr([NotNull] Java9Parser.DimExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dimExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDimExpr([NotNull] Java9Parser.DimExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] Java9Parser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] Java9Parser.ConstantExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] Java9Parser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] Java9Parser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaExpression([NotNull] Java9Parser.LambdaExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaExpression([NotNull] Java9Parser.LambdaExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaParameters([NotNull] Java9Parser.LambdaParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaParameters([NotNull] Java9Parser.LambdaParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.inferredFormalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInferredFormalParameterList([NotNull] Java9Parser.InferredFormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.inferredFormalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInferredFormalParameterList([NotNull] Java9Parser.InferredFormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaBody([NotNull] Java9Parser.LambdaBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaBody([NotNull] Java9Parser.LambdaBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] Java9Parser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] Java9Parser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] Java9Parser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] Java9Parser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.leftHandSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeftHandSide([NotNull] Java9Parser.LeftHandSideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.leftHandSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeftHandSide([NotNull] Java9Parser.LeftHandSideContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] Java9Parser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] Java9Parser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalExpression([NotNull] Java9Parser.ConditionalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalExpression([NotNull] Java9Parser.ConditionalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalOrExpression([NotNull] Java9Parser.ConditionalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalOrExpression([NotNull] Java9Parser.ConditionalOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalAndExpression([NotNull] Java9Parser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalAndExpression([NotNull] Java9Parser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclusiveOrExpression([NotNull] Java9Parser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclusiveOrExpression([NotNull] Java9Parser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusiveOrExpression([NotNull] Java9Parser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusiveOrExpression([NotNull] Java9Parser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] Java9Parser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] Java9Parser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] Java9Parser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] Java9Parser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] Java9Parser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] Java9Parser.RelationalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftExpression([NotNull] Java9Parser.ShiftExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftExpression([NotNull] Java9Parser.ShiftExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] Java9Parser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] Java9Parser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] Java9Parser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] Java9Parser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] Java9Parser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] Java9Parser.UnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.preIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreIncrementExpression([NotNull] Java9Parser.PreIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.preIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreIncrementExpression([NotNull] Java9Parser.PreIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.preDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreDecrementExpression([NotNull] Java9Parser.PreDecrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.preDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreDecrementExpression([NotNull] Java9Parser.PreDecrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unaryExpressionNotPlusMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpressionNotPlusMinus([NotNull] Java9Parser.UnaryExpressionNotPlusMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unaryExpressionNotPlusMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpressionNotPlusMinus([NotNull] Java9Parser.UnaryExpressionNotPlusMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixExpression([NotNull] Java9Parser.PostfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixExpression([NotNull] Java9Parser.PostfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostIncrementExpression([NotNull] Java9Parser.PostIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostIncrementExpression([NotNull] Java9Parser.PostIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostIncrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostIncrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostIncrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostIncrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostDecrementExpression([NotNull] Java9Parser.PostDecrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostDecrementExpression([NotNull] Java9Parser.PostDecrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostDecrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostDecrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostDecrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostDecrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastExpression([NotNull] Java9Parser.CastExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastExpression([NotNull] Java9Parser.CastExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] Java9Parser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] Java9Parser.IdentifierContext context);
}
