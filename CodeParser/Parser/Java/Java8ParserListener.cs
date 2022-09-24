using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="Java8Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IJava8ParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] Java8Parser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] Java8Parser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] Java8Parser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] Java8Parser.PrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.numericType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericType([NotNull] Java8Parser.NumericTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.numericType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericType([NotNull] Java8Parser.NumericTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.integralType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegralType([NotNull] Java8Parser.IntegralTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.integralType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegralType([NotNull] Java8Parser.IntegralTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.floatingPointType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatingPointType([NotNull] Java8Parser.FloatingPointTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.floatingPointType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatingPointType([NotNull] Java8Parser.FloatingPointTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.referenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferenceType([NotNull] Java8Parser.ReferenceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.referenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferenceType([NotNull] Java8Parser.ReferenceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassOrInterfaceType([NotNull] Java8Parser.ClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassOrInterfaceType([NotNull] Java8Parser.ClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType([NotNull] Java8Parser.ClassTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType([NotNull] Java8Parser.ClassTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType_lf_classOrInterfaceType([NotNull] Java8Parser.ClassType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType_lf_classOrInterfaceType([NotNull] Java8Parser.ClassType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassType_lfno_classOrInterfaceType([NotNull] Java8Parser.ClassType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassType_lfno_classOrInterfaceType([NotNull] Java8Parser.ClassType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType([NotNull] Java8Parser.InterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType([NotNull] Java8Parser.InterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType_lf_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType_lf_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lf_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceType_lfno_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceType_lfno_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lfno_classOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeVariable([NotNull] Java8Parser.TypeVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeVariable([NotNull] Java8Parser.TypeVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayType([NotNull] Java8Parser.ArrayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayType([NotNull] Java8Parser.ArrayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dims"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDims([NotNull] Java8Parser.DimsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dims"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDims([NotNull] Java8Parser.DimsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameter([NotNull] Java8Parser.TypeParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameter([NotNull] Java8Parser.TypeParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterModifier([NotNull] Java8Parser.TypeParameterModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterModifier([NotNull] Java8Parser.TypeParameterModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeBound([NotNull] Java8Parser.TypeBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeBound([NotNull] Java8Parser.TypeBoundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.additionalBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditionalBound([NotNull] Java8Parser.AdditionalBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.additionalBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditionalBound([NotNull] Java8Parser.AdditionalBoundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArguments([NotNull] Java8Parser.TypeArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArguments([NotNull] Java8Parser.TypeArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgumentList([NotNull] Java8Parser.TypeArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgumentList([NotNull] Java8Parser.TypeArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgument([NotNull] Java8Parser.TypeArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgument([NotNull] Java8Parser.TypeArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.wildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWildcard([NotNull] Java8Parser.WildcardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.wildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWildcard([NotNull] Java8Parser.WildcardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.wildcardBounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWildcardBounds([NotNull] Java8Parser.WildcardBoundsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.wildcardBounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWildcardBounds([NotNull] Java8Parser.WildcardBoundsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageName([NotNull] Java8Parser.PackageNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageName([NotNull] Java8Parser.PackageNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] Java8Parser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] Java8Parser.TypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageOrTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageOrTypeName([NotNull] Java8Parser.PackageOrTypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageOrTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageOrTypeName([NotNull] Java8Parser.PackageOrTypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expressionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionName([NotNull] Java8Parser.ExpressionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expressionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionName([NotNull] Java8Parser.ExpressionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodName([NotNull] Java8Parser.MethodNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodName([NotNull] Java8Parser.MethodNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ambiguousName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAmbiguousName([NotNull] Java8Parser.AmbiguousNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ambiguousName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAmbiguousName([NotNull] Java8Parser.AmbiguousNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] Java8Parser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] Java8Parser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageDeclaration([NotNull] Java8Parser.PackageDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageDeclaration([NotNull] Java8Parser.PackageDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackageModifier([NotNull] Java8Parser.PackageModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackageModifier([NotNull] Java8Parser.PackageModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDeclaration([NotNull] Java8Parser.ImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDeclaration([NotNull] Java8Parser.ImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleTypeImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleTypeImportDeclaration([NotNull] Java8Parser.SingleTypeImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleTypeImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleTypeImportDeclaration([NotNull] Java8Parser.SingleTypeImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeImportOnDemandDeclaration([NotNull] Java8Parser.TypeImportOnDemandDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeImportOnDemandDeclaration([NotNull] Java8Parser.TypeImportOnDemandDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleStaticImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleStaticImportDeclaration([NotNull] Java8Parser.SingleStaticImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleStaticImportDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleStaticImportDeclaration([NotNull] Java8Parser.SingleStaticImportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.staticImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticImportOnDemandDeclaration([NotNull] Java8Parser.StaticImportOnDemandDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.staticImportOnDemandDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticImportOnDemandDeclaration([NotNull] Java8Parser.StaticImportOnDemandDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDeclaration([NotNull] Java8Parser.TypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDeclaration([NotNull] Java8Parser.TypeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] Java8Parser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] Java8Parser.ClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalClassDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalClassDeclaration([NotNull] Java8Parser.NormalClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalClassDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalClassDeclaration([NotNull] Java8Parser.NormalClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassModifier([NotNull] Java8Parser.ClassModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassModifier([NotNull] Java8Parser.ClassModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameters([NotNull] Java8Parser.TypeParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameters([NotNull] Java8Parser.TypeParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterList([NotNull] Java8Parser.TypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterList([NotNull] Java8Parser.TypeParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.superclass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuperclass([NotNull] Java8Parser.SuperclassContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.superclass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuperclass([NotNull] Java8Parser.SuperclassContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.superinterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuperinterfaces([NotNull] Java8Parser.SuperinterfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.superinterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuperinterfaces([NotNull] Java8Parser.SuperinterfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceTypeList([NotNull] Java8Parser.InterfaceTypeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceTypeList([NotNull] Java8Parser.InterfaceTypeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBody([NotNull] Java8Parser.ClassBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBody([NotNull] Java8Parser.ClassBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBodyDeclaration([NotNull] Java8Parser.ClassBodyDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBodyDeclaration([NotNull] Java8Parser.ClassBodyDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassMemberDeclaration([NotNull] Java8Parser.ClassMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassMemberDeclaration([NotNull] Java8Parser.ClassMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldDeclaration([NotNull] Java8Parser.FieldDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldDeclaration([NotNull] Java8Parser.FieldDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldModifier([NotNull] Java8Parser.FieldModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldModifier([NotNull] Java8Parser.FieldModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaratorList([NotNull] Java8Parser.VariableDeclaratorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaratorList([NotNull] Java8Parser.VariableDeclaratorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarator([NotNull] Java8Parser.VariableDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarator([NotNull] Java8Parser.VariableDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaratorId([NotNull] Java8Parser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaratorId([NotNull] Java8Parser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializer([NotNull] Java8Parser.VariableInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializer([NotNull] Java8Parser.VariableInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannType([NotNull] Java8Parser.UnannTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannType([NotNull] Java8Parser.UnannTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannPrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannPrimitiveType([NotNull] Java8Parser.UnannPrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannPrimitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannPrimitiveType([NotNull] Java8Parser.UnannPrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannReferenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannReferenceType([NotNull] Java8Parser.UnannReferenceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannReferenceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannReferenceType([NotNull] Java8Parser.UnannReferenceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassOrInterfaceType([NotNull] Java8Parser.UnannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassOrInterfaceType([NotNull] Java8Parser.UnannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType([NotNull] Java8Parser.UnannClassTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType([NotNull] Java8Parser.UnannClassTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType([NotNull] Java8Parser.UnannInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType([NotNull] Java8Parser.UnannInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannTypeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannTypeVariable([NotNull] Java8Parser.UnannTypeVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannTypeVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannTypeVariable([NotNull] Java8Parser.UnannTypeVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannArrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnannArrayType([NotNull] Java8Parser.UnannArrayTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannArrayType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnannArrayType([NotNull] Java8Parser.UnannArrayTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclaration([NotNull] Java8Parser.MethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclaration([NotNull] Java8Parser.MethodDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodModifier([NotNull] Java8Parser.MethodModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodModifier([NotNull] Java8Parser.MethodModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodHeader([NotNull] Java8Parser.MethodHeaderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodHeader"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodHeader([NotNull] Java8Parser.MethodHeaderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult([NotNull] Java8Parser.ResultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult([NotNull] Java8Parser.ResultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclarator([NotNull] Java8Parser.MethodDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclarator([NotNull] Java8Parser.MethodDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterList([NotNull] Java8Parser.FormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterList([NotNull] Java8Parser.FormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameters([NotNull] Java8Parser.FormalParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameters([NotNull] Java8Parser.FormalParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameter([NotNull] Java8Parser.FormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameter([NotNull] Java8Parser.FormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableModifier([NotNull] Java8Parser.VariableModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableModifier([NotNull] Java8Parser.VariableModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLastFormalParameter([NotNull] Java8Parser.LastFormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLastFormalParameter([NotNull] Java8Parser.LastFormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.receiverParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReceiverParameter([NotNull] Java8Parser.ReceiverParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.receiverParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReceiverParameter([NotNull] Java8Parser.ReceiverParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.throws_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrows_([NotNull] Java8Parser.Throws_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.throws_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrows_([NotNull] Java8Parser.Throws_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exceptionTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionTypeList([NotNull] Java8Parser.ExceptionTypeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exceptionTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionTypeList([NotNull] Java8Parser.ExceptionTypeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exceptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionType([NotNull] Java8Parser.ExceptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exceptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionType([NotNull] Java8Parser.ExceptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] Java8Parser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] Java8Parser.MethodBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.instanceInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceInitializer([NotNull] Java8Parser.InstanceInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.instanceInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceInitializer([NotNull] Java8Parser.InstanceInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.staticInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticInitializer([NotNull] Java8Parser.StaticInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.staticInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticInitializer([NotNull] Java8Parser.StaticInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDeclaration([NotNull] Java8Parser.ConstructorDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDeclaration([NotNull] Java8Parser.ConstructorDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorModifier([NotNull] Java8Parser.ConstructorModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorModifier([NotNull] Java8Parser.ConstructorModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDeclarator([NotNull] Java8Parser.ConstructorDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDeclarator([NotNull] Java8Parser.ConstructorDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.simpleTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleTypeName([NotNull] Java8Parser.SimpleTypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.simpleTypeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleTypeName([NotNull] Java8Parser.SimpleTypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorBody([NotNull] Java8Parser.ConstructorBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorBody([NotNull] Java8Parser.ConstructorBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.explicitConstructorInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicitConstructorInvocation([NotNull] Java8Parser.ExplicitConstructorInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.explicitConstructorInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicitConstructorInvocation([NotNull] Java8Parser.ExplicitConstructorInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumDeclaration([NotNull] Java8Parser.EnumDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumDeclaration([NotNull] Java8Parser.EnumDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBody([NotNull] Java8Parser.EnumBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBody([NotNull] Java8Parser.EnumBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantList([NotNull] Java8Parser.EnumConstantListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantList([NotNull] Java8Parser.EnumConstantListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstant([NotNull] Java8Parser.EnumConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstant([NotNull] Java8Parser.EnumConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantModifier([NotNull] Java8Parser.EnumConstantModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantModifier([NotNull] Java8Parser.EnumConstantModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumBodyDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBodyDeclarations([NotNull] Java8Parser.EnumBodyDeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumBodyDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBodyDeclarations([NotNull] Java8Parser.EnumBodyDeclarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceDeclaration([NotNull] Java8Parser.InterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceDeclaration([NotNull] Java8Parser.InterfaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalInterfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalInterfaceDeclaration([NotNull] Java8Parser.NormalInterfaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalInterfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalInterfaceDeclaration([NotNull] Java8Parser.NormalInterfaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceModifier([NotNull] Java8Parser.InterfaceModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceModifier([NotNull] Java8Parser.InterfaceModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.extendsInterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtendsInterfaces([NotNull] Java8Parser.ExtendsInterfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.extendsInterfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtendsInterfaces([NotNull] Java8Parser.ExtendsInterfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceBody([NotNull] Java8Parser.InterfaceBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceBody([NotNull] Java8Parser.InterfaceBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMemberDeclaration([NotNull] Java8Parser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMemberDeclaration([NotNull] Java8Parser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantDeclaration([NotNull] Java8Parser.ConstantDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantDeclaration([NotNull] Java8Parser.ConstantDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantModifier([NotNull] Java8Parser.ConstantModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantModifier([NotNull] Java8Parser.ConstantModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMethodDeclaration([NotNull] Java8Parser.InterfaceMethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMethodDeclaration([NotNull] Java8Parser.InterfaceMethodDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMethodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceMethodModifier([NotNull] Java8Parser.InterfaceMethodModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMethodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceMethodModifier([NotNull] Java8Parser.InterfaceMethodModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeDeclaration([NotNull] Java8Parser.AnnotationTypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeDeclaration([NotNull] Java8Parser.AnnotationTypeDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeBody([NotNull] Java8Parser.AnnotationTypeBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeBody([NotNull] Java8Parser.AnnotationTypeBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeMemberDeclaration([NotNull] Java8Parser.AnnotationTypeMemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeMemberDeclaration([NotNull] Java8Parser.AnnotationTypeMemberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeElementDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeElementDeclaration([NotNull] Java8Parser.AnnotationTypeElementDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeElementDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeElementDeclaration([NotNull] Java8Parser.AnnotationTypeElementDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeElementModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotationTypeElementModifier([NotNull] Java8Parser.AnnotationTypeElementModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeElementModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotationTypeElementModifier([NotNull] Java8Parser.AnnotationTypeElementModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.defaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultValue([NotNull] Java8Parser.DefaultValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.defaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultValue([NotNull] Java8Parser.DefaultValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnnotation([NotNull] Java8Parser.AnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnnotation([NotNull] Java8Parser.AnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNormalAnnotation([NotNull] Java8Parser.NormalAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNormalAnnotation([NotNull] Java8Parser.NormalAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValuePairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValuePairList([NotNull] Java8Parser.ElementValuePairListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValuePairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValuePairList([NotNull] Java8Parser.ElementValuePairListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValuePair([NotNull] Java8Parser.ElementValuePairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValuePair([NotNull] Java8Parser.ElementValuePairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValue([NotNull] Java8Parser.ElementValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValue([NotNull] Java8Parser.ElementValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValueArrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValueArrayInitializer([NotNull] Java8Parser.ElementValueArrayInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValueArrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValueArrayInitializer([NotNull] Java8Parser.ElementValueArrayInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementValueList([NotNull] Java8Parser.ElementValueListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementValueList([NotNull] Java8Parser.ElementValueListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.markerAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMarkerAnnotation([NotNull] Java8Parser.MarkerAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.markerAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMarkerAnnotation([NotNull] Java8Parser.MarkerAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleElementAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleElementAnnotation([NotNull] Java8Parser.SingleElementAnnotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleElementAnnotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleElementAnnotation([NotNull] Java8Parser.SingleElementAnnotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayInitializer([NotNull] Java8Parser.ArrayInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayInitializer([NotNull] Java8Parser.ArrayInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializerList([NotNull] Java8Parser.VariableInitializerListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableInitializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializerList([NotNull] Java8Parser.VariableInitializerListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] Java8Parser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] Java8Parser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.blockStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatements([NotNull] Java8Parser.BlockStatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.blockStatements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatements([NotNull] Java8Parser.BlockStatementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatement([NotNull] Java8Parser.BlockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatement([NotNull] Java8Parser.BlockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.localVariableDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclarationStatement([NotNull] Java8Parser.LocalVariableDeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.localVariableDeclarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclarationStatement([NotNull] Java8Parser.LocalVariableDeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclaration([NotNull] Java8Parser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclaration([NotNull] Java8Parser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] Java8Parser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] Java8Parser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementNoShortIf([NotNull] Java8Parser.StatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementNoShortIf([NotNull] Java8Parser.StatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementWithoutTrailingSubstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementWithoutTrailingSubstatement([NotNull] Java8Parser.StatementWithoutTrailingSubstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementWithoutTrailingSubstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementWithoutTrailingSubstatement([NotNull] Java8Parser.StatementWithoutTrailingSubstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement_([NotNull] Java8Parser.EmptyStatement_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement_([NotNull] Java8Parser.EmptyStatement_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledStatement([NotNull] Java8Parser.LabeledStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledStatement([NotNull] Java8Parser.LabeledStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.labeledStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledStatementNoShortIf([NotNull] Java8Parser.LabeledStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.labeledStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledStatementNoShortIf([NotNull] Java8Parser.LabeledStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] Java8Parser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] Java8Parser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpression([NotNull] Java8Parser.StatementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpression([NotNull] Java8Parser.StatementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenStatement([NotNull] Java8Parser.IfThenStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenStatement([NotNull] Java8Parser.IfThenStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenElseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenElseStatement([NotNull] Java8Parser.IfThenElseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenElseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenElseStatement([NotNull] Java8Parser.IfThenElseStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenElseStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfThenElseStatementNoShortIf([NotNull] Java8Parser.IfThenElseStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenElseStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfThenElseStatementNoShortIf([NotNull] Java8Parser.IfThenElseStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssertStatement([NotNull] Java8Parser.AssertStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssertStatement([NotNull] Java8Parser.AssertStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchStatement([NotNull] Java8Parser.SwitchStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchStatement([NotNull] Java8Parser.SwitchStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchBlock([NotNull] Java8Parser.SwitchBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchBlock([NotNull] Java8Parser.SwitchBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchBlockStatementGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchBlockStatementGroup([NotNull] Java8Parser.SwitchBlockStatementGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchBlockStatementGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchBlockStatementGroup([NotNull] Java8Parser.SwitchBlockStatementGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchLabels([NotNull] Java8Parser.SwitchLabelsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchLabels([NotNull] Java8Parser.SwitchLabelsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchLabel([NotNull] Java8Parser.SwitchLabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchLabel([NotNull] Java8Parser.SwitchLabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumConstantName([NotNull] Java8Parser.EnumConstantNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumConstantName([NotNull] Java8Parser.EnumConstantNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] Java8Parser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] Java8Parser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.whileStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatementNoShortIf([NotNull] Java8Parser.WhileStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.whileStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatementNoShortIf([NotNull] Java8Parser.WhileStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoStatement([NotNull] Java8Parser.DoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoStatement([NotNull] Java8Parser.DoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] Java8Parser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] Java8Parser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatementNoShortIf([NotNull] Java8Parser.ForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatementNoShortIf([NotNull] Java8Parser.ForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.basicForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicForStatement([NotNull] Java8Parser.BasicForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.basicForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicForStatement([NotNull] Java8Parser.BasicForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.basicForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasicForStatementNoShortIf([NotNull] Java8Parser.BasicForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.basicForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasicForStatementNoShortIf([NotNull] Java8Parser.BasicForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForInit([NotNull] Java8Parser.ForInitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForInit([NotNull] Java8Parser.ForInitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForUpdate([NotNull] Java8Parser.ForUpdateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForUpdate([NotNull] Java8Parser.ForUpdateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpressionList([NotNull] Java8Parser.StatementExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpressionList([NotNull] Java8Parser.StatementExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enhancedForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnhancedForStatement([NotNull] Java8Parser.EnhancedForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enhancedForStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnhancedForStatement([NotNull] Java8Parser.EnhancedForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enhancedForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnhancedForStatementNoShortIf([NotNull] Java8Parser.EnhancedForStatementNoShortIfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enhancedForStatementNoShortIf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnhancedForStatementNoShortIf([NotNull] Java8Parser.EnhancedForStatementNoShortIfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakStatement([NotNull] Java8Parser.BreakStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakStatement([NotNull] Java8Parser.BreakStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinueStatement([NotNull] Java8Parser.ContinueStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinueStatement([NotNull] Java8Parser.ContinueStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] Java8Parser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] Java8Parser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] Java8Parser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] Java8Parser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.synchronizedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSynchronizedStatement([NotNull] Java8Parser.SynchronizedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.synchronizedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSynchronizedStatement([NotNull] Java8Parser.SynchronizedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryStatement([NotNull] Java8Parser.TryStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryStatement([NotNull] Java8Parser.TryStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatches([NotNull] Java8Parser.CatchesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatches([NotNull] Java8Parser.CatchesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchClause([NotNull] Java8Parser.CatchClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchClause([NotNull] Java8Parser.CatchClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchFormalParameter([NotNull] Java8Parser.CatchFormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchFormalParameter([NotNull] Java8Parser.CatchFormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchType([NotNull] Java8Parser.CatchTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchType([NotNull] Java8Parser.CatchTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.finally_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFinally_([NotNull] Java8Parser.Finally_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.finally_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFinally_([NotNull] Java8Parser.Finally_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.tryWithResourcesStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryWithResourcesStatement([NotNull] Java8Parser.TryWithResourcesStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.tryWithResourcesStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryWithResourcesStatement([NotNull] Java8Parser.TryWithResourcesStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resourceSpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceSpecification([NotNull] Java8Parser.ResourceSpecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resourceSpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceSpecification([NotNull] Java8Parser.ResourceSpecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceList([NotNull] Java8Parser.ResourceListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resourceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceList([NotNull] Java8Parser.ResourceListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResource([NotNull] Java8Parser.ResourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResource([NotNull] Java8Parser.ResourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary([NotNull] Java8Parser.PrimaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary([NotNull] Java8Parser.PrimaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray([NotNull] Java8Parser.PrimaryNoNewArrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray([NotNull] Java8Parser.PrimaryNoNewArrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lf_arrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lf_arrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lfno_arrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lfno_arrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression([NotNull] Java8Parser.ClassInstanceCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression([NotNull] Java8Parser.ClassInstanceCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression_lf_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression_lf_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassInstanceCreationExpression_lfno_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassInstanceCreationExpression_lfno_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeArgumentsOrDiamond([NotNull] Java8Parser.TypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeArgumentsOrDiamond([NotNull] Java8Parser.TypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess([NotNull] Java8Parser.FieldAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess([NotNull] Java8Parser.FieldAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess_lf_primary([NotNull] Java8Parser.FieldAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess_lf_primary([NotNull] Java8Parser.FieldAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess_lfno_primary([NotNull] Java8Parser.FieldAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess_lfno_primary([NotNull] Java8Parser.FieldAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess([NotNull] Java8Parser.ArrayAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess([NotNull] Java8Parser.ArrayAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess_lf_primary([NotNull] Java8Parser.ArrayAccess_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess_lf_primary([NotNull] Java8Parser.ArrayAccess_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayAccess_lfno_primary([NotNull] Java8Parser.ArrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayAccess_lfno_primary([NotNull] Java8Parser.ArrayAccess_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation([NotNull] Java8Parser.MethodInvocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation([NotNull] Java8Parser.MethodInvocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation_lf_primary([NotNull] Java8Parser.MethodInvocation_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation_lf_primary([NotNull] Java8Parser.MethodInvocation_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodInvocation_lfno_primary([NotNull] Java8Parser.MethodInvocation_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodInvocation_lfno_primary([NotNull] Java8Parser.MethodInvocation_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentList([NotNull] Java8Parser.ArgumentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentList([NotNull] Java8Parser.ArgumentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference([NotNull] Java8Parser.MethodReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference([NotNull] Java8Parser.MethodReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference_lf_primary([NotNull] Java8Parser.MethodReference_lf_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference_lf_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference_lf_primary([NotNull] Java8Parser.MethodReference_lf_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodReference_lfno_primary([NotNull] Java8Parser.MethodReference_lfno_primaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference_lfno_primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodReference_lfno_primary([NotNull] Java8Parser.MethodReference_lfno_primaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayCreationExpression([NotNull] Java8Parser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayCreationExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayCreationExpression([NotNull] Java8Parser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dimExprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDimExprs([NotNull] Java8Parser.DimExprsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dimExprs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDimExprs([NotNull] Java8Parser.DimExprsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dimExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDimExpr([NotNull] Java8Parser.DimExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dimExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDimExpr([NotNull] Java8Parser.DimExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] Java8Parser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] Java8Parser.ConstantExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] Java8Parser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] Java8Parser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaExpression([NotNull] Java8Parser.LambdaExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaExpression([NotNull] Java8Parser.LambdaExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaParameters([NotNull] Java8Parser.LambdaParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaParameters([NotNull] Java8Parser.LambdaParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.inferredFormalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInferredFormalParameterList([NotNull] Java8Parser.InferredFormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.inferredFormalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInferredFormalParameterList([NotNull] Java8Parser.InferredFormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaBody([NotNull] Java8Parser.LambdaBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaBody([NotNull] Java8Parser.LambdaBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] Java8Parser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] Java8Parser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] Java8Parser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] Java8Parser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.leftHandSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeftHandSide([NotNull] Java8Parser.LeftHandSideContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.leftHandSide"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeftHandSide([NotNull] Java8Parser.LeftHandSideContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] Java8Parser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] Java8Parser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalExpression([NotNull] Java8Parser.ConditionalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalExpression([NotNull] Java8Parser.ConditionalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalOrExpression([NotNull] Java8Parser.ConditionalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalOrExpression([NotNull] Java8Parser.ConditionalOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalAndExpression([NotNull] Java8Parser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalAndExpression([NotNull] Java8Parser.ConditionalAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclusiveOrExpression([NotNull] Java8Parser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclusiveOrExpression([NotNull] Java8Parser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusiveOrExpression([NotNull] Java8Parser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusiveOrExpression([NotNull] Java8Parser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] Java8Parser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] Java8Parser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] Java8Parser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] Java8Parser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] Java8Parser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] Java8Parser.RelationalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftExpression([NotNull] Java8Parser.ShiftExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftExpression([NotNull] Java8Parser.ShiftExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] Java8Parser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] Java8Parser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] Java8Parser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] Java8Parser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] Java8Parser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] Java8Parser.UnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.preIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreIncrementExpression([NotNull] Java8Parser.PreIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.preIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreIncrementExpression([NotNull] Java8Parser.PreIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.preDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreDecrementExpression([NotNull] Java8Parser.PreDecrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.preDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreDecrementExpression([NotNull] Java8Parser.PreDecrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unaryExpressionNotPlusMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpressionNotPlusMinus([NotNull] Java8Parser.UnaryExpressionNotPlusMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unaryExpressionNotPlusMinus"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpressionNotPlusMinus([NotNull] Java8Parser.UnaryExpressionNotPlusMinusContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixExpression([NotNull] Java8Parser.PostfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixExpression([NotNull] Java8Parser.PostfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostIncrementExpression([NotNull] Java8Parser.PostIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postIncrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostIncrementExpression([NotNull] Java8Parser.PostIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostIncrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostIncrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostIncrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostIncrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostDecrementExpression([NotNull] Java8Parser.PostDecrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postDecrementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostDecrementExpression([NotNull] Java8Parser.PostDecrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostDecrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostDecrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostDecrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostDecrementExpression_lf_postfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastExpression([NotNull] Java8Parser.CastExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastExpression([NotNull] Java8Parser.CastExpressionContext context);
}
