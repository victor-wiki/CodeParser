using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPostgreSQLParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class PostgreSqlParserBaseListener : IPostgreSqlParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.root"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoot([NotNull] PostgreSqlParser.RootContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.root"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoot([NotNull] PostgreSqlParser.RootContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlroot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsqlroot([NotNull] PostgreSqlParser.PlsqlrootContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlroot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsqlroot([NotNull] PostgreSqlParser.PlsqlrootContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmtblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtblock([NotNull] PostgreSqlParser.StmtblockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmtblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtblock([NotNull] PostgreSqlParser.StmtblockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmtmulti"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmtmulti([NotNull] PostgreSqlParser.StmtmultiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmtmulti"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmtmulti([NotNull] PostgreSqlParser.StmtmultiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt([NotNull] PostgreSqlParser.StmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt([NotNull] PostgreSqlParser.StmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlconsolecommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsqlconsolecommand([NotNull] PostgreSqlParser.PlsqlconsolecommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlconsolecommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsqlconsolecommand([NotNull] PostgreSqlParser.PlsqlconsolecommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.callstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallstmt([NotNull] PostgreSqlParser.CallstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.callstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallstmt([NotNull] PostgreSqlParser.CallstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreaterolestmt([NotNull] PostgreSqlParser.CreaterolestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreaterolestmt([NotNull] PostgreSqlParser.CreaterolestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_with([NotNull] PostgreSqlParser.Opt_withContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_with([NotNull] PostgreSqlParser.Opt_withContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optrolelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptrolelist([NotNull] PostgreSqlParser.OptrolelistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optrolelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptrolelist([NotNull] PostgreSqlParser.OptrolelistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroptrolelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlteroptrolelist([NotNull] PostgreSqlParser.AlteroptrolelistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroptrolelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlteroptrolelist([NotNull] PostgreSqlParser.AlteroptrolelistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroptroleelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlteroptroleelem([NotNull] PostgreSqlParser.AlteroptroleelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroptroleelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlteroptroleelem([NotNull] PostgreSqlParser.AlteroptroleelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createoptroleelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateoptroleelem([NotNull] PostgreSqlParser.CreateoptroleelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createoptroleelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateoptroleelem([NotNull] PostgreSqlParser.CreateoptroleelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createuserstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateuserstmt([NotNull] PostgreSqlParser.CreateuserstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createuserstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateuserstmt([NotNull] PostgreSqlParser.CreateuserstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterrolestmt([NotNull] PostgreSqlParser.AlterrolestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterrolestmt([NotNull] PostgreSqlParser.AlterrolestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_in_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_in_database([NotNull] PostgreSqlParser.Opt_in_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_in_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_in_database([NotNull] PostgreSqlParser.Opt_in_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterrolesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterrolesetstmt([NotNull] PostgreSqlParser.AlterrolesetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterrolesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterrolesetstmt([NotNull] PostgreSqlParser.AlterrolesetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droprolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDroprolestmt([NotNull] PostgreSqlParser.DroprolestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droprolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDroprolestmt([NotNull] PostgreSqlParser.DroprolestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.creategroupstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreategroupstmt([NotNull] PostgreSqlParser.CreategroupstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.creategroupstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreategroupstmt([NotNull] PostgreSqlParser.CreategroupstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altergroupstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltergroupstmt([NotNull] PostgreSqlParser.AltergroupstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altergroupstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltergroupstmt([NotNull] PostgreSqlParser.AltergroupstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.add_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_drop([NotNull] PostgreSqlParser.Add_dropContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.add_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_drop([NotNull] PostgreSqlParser.Add_dropContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateschemastmt([NotNull] PostgreSqlParser.CreateschemastmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateschemastmt([NotNull] PostgreSqlParser.CreateschemastmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optschemaname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptschemaname([NotNull] PostgreSqlParser.OptschemanameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optschemaname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptschemaname([NotNull] PostgreSqlParser.OptschemanameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optschemaeltlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptschemaeltlist([NotNull] PostgreSqlParser.OptschemaeltlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optschemaeltlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptschemaeltlist([NotNull] PostgreSqlParser.OptschemaeltlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.schema_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_stmt([NotNull] PostgreSqlParser.Schema_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.schema_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_stmt([NotNull] PostgreSqlParser.Schema_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variablesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariablesetstmt([NotNull] PostgreSqlParser.VariablesetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variablesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariablesetstmt([NotNull] PostgreSqlParser.VariablesetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_rest([NotNull] PostgreSqlParser.Set_restContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_rest([NotNull] PostgreSqlParser.Set_restContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_set([NotNull] PostgreSqlParser.Generic_setContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_set([NotNull] PostgreSqlParser.Generic_setContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_rest_more"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_rest_more([NotNull] PostgreSqlParser.Set_rest_moreContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_rest_more"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_rest_more([NotNull] PostgreSqlParser.Set_rest_moreContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_name([NotNull] PostgreSqlParser.Var_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_name([NotNull] PostgreSqlParser.Var_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_list([NotNull] PostgreSqlParser.Var_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_list([NotNull] PostgreSqlParser.Var_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVar_value([NotNull] PostgreSqlParser.Var_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVar_value([NotNull] PostgreSqlParser.Var_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.iso_level"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIso_level([NotNull] PostgreSqlParser.Iso_levelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.iso_level"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIso_level([NotNull] PostgreSqlParser.Iso_levelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_boolean_or_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_boolean_or_string([NotNull] PostgreSqlParser.Opt_boolean_or_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_boolean_or_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_boolean_or_string([NotNull] PostgreSqlParser.Opt_boolean_or_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.zone_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterZone_value([NotNull] PostgreSqlParser.Zone_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.zone_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitZone_value([NotNull] PostgreSqlParser.Zone_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_encoding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_encoding([NotNull] PostgreSqlParser.Opt_encodingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_encoding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_encoding([NotNull] PostgreSqlParser.Opt_encodingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.nonreservedword_or_sconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNonreservedword_or_sconst([NotNull] PostgreSqlParser.Nonreservedword_or_sconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.nonreservedword_or_sconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNonreservedword_or_sconst([NotNull] PostgreSqlParser.Nonreservedword_or_sconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variableresetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableresetstmt([NotNull] PostgreSqlParser.VariableresetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variableresetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableresetstmt([NotNull] PostgreSqlParser.VariableresetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reset_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReset_rest([NotNull] PostgreSqlParser.Reset_restContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reset_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReset_rest([NotNull] PostgreSqlParser.Reset_restContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_reset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_reset([NotNull] PostgreSqlParser.Generic_resetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_reset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_reset([NotNull] PostgreSqlParser.Generic_resetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.setresetclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetresetclause([NotNull] PostgreSqlParser.SetresetclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.setresetclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetresetclause([NotNull] PostgreSqlParser.SetresetclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.functionsetresetclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionsetresetclause([NotNull] PostgreSqlParser.FunctionsetresetclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.functionsetresetclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionsetresetclause([NotNull] PostgreSqlParser.FunctionsetresetclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variableshowstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableshowstmt([NotNull] PostgreSqlParser.VariableshowstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variableshowstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableshowstmt([NotNull] PostgreSqlParser.VariableshowstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintssetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintssetstmt([NotNull] PostgreSqlParser.ConstraintssetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintssetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintssetstmt([NotNull] PostgreSqlParser.ConstraintssetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraints_set_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraints_set_list([NotNull] PostgreSqlParser.Constraints_set_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraints_set_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraints_set_list([NotNull] PostgreSqlParser.Constraints_set_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraints_set_mode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraints_set_mode([NotNull] PostgreSqlParser.Constraints_set_modeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraints_set_mode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraints_set_mode([NotNull] PostgreSqlParser.Constraints_set_modeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.checkpointstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckpointstmt([NotNull] PostgreSqlParser.CheckpointstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.checkpointstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckpointstmt([NotNull] PostgreSqlParser.CheckpointstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.discardstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDiscardstmt([NotNull] PostgreSqlParser.DiscardstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.discardstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDiscardstmt([NotNull] PostgreSqlParser.DiscardstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltertablestmt([NotNull] PostgreSqlParser.AltertablestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltertablestmt([NotNull] PostgreSqlParser.AltertablestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_cmds([NotNull] PostgreSqlParser.Alter_table_cmdsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_cmds([NotNull] PostgreSqlParser.Alter_table_cmdsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partition_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_cmd([NotNull] PostgreSqlParser.Partition_cmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partition_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_cmd([NotNull] PostgreSqlParser.Partition_cmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_partition_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_partition_cmd([NotNull] PostgreSqlParser.Index_partition_cmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_partition_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_partition_cmd([NotNull] PostgreSqlParser.Index_partition_cmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_cmd([NotNull] PostgreSqlParser.Alter_table_cmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_cmd([NotNull] PostgreSqlParser.Alter_table_cmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_column_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_column_default([NotNull] PostgreSqlParser.Alter_column_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_column_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_column_default([NotNull] PostgreSqlParser.Alter_column_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_drop_behavior"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_drop_behavior([NotNull] PostgreSqlParser.Opt_drop_behaviorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_drop_behavior"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_drop_behavior([NotNull] PostgreSqlParser.Opt_drop_behaviorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_collate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_collate_clause([NotNull] PostgreSqlParser.Opt_collate_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_collate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_collate_clause([NotNull] PostgreSqlParser.Opt_collate_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_using([NotNull] PostgreSqlParser.Alter_usingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_using([NotNull] PostgreSqlParser.Alter_usingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.replica_identity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplica_identity([NotNull] PostgreSqlParser.Replica_identityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.replica_identity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplica_identity([NotNull] PostgreSqlParser.Replica_identityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReloptions([NotNull] PostgreSqlParser.ReloptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReloptions([NotNull] PostgreSqlParser.ReloptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_reloptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_reloptions([NotNull] PostgreSqlParser.Opt_reloptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_reloptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_reloptions([NotNull] PostgreSqlParser.Opt_reloptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloption_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReloption_list([NotNull] PostgreSqlParser.Reloption_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloption_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReloption_list([NotNull] PostgreSqlParser.Reloption_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloption_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReloption_elem([NotNull] PostgreSqlParser.Reloption_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloption_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReloption_elem([NotNull] PostgreSqlParser.Reloption_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_identity_column_option_list([NotNull] PostgreSqlParser.Alter_identity_column_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_identity_column_option_list([NotNull] PostgreSqlParser.Alter_identity_column_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_identity_column_option([NotNull] PostgreSqlParser.Alter_identity_column_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_identity_column_option([NotNull] PostgreSqlParser.Alter_identity_column_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partitionboundspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionboundspec([NotNull] PostgreSqlParser.PartitionboundspecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partitionboundspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionboundspec([NotNull] PostgreSqlParser.PartitionboundspecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.hash_partbound_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_partbound_elem([NotNull] PostgreSqlParser.Hash_partbound_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.hash_partbound_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_partbound_elem([NotNull] PostgreSqlParser.Hash_partbound_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.hash_partbound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_partbound([NotNull] PostgreSqlParser.Hash_partboundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.hash_partbound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_partbound([NotNull] PostgreSqlParser.Hash_partboundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altercompositetypestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltercompositetypestmt([NotNull] PostgreSqlParser.AltercompositetypestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altercompositetypestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltercompositetypestmt([NotNull] PostgreSqlParser.AltercompositetypestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_type_cmds([NotNull] PostgreSqlParser.Alter_type_cmdsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_type_cmds([NotNull] PostgreSqlParser.Alter_type_cmdsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_type_cmd([NotNull] PostgreSqlParser.Alter_type_cmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_type_cmd([NotNull] PostgreSqlParser.Alter_type_cmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.closeportalstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCloseportalstmt([NotNull] PostgreSqlParser.CloseportalstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.closeportalstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCloseportalstmt([NotNull] PostgreSqlParser.CloseportalstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopystmt([NotNull] PostgreSqlParser.CopystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopystmt([NotNull] PostgreSqlParser.CopystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_from([NotNull] PostgreSqlParser.Copy_fromContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_from([NotNull] PostgreSqlParser.Copy_fromContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_program([NotNull] PostgreSqlParser.Opt_programContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_program([NotNull] PostgreSqlParser.Opt_programContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_file_name([NotNull] PostgreSqlParser.Copy_file_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_file_name([NotNull] PostgreSqlParser.Copy_file_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_options([NotNull] PostgreSqlParser.Copy_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_options([NotNull] PostgreSqlParser.Copy_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_opt_list([NotNull] PostgreSqlParser.Copy_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_opt_list([NotNull] PostgreSqlParser.Copy_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_opt_item([NotNull] PostgreSqlParser.Copy_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_opt_item([NotNull] PostgreSqlParser.Copy_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_binary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_binary([NotNull] PostgreSqlParser.Opt_binaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_binary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_binary([NotNull] PostgreSqlParser.Opt_binaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_delimiter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_delimiter([NotNull] PostgreSqlParser.Copy_delimiterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_delimiter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_delimiter([NotNull] PostgreSqlParser.Copy_delimiterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_using([NotNull] PostgreSqlParser.Opt_usingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_using([NotNull] PostgreSqlParser.Opt_usingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_generic_opt_list([NotNull] PostgreSqlParser.Copy_generic_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_generic_opt_list([NotNull] PostgreSqlParser.Copy_generic_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_generic_opt_elem([NotNull] PostgreSqlParser.Copy_generic_opt_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_generic_opt_elem([NotNull] PostgreSqlParser.Copy_generic_opt_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_generic_opt_arg([NotNull] PostgreSqlParser.Copy_generic_opt_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_generic_opt_arg([NotNull] PostgreSqlParser.Copy_generic_opt_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_generic_opt_arg_list([NotNull] PostgreSqlParser.Copy_generic_opt_arg_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_generic_opt_arg_list([NotNull] PostgreSqlParser.Copy_generic_opt_arg_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCopy_generic_opt_arg_list_item([NotNull] PostgreSqlParser.Copy_generic_opt_arg_list_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCopy_generic_opt_arg_list_item([NotNull] PostgreSqlParser.Copy_generic_opt_arg_list_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatestmt([NotNull] PostgreSqlParser.CreatestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatestmt([NotNull] PostgreSqlParser.CreatestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttemp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttemp([NotNull] PostgreSqlParser.OpttempContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttemp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttemp([NotNull] PostgreSqlParser.OpttempContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttableelementlist([NotNull] PostgreSqlParser.OpttableelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttableelementlist([NotNull] PostgreSqlParser.OpttableelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttypedtableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttypedtableelementlist([NotNull] PostgreSqlParser.OpttypedtableelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttypedtableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttypedtableelementlist([NotNull] PostgreSqlParser.OpttypedtableelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableelementlist([NotNull] PostgreSqlParser.TableelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableelementlist([NotNull] PostgreSqlParser.TableelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typedtableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypedtableelementlist([NotNull] PostgreSqlParser.TypedtableelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typedtableelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypedtableelementlist([NotNull] PostgreSqlParser.TypedtableelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableelement([NotNull] PostgreSqlParser.TableelementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableelement([NotNull] PostgreSqlParser.TableelementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typedtableelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypedtableelement([NotNull] PostgreSqlParser.TypedtableelementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typedtableelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypedtableelement([NotNull] PostgreSqlParser.TypedtableelementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnDef([NotNull] PostgreSqlParser.ColumnDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnDef([NotNull] PostgreSqlParser.ColumnDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnOptions([NotNull] PostgreSqlParser.ColumnOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnOptions([NotNull] PostgreSqlParser.ColumnOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colquallist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColquallist([NotNull] PostgreSqlParser.ColquallistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colquallist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColquallist([NotNull] PostgreSqlParser.ColquallistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colconstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColconstraint([NotNull] PostgreSqlParser.ColconstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colconstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColconstraint([NotNull] PostgreSqlParser.ColconstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colconstraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColconstraintelem([NotNull] PostgreSqlParser.ColconstraintelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colconstraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColconstraintelem([NotNull] PostgreSqlParser.ColconstraintelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generated_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenerated_when([NotNull] PostgreSqlParser.Generated_whenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generated_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenerated_when([NotNull] PostgreSqlParser.Generated_whenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintattr([NotNull] PostgreSqlParser.ConstraintattrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintattr([NotNull] PostgreSqlParser.ConstraintattrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablelikeclause([NotNull] PostgreSqlParser.TablelikeclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablelikeclause([NotNull] PostgreSqlParser.TablelikeclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeoptionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablelikeoptionlist([NotNull] PostgreSqlParser.TablelikeoptionlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeoptionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablelikeoptionlist([NotNull] PostgreSqlParser.TablelikeoptionlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeoption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablelikeoption([NotNull] PostgreSqlParser.TablelikeoptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeoption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablelikeoption([NotNull] PostgreSqlParser.TablelikeoptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableconstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableconstraint([NotNull] PostgreSqlParser.TableconstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableconstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableconstraint([NotNull] PostgreSqlParser.TableconstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintelem([NotNull] PostgreSqlParser.ConstraintelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintelem([NotNull] PostgreSqlParser.ConstraintelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_no_inherit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_no_inherit([NotNull] PostgreSqlParser.Opt_no_inheritContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_no_inherit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_no_inherit([NotNull] PostgreSqlParser.Opt_no_inheritContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_column_list([NotNull] PostgreSqlParser.Opt_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_column_list([NotNull] PostgreSqlParser.Opt_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnlist([NotNull] PostgreSqlParser.ColumnlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnlist([NotNull] PostgreSqlParser.ColumnlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnElem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnElem([NotNull] PostgreSqlParser.ColumnElemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnElem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnElem([NotNull] PostgreSqlParser.ColumnElemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_c_include"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_c_include([NotNull] PostgreSqlParser.Opt_c_includeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_c_include"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_c_include([NotNull] PostgreSqlParser.Opt_c_includeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_match"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_match([NotNull] PostgreSqlParser.Key_matchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_match"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_match([NotNull] PostgreSqlParser.Key_matchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusionconstraintlist([NotNull] PostgreSqlParser.ExclusionconstraintlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusionconstraintlist([NotNull] PostgreSqlParser.ExclusionconstraintlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusionconstraintelem([NotNull] PostgreSqlParser.ExclusionconstraintelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusionconstraintelem([NotNull] PostgreSqlParser.ExclusionconstraintelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionwhereclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusionwhereclause([NotNull] PostgreSqlParser.ExclusionwhereclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionwhereclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusionwhereclause([NotNull] PostgreSqlParser.ExclusionwhereclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_actions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_actions([NotNull] PostgreSqlParser.Key_actionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_actions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_actions([NotNull] PostgreSqlParser.Key_actionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_update"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_update([NotNull] PostgreSqlParser.Key_updateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_update"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_update([NotNull] PostgreSqlParser.Key_updateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_delete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_delete([NotNull] PostgreSqlParser.Key_deleteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_delete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_delete([NotNull] PostgreSqlParser.Key_deleteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_action"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_action([NotNull] PostgreSqlParser.Key_actionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_action"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_action([NotNull] PostgreSqlParser.Key_actionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optinherit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptinherit([NotNull] PostgreSqlParser.OptinheritContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optinherit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptinherit([NotNull] PostgreSqlParser.OptinheritContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optpartitionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptpartitionspec([NotNull] PostgreSqlParser.OptpartitionspecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optpartitionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptpartitionspec([NotNull] PostgreSqlParser.OptpartitionspecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partitionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionspec([NotNull] PostgreSqlParser.PartitionspecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partitionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionspec([NotNull] PostgreSqlParser.PartitionspecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.part_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPart_params([NotNull] PostgreSqlParser.Part_paramsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.part_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPart_params([NotNull] PostgreSqlParser.Part_paramsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.part_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPart_elem([NotNull] PostgreSqlParser.Part_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.part_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPart_elem([NotNull] PostgreSqlParser.Part_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_access_method_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_access_method_clause([NotNull] PostgreSqlParser.Table_access_method_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_access_method_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_access_method_clause([NotNull] PostgreSqlParser.Table_access_method_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optwith"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptwith([NotNull] PostgreSqlParser.OptwithContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optwith"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptwith([NotNull] PostgreSqlParser.OptwithContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.oncommitoption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOncommitoption([NotNull] PostgreSqlParser.OncommitoptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.oncommitoption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOncommitoption([NotNull] PostgreSqlParser.OncommitoptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttablespace([NotNull] PostgreSqlParser.OpttablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttablespace([NotNull] PostgreSqlParser.OpttablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optconstablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptconstablespace([NotNull] PostgreSqlParser.OptconstablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optconstablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptconstablespace([NotNull] PostgreSqlParser.OptconstablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.existingindex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExistingindex([NotNull] PostgreSqlParser.ExistingindexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.existingindex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExistingindex([NotNull] PostgreSqlParser.ExistingindexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createstatsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatestatsstmt([NotNull] PostgreSqlParser.CreatestatsstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createstatsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatestatsstmt([NotNull] PostgreSqlParser.CreatestatsstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterstatsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterstatsstmt([NotNull] PostgreSqlParser.AlterstatsstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterstatsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterstatsstmt([NotNull] PostgreSqlParser.AlterstatsstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createasstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateasstmt([NotNull] PostgreSqlParser.CreateasstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createasstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateasstmt([NotNull] PostgreSqlParser.CreateasstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_as_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_as_target([NotNull] PostgreSqlParser.Create_as_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_as_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_as_target([NotNull] PostgreSqlParser.Create_as_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_with_data([NotNull] PostgreSqlParser.Opt_with_dataContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_with_data([NotNull] PostgreSqlParser.Opt_with_dataContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.creatematviewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatematviewstmt([NotNull] PostgreSqlParser.CreatematviewstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.creatematviewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatematviewstmt([NotNull] PostgreSqlParser.CreatematviewstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_mv_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_mv_target([NotNull] PostgreSqlParser.Create_mv_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_mv_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_mv_target([NotNull] PostgreSqlParser.Create_mv_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optnolog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptnolog([NotNull] PostgreSqlParser.OptnologContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optnolog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptnolog([NotNull] PostgreSqlParser.OptnologContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.refreshmatviewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRefreshmatviewstmt([NotNull] PostgreSqlParser.RefreshmatviewstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.refreshmatviewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRefreshmatviewstmt([NotNull] PostgreSqlParser.RefreshmatviewstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createseqstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateseqstmt([NotNull] PostgreSqlParser.CreateseqstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createseqstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateseqstmt([NotNull] PostgreSqlParser.CreateseqstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterseqstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterseqstmt([NotNull] PostgreSqlParser.AlterseqstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterseqstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterseqstmt([NotNull] PostgreSqlParser.AlterseqstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optseqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptseqoptlist([NotNull] PostgreSqlParser.OptseqoptlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optseqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptseqoptlist([NotNull] PostgreSqlParser.OptseqoptlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optparenthesizedseqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptparenthesizedseqoptlist([NotNull] PostgreSqlParser.OptparenthesizedseqoptlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optparenthesizedseqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptparenthesizedseqoptlist([NotNull] PostgreSqlParser.OptparenthesizedseqoptlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeqoptlist([NotNull] PostgreSqlParser.SeqoptlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seqoptlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeqoptlist([NotNull] PostgreSqlParser.SeqoptlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seqoptelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeqoptelem([NotNull] PostgreSqlParser.SeqoptelemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seqoptelem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeqoptelem([NotNull] PostgreSqlParser.SeqoptelemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_by([NotNull] PostgreSqlParser.Opt_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_by([NotNull] PostgreSqlParser.Opt_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numericonly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericonly([NotNull] PostgreSqlParser.NumericonlyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numericonly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericonly([NotNull] PostgreSqlParser.NumericonlyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numericonly_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumericonly_list([NotNull] PostgreSqlParser.Numericonly_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numericonly_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumericonly_list([NotNull] PostgreSqlParser.Numericonly_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createplangstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateplangstmt([NotNull] PostgreSqlParser.CreateplangstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createplangstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateplangstmt([NotNull] PostgreSqlParser.CreateplangstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_trusted"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_trusted([NotNull] PostgreSqlParser.Opt_trustedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_trusted"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_trusted([NotNull] PostgreSqlParser.Opt_trustedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.handler_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandler_name([NotNull] PostgreSqlParser.Handler_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.handler_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandler_name([NotNull] PostgreSqlParser.Handler_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_inline_handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_inline_handler([NotNull] PostgreSqlParser.Opt_inline_handlerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_inline_handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_inline_handler([NotNull] PostgreSqlParser.Opt_inline_handlerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.validator_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValidator_clause([NotNull] PostgreSqlParser.Validator_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.validator_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValidator_clause([NotNull] PostgreSqlParser.Validator_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_validator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_validator([NotNull] PostgreSqlParser.Opt_validatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_validator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_validator([NotNull] PostgreSqlParser.Opt_validatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_procedural"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_procedural([NotNull] PostgreSqlParser.Opt_proceduralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_procedural"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_procedural([NotNull] PostgreSqlParser.Opt_proceduralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtablespacestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatetablespacestmt([NotNull] PostgreSqlParser.CreatetablespacestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtablespacestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatetablespacestmt([NotNull] PostgreSqlParser.CreatetablespacestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablespaceowner"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttablespaceowner([NotNull] PostgreSqlParser.OpttablespaceownerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablespaceowner"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttablespaceowner([NotNull] PostgreSqlParser.OpttablespaceownerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droptablespacestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDroptablespacestmt([NotNull] PostgreSqlParser.DroptablespacestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droptablespacestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDroptablespacestmt([NotNull] PostgreSqlParser.DroptablespacestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createextensionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateextensionstmt([NotNull] PostgreSqlParser.CreateextensionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createextensionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateextensionstmt([NotNull] PostgreSqlParser.CreateextensionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_extension_opt_list([NotNull] PostgreSqlParser.Create_extension_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_extension_opt_list([NotNull] PostgreSqlParser.Create_extension_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_extension_opt_item([NotNull] PostgreSqlParser.Create_extension_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_extension_opt_item([NotNull] PostgreSqlParser.Create_extension_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterextensionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterextensionstmt([NotNull] PostgreSqlParser.AlterextensionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterextensionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterextensionstmt([NotNull] PostgreSqlParser.AlterextensionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_extension_opt_list([NotNull] PostgreSqlParser.Alter_extension_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_extension_opt_list([NotNull] PostgreSqlParser.Alter_extension_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_extension_opt_item([NotNull] PostgreSqlParser.Alter_extension_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_extension_opt_item([NotNull] PostgreSqlParser.Alter_extension_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterextensioncontentsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterextensioncontentsstmt([NotNull] PostgreSqlParser.AlterextensioncontentsstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterextensioncontentsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterextensioncontentsstmt([NotNull] PostgreSqlParser.AlterextensioncontentsstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfdwstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatefdwstmt([NotNull] PostgreSqlParser.CreatefdwstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfdwstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatefdwstmt([NotNull] PostgreSqlParser.CreatefdwstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fdw_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFdw_option([NotNull] PostgreSqlParser.Fdw_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fdw_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFdw_option([NotNull] PostgreSqlParser.Fdw_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fdw_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFdw_options([NotNull] PostgreSqlParser.Fdw_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fdw_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFdw_options([NotNull] PostgreSqlParser.Fdw_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_fdw_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_fdw_options([NotNull] PostgreSqlParser.Opt_fdw_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_fdw_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_fdw_options([NotNull] PostgreSqlParser.Opt_fdw_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfdwstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterfdwstmt([NotNull] PostgreSqlParser.AlterfdwstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfdwstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterfdwstmt([NotNull] PostgreSqlParser.AlterfdwstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_generic_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_generic_options([NotNull] PostgreSqlParser.Create_generic_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_generic_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_generic_options([NotNull] PostgreSqlParser.Create_generic_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_option_list([NotNull] PostgreSqlParser.Generic_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_option_list([NotNull] PostgreSqlParser.Generic_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_generic_options([NotNull] PostgreSqlParser.Alter_generic_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_generic_options([NotNull] PostgreSqlParser.Alter_generic_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_generic_option_list([NotNull] PostgreSqlParser.Alter_generic_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_generic_option_list([NotNull] PostgreSqlParser.Alter_generic_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_generic_option_elem([NotNull] PostgreSqlParser.Alter_generic_option_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_generic_option_elem([NotNull] PostgreSqlParser.Alter_generic_option_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_option_elem([NotNull] PostgreSqlParser.Generic_option_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_option_elem([NotNull] PostgreSqlParser.Generic_option_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_option_name([NotNull] PostgreSqlParser.Generic_option_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_option_name([NotNull] PostgreSqlParser.Generic_option_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_option_arg([NotNull] PostgreSqlParser.Generic_option_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_option_arg([NotNull] PostgreSqlParser.Generic_option_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createforeignserverstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateforeignserverstmt([NotNull] PostgreSqlParser.CreateforeignserverstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createforeignserverstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateforeignserverstmt([NotNull] PostgreSqlParser.CreateforeignserverstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_type([NotNull] PostgreSqlParser.Opt_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_type([NotNull] PostgreSqlParser.Opt_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.foreign_server_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_server_version([NotNull] PostgreSqlParser.Foreign_server_versionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.foreign_server_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_server_version([NotNull] PostgreSqlParser.Foreign_server_versionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_foreign_server_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_foreign_server_version([NotNull] PostgreSqlParser.Opt_foreign_server_versionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_foreign_server_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_foreign_server_version([NotNull] PostgreSqlParser.Opt_foreign_server_versionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterforeignserverstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterforeignserverstmt([NotNull] PostgreSqlParser.AlterforeignserverstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterforeignserverstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterforeignserverstmt([NotNull] PostgreSqlParser.AlterforeignserverstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createforeigntablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateforeigntablestmt([NotNull] PostgreSqlParser.CreateforeigntablestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createforeigntablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateforeigntablestmt([NotNull] PostgreSqlParser.CreateforeigntablestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.importforeignschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportforeignschemastmt([NotNull] PostgreSqlParser.ImportforeignschemastmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.importforeignschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportforeignschemastmt([NotNull] PostgreSqlParser.ImportforeignschemastmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.import_qualification_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_qualification_type([NotNull] PostgreSqlParser.Import_qualification_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.import_qualification_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_qualification_type([NotNull] PostgreSqlParser.Import_qualification_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.import_qualification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImport_qualification([NotNull] PostgreSqlParser.Import_qualificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.import_qualification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImport_qualification([NotNull] PostgreSqlParser.Import_qualificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateusermappingstmt([NotNull] PostgreSqlParser.CreateusermappingstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateusermappingstmt([NotNull] PostgreSqlParser.CreateusermappingstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.auth_ident"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAuth_ident([NotNull] PostgreSqlParser.Auth_identContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.auth_ident"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAuth_ident([NotNull] PostgreSqlParser.Auth_identContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropusermappingstmt([NotNull] PostgreSqlParser.DropusermappingstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropusermappingstmt([NotNull] PostgreSqlParser.DropusermappingstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterusermappingstmt([NotNull] PostgreSqlParser.AlterusermappingstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterusermappingstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterusermappingstmt([NotNull] PostgreSqlParser.AlterusermappingstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createpolicystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatepolicystmt([NotNull] PostgreSqlParser.CreatepolicystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createpolicystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatepolicystmt([NotNull] PostgreSqlParser.CreatepolicystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterpolicystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterpolicystmt([NotNull] PostgreSqlParser.AlterpolicystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterpolicystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterpolicystmt([NotNull] PostgreSqlParser.AlterpolicystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecurityoptionalexpr([NotNull] PostgreSqlParser.RowsecurityoptionalexprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecurityoptionalexpr([NotNull] PostgreSqlParser.RowsecurityoptionalexprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalwithcheck"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecurityoptionalwithcheck([NotNull] PostgreSqlParser.RowsecurityoptionalwithcheckContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalwithcheck"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecurityoptionalwithcheck([NotNull] PostgreSqlParser.RowsecurityoptionalwithcheckContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaulttorole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecuritydefaulttorole([NotNull] PostgreSqlParser.RowsecuritydefaulttoroleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaulttorole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecuritydefaulttorole([NotNull] PostgreSqlParser.RowsecuritydefaulttoroleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionaltorole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecurityoptionaltorole([NotNull] PostgreSqlParser.RowsecurityoptionaltoroleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionaltorole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecurityoptionaltorole([NotNull] PostgreSqlParser.RowsecurityoptionaltoroleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultpermissive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecuritydefaultpermissive([NotNull] PostgreSqlParser.RowsecuritydefaultpermissiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultpermissive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecuritydefaultpermissive([NotNull] PostgreSqlParser.RowsecuritydefaultpermissiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultforcmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsecuritydefaultforcmd([NotNull] PostgreSqlParser.RowsecuritydefaultforcmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultforcmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsecuritydefaultforcmd([NotNull] PostgreSqlParser.RowsecuritydefaultforcmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row_security_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRow_security_cmd([NotNull] PostgreSqlParser.Row_security_cmdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row_security_cmd"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRow_security_cmd([NotNull] PostgreSqlParser.Row_security_cmdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createamstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateamstmt([NotNull] PostgreSqlParser.CreateamstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createamstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateamstmt([NotNull] PostgreSqlParser.CreateamstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.am_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAm_type([NotNull] PostgreSqlParser.Am_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.am_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAm_type([NotNull] PostgreSqlParser.Am_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatetrigstmt([NotNull] PostgreSqlParser.CreatetrigstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatetrigstmt([NotNull] PostgreSqlParser.CreatetrigstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggeractiontime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggeractiontime([NotNull] PostgreSqlParser.TriggeractiontimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggeractiontime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggeractiontime([NotNull] PostgreSqlParser.TriggeractiontimeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerevents"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerevents([NotNull] PostgreSqlParser.TriggereventsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerevents"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerevents([NotNull] PostgreSqlParser.TriggereventsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggeroneevent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggeroneevent([NotNull] PostgreSqlParser.TriggeroneeventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggeroneevent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggeroneevent([NotNull] PostgreSqlParser.TriggeroneeventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerreferencing"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerreferencing([NotNull] PostgreSqlParser.TriggerreferencingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerreferencing"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerreferencing([NotNull] PostgreSqlParser.TriggerreferencingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggertransitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggertransitions([NotNull] PostgreSqlParser.TriggertransitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggertransitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggertransitions([NotNull] PostgreSqlParser.TriggertransitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggertransition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggertransition([NotNull] PostgreSqlParser.TriggertransitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggertransition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggertransition([NotNull] PostgreSqlParser.TriggertransitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionoldornew"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransitionoldornew([NotNull] PostgreSqlParser.TransitionoldornewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionoldornew"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransitionoldornew([NotNull] PostgreSqlParser.TransitionoldornewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionrowortable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransitionrowortable([NotNull] PostgreSqlParser.TransitionrowortableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionrowortable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransitionrowortable([NotNull] PostgreSqlParser.TransitionrowortableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionrelname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransitionrelname([NotNull] PostgreSqlParser.TransitionrelnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionrelname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransitionrelname([NotNull] PostgreSqlParser.TransitionrelnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerforspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerforspec([NotNull] PostgreSqlParser.TriggerforspecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerforspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerforspec([NotNull] PostgreSqlParser.TriggerforspecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerforopteach"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerforopteach([NotNull] PostgreSqlParser.TriggerforopteachContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerforopteach"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerforopteach([NotNull] PostgreSqlParser.TriggerforopteachContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfortype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerfortype([NotNull] PostgreSqlParser.TriggerfortypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfortype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerfortype([NotNull] PostgreSqlParser.TriggerfortypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerwhen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerwhen([NotNull] PostgreSqlParser.TriggerwhenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerwhen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerwhen([NotNull] PostgreSqlParser.TriggerwhenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_or_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_or_procedure([NotNull] PostgreSqlParser.Function_or_procedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_or_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_or_procedure([NotNull] PostgreSqlParser.Function_or_procedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfuncargs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerfuncargs([NotNull] PostgreSqlParser.TriggerfuncargsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfuncargs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerfuncargs([NotNull] PostgreSqlParser.TriggerfuncargsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfuncarg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerfuncarg([NotNull] PostgreSqlParser.TriggerfuncargContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfuncarg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerfuncarg([NotNull] PostgreSqlParser.TriggerfuncargContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optconstrfromtable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptconstrfromtable([NotNull] PostgreSqlParser.OptconstrfromtableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optconstrfromtable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptconstrfromtable([NotNull] PostgreSqlParser.OptconstrfromtableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattributespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintattributespec([NotNull] PostgreSqlParser.ConstraintattributespecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattributespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintattributespec([NotNull] PostgreSqlParser.ConstraintattributespecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattributeElem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintattributeElem([NotNull] PostgreSqlParser.ConstraintattributeElemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattributeElem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintattributeElem([NotNull] PostgreSqlParser.ConstraintattributeElemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createeventtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateeventtrigstmt([NotNull] PostgreSqlParser.CreateeventtrigstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createeventtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateeventtrigstmt([NotNull] PostgreSqlParser.CreateeventtrigstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_trigger_when_list([NotNull] PostgreSqlParser.Event_trigger_when_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_trigger_when_list([NotNull] PostgreSqlParser.Event_trigger_when_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_trigger_when_item([NotNull] PostgreSqlParser.Event_trigger_when_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_trigger_when_item([NotNull] PostgreSqlParser.Event_trigger_when_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_value_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_trigger_value_list([NotNull] PostgreSqlParser.Event_trigger_value_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_value_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_trigger_value_list([NotNull] PostgreSqlParser.Event_trigger_value_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altereventtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltereventtrigstmt([NotNull] PostgreSqlParser.AltereventtrigstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altereventtrigstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltereventtrigstmt([NotNull] PostgreSqlParser.AltereventtrigstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.enable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnable_trigger([NotNull] PostgreSqlParser.Enable_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.enable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnable_trigger([NotNull] PostgreSqlParser.Enable_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createassertionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateassertionstmt([NotNull] PostgreSqlParser.CreateassertionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createassertionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateassertionstmt([NotNull] PostgreSqlParser.CreateassertionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.definestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefinestmt([NotNull] PostgreSqlParser.DefinestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.definestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefinestmt([NotNull] PostgreSqlParser.DefinestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefinition([NotNull] PostgreSqlParser.DefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefinition([NotNull] PostgreSqlParser.DefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDef_list([NotNull] PostgreSqlParser.Def_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDef_list([NotNull] PostgreSqlParser.Def_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDef_elem([NotNull] PostgreSqlParser.Def_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDef_elem([NotNull] PostgreSqlParser.Def_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDef_arg([NotNull] PostgreSqlParser.Def_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDef_arg([NotNull] PostgreSqlParser.Def_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOld_aggr_definition([NotNull] PostgreSqlParser.Old_aggr_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOld_aggr_definition([NotNull] PostgreSqlParser.Old_aggr_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOld_aggr_list([NotNull] PostgreSqlParser.Old_aggr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOld_aggr_list([NotNull] PostgreSqlParser.Old_aggr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOld_aggr_elem([NotNull] PostgreSqlParser.Old_aggr_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOld_aggr_elem([NotNull] PostgreSqlParser.Old_aggr_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_enum_val_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_enum_val_list([NotNull] PostgreSqlParser.Opt_enum_val_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_enum_val_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_enum_val_list([NotNull] PostgreSqlParser.Opt_enum_val_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.enum_val_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnum_val_list([NotNull] PostgreSqlParser.Enum_val_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.enum_val_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnum_val_list([NotNull] PostgreSqlParser.Enum_val_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterenumstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterenumstmt([NotNull] PostgreSqlParser.AlterenumstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterenumstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterenumstmt([NotNull] PostgreSqlParser.AlterenumstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_if_not_exists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_if_not_exists([NotNull] PostgreSqlParser.Opt_if_not_existsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_if_not_exists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_if_not_exists([NotNull] PostgreSqlParser.Opt_if_not_existsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createopclassstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateopclassstmt([NotNull] PostgreSqlParser.CreateopclassstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createopclassstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateopclassstmt([NotNull] PostgreSqlParser.CreateopclassstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_item_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpclass_item_list([NotNull] PostgreSqlParser.Opclass_item_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_item_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpclass_item_list([NotNull] PostgreSqlParser.Opclass_item_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpclass_item([NotNull] PostgreSqlParser.Opclass_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpclass_item([NotNull] PostgreSqlParser.Opclass_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_default([NotNull] PostgreSqlParser.Opt_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_default([NotNull] PostgreSqlParser.Opt_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_opfamily"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_opfamily([NotNull] PostgreSqlParser.Opt_opfamilyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_opfamily"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_opfamily([NotNull] PostgreSqlParser.Opt_opfamilyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_purpose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpclass_purpose([NotNull] PostgreSqlParser.Opclass_purposeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_purpose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpclass_purpose([NotNull] PostgreSqlParser.Opclass_purposeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_recheck"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_recheck([NotNull] PostgreSqlParser.Opt_recheckContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_recheck"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_recheck([NotNull] PostgreSqlParser.Opt_recheckContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createopfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateopfamilystmt([NotNull] PostgreSqlParser.CreateopfamilystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createopfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateopfamilystmt([NotNull] PostgreSqlParser.CreateopfamilystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteropfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlteropfamilystmt([NotNull] PostgreSqlParser.AlteropfamilystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteropfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlteropfamilystmt([NotNull] PostgreSqlParser.AlteropfamilystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_drop_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpclass_drop_list([NotNull] PostgreSqlParser.Opclass_drop_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_drop_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpclass_drop_list([NotNull] PostgreSqlParser.Opclass_drop_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpclass_drop([NotNull] PostgreSqlParser.Opclass_dropContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpclass_drop([NotNull] PostgreSqlParser.Opclass_dropContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropopclassstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropopclassstmt([NotNull] PostgreSqlParser.DropopclassstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropopclassstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropopclassstmt([NotNull] PostgreSqlParser.DropopclassstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropopfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropopfamilystmt([NotNull] PostgreSqlParser.DropopfamilystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropopfamilystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropopfamilystmt([NotNull] PostgreSqlParser.DropopfamilystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropownedstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropownedstmt([NotNull] PostgreSqlParser.DropownedstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropownedstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropownedstmt([NotNull] PostgreSqlParser.DropownedstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reassignownedstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReassignownedstmt([NotNull] PostgreSqlParser.ReassignownedstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reassignownedstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReassignownedstmt([NotNull] PostgreSqlParser.ReassignownedstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropstmt([NotNull] PostgreSqlParser.DropstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropstmt([NotNull] PostgreSqlParser.DropstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_type_any_name([NotNull] PostgreSqlParser.Object_type_any_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_type_any_name([NotNull] PostgreSqlParser.Object_type_any_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_type_name([NotNull] PostgreSqlParser.Object_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_type_name([NotNull] PostgreSqlParser.Object_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_type_name([NotNull] PostgreSqlParser.Drop_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_type_name([NotNull] PostgreSqlParser.Drop_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_name_on_any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_type_name_on_any_name([NotNull] PostgreSqlParser.Object_type_name_on_any_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_name_on_any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_type_name_on_any_name([NotNull] PostgreSqlParser.Object_type_name_on_any_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_name_list([NotNull] PostgreSqlParser.Any_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_name_list([NotNull] PostgreSqlParser.Any_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_name([NotNull] PostgreSqlParser.Any_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_name([NotNull] PostgreSqlParser.Any_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.attrs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttrs([NotNull] PostgreSqlParser.AttrsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.attrs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttrs([NotNull] PostgreSqlParser.AttrsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_name_list([NotNull] PostgreSqlParser.Type_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_name_list([NotNull] PostgreSqlParser.Type_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.truncatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncatestmt([NotNull] PostgreSqlParser.TruncatestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.truncatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncatestmt([NotNull] PostgreSqlParser.TruncatestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_restart_seqs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_restart_seqs([NotNull] PostgreSqlParser.Opt_restart_seqsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_restart_seqs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_restart_seqs([NotNull] PostgreSqlParser.Opt_restart_seqsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.commentstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommentstmt([NotNull] PostgreSqlParser.CommentstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.commentstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommentstmt([NotNull] PostgreSqlParser.CommentstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comment_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComment_text([NotNull] PostgreSqlParser.Comment_textContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comment_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComment_text([NotNull] PostgreSqlParser.Comment_textContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seclabelstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeclabelstmt([NotNull] PostgreSqlParser.SeclabelstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seclabelstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeclabelstmt([NotNull] PostgreSqlParser.SeclabelstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_provider([NotNull] PostgreSqlParser.Opt_providerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_provider([NotNull] PostgreSqlParser.Opt_providerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.security_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSecurity_label([NotNull] PostgreSqlParser.Security_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.security_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSecurity_label([NotNull] PostgreSqlParser.Security_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fetchstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFetchstmt([NotNull] PostgreSqlParser.FetchstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fetchstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFetchstmt([NotNull] PostgreSqlParser.FetchstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fetch_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFetch_args([NotNull] PostgreSqlParser.Fetch_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fetch_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFetch_args([NotNull] PostgreSqlParser.Fetch_argsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrom_in([NotNull] PostgreSqlParser.From_inContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrom_in([NotNull] PostgreSqlParser.From_inContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_from_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_from_in([NotNull] PostgreSqlParser.Opt_from_inContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_from_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_from_in([NotNull] PostgreSqlParser.Opt_from_inContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantstmt([NotNull] PostgreSqlParser.GrantstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantstmt([NotNull] PostgreSqlParser.GrantstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.revokestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRevokestmt([NotNull] PostgreSqlParser.RevokestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.revokestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRevokestmt([NotNull] PostgreSqlParser.RevokestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privileges"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivileges([NotNull] PostgreSqlParser.PrivilegesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privileges"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivileges([NotNull] PostgreSqlParser.PrivilegesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivilege_list([NotNull] PostgreSqlParser.Privilege_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivilege_list([NotNull] PostgreSqlParser.Privilege_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivilege([NotNull] PostgreSqlParser.PrivilegeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivilege([NotNull] PostgreSqlParser.PrivilegeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivilege_target([NotNull] PostgreSqlParser.Privilege_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivilege_target([NotNull] PostgreSqlParser.Privilege_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantee_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantee_list([NotNull] PostgreSqlParser.Grantee_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantee_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantee_list([NotNull] PostgreSqlParser.Grantee_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantee"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantee([NotNull] PostgreSqlParser.GranteeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantee"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantee([NotNull] PostgreSqlParser.GranteeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_grant_grant_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_grant_grant_option([NotNull] PostgreSqlParser.Opt_grant_grant_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_grant_grant_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_grant_grant_option([NotNull] PostgreSqlParser.Opt_grant_grant_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantrolestmt([NotNull] PostgreSqlParser.GrantrolestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantrolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantrolestmt([NotNull] PostgreSqlParser.GrantrolestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.revokerolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRevokerolestmt([NotNull] PostgreSqlParser.RevokerolestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.revokerolestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRevokerolestmt([NotNull] PostgreSqlParser.RevokerolestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_grant_admin_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_grant_admin_option([NotNull] PostgreSqlParser.Opt_grant_admin_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_grant_admin_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_grant_admin_option([NotNull] PostgreSqlParser.Opt_grant_admin_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_granted_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_granted_by([NotNull] PostgreSqlParser.Opt_granted_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_granted_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_granted_by([NotNull] PostgreSqlParser.Opt_granted_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdefaultprivilegesstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterdefaultprivilegesstmt([NotNull] PostgreSqlParser.AlterdefaultprivilegesstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdefaultprivilegesstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterdefaultprivilegesstmt([NotNull] PostgreSqlParser.AlterdefaultprivilegesstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacloptionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefacloptionlist([NotNull] PostgreSqlParser.DefacloptionlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacloptionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefacloptionlist([NotNull] PostgreSqlParser.DefacloptionlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacloption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefacloption([NotNull] PostgreSqlParser.DefacloptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacloption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefacloption([NotNull] PostgreSqlParser.DefacloptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defaclaction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaclaction([NotNull] PostgreSqlParser.DefaclactionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defaclaction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaclaction([NotNull] PostgreSqlParser.DefaclactionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacl_privilege_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefacl_privilege_target([NotNull] PostgreSqlParser.Defacl_privilege_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacl_privilege_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefacl_privilege_target([NotNull] PostgreSqlParser.Defacl_privilege_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indexstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexstmt([NotNull] PostgreSqlParser.IndexstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indexstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexstmt([NotNull] PostgreSqlParser.IndexstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_unique"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_unique([NotNull] PostgreSqlParser.Opt_uniqueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_unique"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_unique([NotNull] PostgreSqlParser.Opt_uniqueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_concurrently"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_concurrently([NotNull] PostgreSqlParser.Opt_concurrentlyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_concurrently"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_concurrently([NotNull] PostgreSqlParser.Opt_concurrentlyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_index_name([NotNull] PostgreSqlParser.Opt_index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_index_name([NotNull] PostgreSqlParser.Opt_index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.access_method_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccess_method_clause([NotNull] PostgreSqlParser.Access_method_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.access_method_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccess_method_clause([NotNull] PostgreSqlParser.Access_method_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_params([NotNull] PostgreSqlParser.Index_paramsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_params([NotNull] PostgreSqlParser.Index_paramsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_elem_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_elem_options([NotNull] PostgreSqlParser.Index_elem_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_elem_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_elem_options([NotNull] PostgreSqlParser.Index_elem_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_elem([NotNull] PostgreSqlParser.Index_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_elem([NotNull] PostgreSqlParser.Index_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_include"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_include([NotNull] PostgreSqlParser.Opt_includeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_include"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_include([NotNull] PostgreSqlParser.Opt_includeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_including_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_including_params([NotNull] PostgreSqlParser.Index_including_paramsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_including_params"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_including_params([NotNull] PostgreSqlParser.Index_including_paramsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_collate([NotNull] PostgreSqlParser.Opt_collateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_collate([NotNull] PostgreSqlParser.Opt_collateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_class"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_class([NotNull] PostgreSqlParser.Opt_classContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_class"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_class([NotNull] PostgreSqlParser.Opt_classContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_asc_desc([NotNull] PostgreSqlParser.Opt_asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_asc_desc([NotNull] PostgreSqlParser.Opt_asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nulls_order"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_nulls_order([NotNull] PostgreSqlParser.Opt_nulls_orderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nulls_order"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_nulls_order([NotNull] PostgreSqlParser.Opt_nulls_orderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunctionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatefunctionstmt([NotNull] PostgreSqlParser.CreatefunctionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunctionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatefunctionstmt([NotNull] PostgreSqlParser.CreatefunctionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_or_replace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_or_replace([NotNull] PostgreSqlParser.Opt_or_replaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_or_replace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_or_replace([NotNull] PostgreSqlParser.Opt_or_replaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_args([NotNull] PostgreSqlParser.Func_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_args([NotNull] PostgreSqlParser.Func_argsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_args_list([NotNull] PostgreSqlParser.Func_args_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_args_list([NotNull] PostgreSqlParser.Func_args_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_with_argtypes_list([NotNull] PostgreSqlParser.Function_with_argtypes_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_with_argtypes_list([NotNull] PostgreSqlParser.Function_with_argtypes_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_with_argtypes([NotNull] PostgreSqlParser.Function_with_argtypesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_with_argtypes([NotNull] PostgreSqlParser.Function_with_argtypesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_args_with_defaults([NotNull] PostgreSqlParser.Func_args_with_defaultsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_args_with_defaults([NotNull] PostgreSqlParser.Func_args_with_defaultsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_args_with_defaults_list([NotNull] PostgreSqlParser.Func_args_with_defaults_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_args_with_defaults_list([NotNull] PostgreSqlParser.Func_args_with_defaults_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_arg([NotNull] PostgreSqlParser.Func_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_arg([NotNull] PostgreSqlParser.Func_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.arg_class"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArg_class([NotNull] PostgreSqlParser.Arg_classContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.arg_class"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArg_class([NotNull] PostgreSqlParser.Arg_classContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.param_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_name([NotNull] PostgreSqlParser.Param_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.param_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_name([NotNull] PostgreSqlParser.Param_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_return"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_return([NotNull] PostgreSqlParser.Func_returnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_return"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_return([NotNull] PostgreSqlParser.Func_returnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_type([NotNull] PostgreSqlParser.Func_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_type([NotNull] PostgreSqlParser.Func_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_with_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_arg_with_default([NotNull] PostgreSqlParser.Func_arg_with_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_with_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_arg_with_default([NotNull] PostgreSqlParser.Func_arg_with_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggr_arg([NotNull] PostgreSqlParser.Aggr_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggr_arg([NotNull] PostgreSqlParser.Aggr_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggr_args([NotNull] PostgreSqlParser.Aggr_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggr_args([NotNull] PostgreSqlParser.Aggr_argsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_args_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggr_args_list([NotNull] PostgreSqlParser.Aggr_args_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_args_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggr_args_list([NotNull] PostgreSqlParser.Aggr_args_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_with_argtypes([NotNull] PostgreSqlParser.Aggregate_with_argtypesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_with_argtypes([NotNull] PostgreSqlParser.Aggregate_with_argtypesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_with_argtypes_list([NotNull] PostgreSqlParser.Aggregate_with_argtypes_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_with_argtypes_list([NotNull] PostgreSqlParser.Aggregate_with_argtypes_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatefunc_opt_list([NotNull] PostgreSqlParser.Createfunc_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatefunc_opt_list([NotNull] PostgreSqlParser.Createfunc_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.common_func_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_func_opt_item([NotNull] PostgreSqlParser.Common_func_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.common_func_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_func_opt_item([NotNull] PostgreSqlParser.Common_func_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatefunc_opt_item([NotNull] PostgreSqlParser.Createfunc_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatefunc_opt_item([NotNull] PostgreSqlParser.Createfunc_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_as([NotNull] PostgreSqlParser.Func_asContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_as([NotNull] PostgreSqlParser.Func_asContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transform_type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransform_type_list([NotNull] PostgreSqlParser.Transform_type_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transform_type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransform_type_list([NotNull] PostgreSqlParser.Transform_type_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_definition([NotNull] PostgreSqlParser.Opt_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_definition([NotNull] PostgreSqlParser.Opt_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_func_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_func_column([NotNull] PostgreSqlParser.Table_func_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_func_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_func_column([NotNull] PostgreSqlParser.Table_func_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_func_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_func_column_list([NotNull] PostgreSqlParser.Table_func_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_func_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_func_column_list([NotNull] PostgreSqlParser.Table_func_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfunctionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterfunctionstmt([NotNull] PostgreSqlParser.AlterfunctionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfunctionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterfunctionstmt([NotNull] PostgreSqlParser.AlterfunctionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfunc_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterfunc_opt_list([NotNull] PostgreSqlParser.Alterfunc_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfunc_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterfunc_opt_list([NotNull] PostgreSqlParser.Alterfunc_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_restrict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_restrict([NotNull] PostgreSqlParser.Opt_restrictContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_restrict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_restrict([NotNull] PostgreSqlParser.Opt_restrictContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removefuncstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemovefuncstmt([NotNull] PostgreSqlParser.RemovefuncstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removefuncstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemovefuncstmt([NotNull] PostgreSqlParser.RemovefuncstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removeaggrstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemoveaggrstmt([NotNull] PostgreSqlParser.RemoveaggrstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removeaggrstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemoveaggrstmt([NotNull] PostgreSqlParser.RemoveaggrstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removeoperstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemoveoperstmt([NotNull] PostgreSqlParser.RemoveoperstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removeoperstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemoveoperstmt([NotNull] PostgreSqlParser.RemoveoperstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.oper_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOper_argtypes([NotNull] PostgreSqlParser.Oper_argtypesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.oper_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOper_argtypes([NotNull] PostgreSqlParser.Oper_argtypesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_operator([NotNull] PostgreSqlParser.Any_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_operator([NotNull] PostgreSqlParser.Any_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_with_argtypes_list([NotNull] PostgreSqlParser.Operator_with_argtypes_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_with_argtypes_list([NotNull] PostgreSqlParser.Operator_with_argtypes_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_with_argtypes([NotNull] PostgreSqlParser.Operator_with_argtypesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_with_argtypes([NotNull] PostgreSqlParser.Operator_with_argtypesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDostmt([NotNull] PostgreSqlParser.DostmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDostmt([NotNull] PostgreSqlParser.DostmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDostmt_opt_list([NotNull] PostgreSqlParser.Dostmt_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDostmt_opt_list([NotNull] PostgreSqlParser.Dostmt_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDostmt_opt_item([NotNull] PostgreSqlParser.Dostmt_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDostmt_opt_item([NotNull] PostgreSqlParser.Dostmt_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createcaststmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatecaststmt([NotNull] PostgreSqlParser.CreatecaststmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createcaststmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatecaststmt([NotNull] PostgreSqlParser.CreatecaststmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cast_context"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCast_context([NotNull] PostgreSqlParser.Cast_contextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cast_context"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCast_context([NotNull] PostgreSqlParser.Cast_contextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropcaststmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropcaststmt([NotNull] PostgreSqlParser.DropcaststmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropcaststmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropcaststmt([NotNull] PostgreSqlParser.DropcaststmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_if_exists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_if_exists([NotNull] PostgreSqlParser.Opt_if_existsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_if_exists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_if_exists([NotNull] PostgreSqlParser.Opt_if_existsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtransformstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatetransformstmt([NotNull] PostgreSqlParser.CreatetransformstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtransformstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatetransformstmt([NotNull] PostgreSqlParser.CreatetransformstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transform_element_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransform_element_list([NotNull] PostgreSqlParser.Transform_element_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transform_element_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransform_element_list([NotNull] PostgreSqlParser.Transform_element_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droptransformstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDroptransformstmt([NotNull] PostgreSqlParser.DroptransformstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droptransformstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDroptransformstmt([NotNull] PostgreSqlParser.DroptransformstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindexstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindexstmt([NotNull] PostgreSqlParser.ReindexstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindexstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindexstmt([NotNull] PostgreSqlParser.ReindexstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_target_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_target_type([NotNull] PostgreSqlParser.Reindex_target_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_target_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_target_type([NotNull] PostgreSqlParser.Reindex_target_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_target_multitable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_target_multitable([NotNull] PostgreSqlParser.Reindex_target_multitableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_target_multitable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_target_multitable([NotNull] PostgreSqlParser.Reindex_target_multitableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_option_list([NotNull] PostgreSqlParser.Reindex_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_option_list([NotNull] PostgreSqlParser.Reindex_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_option_elem([NotNull] PostgreSqlParser.Reindex_option_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_option_elem([NotNull] PostgreSqlParser.Reindex_option_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertblspcstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltertblspcstmt([NotNull] PostgreSqlParser.AltertblspcstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertblspcstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltertblspcstmt([NotNull] PostgreSqlParser.AltertblspcstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.renamestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRenamestmt([NotNull] PostgreSqlParser.RenamestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.renamestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRenamestmt([NotNull] PostgreSqlParser.RenamestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_column([NotNull] PostgreSqlParser.Opt_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_column([NotNull] PostgreSqlParser.Opt_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_set_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_set_data([NotNull] PostgreSqlParser.Opt_set_dataContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_set_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_set_data([NotNull] PostgreSqlParser.Opt_set_dataContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterobjectdependsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterobjectdependsstmt([NotNull] PostgreSqlParser.AlterobjectdependsstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterobjectdependsstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterobjectdependsstmt([NotNull] PostgreSqlParser.AlterobjectdependsstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_no"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_no([NotNull] PostgreSqlParser.Opt_noContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_no"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_no([NotNull] PostgreSqlParser.Opt_noContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterobjectschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterobjectschemastmt([NotNull] PostgreSqlParser.AlterobjectschemastmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterobjectschemastmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterobjectschemastmt([NotNull] PostgreSqlParser.AlterobjectschemastmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroperatorstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlteroperatorstmt([NotNull] PostgreSqlParser.AlteroperatorstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroperatorstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlteroperatorstmt([NotNull] PostgreSqlParser.AlteroperatorstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_def_list([NotNull] PostgreSqlParser.Operator_def_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_def_list([NotNull] PostgreSqlParser.Operator_def_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_def_elem([NotNull] PostgreSqlParser.Operator_def_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_def_elem([NotNull] PostgreSqlParser.Operator_def_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_def_arg([NotNull] PostgreSqlParser.Operator_def_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_def_arg([NotNull] PostgreSqlParser.Operator_def_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertypestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltertypestmt([NotNull] PostgreSqlParser.AltertypestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertypestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltertypestmt([NotNull] PostgreSqlParser.AltertypestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterownerstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterownerstmt([NotNull] PostgreSqlParser.AlterownerstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterownerstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterownerstmt([NotNull] PostgreSqlParser.AlterownerstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createpublicationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatepublicationstmt([NotNull] PostgreSqlParser.CreatepublicationstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createpublicationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatepublicationstmt([NotNull] PostgreSqlParser.CreatepublicationstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_publication_for_tables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_publication_for_tables([NotNull] PostgreSqlParser.Opt_publication_for_tablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_publication_for_tables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_publication_for_tables([NotNull] PostgreSqlParser.Opt_publication_for_tablesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_for_tables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPublication_for_tables([NotNull] PostgreSqlParser.Publication_for_tablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_for_tables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPublication_for_tables([NotNull] PostgreSqlParser.Publication_for_tablesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterpublicationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterpublicationstmt([NotNull] PostgreSqlParser.AlterpublicationstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterpublicationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterpublicationstmt([NotNull] PostgreSqlParser.AlterpublicationstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createsubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatesubscriptionstmt([NotNull] PostgreSqlParser.CreatesubscriptionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createsubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatesubscriptionstmt([NotNull] PostgreSqlParser.CreatesubscriptionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPublication_name_list([NotNull] PostgreSqlParser.Publication_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPublication_name_list([NotNull] PostgreSqlParser.Publication_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_name_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPublication_name_item([NotNull] PostgreSqlParser.Publication_name_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_name_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPublication_name_item([NotNull] PostgreSqlParser.Publication_name_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altersubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltersubscriptionstmt([NotNull] PostgreSqlParser.AltersubscriptionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altersubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltersubscriptionstmt([NotNull] PostgreSqlParser.AltersubscriptionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropsubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropsubscriptionstmt([NotNull] PostgreSqlParser.DropsubscriptionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropsubscriptionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropsubscriptionstmt([NotNull] PostgreSqlParser.DropsubscriptionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rulestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRulestmt([NotNull] PostgreSqlParser.RulestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rulestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRulestmt([NotNull] PostgreSqlParser.RulestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuleactionlist([NotNull] PostgreSqlParser.RuleactionlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuleactionlist([NotNull] PostgreSqlParser.RuleactionlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionmulti"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuleactionmulti([NotNull] PostgreSqlParser.RuleactionmultiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionmulti"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuleactionmulti([NotNull] PostgreSqlParser.RuleactionmultiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuleactionstmt([NotNull] PostgreSqlParser.RuleactionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuleactionstmt([NotNull] PostgreSqlParser.RuleactionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmtOrEmpty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuleactionstmtOrEmpty([NotNull] PostgreSqlParser.RuleactionstmtOrEmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmtOrEmpty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuleactionstmtOrEmpty([NotNull] PostgreSqlParser.RuleactionstmtOrEmptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent([NotNull] PostgreSqlParser.EventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent([NotNull] PostgreSqlParser.EventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_instead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_instead([NotNull] PostgreSqlParser.Opt_insteadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_instead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_instead([NotNull] PostgreSqlParser.Opt_insteadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.notifystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotifystmt([NotNull] PostgreSqlParser.NotifystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.notifystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotifystmt([NotNull] PostgreSqlParser.NotifystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.notify_payload"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotify_payload([NotNull] PostgreSqlParser.Notify_payloadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.notify_payload"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotify_payload([NotNull] PostgreSqlParser.Notify_payloadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.listenstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterListenstmt([NotNull] PostgreSqlParser.ListenstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.listenstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitListenstmt([NotNull] PostgreSqlParser.ListenstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unlistenstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnlistenstmt([NotNull] PostgreSqlParser.UnlistenstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unlistenstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnlistenstmt([NotNull] PostgreSqlParser.UnlistenstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transactionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionstmt([NotNull] PostgreSqlParser.TransactionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transactionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionstmt([NotNull] PostgreSqlParser.TransactionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_transaction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_transaction([NotNull] PostgreSqlParser.Opt_transactionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_transaction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_transaction([NotNull] PostgreSqlParser.Opt_transactionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_mode_item([NotNull] PostgreSqlParser.Transaction_mode_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_mode_item([NotNull] PostgreSqlParser.Transaction_mode_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_mode_list([NotNull] PostgreSqlParser.Transaction_mode_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_mode_list([NotNull] PostgreSqlParser.Transaction_mode_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list_or_empty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_mode_list_or_empty([NotNull] PostgreSqlParser.Transaction_mode_list_or_emptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list_or_empty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_mode_list_or_empty([NotNull] PostgreSqlParser.Transaction_mode_list_or_emptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_transaction_chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_transaction_chain([NotNull] PostgreSqlParser.Opt_transaction_chainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_transaction_chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_transaction_chain([NotNull] PostgreSqlParser.Opt_transaction_chainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.viewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewstmt([NotNull] PostgreSqlParser.ViewstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.viewstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewstmt([NotNull] PostgreSqlParser.ViewstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_check_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_check_option([NotNull] PostgreSqlParser.Opt_check_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_check_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_check_option([NotNull] PostgreSqlParser.Opt_check_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.loadstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoadstmt([NotNull] PostgreSqlParser.LoadstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.loadstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoadstmt([NotNull] PostgreSqlParser.LoadstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdbstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedbstmt([NotNull] PostgreSqlParser.CreatedbstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdbstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedbstmt([NotNull] PostgreSqlParser.CreatedbstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedb_opt_list([NotNull] PostgreSqlParser.Createdb_opt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedb_opt_list([NotNull] PostgreSqlParser.Createdb_opt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_items"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedb_opt_items([NotNull] PostgreSqlParser.Createdb_opt_itemsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_items"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedb_opt_items([NotNull] PostgreSqlParser.Createdb_opt_itemsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedb_opt_item([NotNull] PostgreSqlParser.Createdb_opt_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedb_opt_item([NotNull] PostgreSqlParser.Createdb_opt_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedb_opt_name([NotNull] PostgreSqlParser.Createdb_opt_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedb_opt_name([NotNull] PostgreSqlParser.Createdb_opt_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_equal([NotNull] PostgreSqlParser.Opt_equalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_equal([NotNull] PostgreSqlParser.Opt_equalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdatabasestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterdatabasestmt([NotNull] PostgreSqlParser.AlterdatabasestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdatabasestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterdatabasestmt([NotNull] PostgreSqlParser.AlterdatabasestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdatabasesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterdatabasesetstmt([NotNull] PostgreSqlParser.AlterdatabasesetstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdatabasesetstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterdatabasesetstmt([NotNull] PostgreSqlParser.AlterdatabasesetstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropdbstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropdbstmt([NotNull] PostgreSqlParser.DropdbstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropdbstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropdbstmt([NotNull] PostgreSqlParser.DropdbstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_option_list([NotNull] PostgreSqlParser.Drop_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_option_list([NotNull] PostgreSqlParser.Drop_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_option([NotNull] PostgreSqlParser.Drop_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_option([NotNull] PostgreSqlParser.Drop_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altercollationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltercollationstmt([NotNull] PostgreSqlParser.AltercollationstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altercollationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltercollationstmt([NotNull] PostgreSqlParser.AltercollationstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altersystemstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltersystemstmt([NotNull] PostgreSqlParser.AltersystemstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altersystemstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltersystemstmt([NotNull] PostgreSqlParser.AltersystemstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdomainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreatedomainstmt([NotNull] PostgreSqlParser.CreatedomainstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdomainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreatedomainstmt([NotNull] PostgreSqlParser.CreatedomainstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdomainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterdomainstmt([NotNull] PostgreSqlParser.AlterdomainstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdomainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterdomainstmt([NotNull] PostgreSqlParser.AlterdomainstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_as([NotNull] PostgreSqlParser.Opt_asContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_as([NotNull] PostgreSqlParser.Opt_asContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertsdictionarystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltertsdictionarystmt([NotNull] PostgreSqlParser.AltertsdictionarystmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertsdictionarystmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltertsdictionarystmt([NotNull] PostgreSqlParser.AltertsdictionarystmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertsconfigurationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAltertsconfigurationstmt([NotNull] PostgreSqlParser.AltertsconfigurationstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertsconfigurationstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAltertsconfigurationstmt([NotNull] PostgreSqlParser.AltertsconfigurationstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_with([NotNull] PostgreSqlParser.Any_withContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_with([NotNull] PostgreSqlParser.Any_withContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createconversionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateconversionstmt([NotNull] PostgreSqlParser.CreateconversionstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createconversionstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateconversionstmt([NotNull] PostgreSqlParser.CreateconversionstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.clusterstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClusterstmt([NotNull] PostgreSqlParser.ClusterstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.clusterstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClusterstmt([NotNull] PostgreSqlParser.ClusterstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cluster_index_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCluster_index_specification([NotNull] PostgreSqlParser.Cluster_index_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cluster_index_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCluster_index_specification([NotNull] PostgreSqlParser.Cluster_index_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuumstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVacuumstmt([NotNull] PostgreSqlParser.VacuumstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuumstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVacuumstmt([NotNull] PostgreSqlParser.VacuumstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.analyzestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalyzestmt([NotNull] PostgreSqlParser.AnalyzestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.analyzestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalyzestmt([NotNull] PostgreSqlParser.AnalyzestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVac_analyze_option_list([NotNull] PostgreSqlParser.Vac_analyze_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVac_analyze_option_list([NotNull] PostgreSqlParser.Vac_analyze_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.analyze_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalyze_keyword([NotNull] PostgreSqlParser.Analyze_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.analyze_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalyze_keyword([NotNull] PostgreSqlParser.Analyze_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVac_analyze_option_elem([NotNull] PostgreSqlParser.Vac_analyze_option_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVac_analyze_option_elem([NotNull] PostgreSqlParser.Vac_analyze_option_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVac_analyze_option_name([NotNull] PostgreSqlParser.Vac_analyze_option_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVac_analyze_option_name([NotNull] PostgreSqlParser.Vac_analyze_option_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVac_analyze_option_arg([NotNull] PostgreSqlParser.Vac_analyze_option_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVac_analyze_option_arg([NotNull] PostgreSqlParser.Vac_analyze_option_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_analyze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_analyze([NotNull] PostgreSqlParser.Opt_analyzeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_analyze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_analyze([NotNull] PostgreSqlParser.Opt_analyzeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_verbose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_verbose([NotNull] PostgreSqlParser.Opt_verboseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_verbose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_verbose([NotNull] PostgreSqlParser.Opt_verboseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_full"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_full([NotNull] PostgreSqlParser.Opt_fullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_full"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_full([NotNull] PostgreSqlParser.Opt_fullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_freeze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_freeze([NotNull] PostgreSqlParser.Opt_freezeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_freeze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_freeze([NotNull] PostgreSqlParser.Opt_freezeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_name_list([NotNull] PostgreSqlParser.Opt_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_name_list([NotNull] PostgreSqlParser.Opt_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVacuum_relation([NotNull] PostgreSqlParser.Vacuum_relationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVacuum_relation([NotNull] PostgreSqlParser.Vacuum_relationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVacuum_relation_list([NotNull] PostgreSqlParser.Vacuum_relation_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVacuum_relation_list([NotNull] PostgreSqlParser.Vacuum_relation_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_vacuum_relation_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_vacuum_relation_list([NotNull] PostgreSqlParser.Opt_vacuum_relation_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_vacuum_relation_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_vacuum_relation_list([NotNull] PostgreSqlParser.Opt_vacuum_relation_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainstmt([NotNull] PostgreSqlParser.ExplainstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explainstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainstmt([NotNull] PostgreSqlParser.ExplainstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explainablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainablestmt([NotNull] PostgreSqlParser.ExplainablestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explainablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainablestmt([NotNull] PostgreSqlParser.ExplainablestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplain_option_list([NotNull] PostgreSqlParser.Explain_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplain_option_list([NotNull] PostgreSqlParser.Explain_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplain_option_elem([NotNull] PostgreSqlParser.Explain_option_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplain_option_elem([NotNull] PostgreSqlParser.Explain_option_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplain_option_name([NotNull] PostgreSqlParser.Explain_option_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplain_option_name([NotNull] PostgreSqlParser.Explain_option_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplain_option_arg([NotNull] PostgreSqlParser.Explain_option_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplain_option_arg([NotNull] PostgreSqlParser.Explain_option_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.preparestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreparestmt([NotNull] PostgreSqlParser.PreparestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.preparestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreparestmt([NotNull] PostgreSqlParser.PreparestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.prep_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrep_type_clause([NotNull] PostgreSqlParser.Prep_type_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.prep_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrep_type_clause([NotNull] PostgreSqlParser.Prep_type_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.preparablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreparablestmt([NotNull] PostgreSqlParser.PreparablestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.preparablestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreparablestmt([NotNull] PostgreSqlParser.PreparablestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.executestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecutestmt([NotNull] PostgreSqlParser.ExecutestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.executestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecutestmt([NotNull] PostgreSqlParser.ExecutestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.execute_param_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_param_clause([NotNull] PostgreSqlParser.Execute_param_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.execute_param_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_param_clause([NotNull] PostgreSqlParser.Execute_param_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.deallocatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeallocatestmt([NotNull] PostgreSqlParser.DeallocatestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.deallocatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeallocatestmt([NotNull] PostgreSqlParser.DeallocatestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insertstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertstmt([NotNull] PostgreSqlParser.InsertstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insertstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertstmt([NotNull] PostgreSqlParser.InsertstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_target([NotNull] PostgreSqlParser.Insert_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_target([NotNull] PostgreSqlParser.Insert_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_rest([NotNull] PostgreSqlParser.Insert_restContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_rest"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_rest([NotNull] PostgreSqlParser.Insert_restContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.override_kind"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOverride_kind([NotNull] PostgreSqlParser.Override_kindContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.override_kind"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOverride_kind([NotNull] PostgreSqlParser.Override_kindContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_column_list([NotNull] PostgreSqlParser.Insert_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_column_list([NotNull] PostgreSqlParser.Insert_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_column_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_column_item([NotNull] PostgreSqlParser.Insert_column_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_column_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_column_item([NotNull] PostgreSqlParser.Insert_column_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_on_conflict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_on_conflict([NotNull] PostgreSqlParser.Opt_on_conflictContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_on_conflict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_on_conflict([NotNull] PostgreSqlParser.Opt_on_conflictContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_conf_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_conf_expr([NotNull] PostgreSqlParser.Opt_conf_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_conf_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_conf_expr([NotNull] PostgreSqlParser.Opt_conf_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturning_clause([NotNull] PostgreSqlParser.Returning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturning_clause([NotNull] PostgreSqlParser.Returning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.deletestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeletestmt([NotNull] PostgreSqlParser.DeletestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.deletestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeletestmt([NotNull] PostgreSqlParser.DeletestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.using_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_clause([NotNull] PostgreSqlParser.Using_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.using_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_clause([NotNull] PostgreSqlParser.Using_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.lockstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockstmt([NotNull] PostgreSqlParser.LockstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.lockstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockstmt([NotNull] PostgreSqlParser.LockstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_lock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_lock([NotNull] PostgreSqlParser.Opt_lockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_lock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_lock([NotNull] PostgreSqlParser.Opt_lockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.lock_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLock_type([NotNull] PostgreSqlParser.Lock_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.lock_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLock_type([NotNull] PostgreSqlParser.Lock_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nowait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_nowait([NotNull] PostgreSqlParser.Opt_nowaitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nowait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_nowait([NotNull] PostgreSqlParser.Opt_nowaitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nowait_or_skip"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_nowait_or_skip([NotNull] PostgreSqlParser.Opt_nowait_or_skipContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nowait_or_skip"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_nowait_or_skip([NotNull] PostgreSqlParser.Opt_nowait_or_skipContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.updatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdatestmt([NotNull] PostgreSqlParser.UpdatestmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.updatestmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdatestmt([NotNull] PostgreSqlParser.UpdatestmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_clause_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_clause_list([NotNull] PostgreSqlParser.Set_clause_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_clause_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_clause_list([NotNull] PostgreSqlParser.Set_clause_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_clause([NotNull] PostgreSqlParser.Set_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_clause([NotNull] PostgreSqlParser.Set_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_target([NotNull] PostgreSqlParser.Set_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_target([NotNull] PostgreSqlParser.Set_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_target_list([NotNull] PostgreSqlParser.Set_target_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_target_list([NotNull] PostgreSqlParser.Set_target_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.declarecursorstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarecursorstmt([NotNull] PostgreSqlParser.DeclarecursorstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.declarecursorstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarecursorstmt([NotNull] PostgreSqlParser.DeclarecursorstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_name([NotNull] PostgreSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_name([NotNull] PostgreSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_options([NotNull] PostgreSqlParser.Cursor_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_options([NotNull] PostgreSqlParser.Cursor_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_hold"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_hold([NotNull] PostgreSqlParser.Opt_holdContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_hold"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_hold([NotNull] PostgreSqlParser.Opt_holdContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.selectstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectstmt([NotNull] PostgreSqlParser.SelectstmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.selectstmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectstmt([NotNull] PostgreSqlParser.SelectstmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_with_parens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_with_parens([NotNull] PostgreSqlParser.Select_with_parensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_with_parens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_with_parens([NotNull] PostgreSqlParser.Select_with_parensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_no_parens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_no_parens([NotNull] PostgreSqlParser.Select_no_parensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_no_parens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_no_parens([NotNull] PostgreSqlParser.Select_no_parensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_clause([NotNull] PostgreSqlParser.Select_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_clause([NotNull] PostgreSqlParser.Select_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.simple_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_select([NotNull] PostgreSqlParser.Simple_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.simple_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_select([NotNull] PostgreSqlParser.Simple_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>union</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnion([NotNull] PostgreSqlParser.UnionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>union</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnion([NotNull] PostgreSqlParser.UnionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>intersect</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntersect([NotNull] PostgreSqlParser.IntersectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>intersect</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntersect([NotNull] PostgreSqlParser.IntersectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>except</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExcept([NotNull] PostgreSqlParser.ExceptContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>except</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExcept([NotNull] PostgreSqlParser.ExceptContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_operator_with_all_or_distinct"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_operator_with_all_or_distinct([NotNull] PostgreSqlParser.Set_operator_with_all_or_distinctContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_operator_with_all_or_distinct"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_operator_with_all_or_distinct([NotNull] PostgreSqlParser.Set_operator_with_all_or_distinctContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_clause([NotNull] PostgreSqlParser.With_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_clause([NotNull] PostgreSqlParser.With_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cte_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCte_list([NotNull] PostgreSqlParser.Cte_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cte_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCte_list([NotNull] PostgreSqlParser.Cte_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.common_table_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_expr([NotNull] PostgreSqlParser.Common_table_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.common_table_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_expr([NotNull] PostgreSqlParser.Common_table_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_materialized"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_materialized([NotNull] PostgreSqlParser.Opt_materializedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_materialized"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_materialized([NotNull] PostgreSqlParser.Opt_materializedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_with_clause([NotNull] PostgreSqlParser.Opt_with_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_with_clause([NotNull] PostgreSqlParser.Opt_with_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInto_clause([NotNull] PostgreSqlParser.Into_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInto_clause([NotNull] PostgreSqlParser.Into_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_strict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_strict([NotNull] PostgreSqlParser.Opt_strictContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_strict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_strict([NotNull] PostgreSqlParser.Opt_strictContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttempTableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttempTableName([NotNull] PostgreSqlParser.OpttempTableNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttempTableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttempTableName([NotNull] PostgreSqlParser.OpttempTableNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_table([NotNull] PostgreSqlParser.Opt_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_table([NotNull] PostgreSqlParser.Opt_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.all_or_distinct"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAll_or_distinct([NotNull] PostgreSqlParser.All_or_distinctContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.all_or_distinct"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAll_or_distinct([NotNull] PostgreSqlParser.All_or_distinctContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.distinct_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDistinct_clause([NotNull] PostgreSqlParser.Distinct_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.distinct_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDistinct_clause([NotNull] PostgreSqlParser.Distinct_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_all_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_all_clause([NotNull] PostgreSqlParser.Opt_all_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_all_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_all_clause([NotNull] PostgreSqlParser.Opt_all_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_sort_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_sort_clause([NotNull] PostgreSqlParser.Opt_sort_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_sort_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_sort_clause([NotNull] PostgreSqlParser.Opt_sort_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sort_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSort_clause([NotNull] PostgreSqlParser.Sort_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sort_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSort_clause([NotNull] PostgreSqlParser.Sort_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sortby_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSortby_list([NotNull] PostgreSqlParser.Sortby_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sortby_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSortby_list([NotNull] PostgreSqlParser.Sortby_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sortby"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSortby([NotNull] PostgreSqlParser.SortbyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sortby"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSortby([NotNull] PostgreSqlParser.SortbyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_limit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_limit([NotNull] PostgreSqlParser.Select_limitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_limit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_limit([NotNull] PostgreSqlParser.Select_limitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_select_limit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_select_limit([NotNull] PostgreSqlParser.Opt_select_limitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_select_limit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_select_limit([NotNull] PostgreSqlParser.Opt_select_limitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.limit_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimit_clause([NotNull] PostgreSqlParser.Limit_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.limit_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimit_clause([NotNull] PostgreSqlParser.Limit_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.offset_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOffset_clause([NotNull] PostgreSqlParser.Offset_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.offset_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOffset_clause([NotNull] PostgreSqlParser.Offset_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_limit_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_limit_value([NotNull] PostgreSqlParser.Select_limit_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_limit_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_limit_value([NotNull] PostgreSqlParser.Select_limit_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_offset_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_offset_value([NotNull] PostgreSqlParser.Select_offset_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_offset_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_offset_value([NotNull] PostgreSqlParser.Select_offset_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_fetch_first_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_fetch_first_value([NotNull] PostgreSqlParser.Select_fetch_first_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_fetch_first_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_fetch_first_value([NotNull] PostgreSqlParser.Select_fetch_first_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.i_or_f_const"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterI_or_f_const([NotNull] PostgreSqlParser.I_or_f_constContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.i_or_f_const"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitI_or_f_const([NotNull] PostgreSqlParser.I_or_f_constContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row_or_rows"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRow_or_rows([NotNull] PostgreSqlParser.Row_or_rowsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row_or_rows"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRow_or_rows([NotNull] PostgreSqlParser.Row_or_rowsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.first_or_next"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFirst_or_next([NotNull] PostgreSqlParser.First_or_nextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.first_or_next"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFirst_or_next([NotNull] PostgreSqlParser.First_or_nextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_clause([NotNull] PostgreSqlParser.Group_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_clause([NotNull] PostgreSqlParser.Group_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_by_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_by_list([NotNull] PostgreSqlParser.Group_by_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_by_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_by_list([NotNull] PostgreSqlParser.Group_by_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_by_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_by_item([NotNull] PostgreSqlParser.Group_by_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_by_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_by_item([NotNull] PostgreSqlParser.Group_by_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.empty_grouping_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmpty_grouping_set([NotNull] PostgreSqlParser.Empty_grouping_setContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.empty_grouping_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmpty_grouping_set([NotNull] PostgreSqlParser.Empty_grouping_setContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rollup_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollup_clause([NotNull] PostgreSqlParser.Rollup_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rollup_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollup_clause([NotNull] PostgreSqlParser.Rollup_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cube_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCube_clause([NotNull] PostgreSqlParser.Cube_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cube_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCube_clause([NotNull] PostgreSqlParser.Cube_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grouping_sets_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrouping_sets_clause([NotNull] PostgreSqlParser.Grouping_sets_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grouping_sets_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrouping_sets_clause([NotNull] PostgreSqlParser.Grouping_sets_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.having_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHaving_clause([NotNull] PostgreSqlParser.Having_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.having_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHaving_clause([NotNull] PostgreSqlParser.Having_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_locking_clause([NotNull] PostgreSqlParser.For_locking_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_locking_clause([NotNull] PostgreSqlParser.For_locking_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_for_locking_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_for_locking_clause([NotNull] PostgreSqlParser.Opt_for_locking_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_for_locking_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_for_locking_clause([NotNull] PostgreSqlParser.Opt_for_locking_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_items"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_locking_items([NotNull] PostgreSqlParser.For_locking_itemsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_items"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_locking_items([NotNull] PostgreSqlParser.For_locking_itemsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_locking_item([NotNull] PostgreSqlParser.For_locking_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_locking_item([NotNull] PostgreSqlParser.For_locking_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_strength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_locking_strength([NotNull] PostgreSqlParser.For_locking_strengthContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_strength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_locking_strength([NotNull] PostgreSqlParser.For_locking_strengthContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.locked_rels_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocked_rels_list([NotNull] PostgreSqlParser.Locked_rels_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.locked_rels_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocked_rels_list([NotNull] PostgreSqlParser.Locked_rels_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValues_clause([NotNull] PostgreSqlParser.Values_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValues_clause([NotNull] PostgreSqlParser.Values_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrom_clause([NotNull] PostgreSqlParser.From_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrom_clause([NotNull] PostgreSqlParser.From_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrom_list([NotNull] PostgreSqlParser.From_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrom_list([NotNull] PostgreSqlParser.From_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref([NotNull] PostgreSqlParser.Table_refContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref([NotNull] PostgreSqlParser.Table_refContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlias_clause([NotNull] PostgreSqlParser.Alias_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlias_clause([NotNull] PostgreSqlParser.Alias_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_alias_clause([NotNull] PostgreSqlParser.Opt_alias_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_alias_clause([NotNull] PostgreSqlParser.Opt_alias_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_alias_clause([NotNull] PostgreSqlParser.Func_alias_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_alias_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_alias_clause([NotNull] PostgreSqlParser.Func_alias_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.join_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_type([NotNull] PostgreSqlParser.Join_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.join_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_type([NotNull] PostgreSqlParser.Join_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.join_qual"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_qual([NotNull] PostgreSqlParser.Join_qualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.join_qual"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_qual([NotNull] PostgreSqlParser.Join_qualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelation_expr([NotNull] PostgreSqlParser.Relation_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelation_expr([NotNull] PostgreSqlParser.Relation_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelation_expr_list([NotNull] PostgreSqlParser.Relation_expr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelation_expr_list([NotNull] PostgreSqlParser.Relation_expr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr_opt_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelation_expr_opt_alias([NotNull] PostgreSqlParser.Relation_expr_opt_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr_opt_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelation_expr_opt_alias([NotNull] PostgreSqlParser.Relation_expr_opt_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablesample_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablesample_clause([NotNull] PostgreSqlParser.Tablesample_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablesample_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablesample_clause([NotNull] PostgreSqlParser.Tablesample_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_repeatable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_repeatable_clause([NotNull] PostgreSqlParser.Opt_repeatable_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_repeatable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_repeatable_clause([NotNull] PostgreSqlParser.Opt_repeatable_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_table([NotNull] PostgreSqlParser.Func_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_table([NotNull] PostgreSqlParser.Func_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsfrom_item([NotNull] PostgreSqlParser.Rowsfrom_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsfrom_item([NotNull] PostgreSqlParser.Rowsfrom_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowsfrom_list([NotNull] PostgreSqlParser.Rowsfrom_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowsfrom_list([NotNull] PostgreSqlParser.Rowsfrom_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_col_def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_col_def_list([NotNull] PostgreSqlParser.Opt_col_def_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_col_def_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_col_def_list([NotNull] PostgreSqlParser.Opt_col_def_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_ordinality"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_ordinality([NotNull] PostgreSqlParser.Opt_ordinalityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_ordinality"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_ordinality([NotNull] PostgreSqlParser.Opt_ordinalityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhere_clause([NotNull] PostgreSqlParser.Where_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhere_clause([NotNull] PostgreSqlParser.Where_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.where_or_current_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhere_or_current_clause([NotNull] PostgreSqlParser.Where_or_current_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.where_or_current_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhere_or_current_clause([NotNull] PostgreSqlParser.Where_or_current_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablefuncelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpttablefuncelementlist([NotNull] PostgreSqlParser.OpttablefuncelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablefuncelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpttablefuncelementlist([NotNull] PostgreSqlParser.OpttablefuncelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablefuncelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablefuncelementlist([NotNull] PostgreSqlParser.TablefuncelementlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablefuncelementlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablefuncelementlist([NotNull] PostgreSqlParser.TablefuncelementlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablefuncelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablefuncelement([NotNull] PostgreSqlParser.TablefuncelementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablefuncelement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablefuncelement([NotNull] PostgreSqlParser.TablefuncelementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable([NotNull] PostgreSqlParser.XmltableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable([NotNull] PostgreSqlParser.XmltableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable_column_list([NotNull] PostgreSqlParser.Xmltable_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable_column_list([NotNull] PostgreSqlParser.Xmltable_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable_column_el([NotNull] PostgreSqlParser.Xmltable_column_elContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable_column_el([NotNull] PostgreSqlParser.Xmltable_column_elContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable_column_option_list([NotNull] PostgreSqlParser.Xmltable_column_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable_column_option_list([NotNull] PostgreSqlParser.Xmltable_column_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable_column_option_el([NotNull] PostgreSqlParser.Xmltable_column_option_elContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable_column_option_el([NotNull] PostgreSqlParser.Xmltable_column_option_elContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_namespace_list([NotNull] PostgreSqlParser.Xml_namespace_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_namespace_list([NotNull] PostgreSqlParser.Xml_namespace_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_namespace_el([NotNull] PostgreSqlParser.Xml_namespace_elContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_namespace_el([NotNull] PostgreSqlParser.Xml_namespace_elContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypename([NotNull] PostgreSqlParser.TypenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypename([NotNull] PostgreSqlParser.TypenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_array_bounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_array_bounds([NotNull] PostgreSqlParser.Opt_array_boundsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_array_bounds"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_array_bounds([NotNull] PostgreSqlParser.Opt_array_boundsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.simpletypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpletypename([NotNull] PostgreSqlParser.SimpletypenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.simpletypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpletypename([NotNull] PostgreSqlParser.SimpletypenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.consttypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConsttypename([NotNull] PostgreSqlParser.ConsttypenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.consttypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConsttypename([NotNull] PostgreSqlParser.ConsttypenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generictype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenerictype([NotNull] PostgreSqlParser.GenerictypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generictype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenerictype([NotNull] PostgreSqlParser.GenerictypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_type_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_type_modifiers([NotNull] PostgreSqlParser.Opt_type_modifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_type_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_type_modifiers([NotNull] PostgreSqlParser.Opt_type_modifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric([NotNull] PostgreSqlParser.NumericContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric([NotNull] PostgreSqlParser.NumericContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_float"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_float([NotNull] PostgreSqlParser.Opt_floatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_float"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_float([NotNull] PostgreSqlParser.Opt_floatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBit([NotNull] PostgreSqlParser.BitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBit([NotNull] PostgreSqlParser.BitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constbit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstbit([NotNull] PostgreSqlParser.ConstbitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constbit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstbit([NotNull] PostgreSqlParser.ConstbitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bitwithlength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitwithlength([NotNull] PostgreSqlParser.BitwithlengthContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bitwithlength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitwithlength([NotNull] PostgreSqlParser.BitwithlengthContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bitwithoutlength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitwithoutlength([NotNull] PostgreSqlParser.BitwithoutlengthContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bitwithoutlength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitwithoutlength([NotNull] PostgreSqlParser.BitwithoutlengthContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.character"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharacter([NotNull] PostgreSqlParser.CharacterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.character"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharacter([NotNull] PostgreSqlParser.CharacterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constcharacter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstcharacter([NotNull] PostgreSqlParser.ConstcharacterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constcharacter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstcharacter([NotNull] PostgreSqlParser.ConstcharacterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.character_c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharacter_c([NotNull] PostgreSqlParser.Character_cContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.character_c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharacter_c([NotNull] PostgreSqlParser.Character_cContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_varying"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_varying([NotNull] PostgreSqlParser.Opt_varyingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_varying"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_varying([NotNull] PostgreSqlParser.Opt_varyingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constdatetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstdatetime([NotNull] PostgreSqlParser.ConstdatetimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constdatetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstdatetime([NotNull] PostgreSqlParser.ConstdatetimeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constinterval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstinterval([NotNull] PostgreSqlParser.ConstintervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constinterval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstinterval([NotNull] PostgreSqlParser.ConstintervalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_timezone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_timezone([NotNull] PostgreSqlParser.Opt_timezoneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_timezone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_timezone([NotNull] PostgreSqlParser.Opt_timezoneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_interval([NotNull] PostgreSqlParser.Opt_intervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_interval([NotNull] PostgreSqlParser.Opt_intervalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.interval_second"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterval_second([NotNull] PostgreSqlParser.Interval_secondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.interval_second"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterval_second([NotNull] PostgreSqlParser.Interval_secondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_escape"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_escape([NotNull] PostgreSqlParser.Opt_escapeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_escape"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_escape([NotNull] PostgreSqlParser.Opt_escapeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr([NotNull] PostgreSqlParser.A_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr([NotNull] PostgreSqlParser.A_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_qual([NotNull] PostgreSqlParser.A_expr_qualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_qual([NotNull] PostgreSqlParser.A_expr_qualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_lessless"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_lessless([NotNull] PostgreSqlParser.A_expr_lesslessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_lessless"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_lessless([NotNull] PostgreSqlParser.A_expr_lesslessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_or"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_or([NotNull] PostgreSqlParser.A_expr_orContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_or"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_or([NotNull] PostgreSqlParser.A_expr_orContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_and"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_and([NotNull] PostgreSqlParser.A_expr_andContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_and"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_and([NotNull] PostgreSqlParser.A_expr_andContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_in([NotNull] PostgreSqlParser.A_expr_inContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_in"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_in([NotNull] PostgreSqlParser.A_expr_inContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_not"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_unary_not([NotNull] PostgreSqlParser.A_expr_unary_notContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_not"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_unary_not([NotNull] PostgreSqlParser.A_expr_unary_notContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_isnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_isnull([NotNull] PostgreSqlParser.A_expr_isnullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_isnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_isnull([NotNull] PostgreSqlParser.A_expr_isnullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_is_not"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_is_not([NotNull] PostgreSqlParser.A_expr_is_notContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_is_not"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_is_not([NotNull] PostgreSqlParser.A_expr_is_notContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_compare"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_compare([NotNull] PostgreSqlParser.A_expr_compareContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_compare"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_compare([NotNull] PostgreSqlParser.A_expr_compareContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_like"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_like([NotNull] PostgreSqlParser.A_expr_likeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_like"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_like([NotNull] PostgreSqlParser.A_expr_likeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_qual_op([NotNull] PostgreSqlParser.A_expr_qual_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_qual_op([NotNull] PostgreSqlParser.A_expr_qual_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_qualop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_unary_qualop([NotNull] PostgreSqlParser.A_expr_unary_qualopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_qualop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_unary_qualop([NotNull] PostgreSqlParser.A_expr_unary_qualopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_add"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_add([NotNull] PostgreSqlParser.A_expr_addContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_add"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_add([NotNull] PostgreSqlParser.A_expr_addContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_mul"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_mul([NotNull] PostgreSqlParser.A_expr_mulContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_mul"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_mul([NotNull] PostgreSqlParser.A_expr_mulContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_caret"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_caret([NotNull] PostgreSqlParser.A_expr_caretContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_caret"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_caret([NotNull] PostgreSqlParser.A_expr_caretContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_unary_sign([NotNull] PostgreSqlParser.A_expr_unary_signContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_unary_sign([NotNull] PostgreSqlParser.A_expr_unary_signContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_at_time_zone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_at_time_zone([NotNull] PostgreSqlParser.A_expr_at_time_zoneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_at_time_zone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_at_time_zone([NotNull] PostgreSqlParser.A_expr_at_time_zoneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_collate([NotNull] PostgreSqlParser.A_expr_collateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_collate([NotNull] PostgreSqlParser.A_expr_collateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_typecast"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterA_expr_typecast([NotNull] PostgreSqlParser.A_expr_typecastContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_typecast"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitA_expr_typecast([NotNull] PostgreSqlParser.A_expr_typecastContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.b_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterB_expr([NotNull] PostgreSqlParser.B_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.b_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitB_expr([NotNull] PostgreSqlParser.B_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_exists</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_expr_exists([NotNull] PostgreSqlParser.C_expr_existsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_exists</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_expr_exists([NotNull] PostgreSqlParser.C_expr_existsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_expr</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_expr_expr([NotNull] PostgreSqlParser.C_expr_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_expr</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_expr_expr([NotNull] PostgreSqlParser.C_expr_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_case</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_expr_case([NotNull] PostgreSqlParser.C_expr_caseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_case</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_expr_case([NotNull] PostgreSqlParser.C_expr_caseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlvariablename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsqlvariablename([NotNull] PostgreSqlParser.PlsqlvariablenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlvariablename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsqlvariablename([NotNull] PostgreSqlParser.PlsqlvariablenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_application"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_application([NotNull] PostgreSqlParser.Func_applicationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_application"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_application([NotNull] PostgreSqlParser.Func_applicationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_expr([NotNull] PostgreSqlParser.Func_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_expr([NotNull] PostgreSqlParser.Func_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr_windowless"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_expr_windowless([NotNull] PostgreSqlParser.Func_expr_windowlessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr_windowless"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_expr_windowless([NotNull] PostgreSqlParser.Func_expr_windowlessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr_common_subexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_expr_common_subexpr([NotNull] PostgreSqlParser.Func_expr_common_subexprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr_common_subexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_expr_common_subexpr([NotNull] PostgreSqlParser.Func_expr_common_subexprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_root_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_root_version([NotNull] PostgreSqlParser.Xml_root_versionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_root_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_root_version([NotNull] PostgreSqlParser.Xml_root_versionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_xml_root_standalone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_xml_root_standalone([NotNull] PostgreSqlParser.Opt_xml_root_standaloneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_xml_root_standalone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_xml_root_standalone([NotNull] PostgreSqlParser.Opt_xml_root_standaloneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_attributes([NotNull] PostgreSqlParser.Xml_attributesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_attributes([NotNull] PostgreSqlParser.Xml_attributesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_attribute_list([NotNull] PostgreSqlParser.Xml_attribute_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_attribute_list([NotNull] PostgreSqlParser.Xml_attribute_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_attribute_el([NotNull] PostgreSqlParser.Xml_attribute_elContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_attribute_el([NotNull] PostgreSqlParser.Xml_attribute_elContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.document_or_content"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDocument_or_content([NotNull] PostgreSqlParser.Document_or_contentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.document_or_content"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDocument_or_content([NotNull] PostgreSqlParser.Document_or_contentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_whitespace_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_whitespace_option([NotNull] PostgreSqlParser.Xml_whitespace_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_whitespace_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_whitespace_option([NotNull] PostgreSqlParser.Xml_whitespace_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmlexists_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlexists_argument([NotNull] PostgreSqlParser.Xmlexists_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmlexists_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlexists_argument([NotNull] PostgreSqlParser.Xmlexists_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_passing_mech"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_passing_mech([NotNull] PostgreSqlParser.Xml_passing_mechContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_passing_mech"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_passing_mech([NotNull] PostgreSqlParser.Xml_passing_mechContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.within_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithin_group_clause([NotNull] PostgreSqlParser.Within_group_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.within_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithin_group_clause([NotNull] PostgreSqlParser.Within_group_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilter_clause([NotNull] PostgreSqlParser.Filter_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilter_clause([NotNull] PostgreSqlParser.Filter_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_clause([NotNull] PostgreSqlParser.Window_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_clause([NotNull] PostgreSqlParser.Window_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_definition_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_definition_list([NotNull] PostgreSqlParser.Window_definition_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_definition_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_definition_list([NotNull] PostgreSqlParser.Window_definition_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_definition([NotNull] PostgreSqlParser.Window_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_definition([NotNull] PostgreSqlParser.Window_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause([NotNull] PostgreSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause([NotNull] PostgreSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_specification([NotNull] PostgreSqlParser.Window_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_specification([NotNull] PostgreSqlParser.Window_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_existing_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_existing_window_name([NotNull] PostgreSqlParser.Opt_existing_window_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_existing_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_existing_window_name([NotNull] PostgreSqlParser.Opt_existing_window_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_partition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_partition_clause([NotNull] PostgreSqlParser.Opt_partition_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_partition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_partition_clause([NotNull] PostgreSqlParser.Opt_partition_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_frame_clause([NotNull] PostgreSqlParser.Opt_frame_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_frame_clause([NotNull] PostgreSqlParser.Opt_frame_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.frame_extent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_extent([NotNull] PostgreSqlParser.Frame_extentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.frame_extent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_extent([NotNull] PostgreSqlParser.Frame_extentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.frame_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_bound([NotNull] PostgreSqlParser.Frame_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.frame_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_bound([NotNull] PostgreSqlParser.Frame_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_window_exclusion_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_window_exclusion_clause([NotNull] PostgreSqlParser.Opt_window_exclusion_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_window_exclusion_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_window_exclusion_clause([NotNull] PostgreSqlParser.Opt_window_exclusion_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRow([NotNull] PostgreSqlParser.RowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRow([NotNull] PostgreSqlParser.RowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explicit_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicit_row([NotNull] PostgreSqlParser.Explicit_rowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explicit_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicit_row([NotNull] PostgreSqlParser.Explicit_rowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.implicit_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImplicit_row([NotNull] PostgreSqlParser.Implicit_rowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.implicit_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImplicit_row([NotNull] PostgreSqlParser.Implicit_rowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sub_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSub_type([NotNull] PostgreSqlParser.Sub_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sub_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSub_type([NotNull] PostgreSqlParser.Sub_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.all_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAll_op([NotNull] PostgreSqlParser.All_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.all_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAll_op([NotNull] PostgreSqlParser.All_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.mathop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathop([NotNull] PostgreSqlParser.MathopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.mathop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathop([NotNull] PostgreSqlParser.MathopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qual_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQual_op([NotNull] PostgreSqlParser.Qual_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qual_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQual_op([NotNull] PostgreSqlParser.Qual_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qual_all_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQual_all_op([NotNull] PostgreSqlParser.Qual_all_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qual_all_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQual_all_op([NotNull] PostgreSqlParser.Qual_all_opContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.subquery_Op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery_Op([NotNull] PostgreSqlParser.Subquery_OpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.subquery_Op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery_Op([NotNull] PostgreSqlParser.Subquery_OpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_list([NotNull] PostgreSqlParser.Expr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_list([NotNull] PostgreSqlParser.Expr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_arg_list([NotNull] PostgreSqlParser.Func_arg_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_arg_list([NotNull] PostgreSqlParser.Func_arg_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_arg_expr([NotNull] PostgreSqlParser.Func_arg_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_arg_expr([NotNull] PostgreSqlParser.Func_arg_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_list([NotNull] PostgreSqlParser.Type_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_list([NotNull] PostgreSqlParser.Type_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.array_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray_expr([NotNull] PostgreSqlParser.Array_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.array_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray_expr([NotNull] PostgreSqlParser.Array_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.array_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray_expr_list([NotNull] PostgreSqlParser.Array_expr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.array_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray_expr_list([NotNull] PostgreSqlParser.Array_expr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.extract_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtract_list([NotNull] PostgreSqlParser.Extract_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.extract_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtract_list([NotNull] PostgreSqlParser.Extract_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.extract_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtract_arg([NotNull] PostgreSqlParser.Extract_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.extract_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtract_arg([NotNull] PostgreSqlParser.Extract_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unicode_normal_form"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnicode_normal_form([NotNull] PostgreSqlParser.Unicode_normal_formContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unicode_normal_form"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnicode_normal_form([NotNull] PostgreSqlParser.Unicode_normal_formContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.overlay_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOverlay_list([NotNull] PostgreSqlParser.Overlay_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.overlay_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOverlay_list([NotNull] PostgreSqlParser.Overlay_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.position_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPosition_list([NotNull] PostgreSqlParser.Position_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.position_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPosition_list([NotNull] PostgreSqlParser.Position_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.substr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubstr_list([NotNull] PostgreSqlParser.Substr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.substr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubstr_list([NotNull] PostgreSqlParser.Substr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.trim_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrim_list([NotNull] PostgreSqlParser.Trim_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.trim_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrim_list([NotNull] PostgreSqlParser.Trim_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>in_expr_select</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIn_expr_select([NotNull] PostgreSqlParser.In_expr_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>in_expr_select</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIn_expr_select([NotNull] PostgreSqlParser.In_expr_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>in_expr_list</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIn_expr_list([NotNull] PostgreSqlParser.In_expr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>in_expr_list</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIn_expr_list([NotNull] PostgreSqlParser.In_expr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_expr([NotNull] PostgreSqlParser.Case_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_expr([NotNull] PostgreSqlParser.Case_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.when_clause_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhen_clause_list([NotNull] PostgreSqlParser.When_clause_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.when_clause_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhen_clause_list([NotNull] PostgreSqlParser.When_clause_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.when_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhen_clause([NotNull] PostgreSqlParser.When_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.when_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhen_clause([NotNull] PostgreSqlParser.When_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_default([NotNull] PostgreSqlParser.Case_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_default([NotNull] PostgreSqlParser.Case_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_arg([NotNull] PostgreSqlParser.Case_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_arg([NotNull] PostgreSqlParser.Case_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnref([NotNull] PostgreSqlParser.ColumnrefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnref([NotNull] PostgreSqlParser.ColumnrefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indirection_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndirection_el([NotNull] PostgreSqlParser.Indirection_elContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indirection_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndirection_el([NotNull] PostgreSqlParser.Indirection_elContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_slice_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_slice_bound([NotNull] PostgreSqlParser.Opt_slice_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_slice_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_slice_bound([NotNull] PostgreSqlParser.Opt_slice_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indirection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndirection([NotNull] PostgreSqlParser.IndirectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indirection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndirection([NotNull] PostgreSqlParser.IndirectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_indirection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_indirection([NotNull] PostgreSqlParser.Opt_indirectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_indirection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_indirection([NotNull] PostgreSqlParser.Opt_indirectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_target_list([NotNull] PostgreSqlParser.Opt_target_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_target_list([NotNull] PostgreSqlParser.Opt_target_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTarget_list([NotNull] PostgreSqlParser.Target_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.target_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTarget_list([NotNull] PostgreSqlParser.Target_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>target_label</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTarget_label([NotNull] PostgreSqlParser.Target_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>target_label</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTarget_label([NotNull] PostgreSqlParser.Target_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>target_star</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTarget_star([NotNull] PostgreSqlParser.Target_starContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>target_star</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTarget_star([NotNull] PostgreSqlParser.Target_starContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qualified_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_name_list([NotNull] PostgreSqlParser.Qualified_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qualified_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_name_list([NotNull] PostgreSqlParser.Qualified_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qualified_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_name([NotNull] PostgreSqlParser.Qualified_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qualified_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_name([NotNull] PostgreSqlParser.Qualified_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName_list([NotNull] PostgreSqlParser.Name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName_list([NotNull] PostgreSqlParser.Name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] PostgreSqlParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] PostgreSqlParser.NameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.attr_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttr_name([NotNull] PostgreSqlParser.Attr_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.attr_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttr_name([NotNull] PostgreSqlParser.Attr_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_name([NotNull] PostgreSqlParser.File_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_name([NotNull] PostgreSqlParser.File_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_name([NotNull] PostgreSqlParser.Func_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_name([NotNull] PostgreSqlParser.Func_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aexprconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAexprconst([NotNull] PostgreSqlParser.AexprconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aexprconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAexprconst([NotNull] PostgreSqlParser.AexprconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXconst([NotNull] PostgreSqlParser.XconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXconst([NotNull] PostgreSqlParser.XconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBconst([NotNull] PostgreSqlParser.BconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBconst([NotNull] PostgreSqlParser.BconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFconst([NotNull] PostgreSqlParser.FconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFconst([NotNull] PostgreSqlParser.FconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.iconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIconst([NotNull] PostgreSqlParser.IconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.iconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIconst([NotNull] PostgreSqlParser.IconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSconst([NotNull] PostgreSqlParser.SconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSconst([NotNull] PostgreSqlParser.SconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.anysconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnysconst([NotNull] PostgreSqlParser.AnysconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.anysconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnysconst([NotNull] PostgreSqlParser.AnysconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_uescape"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_uescape([NotNull] PostgreSqlParser.Opt_uescapeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_uescape"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_uescape([NotNull] PostgreSqlParser.Opt_uescapeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.signediconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignediconst([NotNull] PostgreSqlParser.SignediconstContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.signediconst"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignediconst([NotNull] PostgreSqlParser.SignediconstContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.roleid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleid([NotNull] PostgreSqlParser.RoleidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.roleid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleid([NotNull] PostgreSqlParser.RoleidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rolespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRolespec([NotNull] PostgreSqlParser.RolespecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rolespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRolespec([NotNull] PostgreSqlParser.RolespecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.role_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRole_list([NotNull] PostgreSqlParser.Role_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.role_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRole_list([NotNull] PostgreSqlParser.Role_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColid([NotNull] PostgreSqlParser.ColidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColid([NotNull] PostgreSqlParser.ColidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_function_name([NotNull] PostgreSqlParser.Type_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_function_name([NotNull] PostgreSqlParser.Type_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.nonreservedword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNonreservedword([NotNull] PostgreSqlParser.NonreservedwordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.nonreservedword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNonreservedword([NotNull] PostgreSqlParser.NonreservedwordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.collabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollabel([NotNull] PostgreSqlParser.CollabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.collabel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollabel([NotNull] PostgreSqlParser.CollabelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PostgreSqlParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PostgreSqlParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlidentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsqlidentifier([NotNull] PostgreSqlParser.PlsqlidentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlidentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsqlidentifier([NotNull] PostgreSqlParser.PlsqlidentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unreserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnreserved_keyword([NotNull] PostgreSqlParser.Unreserved_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unreserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnreserved_keyword([NotNull] PostgreSqlParser.Unreserved_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.col_name_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCol_name_keyword([NotNull] PostgreSqlParser.Col_name_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.col_name_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCol_name_keyword([NotNull] PostgreSqlParser.Col_name_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_func_name_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_func_name_keyword([NotNull] PostgreSqlParser.Type_func_name_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_func_name_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_func_name_keyword([NotNull] PostgreSqlParser.Type_func_name_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReserved_keyword([NotNull] PostgreSqlParser.Reserved_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReserved_keyword([NotNull] PostgreSqlParser.Reserved_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.pl_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPl_function([NotNull] PostgreSqlParser.Pl_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.pl_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPl_function([NotNull] PostgreSqlParser.Pl_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comp_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_options([NotNull] PostgreSqlParser.Comp_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comp_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_options([NotNull] PostgreSqlParser.Comp_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comp_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_option([NotNull] PostgreSqlParser.Comp_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comp_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_option([NotNull] PostgreSqlParser.Comp_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sharp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSharp([NotNull] PostgreSqlParser.SharpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sharp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSharp([NotNull] PostgreSqlParser.SharpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.option_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOption_value([NotNull] PostgreSqlParser.Option_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.option_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOption_value([NotNull] PostgreSqlParser.Option_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_semi([NotNull] PostgreSqlParser.Opt_semiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_semi([NotNull] PostgreSqlParser.Opt_semiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.pl_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPl_block([NotNull] PostgreSqlParser.Pl_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.pl_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPl_block([NotNull] PostgreSqlParser.Pl_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_sect([NotNull] PostgreSqlParser.Decl_sectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_sect([NotNull] PostgreSqlParser.Decl_sectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_start([NotNull] PostgreSqlParser.Decl_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_start([NotNull] PostgreSqlParser.Decl_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_stmts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_stmts([NotNull] PostgreSqlParser.Decl_stmtsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_stmts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_stmts([NotNull] PostgreSqlParser.Decl_stmtsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.label_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel_decl([NotNull] PostgreSqlParser.Label_declContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.label_decl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel_decl([NotNull] PostgreSqlParser.Label_declContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_stmt([NotNull] PostgreSqlParser.Decl_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_stmt([NotNull] PostgreSqlParser.Decl_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_statement([NotNull] PostgreSqlParser.Decl_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_statement([NotNull] PostgreSqlParser.Decl_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scrollable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_scrollable([NotNull] PostgreSqlParser.Opt_scrollableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scrollable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_scrollable([NotNull] PostgreSqlParser.Opt_scrollableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_cursor_query([NotNull] PostgreSqlParser.Decl_cursor_queryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_cursor_query([NotNull] PostgreSqlParser.Decl_cursor_queryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_cursor_args([NotNull] PostgreSqlParser.Decl_cursor_argsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_args"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_cursor_args([NotNull] PostgreSqlParser.Decl_cursor_argsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arglist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_cursor_arglist([NotNull] PostgreSqlParser.Decl_cursor_arglistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arglist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_cursor_arglist([NotNull] PostgreSqlParser.Decl_cursor_arglistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_cursor_arg([NotNull] PostgreSqlParser.Decl_cursor_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_cursor_arg([NotNull] PostgreSqlParser.Decl_cursor_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_is_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_is_for([NotNull] PostgreSqlParser.Decl_is_forContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_is_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_is_for([NotNull] PostgreSqlParser.Decl_is_forContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_aliasitem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_aliasitem([NotNull] PostgreSqlParser.Decl_aliasitemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_aliasitem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_aliasitem([NotNull] PostgreSqlParser.Decl_aliasitemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_varname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_varname([NotNull] PostgreSqlParser.Decl_varnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_varname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_varname([NotNull] PostgreSqlParser.Decl_varnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_const"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_const([NotNull] PostgreSqlParser.Decl_constContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_const"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_const([NotNull] PostgreSqlParser.Decl_constContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_datatype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_datatype([NotNull] PostgreSqlParser.Decl_datatypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_datatype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_datatype([NotNull] PostgreSqlParser.Decl_datatypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_collate([NotNull] PostgreSqlParser.Decl_collateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_collate([NotNull] PostgreSqlParser.Decl_collateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_notnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_notnull([NotNull] PostgreSqlParser.Decl_notnullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_notnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_notnull([NotNull] PostgreSqlParser.Decl_notnullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_defval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_defval([NotNull] PostgreSqlParser.Decl_defvalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_defval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_defval([NotNull] PostgreSqlParser.Decl_defvalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_defkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecl_defkey([NotNull] PostgreSqlParser.Decl_defkeyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_defkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecl_defkey([NotNull] PostgreSqlParser.Decl_defkeyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.assign_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign_operator([NotNull] PostgreSqlParser.Assign_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.assign_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign_operator([NotNull] PostgreSqlParser.Assign_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_sect([NotNull] PostgreSqlParser.Proc_sectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_sect([NotNull] PostgreSqlParser.Proc_sectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_stmt([NotNull] PostgreSqlParser.Proc_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_stmt([NotNull] PostgreSqlParser.Proc_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_perform"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_perform([NotNull] PostgreSqlParser.Stmt_performContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_perform"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_perform([NotNull] PostgreSqlParser.Stmt_performContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_call([NotNull] PostgreSqlParser.Stmt_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_call([NotNull] PostgreSqlParser.Stmt_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_expr_list([NotNull] PostgreSqlParser.Opt_expr_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_expr_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_expr_list([NotNull] PostgreSqlParser.Opt_expr_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_assign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_assign([NotNull] PostgreSqlParser.Stmt_assignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_assign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_assign([NotNull] PostgreSqlParser.Stmt_assignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_getdiag"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_getdiag([NotNull] PostgreSqlParser.Stmt_getdiagContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_getdiag"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_getdiag([NotNull] PostgreSqlParser.Stmt_getdiagContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_area_opt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetdiag_area_opt([NotNull] PostgreSqlParser.Getdiag_area_optContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_area_opt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetdiag_area_opt([NotNull] PostgreSqlParser.Getdiag_area_optContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetdiag_list([NotNull] PostgreSqlParser.Getdiag_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetdiag_list([NotNull] PostgreSqlParser.Getdiag_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetdiag_list_item([NotNull] PostgreSqlParser.Getdiag_list_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetdiag_list_item([NotNull] PostgreSqlParser.Getdiag_list_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetdiag_item([NotNull] PostgreSqlParser.Getdiag_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetdiag_item([NotNull] PostgreSqlParser.Getdiag_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetdiag_target([NotNull] PostgreSqlParser.Getdiag_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetdiag_target([NotNull] PostgreSqlParser.Getdiag_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.assign_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssign_var([NotNull] PostgreSqlParser.Assign_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.assign_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssign_var([NotNull] PostgreSqlParser.Assign_varContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_if"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_if([NotNull] PostgreSqlParser.Stmt_ifContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_if"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_if([NotNull] PostgreSqlParser.Stmt_ifContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_elsifs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_elsifs([NotNull] PostgreSqlParser.Stmt_elsifsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_elsifs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_elsifs([NotNull] PostgreSqlParser.Stmt_elsifsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_else"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_else([NotNull] PostgreSqlParser.Stmt_elseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_else"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_else([NotNull] PostgreSqlParser.Stmt_elseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_case"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_case([NotNull] PostgreSqlParser.Stmt_caseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_case"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_case([NotNull] PostgreSqlParser.Stmt_caseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_expr_until_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_expr_until_when([NotNull] PostgreSqlParser.Opt_expr_until_whenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_expr_until_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_expr_until_when([NotNull] PostgreSqlParser.Opt_expr_until_whenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_when_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_when_list([NotNull] PostgreSqlParser.Case_when_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_when_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_when_list([NotNull] PostgreSqlParser.Case_when_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_when([NotNull] PostgreSqlParser.Case_whenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_when"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_when([NotNull] PostgreSqlParser.Case_whenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_case_else"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_case_else([NotNull] PostgreSqlParser.Opt_case_elseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_case_else"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_case_else([NotNull] PostgreSqlParser.Opt_case_elseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_loop([NotNull] PostgreSqlParser.Stmt_loopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_loop([NotNull] PostgreSqlParser.Stmt_loopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_while"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_while([NotNull] PostgreSqlParser.Stmt_whileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_while"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_while([NotNull] PostgreSqlParser.Stmt_whileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_for([NotNull] PostgreSqlParser.Stmt_forContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_for"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_for([NotNull] PostgreSqlParser.Stmt_forContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_control"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_control([NotNull] PostgreSqlParser.For_controlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_control"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_control([NotNull] PostgreSqlParser.For_controlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_for_using_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_for_using_expression([NotNull] PostgreSqlParser.Opt_for_using_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_for_using_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_for_using_expression([NotNull] PostgreSqlParser.Opt_for_using_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_cursor_parameters([NotNull] PostgreSqlParser.Opt_cursor_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_cursor_parameters([NotNull] PostgreSqlParser.Opt_cursor_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_reverse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_reverse([NotNull] PostgreSqlParser.Opt_reverseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_reverse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_reverse([NotNull] PostgreSqlParser.Opt_reverseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_by_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_by_expression([NotNull] PostgreSqlParser.Opt_by_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_by_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_by_expression([NotNull] PostgreSqlParser.Opt_by_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_variable([NotNull] PostgreSqlParser.For_variableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_variable([NotNull] PostgreSqlParser.For_variableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_foreach_a"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_foreach_a([NotNull] PostgreSqlParser.Stmt_foreach_aContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_foreach_a"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_foreach_a([NotNull] PostgreSqlParser.Stmt_foreach_aContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.foreach_slice"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeach_slice([NotNull] PostgreSqlParser.Foreach_sliceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.foreach_slice"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeach_slice([NotNull] PostgreSqlParser.Foreach_sliceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_exit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_exit([NotNull] PostgreSqlParser.Stmt_exitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_exit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_exit([NotNull] PostgreSqlParser.Stmt_exitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exit_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExit_type([NotNull] PostgreSqlParser.Exit_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exit_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExit_type([NotNull] PostgreSqlParser.Exit_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_return"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_return([NotNull] PostgreSqlParser.Stmt_returnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_return"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_return([NotNull] PostgreSqlParser.Stmt_returnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_return_result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_return_result([NotNull] PostgreSqlParser.Opt_return_resultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_return_result"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_return_result([NotNull] PostgreSqlParser.Opt_return_resultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_raise"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_raise([NotNull] PostgreSqlParser.Stmt_raiseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_raise"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_raise([NotNull] PostgreSqlParser.Stmt_raiseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_raise_level"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_stmt_raise_level([NotNull] PostgreSqlParser.Opt_stmt_raise_levelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_raise_level"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_stmt_raise_level([NotNull] PostgreSqlParser.Opt_stmt_raise_levelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_raise_list([NotNull] PostgreSqlParser.Opt_raise_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_raise_list([NotNull] PostgreSqlParser.Opt_raise_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_raise_using([NotNull] PostgreSqlParser.Opt_raise_usingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_raise_using([NotNull] PostgreSqlParser.Opt_raise_usingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_raise_using_elem([NotNull] PostgreSqlParser.Opt_raise_using_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_raise_using_elem([NotNull] PostgreSqlParser.Opt_raise_using_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_raise_using_elem_list([NotNull] PostgreSqlParser.Opt_raise_using_elem_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_raise_using_elem_list([NotNull] PostgreSqlParser.Opt_raise_using_elem_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_assert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_assert([NotNull] PostgreSqlParser.Stmt_assertContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_assert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_assert([NotNull] PostgreSqlParser.Stmt_assertContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_assert_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_stmt_assert_message([NotNull] PostgreSqlParser.Opt_stmt_assert_messageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_assert_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_stmt_assert_message([NotNull] PostgreSqlParser.Opt_stmt_assert_messageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.loop_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoop_body([NotNull] PostgreSqlParser.Loop_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.loop_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoop_body([NotNull] PostgreSqlParser.Loop_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_execsql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_execsql([NotNull] PostgreSqlParser.Stmt_execsqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_execsql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_execsql([NotNull] PostgreSqlParser.Stmt_execsqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_dynexecute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_dynexecute([NotNull] PostgreSqlParser.Stmt_dynexecuteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_dynexecute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_dynexecute([NotNull] PostgreSqlParser.Stmt_dynexecuteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_execute_using([NotNull] PostgreSqlParser.Opt_execute_usingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_execute_using([NotNull] PostgreSqlParser.Opt_execute_usingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_execute_using_list([NotNull] PostgreSqlParser.Opt_execute_using_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_execute_using_list([NotNull] PostgreSqlParser.Opt_execute_using_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_into"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_execute_into([NotNull] PostgreSqlParser.Opt_execute_intoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_into"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_execute_into([NotNull] PostgreSqlParser.Opt_execute_intoContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_open"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_open([NotNull] PostgreSqlParser.Stmt_openContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_open"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_open([NotNull] PostgreSqlParser.Stmt_openContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_open_bound_list_item([NotNull] PostgreSqlParser.Opt_open_bound_list_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_open_bound_list_item([NotNull] PostgreSqlParser.Opt_open_bound_list_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_open_bound_list([NotNull] PostgreSqlParser.Opt_open_bound_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_open_bound_list([NotNull] PostgreSqlParser.Opt_open_bound_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_open_using([NotNull] PostgreSqlParser.Opt_open_usingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_using"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_open_using([NotNull] PostgreSqlParser.Opt_open_usingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_scroll_option([NotNull] PostgreSqlParser.Opt_scroll_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_scroll_option([NotNull] PostgreSqlParser.Opt_scroll_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option_no"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_scroll_option_no([NotNull] PostgreSqlParser.Opt_scroll_option_noContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option_no"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_scroll_option_no([NotNull] PostgreSqlParser.Opt_scroll_option_noContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_fetch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_fetch([NotNull] PostgreSqlParser.Stmt_fetchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_fetch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_fetch([NotNull] PostgreSqlParser.Stmt_fetchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.into_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInto_target([NotNull] PostgreSqlParser.Into_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.into_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInto_target([NotNull] PostgreSqlParser.Into_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_cursor_from([NotNull] PostgreSqlParser.Opt_cursor_fromContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_cursor_from([NotNull] PostgreSqlParser.Opt_cursor_fromContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_fetch_direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_fetch_direction([NotNull] PostgreSqlParser.Opt_fetch_directionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_fetch_direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_fetch_direction([NotNull] PostgreSqlParser.Opt_fetch_directionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_move"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_move([NotNull] PostgreSqlParser.Stmt_moveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_move"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_move([NotNull] PostgreSqlParser.Stmt_moveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_close"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_close([NotNull] PostgreSqlParser.Stmt_closeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_close"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_close([NotNull] PostgreSqlParser.Stmt_closeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_null"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_null([NotNull] PostgreSqlParser.Stmt_nullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_null"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_null([NotNull] PostgreSqlParser.Stmt_nullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_commit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_commit([NotNull] PostgreSqlParser.Stmt_commitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_commit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_commit([NotNull] PostgreSqlParser.Stmt_commitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_rollback"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_rollback([NotNull] PostgreSqlParser.Stmt_rollbackContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_rollback"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_rollback([NotNull] PostgreSqlParser.Stmt_rollbackContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsql_opt_transaction_chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsql_opt_transaction_chain([NotNull] PostgreSqlParser.Plsql_opt_transaction_chainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsql_opt_transaction_chain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsql_opt_transaction_chain([NotNull] PostgreSqlParser.Plsql_opt_transaction_chainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStmt_set([NotNull] PostgreSqlParser.Stmt_setContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_set"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStmt_set([NotNull] PostgreSqlParser.Stmt_setContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_variable([NotNull] PostgreSqlParser.Cursor_variableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_variable([NotNull] PostgreSqlParser.Cursor_variableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exception_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_sect([NotNull] PostgreSqlParser.Exception_sectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exception_sect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_sect([NotNull] PostgreSqlParser.Exception_sectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_exceptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_exceptions([NotNull] PostgreSqlParser.Proc_exceptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_exceptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_exceptions([NotNull] PostgreSqlParser.Proc_exceptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_exception"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_exception([NotNull] PostgreSqlParser.Proc_exceptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_exception"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_exception([NotNull] PostgreSqlParser.Proc_exceptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_conditions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_conditions([NotNull] PostgreSqlParser.Proc_conditionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_conditions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_conditions([NotNull] PostgreSqlParser.Proc_conditionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_condition([NotNull] PostgreSqlParser.Proc_conditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_condition([NotNull] PostgreSqlParser.Proc_conditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_block_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_block_label([NotNull] PostgreSqlParser.Opt_block_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_block_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_block_label([NotNull] PostgreSqlParser.Opt_block_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_loop_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_loop_label([NotNull] PostgreSqlParser.Opt_loop_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_loop_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_loop_label([NotNull] PostgreSqlParser.Opt_loop_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_label([NotNull] PostgreSqlParser.Opt_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_label([NotNull] PostgreSqlParser.Opt_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_exitcond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_exitcond([NotNull] PostgreSqlParser.Opt_exitcondContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_exitcond"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_exitcond([NotNull] PostgreSqlParser.Opt_exitcondContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_identifier([NotNull] PostgreSqlParser.Any_identifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_identifier([NotNull] PostgreSqlParser.Any_identifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsql_unreserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlsql_unreserved_keyword([NotNull] PostgreSqlParser.Plsql_unreserved_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsql_unreserved_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlsql_unreserved_keyword([NotNull] PostgreSqlParser.Plsql_unreserved_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sql_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_expression([NotNull] PostgreSqlParser.Sql_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sql_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_expression([NotNull] PostgreSqlParser.Sql_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_then"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_until_then([NotNull] PostgreSqlParser.Expr_until_thenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_then"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_until_then([NotNull] PostgreSqlParser.Expr_until_thenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_until_semi([NotNull] PostgreSqlParser.Expr_until_semiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_until_semi([NotNull] PostgreSqlParser.Expr_until_semiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_rightbracket"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_until_rightbracket([NotNull] PostgreSqlParser.Expr_until_rightbracketContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_rightbracket"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_until_rightbracket([NotNull] PostgreSqlParser.Expr_until_rightbracketContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_until_loop([NotNull] PostgreSqlParser.Expr_until_loopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_until_loop([NotNull] PostgreSqlParser.Expr_until_loopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.make_execsql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMake_execsql_stmt([NotNull] PostgreSqlParser.Make_execsql_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.make_execsql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMake_execsql_stmt([NotNull] PostgreSqlParser.Make_execsql_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_returning_clause_into"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpt_returning_clause_into([NotNull] PostgreSqlParser.Opt_returning_clause_intoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_returning_clause_into"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpt_returning_clause_into([NotNull] PostgreSqlParser.Opt_returning_clause_intoContext context) { }

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
