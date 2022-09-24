using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPhpParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class PhpParserBaseListener : IPhpParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.htmlDocument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHtmlDocument([NotNull] PhpParser.HtmlDocumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.htmlDocument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHtmlDocument([NotNull] PhpParser.HtmlDocumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.inlineHtml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInlineHtml([NotNull] PhpParser.InlineHtmlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.inlineHtml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInlineHtml([NotNull] PhpParser.InlineHtmlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.htmlElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHtmlElement([NotNull] PhpParser.HtmlElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.htmlElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHtmlElement([NotNull] PhpParser.HtmlElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.scriptText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScriptText([NotNull] PhpParser.ScriptTextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.scriptText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScriptText([NotNull] PhpParser.ScriptTextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.phpBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhpBlock([NotNull] PhpParser.PhpBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.phpBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhpBlock([NotNull] PhpParser.PhpBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportStatement([NotNull] PhpParser.ImportStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportStatement([NotNull] PhpParser.ImportStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.topStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTopStatement([NotNull] PhpParser.TopStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.topStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTopStatement([NotNull] PhpParser.TopStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUseDeclaration([NotNull] PhpParser.UseDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUseDeclaration([NotNull] PhpParser.UseDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclarationContentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUseDeclarationContentList([NotNull] PhpParser.UseDeclarationContentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclarationContentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUseDeclarationContentList([NotNull] PhpParser.UseDeclarationContentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclarationContent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUseDeclarationContent([NotNull] PhpParser.UseDeclarationContentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclarationContent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUseDeclarationContent([NotNull] PhpParser.UseDeclarationContentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespaceDeclaration([NotNull] PhpParser.NamespaceDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespaceDeclaration([NotNull] PhpParser.NamespaceDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespaceStatement([NotNull] PhpParser.NamespaceStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespaceStatement([NotNull] PhpParser.NamespaceStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] PhpParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] PhpParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassDeclaration([NotNull] PhpParser.ClassDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassDeclaration([NotNull] PhpParser.ClassDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classEntryType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassEntryType([NotNull] PhpParser.ClassEntryTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classEntryType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassEntryType([NotNull] PhpParser.ClassEntryTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.interfaceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterfaceList([NotNull] PhpParser.InterfaceListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.interfaceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterfaceList([NotNull] PhpParser.InterfaceListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterListInBrackets"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterListInBrackets([NotNull] PhpParser.TypeParameterListInBracketsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterListInBrackets"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterListInBrackets([NotNull] PhpParser.TypeParameterListInBracketsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterList([NotNull] PhpParser.TypeParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterList([NotNull] PhpParser.TypeParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultsList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterWithDefaultsList([NotNull] PhpParser.TypeParameterWithDefaultsListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultsList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterWithDefaultsList([NotNull] PhpParser.TypeParameterWithDefaultsListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterDecl([NotNull] PhpParser.TypeParameterDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterDecl([NotNull] PhpParser.TypeParameterDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeParameterWithDefaultDecl([NotNull] PhpParser.TypeParameterWithDefaultDeclContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultDecl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeParameterWithDefaultDecl([NotNull] PhpParser.TypeParameterWithDefaultDeclContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.genericDynamicArgs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenericDynamicArgs([NotNull] PhpParser.GenericDynamicArgsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.genericDynamicArgs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenericDynamicArgs([NotNull] PhpParser.GenericDynamicArgsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributes([NotNull] PhpParser.AttributesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributes([NotNull] PhpParser.AttributesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attributeGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributeGroup([NotNull] PhpParser.AttributeGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attributeGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributeGroup([NotNull] PhpParser.AttributeGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute([NotNull] PhpParser.AttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute([NotNull] PhpParser.AttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.innerStatementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInnerStatementList([NotNull] PhpParser.InnerStatementListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.innerStatementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInnerStatementList([NotNull] PhpParser.InnerStatementListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.innerStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInnerStatement([NotNull] PhpParser.InnerStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.innerStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInnerStatement([NotNull] PhpParser.InnerStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] PhpParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] PhpParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.emptyStatement_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptyStatement_([NotNull] PhpParser.EmptyStatement_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.emptyStatement_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptyStatement_([NotNull] PhpParser.EmptyStatement_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockStatement([NotNull] PhpParser.BlockStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.blockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockStatement([NotNull] PhpParser.BlockStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] PhpParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] PhpParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseIfStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfStatement([NotNull] PhpParser.ElseIfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseIfStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfStatement([NotNull] PhpParser.ElseIfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseIfColonStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseIfColonStatement([NotNull] PhpParser.ElseIfColonStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseIfColonStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseIfColonStatement([NotNull] PhpParser.ElseIfColonStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseStatement([NotNull] PhpParser.ElseStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseStatement([NotNull] PhpParser.ElseStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseColonStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseColonStatement([NotNull] PhpParser.ElseColonStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseColonStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseColonStatement([NotNull] PhpParser.ElseColonStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] PhpParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.whileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] PhpParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.doWhileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoWhileStatement([NotNull] PhpParser.DoWhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.doWhileStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoWhileStatement([NotNull] PhpParser.DoWhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] PhpParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] PhpParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForInit([NotNull] PhpParser.ForInitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forInit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForInit([NotNull] PhpParser.ForInitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForUpdate([NotNull] PhpParser.ForUpdateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forUpdate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForUpdate([NotNull] PhpParser.ForUpdateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchStatement([NotNull] PhpParser.SwitchStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.switchStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchStatement([NotNull] PhpParser.SwitchStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchBlock([NotNull] PhpParser.SwitchBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.switchBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchBlock([NotNull] PhpParser.SwitchBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] PhpParser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.breakStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] PhpParser.BreakStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] PhpParser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.continueStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] PhpParser.ContinueStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] PhpParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] PhpParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] PhpParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] PhpParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.unsetStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnsetStatement([NotNull] PhpParser.UnsetStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.unsetStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnsetStatement([NotNull] PhpParser.UnsetStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.foreachStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeachStatement([NotNull] PhpParser.ForeachStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.foreachStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeachStatement([NotNull] PhpParser.ForeachStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.tryCatchFinally"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryCatchFinally([NotNull] PhpParser.TryCatchFinallyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.tryCatchFinally"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryCatchFinally([NotNull] PhpParser.TryCatchFinallyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatchClause([NotNull] PhpParser.CatchClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.catchClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatchClause([NotNull] PhpParser.CatchClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.finallyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFinallyStatement([NotNull] PhpParser.FinallyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.finallyStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFinallyStatement([NotNull] PhpParser.FinallyStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowStatement([NotNull] PhpParser.ThrowStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.throwStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowStatement([NotNull] PhpParser.ThrowStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoStatement([NotNull] PhpParser.GotoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.gotoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoStatement([NotNull] PhpParser.GotoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.declareStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclareStatement([NotNull] PhpParser.DeclareStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.declareStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclareStatement([NotNull] PhpParser.DeclareStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.inlineHtmlStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInlineHtmlStatement([NotNull] PhpParser.InlineHtmlStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.inlineHtmlStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInlineHtmlStatement([NotNull] PhpParser.InlineHtmlStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.declareList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclareList([NotNull] PhpParser.DeclareListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.declareList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclareList([NotNull] PhpParser.DeclareListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameterList([NotNull] PhpParser.FormalParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.formalParameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameterList([NotNull] PhpParser.FormalParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormalParameter([NotNull] PhpParser.FormalParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.formalParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormalParameter([NotNull] PhpParser.FormalParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeHint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeHint([NotNull] PhpParser.TypeHintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeHint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeHint([NotNull] PhpParser.TypeHintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalStatement([NotNull] PhpParser.GlobalStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalStatement([NotNull] PhpParser.GlobalStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalVar([NotNull] PhpParser.GlobalVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalVar([NotNull] PhpParser.GlobalVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.echoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEchoStatement([NotNull] PhpParser.EchoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.echoStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEchoStatement([NotNull] PhpParser.EchoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.staticVariableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticVariableStatement([NotNull] PhpParser.StaticVariableStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.staticVariableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticVariableStatement([NotNull] PhpParser.StaticVariableStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassStatement([NotNull] PhpParser.ClassStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassStatement([NotNull] PhpParser.ClassStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAdaptations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTraitAdaptations([NotNull] PhpParser.TraitAdaptationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAdaptations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTraitAdaptations([NotNull] PhpParser.TraitAdaptationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAdaptationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTraitAdaptationStatement([NotNull] PhpParser.TraitAdaptationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAdaptationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTraitAdaptationStatement([NotNull] PhpParser.TraitAdaptationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitPrecedence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTraitPrecedence([NotNull] PhpParser.TraitPrecedenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitPrecedence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTraitPrecedence([NotNull] PhpParser.TraitPrecedenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTraitAlias([NotNull] PhpParser.TraitAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTraitAlias([NotNull] PhpParser.TraitAliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitMethodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTraitMethodReference([NotNull] PhpParser.TraitMethodReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitMethodReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTraitMethodReference([NotNull] PhpParser.TraitMethodReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.baseCtorCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBaseCtorCall([NotNull] PhpParser.BaseCtorCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.baseCtorCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBaseCtorCall([NotNull] PhpParser.BaseCtorCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethodBody([NotNull] PhpParser.MethodBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.methodBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethodBody([NotNull] PhpParser.MethodBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.propertyModifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPropertyModifiers([NotNull] PhpParser.PropertyModifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.propertyModifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPropertyModifiers([NotNull] PhpParser.PropertyModifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberModifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberModifiers([NotNull] PhpParser.MemberModifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberModifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberModifiers([NotNull] PhpParser.MemberModifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableInitializer([NotNull] PhpParser.VariableInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.variableInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableInitializer([NotNull] PhpParser.VariableInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.identifierInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierInitializer([NotNull] PhpParser.IdentifierInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.identifierInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierInitializer([NotNull] PhpParser.IdentifierInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalConstantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobalConstantDeclaration([NotNull] PhpParser.GlobalConstantDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalConstantDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobalConstantDeclaration([NotNull] PhpParser.GlobalConstantDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.expressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionList([NotNull] PhpParser.ExpressionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.expressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionList([NotNull] PhpParser.ExpressionListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.parentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParentheses([NotNull] PhpParser.ParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.parentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParentheses([NotNull] PhpParser.ParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ChainExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChainExpression([NotNull] PhpParser.ChainExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ChainExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChainExpression([NotNull] PhpParser.ChainExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SpecialWordExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecialWordExpression([NotNull] PhpParser.SpecialWordExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecialWordExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecialWordExpression([NotNull] PhpParser.SpecialWordExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayCreationExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayCreationExpression([NotNull] PhpParser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayCreationExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayCreationExpression([NotNull] PhpParser.ArrayCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BackQuoteStringExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackQuoteStringExpression([NotNull] PhpParser.BackQuoteStringExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BackQuoteStringExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackQuoteStringExpression([NotNull] PhpParser.BackQuoteStringExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MatchExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchExpression([NotNull] PhpParser.MatchExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MatchExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchExpression([NotNull] PhpParser.MatchExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalExpression([NotNull] PhpParser.LogicalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalExpression([NotNull] PhpParser.LogicalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PrintExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintExpression([NotNull] PhpParser.PrintExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PrintExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintExpression([NotNull] PhpParser.PrintExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] PhpParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] PhpParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PostfixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixIncDecExpression([NotNull] PhpParser.PostfixIncDecExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PostfixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixIncDecExpression([NotNull] PhpParser.PostfixIncDecExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CloneExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCloneExpression([NotNull] PhpParser.CloneExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CloneExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCloneExpression([NotNull] PhpParser.CloneExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryOperatorExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryOperatorExpression([NotNull] PhpParser.UnaryOperatorExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryOperatorExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryOperatorExpression([NotNull] PhpParser.UnaryOperatorExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewExpression([NotNull] PhpParser.NewExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewExpression([NotNull] PhpParser.NewExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisExpression([NotNull] PhpParser.ParenthesisExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisExpression([NotNull] PhpParser.ParenthesisExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SpaceshipExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpaceshipExpression([NotNull] PhpParser.SpaceshipExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SpaceshipExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpaceshipExpression([NotNull] PhpParser.SpaceshipExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ConditionalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalExpression([NotNull] PhpParser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ConditionalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalExpression([NotNull] PhpParser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NullCoalescingExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNullCoalescingExpression([NotNull] PhpParser.NullCoalescingExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NullCoalescingExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNullCoalescingExpression([NotNull] PhpParser.NullCoalescingExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArithmeticExpression([NotNull] PhpParser.ArithmeticExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArithmeticExpression([NotNull] PhpParser.ArithmeticExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IndexerExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexerExpression([NotNull] PhpParser.IndexerExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IndexerExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexerExpression([NotNull] PhpParser.IndexerExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ScalarExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScalarExpression([NotNull] PhpParser.ScalarExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ScalarExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScalarExpression([NotNull] PhpParser.ScalarExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PrefixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrefixIncDecExpression([NotNull] PhpParser.PrefixIncDecExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PrefixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrefixIncDecExpression([NotNull] PhpParser.PrefixIncDecExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparisonExpression([NotNull] PhpParser.ComparisonExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparisonExpression([NotNull] PhpParser.ComparisonExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CastExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpression([NotNull] PhpParser.CastExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CastExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpression([NotNull] PhpParser.CastExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>InstanceOfExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstanceOfExpression([NotNull] PhpParser.InstanceOfExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>InstanceOfExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstanceOfExpression([NotNull] PhpParser.InstanceOfExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LambdaFunctionExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaFunctionExpression([NotNull] PhpParser.LambdaFunctionExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LambdaFunctionExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaFunctionExpression([NotNull] PhpParser.LambdaFunctionExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BitwiseExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitwiseExpression([NotNull] PhpParser.BitwiseExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BitwiseExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitwiseExpression([NotNull] PhpParser.BitwiseExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignable([NotNull] PhpParser.AssignableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignable([NotNull] PhpParser.AssignableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayCreation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayCreation([NotNull] PhpParser.ArrayCreationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayCreation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayCreation([NotNull] PhpParser.ArrayCreationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaFunctionExpr([NotNull] PhpParser.LambdaFunctionExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaFunctionExpr([NotNull] PhpParser.LambdaFunctionExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.matchExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchExpr([NotNull] PhpParser.MatchExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.matchExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchExpr([NotNull] PhpParser.MatchExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.matchItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMatchItem([NotNull] PhpParser.MatchItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.matchItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMatchItem([NotNull] PhpParser.MatchItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.newExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewExpr([NotNull] PhpParser.NewExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.newExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewExpr([NotNull] PhpParser.NewExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperator([NotNull] PhpParser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperator([NotNull] PhpParser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.yieldExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYieldExpression([NotNull] PhpParser.YieldExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.yieldExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYieldExpression([NotNull] PhpParser.YieldExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayItemList([NotNull] PhpParser.ArrayItemListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayItemList([NotNull] PhpParser.ArrayItemListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayItem([NotNull] PhpParser.ArrayItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayItem([NotNull] PhpParser.ArrayItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaFunctionUseVars([NotNull] PhpParser.LambdaFunctionUseVarsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVars"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaFunctionUseVars([NotNull] PhpParser.LambdaFunctionUseVarsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaFunctionUseVar([NotNull] PhpParser.LambdaFunctionUseVarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaFunctionUseVar([NotNull] PhpParser.LambdaFunctionUseVarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedStaticTypeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiedStaticTypeRef([NotNull] PhpParser.QualifiedStaticTypeRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedStaticTypeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiedStaticTypeRef([NotNull] PhpParser.QualifiedStaticTypeRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeRef([NotNull] PhpParser.TypeRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeRef([NotNull] PhpParser.TypeRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.anonymousClass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymousClass([NotNull] PhpParser.AnonymousClassContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.anonymousClass"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymousClass([NotNull] PhpParser.AnonymousClassContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.indirectTypeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndirectTypeRef([NotNull] PhpParser.IndirectTypeRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.indirectTypeRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndirectTypeRef([NotNull] PhpParser.IndirectTypeRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedNamespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiedNamespaceName([NotNull] PhpParser.QualifiedNamespaceNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedNamespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiedNamespaceName([NotNull] PhpParser.QualifiedNamespaceNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespaceNameList([NotNull] PhpParser.NamespaceNameListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespaceNameList([NotNull] PhpParser.NamespaceNameListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceNameTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespaceNameTail([NotNull] PhpParser.NamespaceNameTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceNameTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespaceNameTail([NotNull] PhpParser.NamespaceNameTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedNamespaceNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiedNamespaceNameList([NotNull] PhpParser.QualifiedNamespaceNameListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedNamespaceNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiedNamespaceNameList([NotNull] PhpParser.QualifiedNamespaceNameListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArguments([NotNull] PhpParser.ArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArguments([NotNull] PhpParser.ArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.actualArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterActualArgument([NotNull] PhpParser.ActualArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.actualArgument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitActualArgument([NotNull] PhpParser.ActualArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.argumentName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentName([NotNull] PhpParser.ArgumentNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.argumentName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentName([NotNull] PhpParser.ArgumentNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.constantInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantInitializer([NotNull] PhpParser.ConstantInitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.constantInitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantInitializer([NotNull] PhpParser.ConstantInitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] PhpParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] PhpParser.ConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.literalConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralConstant([NotNull] PhpParser.LiteralConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.literalConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralConstant([NotNull] PhpParser.LiteralConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.numericConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericConstant([NotNull] PhpParser.NumericConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.numericConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericConstant([NotNull] PhpParser.NumericConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassConstant([NotNull] PhpParser.ClassConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassConstant([NotNull] PhpParser.ClassConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.stringConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringConstant([NotNull] PhpParser.StringConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.stringConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringConstant([NotNull] PhpParser.StringConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] PhpParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] PhpParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.interpolatedStringPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolatedStringPart([NotNull] PhpParser.InterpolatedStringPartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.interpolatedStringPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolatedStringPart([NotNull] PhpParser.InterpolatedStringPartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChainList([NotNull] PhpParser.ChainListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChainList([NotNull] PhpParser.ChainListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChain([NotNull] PhpParser.ChainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChain([NotNull] PhpParser.ChainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainOrigin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChainOrigin([NotNull] PhpParser.ChainOriginContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainOrigin"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChainOrigin([NotNull] PhpParser.ChainOriginContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberAccess([NotNull] PhpParser.MemberAccessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberAccess"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberAccess([NotNull] PhpParser.MemberAccessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] PhpParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] PhpParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionCallName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCallName([NotNull] PhpParser.FunctionCallNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionCallName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCallName([NotNull] PhpParser.FunctionCallNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.actualArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterActualArguments([NotNull] PhpParser.ActualArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.actualArguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitActualArguments([NotNull] PhpParser.ActualArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainBase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChainBase([NotNull] PhpParser.ChainBaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainBase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChainBase([NotNull] PhpParser.ChainBaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedFieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyedFieldName([NotNull] PhpParser.KeyedFieldNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedFieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyedFieldName([NotNull] PhpParser.KeyedFieldNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedSimpleFieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyedSimpleFieldName([NotNull] PhpParser.KeyedSimpleFieldNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedSimpleFieldName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyedSimpleFieldName([NotNull] PhpParser.KeyedSimpleFieldNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyedVariable([NotNull] PhpParser.KeyedVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyedVariable([NotNull] PhpParser.KeyedVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.squareCurlyExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSquareCurlyExpression([NotNull] PhpParser.SquareCurlyExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.squareCurlyExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSquareCurlyExpression([NotNull] PhpParser.SquareCurlyExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentList([NotNull] PhpParser.AssignmentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentList([NotNull] PhpParser.AssignmentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentListElement([NotNull] PhpParser.AssignmentListElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentListElement([NotNull] PhpParser.AssignmentListElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModifier([NotNull] PhpParser.ModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModifier([NotNull] PhpParser.ModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PhpParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PhpParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberModifier([NotNull] PhpParser.MemberModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberModifier([NotNull] PhpParser.MemberModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.magicConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMagicConstant([NotNull] PhpParser.MagicConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.magicConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMagicConstant([NotNull] PhpParser.MagicConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.magicMethod"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMagicMethod([NotNull] PhpParser.MagicMethodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.magicMethod"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMagicMethod([NotNull] PhpParser.MagicMethodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitiveType([NotNull] PhpParser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.primitiveType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitiveType([NotNull] PhpParser.PrimitiveTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.castOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastOperation([NotNull] PhpParser.CastOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.castOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastOperation([NotNull] PhpParser.CastOperationContext context) { }

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
