using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PhpParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IPhpParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.htmlDocument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHtmlDocument([NotNull] PhpParser.HtmlDocumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.htmlDocument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHtmlDocument([NotNull] PhpParser.HtmlDocumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.inlineHtml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInlineHtml([NotNull] PhpParser.InlineHtmlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.inlineHtml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInlineHtml([NotNull] PhpParser.InlineHtmlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.htmlElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHtmlElement([NotNull] PhpParser.HtmlElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.htmlElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHtmlElement([NotNull] PhpParser.HtmlElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.scriptText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScriptText([NotNull] PhpParser.ScriptTextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.scriptText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScriptText([NotNull] PhpParser.ScriptTextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.phpBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPhpBlock([NotNull] PhpParser.PhpBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.phpBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPhpBlock([NotNull] PhpParser.PhpBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportStatement([NotNull] PhpParser.ImportStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportStatement([NotNull] PhpParser.ImportStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.topStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTopStatement([NotNull] PhpParser.TopStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.topStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTopStatement([NotNull] PhpParser.TopStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUseDeclaration([NotNull] PhpParser.UseDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUseDeclaration([NotNull] PhpParser.UseDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclarationContentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUseDeclarationContentList([NotNull] PhpParser.UseDeclarationContentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclarationContentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUseDeclarationContentList([NotNull] PhpParser.UseDeclarationContentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.useDeclarationContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUseDeclarationContent([NotNull] PhpParser.UseDeclarationContentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.useDeclarationContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUseDeclarationContent([NotNull] PhpParser.UseDeclarationContentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceDeclaration([NotNull] PhpParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceDeclaration([NotNull] PhpParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceStatement([NotNull] PhpParser.NamespaceStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceStatement([NotNull] PhpParser.NamespaceStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclaration([NotNull] PhpParser.FunctionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclaration([NotNull] PhpParser.FunctionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] PhpParser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] PhpParser.ClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classEntryType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassEntryType([NotNull] PhpParser.ClassEntryTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classEntryType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassEntryType([NotNull] PhpParser.ClassEntryTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.interfaceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterfaceList([NotNull] PhpParser.InterfaceListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.interfaceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterfaceList([NotNull] PhpParser.InterfaceListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterListInBrackets"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterListInBrackets([NotNull] PhpParser.TypeParameterListInBracketsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterListInBrackets"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterListInBrackets([NotNull] PhpParser.TypeParameterListInBracketsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterList([NotNull] PhpParser.TypeParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterList([NotNull] PhpParser.TypeParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterWithDefaultsList([NotNull] PhpParser.TypeParameterWithDefaultsListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultsList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterWithDefaultsList([NotNull] PhpParser.TypeParameterWithDefaultsListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterDecl([NotNull] PhpParser.TypeParameterDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterDecl([NotNull] PhpParser.TypeParameterDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeParameterWithDefaultDecl([NotNull] PhpParser.TypeParameterWithDefaultDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeParameterWithDefaultDecl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeParameterWithDefaultDecl([NotNull] PhpParser.TypeParameterWithDefaultDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.genericDynamicArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenericDynamicArgs([NotNull] PhpParser.GenericDynamicArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.genericDynamicArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenericDynamicArgs([NotNull] PhpParser.GenericDynamicArgsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributes([NotNull] PhpParser.AttributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributes([NotNull] PhpParser.AttributesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attributeGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeGroup([NotNull] PhpParser.AttributeGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attributeGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeGroup([NotNull] PhpParser.AttributeGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] PhpParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] PhpParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.innerStatementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInnerStatementList([NotNull] PhpParser.InnerStatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.innerStatementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInnerStatementList([NotNull] PhpParser.InnerStatementListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.innerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInnerStatement([NotNull] PhpParser.InnerStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.innerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInnerStatement([NotNull] PhpParser.InnerStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] PhpParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] PhpParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement_([NotNull] PhpParser.EmptyStatement_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement_([NotNull] PhpParser.EmptyStatement_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockStatement([NotNull] PhpParser.BlockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockStatement([NotNull] PhpParser.BlockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] PhpParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] PhpParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseIfStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfStatement([NotNull] PhpParser.ElseIfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseIfStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfStatement([NotNull] PhpParser.ElseIfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseIfColonStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfColonStatement([NotNull] PhpParser.ElseIfColonStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseIfColonStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfColonStatement([NotNull] PhpParser.ElseIfColonStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseStatement([NotNull] PhpParser.ElseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseStatement([NotNull] PhpParser.ElseStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.elseColonStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseColonStatement([NotNull] PhpParser.ElseColonStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.elseColonStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseColonStatement([NotNull] PhpParser.ElseColonStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] PhpParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] PhpParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.doWhileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoWhileStatement([NotNull] PhpParser.DoWhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.doWhileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoWhileStatement([NotNull] PhpParser.DoWhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] PhpParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] PhpParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForInit([NotNull] PhpParser.ForInitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForInit([NotNull] PhpParser.ForInitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForUpdate([NotNull] PhpParser.ForUpdateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.forUpdate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForUpdate([NotNull] PhpParser.ForUpdateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchStatement([NotNull] PhpParser.SwitchStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchStatement([NotNull] PhpParser.SwitchStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchBlock([NotNull] PhpParser.SwitchBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.switchBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchBlock([NotNull] PhpParser.SwitchBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakStatement([NotNull] PhpParser.BreakStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakStatement([NotNull] PhpParser.BreakStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinueStatement([NotNull] PhpParser.ContinueStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinueStatement([NotNull] PhpParser.ContinueStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] PhpParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] PhpParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] PhpParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] PhpParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.unsetStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnsetStatement([NotNull] PhpParser.UnsetStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.unsetStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnsetStatement([NotNull] PhpParser.UnsetStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.foreachStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeachStatement([NotNull] PhpParser.ForeachStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.foreachStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeachStatement([NotNull] PhpParser.ForeachStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.tryCatchFinally"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryCatchFinally([NotNull] PhpParser.TryCatchFinallyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.tryCatchFinally"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryCatchFinally([NotNull] PhpParser.TryCatchFinallyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchClause([NotNull] PhpParser.CatchClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchClause([NotNull] PhpParser.CatchClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.finallyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFinallyStatement([NotNull] PhpParser.FinallyStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.finallyStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFinallyStatement([NotNull] PhpParser.FinallyStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] PhpParser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] PhpParser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGotoStatement([NotNull] PhpParser.GotoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.gotoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGotoStatement([NotNull] PhpParser.GotoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.declareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclareStatement([NotNull] PhpParser.DeclareStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.declareStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclareStatement([NotNull] PhpParser.DeclareStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.inlineHtmlStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInlineHtmlStatement([NotNull] PhpParser.InlineHtmlStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.inlineHtmlStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInlineHtmlStatement([NotNull] PhpParser.InlineHtmlStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.declareList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclareList([NotNull] PhpParser.DeclareListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.declareList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclareList([NotNull] PhpParser.DeclareListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterList([NotNull] PhpParser.FormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterList([NotNull] PhpParser.FormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameter([NotNull] PhpParser.FormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameter([NotNull] PhpParser.FormalParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeHint([NotNull] PhpParser.TypeHintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeHint([NotNull] PhpParser.TypeHintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalStatement([NotNull] PhpParser.GlobalStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalStatement([NotNull] PhpParser.GlobalStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalVar([NotNull] PhpParser.GlobalVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalVar([NotNull] PhpParser.GlobalVarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.echoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEchoStatement([NotNull] PhpParser.EchoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.echoStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEchoStatement([NotNull] PhpParser.EchoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.staticVariableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticVariableStatement([NotNull] PhpParser.StaticVariableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.staticVariableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticVariableStatement([NotNull] PhpParser.StaticVariableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassStatement([NotNull] PhpParser.ClassStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassStatement([NotNull] PhpParser.ClassStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAdaptations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraitAdaptations([NotNull] PhpParser.TraitAdaptationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAdaptations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraitAdaptations([NotNull] PhpParser.TraitAdaptationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAdaptationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraitAdaptationStatement([NotNull] PhpParser.TraitAdaptationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAdaptationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraitAdaptationStatement([NotNull] PhpParser.TraitAdaptationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitPrecedence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraitPrecedence([NotNull] PhpParser.TraitPrecedenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitPrecedence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraitPrecedence([NotNull] PhpParser.TraitPrecedenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraitAlias([NotNull] PhpParser.TraitAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraitAlias([NotNull] PhpParser.TraitAliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.traitMethodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTraitMethodReference([NotNull] PhpParser.TraitMethodReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.traitMethodReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTraitMethodReference([NotNull] PhpParser.TraitMethodReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.baseCtorCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseCtorCall([NotNull] PhpParser.BaseCtorCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.baseCtorCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseCtorCall([NotNull] PhpParser.BaseCtorCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] PhpParser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] PhpParser.MethodBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.propertyModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyModifiers([NotNull] PhpParser.PropertyModifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.propertyModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyModifiers([NotNull] PhpParser.PropertyModifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberModifiers([NotNull] PhpParser.MemberModifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberModifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberModifiers([NotNull] PhpParser.MemberModifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializer([NotNull] PhpParser.VariableInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializer([NotNull] PhpParser.VariableInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.identifierInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierInitializer([NotNull] PhpParser.IdentifierInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.identifierInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierInitializer([NotNull] PhpParser.IdentifierInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.globalConstantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobalConstantDeclaration([NotNull] PhpParser.GlobalConstantDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.globalConstantDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobalConstantDeclaration([NotNull] PhpParser.GlobalConstantDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionList([NotNull] PhpParser.ExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionList([NotNull] PhpParser.ExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.parentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] PhpParser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.parentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] PhpParser.ParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ChainExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChainExpression([NotNull] PhpParser.ChainExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ChainExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChainExpression([NotNull] PhpParser.ChainExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SpecialWordExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecialWordExpression([NotNull] PhpParser.SpecialWordExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SpecialWordExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecialWordExpression([NotNull] PhpParser.SpecialWordExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayCreationExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayCreationExpression([NotNull] PhpParser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayCreationExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayCreationExpression([NotNull] PhpParser.ArrayCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BackQuoteStringExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackQuoteStringExpression([NotNull] PhpParser.BackQuoteStringExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BackQuoteStringExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackQuoteStringExpression([NotNull] PhpParser.BackQuoteStringExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MatchExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatchExpression([NotNull] PhpParser.MatchExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MatchExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatchExpression([NotNull] PhpParser.MatchExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalExpression([NotNull] PhpParser.LogicalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalExpression([NotNull] PhpParser.LogicalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PrintExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintExpression([NotNull] PhpParser.PrintExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PrintExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintExpression([NotNull] PhpParser.PrintExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] PhpParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] PhpParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PostfixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixIncDecExpression([NotNull] PhpParser.PostfixIncDecExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PostfixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixIncDecExpression([NotNull] PhpParser.PostfixIncDecExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CloneExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCloneExpression([NotNull] PhpParser.CloneExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CloneExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCloneExpression([NotNull] PhpParser.CloneExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryOperatorExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOperatorExpression([NotNull] PhpParser.UnaryOperatorExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryOperatorExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOperatorExpression([NotNull] PhpParser.UnaryOperatorExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewExpression([NotNull] PhpParser.NewExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewExpression([NotNull] PhpParser.NewExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesisExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesisExpression([NotNull] PhpParser.ParenthesisExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesisExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesisExpression([NotNull] PhpParser.ParenthesisExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SpaceshipExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpaceshipExpression([NotNull] PhpParser.SpaceshipExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SpaceshipExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpaceshipExpression([NotNull] PhpParser.SpaceshipExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ConditionalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalExpression([NotNull] PhpParser.ConditionalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ConditionalExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalExpression([NotNull] PhpParser.ConditionalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NullCoalescingExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullCoalescingExpression([NotNull] PhpParser.NullCoalescingExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NullCoalescingExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullCoalescingExpression([NotNull] PhpParser.NullCoalescingExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArithmeticExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArithmeticExpression([NotNull] PhpParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArithmeticExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArithmeticExpression([NotNull] PhpParser.ArithmeticExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IndexerExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexerExpression([NotNull] PhpParser.IndexerExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IndexerExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexerExpression([NotNull] PhpParser.IndexerExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ScalarExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScalarExpression([NotNull] PhpParser.ScalarExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ScalarExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScalarExpression([NotNull] PhpParser.ScalarExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PrefixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixIncDecExpression([NotNull] PhpParser.PrefixIncDecExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PrefixIncDecExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixIncDecExpression([NotNull] PhpParser.PrefixIncDecExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparisonExpression([NotNull] PhpParser.ComparisonExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComparisonExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparisonExpression([NotNull] PhpParser.ComparisonExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CastExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastExpression([NotNull] PhpParser.CastExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CastExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastExpression([NotNull] PhpParser.CastExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>InstanceOfExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceOfExpression([NotNull] PhpParser.InstanceOfExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstanceOfExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceOfExpression([NotNull] PhpParser.InstanceOfExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LambdaFunctionExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaFunctionExpression([NotNull] PhpParser.LambdaFunctionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LambdaFunctionExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaFunctionExpression([NotNull] PhpParser.LambdaFunctionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitwiseExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitwiseExpression([NotNull] PhpParser.BitwiseExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitwiseExpression</c>
	/// labeled alternative in <see cref="PhpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitwiseExpression([NotNull] PhpParser.BitwiseExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignable([NotNull] PhpParser.AssignableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignable([NotNull] PhpParser.AssignableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayCreation([NotNull] PhpParser.ArrayCreationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayCreation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayCreation([NotNull] PhpParser.ArrayCreationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaFunctionExpr([NotNull] PhpParser.LambdaFunctionExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaFunctionExpr([NotNull] PhpParser.LambdaFunctionExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.matchExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatchExpr([NotNull] PhpParser.MatchExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.matchExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatchExpr([NotNull] PhpParser.MatchExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.matchItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMatchItem([NotNull] PhpParser.MatchItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.matchItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMatchItem([NotNull] PhpParser.MatchItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.newExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewExpr([NotNull] PhpParser.NewExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.newExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewExpr([NotNull] PhpParser.NewExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] PhpParser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] PhpParser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.yieldExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYieldExpression([NotNull] PhpParser.YieldExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.yieldExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYieldExpression([NotNull] PhpParser.YieldExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayItemList([NotNull] PhpParser.ArrayItemListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayItemList([NotNull] PhpParser.ArrayItemListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arrayItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayItem([NotNull] PhpParser.ArrayItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arrayItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayItem([NotNull] PhpParser.ArrayItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaFunctionUseVars([NotNull] PhpParser.LambdaFunctionUseVarsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVars"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaFunctionUseVars([NotNull] PhpParser.LambdaFunctionUseVarsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaFunctionUseVar([NotNull] PhpParser.LambdaFunctionUseVarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.lambdaFunctionUseVar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaFunctionUseVar([NotNull] PhpParser.LambdaFunctionUseVarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedStaticTypeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedStaticTypeRef([NotNull] PhpParser.QualifiedStaticTypeRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedStaticTypeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedStaticTypeRef([NotNull] PhpParser.QualifiedStaticTypeRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.typeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeRef([NotNull] PhpParser.TypeRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.typeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeRef([NotNull] PhpParser.TypeRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.anonymousClass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymousClass([NotNull] PhpParser.AnonymousClassContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.anonymousClass"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymousClass([NotNull] PhpParser.AnonymousClassContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.indirectTypeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndirectTypeRef([NotNull] PhpParser.IndirectTypeRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.indirectTypeRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndirectTypeRef([NotNull] PhpParser.IndirectTypeRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedNamespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedNamespaceName([NotNull] PhpParser.QualifiedNamespaceNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedNamespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedNamespaceName([NotNull] PhpParser.QualifiedNamespaceNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceNameList([NotNull] PhpParser.NamespaceNameListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceNameList([NotNull] PhpParser.NamespaceNameListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.namespaceNameTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespaceNameTail([NotNull] PhpParser.NamespaceNameTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.namespaceNameTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespaceNameTail([NotNull] PhpParser.NamespaceNameTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.qualifiedNamespaceNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedNamespaceNameList([NotNull] PhpParser.QualifiedNamespaceNameListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.qualifiedNamespaceNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedNamespaceNameList([NotNull] PhpParser.QualifiedNamespaceNameListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] PhpParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] PhpParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.actualArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterActualArgument([NotNull] PhpParser.ActualArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.actualArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitActualArgument([NotNull] PhpParser.ActualArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.argumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentName([NotNull] PhpParser.ArgumentNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.argumentName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentName([NotNull] PhpParser.ArgumentNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.constantInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantInitializer([NotNull] PhpParser.ConstantInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.constantInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantInitializer([NotNull] PhpParser.ConstantInitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] PhpParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] PhpParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.literalConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralConstant([NotNull] PhpParser.LiteralConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.literalConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralConstant([NotNull] PhpParser.LiteralConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.numericConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericConstant([NotNull] PhpParser.NumericConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.numericConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericConstant([NotNull] PhpParser.NumericConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.classConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassConstant([NotNull] PhpParser.ClassConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.classConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassConstant([NotNull] PhpParser.ClassConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.stringConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringConstant([NotNull] PhpParser.StringConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.stringConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringConstant([NotNull] PhpParser.StringConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] PhpParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] PhpParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.interpolatedStringPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolatedStringPart([NotNull] PhpParser.InterpolatedStringPartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.interpolatedStringPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolatedStringPart([NotNull] PhpParser.InterpolatedStringPartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChainList([NotNull] PhpParser.ChainListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChainList([NotNull] PhpParser.ChainListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChain([NotNull] PhpParser.ChainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChain([NotNull] PhpParser.ChainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainOrigin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChainOrigin([NotNull] PhpParser.ChainOriginContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainOrigin"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChainOrigin([NotNull] PhpParser.ChainOriginContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberAccess([NotNull] PhpParser.MemberAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberAccess([NotNull] PhpParser.MemberAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] PhpParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] PhpParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.functionCallName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallName([NotNull] PhpParser.FunctionCallNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.functionCallName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallName([NotNull] PhpParser.FunctionCallNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.actualArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterActualArguments([NotNull] PhpParser.ActualArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.actualArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitActualArguments([NotNull] PhpParser.ActualArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.chainBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChainBase([NotNull] PhpParser.ChainBaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.chainBase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChainBase([NotNull] PhpParser.ChainBaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedFieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyedFieldName([NotNull] PhpParser.KeyedFieldNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedFieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyedFieldName([NotNull] PhpParser.KeyedFieldNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedSimpleFieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyedSimpleFieldName([NotNull] PhpParser.KeyedSimpleFieldNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedSimpleFieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyedSimpleFieldName([NotNull] PhpParser.KeyedSimpleFieldNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.keyedVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyedVariable([NotNull] PhpParser.KeyedVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.keyedVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyedVariable([NotNull] PhpParser.KeyedVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.squareCurlyExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSquareCurlyExpression([NotNull] PhpParser.SquareCurlyExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.squareCurlyExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSquareCurlyExpression([NotNull] PhpParser.SquareCurlyExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentList([NotNull] PhpParser.AssignmentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentList([NotNull] PhpParser.AssignmentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.assignmentListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentListElement([NotNull] PhpParser.AssignmentListElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.assignmentListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentListElement([NotNull] PhpParser.AssignmentListElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModifier([NotNull] PhpParser.ModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModifier([NotNull] PhpParser.ModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] PhpParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] PhpParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.memberModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberModifier([NotNull] PhpParser.MemberModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.memberModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberModifier([NotNull] PhpParser.MemberModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.magicConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMagicConstant([NotNull] PhpParser.MagicConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.magicConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMagicConstant([NotNull] PhpParser.MagicConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.magicMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMagicMethod([NotNull] PhpParser.MagicMethodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.magicMethod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMagicMethod([NotNull] PhpParser.MagicMethodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] PhpParser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] PhpParser.PrimitiveTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PhpParser.castOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastOperation([NotNull] PhpParser.CastOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PhpParser.castOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastOperation([NotNull] PhpParser.CastOperationContext context);
}
