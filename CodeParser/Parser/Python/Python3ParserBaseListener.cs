using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPython3ParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class Python3ParserBaseListener : IPython3ParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.single_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_input([NotNull] Python3Parser.Single_inputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.single_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_input([NotNull] Python3Parser.Single_inputContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.file_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_input([NotNull] Python3Parser.File_inputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.file_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_input([NotNull] Python3Parser.File_inputContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.eval_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEval_input([NotNull] Python3Parser.Eval_inputContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.eval_input"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEval_input([NotNull] Python3Parser.Eval_inputContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.decorator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecorator([NotNull] Python3Parser.DecoratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.decorator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecorator([NotNull] Python3Parser.DecoratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.decorators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecorators([NotNull] Python3Parser.DecoratorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.decorators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecorators([NotNull] Python3Parser.DecoratorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.decorated"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecorated([NotNull] Python3Parser.DecoratedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.decorated"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecorated([NotNull] Python3Parser.DecoratedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.async_funcdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsync_funcdef([NotNull] Python3Parser.Async_funcdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.async_funcdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsync_funcdef([NotNull] Python3Parser.Async_funcdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.funcdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFuncdef([NotNull] Python3Parser.FuncdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.funcdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFuncdef([NotNull] Python3Parser.FuncdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameters([NotNull] Python3Parser.ParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameters([NotNull] Python3Parser.ParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.typedargslist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypedargslist([NotNull] Python3Parser.TypedargslistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.typedargslist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypedargslist([NotNull] Python3Parser.TypedargslistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.tfpdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTfpdef([NotNull] Python3Parser.TfpdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.tfpdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTfpdef([NotNull] Python3Parser.TfpdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.varargslist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarargslist([NotNull] Python3Parser.VarargslistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.varargslist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarargslist([NotNull] Python3Parser.VarargslistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.vfpdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVfpdef([NotNull] Python3Parser.VfpdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.vfpdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVfpdef([NotNull] Python3Parser.VfpdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt([NotNull] Python3Parser.StmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt([NotNull] Python3Parser.StmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.simple_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_stmt([NotNull] Python3Parser.Simple_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.simple_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_stmt([NotNull] Python3Parser.Simple_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.small_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSmall_stmt([NotNull] Python3Parser.Small_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.small_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSmall_stmt([NotNull] Python3Parser.Small_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.expr_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_stmt([NotNull] Python3Parser.Expr_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.expr_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_stmt([NotNull] Python3Parser.Expr_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.annassign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnnassign([NotNull] Python3Parser.AnnassignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.annassign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnnassign([NotNull] Python3Parser.AnnassignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.testlist_star_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTestlist_star_expr([NotNull] Python3Parser.Testlist_star_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.testlist_star_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTestlist_star_expr([NotNull] Python3Parser.Testlist_star_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.augassign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAugassign([NotNull] Python3Parser.AugassignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.augassign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAugassign([NotNull] Python3Parser.AugassignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.del_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDel_stmt([NotNull] Python3Parser.Del_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.del_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDel_stmt([NotNull] Python3Parser.Del_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.pass_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPass_stmt([NotNull] Python3Parser.Pass_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.pass_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPass_stmt([NotNull] Python3Parser.Pass_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.flow_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlow_stmt([NotNull] Python3Parser.Flow_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.flow_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlow_stmt([NotNull] Python3Parser.Flow_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.break_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreak_stmt([NotNull] Python3Parser.Break_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.break_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreak_stmt([NotNull] Python3Parser.Break_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.continue_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinue_stmt([NotNull] Python3Parser.Continue_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.continue_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinue_stmt([NotNull] Python3Parser.Continue_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.return_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_stmt([NotNull] Python3Parser.Return_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.return_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_stmt([NotNull] Python3Parser.Return_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.yield_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYield_stmt([NotNull] Python3Parser.Yield_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.yield_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYield_stmt([NotNull] Python3Parser.Yield_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.raise_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRaise_stmt([NotNull] Python3Parser.Raise_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.raise_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRaise_stmt([NotNull] Python3Parser.Raise_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.import_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_stmt([NotNull] Python3Parser.Import_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.import_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_stmt([NotNull] Python3Parser.Import_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.import_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_name([NotNull] Python3Parser.Import_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.import_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_name([NotNull] Python3Parser.Import_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.import_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_from([NotNull] Python3Parser.Import_fromContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.import_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_from([NotNull] Python3Parser.Import_fromContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.import_as_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_as_name([NotNull] Python3Parser.Import_as_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.import_as_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_as_name([NotNull] Python3Parser.Import_as_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.dotted_as_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDotted_as_name([NotNull] Python3Parser.Dotted_as_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.dotted_as_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDotted_as_name([NotNull] Python3Parser.Dotted_as_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.import_as_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_as_names([NotNull] Python3Parser.Import_as_namesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.import_as_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_as_names([NotNull] Python3Parser.Import_as_namesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.dotted_as_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDotted_as_names([NotNull] Python3Parser.Dotted_as_namesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.dotted_as_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDotted_as_names([NotNull] Python3Parser.Dotted_as_namesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.dotted_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDotted_name([NotNull] Python3Parser.Dotted_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.dotted_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDotted_name([NotNull] Python3Parser.Dotted_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.global_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobal_stmt([NotNull] Python3Parser.Global_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.global_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobal_stmt([NotNull] Python3Parser.Global_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.nonlocal_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNonlocal_stmt([NotNull] Python3Parser.Nonlocal_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.nonlocal_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNonlocal_stmt([NotNull] Python3Parser.Nonlocal_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.assert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssert_stmt([NotNull] Python3Parser.Assert_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.assert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssert_stmt([NotNull] Python3Parser.Assert_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.compound_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_stmt([NotNull] Python3Parser.Compound_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.compound_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_stmt([NotNull] Python3Parser.Compound_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.async_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsync_stmt([NotNull] Python3Parser.Async_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.async_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsync_stmt([NotNull] Python3Parser.Async_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.if_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_stmt([NotNull] Python3Parser.If_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.if_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_stmt([NotNull] Python3Parser.If_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.while_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_stmt([NotNull] Python3Parser.While_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.while_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_stmt([NotNull] Python3Parser.While_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.for_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_stmt([NotNull] Python3Parser.For_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.for_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_stmt([NotNull] Python3Parser.For_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.try_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTry_stmt([NotNull] Python3Parser.Try_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.try_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTry_stmt([NotNull] Python3Parser.Try_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.with_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_stmt([NotNull] Python3Parser.With_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.with_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_stmt([NotNull] Python3Parser.With_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.with_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_item([NotNull] Python3Parser.With_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.with_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_item([NotNull] Python3Parser.With_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.except_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExcept_clause([NotNull] Python3Parser.Except_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.except_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExcept_clause([NotNull] Python3Parser.Except_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.suite"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSuite([NotNull] Python3Parser.SuiteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.suite"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSuite([NotNull] Python3Parser.SuiteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTest([NotNull] Python3Parser.TestContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTest([NotNull] Python3Parser.TestContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.test_nocond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTest_nocond([NotNull] Python3Parser.Test_nocondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.test_nocond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTest_nocond([NotNull] Python3Parser.Test_nocondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.lambdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdef([NotNull] Python3Parser.LambdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.lambdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdef([NotNull] Python3Parser.LambdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.lambdef_nocond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdef_nocond([NotNull] Python3Parser.Lambdef_nocondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.lambdef_nocond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdef_nocond([NotNull] Python3Parser.Lambdef_nocondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.or_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr_test([NotNull] Python3Parser.Or_testContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.or_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr_test([NotNull] Python3Parser.Or_testContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.and_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd_test([NotNull] Python3Parser.And_testContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.and_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd_test([NotNull] Python3Parser.And_testContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.not_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNot_test([NotNull] Python3Parser.Not_testContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.not_test"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNot_test([NotNull] Python3Parser.Not_testContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison([NotNull] Python3Parser.ComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison([NotNull] Python3Parser.ComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.comp_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_op([NotNull] Python3Parser.Comp_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.comp_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_op([NotNull] Python3Parser.Comp_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.star_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStar_expr([NotNull] Python3Parser.Star_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.star_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStar_expr([NotNull] Python3Parser.Star_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] Python3Parser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] Python3Parser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.xor_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXor_expr([NotNull] Python3Parser.Xor_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.xor_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXor_expr([NotNull] Python3Parser.Xor_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.and_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd_expr([NotNull] Python3Parser.And_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.and_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd_expr([NotNull] Python3Parser.And_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.shift_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShift_expr([NotNull] Python3Parser.Shift_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.shift_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShift_expr([NotNull] Python3Parser.Shift_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.arith_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArith_expr([NotNull] Python3Parser.Arith_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.arith_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArith_expr([NotNull] Python3Parser.Arith_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] Python3Parser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] Python3Parser.TermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] Python3Parser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] Python3Parser.FactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.power"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower([NotNull] Python3Parser.PowerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.power"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower([NotNull] Python3Parser.PowerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.atom_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom_expr([NotNull] Python3Parser.Atom_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.atom_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom_expr([NotNull] Python3Parser.Atom_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] Python3Parser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] Python3Parser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.testlist_comp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTestlist_comp([NotNull] Python3Parser.Testlist_compContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.testlist_comp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTestlist_comp([NotNull] Python3Parser.Testlist_compContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.trailer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrailer([NotNull] Python3Parser.TrailerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.trailer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrailer([NotNull] Python3Parser.TrailerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.subscriptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubscriptlist([NotNull] Python3Parser.SubscriptlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.subscriptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubscriptlist([NotNull] Python3Parser.SubscriptlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.subscript_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubscript_([NotNull] Python3Parser.Subscript_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.subscript_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubscript_([NotNull] Python3Parser.Subscript_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.sliceop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSliceop([NotNull] Python3Parser.SliceopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.sliceop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSliceop([NotNull] Python3Parser.SliceopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.exprlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprlist([NotNull] Python3Parser.ExprlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.exprlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprlist([NotNull] Python3Parser.ExprlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.testlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTestlist([NotNull] Python3Parser.TestlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.testlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTestlist([NotNull] Python3Parser.TestlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.dictorsetmaker"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDictorsetmaker([NotNull] Python3Parser.DictorsetmakerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.dictorsetmaker"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDictorsetmaker([NotNull] Python3Parser.DictorsetmakerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.classdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassdef([NotNull] Python3Parser.ClassdefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.classdef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassdef([NotNull] Python3Parser.ClassdefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.arglist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArglist([NotNull] Python3Parser.ArglistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.arglist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArglist([NotNull] Python3Parser.ArglistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument([NotNull] Python3Parser.ArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument([NotNull] Python3Parser.ArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.comp_iter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_iter([NotNull] Python3Parser.Comp_iterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.comp_iter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_iter([NotNull] Python3Parser.Comp_iterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.comp_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_for([NotNull] Python3Parser.Comp_forContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.comp_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_for([NotNull] Python3Parser.Comp_forContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.comp_if"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_if([NotNull] Python3Parser.Comp_ifContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.comp_if"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_if([NotNull] Python3Parser.Comp_ifContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.encoding_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEncoding_decl([NotNull] Python3Parser.Encoding_declContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.encoding_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEncoding_decl([NotNull] Python3Parser.Encoding_declContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.yield_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYield_expr([NotNull] Python3Parser.Yield_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.yield_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYield_expr([NotNull] Python3Parser.Yield_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="Python3Parser.yield_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYield_arg([NotNull] Python3Parser.Yield_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="Python3Parser.yield_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYield_arg([NotNull] Python3Parser.Yield_argContext context) { }

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
