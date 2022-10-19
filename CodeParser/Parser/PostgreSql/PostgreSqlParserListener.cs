using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PostgreSQLParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IPostgreSqlParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoot([NotNull] PostgreSqlParser.RootContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoot([NotNull] PostgreSqlParser.RootContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlroot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsqlroot([NotNull] PostgreSqlParser.PlsqlrootContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlroot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsqlroot([NotNull] PostgreSqlParser.PlsqlrootContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmtblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmtblock([NotNull] PostgreSqlParser.StmtblockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmtblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmtblock([NotNull] PostgreSqlParser.StmtblockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmtmulti"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmtmulti([NotNull] PostgreSqlParser.StmtmultiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmtmulti"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmtmulti([NotNull] PostgreSqlParser.StmtmultiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt([NotNull] PostgreSqlParser.StmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt([NotNull] PostgreSqlParser.StmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlconsolecommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsqlconsolecommand([NotNull] PostgreSqlParser.PlsqlconsolecommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlconsolecommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsqlconsolecommand([NotNull] PostgreSqlParser.PlsqlconsolecommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.callstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallstmt([NotNull] PostgreSqlParser.CallstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.callstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallstmt([NotNull] PostgreSqlParser.CallstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreaterolestmt([NotNull] PostgreSqlParser.CreaterolestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreaterolestmt([NotNull] PostgreSqlParser.CreaterolestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_with([NotNull] PostgreSqlParser.Opt_withContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_with([NotNull] PostgreSqlParser.Opt_withContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optrolelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptrolelist([NotNull] PostgreSqlParser.OptrolelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optrolelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptrolelist([NotNull] PostgreSqlParser.OptrolelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroptrolelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlteroptrolelist([NotNull] PostgreSqlParser.AlteroptrolelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroptrolelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlteroptrolelist([NotNull] PostgreSqlParser.AlteroptrolelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroptroleelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlteroptroleelem([NotNull] PostgreSqlParser.AlteroptroleelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroptroleelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlteroptroleelem([NotNull] PostgreSqlParser.AlteroptroleelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createoptroleelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateoptroleelem([NotNull] PostgreSqlParser.CreateoptroleelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createoptroleelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateoptroleelem([NotNull] PostgreSqlParser.CreateoptroleelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createuserstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateuserstmt([NotNull] PostgreSqlParser.CreateuserstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createuserstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateuserstmt([NotNull] PostgreSqlParser.CreateuserstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterrolestmt([NotNull] PostgreSqlParser.AlterrolestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterrolestmt([NotNull] PostgreSqlParser.AlterrolestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_in_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_in_database([NotNull] PostgreSqlParser.Opt_in_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_in_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_in_database([NotNull] PostgreSqlParser.Opt_in_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterrolesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterrolesetstmt([NotNull] PostgreSqlParser.AlterrolesetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterrolesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterrolesetstmt([NotNull] PostgreSqlParser.AlterrolesetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droprolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDroprolestmt([NotNull] PostgreSqlParser.DroprolestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droprolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDroprolestmt([NotNull] PostgreSqlParser.DroprolestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.creategroupstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreategroupstmt([NotNull] PostgreSqlParser.CreategroupstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.creategroupstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreategroupstmt([NotNull] PostgreSqlParser.CreategroupstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altergroupstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltergroupstmt([NotNull] PostgreSqlParser.AltergroupstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altergroupstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltergroupstmt([NotNull] PostgreSqlParser.AltergroupstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.add_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_drop([NotNull] PostgreSqlParser.Add_dropContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.add_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_drop([NotNull] PostgreSqlParser.Add_dropContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateschemastmt([NotNull] PostgreSqlParser.CreateschemastmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateschemastmt([NotNull] PostgreSqlParser.CreateschemastmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optschemaname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptschemaname([NotNull] PostgreSqlParser.OptschemanameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optschemaname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptschemaname([NotNull] PostgreSqlParser.OptschemanameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optschemaeltlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptschemaeltlist([NotNull] PostgreSqlParser.OptschemaeltlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optschemaeltlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptschemaeltlist([NotNull] PostgreSqlParser.OptschemaeltlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.schema_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_stmt([NotNull] PostgreSqlParser.Schema_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.schema_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_stmt([NotNull] PostgreSqlParser.Schema_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variablesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariablesetstmt([NotNull] PostgreSqlParser.VariablesetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variablesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariablesetstmt([NotNull] PostgreSqlParser.VariablesetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_rest([NotNull] PostgreSqlParser.Set_restContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_rest([NotNull] PostgreSqlParser.Set_restContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_set([NotNull] PostgreSqlParser.Generic_setContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_set([NotNull] PostgreSqlParser.Generic_setContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_rest_more"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_rest_more([NotNull] PostgreSqlParser.Set_rest_moreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_rest_more"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_rest_more([NotNull] PostgreSqlParser.Set_rest_moreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_name([NotNull] PostgreSqlParser.Var_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_name([NotNull] PostgreSqlParser.Var_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_list([NotNull] PostgreSqlParser.Var_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_list([NotNull] PostgreSqlParser.Var_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.var_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar_value([NotNull] PostgreSqlParser.Var_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.var_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar_value([NotNull] PostgreSqlParser.Var_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.iso_level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIso_level([NotNull] PostgreSqlParser.Iso_levelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.iso_level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIso_level([NotNull] PostgreSqlParser.Iso_levelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_boolean_or_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_boolean_or_string([NotNull] PostgreSqlParser.Opt_boolean_or_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_boolean_or_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_boolean_or_string([NotNull] PostgreSqlParser.Opt_boolean_or_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.zone_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterZone_value([NotNull] PostgreSqlParser.Zone_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.zone_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitZone_value([NotNull] PostgreSqlParser.Zone_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_encoding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_encoding([NotNull] PostgreSqlParser.Opt_encodingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_encoding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_encoding([NotNull] PostgreSqlParser.Opt_encodingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.nonreservedword_or_sconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNonreservedword_or_sconst([NotNull] PostgreSqlParser.Nonreservedword_or_sconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.nonreservedword_or_sconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNonreservedword_or_sconst([NotNull] PostgreSqlParser.Nonreservedword_or_sconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variableresetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableresetstmt([NotNull] PostgreSqlParser.VariableresetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variableresetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableresetstmt([NotNull] PostgreSqlParser.VariableresetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reset_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReset_rest([NotNull] PostgreSqlParser.Reset_restContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reset_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReset_rest([NotNull] PostgreSqlParser.Reset_restContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_reset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_reset([NotNull] PostgreSqlParser.Generic_resetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_reset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_reset([NotNull] PostgreSqlParser.Generic_resetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.setresetclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetresetclause([NotNull] PostgreSqlParser.SetresetclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.setresetclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetresetclause([NotNull] PostgreSqlParser.SetresetclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.functionsetresetclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionsetresetclause([NotNull] PostgreSqlParser.FunctionsetresetclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.functionsetresetclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionsetresetclause([NotNull] PostgreSqlParser.FunctionsetresetclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.variableshowstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableshowstmt([NotNull] PostgreSqlParser.VariableshowstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.variableshowstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableshowstmt([NotNull] PostgreSqlParser.VariableshowstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintssetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintssetstmt([NotNull] PostgreSqlParser.ConstraintssetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintssetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintssetstmt([NotNull] PostgreSqlParser.ConstraintssetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraints_set_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraints_set_list([NotNull] PostgreSqlParser.Constraints_set_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraints_set_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraints_set_list([NotNull] PostgreSqlParser.Constraints_set_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraints_set_mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraints_set_mode([NotNull] PostgreSqlParser.Constraints_set_modeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraints_set_mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraints_set_mode([NotNull] PostgreSqlParser.Constraints_set_modeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.checkpointstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckpointstmt([NotNull] PostgreSqlParser.CheckpointstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.checkpointstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckpointstmt([NotNull] PostgreSqlParser.CheckpointstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.discardstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiscardstmt([NotNull] PostgreSqlParser.DiscardstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.discardstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiscardstmt([NotNull] PostgreSqlParser.DiscardstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltertablestmt([NotNull] PostgreSqlParser.AltertablestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltertablestmt([NotNull] PostgreSqlParser.AltertablestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_cmds([NotNull] PostgreSqlParser.Alter_table_cmdsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_cmds([NotNull] PostgreSqlParser.Alter_table_cmdsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partition_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_cmd([NotNull] PostgreSqlParser.Partition_cmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partition_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_cmd([NotNull] PostgreSqlParser.Partition_cmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_partition_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_partition_cmd([NotNull] PostgreSqlParser.Index_partition_cmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_partition_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_partition_cmd([NotNull] PostgreSqlParser.Index_partition_cmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_cmd([NotNull] PostgreSqlParser.Alter_table_cmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_table_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_cmd([NotNull] PostgreSqlParser.Alter_table_cmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_column_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_column_default([NotNull] PostgreSqlParser.Alter_column_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_column_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_column_default([NotNull] PostgreSqlParser.Alter_column_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_drop_behavior"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_drop_behavior([NotNull] PostgreSqlParser.Opt_drop_behaviorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_drop_behavior"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_drop_behavior([NotNull] PostgreSqlParser.Opt_drop_behaviorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_collate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_collate_clause([NotNull] PostgreSqlParser.Opt_collate_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_collate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_collate_clause([NotNull] PostgreSqlParser.Opt_collate_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_using([NotNull] PostgreSqlParser.Alter_usingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_using([NotNull] PostgreSqlParser.Alter_usingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.replica_identity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplica_identity([NotNull] PostgreSqlParser.Replica_identityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.replica_identity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplica_identity([NotNull] PostgreSqlParser.Replica_identityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReloptions([NotNull] PostgreSqlParser.ReloptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReloptions([NotNull] PostgreSqlParser.ReloptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_reloptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_reloptions([NotNull] PostgreSqlParser.Opt_reloptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_reloptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_reloptions([NotNull] PostgreSqlParser.Opt_reloptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloption_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReloption_list([NotNull] PostgreSqlParser.Reloption_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloption_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReloption_list([NotNull] PostgreSqlParser.Reloption_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reloption_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReloption_elem([NotNull] PostgreSqlParser.Reloption_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reloption_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReloption_elem([NotNull] PostgreSqlParser.Reloption_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_identity_column_option_list([NotNull] PostgreSqlParser.Alter_identity_column_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_identity_column_option_list([NotNull] PostgreSqlParser.Alter_identity_column_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_identity_column_option([NotNull] PostgreSqlParser.Alter_identity_column_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_identity_column_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_identity_column_option([NotNull] PostgreSqlParser.Alter_identity_column_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partitionboundspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionboundspec([NotNull] PostgreSqlParser.PartitionboundspecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partitionboundspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionboundspec([NotNull] PostgreSqlParser.PartitionboundspecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.hash_partbound_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_partbound_elem([NotNull] PostgreSqlParser.Hash_partbound_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.hash_partbound_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_partbound_elem([NotNull] PostgreSqlParser.Hash_partbound_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.hash_partbound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_partbound([NotNull] PostgreSqlParser.Hash_partboundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.hash_partbound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_partbound([NotNull] PostgreSqlParser.Hash_partboundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altercompositetypestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltercompositetypestmt([NotNull] PostgreSqlParser.AltercompositetypestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altercompositetypestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltercompositetypestmt([NotNull] PostgreSqlParser.AltercompositetypestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_type_cmds([NotNull] PostgreSqlParser.Alter_type_cmdsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_type_cmds([NotNull] PostgreSqlParser.Alter_type_cmdsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_type_cmd([NotNull] PostgreSqlParser.Alter_type_cmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_type_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_type_cmd([NotNull] PostgreSqlParser.Alter_type_cmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.closeportalstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCloseportalstmt([NotNull] PostgreSqlParser.CloseportalstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.closeportalstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCloseportalstmt([NotNull] PostgreSqlParser.CloseportalstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopystmt([NotNull] PostgreSqlParser.CopystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopystmt([NotNull] PostgreSqlParser.CopystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_from([NotNull] PostgreSqlParser.Copy_fromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_from([NotNull] PostgreSqlParser.Copy_fromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_program([NotNull] PostgreSqlParser.Opt_programContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_program([NotNull] PostgreSqlParser.Opt_programContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_file_name([NotNull] PostgreSqlParser.Copy_file_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_file_name([NotNull] PostgreSqlParser.Copy_file_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_options([NotNull] PostgreSqlParser.Copy_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_options([NotNull] PostgreSqlParser.Copy_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_opt_list([NotNull] PostgreSqlParser.Copy_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_opt_list([NotNull] PostgreSqlParser.Copy_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_opt_item([NotNull] PostgreSqlParser.Copy_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_opt_item([NotNull] PostgreSqlParser.Copy_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_binary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_binary([NotNull] PostgreSqlParser.Opt_binaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_binary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_binary([NotNull] PostgreSqlParser.Opt_binaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_delimiter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_delimiter([NotNull] PostgreSqlParser.Copy_delimiterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_delimiter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_delimiter([NotNull] PostgreSqlParser.Copy_delimiterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_using([NotNull] PostgreSqlParser.Opt_usingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_using([NotNull] PostgreSqlParser.Opt_usingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_generic_opt_list([NotNull] PostgreSqlParser.Copy_generic_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_generic_opt_list([NotNull] PostgreSqlParser.Copy_generic_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_generic_opt_elem([NotNull] PostgreSqlParser.Copy_generic_opt_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_generic_opt_elem([NotNull] PostgreSqlParser.Copy_generic_opt_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_generic_opt_arg([NotNull] PostgreSqlParser.Copy_generic_opt_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_generic_opt_arg([NotNull] PostgreSqlParser.Copy_generic_opt_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_generic_opt_arg_list([NotNull] PostgreSqlParser.Copy_generic_opt_arg_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_generic_opt_arg_list([NotNull] PostgreSqlParser.Copy_generic_opt_arg_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCopy_generic_opt_arg_list_item([NotNull] PostgreSqlParser.Copy_generic_opt_arg_list_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.copy_generic_opt_arg_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCopy_generic_opt_arg_list_item([NotNull] PostgreSqlParser.Copy_generic_opt_arg_list_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatestmt([NotNull] PostgreSqlParser.CreatestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatestmt([NotNull] PostgreSqlParser.CreatestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttemp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttemp([NotNull] PostgreSqlParser.OpttempContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttemp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttemp([NotNull] PostgreSqlParser.OpttempContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttableelementlist([NotNull] PostgreSqlParser.OpttableelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttableelementlist([NotNull] PostgreSqlParser.OpttableelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttypedtableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttypedtableelementlist([NotNull] PostgreSqlParser.OpttypedtableelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttypedtableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttypedtableelementlist([NotNull] PostgreSqlParser.OpttypedtableelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableelementlist([NotNull] PostgreSqlParser.TableelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableelementlist([NotNull] PostgreSqlParser.TableelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typedtableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypedtableelementlist([NotNull] PostgreSqlParser.TypedtableelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typedtableelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypedtableelementlist([NotNull] PostgreSqlParser.TypedtableelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableelement([NotNull] PostgreSqlParser.TableelementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableelement([NotNull] PostgreSqlParser.TableelementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typedtableelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypedtableelement([NotNull] PostgreSqlParser.TypedtableelementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typedtableelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypedtableelement([NotNull] PostgreSqlParser.TypedtableelementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnDef([NotNull] PostgreSqlParser.ColumnDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnDef([NotNull] PostgreSqlParser.ColumnDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnOptions([NotNull] PostgreSqlParser.ColumnOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnOptions([NotNull] PostgreSqlParser.ColumnOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colquallist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColquallist([NotNull] PostgreSqlParser.ColquallistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colquallist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColquallist([NotNull] PostgreSqlParser.ColquallistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colconstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColconstraint([NotNull] PostgreSqlParser.ColconstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colconstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColconstraint([NotNull] PostgreSqlParser.ColconstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colconstraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColconstraintelem([NotNull] PostgreSqlParser.ColconstraintelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colconstraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColconstraintelem([NotNull] PostgreSqlParser.ColconstraintelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generated_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenerated_when([NotNull] PostgreSqlParser.Generated_whenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generated_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenerated_when([NotNull] PostgreSqlParser.Generated_whenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintattr([NotNull] PostgreSqlParser.ConstraintattrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintattr([NotNull] PostgreSqlParser.ConstraintattrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablelikeclause([NotNull] PostgreSqlParser.TablelikeclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablelikeclause([NotNull] PostgreSqlParser.TablelikeclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeoptionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablelikeoptionlist([NotNull] PostgreSqlParser.TablelikeoptionlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeoptionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablelikeoptionlist([NotNull] PostgreSqlParser.TablelikeoptionlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablelikeoption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablelikeoption([NotNull] PostgreSqlParser.TablelikeoptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablelikeoption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablelikeoption([NotNull] PostgreSqlParser.TablelikeoptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tableconstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableconstraint([NotNull] PostgreSqlParser.TableconstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tableconstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableconstraint([NotNull] PostgreSqlParser.TableconstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintelem([NotNull] PostgreSqlParser.ConstraintelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintelem([NotNull] PostgreSqlParser.ConstraintelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_no_inherit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_no_inherit([NotNull] PostgreSqlParser.Opt_no_inheritContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_no_inherit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_no_inherit([NotNull] PostgreSqlParser.Opt_no_inheritContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_column_list([NotNull] PostgreSqlParser.Opt_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_column_list([NotNull] PostgreSqlParser.Opt_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnlist([NotNull] PostgreSqlParser.ColumnlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnlist([NotNull] PostgreSqlParser.ColumnlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnElem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnElem([NotNull] PostgreSqlParser.ColumnElemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnElem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnElem([NotNull] PostgreSqlParser.ColumnElemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_c_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_c_include([NotNull] PostgreSqlParser.Opt_c_includeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_c_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_c_include([NotNull] PostgreSqlParser.Opt_c_includeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_match"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_match([NotNull] PostgreSqlParser.Key_matchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_match"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_match([NotNull] PostgreSqlParser.Key_matchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusionconstraintlist([NotNull] PostgreSqlParser.ExclusionconstraintlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusionconstraintlist([NotNull] PostgreSqlParser.ExclusionconstraintlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusionconstraintelem([NotNull] PostgreSqlParser.ExclusionconstraintelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionconstraintelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusionconstraintelem([NotNull] PostgreSqlParser.ExclusionconstraintelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exclusionwhereclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusionwhereclause([NotNull] PostgreSqlParser.ExclusionwhereclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exclusionwhereclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusionwhereclause([NotNull] PostgreSqlParser.ExclusionwhereclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_actions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_actions([NotNull] PostgreSqlParser.Key_actionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_actions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_actions([NotNull] PostgreSqlParser.Key_actionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_update"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_update([NotNull] PostgreSqlParser.Key_updateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_update"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_update([NotNull] PostgreSqlParser.Key_updateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_delete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_delete([NotNull] PostgreSqlParser.Key_deleteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_delete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_delete([NotNull] PostgreSqlParser.Key_deleteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.key_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_action([NotNull] PostgreSqlParser.Key_actionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.key_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_action([NotNull] PostgreSqlParser.Key_actionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optinherit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptinherit([NotNull] PostgreSqlParser.OptinheritContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optinherit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptinherit([NotNull] PostgreSqlParser.OptinheritContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optpartitionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptpartitionspec([NotNull] PostgreSqlParser.OptpartitionspecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optpartitionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptpartitionspec([NotNull] PostgreSqlParser.OptpartitionspecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.partitionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionspec([NotNull] PostgreSqlParser.PartitionspecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.partitionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionspec([NotNull] PostgreSqlParser.PartitionspecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.part_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPart_params([NotNull] PostgreSqlParser.Part_paramsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.part_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPart_params([NotNull] PostgreSqlParser.Part_paramsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.part_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPart_elem([NotNull] PostgreSqlParser.Part_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.part_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPart_elem([NotNull] PostgreSqlParser.Part_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_access_method_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_access_method_clause([NotNull] PostgreSqlParser.Table_access_method_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_access_method_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_access_method_clause([NotNull] PostgreSqlParser.Table_access_method_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optwith"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptwith([NotNull] PostgreSqlParser.OptwithContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optwith"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptwith([NotNull] PostgreSqlParser.OptwithContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.oncommitoption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOncommitoption([NotNull] PostgreSqlParser.OncommitoptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.oncommitoption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOncommitoption([NotNull] PostgreSqlParser.OncommitoptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttablespace([NotNull] PostgreSqlParser.OpttablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttablespace([NotNull] PostgreSqlParser.OpttablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optconstablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptconstablespace([NotNull] PostgreSqlParser.OptconstablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optconstablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptconstablespace([NotNull] PostgreSqlParser.OptconstablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.existingindex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExistingindex([NotNull] PostgreSqlParser.ExistingindexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.existingindex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExistingindex([NotNull] PostgreSqlParser.ExistingindexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createstatsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatestatsstmt([NotNull] PostgreSqlParser.CreatestatsstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createstatsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatestatsstmt([NotNull] PostgreSqlParser.CreatestatsstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterstatsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterstatsstmt([NotNull] PostgreSqlParser.AlterstatsstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterstatsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterstatsstmt([NotNull] PostgreSqlParser.AlterstatsstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createasstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateasstmt([NotNull] PostgreSqlParser.CreateasstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createasstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateasstmt([NotNull] PostgreSqlParser.CreateasstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_as_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_as_target([NotNull] PostgreSqlParser.Create_as_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_as_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_as_target([NotNull] PostgreSqlParser.Create_as_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_with_data([NotNull] PostgreSqlParser.Opt_with_dataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_with_data([NotNull] PostgreSqlParser.Opt_with_dataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.creatematviewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatematviewstmt([NotNull] PostgreSqlParser.CreatematviewstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.creatematviewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatematviewstmt([NotNull] PostgreSqlParser.CreatematviewstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_mv_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_mv_target([NotNull] PostgreSqlParser.Create_mv_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_mv_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_mv_target([NotNull] PostgreSqlParser.Create_mv_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optnolog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptnolog([NotNull] PostgreSqlParser.OptnologContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optnolog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptnolog([NotNull] PostgreSqlParser.OptnologContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.refreshmatviewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRefreshmatviewstmt([NotNull] PostgreSqlParser.RefreshmatviewstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.refreshmatviewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRefreshmatviewstmt([NotNull] PostgreSqlParser.RefreshmatviewstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createseqstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateseqstmt([NotNull] PostgreSqlParser.CreateseqstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createseqstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateseqstmt([NotNull] PostgreSqlParser.CreateseqstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterseqstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterseqstmt([NotNull] PostgreSqlParser.AlterseqstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterseqstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterseqstmt([NotNull] PostgreSqlParser.AlterseqstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optseqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptseqoptlist([NotNull] PostgreSqlParser.OptseqoptlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optseqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptseqoptlist([NotNull] PostgreSqlParser.OptseqoptlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optparenthesizedseqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptparenthesizedseqoptlist([NotNull] PostgreSqlParser.OptparenthesizedseqoptlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optparenthesizedseqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptparenthesizedseqoptlist([NotNull] PostgreSqlParser.OptparenthesizedseqoptlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeqoptlist([NotNull] PostgreSqlParser.SeqoptlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seqoptlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeqoptlist([NotNull] PostgreSqlParser.SeqoptlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seqoptelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeqoptelem([NotNull] PostgreSqlParser.SeqoptelemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seqoptelem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeqoptelem([NotNull] PostgreSqlParser.SeqoptelemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_by([NotNull] PostgreSqlParser.Opt_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_by([NotNull] PostgreSqlParser.Opt_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numericonly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericonly([NotNull] PostgreSqlParser.NumericonlyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numericonly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericonly([NotNull] PostgreSqlParser.NumericonlyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numericonly_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumericonly_list([NotNull] PostgreSqlParser.Numericonly_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numericonly_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumericonly_list([NotNull] PostgreSqlParser.Numericonly_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createplangstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateplangstmt([NotNull] PostgreSqlParser.CreateplangstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createplangstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateplangstmt([NotNull] PostgreSqlParser.CreateplangstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_trusted"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_trusted([NotNull] PostgreSqlParser.Opt_trustedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_trusted"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_trusted([NotNull] PostgreSqlParser.Opt_trustedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.handler_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandler_name([NotNull] PostgreSqlParser.Handler_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.handler_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandler_name([NotNull] PostgreSqlParser.Handler_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_inline_handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_inline_handler([NotNull] PostgreSqlParser.Opt_inline_handlerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_inline_handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_inline_handler([NotNull] PostgreSqlParser.Opt_inline_handlerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.validator_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValidator_clause([NotNull] PostgreSqlParser.Validator_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.validator_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValidator_clause([NotNull] PostgreSqlParser.Validator_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_validator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_validator([NotNull] PostgreSqlParser.Opt_validatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_validator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_validator([NotNull] PostgreSqlParser.Opt_validatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_procedural"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_procedural([NotNull] PostgreSqlParser.Opt_proceduralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_procedural"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_procedural([NotNull] PostgreSqlParser.Opt_proceduralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtablespacestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatetablespacestmt([NotNull] PostgreSqlParser.CreatetablespacestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtablespacestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatetablespacestmt([NotNull] PostgreSqlParser.CreatetablespacestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablespaceowner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttablespaceowner([NotNull] PostgreSqlParser.OpttablespaceownerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablespaceowner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttablespaceowner([NotNull] PostgreSqlParser.OpttablespaceownerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droptablespacestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDroptablespacestmt([NotNull] PostgreSqlParser.DroptablespacestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droptablespacestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDroptablespacestmt([NotNull] PostgreSqlParser.DroptablespacestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createextensionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateextensionstmt([NotNull] PostgreSqlParser.CreateextensionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createextensionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateextensionstmt([NotNull] PostgreSqlParser.CreateextensionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_extension_opt_list([NotNull] PostgreSqlParser.Create_extension_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_extension_opt_list([NotNull] PostgreSqlParser.Create_extension_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_extension_opt_item([NotNull] PostgreSqlParser.Create_extension_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_extension_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_extension_opt_item([NotNull] PostgreSqlParser.Create_extension_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterextensionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterextensionstmt([NotNull] PostgreSqlParser.AlterextensionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterextensionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterextensionstmt([NotNull] PostgreSqlParser.AlterextensionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_extension_opt_list([NotNull] PostgreSqlParser.Alter_extension_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_extension_opt_list([NotNull] PostgreSqlParser.Alter_extension_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_extension_opt_item([NotNull] PostgreSqlParser.Alter_extension_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_extension_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_extension_opt_item([NotNull] PostgreSqlParser.Alter_extension_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterextensioncontentsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterextensioncontentsstmt([NotNull] PostgreSqlParser.AlterextensioncontentsstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterextensioncontentsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterextensioncontentsstmt([NotNull] PostgreSqlParser.AlterextensioncontentsstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfdwstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatefdwstmt([NotNull] PostgreSqlParser.CreatefdwstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfdwstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatefdwstmt([NotNull] PostgreSqlParser.CreatefdwstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fdw_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFdw_option([NotNull] PostgreSqlParser.Fdw_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fdw_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFdw_option([NotNull] PostgreSqlParser.Fdw_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fdw_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFdw_options([NotNull] PostgreSqlParser.Fdw_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fdw_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFdw_options([NotNull] PostgreSqlParser.Fdw_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_fdw_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_fdw_options([NotNull] PostgreSqlParser.Opt_fdw_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_fdw_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_fdw_options([NotNull] PostgreSqlParser.Opt_fdw_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfdwstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterfdwstmt([NotNull] PostgreSqlParser.AlterfdwstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfdwstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterfdwstmt([NotNull] PostgreSqlParser.AlterfdwstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.create_generic_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_generic_options([NotNull] PostgreSqlParser.Create_generic_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.create_generic_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_generic_options([NotNull] PostgreSqlParser.Create_generic_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_option_list([NotNull] PostgreSqlParser.Generic_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_option_list([NotNull] PostgreSqlParser.Generic_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_generic_options([NotNull] PostgreSqlParser.Alter_generic_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_generic_options([NotNull] PostgreSqlParser.Alter_generic_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_generic_option_list([NotNull] PostgreSqlParser.Alter_generic_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_generic_option_list([NotNull] PostgreSqlParser.Alter_generic_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_generic_option_elem([NotNull] PostgreSqlParser.Alter_generic_option_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alter_generic_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_generic_option_elem([NotNull] PostgreSqlParser.Alter_generic_option_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_option_elem([NotNull] PostgreSqlParser.Generic_option_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_option_elem([NotNull] PostgreSqlParser.Generic_option_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_option_name([NotNull] PostgreSqlParser.Generic_option_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_option_name([NotNull] PostgreSqlParser.Generic_option_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generic_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_option_arg([NotNull] PostgreSqlParser.Generic_option_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generic_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_option_arg([NotNull] PostgreSqlParser.Generic_option_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createforeignserverstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateforeignserverstmt([NotNull] PostgreSqlParser.CreateforeignserverstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createforeignserverstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateforeignserverstmt([NotNull] PostgreSqlParser.CreateforeignserverstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_type([NotNull] PostgreSqlParser.Opt_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_type([NotNull] PostgreSqlParser.Opt_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.foreign_server_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_server_version([NotNull] PostgreSqlParser.Foreign_server_versionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.foreign_server_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_server_version([NotNull] PostgreSqlParser.Foreign_server_versionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_foreign_server_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_foreign_server_version([NotNull] PostgreSqlParser.Opt_foreign_server_versionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_foreign_server_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_foreign_server_version([NotNull] PostgreSqlParser.Opt_foreign_server_versionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterforeignserverstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterforeignserverstmt([NotNull] PostgreSqlParser.AlterforeignserverstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterforeignserverstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterforeignserverstmt([NotNull] PostgreSqlParser.AlterforeignserverstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createforeigntablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateforeigntablestmt([NotNull] PostgreSqlParser.CreateforeigntablestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createforeigntablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateforeigntablestmt([NotNull] PostgreSqlParser.CreateforeigntablestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.importforeignschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportforeignschemastmt([NotNull] PostgreSqlParser.ImportforeignschemastmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.importforeignschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportforeignschemastmt([NotNull] PostgreSqlParser.ImportforeignschemastmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.import_qualification_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImport_qualification_type([NotNull] PostgreSqlParser.Import_qualification_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.import_qualification_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImport_qualification_type([NotNull] PostgreSqlParser.Import_qualification_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.import_qualification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImport_qualification([NotNull] PostgreSqlParser.Import_qualificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.import_qualification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImport_qualification([NotNull] PostgreSqlParser.Import_qualificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateusermappingstmt([NotNull] PostgreSqlParser.CreateusermappingstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateusermappingstmt([NotNull] PostgreSqlParser.CreateusermappingstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.auth_ident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuth_ident([NotNull] PostgreSqlParser.Auth_identContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.auth_ident"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuth_ident([NotNull] PostgreSqlParser.Auth_identContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropusermappingstmt([NotNull] PostgreSqlParser.DropusermappingstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropusermappingstmt([NotNull] PostgreSqlParser.DropusermappingstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterusermappingstmt([NotNull] PostgreSqlParser.AlterusermappingstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterusermappingstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterusermappingstmt([NotNull] PostgreSqlParser.AlterusermappingstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createpolicystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatepolicystmt([NotNull] PostgreSqlParser.CreatepolicystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createpolicystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatepolicystmt([NotNull] PostgreSqlParser.CreatepolicystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterpolicystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterpolicystmt([NotNull] PostgreSqlParser.AlterpolicystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterpolicystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterpolicystmt([NotNull] PostgreSqlParser.AlterpolicystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecurityoptionalexpr([NotNull] PostgreSqlParser.RowsecurityoptionalexprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecurityoptionalexpr([NotNull] PostgreSqlParser.RowsecurityoptionalexprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalwithcheck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecurityoptionalwithcheck([NotNull] PostgreSqlParser.RowsecurityoptionalwithcheckContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionalwithcheck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecurityoptionalwithcheck([NotNull] PostgreSqlParser.RowsecurityoptionalwithcheckContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaulttorole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecuritydefaulttorole([NotNull] PostgreSqlParser.RowsecuritydefaulttoroleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaulttorole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecuritydefaulttorole([NotNull] PostgreSqlParser.RowsecuritydefaulttoroleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionaltorole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecurityoptionaltorole([NotNull] PostgreSqlParser.RowsecurityoptionaltoroleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecurityoptionaltorole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecurityoptionaltorole([NotNull] PostgreSqlParser.RowsecurityoptionaltoroleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultpermissive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecuritydefaultpermissive([NotNull] PostgreSqlParser.RowsecuritydefaultpermissiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultpermissive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecuritydefaultpermissive([NotNull] PostgreSqlParser.RowsecuritydefaultpermissiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultforcmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsecuritydefaultforcmd([NotNull] PostgreSqlParser.RowsecuritydefaultforcmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsecuritydefaultforcmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsecuritydefaultforcmd([NotNull] PostgreSqlParser.RowsecuritydefaultforcmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row_security_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow_security_cmd([NotNull] PostgreSqlParser.Row_security_cmdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row_security_cmd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow_security_cmd([NotNull] PostgreSqlParser.Row_security_cmdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createamstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateamstmt([NotNull] PostgreSqlParser.CreateamstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createamstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateamstmt([NotNull] PostgreSqlParser.CreateamstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.am_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAm_type([NotNull] PostgreSqlParser.Am_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.am_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAm_type([NotNull] PostgreSqlParser.Am_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatetrigstmt([NotNull] PostgreSqlParser.CreatetrigstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatetrigstmt([NotNull] PostgreSqlParser.CreatetrigstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggeractiontime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggeractiontime([NotNull] PostgreSqlParser.TriggeractiontimeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggeractiontime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggeractiontime([NotNull] PostgreSqlParser.TriggeractiontimeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerevents"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerevents([NotNull] PostgreSqlParser.TriggereventsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerevents"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerevents([NotNull] PostgreSqlParser.TriggereventsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggeroneevent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggeroneevent([NotNull] PostgreSqlParser.TriggeroneeventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggeroneevent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggeroneevent([NotNull] PostgreSqlParser.TriggeroneeventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerreferencing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerreferencing([NotNull] PostgreSqlParser.TriggerreferencingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerreferencing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerreferencing([NotNull] PostgreSqlParser.TriggerreferencingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggertransitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggertransitions([NotNull] PostgreSqlParser.TriggertransitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggertransitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggertransitions([NotNull] PostgreSqlParser.TriggertransitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggertransition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggertransition([NotNull] PostgreSqlParser.TriggertransitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggertransition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggertransition([NotNull] PostgreSqlParser.TriggertransitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionoldornew"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransitionoldornew([NotNull] PostgreSqlParser.TransitionoldornewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionoldornew"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransitionoldornew([NotNull] PostgreSqlParser.TransitionoldornewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionrowortable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransitionrowortable([NotNull] PostgreSqlParser.TransitionrowortableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionrowortable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransitionrowortable([NotNull] PostgreSqlParser.TransitionrowortableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transitionrelname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransitionrelname([NotNull] PostgreSqlParser.TransitionrelnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transitionrelname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransitionrelname([NotNull] PostgreSqlParser.TransitionrelnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerforspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerforspec([NotNull] PostgreSqlParser.TriggerforspecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerforspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerforspec([NotNull] PostgreSqlParser.TriggerforspecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerforopteach"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerforopteach([NotNull] PostgreSqlParser.TriggerforopteachContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerforopteach"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerforopteach([NotNull] PostgreSqlParser.TriggerforopteachContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfortype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerfortype([NotNull] PostgreSqlParser.TriggerfortypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfortype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerfortype([NotNull] PostgreSqlParser.TriggerfortypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerwhen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerwhen([NotNull] PostgreSqlParser.TriggerwhenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerwhen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerwhen([NotNull] PostgreSqlParser.TriggerwhenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_or_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_or_procedure([NotNull] PostgreSqlParser.Function_or_procedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_or_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_or_procedure([NotNull] PostgreSqlParser.Function_or_procedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfuncargs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerfuncargs([NotNull] PostgreSqlParser.TriggerfuncargsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfuncargs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerfuncargs([NotNull] PostgreSqlParser.TriggerfuncargsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.triggerfuncarg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerfuncarg([NotNull] PostgreSqlParser.TriggerfuncargContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.triggerfuncarg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerfuncarg([NotNull] PostgreSqlParser.TriggerfuncargContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.optconstrfromtable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptconstrfromtable([NotNull] PostgreSqlParser.OptconstrfromtableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.optconstrfromtable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptconstrfromtable([NotNull] PostgreSqlParser.OptconstrfromtableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattributespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintattributespec([NotNull] PostgreSqlParser.ConstraintattributespecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattributespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintattributespec([NotNull] PostgreSqlParser.ConstraintattributespecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constraintattributeElem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintattributeElem([NotNull] PostgreSqlParser.ConstraintattributeElemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constraintattributeElem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintattributeElem([NotNull] PostgreSqlParser.ConstraintattributeElemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createeventtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateeventtrigstmt([NotNull] PostgreSqlParser.CreateeventtrigstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createeventtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateeventtrigstmt([NotNull] PostgreSqlParser.CreateeventtrigstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_trigger_when_list([NotNull] PostgreSqlParser.Event_trigger_when_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_trigger_when_list([NotNull] PostgreSqlParser.Event_trigger_when_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_trigger_when_item([NotNull] PostgreSqlParser.Event_trigger_when_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_when_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_trigger_when_item([NotNull] PostgreSqlParser.Event_trigger_when_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event_trigger_value_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_trigger_value_list([NotNull] PostgreSqlParser.Event_trigger_value_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event_trigger_value_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_trigger_value_list([NotNull] PostgreSqlParser.Event_trigger_value_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altereventtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltereventtrigstmt([NotNull] PostgreSqlParser.AltereventtrigstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altereventtrigstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltereventtrigstmt([NotNull] PostgreSqlParser.AltereventtrigstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.enable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnable_trigger([NotNull] PostgreSqlParser.Enable_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.enable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnable_trigger([NotNull] PostgreSqlParser.Enable_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createassertionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateassertionstmt([NotNull] PostgreSqlParser.CreateassertionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createassertionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateassertionstmt([NotNull] PostgreSqlParser.CreateassertionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.definestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefinestmt([NotNull] PostgreSqlParser.DefinestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.definestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefinestmt([NotNull] PostgreSqlParser.DefinestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefinition([NotNull] PostgreSqlParser.DefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefinition([NotNull] PostgreSqlParser.DefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDef_list([NotNull] PostgreSqlParser.Def_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDef_list([NotNull] PostgreSqlParser.Def_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDef_elem([NotNull] PostgreSqlParser.Def_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDef_elem([NotNull] PostgreSqlParser.Def_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.def_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDef_arg([NotNull] PostgreSqlParser.Def_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.def_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDef_arg([NotNull] PostgreSqlParser.Def_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOld_aggr_definition([NotNull] PostgreSqlParser.Old_aggr_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOld_aggr_definition([NotNull] PostgreSqlParser.Old_aggr_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOld_aggr_list([NotNull] PostgreSqlParser.Old_aggr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOld_aggr_list([NotNull] PostgreSqlParser.Old_aggr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.old_aggr_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOld_aggr_elem([NotNull] PostgreSqlParser.Old_aggr_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.old_aggr_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOld_aggr_elem([NotNull] PostgreSqlParser.Old_aggr_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_enum_val_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_enum_val_list([NotNull] PostgreSqlParser.Opt_enum_val_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_enum_val_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_enum_val_list([NotNull] PostgreSqlParser.Opt_enum_val_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.enum_val_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_val_list([NotNull] PostgreSqlParser.Enum_val_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.enum_val_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_val_list([NotNull] PostgreSqlParser.Enum_val_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterenumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterenumstmt([NotNull] PostgreSqlParser.AlterenumstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterenumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterenumstmt([NotNull] PostgreSqlParser.AlterenumstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_if_not_exists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_if_not_exists([NotNull] PostgreSqlParser.Opt_if_not_existsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_if_not_exists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_if_not_exists([NotNull] PostgreSqlParser.Opt_if_not_existsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createopclassstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateopclassstmt([NotNull] PostgreSqlParser.CreateopclassstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createopclassstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateopclassstmt([NotNull] PostgreSqlParser.CreateopclassstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_item_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpclass_item_list([NotNull] PostgreSqlParser.Opclass_item_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_item_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpclass_item_list([NotNull] PostgreSqlParser.Opclass_item_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpclass_item([NotNull] PostgreSqlParser.Opclass_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpclass_item([NotNull] PostgreSqlParser.Opclass_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_default([NotNull] PostgreSqlParser.Opt_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_default([NotNull] PostgreSqlParser.Opt_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_opfamily"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_opfamily([NotNull] PostgreSqlParser.Opt_opfamilyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_opfamily"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_opfamily([NotNull] PostgreSqlParser.Opt_opfamilyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_purpose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpclass_purpose([NotNull] PostgreSqlParser.Opclass_purposeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_purpose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpclass_purpose([NotNull] PostgreSqlParser.Opclass_purposeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_recheck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_recheck([NotNull] PostgreSqlParser.Opt_recheckContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_recheck"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_recheck([NotNull] PostgreSqlParser.Opt_recheckContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createopfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateopfamilystmt([NotNull] PostgreSqlParser.CreateopfamilystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createopfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateopfamilystmt([NotNull] PostgreSqlParser.CreateopfamilystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteropfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlteropfamilystmt([NotNull] PostgreSqlParser.AlteropfamilystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteropfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlteropfamilystmt([NotNull] PostgreSqlParser.AlteropfamilystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_drop_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpclass_drop_list([NotNull] PostgreSqlParser.Opclass_drop_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_drop_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpclass_drop_list([NotNull] PostgreSqlParser.Opclass_drop_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opclass_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpclass_drop([NotNull] PostgreSqlParser.Opclass_dropContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opclass_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpclass_drop([NotNull] PostgreSqlParser.Opclass_dropContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropopclassstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropopclassstmt([NotNull] PostgreSqlParser.DropopclassstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropopclassstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropopclassstmt([NotNull] PostgreSqlParser.DropopclassstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropopfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropopfamilystmt([NotNull] PostgreSqlParser.DropopfamilystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropopfamilystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropopfamilystmt([NotNull] PostgreSqlParser.DropopfamilystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropownedstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropownedstmt([NotNull] PostgreSqlParser.DropownedstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropownedstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropownedstmt([NotNull] PostgreSqlParser.DropownedstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reassignownedstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReassignownedstmt([NotNull] PostgreSqlParser.ReassignownedstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reassignownedstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReassignownedstmt([NotNull] PostgreSqlParser.ReassignownedstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropstmt([NotNull] PostgreSqlParser.DropstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropstmt([NotNull] PostgreSqlParser.DropstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_type_any_name([NotNull] PostgreSqlParser.Object_type_any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_type_any_name([NotNull] PostgreSqlParser.Object_type_any_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_type_name([NotNull] PostgreSqlParser.Object_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_type_name([NotNull] PostgreSqlParser.Object_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_type_name([NotNull] PostgreSqlParser.Drop_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_type_name([NotNull] PostgreSqlParser.Drop_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.object_type_name_on_any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_type_name_on_any_name([NotNull] PostgreSqlParser.Object_type_name_on_any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.object_type_name_on_any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_type_name_on_any_name([NotNull] PostgreSqlParser.Object_type_name_on_any_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_name_list([NotNull] PostgreSqlParser.Any_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_name_list([NotNull] PostgreSqlParser.Any_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_name([NotNull] PostgreSqlParser.Any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_name([NotNull] PostgreSqlParser.Any_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.attrs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttrs([NotNull] PostgreSqlParser.AttrsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.attrs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttrs([NotNull] PostgreSqlParser.AttrsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name_list([NotNull] PostgreSqlParser.Type_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name_list([NotNull] PostgreSqlParser.Type_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.truncatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncatestmt([NotNull] PostgreSqlParser.TruncatestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.truncatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncatestmt([NotNull] PostgreSqlParser.TruncatestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_restart_seqs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_restart_seqs([NotNull] PostgreSqlParser.Opt_restart_seqsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_restart_seqs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_restart_seqs([NotNull] PostgreSqlParser.Opt_restart_seqsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.commentstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommentstmt([NotNull] PostgreSqlParser.CommentstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.commentstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommentstmt([NotNull] PostgreSqlParser.CommentstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comment_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment_text([NotNull] PostgreSqlParser.Comment_textContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comment_text"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment_text([NotNull] PostgreSqlParser.Comment_textContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.seclabelstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeclabelstmt([NotNull] PostgreSqlParser.SeclabelstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.seclabelstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeclabelstmt([NotNull] PostgreSqlParser.SeclabelstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_provider([NotNull] PostgreSqlParser.Opt_providerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_provider([NotNull] PostgreSqlParser.Opt_providerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.security_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSecurity_label([NotNull] PostgreSqlParser.Security_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.security_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSecurity_label([NotNull] PostgreSqlParser.Security_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fetchstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFetchstmt([NotNull] PostgreSqlParser.FetchstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fetchstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFetchstmt([NotNull] PostgreSqlParser.FetchstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fetch_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFetch_args([NotNull] PostgreSqlParser.Fetch_argsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fetch_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFetch_args([NotNull] PostgreSqlParser.Fetch_argsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_in([NotNull] PostgreSqlParser.From_inContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_in([NotNull] PostgreSqlParser.From_inContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_from_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_from_in([NotNull] PostgreSqlParser.Opt_from_inContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_from_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_from_in([NotNull] PostgreSqlParser.Opt_from_inContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantstmt([NotNull] PostgreSqlParser.GrantstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantstmt([NotNull] PostgreSqlParser.GrantstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.revokestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRevokestmt([NotNull] PostgreSqlParser.RevokestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.revokestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRevokestmt([NotNull] PostgreSqlParser.RevokestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privileges"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivileges([NotNull] PostgreSqlParser.PrivilegesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privileges"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivileges([NotNull] PostgreSqlParser.PrivilegesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivilege_list([NotNull] PostgreSqlParser.Privilege_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivilege_list([NotNull] PostgreSqlParser.Privilege_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivilege([NotNull] PostgreSqlParser.PrivilegeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivilege([NotNull] PostgreSqlParser.PrivilegeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.privilege_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivilege_target([NotNull] PostgreSqlParser.Privilege_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.privilege_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivilege_target([NotNull] PostgreSqlParser.Privilege_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantee_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantee_list([NotNull] PostgreSqlParser.Grantee_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantee_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantee_list([NotNull] PostgreSqlParser.Grantee_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantee"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantee([NotNull] PostgreSqlParser.GranteeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantee"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantee([NotNull] PostgreSqlParser.GranteeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_grant_grant_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_grant_grant_option([NotNull] PostgreSqlParser.Opt_grant_grant_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_grant_grant_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_grant_grant_option([NotNull] PostgreSqlParser.Opt_grant_grant_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grantrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantrolestmt([NotNull] PostgreSqlParser.GrantrolestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grantrolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantrolestmt([NotNull] PostgreSqlParser.GrantrolestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.revokerolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRevokerolestmt([NotNull] PostgreSqlParser.RevokerolestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.revokerolestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRevokerolestmt([NotNull] PostgreSqlParser.RevokerolestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_grant_admin_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_grant_admin_option([NotNull] PostgreSqlParser.Opt_grant_admin_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_grant_admin_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_grant_admin_option([NotNull] PostgreSqlParser.Opt_grant_admin_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_granted_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_granted_by([NotNull] PostgreSqlParser.Opt_granted_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_granted_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_granted_by([NotNull] PostgreSqlParser.Opt_granted_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdefaultprivilegesstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterdefaultprivilegesstmt([NotNull] PostgreSqlParser.AlterdefaultprivilegesstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdefaultprivilegesstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterdefaultprivilegesstmt([NotNull] PostgreSqlParser.AlterdefaultprivilegesstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacloptionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefacloptionlist([NotNull] PostgreSqlParser.DefacloptionlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacloptionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefacloptionlist([NotNull] PostgreSqlParser.DefacloptionlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacloption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefacloption([NotNull] PostgreSqlParser.DefacloptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacloption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefacloption([NotNull] PostgreSqlParser.DefacloptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defaclaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaclaction([NotNull] PostgreSqlParser.DefaclactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defaclaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaclaction([NotNull] PostgreSqlParser.DefaclactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.defacl_privilege_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefacl_privilege_target([NotNull] PostgreSqlParser.Defacl_privilege_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.defacl_privilege_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefacl_privilege_target([NotNull] PostgreSqlParser.Defacl_privilege_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indexstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexstmt([NotNull] PostgreSqlParser.IndexstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indexstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexstmt([NotNull] PostgreSqlParser.IndexstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_unique"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_unique([NotNull] PostgreSqlParser.Opt_uniqueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_unique"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_unique([NotNull] PostgreSqlParser.Opt_uniqueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_concurrently"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_concurrently([NotNull] PostgreSqlParser.Opt_concurrentlyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_concurrently"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_concurrently([NotNull] PostgreSqlParser.Opt_concurrentlyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_index_name([NotNull] PostgreSqlParser.Opt_index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_index_name([NotNull] PostgreSqlParser.Opt_index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.access_method_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccess_method_clause([NotNull] PostgreSqlParser.Access_method_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.access_method_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccess_method_clause([NotNull] PostgreSqlParser.Access_method_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_params([NotNull] PostgreSqlParser.Index_paramsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_params([NotNull] PostgreSqlParser.Index_paramsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_elem_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_elem_options([NotNull] PostgreSqlParser.Index_elem_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_elem_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_elem_options([NotNull] PostgreSqlParser.Index_elem_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_elem([NotNull] PostgreSqlParser.Index_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_elem([NotNull] PostgreSqlParser.Index_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_include([NotNull] PostgreSqlParser.Opt_includeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_include"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_include([NotNull] PostgreSqlParser.Opt_includeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.index_including_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_including_params([NotNull] PostgreSqlParser.Index_including_paramsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.index_including_params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_including_params([NotNull] PostgreSqlParser.Index_including_paramsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_collate([NotNull] PostgreSqlParser.Opt_collateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_collate([NotNull] PostgreSqlParser.Opt_collateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_class([NotNull] PostgreSqlParser.Opt_classContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_class([NotNull] PostgreSqlParser.Opt_classContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_asc_desc([NotNull] PostgreSqlParser.Opt_asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_asc_desc([NotNull] PostgreSqlParser.Opt_asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nulls_order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_nulls_order([NotNull] PostgreSqlParser.Opt_nulls_orderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nulls_order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_nulls_order([NotNull] PostgreSqlParser.Opt_nulls_orderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunctionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatefunctionstmt([NotNull] PostgreSqlParser.CreatefunctionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunctionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatefunctionstmt([NotNull] PostgreSqlParser.CreatefunctionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_or_replace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_or_replace([NotNull] PostgreSqlParser.Opt_or_replaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_or_replace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_or_replace([NotNull] PostgreSqlParser.Opt_or_replaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_args([NotNull] PostgreSqlParser.Func_argsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_args([NotNull] PostgreSqlParser.Func_argsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_args_list([NotNull] PostgreSqlParser.Func_args_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_args_list([NotNull] PostgreSqlParser.Func_args_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_with_argtypes_list([NotNull] PostgreSqlParser.Function_with_argtypes_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_with_argtypes_list([NotNull] PostgreSqlParser.Function_with_argtypes_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_with_argtypes([NotNull] PostgreSqlParser.Function_with_argtypesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.function_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_with_argtypes([NotNull] PostgreSqlParser.Function_with_argtypesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_args_with_defaults([NotNull] PostgreSqlParser.Func_args_with_defaultsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_args_with_defaults([NotNull] PostgreSqlParser.Func_args_with_defaultsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_args_with_defaults_list([NotNull] PostgreSqlParser.Func_args_with_defaults_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_args_with_defaults_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_args_with_defaults_list([NotNull] PostgreSqlParser.Func_args_with_defaults_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_arg([NotNull] PostgreSqlParser.Func_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_arg([NotNull] PostgreSqlParser.Func_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.arg_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArg_class([NotNull] PostgreSqlParser.Arg_classContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.arg_class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArg_class([NotNull] PostgreSqlParser.Arg_classContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.param_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam_name([NotNull] PostgreSqlParser.Param_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.param_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam_name([NotNull] PostgreSqlParser.Param_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_return([NotNull] PostgreSqlParser.Func_returnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_return([NotNull] PostgreSqlParser.Func_returnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_type([NotNull] PostgreSqlParser.Func_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_type([NotNull] PostgreSqlParser.Func_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_with_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_arg_with_default([NotNull] PostgreSqlParser.Func_arg_with_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_with_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_arg_with_default([NotNull] PostgreSqlParser.Func_arg_with_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggr_arg([NotNull] PostgreSqlParser.Aggr_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggr_arg([NotNull] PostgreSqlParser.Aggr_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggr_args([NotNull] PostgreSqlParser.Aggr_argsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggr_args([NotNull] PostgreSqlParser.Aggr_argsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggr_args_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggr_args_list([NotNull] PostgreSqlParser.Aggr_args_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggr_args_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggr_args_list([NotNull] PostgreSqlParser.Aggr_args_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_with_argtypes([NotNull] PostgreSqlParser.Aggregate_with_argtypesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_with_argtypes([NotNull] PostgreSqlParser.Aggregate_with_argtypesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_with_argtypes_list([NotNull] PostgreSqlParser.Aggregate_with_argtypes_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aggregate_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_with_argtypes_list([NotNull] PostgreSqlParser.Aggregate_with_argtypes_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatefunc_opt_list([NotNull] PostgreSqlParser.Createfunc_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatefunc_opt_list([NotNull] PostgreSqlParser.Createfunc_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.common_func_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_func_opt_item([NotNull] PostgreSqlParser.Common_func_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.common_func_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_func_opt_item([NotNull] PostgreSqlParser.Common_func_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatefunc_opt_item([NotNull] PostgreSqlParser.Createfunc_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createfunc_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatefunc_opt_item([NotNull] PostgreSqlParser.Createfunc_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_as([NotNull] PostgreSqlParser.Func_asContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_as([NotNull] PostgreSqlParser.Func_asContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transform_type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransform_type_list([NotNull] PostgreSqlParser.Transform_type_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transform_type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransform_type_list([NotNull] PostgreSqlParser.Transform_type_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_definition([NotNull] PostgreSqlParser.Opt_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_definition([NotNull] PostgreSqlParser.Opt_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_func_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_func_column([NotNull] PostgreSqlParser.Table_func_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_func_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_func_column([NotNull] PostgreSqlParser.Table_func_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_func_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_func_column_list([NotNull] PostgreSqlParser.Table_func_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_func_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_func_column_list([NotNull] PostgreSqlParser.Table_func_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfunctionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterfunctionstmt([NotNull] PostgreSqlParser.AlterfunctionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfunctionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterfunctionstmt([NotNull] PostgreSqlParser.AlterfunctionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterfunc_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterfunc_opt_list([NotNull] PostgreSqlParser.Alterfunc_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterfunc_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterfunc_opt_list([NotNull] PostgreSqlParser.Alterfunc_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_restrict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_restrict([NotNull] PostgreSqlParser.Opt_restrictContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_restrict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_restrict([NotNull] PostgreSqlParser.Opt_restrictContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removefuncstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemovefuncstmt([NotNull] PostgreSqlParser.RemovefuncstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removefuncstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemovefuncstmt([NotNull] PostgreSqlParser.RemovefuncstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removeaggrstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemoveaggrstmt([NotNull] PostgreSqlParser.RemoveaggrstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removeaggrstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemoveaggrstmt([NotNull] PostgreSqlParser.RemoveaggrstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.removeoperstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemoveoperstmt([NotNull] PostgreSqlParser.RemoveoperstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.removeoperstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemoveoperstmt([NotNull] PostgreSqlParser.RemoveoperstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.oper_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOper_argtypes([NotNull] PostgreSqlParser.Oper_argtypesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.oper_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOper_argtypes([NotNull] PostgreSqlParser.Oper_argtypesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_operator([NotNull] PostgreSqlParser.Any_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_operator([NotNull] PostgreSqlParser.Any_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_with_argtypes_list([NotNull] PostgreSqlParser.Operator_with_argtypes_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_with_argtypes_list([NotNull] PostgreSqlParser.Operator_with_argtypes_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_with_argtypes([NotNull] PostgreSqlParser.Operator_with_argtypesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_with_argtypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_with_argtypes([NotNull] PostgreSqlParser.Operator_with_argtypesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDostmt([NotNull] PostgreSqlParser.DostmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDostmt([NotNull] PostgreSqlParser.DostmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDostmt_opt_list([NotNull] PostgreSqlParser.Dostmt_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDostmt_opt_list([NotNull] PostgreSqlParser.Dostmt_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDostmt_opt_item([NotNull] PostgreSqlParser.Dostmt_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dostmt_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDostmt_opt_item([NotNull] PostgreSqlParser.Dostmt_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createcaststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatecaststmt([NotNull] PostgreSqlParser.CreatecaststmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createcaststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatecaststmt([NotNull] PostgreSqlParser.CreatecaststmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cast_context"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCast_context([NotNull] PostgreSqlParser.Cast_contextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cast_context"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCast_context([NotNull] PostgreSqlParser.Cast_contextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropcaststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropcaststmt([NotNull] PostgreSqlParser.DropcaststmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropcaststmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropcaststmt([NotNull] PostgreSqlParser.DropcaststmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_if_exists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_if_exists([NotNull] PostgreSqlParser.Opt_if_existsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_if_exists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_if_exists([NotNull] PostgreSqlParser.Opt_if_existsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createtransformstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatetransformstmt([NotNull] PostgreSqlParser.CreatetransformstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createtransformstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatetransformstmt([NotNull] PostgreSqlParser.CreatetransformstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transform_element_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransform_element_list([NotNull] PostgreSqlParser.Transform_element_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transform_element_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransform_element_list([NotNull] PostgreSqlParser.Transform_element_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.droptransformstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDroptransformstmt([NotNull] PostgreSqlParser.DroptransformstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.droptransformstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDroptransformstmt([NotNull] PostgreSqlParser.DroptransformstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindexstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindexstmt([NotNull] PostgreSqlParser.ReindexstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindexstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindexstmt([NotNull] PostgreSqlParser.ReindexstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_target_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_target_type([NotNull] PostgreSqlParser.Reindex_target_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_target_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_target_type([NotNull] PostgreSqlParser.Reindex_target_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_target_multitable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_target_multitable([NotNull] PostgreSqlParser.Reindex_target_multitableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_target_multitable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_target_multitable([NotNull] PostgreSqlParser.Reindex_target_multitableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_option_list([NotNull] PostgreSqlParser.Reindex_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_option_list([NotNull] PostgreSqlParser.Reindex_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reindex_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_option_elem([NotNull] PostgreSqlParser.Reindex_option_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reindex_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_option_elem([NotNull] PostgreSqlParser.Reindex_option_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertblspcstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltertblspcstmt([NotNull] PostgreSqlParser.AltertblspcstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertblspcstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltertblspcstmt([NotNull] PostgreSqlParser.AltertblspcstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.renamestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRenamestmt([NotNull] PostgreSqlParser.RenamestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.renamestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRenamestmt([NotNull] PostgreSqlParser.RenamestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_column([NotNull] PostgreSqlParser.Opt_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_column([NotNull] PostgreSqlParser.Opt_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_set_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_set_data([NotNull] PostgreSqlParser.Opt_set_dataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_set_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_set_data([NotNull] PostgreSqlParser.Opt_set_dataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterobjectdependsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterobjectdependsstmt([NotNull] PostgreSqlParser.AlterobjectdependsstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterobjectdependsstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterobjectdependsstmt([NotNull] PostgreSqlParser.AlterobjectdependsstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_no"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_no([NotNull] PostgreSqlParser.Opt_noContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_no"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_no([NotNull] PostgreSqlParser.Opt_noContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterobjectschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterobjectschemastmt([NotNull] PostgreSqlParser.AlterobjectschemastmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterobjectschemastmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterobjectschemastmt([NotNull] PostgreSqlParser.AlterobjectschemastmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alteroperatorstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlteroperatorstmt([NotNull] PostgreSqlParser.AlteroperatorstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alteroperatorstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlteroperatorstmt([NotNull] PostgreSqlParser.AlteroperatorstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_def_list([NotNull] PostgreSqlParser.Operator_def_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_def_list([NotNull] PostgreSqlParser.Operator_def_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_def_elem([NotNull] PostgreSqlParser.Operator_def_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_def_elem([NotNull] PostgreSqlParser.Operator_def_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.operator_def_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_def_arg([NotNull] PostgreSqlParser.Operator_def_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.operator_def_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_def_arg([NotNull] PostgreSqlParser.Operator_def_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertypestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltertypestmt([NotNull] PostgreSqlParser.AltertypestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertypestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltertypestmt([NotNull] PostgreSqlParser.AltertypestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterownerstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterownerstmt([NotNull] PostgreSqlParser.AlterownerstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterownerstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterownerstmt([NotNull] PostgreSqlParser.AlterownerstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createpublicationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatepublicationstmt([NotNull] PostgreSqlParser.CreatepublicationstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createpublicationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatepublicationstmt([NotNull] PostgreSqlParser.CreatepublicationstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_publication_for_tables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_publication_for_tables([NotNull] PostgreSqlParser.Opt_publication_for_tablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_publication_for_tables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_publication_for_tables([NotNull] PostgreSqlParser.Opt_publication_for_tablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_for_tables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPublication_for_tables([NotNull] PostgreSqlParser.Publication_for_tablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_for_tables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPublication_for_tables([NotNull] PostgreSqlParser.Publication_for_tablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterpublicationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterpublicationstmt([NotNull] PostgreSqlParser.AlterpublicationstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterpublicationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterpublicationstmt([NotNull] PostgreSqlParser.AlterpublicationstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createsubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatesubscriptionstmt([NotNull] PostgreSqlParser.CreatesubscriptionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createsubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatesubscriptionstmt([NotNull] PostgreSqlParser.CreatesubscriptionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPublication_name_list([NotNull] PostgreSqlParser.Publication_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPublication_name_list([NotNull] PostgreSqlParser.Publication_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.publication_name_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPublication_name_item([NotNull] PostgreSqlParser.Publication_name_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.publication_name_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPublication_name_item([NotNull] PostgreSqlParser.Publication_name_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altersubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltersubscriptionstmt([NotNull] PostgreSqlParser.AltersubscriptionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altersubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltersubscriptionstmt([NotNull] PostgreSqlParser.AltersubscriptionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropsubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropsubscriptionstmt([NotNull] PostgreSqlParser.DropsubscriptionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropsubscriptionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropsubscriptionstmt([NotNull] PostgreSqlParser.DropsubscriptionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rulestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRulestmt([NotNull] PostgreSqlParser.RulestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rulestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRulestmt([NotNull] PostgreSqlParser.RulestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleactionlist([NotNull] PostgreSqlParser.RuleactionlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleactionlist([NotNull] PostgreSqlParser.RuleactionlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionmulti"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleactionmulti([NotNull] PostgreSqlParser.RuleactionmultiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionmulti"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleactionmulti([NotNull] PostgreSqlParser.RuleactionmultiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleactionstmt([NotNull] PostgreSqlParser.RuleactionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleactionstmt([NotNull] PostgreSqlParser.RuleactionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmtOrEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuleactionstmtOrEmpty([NotNull] PostgreSqlParser.RuleactionstmtOrEmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.ruleactionstmtOrEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuleactionstmtOrEmpty([NotNull] PostgreSqlParser.RuleactionstmtOrEmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.event"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent([NotNull] PostgreSqlParser.EventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.event"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent([NotNull] PostgreSqlParser.EventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_instead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_instead([NotNull] PostgreSqlParser.Opt_insteadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_instead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_instead([NotNull] PostgreSqlParser.Opt_insteadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.notifystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotifystmt([NotNull] PostgreSqlParser.NotifystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.notifystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotifystmt([NotNull] PostgreSqlParser.NotifystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.notify_payload"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotify_payload([NotNull] PostgreSqlParser.Notify_payloadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.notify_payload"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotify_payload([NotNull] PostgreSqlParser.Notify_payloadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.listenstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterListenstmt([NotNull] PostgreSqlParser.ListenstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.listenstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitListenstmt([NotNull] PostgreSqlParser.ListenstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unlistenstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnlistenstmt([NotNull] PostgreSqlParser.UnlistenstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unlistenstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnlistenstmt([NotNull] PostgreSqlParser.UnlistenstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transactionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionstmt([NotNull] PostgreSqlParser.TransactionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transactionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionstmt([NotNull] PostgreSqlParser.TransactionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_transaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_transaction([NotNull] PostgreSqlParser.Opt_transactionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_transaction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_transaction([NotNull] PostgreSqlParser.Opt_transactionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_mode_item([NotNull] PostgreSqlParser.Transaction_mode_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_mode_item([NotNull] PostgreSqlParser.Transaction_mode_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_mode_list([NotNull] PostgreSqlParser.Transaction_mode_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_mode_list([NotNull] PostgreSqlParser.Transaction_mode_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list_or_empty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_mode_list_or_empty([NotNull] PostgreSqlParser.Transaction_mode_list_or_emptyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.transaction_mode_list_or_empty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_mode_list_or_empty([NotNull] PostgreSqlParser.Transaction_mode_list_or_emptyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_transaction_chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_transaction_chain([NotNull] PostgreSqlParser.Opt_transaction_chainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_transaction_chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_transaction_chain([NotNull] PostgreSqlParser.Opt_transaction_chainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.viewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewstmt([NotNull] PostgreSqlParser.ViewstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.viewstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewstmt([NotNull] PostgreSqlParser.ViewstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_check_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_check_option([NotNull] PostgreSqlParser.Opt_check_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_check_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_check_option([NotNull] PostgreSqlParser.Opt_check_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.loadstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoadstmt([NotNull] PostgreSqlParser.LoadstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.loadstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoadstmt([NotNull] PostgreSqlParser.LoadstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdbstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedbstmt([NotNull] PostgreSqlParser.CreatedbstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdbstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedbstmt([NotNull] PostgreSqlParser.CreatedbstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedb_opt_list([NotNull] PostgreSqlParser.Createdb_opt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedb_opt_list([NotNull] PostgreSqlParser.Createdb_opt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_items"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedb_opt_items([NotNull] PostgreSqlParser.Createdb_opt_itemsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_items"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedb_opt_items([NotNull] PostgreSqlParser.Createdb_opt_itemsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedb_opt_item([NotNull] PostgreSqlParser.Createdb_opt_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedb_opt_item([NotNull] PostgreSqlParser.Createdb_opt_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedb_opt_name([NotNull] PostgreSqlParser.Createdb_opt_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdb_opt_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedb_opt_name([NotNull] PostgreSqlParser.Createdb_opt_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_equal([NotNull] PostgreSqlParser.Opt_equalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_equal([NotNull] PostgreSqlParser.Opt_equalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdatabasestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterdatabasestmt([NotNull] PostgreSqlParser.AlterdatabasestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdatabasestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterdatabasestmt([NotNull] PostgreSqlParser.AlterdatabasestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdatabasesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterdatabasesetstmt([NotNull] PostgreSqlParser.AlterdatabasesetstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdatabasesetstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterdatabasesetstmt([NotNull] PostgreSqlParser.AlterdatabasesetstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.dropdbstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropdbstmt([NotNull] PostgreSqlParser.DropdbstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.dropdbstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropdbstmt([NotNull] PostgreSqlParser.DropdbstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_option_list([NotNull] PostgreSqlParser.Drop_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_option_list([NotNull] PostgreSqlParser.Drop_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.drop_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_option([NotNull] PostgreSqlParser.Drop_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.drop_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_option([NotNull] PostgreSqlParser.Drop_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altercollationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltercollationstmt([NotNull] PostgreSqlParser.AltercollationstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altercollationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltercollationstmt([NotNull] PostgreSqlParser.AltercollationstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altersystemstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltersystemstmt([NotNull] PostgreSqlParser.AltersystemstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altersystemstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltersystemstmt([NotNull] PostgreSqlParser.AltersystemstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createdomainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedomainstmt([NotNull] PostgreSqlParser.CreatedomainstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createdomainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedomainstmt([NotNull] PostgreSqlParser.CreatedomainstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alterdomainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterdomainstmt([NotNull] PostgreSqlParser.AlterdomainstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alterdomainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterdomainstmt([NotNull] PostgreSqlParser.AlterdomainstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_as([NotNull] PostgreSqlParser.Opt_asContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_as([NotNull] PostgreSqlParser.Opt_asContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertsdictionarystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltertsdictionarystmt([NotNull] PostgreSqlParser.AltertsdictionarystmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertsdictionarystmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltertsdictionarystmt([NotNull] PostgreSqlParser.AltertsdictionarystmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.altertsconfigurationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAltertsconfigurationstmt([NotNull] PostgreSqlParser.AltertsconfigurationstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.altertsconfigurationstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAltertsconfigurationstmt([NotNull] PostgreSqlParser.AltertsconfigurationstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_with([NotNull] PostgreSqlParser.Any_withContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_with([NotNull] PostgreSqlParser.Any_withContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.createconversionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateconversionstmt([NotNull] PostgreSqlParser.CreateconversionstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.createconversionstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateconversionstmt([NotNull] PostgreSqlParser.CreateconversionstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.clusterstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClusterstmt([NotNull] PostgreSqlParser.ClusterstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.clusterstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClusterstmt([NotNull] PostgreSqlParser.ClusterstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cluster_index_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCluster_index_specification([NotNull] PostgreSqlParser.Cluster_index_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cluster_index_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCluster_index_specification([NotNull] PostgreSqlParser.Cluster_index_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuumstmt([NotNull] PostgreSqlParser.VacuumstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuumstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuumstmt([NotNull] PostgreSqlParser.VacuumstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.analyzestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyzestmt([NotNull] PostgreSqlParser.AnalyzestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.analyzestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyzestmt([NotNull] PostgreSqlParser.AnalyzestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVac_analyze_option_list([NotNull] PostgreSqlParser.Vac_analyze_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVac_analyze_option_list([NotNull] PostgreSqlParser.Vac_analyze_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.analyze_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyze_keyword([NotNull] PostgreSqlParser.Analyze_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.analyze_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyze_keyword([NotNull] PostgreSqlParser.Analyze_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVac_analyze_option_elem([NotNull] PostgreSqlParser.Vac_analyze_option_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVac_analyze_option_elem([NotNull] PostgreSqlParser.Vac_analyze_option_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVac_analyze_option_name([NotNull] PostgreSqlParser.Vac_analyze_option_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVac_analyze_option_name([NotNull] PostgreSqlParser.Vac_analyze_option_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVac_analyze_option_arg([NotNull] PostgreSqlParser.Vac_analyze_option_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vac_analyze_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVac_analyze_option_arg([NotNull] PostgreSqlParser.Vac_analyze_option_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_analyze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_analyze([NotNull] PostgreSqlParser.Opt_analyzeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_analyze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_analyze([NotNull] PostgreSqlParser.Opt_analyzeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_verbose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_verbose([NotNull] PostgreSqlParser.Opt_verboseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_verbose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_verbose([NotNull] PostgreSqlParser.Opt_verboseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_full"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_full([NotNull] PostgreSqlParser.Opt_fullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_full"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_full([NotNull] PostgreSqlParser.Opt_fullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_freeze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_freeze([NotNull] PostgreSqlParser.Opt_freezeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_freeze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_freeze([NotNull] PostgreSqlParser.Opt_freezeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_name_list([NotNull] PostgreSqlParser.Opt_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_name_list([NotNull] PostgreSqlParser.Opt_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuum_relation([NotNull] PostgreSqlParser.Vacuum_relationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuum_relation([NotNull] PostgreSqlParser.Vacuum_relationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuum_relation_list([NotNull] PostgreSqlParser.Vacuum_relation_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.vacuum_relation_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuum_relation_list([NotNull] PostgreSqlParser.Vacuum_relation_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_vacuum_relation_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_vacuum_relation_list([NotNull] PostgreSqlParser.Opt_vacuum_relation_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_vacuum_relation_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_vacuum_relation_list([NotNull] PostgreSqlParser.Opt_vacuum_relation_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainstmt([NotNull] PostgreSqlParser.ExplainstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explainstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainstmt([NotNull] PostgreSqlParser.ExplainstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explainablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainablestmt([NotNull] PostgreSqlParser.ExplainablestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explainablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainablestmt([NotNull] PostgreSqlParser.ExplainablestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplain_option_list([NotNull] PostgreSqlParser.Explain_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplain_option_list([NotNull] PostgreSqlParser.Explain_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplain_option_elem([NotNull] PostgreSqlParser.Explain_option_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplain_option_elem([NotNull] PostgreSqlParser.Explain_option_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplain_option_name([NotNull] PostgreSqlParser.Explain_option_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplain_option_name([NotNull] PostgreSqlParser.Explain_option_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explain_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplain_option_arg([NotNull] PostgreSqlParser.Explain_option_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explain_option_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplain_option_arg([NotNull] PostgreSqlParser.Explain_option_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.preparestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreparestmt([NotNull] PostgreSqlParser.PreparestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.preparestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreparestmt([NotNull] PostgreSqlParser.PreparestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.prep_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrep_type_clause([NotNull] PostgreSqlParser.Prep_type_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.prep_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrep_type_clause([NotNull] PostgreSqlParser.Prep_type_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.preparablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreparablestmt([NotNull] PostgreSqlParser.PreparablestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.preparablestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreparablestmt([NotNull] PostgreSqlParser.PreparablestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.executestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecutestmt([NotNull] PostgreSqlParser.ExecutestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.executestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecutestmt([NotNull] PostgreSqlParser.ExecutestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.execute_param_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_param_clause([NotNull] PostgreSqlParser.Execute_param_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.execute_param_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_param_clause([NotNull] PostgreSqlParser.Execute_param_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.deallocatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeallocatestmt([NotNull] PostgreSqlParser.DeallocatestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.deallocatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeallocatestmt([NotNull] PostgreSqlParser.DeallocatestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insertstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertstmt([NotNull] PostgreSqlParser.InsertstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insertstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertstmt([NotNull] PostgreSqlParser.InsertstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_target([NotNull] PostgreSqlParser.Insert_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_target([NotNull] PostgreSqlParser.Insert_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_rest([NotNull] PostgreSqlParser.Insert_restContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_rest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_rest([NotNull] PostgreSqlParser.Insert_restContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.override_kind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverride_kind([NotNull] PostgreSqlParser.Override_kindContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.override_kind"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverride_kind([NotNull] PostgreSqlParser.Override_kindContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_column_list([NotNull] PostgreSqlParser.Insert_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_column_list([NotNull] PostgreSqlParser.Insert_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.insert_column_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_column_item([NotNull] PostgreSqlParser.Insert_column_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.insert_column_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_column_item([NotNull] PostgreSqlParser.Insert_column_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_on_conflict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_on_conflict([NotNull] PostgreSqlParser.Opt_on_conflictContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_on_conflict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_on_conflict([NotNull] PostgreSqlParser.Opt_on_conflictContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_conf_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_conf_expr([NotNull] PostgreSqlParser.Opt_conf_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_conf_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_conf_expr([NotNull] PostgreSqlParser.Opt_conf_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturning_clause([NotNull] PostgreSqlParser.Returning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturning_clause([NotNull] PostgreSqlParser.Returning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.deletestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeletestmt([NotNull] PostgreSqlParser.DeletestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.deletestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeletestmt([NotNull] PostgreSqlParser.DeletestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.using_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_clause([NotNull] PostgreSqlParser.Using_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.using_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_clause([NotNull] PostgreSqlParser.Using_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.lockstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockstmt([NotNull] PostgreSqlParser.LockstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.lockstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockstmt([NotNull] PostgreSqlParser.LockstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_lock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_lock([NotNull] PostgreSqlParser.Opt_lockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_lock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_lock([NotNull] PostgreSqlParser.Opt_lockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.lock_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLock_type([NotNull] PostgreSqlParser.Lock_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.lock_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLock_type([NotNull] PostgreSqlParser.Lock_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nowait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_nowait([NotNull] PostgreSqlParser.Opt_nowaitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nowait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_nowait([NotNull] PostgreSqlParser.Opt_nowaitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_nowait_or_skip"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_nowait_or_skip([NotNull] PostgreSqlParser.Opt_nowait_or_skipContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_nowait_or_skip"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_nowait_or_skip([NotNull] PostgreSqlParser.Opt_nowait_or_skipContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.updatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdatestmt([NotNull] PostgreSqlParser.UpdatestmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.updatestmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdatestmt([NotNull] PostgreSqlParser.UpdatestmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_clause_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_clause_list([NotNull] PostgreSqlParser.Set_clause_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_clause_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_clause_list([NotNull] PostgreSqlParser.Set_clause_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_clause([NotNull] PostgreSqlParser.Set_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_clause([NotNull] PostgreSqlParser.Set_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_target([NotNull] PostgreSqlParser.Set_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_target([NotNull] PostgreSqlParser.Set_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_target_list([NotNull] PostgreSqlParser.Set_target_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_target_list([NotNull] PostgreSqlParser.Set_target_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.declarecursorstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarecursorstmt([NotNull] PostgreSqlParser.DeclarecursorstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.declarecursorstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarecursorstmt([NotNull] PostgreSqlParser.DeclarecursorstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_name([NotNull] PostgreSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_name([NotNull] PostgreSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_options([NotNull] PostgreSqlParser.Cursor_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_options([NotNull] PostgreSqlParser.Cursor_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_hold"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_hold([NotNull] PostgreSqlParser.Opt_holdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_hold"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_hold([NotNull] PostgreSqlParser.Opt_holdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.selectstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectstmt([NotNull] PostgreSqlParser.SelectstmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.selectstmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectstmt([NotNull] PostgreSqlParser.SelectstmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_with_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_with_parens([NotNull] PostgreSqlParser.Select_with_parensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_with_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_with_parens([NotNull] PostgreSqlParser.Select_with_parensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_no_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_no_parens([NotNull] PostgreSqlParser.Select_no_parensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_no_parens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_no_parens([NotNull] PostgreSqlParser.Select_no_parensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_clause([NotNull] PostgreSqlParser.Select_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_clause([NotNull] PostgreSqlParser.Select_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.simple_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_select([NotNull] PostgreSqlParser.Simple_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.simple_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_select([NotNull] PostgreSqlParser.Simple_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>union</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnion([NotNull] PostgreSqlParser.UnionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>union</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnion([NotNull] PostgreSqlParser.UnionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>intersect</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntersect([NotNull] PostgreSqlParser.IntersectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>intersect</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntersect([NotNull] PostgreSqlParser.IntersectContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>except</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExcept([NotNull] PostgreSqlParser.ExceptContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>except</c>
	/// labeled alternative in <see cref="PostgreSqlParser.set_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExcept([NotNull] PostgreSqlParser.ExceptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.set_operator_with_all_or_distinct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_operator_with_all_or_distinct([NotNull] PostgreSqlParser.Set_operator_with_all_or_distinctContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.set_operator_with_all_or_distinct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_operator_with_all_or_distinct([NotNull] PostgreSqlParser.Set_operator_with_all_or_distinctContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_clause([NotNull] PostgreSqlParser.With_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_clause([NotNull] PostgreSqlParser.With_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cte_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCte_list([NotNull] PostgreSqlParser.Cte_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cte_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCte_list([NotNull] PostgreSqlParser.Cte_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.common_table_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_expr([NotNull] PostgreSqlParser.Common_table_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.common_table_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_expr([NotNull] PostgreSqlParser.Common_table_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_materialized"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_materialized([NotNull] PostgreSqlParser.Opt_materializedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_materialized"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_materialized([NotNull] PostgreSqlParser.Opt_materializedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_with_clause([NotNull] PostgreSqlParser.Opt_with_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_with_clause([NotNull] PostgreSqlParser.Opt_with_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInto_clause([NotNull] PostgreSqlParser.Into_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInto_clause([NotNull] PostgreSqlParser.Into_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_strict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_strict([NotNull] PostgreSqlParser.Opt_strictContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_strict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_strict([NotNull] PostgreSqlParser.Opt_strictContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttempTableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttempTableName([NotNull] PostgreSqlParser.OpttempTableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttempTableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttempTableName([NotNull] PostgreSqlParser.OpttempTableNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_table([NotNull] PostgreSqlParser.Opt_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_table([NotNull] PostgreSqlParser.Opt_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.all_or_distinct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAll_or_distinct([NotNull] PostgreSqlParser.All_or_distinctContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.all_or_distinct"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAll_or_distinct([NotNull] PostgreSqlParser.All_or_distinctContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.distinct_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDistinct_clause([NotNull] PostgreSqlParser.Distinct_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.distinct_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDistinct_clause([NotNull] PostgreSqlParser.Distinct_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_all_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_all_clause([NotNull] PostgreSqlParser.Opt_all_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_all_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_all_clause([NotNull] PostgreSqlParser.Opt_all_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_sort_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_sort_clause([NotNull] PostgreSqlParser.Opt_sort_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_sort_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_sort_clause([NotNull] PostgreSqlParser.Opt_sort_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sort_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSort_clause([NotNull] PostgreSqlParser.Sort_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sort_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSort_clause([NotNull] PostgreSqlParser.Sort_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sortby_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSortby_list([NotNull] PostgreSqlParser.Sortby_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sortby_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSortby_list([NotNull] PostgreSqlParser.Sortby_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sortby"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSortby([NotNull] PostgreSqlParser.SortbyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sortby"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSortby([NotNull] PostgreSqlParser.SortbyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_limit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_limit([NotNull] PostgreSqlParser.Select_limitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_limit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_limit([NotNull] PostgreSqlParser.Select_limitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_select_limit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_select_limit([NotNull] PostgreSqlParser.Opt_select_limitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_select_limit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_select_limit([NotNull] PostgreSqlParser.Opt_select_limitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.limit_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimit_clause([NotNull] PostgreSqlParser.Limit_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.limit_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimit_clause([NotNull] PostgreSqlParser.Limit_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.offset_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffset_clause([NotNull] PostgreSqlParser.Offset_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.offset_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffset_clause([NotNull] PostgreSqlParser.Offset_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_limit_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_limit_value([NotNull] PostgreSqlParser.Select_limit_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_limit_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_limit_value([NotNull] PostgreSqlParser.Select_limit_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_offset_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_offset_value([NotNull] PostgreSqlParser.Select_offset_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_offset_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_offset_value([NotNull] PostgreSqlParser.Select_offset_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.select_fetch_first_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_fetch_first_value([NotNull] PostgreSqlParser.Select_fetch_first_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.select_fetch_first_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_fetch_first_value([NotNull] PostgreSqlParser.Select_fetch_first_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.i_or_f_const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterI_or_f_const([NotNull] PostgreSqlParser.I_or_f_constContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.i_or_f_const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitI_or_f_const([NotNull] PostgreSqlParser.I_or_f_constContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row_or_rows"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow_or_rows([NotNull] PostgreSqlParser.Row_or_rowsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row_or_rows"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow_or_rows([NotNull] PostgreSqlParser.Row_or_rowsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.first_or_next"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFirst_or_next([NotNull] PostgreSqlParser.First_or_nextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.first_or_next"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFirst_or_next([NotNull] PostgreSqlParser.First_or_nextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_clause([NotNull] PostgreSqlParser.Group_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_clause([NotNull] PostgreSqlParser.Group_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_by_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_by_list([NotNull] PostgreSqlParser.Group_by_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_by_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_by_list([NotNull] PostgreSqlParser.Group_by_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.group_by_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_by_item([NotNull] PostgreSqlParser.Group_by_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.group_by_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_by_item([NotNull] PostgreSqlParser.Group_by_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.empty_grouping_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty_grouping_set([NotNull] PostgreSqlParser.Empty_grouping_setContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.empty_grouping_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty_grouping_set([NotNull] PostgreSqlParser.Empty_grouping_setContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rollup_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollup_clause([NotNull] PostgreSqlParser.Rollup_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rollup_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollup_clause([NotNull] PostgreSqlParser.Rollup_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cube_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCube_clause([NotNull] PostgreSqlParser.Cube_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cube_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCube_clause([NotNull] PostgreSqlParser.Cube_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.grouping_sets_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrouping_sets_clause([NotNull] PostgreSqlParser.Grouping_sets_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.grouping_sets_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrouping_sets_clause([NotNull] PostgreSqlParser.Grouping_sets_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.having_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHaving_clause([NotNull] PostgreSqlParser.Having_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.having_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHaving_clause([NotNull] PostgreSqlParser.Having_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_locking_clause([NotNull] PostgreSqlParser.For_locking_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_locking_clause([NotNull] PostgreSqlParser.For_locking_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_for_locking_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_for_locking_clause([NotNull] PostgreSqlParser.Opt_for_locking_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_for_locking_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_for_locking_clause([NotNull] PostgreSqlParser.Opt_for_locking_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_items"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_locking_items([NotNull] PostgreSqlParser.For_locking_itemsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_items"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_locking_items([NotNull] PostgreSqlParser.For_locking_itemsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_locking_item([NotNull] PostgreSqlParser.For_locking_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_locking_item([NotNull] PostgreSqlParser.For_locking_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_locking_strength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_locking_strength([NotNull] PostgreSqlParser.For_locking_strengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_locking_strength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_locking_strength([NotNull] PostgreSqlParser.For_locking_strengthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.locked_rels_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocked_rels_list([NotNull] PostgreSqlParser.Locked_rels_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.locked_rels_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocked_rels_list([NotNull] PostgreSqlParser.Locked_rels_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValues_clause([NotNull] PostgreSqlParser.Values_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValues_clause([NotNull] PostgreSqlParser.Values_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_clause([NotNull] PostgreSqlParser.From_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_clause([NotNull] PostgreSqlParser.From_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.from_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_list([NotNull] PostgreSqlParser.From_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.from_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_list([NotNull] PostgreSqlParser.From_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref([NotNull] PostgreSqlParser.Table_refContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref([NotNull] PostgreSqlParser.Table_refContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlias_clause([NotNull] PostgreSqlParser.Alias_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlias_clause([NotNull] PostgreSqlParser.Alias_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_alias_clause([NotNull] PostgreSqlParser.Opt_alias_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_alias_clause([NotNull] PostgreSqlParser.Opt_alias_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_alias_clause([NotNull] PostgreSqlParser.Func_alias_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_alias_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_alias_clause([NotNull] PostgreSqlParser.Func_alias_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.join_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_type([NotNull] PostgreSqlParser.Join_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.join_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_type([NotNull] PostgreSqlParser.Join_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.join_qual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_qual([NotNull] PostgreSqlParser.Join_qualContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.join_qual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_qual([NotNull] PostgreSqlParser.Join_qualContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelation_expr([NotNull] PostgreSqlParser.Relation_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelation_expr([NotNull] PostgreSqlParser.Relation_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelation_expr_list([NotNull] PostgreSqlParser.Relation_expr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelation_expr_list([NotNull] PostgreSqlParser.Relation_expr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.relation_expr_opt_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelation_expr_opt_alias([NotNull] PostgreSqlParser.Relation_expr_opt_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.relation_expr_opt_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelation_expr_opt_alias([NotNull] PostgreSqlParser.Relation_expr_opt_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablesample_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablesample_clause([NotNull] PostgreSqlParser.Tablesample_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablesample_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablesample_clause([NotNull] PostgreSqlParser.Tablesample_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_repeatable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_repeatable_clause([NotNull] PostgreSqlParser.Opt_repeatable_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_repeatable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_repeatable_clause([NotNull] PostgreSqlParser.Opt_repeatable_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_table([NotNull] PostgreSqlParser.Func_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_table([NotNull] PostgreSqlParser.Func_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsfrom_item([NotNull] PostgreSqlParser.Rowsfrom_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsfrom_item([NotNull] PostgreSqlParser.Rowsfrom_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowsfrom_list([NotNull] PostgreSqlParser.Rowsfrom_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rowsfrom_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowsfrom_list([NotNull] PostgreSqlParser.Rowsfrom_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_col_def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_col_def_list([NotNull] PostgreSqlParser.Opt_col_def_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_col_def_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_col_def_list([NotNull] PostgreSqlParser.Opt_col_def_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_ordinality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_ordinality([NotNull] PostgreSqlParser.Opt_ordinalityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_ordinality"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_ordinality([NotNull] PostgreSqlParser.Opt_ordinalityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_clause([NotNull] PostgreSqlParser.Where_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_clause([NotNull] PostgreSqlParser.Where_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.where_or_current_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_or_current_clause([NotNull] PostgreSqlParser.Where_or_current_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.where_or_current_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_or_current_clause([NotNull] PostgreSqlParser.Where_or_current_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opttablefuncelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpttablefuncelementlist([NotNull] PostgreSqlParser.OpttablefuncelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opttablefuncelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpttablefuncelementlist([NotNull] PostgreSqlParser.OpttablefuncelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablefuncelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablefuncelementlist([NotNull] PostgreSqlParser.TablefuncelementlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablefuncelementlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablefuncelementlist([NotNull] PostgreSqlParser.TablefuncelementlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.tablefuncelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablefuncelement([NotNull] PostgreSqlParser.TablefuncelementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.tablefuncelement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablefuncelement([NotNull] PostgreSqlParser.TablefuncelementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable([NotNull] PostgreSqlParser.XmltableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable([NotNull] PostgreSqlParser.XmltableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable_column_list([NotNull] PostgreSqlParser.Xmltable_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable_column_list([NotNull] PostgreSqlParser.Xmltable_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable_column_el([NotNull] PostgreSqlParser.Xmltable_column_elContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable_column_el([NotNull] PostgreSqlParser.Xmltable_column_elContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable_column_option_list([NotNull] PostgreSqlParser.Xmltable_column_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable_column_option_list([NotNull] PostgreSqlParser.Xmltable_column_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable_column_option_el([NotNull] PostgreSqlParser.Xmltable_column_option_elContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmltable_column_option_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable_column_option_el([NotNull] PostgreSqlParser.Xmltable_column_option_elContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_namespace_list([NotNull] PostgreSqlParser.Xml_namespace_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_namespace_list([NotNull] PostgreSqlParser.Xml_namespace_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_namespace_el([NotNull] PostgreSqlParser.Xml_namespace_elContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_namespace_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_namespace_el([NotNull] PostgreSqlParser.Xml_namespace_elContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.typename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypename([NotNull] PostgreSqlParser.TypenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.typename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypename([NotNull] PostgreSqlParser.TypenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_array_bounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_array_bounds([NotNull] PostgreSqlParser.Opt_array_boundsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_array_bounds"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_array_bounds([NotNull] PostgreSqlParser.Opt_array_boundsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.simpletypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpletypename([NotNull] PostgreSqlParser.SimpletypenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.simpletypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpletypename([NotNull] PostgreSqlParser.SimpletypenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.consttypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConsttypename([NotNull] PostgreSqlParser.ConsttypenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.consttypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConsttypename([NotNull] PostgreSqlParser.ConsttypenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.generictype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenerictype([NotNull] PostgreSqlParser.GenerictypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.generictype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenerictype([NotNull] PostgreSqlParser.GenerictypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_type_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_type_modifiers([NotNull] PostgreSqlParser.Opt_type_modifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_type_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_type_modifiers([NotNull] PostgreSqlParser.Opt_type_modifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric([NotNull] PostgreSqlParser.NumericContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric([NotNull] PostgreSqlParser.NumericContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_float([NotNull] PostgreSqlParser.Opt_floatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_float([NotNull] PostgreSqlParser.Opt_floatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBit([NotNull] PostgreSqlParser.BitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBit([NotNull] PostgreSqlParser.BitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constbit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstbit([NotNull] PostgreSqlParser.ConstbitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constbit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstbit([NotNull] PostgreSqlParser.ConstbitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bitwithlength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitwithlength([NotNull] PostgreSqlParser.BitwithlengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bitwithlength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitwithlength([NotNull] PostgreSqlParser.BitwithlengthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bitwithoutlength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitwithoutlength([NotNull] PostgreSqlParser.BitwithoutlengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bitwithoutlength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitwithoutlength([NotNull] PostgreSqlParser.BitwithoutlengthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.character"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharacter([NotNull] PostgreSqlParser.CharacterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.character"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharacter([NotNull] PostgreSqlParser.CharacterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constcharacter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstcharacter([NotNull] PostgreSqlParser.ConstcharacterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constcharacter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstcharacter([NotNull] PostgreSqlParser.ConstcharacterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.character_c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharacter_c([NotNull] PostgreSqlParser.Character_cContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.character_c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharacter_c([NotNull] PostgreSqlParser.Character_cContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_varying"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_varying([NotNull] PostgreSqlParser.Opt_varyingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_varying"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_varying([NotNull] PostgreSqlParser.Opt_varyingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constdatetime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstdatetime([NotNull] PostgreSqlParser.ConstdatetimeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constdatetime"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstdatetime([NotNull] PostgreSqlParser.ConstdatetimeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.constinterval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstinterval([NotNull] PostgreSqlParser.ConstintervalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.constinterval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstinterval([NotNull] PostgreSqlParser.ConstintervalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_timezone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_timezone([NotNull] PostgreSqlParser.Opt_timezoneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_timezone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_timezone([NotNull] PostgreSqlParser.Opt_timezoneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_interval([NotNull] PostgreSqlParser.Opt_intervalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_interval([NotNull] PostgreSqlParser.Opt_intervalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.interval_second"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterval_second([NotNull] PostgreSqlParser.Interval_secondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.interval_second"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterval_second([NotNull] PostgreSqlParser.Interval_secondContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_escape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_escape([NotNull] PostgreSqlParser.Opt_escapeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_escape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_escape([NotNull] PostgreSqlParser.Opt_escapeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr([NotNull] PostgreSqlParser.A_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr([NotNull] PostgreSqlParser.A_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_qual([NotNull] PostgreSqlParser.A_expr_qualContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_qual([NotNull] PostgreSqlParser.A_expr_qualContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_lessless"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_lessless([NotNull] PostgreSqlParser.A_expr_lesslessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_lessless"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_lessless([NotNull] PostgreSqlParser.A_expr_lesslessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_or"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_or([NotNull] PostgreSqlParser.A_expr_orContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_or"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_or([NotNull] PostgreSqlParser.A_expr_orContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_and([NotNull] PostgreSqlParser.A_expr_andContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_and([NotNull] PostgreSqlParser.A_expr_andContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_in([NotNull] PostgreSqlParser.A_expr_inContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_in"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_in([NotNull] PostgreSqlParser.A_expr_inContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_unary_not([NotNull] PostgreSqlParser.A_expr_unary_notContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_unary_not([NotNull] PostgreSqlParser.A_expr_unary_notContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_isnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_isnull([NotNull] PostgreSqlParser.A_expr_isnullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_isnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_isnull([NotNull] PostgreSqlParser.A_expr_isnullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_is_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_is_not([NotNull] PostgreSqlParser.A_expr_is_notContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_is_not"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_is_not([NotNull] PostgreSqlParser.A_expr_is_notContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_compare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_compare([NotNull] PostgreSqlParser.A_expr_compareContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_compare"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_compare([NotNull] PostgreSqlParser.A_expr_compareContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_like"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_like([NotNull] PostgreSqlParser.A_expr_likeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_like"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_like([NotNull] PostgreSqlParser.A_expr_likeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_qual_op([NotNull] PostgreSqlParser.A_expr_qual_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_qual_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_qual_op([NotNull] PostgreSqlParser.A_expr_qual_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_qualop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_unary_qualop([NotNull] PostgreSqlParser.A_expr_unary_qualopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_qualop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_unary_qualop([NotNull] PostgreSqlParser.A_expr_unary_qualopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_add([NotNull] PostgreSqlParser.A_expr_addContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_add"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_add([NotNull] PostgreSqlParser.A_expr_addContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_mul"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_mul([NotNull] PostgreSqlParser.A_expr_mulContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_mul"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_mul([NotNull] PostgreSqlParser.A_expr_mulContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_caret"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_caret([NotNull] PostgreSqlParser.A_expr_caretContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_caret"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_caret([NotNull] PostgreSqlParser.A_expr_caretContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_unary_sign([NotNull] PostgreSqlParser.A_expr_unary_signContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_unary_sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_unary_sign([NotNull] PostgreSqlParser.A_expr_unary_signContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_at_time_zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_at_time_zone([NotNull] PostgreSqlParser.A_expr_at_time_zoneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_at_time_zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_at_time_zone([NotNull] PostgreSqlParser.A_expr_at_time_zoneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_collate([NotNull] PostgreSqlParser.A_expr_collateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_collate([NotNull] PostgreSqlParser.A_expr_collateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.a_expr_typecast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterA_expr_typecast([NotNull] PostgreSqlParser.A_expr_typecastContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.a_expr_typecast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitA_expr_typecast([NotNull] PostgreSqlParser.A_expr_typecastContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.b_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterB_expr([NotNull] PostgreSqlParser.B_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.b_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitB_expr([NotNull] PostgreSqlParser.B_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_exists</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_expr_exists([NotNull] PostgreSqlParser.C_expr_existsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_exists</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_expr_exists([NotNull] PostgreSqlParser.C_expr_existsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_expr</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_expr_expr([NotNull] PostgreSqlParser.C_expr_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_expr</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_expr_expr([NotNull] PostgreSqlParser.C_expr_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>c_expr_case</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_expr_case([NotNull] PostgreSqlParser.C_expr_caseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>c_expr_case</c>
	/// labeled alternative in <see cref="PostgreSqlParser.c_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_expr_case([NotNull] PostgreSqlParser.C_expr_caseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlvariablename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsqlvariablename([NotNull] PostgreSqlParser.PlsqlvariablenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlvariablename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsqlvariablename([NotNull] PostgreSqlParser.PlsqlvariablenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_application"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_application([NotNull] PostgreSqlParser.Func_applicationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_application"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_application([NotNull] PostgreSqlParser.Func_applicationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_expr([NotNull] PostgreSqlParser.Func_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_expr([NotNull] PostgreSqlParser.Func_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr_windowless"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_expr_windowless([NotNull] PostgreSqlParser.Func_expr_windowlessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr_windowless"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_expr_windowless([NotNull] PostgreSqlParser.Func_expr_windowlessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_expr_common_subexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_expr_common_subexpr([NotNull] PostgreSqlParser.Func_expr_common_subexprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_expr_common_subexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_expr_common_subexpr([NotNull] PostgreSqlParser.Func_expr_common_subexprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_root_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_root_version([NotNull] PostgreSqlParser.Xml_root_versionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_root_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_root_version([NotNull] PostgreSqlParser.Xml_root_versionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_xml_root_standalone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_xml_root_standalone([NotNull] PostgreSqlParser.Opt_xml_root_standaloneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_xml_root_standalone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_xml_root_standalone([NotNull] PostgreSqlParser.Opt_xml_root_standaloneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_attributes([NotNull] PostgreSqlParser.Xml_attributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_attributes([NotNull] PostgreSqlParser.Xml_attributesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_attribute_list([NotNull] PostgreSqlParser.Xml_attribute_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_attribute_list([NotNull] PostgreSqlParser.Xml_attribute_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_attribute_el([NotNull] PostgreSqlParser.Xml_attribute_elContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_attribute_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_attribute_el([NotNull] PostgreSqlParser.Xml_attribute_elContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.document_or_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDocument_or_content([NotNull] PostgreSqlParser.Document_or_contentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.document_or_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDocument_or_content([NotNull] PostgreSqlParser.Document_or_contentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_whitespace_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_whitespace_option([NotNull] PostgreSqlParser.Xml_whitespace_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_whitespace_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_whitespace_option([NotNull] PostgreSqlParser.Xml_whitespace_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xmlexists_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlexists_argument([NotNull] PostgreSqlParser.Xmlexists_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xmlexists_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlexists_argument([NotNull] PostgreSqlParser.Xmlexists_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xml_passing_mech"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_passing_mech([NotNull] PostgreSqlParser.Xml_passing_mechContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xml_passing_mech"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_passing_mech([NotNull] PostgreSqlParser.Xml_passing_mechContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.within_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithin_group_clause([NotNull] PostgreSqlParser.Within_group_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.within_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithin_group_clause([NotNull] PostgreSqlParser.Within_group_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter_clause([NotNull] PostgreSqlParser.Filter_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter_clause([NotNull] PostgreSqlParser.Filter_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_clause([NotNull] PostgreSqlParser.Window_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_clause([NotNull] PostgreSqlParser.Window_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_definition_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_definition_list([NotNull] PostgreSqlParser.Window_definition_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_definition_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_definition_list([NotNull] PostgreSqlParser.Window_definition_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_definition([NotNull] PostgreSqlParser.Window_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_definition([NotNull] PostgreSqlParser.Window_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause([NotNull] PostgreSqlParser.Over_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause([NotNull] PostgreSqlParser.Over_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.window_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_specification([NotNull] PostgreSqlParser.Window_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.window_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_specification([NotNull] PostgreSqlParser.Window_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_existing_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_existing_window_name([NotNull] PostgreSqlParser.Opt_existing_window_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_existing_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_existing_window_name([NotNull] PostgreSqlParser.Opt_existing_window_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_partition_clause([NotNull] PostgreSqlParser.Opt_partition_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_partition_clause([NotNull] PostgreSqlParser.Opt_partition_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_frame_clause([NotNull] PostgreSqlParser.Opt_frame_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_frame_clause([NotNull] PostgreSqlParser.Opt_frame_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.frame_extent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_extent([NotNull] PostgreSqlParser.Frame_extentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.frame_extent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_extent([NotNull] PostgreSqlParser.Frame_extentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.frame_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_bound([NotNull] PostgreSqlParser.Frame_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.frame_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_bound([NotNull] PostgreSqlParser.Frame_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_window_exclusion_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_window_exclusion_clause([NotNull] PostgreSqlParser.Opt_window_exclusion_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_window_exclusion_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_window_exclusion_clause([NotNull] PostgreSqlParser.Opt_window_exclusion_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow([NotNull] PostgreSqlParser.RowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow([NotNull] PostgreSqlParser.RowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.explicit_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicit_row([NotNull] PostgreSqlParser.Explicit_rowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.explicit_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicit_row([NotNull] PostgreSqlParser.Explicit_rowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.implicit_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImplicit_row([NotNull] PostgreSqlParser.Implicit_rowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.implicit_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImplicit_row([NotNull] PostgreSqlParser.Implicit_rowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sub_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSub_type([NotNull] PostgreSqlParser.Sub_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sub_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSub_type([NotNull] PostgreSqlParser.Sub_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.all_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAll_op([NotNull] PostgreSqlParser.All_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.all_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAll_op([NotNull] PostgreSqlParser.All_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.mathop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathop([NotNull] PostgreSqlParser.MathopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.mathop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathop([NotNull] PostgreSqlParser.MathopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qual_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQual_op([NotNull] PostgreSqlParser.Qual_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qual_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQual_op([NotNull] PostgreSqlParser.Qual_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qual_all_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQual_all_op([NotNull] PostgreSqlParser.Qual_all_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qual_all_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQual_all_op([NotNull] PostgreSqlParser.Qual_all_opContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.subquery_Op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_Op([NotNull] PostgreSqlParser.Subquery_OpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.subquery_Op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_Op([NotNull] PostgreSqlParser.Subquery_OpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_list([NotNull] PostgreSqlParser.Expr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_list([NotNull] PostgreSqlParser.Expr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_arg_list([NotNull] PostgreSqlParser.Func_arg_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_arg_list([NotNull] PostgreSqlParser.Func_arg_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_arg_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_arg_expr([NotNull] PostgreSqlParser.Func_arg_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_arg_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_arg_expr([NotNull] PostgreSqlParser.Func_arg_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_list([NotNull] PostgreSqlParser.Type_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_list([NotNull] PostgreSqlParser.Type_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.array_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_expr([NotNull] PostgreSqlParser.Array_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.array_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_expr([NotNull] PostgreSqlParser.Array_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.array_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_expr_list([NotNull] PostgreSqlParser.Array_expr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.array_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_expr_list([NotNull] PostgreSqlParser.Array_expr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.extract_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtract_list([NotNull] PostgreSqlParser.Extract_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.extract_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtract_list([NotNull] PostgreSqlParser.Extract_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.extract_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtract_arg([NotNull] PostgreSqlParser.Extract_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.extract_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtract_arg([NotNull] PostgreSqlParser.Extract_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unicode_normal_form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnicode_normal_form([NotNull] PostgreSqlParser.Unicode_normal_formContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unicode_normal_form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnicode_normal_form([NotNull] PostgreSqlParser.Unicode_normal_formContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.overlay_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverlay_list([NotNull] PostgreSqlParser.Overlay_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.overlay_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverlay_list([NotNull] PostgreSqlParser.Overlay_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.position_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPosition_list([NotNull] PostgreSqlParser.Position_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.position_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPosition_list([NotNull] PostgreSqlParser.Position_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.substr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstr_list([NotNull] PostgreSqlParser.Substr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.substr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstr_list([NotNull] PostgreSqlParser.Substr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.trim_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrim_list([NotNull] PostgreSqlParser.Trim_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.trim_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrim_list([NotNull] PostgreSqlParser.Trim_listContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>in_expr_select</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIn_expr_select([NotNull] PostgreSqlParser.In_expr_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>in_expr_select</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIn_expr_select([NotNull] PostgreSqlParser.In_expr_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>in_expr_list</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIn_expr_list([NotNull] PostgreSqlParser.In_expr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>in_expr_list</c>
	/// labeled alternative in <see cref="PostgreSqlParser.in_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIn_expr_list([NotNull] PostgreSqlParser.In_expr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_expr([NotNull] PostgreSqlParser.Case_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_expr([NotNull] PostgreSqlParser.Case_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.when_clause_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhen_clause_list([NotNull] PostgreSqlParser.When_clause_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.when_clause_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhen_clause_list([NotNull] PostgreSqlParser.When_clause_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.when_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhen_clause([NotNull] PostgreSqlParser.When_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.when_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhen_clause([NotNull] PostgreSqlParser.When_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_default([NotNull] PostgreSqlParser.Case_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_default([NotNull] PostgreSqlParser.Case_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_arg([NotNull] PostgreSqlParser.Case_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_arg([NotNull] PostgreSqlParser.Case_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.columnref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnref([NotNull] PostgreSqlParser.ColumnrefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.columnref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnref([NotNull] PostgreSqlParser.ColumnrefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indirection_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndirection_el([NotNull] PostgreSqlParser.Indirection_elContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indirection_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndirection_el([NotNull] PostgreSqlParser.Indirection_elContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_slice_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_slice_bound([NotNull] PostgreSqlParser.Opt_slice_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_slice_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_slice_bound([NotNull] PostgreSqlParser.Opt_slice_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.indirection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndirection([NotNull] PostgreSqlParser.IndirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.indirection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndirection([NotNull] PostgreSqlParser.IndirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_indirection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_indirection([NotNull] PostgreSqlParser.Opt_indirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_indirection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_indirection([NotNull] PostgreSqlParser.Opt_indirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_target_list([NotNull] PostgreSqlParser.Opt_target_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_target_list([NotNull] PostgreSqlParser.Opt_target_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget_list([NotNull] PostgreSqlParser.Target_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.target_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget_list([NotNull] PostgreSqlParser.Target_listContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>target_label</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget_label([NotNull] PostgreSqlParser.Target_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>target_label</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget_label([NotNull] PostgreSqlParser.Target_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>target_star</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget_star([NotNull] PostgreSqlParser.Target_starContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>target_star</c>
	/// labeled alternative in <see cref="PostgreSqlParser.target_el"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget_star([NotNull] PostgreSqlParser.Target_starContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qualified_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_name_list([NotNull] PostgreSqlParser.Qualified_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qualified_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_name_list([NotNull] PostgreSqlParser.Qualified_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.qualified_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_name([NotNull] PostgreSqlParser.Qualified_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.qualified_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_name([NotNull] PostgreSqlParser.Qualified_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName_list([NotNull] PostgreSqlParser.Name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName_list([NotNull] PostgreSqlParser.Name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] PostgreSqlParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] PostgreSqlParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.attr_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttr_name([NotNull] PostgreSqlParser.Attr_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.attr_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttr_name([NotNull] PostgreSqlParser.Attr_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_name([NotNull] PostgreSqlParser.File_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_name([NotNull] PostgreSqlParser.File_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.func_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_name([NotNull] PostgreSqlParser.Func_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.func_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_name([NotNull] PostgreSqlParser.Func_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.aexprconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAexprconst([NotNull] PostgreSqlParser.AexprconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.aexprconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAexprconst([NotNull] PostgreSqlParser.AexprconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.xconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXconst([NotNull] PostgreSqlParser.XconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.xconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXconst([NotNull] PostgreSqlParser.XconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.bconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBconst([NotNull] PostgreSqlParser.BconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.bconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBconst([NotNull] PostgreSqlParser.BconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.fconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFconst([NotNull] PostgreSqlParser.FconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.fconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFconst([NotNull] PostgreSqlParser.FconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.iconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIconst([NotNull] PostgreSqlParser.IconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.iconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIconst([NotNull] PostgreSqlParser.IconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSconst([NotNull] PostgreSqlParser.SconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSconst([NotNull] PostgreSqlParser.SconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.anysconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnysconst([NotNull] PostgreSqlParser.AnysconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.anysconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnysconst([NotNull] PostgreSqlParser.AnysconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_uescape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_uescape([NotNull] PostgreSqlParser.Opt_uescapeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_uescape"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_uescape([NotNull] PostgreSqlParser.Opt_uescapeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.signediconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignediconst([NotNull] PostgreSqlParser.SignediconstContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.signediconst"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignediconst([NotNull] PostgreSqlParser.SignediconstContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.roleid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleid([NotNull] PostgreSqlParser.RoleidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.roleid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleid([NotNull] PostgreSqlParser.RoleidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.rolespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRolespec([NotNull] PostgreSqlParser.RolespecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.rolespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRolespec([NotNull] PostgreSqlParser.RolespecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.role_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRole_list([NotNull] PostgreSqlParser.Role_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.role_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRole_list([NotNull] PostgreSqlParser.Role_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.colid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColid([NotNull] PostgreSqlParser.ColidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.colid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColid([NotNull] PostgreSqlParser.ColidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_function_name([NotNull] PostgreSqlParser.Type_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_function_name([NotNull] PostgreSqlParser.Type_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.nonreservedword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNonreservedword([NotNull] PostgreSqlParser.NonreservedwordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.nonreservedword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNonreservedword([NotNull] PostgreSqlParser.NonreservedwordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.collabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollabel([NotNull] PostgreSqlParser.CollabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.collabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollabel([NotNull] PostgreSqlParser.CollabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] PostgreSqlParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] PostgreSqlParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsqlidentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsqlidentifier([NotNull] PostgreSqlParser.PlsqlidentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsqlidentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsqlidentifier([NotNull] PostgreSqlParser.PlsqlidentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.unreserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnreserved_keyword([NotNull] PostgreSqlParser.Unreserved_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.unreserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnreserved_keyword([NotNull] PostgreSqlParser.Unreserved_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.col_name_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCol_name_keyword([NotNull] PostgreSqlParser.Col_name_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.col_name_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCol_name_keyword([NotNull] PostgreSqlParser.Col_name_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.type_func_name_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_func_name_keyword([NotNull] PostgreSqlParser.Type_func_name_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.type_func_name_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_func_name_keyword([NotNull] PostgreSqlParser.Type_func_name_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.reserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReserved_keyword([NotNull] PostgreSqlParser.Reserved_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.reserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReserved_keyword([NotNull] PostgreSqlParser.Reserved_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.pl_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPl_function([NotNull] PostgreSqlParser.Pl_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.pl_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPl_function([NotNull] PostgreSqlParser.Pl_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comp_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_options([NotNull] PostgreSqlParser.Comp_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comp_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_options([NotNull] PostgreSqlParser.Comp_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.comp_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_option([NotNull] PostgreSqlParser.Comp_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.comp_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_option([NotNull] PostgreSqlParser.Comp_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sharp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSharp([NotNull] PostgreSqlParser.SharpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sharp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSharp([NotNull] PostgreSqlParser.SharpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.option_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption_value([NotNull] PostgreSqlParser.Option_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.option_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption_value([NotNull] PostgreSqlParser.Option_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_semi([NotNull] PostgreSqlParser.Opt_semiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_semi([NotNull] PostgreSqlParser.Opt_semiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.pl_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPl_block([NotNull] PostgreSqlParser.Pl_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.pl_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPl_block([NotNull] PostgreSqlParser.Pl_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_sect([NotNull] PostgreSqlParser.Decl_sectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_sect([NotNull] PostgreSqlParser.Decl_sectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_start([NotNull] PostgreSqlParser.Decl_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_start([NotNull] PostgreSqlParser.Decl_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_stmts([NotNull] PostgreSqlParser.Decl_stmtsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_stmts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_stmts([NotNull] PostgreSqlParser.Decl_stmtsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.label_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel_decl([NotNull] PostgreSqlParser.Label_declContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.label_decl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel_decl([NotNull] PostgreSqlParser.Label_declContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_stmt([NotNull] PostgreSqlParser.Decl_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_stmt([NotNull] PostgreSqlParser.Decl_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_statement([NotNull] PostgreSqlParser.Decl_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_statement([NotNull] PostgreSqlParser.Decl_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scrollable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_scrollable([NotNull] PostgreSqlParser.Opt_scrollableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scrollable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_scrollable([NotNull] PostgreSqlParser.Opt_scrollableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_cursor_query([NotNull] PostgreSqlParser.Decl_cursor_queryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_cursor_query([NotNull] PostgreSqlParser.Decl_cursor_queryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_cursor_args([NotNull] PostgreSqlParser.Decl_cursor_argsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_cursor_args([NotNull] PostgreSqlParser.Decl_cursor_argsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arglist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_cursor_arglist([NotNull] PostgreSqlParser.Decl_cursor_arglistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arglist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_cursor_arglist([NotNull] PostgreSqlParser.Decl_cursor_arglistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_cursor_arg([NotNull] PostgreSqlParser.Decl_cursor_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_cursor_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_cursor_arg([NotNull] PostgreSqlParser.Decl_cursor_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_is_for"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_is_for([NotNull] PostgreSqlParser.Decl_is_forContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_is_for"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_is_for([NotNull] PostgreSqlParser.Decl_is_forContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_aliasitem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_aliasitem([NotNull] PostgreSqlParser.Decl_aliasitemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_aliasitem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_aliasitem([NotNull] PostgreSqlParser.Decl_aliasitemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_varname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_varname([NotNull] PostgreSqlParser.Decl_varnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_varname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_varname([NotNull] PostgreSqlParser.Decl_varnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_const([NotNull] PostgreSqlParser.Decl_constContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_const"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_const([NotNull] PostgreSqlParser.Decl_constContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_datatype([NotNull] PostgreSqlParser.Decl_datatypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_datatype([NotNull] PostgreSqlParser.Decl_datatypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_collate([NotNull] PostgreSqlParser.Decl_collateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_collate([NotNull] PostgreSqlParser.Decl_collateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_notnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_notnull([NotNull] PostgreSqlParser.Decl_notnullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_notnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_notnull([NotNull] PostgreSqlParser.Decl_notnullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_defval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_defval([NotNull] PostgreSqlParser.Decl_defvalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_defval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_defval([NotNull] PostgreSqlParser.Decl_defvalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.decl_defkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecl_defkey([NotNull] PostgreSqlParser.Decl_defkeyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.decl_defkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecl_defkey([NotNull] PostgreSqlParser.Decl_defkeyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.assign_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign_operator([NotNull] PostgreSqlParser.Assign_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.assign_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign_operator([NotNull] PostgreSqlParser.Assign_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_sect([NotNull] PostgreSqlParser.Proc_sectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_sect([NotNull] PostgreSqlParser.Proc_sectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_stmt([NotNull] PostgreSqlParser.Proc_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_stmt([NotNull] PostgreSqlParser.Proc_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_perform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_perform([NotNull] PostgreSqlParser.Stmt_performContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_perform"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_perform([NotNull] PostgreSqlParser.Stmt_performContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_call([NotNull] PostgreSqlParser.Stmt_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_call([NotNull] PostgreSqlParser.Stmt_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_expr_list([NotNull] PostgreSqlParser.Opt_expr_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_expr_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_expr_list([NotNull] PostgreSqlParser.Opt_expr_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_assign([NotNull] PostgreSqlParser.Stmt_assignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_assign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_assign([NotNull] PostgreSqlParser.Stmt_assignContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_getdiag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_getdiag([NotNull] PostgreSqlParser.Stmt_getdiagContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_getdiag"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_getdiag([NotNull] PostgreSqlParser.Stmt_getdiagContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_area_opt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetdiag_area_opt([NotNull] PostgreSqlParser.Getdiag_area_optContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_area_opt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetdiag_area_opt([NotNull] PostgreSqlParser.Getdiag_area_optContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetdiag_list([NotNull] PostgreSqlParser.Getdiag_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetdiag_list([NotNull] PostgreSqlParser.Getdiag_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetdiag_list_item([NotNull] PostgreSqlParser.Getdiag_list_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetdiag_list_item([NotNull] PostgreSqlParser.Getdiag_list_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetdiag_item([NotNull] PostgreSqlParser.Getdiag_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetdiag_item([NotNull] PostgreSqlParser.Getdiag_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.getdiag_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetdiag_target([NotNull] PostgreSqlParser.Getdiag_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.getdiag_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetdiag_target([NotNull] PostgreSqlParser.Getdiag_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.assign_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssign_var([NotNull] PostgreSqlParser.Assign_varContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.assign_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssign_var([NotNull] PostgreSqlParser.Assign_varContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_if([NotNull] PostgreSqlParser.Stmt_ifContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_if"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_if([NotNull] PostgreSqlParser.Stmt_ifContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_elsifs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_elsifs([NotNull] PostgreSqlParser.Stmt_elsifsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_elsifs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_elsifs([NotNull] PostgreSqlParser.Stmt_elsifsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_else([NotNull] PostgreSqlParser.Stmt_elseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_else([NotNull] PostgreSqlParser.Stmt_elseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_case([NotNull] PostgreSqlParser.Stmt_caseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_case"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_case([NotNull] PostgreSqlParser.Stmt_caseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_expr_until_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_expr_until_when([NotNull] PostgreSqlParser.Opt_expr_until_whenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_expr_until_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_expr_until_when([NotNull] PostgreSqlParser.Opt_expr_until_whenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_when_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_when_list([NotNull] PostgreSqlParser.Case_when_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_when_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_when_list([NotNull] PostgreSqlParser.Case_when_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.case_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_when([NotNull] PostgreSqlParser.Case_whenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.case_when"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_when([NotNull] PostgreSqlParser.Case_whenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_case_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_case_else([NotNull] PostgreSqlParser.Opt_case_elseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_case_else"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_case_else([NotNull] PostgreSqlParser.Opt_case_elseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_loop([NotNull] PostgreSqlParser.Stmt_loopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_loop([NotNull] PostgreSqlParser.Stmt_loopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_while"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_while([NotNull] PostgreSqlParser.Stmt_whileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_while"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_while([NotNull] PostgreSqlParser.Stmt_whileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_for"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_for([NotNull] PostgreSqlParser.Stmt_forContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_for"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_for([NotNull] PostgreSqlParser.Stmt_forContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_control"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_control([NotNull] PostgreSqlParser.For_controlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_control"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_control([NotNull] PostgreSqlParser.For_controlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_for_using_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_for_using_expression([NotNull] PostgreSqlParser.Opt_for_using_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_for_using_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_for_using_expression([NotNull] PostgreSqlParser.Opt_for_using_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_cursor_parameters([NotNull] PostgreSqlParser.Opt_cursor_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_cursor_parameters([NotNull] PostgreSqlParser.Opt_cursor_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_reverse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_reverse([NotNull] PostgreSqlParser.Opt_reverseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_reverse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_reverse([NotNull] PostgreSqlParser.Opt_reverseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_by_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_by_expression([NotNull] PostgreSqlParser.Opt_by_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_by_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_by_expression([NotNull] PostgreSqlParser.Opt_by_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.for_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_variable([NotNull] PostgreSqlParser.For_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.for_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_variable([NotNull] PostgreSqlParser.For_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_foreach_a"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_foreach_a([NotNull] PostgreSqlParser.Stmt_foreach_aContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_foreach_a"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_foreach_a([NotNull] PostgreSqlParser.Stmt_foreach_aContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.foreach_slice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeach_slice([NotNull] PostgreSqlParser.Foreach_sliceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.foreach_slice"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeach_slice([NotNull] PostgreSqlParser.Foreach_sliceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_exit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_exit([NotNull] PostgreSqlParser.Stmt_exitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_exit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_exit([NotNull] PostgreSqlParser.Stmt_exitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exit_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExit_type([NotNull] PostgreSqlParser.Exit_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exit_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExit_type([NotNull] PostgreSqlParser.Exit_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_return([NotNull] PostgreSqlParser.Stmt_returnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_return([NotNull] PostgreSqlParser.Stmt_returnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_return_result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_return_result([NotNull] PostgreSqlParser.Opt_return_resultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_return_result"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_return_result([NotNull] PostgreSqlParser.Opt_return_resultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_raise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_raise([NotNull] PostgreSqlParser.Stmt_raiseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_raise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_raise([NotNull] PostgreSqlParser.Stmt_raiseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_raise_level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_stmt_raise_level([NotNull] PostgreSqlParser.Opt_stmt_raise_levelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_raise_level"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_stmt_raise_level([NotNull] PostgreSqlParser.Opt_stmt_raise_levelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_raise_list([NotNull] PostgreSqlParser.Opt_raise_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_raise_list([NotNull] PostgreSqlParser.Opt_raise_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_raise_using([NotNull] PostgreSqlParser.Opt_raise_usingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_raise_using([NotNull] PostgreSqlParser.Opt_raise_usingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_raise_using_elem([NotNull] PostgreSqlParser.Opt_raise_using_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_raise_using_elem([NotNull] PostgreSqlParser.Opt_raise_using_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_raise_using_elem_list([NotNull] PostgreSqlParser.Opt_raise_using_elem_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_raise_using_elem_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_raise_using_elem_list([NotNull] PostgreSqlParser.Opt_raise_using_elem_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_assert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_assert([NotNull] PostgreSqlParser.Stmt_assertContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_assert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_assert([NotNull] PostgreSqlParser.Stmt_assertContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_assert_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_stmt_assert_message([NotNull] PostgreSqlParser.Opt_stmt_assert_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_stmt_assert_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_stmt_assert_message([NotNull] PostgreSqlParser.Opt_stmt_assert_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.loop_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoop_body([NotNull] PostgreSqlParser.Loop_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.loop_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoop_body([NotNull] PostgreSqlParser.Loop_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_execsql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_execsql([NotNull] PostgreSqlParser.Stmt_execsqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_execsql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_execsql([NotNull] PostgreSqlParser.Stmt_execsqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_dynexecute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_dynexecute([NotNull] PostgreSqlParser.Stmt_dynexecuteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_dynexecute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_dynexecute([NotNull] PostgreSqlParser.Stmt_dynexecuteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_execute_using([NotNull] PostgreSqlParser.Opt_execute_usingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_execute_using([NotNull] PostgreSqlParser.Opt_execute_usingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_execute_using_list([NotNull] PostgreSqlParser.Opt_execute_using_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_using_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_execute_using_list([NotNull] PostgreSqlParser.Opt_execute_using_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_execute_into"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_execute_into([NotNull] PostgreSqlParser.Opt_execute_intoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_execute_into"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_execute_into([NotNull] PostgreSqlParser.Opt_execute_intoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_open"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_open([NotNull] PostgreSqlParser.Stmt_openContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_open"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_open([NotNull] PostgreSqlParser.Stmt_openContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_open_bound_list_item([NotNull] PostgreSqlParser.Opt_open_bound_list_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_open_bound_list_item([NotNull] PostgreSqlParser.Opt_open_bound_list_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_open_bound_list([NotNull] PostgreSqlParser.Opt_open_bound_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_bound_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_open_bound_list([NotNull] PostgreSqlParser.Opt_open_bound_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_open_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_open_using([NotNull] PostgreSqlParser.Opt_open_usingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_open_using"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_open_using([NotNull] PostgreSqlParser.Opt_open_usingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_scroll_option([NotNull] PostgreSqlParser.Opt_scroll_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_scroll_option([NotNull] PostgreSqlParser.Opt_scroll_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option_no"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_scroll_option_no([NotNull] PostgreSqlParser.Opt_scroll_option_noContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_scroll_option_no"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_scroll_option_no([NotNull] PostgreSqlParser.Opt_scroll_option_noContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_fetch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_fetch([NotNull] PostgreSqlParser.Stmt_fetchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_fetch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_fetch([NotNull] PostgreSqlParser.Stmt_fetchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.into_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInto_target([NotNull] PostgreSqlParser.Into_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.into_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInto_target([NotNull] PostgreSqlParser.Into_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_cursor_from([NotNull] PostgreSqlParser.Opt_cursor_fromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_cursor_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_cursor_from([NotNull] PostgreSqlParser.Opt_cursor_fromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_fetch_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_fetch_direction([NotNull] PostgreSqlParser.Opt_fetch_directionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_fetch_direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_fetch_direction([NotNull] PostgreSqlParser.Opt_fetch_directionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_move"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_move([NotNull] PostgreSqlParser.Stmt_moveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_move"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_move([NotNull] PostgreSqlParser.Stmt_moveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_close"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_close([NotNull] PostgreSqlParser.Stmt_closeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_close"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_close([NotNull] PostgreSqlParser.Stmt_closeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_null([NotNull] PostgreSqlParser.Stmt_nullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_null"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_null([NotNull] PostgreSqlParser.Stmt_nullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_commit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_commit([NotNull] PostgreSqlParser.Stmt_commitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_commit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_commit([NotNull] PostgreSqlParser.Stmt_commitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_rollback"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_rollback([NotNull] PostgreSqlParser.Stmt_rollbackContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_rollback"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_rollback([NotNull] PostgreSqlParser.Stmt_rollbackContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsql_opt_transaction_chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsql_opt_transaction_chain([NotNull] PostgreSqlParser.Plsql_opt_transaction_chainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsql_opt_transaction_chain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsql_opt_transaction_chain([NotNull] PostgreSqlParser.Plsql_opt_transaction_chainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.stmt_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStmt_set([NotNull] PostgreSqlParser.Stmt_setContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.stmt_set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStmt_set([NotNull] PostgreSqlParser.Stmt_setContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.cursor_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_variable([NotNull] PostgreSqlParser.Cursor_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.cursor_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_variable([NotNull] PostgreSqlParser.Cursor_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.exception_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_sect([NotNull] PostgreSqlParser.Exception_sectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.exception_sect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_sect([NotNull] PostgreSqlParser.Exception_sectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_exceptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_exceptions([NotNull] PostgreSqlParser.Proc_exceptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_exceptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_exceptions([NotNull] PostgreSqlParser.Proc_exceptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_exception"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_exception([NotNull] PostgreSqlParser.Proc_exceptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_exception"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_exception([NotNull] PostgreSqlParser.Proc_exceptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_conditions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_conditions([NotNull] PostgreSqlParser.Proc_conditionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_conditions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_conditions([NotNull] PostgreSqlParser.Proc_conditionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.proc_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_condition([NotNull] PostgreSqlParser.Proc_conditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.proc_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_condition([NotNull] PostgreSqlParser.Proc_conditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_block_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_block_label([NotNull] PostgreSqlParser.Opt_block_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_block_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_block_label([NotNull] PostgreSqlParser.Opt_block_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_loop_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_loop_label([NotNull] PostgreSqlParser.Opt_loop_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_loop_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_loop_label([NotNull] PostgreSqlParser.Opt_loop_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_label([NotNull] PostgreSqlParser.Opt_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_label([NotNull] PostgreSqlParser.Opt_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_exitcond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_exitcond([NotNull] PostgreSqlParser.Opt_exitcondContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_exitcond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_exitcond([NotNull] PostgreSqlParser.Opt_exitcondContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.any_identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_identifier([NotNull] PostgreSqlParser.Any_identifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.any_identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_identifier([NotNull] PostgreSqlParser.Any_identifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.plsql_unreserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlsql_unreserved_keyword([NotNull] PostgreSqlParser.Plsql_unreserved_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.plsql_unreserved_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlsql_unreserved_keyword([NotNull] PostgreSqlParser.Plsql_unreserved_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.sql_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_expression([NotNull] PostgreSqlParser.Sql_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.sql_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_expression([NotNull] PostgreSqlParser.Sql_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_until_then([NotNull] PostgreSqlParser.Expr_until_thenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_then"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_until_then([NotNull] PostgreSqlParser.Expr_until_thenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_until_semi([NotNull] PostgreSqlParser.Expr_until_semiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_until_semi([NotNull] PostgreSqlParser.Expr_until_semiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_rightbracket"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_until_rightbracket([NotNull] PostgreSqlParser.Expr_until_rightbracketContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_rightbracket"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_until_rightbracket([NotNull] PostgreSqlParser.Expr_until_rightbracketContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.expr_until_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_until_loop([NotNull] PostgreSqlParser.Expr_until_loopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.expr_until_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_until_loop([NotNull] PostgreSqlParser.Expr_until_loopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.make_execsql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMake_execsql_stmt([NotNull] PostgreSqlParser.Make_execsql_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.make_execsql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMake_execsql_stmt([NotNull] PostgreSqlParser.Make_execsql_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PostgreSqlParser.opt_returning_clause_into"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpt_returning_clause_into([NotNull] PostgreSqlParser.Opt_returning_clause_intoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PostgreSqlParser.opt_returning_clause_into"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpt_returning_clause_into([NotNull] PostgreSqlParser.Opt_returning_clause_intoContext context);
}
