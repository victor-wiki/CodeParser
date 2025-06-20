using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IJava9Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class Java9BaseListener : IJava9Listener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] Java9Parser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] Java9Parser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitiveType([NotNull] Java9Parser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitiveType([NotNull] Java9Parser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.numericType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericType([NotNull] Java9Parser.NumericTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.numericType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericType([NotNull] Java9Parser.NumericTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.integralType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntegralType([NotNull] Java9Parser.IntegralTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.integralType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntegralType([NotNull] Java9Parser.IntegralTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.floatingPointType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloatingPointType([NotNull] Java9Parser.FloatingPointTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.floatingPointType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloatingPointType([NotNull] Java9Parser.FloatingPointTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.referenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferenceType([NotNull] Java9Parser.ReferenceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.referenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferenceType([NotNull] Java9Parser.ReferenceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassOrInterfaceType([NotNull] Java9Parser.ClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassOrInterfaceType([NotNull] Java9Parser.ClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType([NotNull] Java9Parser.ClassTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType([NotNull] Java9Parser.ClassTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType_lf_classOrInterfaceType([NotNull] Java9Parser.ClassType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType_lf_classOrInterfaceType([NotNull] Java9Parser.ClassType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassType_lfno_classOrInterfaceType([NotNull] Java9Parser.ClassType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassType_lfno_classOrInterfaceType([NotNull] Java9Parser.ClassType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType([NotNull] Java9Parser.InterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType([NotNull] Java9Parser.InterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType_lf_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType_lf_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType_lf_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lf_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceType_lfno_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceType_lfno_classOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceType_lfno_classOrInterfaceType([NotNull] Java9Parser.InterfaceType_lfno_classOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeVariable([NotNull] Java9Parser.TypeVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeVariable([NotNull] Java9Parser.TypeVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayType([NotNull] Java9Parser.ArrayTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayType([NotNull] Java9Parser.ArrayTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dims"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDims([NotNull] Java9Parser.DimsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dims"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDims([NotNull] Java9Parser.DimsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameter([NotNull] Java9Parser.TypeParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameter([NotNull] Java9Parser.TypeParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameterModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterModifier([NotNull] Java9Parser.TypeParameterModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameterModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterModifier([NotNull] Java9Parser.TypeParameterModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeBound([NotNull] Java9Parser.TypeBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeBound([NotNull] Java9Parser.TypeBoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.additionalBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditionalBound([NotNull] Java9Parser.AdditionalBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.additionalBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditionalBound([NotNull] Java9Parser.AdditionalBoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArguments([NotNull] Java9Parser.TypeArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArguments([NotNull] Java9Parser.TypeArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgumentList([NotNull] Java9Parser.TypeArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgumentList([NotNull] Java9Parser.TypeArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgument([NotNull] Java9Parser.TypeArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgument([NotNull] Java9Parser.TypeArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.wildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWildcard([NotNull] Java9Parser.WildcardContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.wildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWildcard([NotNull] Java9Parser.WildcardContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.wildcardBounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWildcardBounds([NotNull] Java9Parser.WildcardBoundsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.wildcardBounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWildcardBounds([NotNull] Java9Parser.WildcardBoundsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModuleName([NotNull] Java9Parser.ModuleNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModuleName([NotNull] Java9Parser.ModuleNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageName([NotNull] Java9Parser.PackageNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageName([NotNull] Java9Parser.PackageNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeName([NotNull] Java9Parser.TypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeName([NotNull] Java9Parser.TypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageOrTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageOrTypeName([NotNull] Java9Parser.PackageOrTypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageOrTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageOrTypeName([NotNull] Java9Parser.PackageOrTypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expressionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionName([NotNull] Java9Parser.ExpressionNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expressionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionName([NotNull] Java9Parser.ExpressionNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodName([NotNull] Java9Parser.MethodNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodName([NotNull] Java9Parser.MethodNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ambiguousName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAmbiguousName([NotNull] Java9Parser.AmbiguousNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ambiguousName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAmbiguousName([NotNull] Java9Parser.AmbiguousNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] Java9Parser.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] Java9Parser.CompilationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ordinaryCompilation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrdinaryCompilation([NotNull] Java9Parser.OrdinaryCompilationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ordinaryCompilation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrdinaryCompilation([NotNull] Java9Parser.OrdinaryCompilationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.modularCompilation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModularCompilation([NotNull] Java9Parser.ModularCompilationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.modularCompilation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModularCompilation([NotNull] Java9Parser.ModularCompilationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageDeclaration([NotNull] Java9Parser.PackageDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageDeclaration([NotNull] Java9Parser.PackageDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.packageModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackageModifier([NotNull] Java9Parser.PackageModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.packageModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackageModifier([NotNull] Java9Parser.PackageModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.importDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportDeclaration([NotNull] Java9Parser.ImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.importDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportDeclaration([NotNull] Java9Parser.ImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleTypeImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleTypeImportDeclaration([NotNull] Java9Parser.SingleTypeImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleTypeImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleTypeImportDeclaration([NotNull] Java9Parser.SingleTypeImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeImportOnDemandDeclaration([NotNull] Java9Parser.TypeImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeImportOnDemandDeclaration([NotNull] Java9Parser.TypeImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleStaticImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleStaticImportDeclaration([NotNull] Java9Parser.SingleStaticImportDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleStaticImportDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleStaticImportDeclaration([NotNull] Java9Parser.SingleStaticImportDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.staticImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticImportOnDemandDeclaration([NotNull] Java9Parser.StaticImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.staticImportOnDemandDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticImportOnDemandDeclaration([NotNull] Java9Parser.StaticImportOnDemandDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeDeclaration([NotNull] Java9Parser.TypeDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeDeclaration([NotNull] Java9Parser.TypeDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModuleDeclaration([NotNull] Java9Parser.ModuleDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModuleDeclaration([NotNull] Java9Parser.ModuleDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.moduleDirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModuleDirective([NotNull] Java9Parser.ModuleDirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.moduleDirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModuleDirective([NotNull] Java9Parser.ModuleDirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.requiresModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRequiresModifier([NotNull] Java9Parser.RequiresModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.requiresModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRequiresModifier([NotNull] Java9Parser.RequiresModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDeclaration([NotNull] Java9Parser.ClassDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDeclaration([NotNull] Java9Parser.ClassDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalClassDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalClassDeclaration([NotNull] Java9Parser.NormalClassDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalClassDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalClassDeclaration([NotNull] Java9Parser.NormalClassDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassModifier([NotNull] Java9Parser.ClassModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassModifier([NotNull] Java9Parser.ClassModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameters([NotNull] Java9Parser.TypeParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameters([NotNull] Java9Parser.TypeParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterList([NotNull] Java9Parser.TypeParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterList([NotNull] Java9Parser.TypeParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.superclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSuperclass([NotNull] Java9Parser.SuperclassContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.superclass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSuperclass([NotNull] Java9Parser.SuperclassContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.superinterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSuperinterfaces([NotNull] Java9Parser.SuperinterfacesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.superinterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSuperinterfaces([NotNull] Java9Parser.SuperinterfacesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceTypeList([NotNull] Java9Parser.InterfaceTypeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceTypeList([NotNull] Java9Parser.InterfaceTypeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassBody([NotNull] Java9Parser.ClassBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassBody([NotNull] Java9Parser.ClassBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classBodyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassBodyDeclaration([NotNull] Java9Parser.ClassBodyDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classBodyDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassBodyDeclaration([NotNull] Java9Parser.ClassBodyDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassMemberDeclaration([NotNull] Java9Parser.ClassMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassMemberDeclaration([NotNull] Java9Parser.ClassMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldDeclaration([NotNull] Java9Parser.FieldDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldModifier([NotNull] Java9Parser.FieldModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldModifier([NotNull] Java9Parser.FieldModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaratorList([NotNull] Java9Parser.VariableDeclaratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaratorList([NotNull] Java9Parser.VariableDeclaratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclarator([NotNull] Java9Parser.VariableDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaratorId([NotNull] Java9Parser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableDeclaratorId"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaratorId([NotNull] Java9Parser.VariableDeclaratorIdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializer([NotNull] Java9Parser.VariableInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializer([NotNull] Java9Parser.VariableInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannType([NotNull] Java9Parser.UnannTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannType([NotNull] Java9Parser.UnannTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannPrimitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannPrimitiveType([NotNull] Java9Parser.UnannPrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannPrimitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannPrimitiveType([NotNull] Java9Parser.UnannPrimitiveTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannReferenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannReferenceType([NotNull] Java9Parser.UnannReferenceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannReferenceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannReferenceType([NotNull] Java9Parser.UnannReferenceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassOrInterfaceType([NotNull] Java9Parser.UnannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType([NotNull] Java9Parser.UnannClassTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType([NotNull] Java9Parser.UnannClassTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannClassType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannClassType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannClassType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType([NotNull] Java9Parser.UnannInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType([NotNull] Java9Parser.UnannInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lf_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType_lf_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lf_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannInterfaceType_lfno_unannClassOrInterfaceType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannInterfaceType_lfno_unannClassOrInterfaceType([NotNull] Java9Parser.UnannInterfaceType_lfno_unannClassOrInterfaceTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannTypeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannTypeVariable([NotNull] Java9Parser.UnannTypeVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannTypeVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannTypeVariable([NotNull] Java9Parser.UnannTypeVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unannArrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unannArrayType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnannArrayType([NotNull] Java9Parser.UnannArrayTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDeclaration([NotNull] Java9Parser.MethodDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDeclaration([NotNull] Java9Parser.MethodDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodModifier([NotNull] Java9Parser.MethodModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodModifier([NotNull] Java9Parser.MethodModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodHeader([NotNull] Java9Parser.MethodHeaderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodHeader"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodHeader([NotNull] Java9Parser.MethodHeaderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult([NotNull] Java9Parser.ResultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult([NotNull] Java9Parser.ResultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodDeclarator([NotNull] Java9Parser.MethodDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameterList([NotNull] Java9Parser.FormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameters([NotNull] Java9Parser.FormalParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameters([NotNull] Java9Parser.FormalParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameter([NotNull] Java9Parser.FormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameter([NotNull] Java9Parser.FormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableModifier([NotNull] Java9Parser.VariableModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableModifier([NotNull] Java9Parser.VariableModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lastFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLastFormalParameter([NotNull] Java9Parser.LastFormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lastFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLastFormalParameter([NotNull] Java9Parser.LastFormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.receiverParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReceiverParameter([NotNull] Java9Parser.ReceiverParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.receiverParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReceiverParameter([NotNull] Java9Parser.ReceiverParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.throws_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrows_([NotNull] Java9Parser.Throws_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.throws_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrows_([NotNull] Java9Parser.Throws_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exceptionTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptionTypeList([NotNull] Java9Parser.ExceptionTypeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exceptionTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptionTypeList([NotNull] Java9Parser.ExceptionTypeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exceptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptionType([NotNull] Java9Parser.ExceptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exceptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptionType([NotNull] Java9Parser.ExceptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodBody([NotNull] Java9Parser.MethodBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodBody([NotNull] Java9Parser.MethodBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.instanceInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstanceInitializer([NotNull] Java9Parser.InstanceInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.instanceInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstanceInitializer([NotNull] Java9Parser.InstanceInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.staticInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticInitializer([NotNull] Java9Parser.StaticInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.staticInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticInitializer([NotNull] Java9Parser.StaticInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorDeclaration([NotNull] Java9Parser.ConstructorDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorDeclaration([NotNull] Java9Parser.ConstructorDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorModifier([NotNull] Java9Parser.ConstructorModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorModifier([NotNull] Java9Parser.ConstructorModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorDeclarator([NotNull] Java9Parser.ConstructorDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorDeclarator([NotNull] Java9Parser.ConstructorDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.simpleTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleTypeName([NotNull] Java9Parser.SimpleTypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.simpleTypeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleTypeName([NotNull] Java9Parser.SimpleTypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constructorBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructorBody([NotNull] Java9Parser.ConstructorBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constructorBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructorBody([NotNull] Java9Parser.ConstructorBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.explicitConstructorInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicitConstructorInvocation([NotNull] Java9Parser.ExplicitConstructorInvocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.explicitConstructorInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicitConstructorInvocation([NotNull] Java9Parser.ExplicitConstructorInvocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumDeclaration([NotNull] Java9Parser.EnumDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumDeclaration([NotNull] Java9Parser.EnumDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumBody([NotNull] Java9Parser.EnumBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumBody([NotNull] Java9Parser.EnumBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantList([NotNull] Java9Parser.EnumConstantListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantList([NotNull] Java9Parser.EnumConstantListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstant([NotNull] Java9Parser.EnumConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstant([NotNull] Java9Parser.EnumConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantModifier([NotNull] Java9Parser.EnumConstantModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantModifier([NotNull] Java9Parser.EnumConstantModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumBodyDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumBodyDeclarations([NotNull] Java9Parser.EnumBodyDeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumBodyDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumBodyDeclarations([NotNull] Java9Parser.EnumBodyDeclarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceDeclaration([NotNull] Java9Parser.InterfaceDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceDeclaration([NotNull] Java9Parser.InterfaceDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalInterfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalInterfaceDeclaration([NotNull] Java9Parser.NormalInterfaceDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalInterfaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalInterfaceDeclaration([NotNull] Java9Parser.NormalInterfaceDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceModifier([NotNull] Java9Parser.InterfaceModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceModifier([NotNull] Java9Parser.InterfaceModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.extendsInterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtendsInterfaces([NotNull] Java9Parser.ExtendsInterfacesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.extendsInterfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtendsInterfaces([NotNull] Java9Parser.ExtendsInterfacesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceBody([NotNull] Java9Parser.InterfaceBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceBody([NotNull] Java9Parser.InterfaceBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMemberDeclaration([NotNull] Java9Parser.InterfaceMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMemberDeclaration([NotNull] Java9Parser.InterfaceMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantDeclaration([NotNull] Java9Parser.ConstantDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantDeclaration([NotNull] Java9Parser.ConstantDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantModifier([NotNull] Java9Parser.ConstantModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantModifier([NotNull] Java9Parser.ConstantModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMethodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMethodDeclaration([NotNull] Java9Parser.InterfaceMethodDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMethodDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMethodDeclaration([NotNull] Java9Parser.InterfaceMethodDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.interfaceMethodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceMethodModifier([NotNull] Java9Parser.InterfaceMethodModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.interfaceMethodModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceMethodModifier([NotNull] Java9Parser.InterfaceMethodModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeDeclaration([NotNull] Java9Parser.AnnotationTypeDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeDeclaration([NotNull] Java9Parser.AnnotationTypeDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeBody([NotNull] Java9Parser.AnnotationTypeBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeBody([NotNull] Java9Parser.AnnotationTypeBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeMemberDeclaration([NotNull] Java9Parser.AnnotationTypeMemberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeMemberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeMemberDeclaration([NotNull] Java9Parser.AnnotationTypeMemberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeElementDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeElementDeclaration([NotNull] Java9Parser.AnnotationTypeElementDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeElementDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeElementDeclaration([NotNull] Java9Parser.AnnotationTypeElementDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotationTypeElementModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotationTypeElementModifier([NotNull] Java9Parser.AnnotationTypeElementModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotationTypeElementModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotationTypeElementModifier([NotNull] Java9Parser.AnnotationTypeElementModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.defaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultValue([NotNull] Java9Parser.DefaultValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.defaultValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultValue([NotNull] Java9Parser.DefaultValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnotation([NotNull] Java9Parser.AnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnotation([NotNull] Java9Parser.AnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.normalAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNormalAnnotation([NotNull] Java9Parser.NormalAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.normalAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNormalAnnotation([NotNull] Java9Parser.NormalAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValuePairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValuePairList([NotNull] Java9Parser.ElementValuePairListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValuePairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValuePairList([NotNull] Java9Parser.ElementValuePairListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValuePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValuePair([NotNull] Java9Parser.ElementValuePairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValuePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValuePair([NotNull] Java9Parser.ElementValuePairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValue([NotNull] Java9Parser.ElementValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValue([NotNull] Java9Parser.ElementValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValueArrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValueArrayInitializer([NotNull] Java9Parser.ElementValueArrayInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValueArrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValueArrayInitializer([NotNull] Java9Parser.ElementValueArrayInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.elementValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElementValueList([NotNull] Java9Parser.ElementValueListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.elementValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElementValueList([NotNull] Java9Parser.ElementValueListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.markerAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMarkerAnnotation([NotNull] Java9Parser.MarkerAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.markerAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMarkerAnnotation([NotNull] Java9Parser.MarkerAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.singleElementAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleElementAnnotation([NotNull] Java9Parser.SingleElementAnnotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.singleElementAnnotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleElementAnnotation([NotNull] Java9Parser.SingleElementAnnotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayInitializer([NotNull] Java9Parser.ArrayInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayInitializer([NotNull] Java9Parser.ArrayInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableInitializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializerList([NotNull] Java9Parser.VariableInitializerListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableInitializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializerList([NotNull] Java9Parser.VariableInitializerListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] Java9Parser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] Java9Parser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.blockStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatements([NotNull] Java9Parser.BlockStatementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.blockStatements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatements([NotNull] Java9Parser.BlockStatementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatement([NotNull] Java9Parser.BlockStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatement([NotNull] Java9Parser.BlockStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.localVariableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocalVariableDeclarationStatement([NotNull] Java9Parser.LocalVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.localVariableDeclarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocalVariableDeclarationStatement([NotNull] Java9Parser.LocalVariableDeclarationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.localVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocalVariableDeclaration([NotNull] Java9Parser.LocalVariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.localVariableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocalVariableDeclaration([NotNull] Java9Parser.LocalVariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] Java9Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] Java9Parser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementNoShortIf([NotNull] Java9Parser.StatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementNoShortIf([NotNull] Java9Parser.StatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementWithoutTrailingSubstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementWithoutTrailingSubstatement([NotNull] Java9Parser.StatementWithoutTrailingSubstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementWithoutTrailingSubstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementWithoutTrailingSubstatement([NotNull] Java9Parser.StatementWithoutTrailingSubstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.emptyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptyStatement([NotNull] Java9Parser.EmptyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.emptyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptyStatement([NotNull] Java9Parser.EmptyStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledStatement([NotNull] Java9Parser.LabeledStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledStatement([NotNull] Java9Parser.LabeledStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.labeledStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledStatementNoShortIf([NotNull] Java9Parser.LabeledStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.labeledStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledStatementNoShortIf([NotNull] Java9Parser.LabeledStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] Java9Parser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] Java9Parser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementExpression([NotNull] Java9Parser.StatementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementExpression([NotNull] Java9Parser.StatementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenStatement([NotNull] Java9Parser.IfThenStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenStatement([NotNull] Java9Parser.IfThenStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenElseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenElseStatement([NotNull] Java9Parser.IfThenElseStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenElseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenElseStatement([NotNull] Java9Parser.IfThenElseStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.ifThenElseStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfThenElseStatementNoShortIf([NotNull] Java9Parser.IfThenElseStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.ifThenElseStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfThenElseStatementNoShortIf([NotNull] Java9Parser.IfThenElseStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssertStatement([NotNull] Java9Parser.AssertStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssertStatement([NotNull] Java9Parser.AssertStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchStatement([NotNull] Java9Parser.SwitchStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchStatement([NotNull] Java9Parser.SwitchStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchBlock([NotNull] Java9Parser.SwitchBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchBlock([NotNull] Java9Parser.SwitchBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchBlockStatementGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchBlockStatementGroup([NotNull] Java9Parser.SwitchBlockStatementGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchBlockStatementGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchBlockStatementGroup([NotNull] Java9Parser.SwitchBlockStatementGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchLabels([NotNull] Java9Parser.SwitchLabelsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchLabels([NotNull] Java9Parser.SwitchLabelsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.switchLabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchLabel([NotNull] Java9Parser.SwitchLabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.switchLabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchLabel([NotNull] Java9Parser.SwitchLabelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enumConstantName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumConstantName([NotNull] Java9Parser.EnumConstantNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enumConstantName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumConstantName([NotNull] Java9Parser.EnumConstantNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] Java9Parser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] Java9Parser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.whileStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatementNoShortIf([NotNull] Java9Parser.WhileStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.whileStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatementNoShortIf([NotNull] Java9Parser.WhileStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoStatement([NotNull] Java9Parser.DoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoStatement([NotNull] Java9Parser.DoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] Java9Parser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] Java9Parser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatementNoShortIf([NotNull] Java9Parser.ForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatementNoShortIf([NotNull] Java9Parser.ForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.basicForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasicForStatement([NotNull] Java9Parser.BasicForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.basicForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasicForStatement([NotNull] Java9Parser.BasicForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.basicForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasicForStatementNoShortIf([NotNull] Java9Parser.BasicForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.basicForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasicForStatementNoShortIf([NotNull] Java9Parser.BasicForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForInit([NotNull] Java9Parser.ForInitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForInit([NotNull] Java9Parser.ForInitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForUpdate([NotNull] Java9Parser.ForUpdateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForUpdate([NotNull] Java9Parser.ForUpdateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.statementExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementExpressionList([NotNull] Java9Parser.StatementExpressionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.statementExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementExpressionList([NotNull] Java9Parser.StatementExpressionListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enhancedForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnhancedForStatement([NotNull] Java9Parser.EnhancedForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enhancedForStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnhancedForStatement([NotNull] Java9Parser.EnhancedForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.enhancedForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnhancedForStatementNoShortIf([NotNull] Java9Parser.EnhancedForStatementNoShortIfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.enhancedForStatementNoShortIf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnhancedForStatementNoShortIf([NotNull] Java9Parser.EnhancedForStatementNoShortIfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] Java9Parser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] Java9Parser.BreakStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] Java9Parser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] Java9Parser.ContinueStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] Java9Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] Java9Parser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowStatement([NotNull] Java9Parser.ThrowStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowStatement([NotNull] Java9Parser.ThrowStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.synchronizedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSynchronizedStatement([NotNull] Java9Parser.SynchronizedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.synchronizedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSynchronizedStatement([NotNull] Java9Parser.SynchronizedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.tryStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryStatement([NotNull] Java9Parser.TryStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.tryStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryStatement([NotNull] Java9Parser.TryStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatches([NotNull] Java9Parser.CatchesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatches([NotNull] Java9Parser.CatchesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchClause([NotNull] Java9Parser.CatchClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchClause([NotNull] Java9Parser.CatchClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchFormalParameter([NotNull] Java9Parser.CatchFormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchFormalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchFormalParameter([NotNull] Java9Parser.CatchFormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.catchType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchType([NotNull] Java9Parser.CatchTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.catchType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchType([NotNull] Java9Parser.CatchTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.finally_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFinally_([NotNull] Java9Parser.Finally_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.finally_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFinally_([NotNull] Java9Parser.Finally_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.tryWithResourcesStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryWithResourcesStatement([NotNull] Java9Parser.TryWithResourcesStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.tryWithResourcesStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryWithResourcesStatement([NotNull] Java9Parser.TryWithResourcesStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resourceSpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceSpecification([NotNull] Java9Parser.ResourceSpecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resourceSpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceSpecification([NotNull] Java9Parser.ResourceSpecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resourceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceList([NotNull] Java9Parser.ResourceListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resourceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceList([NotNull] Java9Parser.ResourceListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.resource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResource([NotNull] Java9Parser.ResourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.resource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResource([NotNull] Java9Parser.ResourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.variableAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableAccess([NotNull] Java9Parser.VariableAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.variableAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableAccess([NotNull] Java9Parser.VariableAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary([NotNull] Java9Parser.PrimaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary([NotNull] Java9Parser.PrimaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray([NotNull] Java9Parser.PrimaryNoNewArrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray([NotNull] Java9Parser.PrimaryNoNewArrayContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lf_arrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lf_arrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lfno_arrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_arrayAccess([NotNull] Java9Parser.PrimaryNoNewArray_lfno_arrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lf_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primary([NotNull] Java9Parser.PrimaryNoNewArray_lf_primary_lfno_arrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lf_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.primaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primary([NotNull] Java9Parser.PrimaryNoNewArray_lfno_primary_lfno_arrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassLiteral([NotNull] Java9Parser.ClassLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassLiteral([NotNull] Java9Parser.ClassLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression([NotNull] Java9Parser.ClassInstanceCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression([NotNull] Java9Parser.ClassInstanceCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression_lf_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression_lf_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassInstanceCreationExpression_lfno_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.classInstanceCreationExpression_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassInstanceCreationExpression_lfno_primary([NotNull] Java9Parser.ClassInstanceCreationExpression_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.typeArgumentsOrDiamond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeArgumentsOrDiamond([NotNull] Java9Parser.TypeArgumentsOrDiamondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.typeArgumentsOrDiamond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeArgumentsOrDiamond([NotNull] Java9Parser.TypeArgumentsOrDiamondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess([NotNull] Java9Parser.FieldAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess([NotNull] Java9Parser.FieldAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess_lf_primary([NotNull] Java9Parser.FieldAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess_lf_primary([NotNull] Java9Parser.FieldAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.fieldAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldAccess_lfno_primary([NotNull] Java9Parser.FieldAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.fieldAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldAccess_lfno_primary([NotNull] Java9Parser.FieldAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess([NotNull] Java9Parser.ArrayAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess([NotNull] Java9Parser.ArrayAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess_lf_primary([NotNull] Java9Parser.ArrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess_lf_primary([NotNull] Java9Parser.ArrayAccess_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayAccess_lfno_primary([NotNull] Java9Parser.ArrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayAccess_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayAccess_lfno_primary([NotNull] Java9Parser.ArrayAccess_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation([NotNull] Java9Parser.MethodInvocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation([NotNull] Java9Parser.MethodInvocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation_lf_primary([NotNull] Java9Parser.MethodInvocation_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation_lf_primary([NotNull] Java9Parser.MethodInvocation_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodInvocation_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodInvocation_lfno_primary([NotNull] Java9Parser.MethodInvocation_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodInvocation_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodInvocation_lfno_primary([NotNull] Java9Parser.MethodInvocation_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentList([NotNull] Java9Parser.ArgumentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.argumentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentList([NotNull] Java9Parser.ArgumentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference([NotNull] Java9Parser.MethodReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference([NotNull] Java9Parser.MethodReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference_lf_primary([NotNull] Java9Parser.MethodReference_lf_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference_lf_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference_lf_primary([NotNull] Java9Parser.MethodReference_lf_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.methodReference_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodReference_lfno_primary([NotNull] Java9Parser.MethodReference_lfno_primaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.methodReference_lfno_primary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodReference_lfno_primary([NotNull] Java9Parser.MethodReference_lfno_primaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.arrayCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayCreationExpression([NotNull] Java9Parser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.arrayCreationExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayCreationExpression([NotNull] Java9Parser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dimExprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDimExprs([NotNull] Java9Parser.DimExprsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dimExprs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDimExprs([NotNull] Java9Parser.DimExprsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.dimExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDimExpr([NotNull] Java9Parser.DimExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.dimExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDimExpr([NotNull] Java9Parser.DimExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] Java9Parser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] Java9Parser.ConstantExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] Java9Parser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] Java9Parser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaExpression([NotNull] Java9Parser.LambdaExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaExpression([NotNull] Java9Parser.LambdaExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaParameters([NotNull] Java9Parser.LambdaParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaParameters([NotNull] Java9Parser.LambdaParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.inferredFormalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInferredFormalParameterList([NotNull] Java9Parser.InferredFormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.inferredFormalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInferredFormalParameterList([NotNull] Java9Parser.InferredFormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.lambdaBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaBody([NotNull] Java9Parser.LambdaBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.lambdaBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaBody([NotNull] Java9Parser.LambdaBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] Java9Parser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] Java9Parser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] Java9Parser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] Java9Parser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.leftHandSide"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLeftHandSide([NotNull] Java9Parser.LeftHandSideContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.leftHandSide"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLeftHandSide([NotNull] Java9Parser.LeftHandSideContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperator([NotNull] Java9Parser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperator([NotNull] Java9Parser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalExpression([NotNull] Java9Parser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalExpression([NotNull] Java9Parser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalOrExpression([NotNull] Java9Parser.ConditionalOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalOrExpression([NotNull] Java9Parser.ConditionalOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.conditionalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalAndExpression([NotNull] Java9Parser.ConditionalAndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.conditionalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalAndExpression([NotNull] Java9Parser.ConditionalAndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInclusiveOrExpression([NotNull] Java9Parser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInclusiveOrExpression([NotNull] Java9Parser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusiveOrExpression([NotNull] Java9Parser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusiveOrExpression([NotNull] Java9Parser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpression([NotNull] Java9Parser.AndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpression([NotNull] Java9Parser.AndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpression([NotNull] Java9Parser.EqualityExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpression([NotNull] Java9Parser.EqualityExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] Java9Parser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] Java9Parser.RelationalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftExpression([NotNull] Java9Parser.ShiftExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftExpression([NotNull] Java9Parser.ShiftExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] Java9Parser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] Java9Parser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] Java9Parser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] Java9Parser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpression([NotNull] Java9Parser.UnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpression([NotNull] Java9Parser.UnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.preIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreIncrementExpression([NotNull] Java9Parser.PreIncrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.preIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreIncrementExpression([NotNull] Java9Parser.PreIncrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.preDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreDecrementExpression([NotNull] Java9Parser.PreDecrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.preDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreDecrementExpression([NotNull] Java9Parser.PreDecrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.unaryExpressionNotPlusMinus"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpressionNotPlusMinus([NotNull] Java9Parser.UnaryExpressionNotPlusMinusContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.unaryExpressionNotPlusMinus"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpressionNotPlusMinus([NotNull] Java9Parser.UnaryExpressionNotPlusMinusContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixExpression([NotNull] Java9Parser.PostfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixExpression([NotNull] Java9Parser.PostfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostIncrementExpression([NotNull] Java9Parser.PostIncrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postIncrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostIncrementExpression([NotNull] Java9Parser.PostIncrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostIncrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostIncrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postIncrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostIncrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostIncrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostDecrementExpression([NotNull] Java9Parser.PostDecrementExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postDecrementExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostDecrementExpression([NotNull] Java9Parser.PostDecrementExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostDecrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostDecrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.postDecrementExpression_lf_postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostDecrementExpression_lf_postfixExpression([NotNull] Java9Parser.PostDecrementExpression_lf_postfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpression([NotNull] Java9Parser.CastExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpression([NotNull] Java9Parser.CastExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Java9Parser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] Java9Parser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Java9Parser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] Java9Parser.IdentifierContext context) { }

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
