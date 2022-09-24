using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IJava8ParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class Java8ParserBaseListener : IJava8ParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] Java8Parser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] Java8Parser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitiveType([NotNull] Java8Parser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitiveType([NotNull] Java8Parser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.numericType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericType([NotNull] Java8Parser.NumericTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.numericType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericType([NotNull] Java8Parser.NumericTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.integralType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntegralType([NotNull] Java8Parser.IntegralTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.integralType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntegralType([NotNull] Java8Parser.IntegralTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.floatingPointType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloatingPointType([NotNull] Java8Parser.FloatingPointTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.floatingPointType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloatingPointType([NotNull] Java8Parser.FloatingPointTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.referenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferenceType([NotNull] Java8Parser.ReferenceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.referenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferenceType([NotNull] Java8Parser.ReferenceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassOrInterfaceType([NotNull] Java8Parser.ClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassOrInterfaceType([NotNull] Java8Parser.ClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType([NotNull] Java8Parser.ClassTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType([NotNull] Java8Parser.ClassTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType_lf_classOrInterfaceType([NotNull] Java8Parser.ClassType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType_lf_classOrInterfaceType([NotNull] Java8Parser.ClassType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType_lfno_classOrInterfaceType([NotNull] Java8Parser.ClassType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType_lfno_classOrInterfaceType([NotNull] Java8Parser.ClassType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType([NotNull] Java8Parser.InterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType([NotNull] Java8Parser.InterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType_lf_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType_lf_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType_lfno_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType_lfno_classOrInterfaceType([NotNull] Java8Parser.InterfaceType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeVariable([NotNull] Java8Parser.TypeVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeVariable([NotNull] Java8Parser.TypeVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayType([NotNull] Java8Parser.ArrayTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayType([NotNull] Java8Parser.ArrayTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dims"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDims([NotNull] Java8Parser.DimsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dims"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDims([NotNull] Java8Parser.DimsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameter([NotNull] Java8Parser.TypeParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameter([NotNull] Java8Parser.TypeParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameterModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterModifier([NotNull] Java8Parser.TypeParameterModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameterModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterModifier([NotNull] Java8Parser.TypeParameterModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeBound([NotNull] Java8Parser.TypeBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeBound([NotNull] Java8Parser.TypeBoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.additionalBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditionalBound([NotNull] Java8Parser.AdditionalBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.additionalBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditionalBound([NotNull] Java8Parser.AdditionalBoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArguments([NotNull] Java8Parser.TypeArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArguments([NotNull] Java8Parser.TypeArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgumentList([NotNull] Java8Parser.TypeArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgumentList([NotNull] Java8Parser.TypeArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgument([NotNull] Java8Parser.TypeArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgument([NotNull] Java8Parser.TypeArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.wildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWildcard([NotNull] Java8Parser.WildcardContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.wildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWildcard([NotNull] Java8Parser.WildcardContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.wildcardBounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWildcardBounds([NotNull] Java8Parser.WildcardBoundsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.wildcardBounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWildcardBounds([NotNull] Java8Parser.WildcardBoundsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageName([NotNull] Java8Parser.PackageNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageName([NotNull] Java8Parser.PackageNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeName([NotNull] Java8Parser.TypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeName([NotNull] Java8Parser.TypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageOrTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageOrTypeName([NotNull] Java8Parser.PackageOrTypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageOrTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageOrTypeName([NotNull] Java8Parser.PackageOrTypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expressionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionName([NotNull] Java8Parser.ExpressionNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expressionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionName([NotNull] Java8Parser.ExpressionNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodName([NotNull] Java8Parser.MethodNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodName([NotNull] Java8Parser.MethodNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ambiguousName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAmbiguousName([NotNull] Java8Parser.AmbiguousNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ambiguousName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAmbiguousName([NotNull] Java8Parser.AmbiguousNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] Java8Parser.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] Java8Parser.CompilationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDeclaration([NotNull] Java8Parser.PackageDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDeclaration([NotNull] Java8Parser.PackageDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.packageModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageModifier([NotNull] Java8Parser.PackageModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.packageModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageModifier([NotNull] Java8Parser.PackageModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.importDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportDeclaration([NotNull] Java8Parser.ImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.importDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportDeclaration([NotNull] Java8Parser.ImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleTypeImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleTypeImportDeclaration([NotNull] Java8Parser.SingleTypeImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleTypeImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleTypeImportDeclaration([NotNull] Java8Parser.SingleTypeImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeImportOnDemandDeclaration([NotNull] Java8Parser.TypeImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeImportOnDemandDeclaration([NotNull] Java8Parser.TypeImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleStaticImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleStaticImportDeclaration([NotNull] Java8Parser.SingleStaticImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleStaticImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleStaticImportDeclaration([NotNull] Java8Parser.SingleStaticImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.staticImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticImportOnDemandDeclaration([NotNull] Java8Parser.StaticImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.staticImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticImportOnDemandDeclaration([NotNull] Java8Parser.StaticImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeDeclaration([NotNull] Java8Parser.TypeDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeDeclaration([NotNull] Java8Parser.TypeDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDeclaration([NotNull] Java8Parser.ClassDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDeclaration([NotNull] Java8Parser.ClassDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalClassDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalClassDeclaration([NotNull] Java8Parser.NormalClassDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalClassDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalClassDeclaration([NotNull] Java8Parser.NormalClassDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassModifier([NotNull] Java8Parser.ClassModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassModifier([NotNull] Java8Parser.ClassModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameters([NotNull] Java8Parser.TypeParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameters([NotNull] Java8Parser.TypeParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterList([NotNull] Java8Parser.TypeParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterList([NotNull] Java8Parser.TypeParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.superclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSuperclass([NotNull] Java8Parser.SuperclassContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.superclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSuperclass([NotNull] Java8Parser.SuperclassContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.superinterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSuperinterfaces([NotNull] Java8Parser.SuperinterfacesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.superinterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSuperinterfaces([NotNull] Java8Parser.SuperinterfacesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceTypeList([NotNull] Java8Parser.InterfaceTypeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceTypeList([NotNull] Java8Parser.InterfaceTypeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassBody([NotNull] Java8Parser.ClassBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassBody([NotNull] Java8Parser.ClassBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classBodyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassBodyDeclaration([NotNull] Java8Parser.ClassBodyDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classBodyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassBodyDeclaration([NotNull] Java8Parser.ClassBodyDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassMemberDeclaration([NotNull] Java8Parser.ClassMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassMemberDeclaration([NotNull] Java8Parser.ClassMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldDeclaration([NotNull] Java8Parser.FieldDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldDeclaration([NotNull] Java8Parser.FieldDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldModifier([NotNull] Java8Parser.FieldModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldModifier([NotNull] Java8Parser.FieldModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaratorList([NotNull] Java8Parser.VariableDeclaratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaratorList([NotNull] Java8Parser.VariableDeclaratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclarator([NotNull] Java8Parser.VariableDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclarator([NotNull] Java8Parser.VariableDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaratorId([NotNull] Java8Parser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaratorId([NotNull] Java8Parser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializer([NotNull] Java8Parser.VariableInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializer([NotNull] Java8Parser.VariableInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannType([NotNull] Java8Parser.UnannTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannType([NotNull] Java8Parser.UnannTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannPrimitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannPrimitiveType([NotNull] Java8Parser.UnannPrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannPrimitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannPrimitiveType([NotNull] Java8Parser.UnannPrimitiveTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannReferenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannReferenceType([NotNull] Java8Parser.UnannReferenceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannReferenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannReferenceType([NotNull] Java8Parser.UnannReferenceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassOrInterfaceType([NotNull] Java8Parser.UnannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassOrInterfaceType([NotNull] Java8Parser.UnannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType([NotNull] Java8Parser.UnannClassTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType([NotNull] Java8Parser.UnannClassTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType([NotNull] Java8Parser.UnannInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType([NotNull] Java8Parser.UnannInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java8Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannTypeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannTypeVariable([NotNull] Java8Parser.UnannTypeVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannTypeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannTypeVariable([NotNull] Java8Parser.UnannTypeVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unannArrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannArrayType([NotNull] Java8Parser.UnannArrayTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unannArrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannArrayType([NotNull] Java8Parser.UnannArrayTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDeclaration([NotNull] Java8Parser.MethodDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDeclaration([NotNull] Java8Parser.MethodDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodModifier([NotNull] Java8Parser.MethodModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodModifier([NotNull] Java8Parser.MethodModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodHeader([NotNull] Java8Parser.MethodHeaderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodHeader([NotNull] Java8Parser.MethodHeaderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult([NotNull] Java8Parser.ResultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult([NotNull] Java8Parser.ResultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDeclarator([NotNull] Java8Parser.MethodDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDeclarator([NotNull] Java8Parser.MethodDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameterList([NotNull] Java8Parser.FormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameterList([NotNull] Java8Parser.FormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameters([NotNull] Java8Parser.FormalParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameters([NotNull] Java8Parser.FormalParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameter([NotNull] Java8Parser.FormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameter([NotNull] Java8Parser.FormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableModifier([NotNull] Java8Parser.VariableModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableModifier([NotNull] Java8Parser.VariableModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lastFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLastFormalParameter([NotNull] Java8Parser.LastFormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lastFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLastFormalParameter([NotNull] Java8Parser.LastFormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.receiverParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReceiverParameter([NotNull] Java8Parser.ReceiverParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.receiverParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReceiverParameter([NotNull] Java8Parser.ReceiverParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.throws_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrows_([NotNull] Java8Parser.Throws_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.throws_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrows_([NotNull] Java8Parser.Throws_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exceptionTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptionTypeList([NotNull] Java8Parser.ExceptionTypeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exceptionTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptionTypeList([NotNull] Java8Parser.ExceptionTypeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exceptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptionType([NotNull] Java8Parser.ExceptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exceptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptionType([NotNull] Java8Parser.ExceptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodBody([NotNull] Java8Parser.MethodBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodBody([NotNull] Java8Parser.MethodBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.instanceInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstanceInitializer([NotNull] Java8Parser.InstanceInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.instanceInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstanceInitializer([NotNull] Java8Parser.InstanceInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.staticInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticInitializer([NotNull] Java8Parser.StaticInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.staticInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticInitializer([NotNull] Java8Parser.StaticInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorDeclaration([NotNull] Java8Parser.ConstructorDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorDeclaration([NotNull] Java8Parser.ConstructorDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorModifier([NotNull] Java8Parser.ConstructorModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorModifier([NotNull] Java8Parser.ConstructorModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorDeclarator([NotNull] Java8Parser.ConstructorDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorDeclarator([NotNull] Java8Parser.ConstructorDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.simpleTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleTypeName([NotNull] Java8Parser.SimpleTypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.simpleTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleTypeName([NotNull] Java8Parser.SimpleTypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constructorBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorBody([NotNull] Java8Parser.ConstructorBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constructorBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorBody([NotNull] Java8Parser.ConstructorBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.explicitConstructorInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicitConstructorInvocation([NotNull] Java8Parser.ExplicitConstructorInvocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.explicitConstructorInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicitConstructorInvocation([NotNull] Java8Parser.ExplicitConstructorInvocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumDeclaration([NotNull] Java8Parser.EnumDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumDeclaration([NotNull] Java8Parser.EnumDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumBody([NotNull] Java8Parser.EnumBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumBody([NotNull] Java8Parser.EnumBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantList([NotNull] Java8Parser.EnumConstantListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantList([NotNull] Java8Parser.EnumConstantListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstant([NotNull] Java8Parser.EnumConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstant([NotNull] Java8Parser.EnumConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantModifier([NotNull] Java8Parser.EnumConstantModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantModifier([NotNull] Java8Parser.EnumConstantModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumBodyDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumBodyDeclarations([NotNull] Java8Parser.EnumBodyDeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumBodyDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumBodyDeclarations([NotNull] Java8Parser.EnumBodyDeclarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceDeclaration([NotNull] Java8Parser.InterfaceDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceDeclaration([NotNull] Java8Parser.InterfaceDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalInterfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalInterfaceDeclaration([NotNull] Java8Parser.NormalInterfaceDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalInterfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalInterfaceDeclaration([NotNull] Java8Parser.NormalInterfaceDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceModifier([NotNull] Java8Parser.InterfaceModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceModifier([NotNull] Java8Parser.InterfaceModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.extendsInterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtendsInterfaces([NotNull] Java8Parser.ExtendsInterfacesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.extendsInterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtendsInterfaces([NotNull] Java8Parser.ExtendsInterfacesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceBody([NotNull] Java8Parser.InterfaceBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceBody([NotNull] Java8Parser.InterfaceBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMemberDeclaration([NotNull] Java8Parser.InterfaceMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMemberDeclaration([NotNull] Java8Parser.InterfaceMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantDeclaration([NotNull] Java8Parser.ConstantDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantDeclaration([NotNull] Java8Parser.ConstantDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantModifier([NotNull] Java8Parser.ConstantModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantModifier([NotNull] Java8Parser.ConstantModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMethodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMethodDeclaration([NotNull] Java8Parser.InterfaceMethodDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMethodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMethodDeclaration([NotNull] Java8Parser.InterfaceMethodDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.interfaceMethodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMethodModifier([NotNull] Java8Parser.InterfaceMethodModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.interfaceMethodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMethodModifier([NotNull] Java8Parser.InterfaceMethodModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeDeclaration([NotNull] Java8Parser.AnnotationTypeDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeDeclaration([NotNull] Java8Parser.AnnotationTypeDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeBody([NotNull] Java8Parser.AnnotationTypeBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeBody([NotNull] Java8Parser.AnnotationTypeBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeMemberDeclaration([NotNull] Java8Parser.AnnotationTypeMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeMemberDeclaration([NotNull] Java8Parser.AnnotationTypeMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeElementDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeElementDeclaration([NotNull] Java8Parser.AnnotationTypeElementDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeElementDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeElementDeclaration([NotNull] Java8Parser.AnnotationTypeElementDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotationTypeElementModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeElementModifier([NotNull] Java8Parser.AnnotationTypeElementModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotationTypeElementModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeElementModifier([NotNull] Java8Parser.AnnotationTypeElementModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.defaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultValue([NotNull] Java8Parser.DefaultValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.defaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultValue([NotNull] Java8Parser.DefaultValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotation([NotNull] Java8Parser.AnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotation([NotNull] Java8Parser.AnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.normalAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalAnnotation([NotNull] Java8Parser.NormalAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.normalAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalAnnotation([NotNull] Java8Parser.NormalAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValuePairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValuePairList([NotNull] Java8Parser.ElementValuePairListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValuePairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValuePairList([NotNull] Java8Parser.ElementValuePairListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValuePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValuePair([NotNull] Java8Parser.ElementValuePairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValuePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValuePair([NotNull] Java8Parser.ElementValuePairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValue([NotNull] Java8Parser.ElementValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValue([NotNull] Java8Parser.ElementValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValueArrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValueArrayInitializer([NotNull] Java8Parser.ElementValueArrayInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValueArrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValueArrayInitializer([NotNull] Java8Parser.ElementValueArrayInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.elementValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValueList([NotNull] Java8Parser.ElementValueListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.elementValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValueList([NotNull] Java8Parser.ElementValueListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.markerAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMarkerAnnotation([NotNull] Java8Parser.MarkerAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.markerAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMarkerAnnotation([NotNull] Java8Parser.MarkerAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.singleElementAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleElementAnnotation([NotNull] Java8Parser.SingleElementAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.singleElementAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleElementAnnotation([NotNull] Java8Parser.SingleElementAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayInitializer([NotNull] Java8Parser.ArrayInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayInitializer([NotNull] Java8Parser.ArrayInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.variableInitializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializerList([NotNull] Java8Parser.VariableInitializerListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.variableInitializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializerList([NotNull] Java8Parser.VariableInitializerListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] Java8Parser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] Java8Parser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.blockStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatements([NotNull] Java8Parser.BlockStatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.blockStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatements([NotNull] Java8Parser.BlockStatementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatement([NotNull] Java8Parser.BlockStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatement([NotNull] Java8Parser.BlockStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.localVariableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocalVariableDeclarationStatement([NotNull] Java8Parser.LocalVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.localVariableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocalVariableDeclarationStatement([NotNull] Java8Parser.LocalVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.localVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocalVariableDeclaration([NotNull] Java8Parser.LocalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.localVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocalVariableDeclaration([NotNull] Java8Parser.LocalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] Java8Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] Java8Parser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementNoShortIf([NotNull] Java8Parser.StatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementNoShortIf([NotNull] Java8Parser.StatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementWithoutTrailingSubstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementWithoutTrailingSubstatement([NotNull] Java8Parser.StatementWithoutTrailingSubstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementWithoutTrailingSubstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementWithoutTrailingSubstatement([NotNull] Java8Parser.StatementWithoutTrailingSubstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.emptyStatement_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptyStatement_([NotNull] Java8Parser.EmptyStatement_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.emptyStatement_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptyStatement_([NotNull] Java8Parser.EmptyStatement_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledStatement([NotNull] Java8Parser.LabeledStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledStatement([NotNull] Java8Parser.LabeledStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.labeledStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledStatementNoShortIf([NotNull] Java8Parser.LabeledStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.labeledStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledStatementNoShortIf([NotNull] Java8Parser.LabeledStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] Java8Parser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] Java8Parser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementExpression([NotNull] Java8Parser.StatementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementExpression([NotNull] Java8Parser.StatementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenStatement([NotNull] Java8Parser.IfThenStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenStatement([NotNull] Java8Parser.IfThenStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenElseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenElseStatement([NotNull] Java8Parser.IfThenElseStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenElseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenElseStatement([NotNull] Java8Parser.IfThenElseStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.ifThenElseStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenElseStatementNoShortIf([NotNull] Java8Parser.IfThenElseStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.ifThenElseStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenElseStatementNoShortIf([NotNull] Java8Parser.IfThenElseStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssertStatement([NotNull] Java8Parser.AssertStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssertStatement([NotNull] Java8Parser.AssertStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchStatement([NotNull] Java8Parser.SwitchStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchStatement([NotNull] Java8Parser.SwitchStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchBlock([NotNull] Java8Parser.SwitchBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchBlock([NotNull] Java8Parser.SwitchBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchBlockStatementGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchBlockStatementGroup([NotNull] Java8Parser.SwitchBlockStatementGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchBlockStatementGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchBlockStatementGroup([NotNull] Java8Parser.SwitchBlockStatementGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchLabels([NotNull] Java8Parser.SwitchLabelsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchLabels([NotNull] Java8Parser.SwitchLabelsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.switchLabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchLabel([NotNull] Java8Parser.SwitchLabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.switchLabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchLabel([NotNull] Java8Parser.SwitchLabelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enumConstantName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantName([NotNull] Java8Parser.EnumConstantNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enumConstantName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantName([NotNull] Java8Parser.EnumConstantNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] Java8Parser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] Java8Parser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.whileStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatementNoShortIf([NotNull] Java8Parser.WhileStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.whileStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatementNoShortIf([NotNull] Java8Parser.WhileStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoStatement([NotNull] Java8Parser.DoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoStatement([NotNull] Java8Parser.DoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] Java8Parser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] Java8Parser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatementNoShortIf([NotNull] Java8Parser.ForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatementNoShortIf([NotNull] Java8Parser.ForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.basicForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasicForStatement([NotNull] Java8Parser.BasicForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.basicForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasicForStatement([NotNull] Java8Parser.BasicForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.basicForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasicForStatementNoShortIf([NotNull] Java8Parser.BasicForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.basicForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasicForStatementNoShortIf([NotNull] Java8Parser.BasicForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForInit([NotNull] Java8Parser.ForInitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForInit([NotNull] Java8Parser.ForInitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForUpdate([NotNull] Java8Parser.ForUpdateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForUpdate([NotNull] Java8Parser.ForUpdateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.statementExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementExpressionList([NotNull] Java8Parser.StatementExpressionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.statementExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementExpressionList([NotNull] Java8Parser.StatementExpressionListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enhancedForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnhancedForStatement([NotNull] Java8Parser.EnhancedForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enhancedForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnhancedForStatement([NotNull] Java8Parser.EnhancedForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.enhancedForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnhancedForStatementNoShortIf([NotNull] Java8Parser.EnhancedForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.enhancedForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnhancedForStatementNoShortIf([NotNull] Java8Parser.EnhancedForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] Java8Parser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] Java8Parser.BreakStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] Java8Parser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] Java8Parser.ContinueStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] Java8Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] Java8Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowStatement([NotNull] Java8Parser.ThrowStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowStatement([NotNull] Java8Parser.ThrowStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.synchronizedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSynchronizedStatement([NotNull] Java8Parser.SynchronizedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.synchronizedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSynchronizedStatement([NotNull] Java8Parser.SynchronizedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.tryStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryStatement([NotNull] Java8Parser.TryStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.tryStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryStatement([NotNull] Java8Parser.TryStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatches([NotNull] Java8Parser.CatchesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatches([NotNull] Java8Parser.CatchesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchClause([NotNull] Java8Parser.CatchClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchClause([NotNull] Java8Parser.CatchClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchFormalParameter([NotNull] Java8Parser.CatchFormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchFormalParameter([NotNull] Java8Parser.CatchFormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.catchType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchType([NotNull] Java8Parser.CatchTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.catchType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchType([NotNull] Java8Parser.CatchTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.finally_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFinally_([NotNull] Java8Parser.Finally_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.finally_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFinally_([NotNull] Java8Parser.Finally_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.tryWithResourcesStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryWithResourcesStatement([NotNull] Java8Parser.TryWithResourcesStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.tryWithResourcesStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryWithResourcesStatement([NotNull] Java8Parser.TryWithResourcesStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resourceSpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceSpecification([NotNull] Java8Parser.ResourceSpecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resourceSpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceSpecification([NotNull] Java8Parser.ResourceSpecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resourceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceList([NotNull] Java8Parser.ResourceListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resourceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceList([NotNull] Java8Parser.ResourceListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.resource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResource([NotNull] Java8Parser.ResourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.resource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResource([NotNull] Java8Parser.ResourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary([NotNull] Java8Parser.PrimaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary([NotNull] Java8Parser.PrimaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray([NotNull] Java8Parser.PrimaryNoNewArrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray([NotNull] Java8Parser.PrimaryNoNewArrayContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lf_arrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lf_arrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lfno_arrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java8Parser.PrimaryNoNewArray_lfno_arrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java8Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java8Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression([NotNull] Java8Parser.ClassInstanceCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression([NotNull] Java8Parser.ClassInstanceCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression_lf_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression_lf_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression_lfno_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression_lfno_primary([NotNull] Java8Parser.ClassInstanceCreationExpression_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.typeArgumentsOrDiamond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgumentsOrDiamond([NotNull] Java8Parser.TypeArgumentsOrDiamondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.typeArgumentsOrDiamond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgumentsOrDiamond([NotNull] Java8Parser.TypeArgumentsOrDiamondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess([NotNull] Java8Parser.FieldAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess([NotNull] Java8Parser.FieldAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess_lf_primary([NotNull] Java8Parser.FieldAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess_lf_primary([NotNull] Java8Parser.FieldAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.fieldAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess_lfno_primary([NotNull] Java8Parser.FieldAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.fieldAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess_lfno_primary([NotNull] Java8Parser.FieldAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess([NotNull] Java8Parser.ArrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess([NotNull] Java8Parser.ArrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess_lf_primary([NotNull] Java8Parser.ArrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess_lf_primary([NotNull] Java8Parser.ArrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess_lfno_primary([NotNull] Java8Parser.ArrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess_lfno_primary([NotNull] Java8Parser.ArrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation([NotNull] Java8Parser.MethodInvocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation([NotNull] Java8Parser.MethodInvocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation_lf_primary([NotNull] Java8Parser.MethodInvocation_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation_lf_primary([NotNull] Java8Parser.MethodInvocation_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodInvocation_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation_lfno_primary([NotNull] Java8Parser.MethodInvocation_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodInvocation_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation_lfno_primary([NotNull] Java8Parser.MethodInvocation_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentList([NotNull] Java8Parser.ArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentList([NotNull] Java8Parser.ArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference([NotNull] Java8Parser.MethodReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference([NotNull] Java8Parser.MethodReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference_lf_primary([NotNull] Java8Parser.MethodReference_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference_lf_primary([NotNull] Java8Parser.MethodReference_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.methodReference_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference_lfno_primary([NotNull] Java8Parser.MethodReference_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.methodReference_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference_lfno_primary([NotNull] Java8Parser.MethodReference_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.arrayCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayCreationExpression([NotNull] Java8Parser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.arrayCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayCreationExpression([NotNull] Java8Parser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dimExprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDimExprs([NotNull] Java8Parser.DimExprsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dimExprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDimExprs([NotNull] Java8Parser.DimExprsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.dimExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDimExpr([NotNull] Java8Parser.DimExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.dimExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDimExpr([NotNull] Java8Parser.DimExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] Java8Parser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] Java8Parser.ConstantExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] Java8Parser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] Java8Parser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaExpression([NotNull] Java8Parser.LambdaExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaExpression([NotNull] Java8Parser.LambdaExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaParameters([NotNull] Java8Parser.LambdaParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaParameters([NotNull] Java8Parser.LambdaParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.inferredFormalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInferredFormalParameterList([NotNull] Java8Parser.InferredFormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.inferredFormalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInferredFormalParameterList([NotNull] Java8Parser.InferredFormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.lambdaBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaBody([NotNull] Java8Parser.LambdaBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.lambdaBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaBody([NotNull] Java8Parser.LambdaBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] Java8Parser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] Java8Parser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] Java8Parser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] Java8Parser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.leftHandSide"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLeftHandSide([NotNull] Java8Parser.LeftHandSideContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.leftHandSide"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLeftHandSide([NotNull] Java8Parser.LeftHandSideContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperator([NotNull] Java8Parser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperator([NotNull] Java8Parser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalExpression([NotNull] Java8Parser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalExpression([NotNull] Java8Parser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalOrExpression([NotNull] Java8Parser.ConditionalOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalOrExpression([NotNull] Java8Parser.ConditionalOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.conditionalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalAndExpression([NotNull] Java8Parser.ConditionalAndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.conditionalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalAndExpression([NotNull] Java8Parser.ConditionalAndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInclusiveOrExpression([NotNull] Java8Parser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInclusiveOrExpression([NotNull] Java8Parser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusiveOrExpression([NotNull] Java8Parser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusiveOrExpression([NotNull] Java8Parser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpression([NotNull] Java8Parser.AndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpression([NotNull] Java8Parser.AndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpression([NotNull] Java8Parser.EqualityExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpression([NotNull] Java8Parser.EqualityExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] Java8Parser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] Java8Parser.RelationalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftExpression([NotNull] Java8Parser.ShiftExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftExpression([NotNull] Java8Parser.ShiftExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] Java8Parser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] Java8Parser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] Java8Parser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] Java8Parser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpression([NotNull] Java8Parser.UnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpression([NotNull] Java8Parser.UnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.preIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreIncrementExpression([NotNull] Java8Parser.PreIncrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.preIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreIncrementExpression([NotNull] Java8Parser.PreIncrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.preDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreDecrementExpression([NotNull] Java8Parser.PreDecrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.preDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreDecrementExpression([NotNull] Java8Parser.PreDecrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.unaryExpressionNotPlusMinus"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpressionNotPlusMinus([NotNull] Java8Parser.UnaryExpressionNotPlusMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.unaryExpressionNotPlusMinus"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpressionNotPlusMinus([NotNull] Java8Parser.UnaryExpressionNotPlusMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixExpression([NotNull] Java8Parser.PostfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixExpression([NotNull] Java8Parser.PostfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostIncrementExpression([NotNull] Java8Parser.PostIncrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostIncrementExpression([NotNull] Java8Parser.PostIncrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostIncrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostIncrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostIncrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostIncrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostDecrementExpression([NotNull] Java8Parser.PostDecrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostDecrementExpression([NotNull] Java8Parser.PostDecrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostDecrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostDecrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostDecrementExpression_lf_postfixExpression([NotNull] Java8Parser.PostDecrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java8Parser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpression([NotNull] Java8Parser.CastExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java8Parser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpression([NotNull] Java8Parser.CastExpressionContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
