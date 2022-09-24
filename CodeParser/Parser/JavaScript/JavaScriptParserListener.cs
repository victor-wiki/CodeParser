using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="JavaScriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IJavaScriptParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] JavaScriptParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] JavaScriptParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.sourceElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceElement([NotNull] JavaScriptParser.SourceElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.sourceElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceElement([NotNull] JavaScriptParser.SourceElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] JavaScriptParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] JavaScriptParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] JavaScriptParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] JavaScriptParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementList([NotNull] JavaScriptParser.StatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.statementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementList([NotNull] JavaScriptParser.StatementListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportStatement([NotNull] JavaScriptParser.ImportStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportStatement([NotNull] JavaScriptParser.ImportStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.importFromBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportFromBlock([NotNull] JavaScriptParser.ImportFromBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.importFromBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportFromBlock([NotNull] JavaScriptParser.ImportFromBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.moduleItems"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModuleItems([NotNull] JavaScriptParser.ModuleItemsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.moduleItems"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModuleItems([NotNull] JavaScriptParser.ModuleItemsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.importDefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDefault([NotNull] JavaScriptParser.ImportDefaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.importDefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDefault([NotNull] JavaScriptParser.ImportDefaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.importNamespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportNamespace([NotNull] JavaScriptParser.ImportNamespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.importNamespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportNamespace([NotNull] JavaScriptParser.ImportNamespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.importFrom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportFrom([NotNull] JavaScriptParser.ImportFromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.importFrom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportFrom([NotNull] JavaScriptParser.ImportFromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.aliasName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAliasName([NotNull] JavaScriptParser.AliasNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.aliasName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAliasName([NotNull] JavaScriptParser.AliasNameContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExportDeclaration</c>
	/// labeled alternative in <see cref="JavaScriptParser.exportStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExportDeclaration([NotNull] JavaScriptParser.ExportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExportDeclaration</c>
	/// labeled alternative in <see cref="JavaScriptParser.exportStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExportDeclaration([NotNull] JavaScriptParser.ExportDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ExportDefaultDeclaration</c>
	/// labeled alternative in <see cref="JavaScriptParser.exportStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExportDefaultDeclaration([NotNull] JavaScriptParser.ExportDefaultDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ExportDefaultDeclaration</c>
	/// labeled alternative in <see cref="JavaScriptParser.exportStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExportDefaultDeclaration([NotNull] JavaScriptParser.ExportDefaultDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.exportFromBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExportFromBlock([NotNull] JavaScriptParser.ExportFromBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.exportFromBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExportFromBlock([NotNull] JavaScriptParser.ExportFromBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] JavaScriptParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] JavaScriptParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.variableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableStatement([NotNull] JavaScriptParser.VariableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.variableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableStatement([NotNull] JavaScriptParser.VariableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.variableDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarationList([NotNull] JavaScriptParser.VariableDeclarationListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.variableDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarationList([NotNull] JavaScriptParser.VariableDeclarationListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaration([NotNull] JavaScriptParser.VariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaration([NotNull] JavaScriptParser.VariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptyStatement_([NotNull] JavaScriptParser.EmptyStatement_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.emptyStatement_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptyStatement_([NotNull] JavaScriptParser.EmptyStatement_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] JavaScriptParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] JavaScriptParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] JavaScriptParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] JavaScriptParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DoStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoStatement([NotNull] JavaScriptParser.DoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DoStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoStatement([NotNull] JavaScriptParser.DoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] JavaScriptParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>WhileStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] JavaScriptParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] JavaScriptParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] JavaScriptParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ForInStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForInStatement([NotNull] JavaScriptParser.ForInStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ForInStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForInStatement([NotNull] JavaScriptParser.ForInStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ForOfStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForOfStatement([NotNull] JavaScriptParser.ForOfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ForOfStatement</c>
	/// labeled alternative in <see cref="JavaScriptParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForOfStatement([NotNull] JavaScriptParser.ForOfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.varModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarModifier([NotNull] JavaScriptParser.VarModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.varModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarModifier([NotNull] JavaScriptParser.VarModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinueStatement([NotNull] JavaScriptParser.ContinueStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.continueStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinueStatement([NotNull] JavaScriptParser.ContinueStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakStatement([NotNull] JavaScriptParser.BreakStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.breakStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakStatement([NotNull] JavaScriptParser.BreakStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] JavaScriptParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] JavaScriptParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.yieldStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYieldStatement([NotNull] JavaScriptParser.YieldStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.yieldStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYieldStatement([NotNull] JavaScriptParser.YieldStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.withStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithStatement([NotNull] JavaScriptParser.WithStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.withStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithStatement([NotNull] JavaScriptParser.WithStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchStatement([NotNull] JavaScriptParser.SwitchStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.switchStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchStatement([NotNull] JavaScriptParser.SwitchStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.caseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaseBlock([NotNull] JavaScriptParser.CaseBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.caseBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaseBlock([NotNull] JavaScriptParser.CaseBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.caseClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaseClauses([NotNull] JavaScriptParser.CaseClausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.caseClauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaseClauses([NotNull] JavaScriptParser.CaseClausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.caseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaseClause([NotNull] JavaScriptParser.CaseClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.caseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaseClause([NotNull] JavaScriptParser.CaseClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.defaultClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultClause([NotNull] JavaScriptParser.DefaultClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.defaultClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultClause([NotNull] JavaScriptParser.DefaultClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.labelledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelledStatement([NotNull] JavaScriptParser.LabelledStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.labelledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelledStatement([NotNull] JavaScriptParser.LabelledStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] JavaScriptParser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.throwStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] JavaScriptParser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryStatement([NotNull] JavaScriptParser.TryStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.tryStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryStatement([NotNull] JavaScriptParser.TryStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.catchProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatchProduction([NotNull] JavaScriptParser.CatchProductionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.catchProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatchProduction([NotNull] JavaScriptParser.CatchProductionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.finallyProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFinallyProduction([NotNull] JavaScriptParser.FinallyProductionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.finallyProduction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFinallyProduction([NotNull] JavaScriptParser.FinallyProductionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.debuggerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDebuggerStatement([NotNull] JavaScriptParser.DebuggerStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.debuggerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDebuggerStatement([NotNull] JavaScriptParser.DebuggerStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclaration([NotNull] JavaScriptParser.FunctionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclaration([NotNull] JavaScriptParser.FunctionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] JavaScriptParser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] JavaScriptParser.ClassDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.classTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassTail([NotNull] JavaScriptParser.ClassTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.classTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassTail([NotNull] JavaScriptParser.ClassTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.classElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassElement([NotNull] JavaScriptParser.ClassElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.classElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassElement([NotNull] JavaScriptParser.ClassElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.methodDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDefinition([NotNull] JavaScriptParser.MethodDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.methodDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDefinition([NotNull] JavaScriptParser.MethodDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterList([NotNull] JavaScriptParser.FormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterList([NotNull] JavaScriptParser.FormalParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.formalParameterArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterArg([NotNull] JavaScriptParser.FormalParameterArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.formalParameterArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterArg([NotNull] JavaScriptParser.FormalParameterArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.lastFormalParameterArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLastFormalParameterArg([NotNull] JavaScriptParser.LastFormalParameterArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.lastFormalParameterArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLastFormalParameterArg([NotNull] JavaScriptParser.LastFormalParameterArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionBody([NotNull] JavaScriptParser.FunctionBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionBody([NotNull] JavaScriptParser.FunctionBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.sourceElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSourceElements([NotNull] JavaScriptParser.SourceElementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.sourceElements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSourceElements([NotNull] JavaScriptParser.SourceElementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayLiteral([NotNull] JavaScriptParser.ArrayLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.arrayLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayLiteral([NotNull] JavaScriptParser.ArrayLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.elementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElementList([NotNull] JavaScriptParser.ElementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.elementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElementList([NotNull] JavaScriptParser.ElementListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.arrayElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayElement([NotNull] JavaScriptParser.ArrayElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.arrayElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayElement([NotNull] JavaScriptParser.ArrayElementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PropertyExpressionAssignment</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyExpressionAssignment([NotNull] JavaScriptParser.PropertyExpressionAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PropertyExpressionAssignment</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyExpressionAssignment([NotNull] JavaScriptParser.PropertyExpressionAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ComputedPropertyExpressionAssignment</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComputedPropertyExpressionAssignment([NotNull] JavaScriptParser.ComputedPropertyExpressionAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ComputedPropertyExpressionAssignment</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComputedPropertyExpressionAssignment([NotNull] JavaScriptParser.ComputedPropertyExpressionAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionProperty</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionProperty([NotNull] JavaScriptParser.FunctionPropertyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionProperty</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionProperty([NotNull] JavaScriptParser.FunctionPropertyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PropertyGetter</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyGetter([NotNull] JavaScriptParser.PropertyGetterContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PropertyGetter</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyGetter([NotNull] JavaScriptParser.PropertyGetterContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PropertySetter</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertySetter([NotNull] JavaScriptParser.PropertySetterContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PropertySetter</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertySetter([NotNull] JavaScriptParser.PropertySetterContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PropertyShorthand</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyShorthand([NotNull] JavaScriptParser.PropertyShorthandContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PropertyShorthand</c>
	/// labeled alternative in <see cref="JavaScriptParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyShorthand([NotNull] JavaScriptParser.PropertyShorthandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.propertyName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyName([NotNull] JavaScriptParser.PropertyNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.propertyName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyName([NotNull] JavaScriptParser.PropertyNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] JavaScriptParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] JavaScriptParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument([NotNull] JavaScriptParser.ArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument([NotNull] JavaScriptParser.ArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.expressionSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionSequence([NotNull] JavaScriptParser.ExpressionSequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.expressionSequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionSequence([NotNull] JavaScriptParser.ExpressionSequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TemplateStringExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateStringExpression([NotNull] JavaScriptParser.TemplateStringExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TemplateStringExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateStringExpression([NotNull] JavaScriptParser.TemplateStringExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTernaryExpression([NotNull] JavaScriptParser.TernaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TernaryExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTernaryExpression([NotNull] JavaScriptParser.TernaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalAndExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalAndExpression([NotNull] JavaScriptParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalAndExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalAndExpression([NotNull] JavaScriptParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PowerExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPowerExpression([NotNull] JavaScriptParser.PowerExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PowerExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPowerExpression([NotNull] JavaScriptParser.PowerExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PreIncrementExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreIncrementExpression([NotNull] JavaScriptParser.PreIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PreIncrementExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreIncrementExpression([NotNull] JavaScriptParser.PreIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ObjectLiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectLiteralExpression([NotNull] JavaScriptParser.ObjectLiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ObjectLiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectLiteralExpression([NotNull] JavaScriptParser.ObjectLiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MetaExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMetaExpression([NotNull] JavaScriptParser.MetaExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MetaExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMetaExpression([NotNull] JavaScriptParser.MetaExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>InExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInExpression([NotNull] JavaScriptParser.InExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInExpression([NotNull] JavaScriptParser.InExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LogicalOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOrExpression([NotNull] JavaScriptParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LogicalOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOrExpression([NotNull] JavaScriptParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] JavaScriptParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] JavaScriptParser.NotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PreDecreaseExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreDecreaseExpression([NotNull] JavaScriptParser.PreDecreaseExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PreDecreaseExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreDecreaseExpression([NotNull] JavaScriptParser.PreDecreaseExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArgumentsExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentsExpression([NotNull] JavaScriptParser.ArgumentsExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArgumentsExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentsExpression([NotNull] JavaScriptParser.ArgumentsExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AwaitExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAwaitExpression([NotNull] JavaScriptParser.AwaitExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AwaitExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAwaitExpression([NotNull] JavaScriptParser.AwaitExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ThisExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThisExpression([NotNull] JavaScriptParser.ThisExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ThisExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThisExpression([NotNull] JavaScriptParser.ThisExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionExpression([NotNull] JavaScriptParser.FunctionExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionExpression([NotNull] JavaScriptParser.FunctionExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryMinusExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMinusExpression([NotNull] JavaScriptParser.UnaryMinusExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryMinusExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMinusExpression([NotNull] JavaScriptParser.UnaryMinusExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] JavaScriptParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] JavaScriptParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PostDecreaseExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostDecreaseExpression([NotNull] JavaScriptParser.PostDecreaseExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PostDecreaseExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostDecreaseExpression([NotNull] JavaScriptParser.PostDecreaseExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TypeofExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeofExpression([NotNull] JavaScriptParser.TypeofExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TypeofExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeofExpression([NotNull] JavaScriptParser.TypeofExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>InstanceofExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstanceofExpression([NotNull] JavaScriptParser.InstanceofExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>InstanceofExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstanceofExpression([NotNull] JavaScriptParser.InstanceofExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryPlusExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryPlusExpression([NotNull] JavaScriptParser.UnaryPlusExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryPlusExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryPlusExpression([NotNull] JavaScriptParser.UnaryPlusExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DeleteExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteExpression([NotNull] JavaScriptParser.DeleteExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DeleteExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteExpression([NotNull] JavaScriptParser.DeleteExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ImportExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportExpression([NotNull] JavaScriptParser.ImportExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ImportExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportExpression([NotNull] JavaScriptParser.ImportExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>EqualityExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] JavaScriptParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>EqualityExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] JavaScriptParser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitXOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitXOrExpression([NotNull] JavaScriptParser.BitXOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitXOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitXOrExpression([NotNull] JavaScriptParser.BitXOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SuperExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSuperExpression([NotNull] JavaScriptParser.SuperExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SuperExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSuperExpression([NotNull] JavaScriptParser.SuperExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] JavaScriptParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] JavaScriptParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitShiftExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitShiftExpression([NotNull] JavaScriptParser.BitShiftExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitShiftExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitShiftExpression([NotNull] JavaScriptParser.BitShiftExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesizedExpression([NotNull] JavaScriptParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ParenthesizedExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesizedExpression([NotNull] JavaScriptParser.ParenthesizedExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] JavaScriptParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] JavaScriptParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] JavaScriptParser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RelationalExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] JavaScriptParser.RelationalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PostIncrementExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostIncrementExpression([NotNull] JavaScriptParser.PostIncrementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PostIncrementExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostIncrementExpression([NotNull] JavaScriptParser.PostIncrementExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>YieldExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYieldExpression([NotNull] JavaScriptParser.YieldExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>YieldExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYieldExpression([NotNull] JavaScriptParser.YieldExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitNotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitNotExpression([NotNull] JavaScriptParser.BitNotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitNotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitNotExpression([NotNull] JavaScriptParser.BitNotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewExpression([NotNull] JavaScriptParser.NewExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewExpression([NotNull] JavaScriptParser.NewExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralExpression([NotNull] JavaScriptParser.LiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralExpression([NotNull] JavaScriptParser.LiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayLiteralExpression([NotNull] JavaScriptParser.ArrayLiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrayLiteralExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayLiteralExpression([NotNull] JavaScriptParser.ArrayLiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MemberDotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberDotExpression([NotNull] JavaScriptParser.MemberDotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MemberDotExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberDotExpression([NotNull] JavaScriptParser.MemberDotExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ClassExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassExpression([NotNull] JavaScriptParser.ClassExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ClassExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassExpression([NotNull] JavaScriptParser.ClassExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MemberIndexExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberIndexExpression([NotNull] JavaScriptParser.MemberIndexExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MemberIndexExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberIndexExpression([NotNull] JavaScriptParser.MemberIndexExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] JavaScriptParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IdentifierExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] JavaScriptParser.IdentifierExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitAndExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitAndExpression([NotNull] JavaScriptParser.BitAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitAndExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitAndExpression([NotNull] JavaScriptParser.BitAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BitOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitOrExpression([NotNull] JavaScriptParser.BitOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BitOrExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitOrExpression([NotNull] JavaScriptParser.BitOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AssignmentOperatorExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperatorExpression([NotNull] JavaScriptParser.AssignmentOperatorExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AssignmentOperatorExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperatorExpression([NotNull] JavaScriptParser.AssignmentOperatorExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>VoidExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoidExpression([NotNull] JavaScriptParser.VoidExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>VoidExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoidExpression([NotNull] JavaScriptParser.VoidExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCoalesceExpression([NotNull] JavaScriptParser.CoalesceExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="JavaScriptParser.singleExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCoalesceExpression([NotNull] JavaScriptParser.CoalesceExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.assignable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignable([NotNull] JavaScriptParser.AssignableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.assignable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignable([NotNull] JavaScriptParser.AssignableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.objectLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectLiteral([NotNull] JavaScriptParser.ObjectLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.objectLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectLiteral([NotNull] JavaScriptParser.ObjectLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FunctionDecl</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDecl([NotNull] JavaScriptParser.FunctionDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FunctionDecl</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDecl([NotNull] JavaScriptParser.FunctionDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AnonymousFunctionDecl</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymousFunctionDecl([NotNull] JavaScriptParser.AnonymousFunctionDeclContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AnonymousFunctionDecl</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymousFunctionDecl([NotNull] JavaScriptParser.AnonymousFunctionDeclContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ArrowFunction</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrowFunction([NotNull] JavaScriptParser.ArrowFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ArrowFunction</c>
	/// labeled alternative in <see cref="JavaScriptParser.anonymousFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrowFunction([NotNull] JavaScriptParser.ArrowFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.arrowFunctionParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrowFunctionParameters([NotNull] JavaScriptParser.ArrowFunctionParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.arrowFunctionParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrowFunctionParameters([NotNull] JavaScriptParser.ArrowFunctionParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.arrowFunctionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrowFunctionBody([NotNull] JavaScriptParser.ArrowFunctionBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.arrowFunctionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrowFunctionBody([NotNull] JavaScriptParser.ArrowFunctionBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] JavaScriptParser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] JavaScriptParser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] JavaScriptParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] JavaScriptParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateStringLiteral([NotNull] JavaScriptParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.templateStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateStringLiteral([NotNull] JavaScriptParser.TemplateStringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateStringAtom([NotNull] JavaScriptParser.TemplateStringAtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.templateStringAtom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateStringAtom([NotNull] JavaScriptParser.TemplateStringAtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericLiteral([NotNull] JavaScriptParser.NumericLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.numericLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericLiteral([NotNull] JavaScriptParser.NumericLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.bigintLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBigintLiteral([NotNull] JavaScriptParser.BigintLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.bigintLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBigintLiteral([NotNull] JavaScriptParser.BigintLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.getter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetter([NotNull] JavaScriptParser.GetterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.getter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetter([NotNull] JavaScriptParser.GetterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.setter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetter([NotNull] JavaScriptParser.SetterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.setter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetter([NotNull] JavaScriptParser.SetterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.identifierName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierName([NotNull] JavaScriptParser.IdentifierNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.identifierName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierName([NotNull] JavaScriptParser.IdentifierNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] JavaScriptParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] JavaScriptParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.reservedWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReservedWord([NotNull] JavaScriptParser.ReservedWordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.reservedWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReservedWord([NotNull] JavaScriptParser.ReservedWordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] JavaScriptParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] JavaScriptParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.let_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLet_([NotNull] JavaScriptParser.Let_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.let_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLet_([NotNull] JavaScriptParser.Let_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="JavaScriptParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEos([NotNull] JavaScriptParser.EosContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="JavaScriptParser.eos"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEos([NotNull] JavaScriptParser.EosContext context);
}
