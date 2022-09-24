using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="TSqlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ITSqlParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.tsql_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsql_file([NotNull] TSqlParser.Tsql_fileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.tsql_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsql_file([NotNull] TSqlParser.Tsql_fileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.batch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBatch([NotNull] TSqlParser.BatchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.batch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBatch([NotNull] TSqlParser.BatchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.batch_level_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBatch_level_statement([NotNull] TSqlParser.Batch_level_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.batch_level_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBatch_level_statement([NotNull] TSqlParser.Batch_level_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_clauses([NotNull] TSqlParser.Sql_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_clauses([NotNull] TSqlParser.Sql_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_clause([NotNull] TSqlParser.Dml_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_clause([NotNull] TSqlParser.Dml_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDdl_clause([NotNull] TSqlParser.Ddl_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDdl_clause([NotNull] TSqlParser.Ddl_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_statement([NotNull] TSqlParser.Backup_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_statement([NotNull] TSqlParser.Backup_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cfl_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCfl_statement([NotNull] TSqlParser.Cfl_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cfl_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCfl_statement([NotNull] TSqlParser.Cfl_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.block_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock_statement([NotNull] TSqlParser.Block_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.block_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock_statement([NotNull] TSqlParser.Block_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreak_statement([NotNull] TSqlParser.Break_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.break_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreak_statement([NotNull] TSqlParser.Break_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.continue_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinue_statement([NotNull] TSqlParser.Continue_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.continue_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinue_statement([NotNull] TSqlParser.Continue_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.goto_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGoto_statement([NotNull] TSqlParser.Goto_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.goto_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGoto_statement([NotNull] TSqlParser.Goto_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_statement([NotNull] TSqlParser.Return_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_statement([NotNull] TSqlParser.Return_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_statement([NotNull] TSqlParser.If_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_statement([NotNull] TSqlParser.If_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrow_statement([NotNull] TSqlParser.Throw_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrow_statement([NotNull] TSqlParser.Throw_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_error_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrow_error_number([NotNull] TSqlParser.Throw_error_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_error_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrow_error_number([NotNull] TSqlParser.Throw_error_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrow_message([NotNull] TSqlParser.Throw_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrow_message([NotNull] TSqlParser.Throw_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrow_state([NotNull] TSqlParser.Throw_stateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrow_state([NotNull] TSqlParser.Throw_stateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.try_catch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTry_catch_statement([NotNull] TSqlParser.Try_catch_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.try_catch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTry_catch_statement([NotNull] TSqlParser.Try_catch_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.waitfor_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWaitfor_statement([NotNull] TSqlParser.Waitfor_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.waitfor_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWaitfor_statement([NotNull] TSqlParser.Waitfor_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhile_statement([NotNull] TSqlParser.While_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.while_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhile_statement([NotNull] TSqlParser.While_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.print_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint_statement([NotNull] TSqlParser.Print_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.print_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint_statement([NotNull] TSqlParser.Print_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.raiseerror_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRaiseerror_statement([NotNull] TSqlParser.Raiseerror_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.raiseerror_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRaiseerror_statement([NotNull] TSqlParser.Raiseerror_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.empty_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmpty_statement([NotNull] TSqlParser.Empty_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.empty_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmpty_statement([NotNull] TSqlParser.Empty_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.another_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnother_statement([NotNull] TSqlParser.Another_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.another_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnother_statement([NotNull] TSqlParser.Another_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_application_role([NotNull] TSqlParser.Alter_application_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_application_role([NotNull] TSqlParser.Alter_application_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_application_role([NotNull] TSqlParser.Create_application_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_application_role([NotNull] TSqlParser.Create_application_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_aggregate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_aggregate([NotNull] TSqlParser.Drop_aggregateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_aggregate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_aggregate([NotNull] TSqlParser.Drop_aggregateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_application_role([NotNull] TSqlParser.Drop_application_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_application_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_application_role([NotNull] TSqlParser.Drop_application_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly([NotNull] TSqlParser.Alter_assemblyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly([NotNull] TSqlParser.Alter_assemblyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_start([NotNull] TSqlParser.Alter_assembly_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_start([NotNull] TSqlParser.Alter_assembly_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_clause([NotNull] TSqlParser.Alter_assembly_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_clause([NotNull] TSqlParser.Alter_assembly_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_from_clause([NotNull] TSqlParser.Alter_assembly_from_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_from_clause([NotNull] TSqlParser.Alter_assembly_from_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_from_clause_start([NotNull] TSqlParser.Alter_assembly_from_clause_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_from_clause_start([NotNull] TSqlParser.Alter_assembly_from_clause_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_drop_clause([NotNull] TSqlParser.Alter_assembly_drop_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_drop_clause([NotNull] TSqlParser.Alter_assembly_drop_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_multiple_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_drop_multiple_files([NotNull] TSqlParser.Alter_assembly_drop_multiple_filesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_multiple_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_drop_multiple_files([NotNull] TSqlParser.Alter_assembly_drop_multiple_filesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_drop([NotNull] TSqlParser.Alter_assembly_dropContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_drop([NotNull] TSqlParser.Alter_assembly_dropContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_add_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_add_clause([NotNull] TSqlParser.Alter_assembly_add_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_add_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_add_clause([NotNull] TSqlParser.Alter_assembly_add_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asssembly_add_clause_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_asssembly_add_clause_start([NotNull] TSqlParser.Alter_asssembly_add_clause_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asssembly_add_clause_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_asssembly_add_clause_start([NotNull] TSqlParser.Alter_asssembly_add_clause_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_client_file_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_client_file_clause([NotNull] TSqlParser.Alter_assembly_client_file_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_client_file_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_client_file_clause([NotNull] TSqlParser.Alter_assembly_client_file_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_file_name([NotNull] TSqlParser.Alter_assembly_file_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_file_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_file_name([NotNull] TSqlParser.Alter_assembly_file_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_file_bits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_file_bits([NotNull] TSqlParser.Alter_assembly_file_bitsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_file_bits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_file_bits([NotNull] TSqlParser.Alter_assembly_file_bitsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_as([NotNull] TSqlParser.Alter_assembly_asContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_as"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_as([NotNull] TSqlParser.Alter_assembly_asContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_with_clause([NotNull] TSqlParser.Alter_assembly_with_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_with_clause([NotNull] TSqlParser.Alter_assembly_with_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_assembly_with([NotNull] TSqlParser.Alter_assembly_withContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_with"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_assembly_with([NotNull] TSqlParser.Alter_assembly_withContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.client_assembly_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClient_assembly_specifier([NotNull] TSqlParser.Client_assembly_specifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.client_assembly_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClient_assembly_specifier([NotNull] TSqlParser.Client_assembly_specifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.assembly_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssembly_option([NotNull] TSqlParser.Assembly_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.assembly_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssembly_option([NotNull] TSqlParser.Assembly_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_file_share"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNetwork_file_share([NotNull] TSqlParser.Network_file_shareContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_file_share"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNetwork_file_share([NotNull] TSqlParser.Network_file_shareContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_computer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNetwork_computer([NotNull] TSqlParser.Network_computerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_computer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNetwork_computer([NotNull] TSqlParser.Network_computerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_file_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNetwork_file_start([NotNull] TSqlParser.Network_file_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_file_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNetwork_file_start([NotNull] TSqlParser.Network_file_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_path([NotNull] TSqlParser.File_pathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_path([NotNull] TSqlParser.File_pathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_directory_path_separator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_directory_path_separator([NotNull] TSqlParser.File_directory_path_separatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_directory_path_separator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_directory_path_separator([NotNull] TSqlParser.File_directory_path_separatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.local_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_file([NotNull] TSqlParser.Local_fileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.local_file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_file([NotNull] TSqlParser.Local_fileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.local_drive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_drive([NotNull] TSqlParser.Local_driveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.local_drive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_drive([NotNull] TSqlParser.Local_driveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.multiple_local_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiple_local_files([NotNull] TSqlParser.Multiple_local_filesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.multiple_local_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiple_local_files([NotNull] TSqlParser.Multiple_local_filesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.multiple_local_file_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiple_local_file_start([NotNull] TSqlParser.Multiple_local_file_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.multiple_local_file_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiple_local_file_start([NotNull] TSqlParser.Multiple_local_file_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_assembly([NotNull] TSqlParser.Create_assemblyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_assembly([NotNull] TSqlParser.Create_assemblyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_assembly([NotNull] TSqlParser.Drop_assemblyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_assembly"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_assembly([NotNull] TSqlParser.Drop_assemblyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_asymmetric_key([NotNull] TSqlParser.Alter_asymmetric_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_asymmetric_key([NotNull] TSqlParser.Alter_asymmetric_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_asymmetric_key_start([NotNull] TSqlParser.Alter_asymmetric_key_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_asymmetric_key_start([NotNull] TSqlParser.Alter_asymmetric_key_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsymmetric_key_option([NotNull] TSqlParser.Asymmetric_key_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsymmetric_key_option([NotNull] TSqlParser.Asymmetric_key_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_option_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsymmetric_key_option_start([NotNull] TSqlParser.Asymmetric_key_option_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_option_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsymmetric_key_option_start([NotNull] TSqlParser.Asymmetric_key_option_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_password_change_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsymmetric_key_password_change_option([NotNull] TSqlParser.Asymmetric_key_password_change_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_password_change_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsymmetric_key_password_change_option([NotNull] TSqlParser.Asymmetric_key_password_change_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_asymmetric_key([NotNull] TSqlParser.Create_asymmetric_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_asymmetric_key([NotNull] TSqlParser.Create_asymmetric_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_asymmetric_key([NotNull] TSqlParser.Drop_asymmetric_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_asymmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_asymmetric_key([NotNull] TSqlParser.Drop_asymmetric_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_authorization([NotNull] TSqlParser.Alter_authorizationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_authorization([NotNull] TSqlParser.Alter_authorizationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.authorization_grantee"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuthorization_grantee([NotNull] TSqlParser.Authorization_granteeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.authorization_grantee"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuthorization_grantee([NotNull] TSqlParser.Authorization_granteeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_to([NotNull] TSqlParser.Entity_toContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_to"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_to([NotNull] TSqlParser.Entity_toContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.colon_colon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColon_colon([NotNull] TSqlParser.Colon_colonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.colon_colon"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColon_colon([NotNull] TSqlParser.Colon_colonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_authorization_start([NotNull] TSqlParser.Alter_authorization_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_authorization_start([NotNull] TSqlParser.Alter_authorization_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_sql_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_authorization_for_sql_database([NotNull] TSqlParser.Alter_authorization_for_sql_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_sql_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_authorization_for_sql_database([NotNull] TSqlParser.Alter_authorization_for_sql_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_authorization_for_azure_dw([NotNull] TSqlParser.Alter_authorization_for_azure_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_authorization_for_azure_dw([NotNull] TSqlParser.Alter_authorization_for_azure_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_authorization_for_parallel_dw([NotNull] TSqlParser.Alter_authorization_for_parallel_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_authorization_for_parallel_dw([NotNull] TSqlParser.Alter_authorization_for_parallel_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type([NotNull] TSqlParser.Class_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type([NotNull] TSqlParser.Class_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_sql_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type_for_sql_database([NotNull] TSqlParser.Class_type_for_sql_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_sql_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type_for_sql_database([NotNull] TSqlParser.Class_type_for_sql_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type_for_azure_dw([NotNull] TSqlParser.Class_type_for_azure_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type_for_azure_dw([NotNull] TSqlParser.Class_type_for_azure_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type_for_parallel_dw([NotNull] TSqlParser.Class_type_for_parallel_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type_for_parallel_dw([NotNull] TSqlParser.Class_type_for_parallel_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_grant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type_for_grant([NotNull] TSqlParser.Class_type_for_grantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_grant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type_for_grant([NotNull] TSqlParser.Class_type_for_grantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_availability_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_availability_group([NotNull] TSqlParser.Drop_availability_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_availability_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_availability_group([NotNull] TSqlParser.Drop_availability_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_availability_group([NotNull] TSqlParser.Alter_availability_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_availability_group([NotNull] TSqlParser.Alter_availability_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_availability_group_start([NotNull] TSqlParser.Alter_availability_group_startContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_availability_group_start([NotNull] TSqlParser.Alter_availability_group_startContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_availability_group_options([NotNull] TSqlParser.Alter_availability_group_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_availability_group_options([NotNull] TSqlParser.Alter_availability_group_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ip_v4_failover"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIp_v4_failover([NotNull] TSqlParser.Ip_v4_failoverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ip_v4_failover"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIp_v4_failover([NotNull] TSqlParser.Ip_v4_failoverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ip_v6_failover"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIp_v6_failover([NotNull] TSqlParser.Ip_v6_failoverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ip_v6_failover"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIp_v6_failover([NotNull] TSqlParser.Ip_v6_failoverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_broker_priority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_broker_priority([NotNull] TSqlParser.Create_or_alter_broker_priorityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_broker_priority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_broker_priority([NotNull] TSqlParser.Create_or_alter_broker_priorityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_broker_priority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_broker_priority([NotNull] TSqlParser.Drop_broker_priorityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_broker_priority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_broker_priority([NotNull] TSqlParser.Drop_broker_priorityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_certificate([NotNull] TSqlParser.Alter_certificateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_certificate([NotNull] TSqlParser.Alter_certificateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_column_encryption_key([NotNull] TSqlParser.Alter_column_encryption_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_column_encryption_key([NotNull] TSqlParser.Alter_column_encryption_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_column_encryption_key([NotNull] TSqlParser.Create_column_encryption_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_column_encryption_key([NotNull] TSqlParser.Create_column_encryption_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_certificate([NotNull] TSqlParser.Drop_certificateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_certificate([NotNull] TSqlParser.Drop_certificateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_column_encryption_key([NotNull] TSqlParser.Drop_column_encryption_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_column_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_column_encryption_key([NotNull] TSqlParser.Drop_column_encryption_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_column_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_column_master_key([NotNull] TSqlParser.Drop_column_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_column_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_column_master_key([NotNull] TSqlParser.Drop_column_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_contract([NotNull] TSqlParser.Drop_contractContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_contract([NotNull] TSqlParser.Drop_contractContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_credential([NotNull] TSqlParser.Drop_credentialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_credential([NotNull] TSqlParser.Drop_credentialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_cryptograhic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_cryptograhic_provider([NotNull] TSqlParser.Drop_cryptograhic_providerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_cryptograhic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_cryptograhic_provider([NotNull] TSqlParser.Drop_cryptograhic_providerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_database([NotNull] TSqlParser.Drop_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_database([NotNull] TSqlParser.Drop_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_database_audit_specification([NotNull] TSqlParser.Drop_database_audit_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_database_audit_specification([NotNull] TSqlParser.Drop_database_audit_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_database_encryption_key([NotNull] TSqlParser.Drop_database_encryption_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_encryption_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_database_encryption_key([NotNull] TSqlParser.Drop_database_encryption_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_scoped_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_database_scoped_credential([NotNull] TSqlParser.Drop_database_scoped_credentialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_scoped_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_database_scoped_credential([NotNull] TSqlParser.Drop_database_scoped_credentialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_default([NotNull] TSqlParser.Drop_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_default([NotNull] TSqlParser.Drop_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_endpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_endpoint([NotNull] TSqlParser.Drop_endpointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_endpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_endpoint([NotNull] TSqlParser.Drop_endpointContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_data_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_external_data_source([NotNull] TSqlParser.Drop_external_data_sourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_data_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_external_data_source([NotNull] TSqlParser.Drop_external_data_sourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_file_format"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_external_file_format([NotNull] TSqlParser.Drop_external_file_formatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_file_format"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_external_file_format([NotNull] TSqlParser.Drop_external_file_formatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_external_library([NotNull] TSqlParser.Drop_external_libraryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_external_library([NotNull] TSqlParser.Drop_external_libraryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_external_resource_pool([NotNull] TSqlParser.Drop_external_resource_poolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_external_resource_pool([NotNull] TSqlParser.Drop_external_resource_poolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_external_table([NotNull] TSqlParser.Drop_external_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_external_table([NotNull] TSqlParser.Drop_external_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_event_notifications"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_event_notifications([NotNull] TSqlParser.Drop_event_notificationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_event_notifications"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_event_notifications([NotNull] TSqlParser.Drop_event_notificationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_event_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_event_session([NotNull] TSqlParser.Drop_event_sessionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_event_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_event_session([NotNull] TSqlParser.Drop_event_sessionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_fulltext_catalog([NotNull] TSqlParser.Drop_fulltext_catalogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_fulltext_catalog([NotNull] TSqlParser.Drop_fulltext_catalogContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_fulltext_index([NotNull] TSqlParser.Drop_fulltext_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_fulltext_index([NotNull] TSqlParser.Drop_fulltext_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_fulltext_stoplist([NotNull] TSqlParser.Drop_fulltext_stoplistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_fulltext_stoplist([NotNull] TSqlParser.Drop_fulltext_stoplistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_login"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_login([NotNull] TSqlParser.Drop_loginContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_login"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_login([NotNull] TSqlParser.Drop_loginContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_master_key([NotNull] TSqlParser.Drop_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_master_key([NotNull] TSqlParser.Drop_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_message_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_message_type([NotNull] TSqlParser.Drop_message_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_message_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_message_type([NotNull] TSqlParser.Drop_message_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_partition_function([NotNull] TSqlParser.Drop_partition_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_partition_function([NotNull] TSqlParser.Drop_partition_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_partition_scheme([NotNull] TSqlParser.Drop_partition_schemeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_partition_scheme([NotNull] TSqlParser.Drop_partition_schemeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_queue([NotNull] TSqlParser.Drop_queueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_queue([NotNull] TSqlParser.Drop_queueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_remote_service_binding([NotNull] TSqlParser.Drop_remote_service_bindingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_remote_service_binding([NotNull] TSqlParser.Drop_remote_service_bindingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_resource_pool([NotNull] TSqlParser.Drop_resource_poolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_resource_pool([NotNull] TSqlParser.Drop_resource_poolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_db_role([NotNull] TSqlParser.Drop_db_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_db_role([NotNull] TSqlParser.Drop_db_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_route"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_route([NotNull] TSqlParser.Drop_routeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_route"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_route([NotNull] TSqlParser.Drop_routeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_rule([NotNull] TSqlParser.Drop_ruleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_rule([NotNull] TSqlParser.Drop_ruleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_schema([NotNull] TSqlParser.Drop_schemaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_schema([NotNull] TSqlParser.Drop_schemaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_search_property_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_search_property_list([NotNull] TSqlParser.Drop_search_property_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_search_property_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_search_property_list([NotNull] TSqlParser.Drop_search_property_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_security_policy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_security_policy([NotNull] TSqlParser.Drop_security_policyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_security_policy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_security_policy([NotNull] TSqlParser.Drop_security_policyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_sequence([NotNull] TSqlParser.Drop_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_sequence([NotNull] TSqlParser.Drop_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_server_audit([NotNull] TSqlParser.Drop_server_auditContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_server_audit([NotNull] TSqlParser.Drop_server_auditContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_server_audit_specification([NotNull] TSqlParser.Drop_server_audit_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_server_audit_specification([NotNull] TSqlParser.Drop_server_audit_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_server_role([NotNull] TSqlParser.Drop_server_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_server_role([NotNull] TSqlParser.Drop_server_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_service([NotNull] TSqlParser.Drop_serviceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_service([NotNull] TSqlParser.Drop_serviceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_signature([NotNull] TSqlParser.Drop_signatureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_signature([NotNull] TSqlParser.Drop_signatureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_statistics_name_azure_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_statistics_name_azure_dw_and_pdw([NotNull] TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_statistics_name_azure_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_statistics_name_azure_dw_and_pdw([NotNull] TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_symmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_symmetric_key([NotNull] TSqlParser.Drop_symmetric_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_symmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_symmetric_key([NotNull] TSqlParser.Drop_symmetric_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_synonym([NotNull] TSqlParser.Drop_synonymContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_synonym([NotNull] TSqlParser.Drop_synonymContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_user([NotNull] TSqlParser.Drop_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_user([NotNull] TSqlParser.Drop_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_workload_group([NotNull] TSqlParser.Drop_workload_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_workload_group([NotNull] TSqlParser.Drop_workload_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_xml_schema_collection([NotNull] TSqlParser.Drop_xml_schema_collectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_xml_schema_collection([NotNull] TSqlParser.Drop_xml_schema_collectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.disable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisable_trigger([NotNull] TSqlParser.Disable_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.disable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisable_trigger([NotNull] TSqlParser.Disable_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.enable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnable_trigger([NotNull] TSqlParser.Enable_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.enable_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnable_trigger([NotNull] TSqlParser.Enable_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.lock_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLock_table([NotNull] TSqlParser.Lock_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.lock_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLock_table([NotNull] TSqlParser.Lock_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.truncate_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncate_table([NotNull] TSqlParser.Truncate_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.truncate_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncate_table([NotNull] TSqlParser.Truncate_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_column_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_column_master_key([NotNull] TSqlParser.Create_column_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_column_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_column_master_key([NotNull] TSqlParser.Create_column_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_credential([NotNull] TSqlParser.Alter_credentialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_credential([NotNull] TSqlParser.Alter_credentialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_credential([NotNull] TSqlParser.Create_credentialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_credential"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_credential([NotNull] TSqlParser.Create_credentialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_cryptographic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_cryptographic_provider([NotNull] TSqlParser.Alter_cryptographic_providerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_cryptographic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_cryptographic_provider([NotNull] TSqlParser.Alter_cryptographic_providerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_cryptographic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_cryptographic_provider([NotNull] TSqlParser.Create_cryptographic_providerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_cryptographic_provider"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_cryptographic_provider([NotNull] TSqlParser.Create_cryptographic_providerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_event_notification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_event_notification([NotNull] TSqlParser.Create_event_notificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_event_notification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_event_notification([NotNull] TSqlParser.Create_event_notificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_event_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_event_session([NotNull] TSqlParser.Create_or_alter_event_sessionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_event_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_event_session([NotNull] TSqlParser.Create_or_alter_event_sessionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_session_predicate_factor([NotNull] TSqlParser.Event_session_predicate_factorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_session_predicate_factor([NotNull] TSqlParser.Event_session_predicate_factorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_leaf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_session_predicate_leaf([NotNull] TSqlParser.Event_session_predicate_leafContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_leaf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_session_predicate_leaf([NotNull] TSqlParser.Event_session_predicate_leafContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_data_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_external_data_source([NotNull] TSqlParser.Alter_external_data_sourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_data_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_external_data_source([NotNull] TSqlParser.Alter_external_data_sourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_external_library([NotNull] TSqlParser.Alter_external_libraryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_external_library([NotNull] TSqlParser.Alter_external_libraryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_external_library([NotNull] TSqlParser.Create_external_libraryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_external_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_external_library([NotNull] TSqlParser.Create_external_libraryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_external_resource_pool([NotNull] TSqlParser.Alter_external_resource_poolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_external_resource_pool([NotNull] TSqlParser.Alter_external_resource_poolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_external_resource_pool([NotNull] TSqlParser.Create_external_resource_poolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_external_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_external_resource_pool([NotNull] TSqlParser.Create_external_resource_poolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_fulltext_catalog([NotNull] TSqlParser.Alter_fulltext_catalogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_fulltext_catalog([NotNull] TSqlParser.Alter_fulltext_catalogContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_fulltext_catalog([NotNull] TSqlParser.Create_fulltext_catalogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_fulltext_catalog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_fulltext_catalog([NotNull] TSqlParser.Create_fulltext_catalogContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_fulltext_stoplist([NotNull] TSqlParser.Alter_fulltext_stoplistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_fulltext_stoplist([NotNull] TSqlParser.Alter_fulltext_stoplistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_fulltext_stoplist([NotNull] TSqlParser.Create_fulltext_stoplistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_fulltext_stoplist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_fulltext_stoplist([NotNull] TSqlParser.Create_fulltext_stoplistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_login_sql_server([NotNull] TSqlParser.Alter_login_sql_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_login_sql_server([NotNull] TSqlParser.Alter_login_sql_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_login_sql_server([NotNull] TSqlParser.Create_login_sql_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_login_sql_server([NotNull] TSqlParser.Create_login_sql_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_login_azure_sql([NotNull] TSqlParser.Alter_login_azure_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_login_azure_sql([NotNull] TSqlParser.Alter_login_azure_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_login_azure_sql([NotNull] TSqlParser.Create_login_azure_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_login_azure_sql([NotNull] TSqlParser.Create_login_azure_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_login_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_login_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_login_pdw([NotNull] TSqlParser.Create_login_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_login_pdw([NotNull] TSqlParser.Create_login_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_master_key_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_master_key_sql_server([NotNull] TSqlParser.Alter_master_key_sql_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_master_key_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_master_key_sql_server([NotNull] TSqlParser.Alter_master_key_sql_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_master_key_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_master_key_sql_server([NotNull] TSqlParser.Create_master_key_sql_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_master_key_sql_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_master_key_sql_server([NotNull] TSqlParser.Create_master_key_sql_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_master_key_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_master_key_azure_sql([NotNull] TSqlParser.Alter_master_key_azure_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_master_key_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_master_key_azure_sql([NotNull] TSqlParser.Alter_master_key_azure_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_master_key_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_master_key_azure_sql([NotNull] TSqlParser.Create_master_key_azure_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_master_key_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_master_key_azure_sql([NotNull] TSqlParser.Create_master_key_azure_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_message_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_message_type([NotNull] TSqlParser.Alter_message_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_message_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_message_type([NotNull] TSqlParser.Alter_message_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_partition_function([NotNull] TSqlParser.Alter_partition_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_partition_function([NotNull] TSqlParser.Alter_partition_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_partition_scheme([NotNull] TSqlParser.Alter_partition_schemeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_partition_scheme([NotNull] TSqlParser.Alter_partition_schemeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_remote_service_binding([NotNull] TSqlParser.Alter_remote_service_bindingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_remote_service_binding([NotNull] TSqlParser.Alter_remote_service_bindingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_remote_service_binding([NotNull] TSqlParser.Create_remote_service_bindingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_remote_service_binding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_remote_service_binding([NotNull] TSqlParser.Create_remote_service_bindingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_resource_pool([NotNull] TSqlParser.Create_resource_poolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_resource_pool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_resource_pool([NotNull] TSqlParser.Create_resource_poolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_resource_governor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_resource_governor([NotNull] TSqlParser.Alter_resource_governorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_resource_governor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_resource_governor([NotNull] TSqlParser.Alter_resource_governorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_db_role([NotNull] TSqlParser.Alter_db_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_db_role([NotNull] TSqlParser.Alter_db_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_db_role([NotNull] TSqlParser.Create_db_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_db_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_db_role([NotNull] TSqlParser.Create_db_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_route"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_route([NotNull] TSqlParser.Create_routeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_route"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_route([NotNull] TSqlParser.Create_routeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_rule([NotNull] TSqlParser.Create_ruleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_rule([NotNull] TSqlParser.Create_ruleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_schema_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_schema_sql([NotNull] TSqlParser.Alter_schema_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_schema_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_schema_sql([NotNull] TSqlParser.Alter_schema_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_schema([NotNull] TSqlParser.Create_schemaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_schema([NotNull] TSqlParser.Create_schemaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_schema_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_schema_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_schema_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_schema_azure_sql_dw_and_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_search_property_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_search_property_list([NotNull] TSqlParser.Create_search_property_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_search_property_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_search_property_list([NotNull] TSqlParser.Create_search_property_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_security_policy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_security_policy([NotNull] TSqlParser.Create_security_policyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_security_policy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_security_policy([NotNull] TSqlParser.Create_security_policyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_sequence([NotNull] TSqlParser.Alter_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_sequence([NotNull] TSqlParser.Alter_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_sequence([NotNull] TSqlParser.Create_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_sequence([NotNull] TSqlParser.Create_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_server_audit([NotNull] TSqlParser.Alter_server_auditContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_server_audit([NotNull] TSqlParser.Alter_server_auditContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_server_audit([NotNull] TSqlParser.Create_server_auditContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_audit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_server_audit([NotNull] TSqlParser.Create_server_auditContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_server_audit_specification([NotNull] TSqlParser.Alter_server_audit_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_server_audit_specification([NotNull] TSqlParser.Alter_server_audit_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_server_audit_specification([NotNull] TSqlParser.Create_server_audit_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_audit_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_server_audit_specification([NotNull] TSqlParser.Create_server_audit_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_server_configuration([NotNull] TSqlParser.Alter_server_configurationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_configuration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_server_configuration([NotNull] TSqlParser.Alter_server_configurationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_server_role([NotNull] TSqlParser.Alter_server_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_server_role([NotNull] TSqlParser.Alter_server_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_server_role([NotNull] TSqlParser.Create_server_roleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_server_role([NotNull] TSqlParser.Create_server_roleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_role_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_server_role_pdw([NotNull] TSqlParser.Alter_server_role_pdwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_role_pdw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_server_role_pdw([NotNull] TSqlParser.Alter_server_role_pdwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_service([NotNull] TSqlParser.Alter_serviceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_service([NotNull] TSqlParser.Alter_serviceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_service([NotNull] TSqlParser.Create_serviceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_service([NotNull] TSqlParser.Create_serviceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_service_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_service_master_key([NotNull] TSqlParser.Alter_service_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_service_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_service_master_key([NotNull] TSqlParser.Alter_service_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_symmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_symmetric_key([NotNull] TSqlParser.Alter_symmetric_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_symmetric_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_symmetric_key([NotNull] TSqlParser.Alter_symmetric_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_synonym([NotNull] TSqlParser.Create_synonymContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_synonym([NotNull] TSqlParser.Create_synonymContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_user([NotNull] TSqlParser.Alter_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_user([NotNull] TSqlParser.Alter_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_user([NotNull] TSqlParser.Create_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_user([NotNull] TSqlParser.Create_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_user_azure_sql_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_user_azure_sql_dw([NotNull] TSqlParser.Create_user_azure_sql_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_user_azure_sql_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_user_azure_sql_dw([NotNull] TSqlParser.Create_user_azure_sql_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_user_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_user_azure_sql([NotNull] TSqlParser.Alter_user_azure_sqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_user_azure_sql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_user_azure_sql([NotNull] TSqlParser.Alter_user_azure_sqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_workload_group([NotNull] TSqlParser.Alter_workload_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_workload_group([NotNull] TSqlParser.Alter_workload_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_workload_group([NotNull] TSqlParser.Create_workload_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_workload_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_workload_group([NotNull] TSqlParser.Create_workload_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_xml_schema_collection([NotNull] TSqlParser.Create_xml_schema_collectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_xml_schema_collection([NotNull] TSqlParser.Create_xml_schema_collectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_partition_function([NotNull] TSqlParser.Create_partition_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_partition_function([NotNull] TSqlParser.Create_partition_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_partition_scheme([NotNull] TSqlParser.Create_partition_schemeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_partition_scheme"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_partition_scheme([NotNull] TSqlParser.Create_partition_schemeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_queue([NotNull] TSqlParser.Create_queueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_queue([NotNull] TSqlParser.Create_queueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_settings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueue_settings([NotNull] TSqlParser.Queue_settingsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_settings"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueue_settings([NotNull] TSqlParser.Queue_settingsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_queue([NotNull] TSqlParser.Alter_queueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_queue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_queue([NotNull] TSqlParser.Alter_queueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueue_action([NotNull] TSqlParser.Queue_actionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueue_action([NotNull] TSqlParser.Queue_actionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_rebuild_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueue_rebuild_options([NotNull] TSqlParser.Queue_rebuild_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_rebuild_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueue_rebuild_options([NotNull] TSqlParser.Queue_rebuild_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_contract([NotNull] TSqlParser.Create_contractContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_contract"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_contract([NotNull] TSqlParser.Create_contractContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.conversation_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversation_statement([NotNull] TSqlParser.Conversation_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.conversation_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversation_statement([NotNull] TSqlParser.Conversation_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.message_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessage_statement([NotNull] TSqlParser.Message_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.message_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessage_statement([NotNull] TSqlParser.Message_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_statement([NotNull] TSqlParser.Merge_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_statement([NotNull] TSqlParser.Merge_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.when_matches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhen_matches([NotNull] TSqlParser.When_matchesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.when_matches"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhen_matches([NotNull] TSqlParser.When_matchesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_matched"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_matched([NotNull] TSqlParser.Merge_matchedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_matched"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_matched([NotNull] TSqlParser.Merge_matchedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_not_matched"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_not_matched([NotNull] TSqlParser.Merge_not_matchedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_not_matched"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_not_matched([NotNull] TSqlParser.Merge_not_matchedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delete_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_statement([NotNull] TSqlParser.Delete_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delete_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_statement([NotNull] TSqlParser.Delete_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delete_statement_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_statement_from([NotNull] TSqlParser.Delete_statement_fromContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delete_statement_from"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_statement_from([NotNull] TSqlParser.Delete_statement_fromContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_statement([NotNull] TSqlParser.Insert_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_statement([NotNull] TSqlParser.Insert_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_statement_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_statement_value([NotNull] TSqlParser.Insert_statement_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_statement_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_statement_value([NotNull] TSqlParser.Insert_statement_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.receive_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReceive_statement([NotNull] TSqlParser.Receive_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.receive_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReceive_statement([NotNull] TSqlParser.Receive_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_statement_standalone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_statement_standalone([NotNull] TSqlParser.Select_statement_standaloneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_statement_standalone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_statement_standalone([NotNull] TSqlParser.Select_statement_standaloneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_statement([NotNull] TSqlParser.Select_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_statement([NotNull] TSqlParser.Select_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTime([NotNull] TSqlParser.TimeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.time"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTime([NotNull] TSqlParser.TimeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_statement([NotNull] TSqlParser.Update_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_statement([NotNull] TSqlParser.Update_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.output_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutput_clause([NotNull] TSqlParser.Output_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.output_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutput_clause([NotNull] TSqlParser.Output_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.output_dml_list_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOutput_dml_list_elem([NotNull] TSqlParser.Output_dml_list_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.output_dml_list_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOutput_dml_list_elem([NotNull] TSqlParser.Output_dml_list_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_database([NotNull] TSqlParser.Create_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_database([NotNull] TSqlParser.Create_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index([NotNull] TSqlParser.Create_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index([NotNull] TSqlParser.Create_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index_options([NotNull] TSqlParser.Create_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index_options([NotNull] TSqlParser.Create_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.relational_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_index_option([NotNull] TSqlParser.Relational_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.relational_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_index_option([NotNull] TSqlParser.Relational_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_index([NotNull] TSqlParser.Alter_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_index([NotNull] TSqlParser.Alter_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.resumable_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResumable_index_options([NotNull] TSqlParser.Resumable_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.resumable_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResumable_index_options([NotNull] TSqlParser.Resumable_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.resumable_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResumable_index_option([NotNull] TSqlParser.Resumable_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.resumable_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResumable_index_option([NotNull] TSqlParser.Resumable_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReorganize_partition([NotNull] TSqlParser.Reorganize_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReorganize_partition([NotNull] TSqlParser.Reorganize_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReorganize_options([NotNull] TSqlParser.Reorganize_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReorganize_options([NotNull] TSqlParser.Reorganize_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReorganize_option([NotNull] TSqlParser.Reorganize_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReorganize_option([NotNull] TSqlParser.Reorganize_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_index_options([NotNull] TSqlParser.Set_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_index_options([NotNull] TSqlParser.Set_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_index_option([NotNull] TSqlParser.Set_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_index_option([NotNull] TSqlParser.Set_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRebuild_partition([NotNull] TSqlParser.Rebuild_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRebuild_partition([NotNull] TSqlParser.Rebuild_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRebuild_index_options([NotNull] TSqlParser.Rebuild_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRebuild_index_options([NotNull] TSqlParser.Rebuild_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRebuild_index_option([NotNull] TSqlParser.Rebuild_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRebuild_index_option([NotNull] TSqlParser.Rebuild_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_partition_rebuild_index_options([NotNull] TSqlParser.Single_partition_rebuild_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_partition_rebuild_index_options([NotNull] TSqlParser.Single_partition_rebuild_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_partition_rebuild_index_option([NotNull] TSqlParser.Single_partition_rebuild_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_partition_rebuild_index_option([NotNull] TSqlParser.Single_partition_rebuild_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_partitions([NotNull] TSqlParser.On_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_partitions([NotNull] TSqlParser.On_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_columnstore_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_columnstore_index([NotNull] TSqlParser.Create_columnstore_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_columnstore_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_columnstore_index([NotNull] TSqlParser.Create_columnstore_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_columnstore_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_columnstore_index_options([NotNull] TSqlParser.Create_columnstore_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_columnstore_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_columnstore_index_options([NotNull] TSqlParser.Create_columnstore_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.columnstore_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnstore_index_option([NotNull] TSqlParser.Columnstore_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.columnstore_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnstore_index_option([NotNull] TSqlParser.Columnstore_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_nonclustered_columnstore_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_nonclustered_columnstore_index([NotNull] TSqlParser.Create_nonclustered_columnstore_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_nonclustered_columnstore_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_nonclustered_columnstore_index([NotNull] TSqlParser.Create_nonclustered_columnstore_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_xml_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_xml_index([NotNull] TSqlParser.Create_xml_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_xml_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_xml_index([NotNull] TSqlParser.Create_xml_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_index_options([NotNull] TSqlParser.Xml_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_index_options([NotNull] TSqlParser.Xml_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_index_option([NotNull] TSqlParser.Xml_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_index_option([NotNull] TSqlParser.Xml_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_procedure([NotNull] TSqlParser.Create_or_alter_procedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_procedure([NotNull] TSqlParser.Create_or_alter_procedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_external_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAs_external_name([NotNull] TSqlParser.As_external_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_external_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAs_external_name([NotNull] TSqlParser.As_external_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_trigger([NotNull] TSqlParser.Create_or_alter_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_trigger([NotNull] TSqlParser.Create_or_alter_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_dml_trigger([NotNull] TSqlParser.Create_or_alter_dml_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_dml_trigger([NotNull] TSqlParser.Create_or_alter_dml_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_trigger_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_trigger_option([NotNull] TSqlParser.Dml_trigger_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_trigger_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_trigger_option([NotNull] TSqlParser.Dml_trigger_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_trigger_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_trigger_operation([NotNull] TSqlParser.Dml_trigger_operationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_trigger_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_trigger_operation([NotNull] TSqlParser.Dml_trigger_operationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_ddl_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_ddl_trigger([NotNull] TSqlParser.Create_or_alter_ddl_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_ddl_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_ddl_trigger([NotNull] TSqlParser.Create_or_alter_ddl_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_trigger_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDdl_trigger_operation([NotNull] TSqlParser.Ddl_trigger_operationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_trigger_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDdl_trigger_operation([NotNull] TSqlParser.Ddl_trigger_operationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_or_alter_function([NotNull] TSqlParser.Create_or_alter_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_or_alter_function([NotNull] TSqlParser.Create_or_alter_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_body_returns_select([NotNull] TSqlParser.Func_body_returns_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_body_returns_select([NotNull] TSqlParser.Func_body_returns_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_body_returns_table([NotNull] TSqlParser.Func_body_returns_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_body_returns_table([NotNull] TSqlParser.Func_body_returns_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_scalar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_body_returns_scalar([NotNull] TSqlParser.Func_body_returns_scalarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_scalar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_body_returns_scalar([NotNull] TSqlParser.Func_body_returns_scalarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.procedure_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_param([NotNull] TSqlParser.Procedure_paramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.procedure_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_param([NotNull] TSqlParser.Procedure_paramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.procedure_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_option([NotNull] TSqlParser.Procedure_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.procedure_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_option([NotNull] TSqlParser.Procedure_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.function_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_option([NotNull] TSqlParser.Function_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.function_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_option([NotNull] TSqlParser.Function_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_statistics([NotNull] TSqlParser.Create_statisticsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_statistics([NotNull] TSqlParser.Create_statisticsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_statistics([NotNull] TSqlParser.Update_statisticsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_statistics([NotNull] TSqlParser.Update_statisticsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_statistics_options([NotNull] TSqlParser.Update_statistics_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_statistics_options([NotNull] TSqlParser.Update_statistics_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_statistics_option([NotNull] TSqlParser.Update_statistics_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_statistics_option([NotNull] TSqlParser.Update_statistics_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table([NotNull] TSqlParser.Create_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table([NotNull] TSqlParser.Create_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_indices"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_indices([NotNull] TSqlParser.Table_indicesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_indices"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_indices([NotNull] TSqlParser.Table_indicesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_options([NotNull] TSqlParser.Table_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_options([NotNull] TSqlParser.Table_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_option([NotNull] TSqlParser.Table_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_option([NotNull] TSqlParser.Table_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table_index_options([NotNull] TSqlParser.Create_table_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table_index_options([NotNull] TSqlParser.Create_table_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table_index_option([NotNull] TSqlParser.Create_table_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table_index_option([NotNull] TSqlParser.Create_table_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_view([NotNull] TSqlParser.Create_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_view([NotNull] TSqlParser.Create_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.view_attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_attribute([NotNull] TSqlParser.View_attributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.view_attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_attribute([NotNull] TSqlParser.View_attributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table([NotNull] TSqlParser.Alter_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table([NotNull] TSqlParser.Alter_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_partition([NotNull] TSqlParser.Switch_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_partition([NotNull] TSqlParser.Switch_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.low_priority_lock_wait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLow_priority_lock_wait([NotNull] TSqlParser.Low_priority_lock_waitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.low_priority_lock_wait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLow_priority_lock_wait([NotNull] TSqlParser.Low_priority_lock_waitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_database([NotNull] TSqlParser.Alter_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_database([NotNull] TSqlParser.Alter_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.add_or_modify_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_or_modify_files([NotNull] TSqlParser.Add_or_modify_filesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.add_or_modify_files"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_or_modify_files([NotNull] TSqlParser.Add_or_modify_filesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.filespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilespec([NotNull] TSqlParser.FilespecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.filespec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilespec([NotNull] TSqlParser.FilespecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.add_or_modify_filegroups"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_or_modify_filegroups([NotNull] TSqlParser.Add_or_modify_filegroupsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.add_or_modify_filegroups"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_or_modify_filegroups([NotNull] TSqlParser.Add_or_modify_filegroupsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.filegroup_updatability_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilegroup_updatability_option([NotNull] TSqlParser.Filegroup_updatability_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.filegroup_updatability_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilegroup_updatability_option([NotNull] TSqlParser.Filegroup_updatability_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_optionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_optionspec([NotNull] TSqlParser.Database_optionspecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_optionspec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_optionspec([NotNull] TSqlParser.Database_optionspecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.auto_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuto_option([NotNull] TSqlParser.Auto_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.auto_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuto_option([NotNull] TSqlParser.Auto_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_tracking_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChange_tracking_option([NotNull] TSqlParser.Change_tracking_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_tracking_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChange_tracking_option([NotNull] TSqlParser.Change_tracking_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_tracking_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChange_tracking_option_list([NotNull] TSqlParser.Change_tracking_option_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_tracking_option_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChange_tracking_option_list([NotNull] TSqlParser.Change_tracking_option_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.containment_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainment_option([NotNull] TSqlParser.Containment_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.containment_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainment_option([NotNull] TSqlParser.Containment_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_option([NotNull] TSqlParser.Cursor_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_option([NotNull] TSqlParser.Cursor_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_endpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_endpoint([NotNull] TSqlParser.Alter_endpointContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_endpoint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_endpoint([NotNull] TSqlParser.Alter_endpointContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_mirroring_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_mirroring_option([NotNull] TSqlParser.Database_mirroring_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_mirroring_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_mirroring_option([NotNull] TSqlParser.Database_mirroring_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_set_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMirroring_set_option([NotNull] TSqlParser.Mirroring_set_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_set_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMirroring_set_option([NotNull] TSqlParser.Mirroring_set_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_partner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMirroring_partner([NotNull] TSqlParser.Mirroring_partnerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_partner"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMirroring_partner([NotNull] TSqlParser.Mirroring_partnerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_witness"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMirroring_witness([NotNull] TSqlParser.Mirroring_witnessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_witness"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMirroring_witness([NotNull] TSqlParser.Mirroring_witnessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_partner_equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWitness_partner_equal([NotNull] TSqlParser.Witness_partner_equalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_partner_equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWitness_partner_equal([NotNull] TSqlParser.Witness_partner_equalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartner_option([NotNull] TSqlParser.Partner_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartner_option([NotNull] TSqlParser.Partner_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWitness_option([NotNull] TSqlParser.Witness_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWitness_option([NotNull] TSqlParser.Witness_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWitness_server([NotNull] TSqlParser.Witness_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWitness_server([NotNull] TSqlParser.Witness_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartner_server([NotNull] TSqlParser.Partner_serverContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_server"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartner_server([NotNull] TSqlParser.Partner_serverContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_host_port_seperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMirroring_host_port_seperator([NotNull] TSqlParser.Mirroring_host_port_seperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_host_port_seperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMirroring_host_port_seperator([NotNull] TSqlParser.Mirroring_host_port_seperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_server_tcp_prefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartner_server_tcp_prefix([NotNull] TSqlParser.Partner_server_tcp_prefixContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_server_tcp_prefix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartner_server_tcp_prefix([NotNull] TSqlParser.Partner_server_tcp_prefixContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.port_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPort_number([NotNull] TSqlParser.Port_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.port_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPort_number([NotNull] TSqlParser.Port_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.host"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHost([NotNull] TSqlParser.HostContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.host"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHost([NotNull] TSqlParser.HostContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.date_correlation_optimization_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDate_correlation_optimization_option([NotNull] TSqlParser.Date_correlation_optimization_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.date_correlation_optimization_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDate_correlation_optimization_option([NotNull] TSqlParser.Date_correlation_optimization_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_encryption_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDb_encryption_option([NotNull] TSqlParser.Db_encryption_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_encryption_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDb_encryption_option([NotNull] TSqlParser.Db_encryption_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_state_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDb_state_option([NotNull] TSqlParser.Db_state_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_state_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDb_state_option([NotNull] TSqlParser.Db_state_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_update_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDb_update_option([NotNull] TSqlParser.Db_update_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_update_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDb_update_option([NotNull] TSqlParser.Db_update_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_user_access_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDb_user_access_option([NotNull] TSqlParser.Db_user_access_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_user_access_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDb_user_access_option([NotNull] TSqlParser.Db_user_access_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delayed_durability_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelayed_durability_option([NotNull] TSqlParser.Delayed_durability_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delayed_durability_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelayed_durability_option([NotNull] TSqlParser.Delayed_durability_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.external_access_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternal_access_option([NotNull] TSqlParser.External_access_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.external_access_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternal_access_option([NotNull] TSqlParser.External_access_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hadr_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHadr_options([NotNull] TSqlParser.Hadr_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hadr_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHadr_options([NotNull] TSqlParser.Hadr_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mixed_page_allocation_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMixed_page_allocation_option([NotNull] TSqlParser.Mixed_page_allocation_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mixed_page_allocation_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMixed_page_allocation_option([NotNull] TSqlParser.Mixed_page_allocation_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.parameterization_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterization_option([NotNull] TSqlParser.Parameterization_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.parameterization_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterization_option([NotNull] TSqlParser.Parameterization_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.recovery_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecovery_option([NotNull] TSqlParser.Recovery_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.recovery_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecovery_option([NotNull] TSqlParser.Recovery_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.service_broker_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterService_broker_option([NotNull] TSqlParser.Service_broker_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.service_broker_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitService_broker_option([NotNull] TSqlParser.Service_broker_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.snapshot_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSnapshot_option([NotNull] TSqlParser.Snapshot_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.snapshot_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSnapshot_option([NotNull] TSqlParser.Snapshot_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_option([NotNull] TSqlParser.Sql_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_option([NotNull] TSqlParser.Sql_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.target_recovery_time_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTarget_recovery_time_option([NotNull] TSqlParser.Target_recovery_time_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.target_recovery_time_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTarget_recovery_time_option([NotNull] TSqlParser.Target_recovery_time_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.termination"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTermination([NotNull] TSqlParser.TerminationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.termination"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTermination([NotNull] TSqlParser.TerminationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_index([NotNull] TSqlParser.Drop_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_index([NotNull] TSqlParser.Drop_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_relational_or_xml_or_spatial_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_relational_or_xml_or_spatial_index([NotNull] TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_relational_or_xml_or_spatial_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_relational_or_xml_or_spatial_index([NotNull] TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_backward_compatible_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_backward_compatible_index([NotNull] TSqlParser.Drop_backward_compatible_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_backward_compatible_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_backward_compatible_index([NotNull] TSqlParser.Drop_backward_compatible_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_procedure([NotNull] TSqlParser.Drop_procedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_procedure([NotNull] TSqlParser.Drop_procedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_trigger([NotNull] TSqlParser.Drop_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_trigger([NotNull] TSqlParser.Drop_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_dml_trigger([NotNull] TSqlParser.Drop_dml_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_dml_trigger([NotNull] TSqlParser.Drop_dml_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_ddl_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_ddl_trigger([NotNull] TSqlParser.Drop_ddl_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_ddl_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_ddl_trigger([NotNull] TSqlParser.Drop_ddl_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_function([NotNull] TSqlParser.Drop_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_function([NotNull] TSqlParser.Drop_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_statistics([NotNull] TSqlParser.Drop_statisticsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_statistics([NotNull] TSqlParser.Drop_statisticsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_table([NotNull] TSqlParser.Drop_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_table([NotNull] TSqlParser.Drop_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_view([NotNull] TSqlParser.Drop_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_view([NotNull] TSqlParser.Drop_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_type([NotNull] TSqlParser.Create_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_type([NotNull] TSqlParser.Create_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_type([NotNull] TSqlParser.Drop_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_type([NotNull] TSqlParser.Drop_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rowset_function_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowset_function_limited([NotNull] TSqlParser.Rowset_function_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rowset_function_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowset_function_limited([NotNull] TSqlParser.Rowset_function_limitedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.openquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpenquery([NotNull] TSqlParser.OpenqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.openquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpenquery([NotNull] TSqlParser.OpenqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.opendatasource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpendatasource([NotNull] TSqlParser.OpendatasourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.opendatasource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpendatasource([NotNull] TSqlParser.OpendatasourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_statement([NotNull] TSqlParser.Declare_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_statement([NotNull] TSqlParser.Declare_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_declaration([NotNull] TSqlParser.Xml_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_declaration([NotNull] TSqlParser.Xml_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_statement([NotNull] TSqlParser.Cursor_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_statement([NotNull] TSqlParser.Cursor_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_database([NotNull] TSqlParser.Backup_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_database([NotNull] TSqlParser.Backup_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_log([NotNull] TSqlParser.Backup_logContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_log([NotNull] TSqlParser.Backup_logContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_certificate([NotNull] TSqlParser.Backup_certificateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_certificate([NotNull] TSqlParser.Backup_certificateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_master_key([NotNull] TSqlParser.Backup_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_master_key([NotNull] TSqlParser.Backup_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_service_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBackup_service_master_key([NotNull] TSqlParser.Backup_service_master_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_service_master_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBackup_service_master_key([NotNull] TSqlParser.Backup_service_master_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKill_statement([NotNull] TSqlParser.Kill_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKill_statement([NotNull] TSqlParser.Kill_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_process"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKill_process([NotNull] TSqlParser.Kill_processContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_process"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKill_process([NotNull] TSqlParser.Kill_processContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_query_notification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKill_query_notification([NotNull] TSqlParser.Kill_query_notificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_query_notification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKill_query_notification([NotNull] TSqlParser.Kill_query_notificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_stats_job"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKill_stats_job([NotNull] TSqlParser.Kill_stats_jobContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_stats_job"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKill_stats_job([NotNull] TSqlParser.Kill_stats_jobContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_statement([NotNull] TSqlParser.Execute_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_statement([NotNull] TSqlParser.Execute_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_body_batch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_body_batch([NotNull] TSqlParser.Execute_body_batchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_body_batch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_body_batch([NotNull] TSqlParser.Execute_body_batchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_body([NotNull] TSqlParser.Execute_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_body([NotNull] TSqlParser.Execute_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_statement_arg([NotNull] TSqlParser.Execute_statement_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_statement_arg([NotNull] TSqlParser.Execute_statement_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg_named"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_statement_arg_named([NotNull] TSqlParser.Execute_statement_arg_namedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg_named"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_statement_arg_named([NotNull] TSqlParser.Execute_statement_arg_namedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg_unnamed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_statement_arg_unnamed([NotNull] TSqlParser.Execute_statement_arg_unnamedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg_unnamed"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_statement_arg_unnamed([NotNull] TSqlParser.Execute_statement_arg_unnamedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_parameter([NotNull] TSqlParser.Execute_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_parameter([NotNull] TSqlParser.Execute_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_var_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_var_string([NotNull] TSqlParser.Execute_var_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_var_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_var_string([NotNull] TSqlParser.Execute_var_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.security_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSecurity_statement([NotNull] TSqlParser.Security_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.security_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSecurity_statement([NotNull] TSqlParser.Security_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.principal_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrincipal_id([NotNull] TSqlParser.Principal_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.principal_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrincipal_id([NotNull] TSqlParser.Principal_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_certificate([NotNull] TSqlParser.Create_certificateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_certificate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_certificate([NotNull] TSqlParser.Create_certificateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.existing_keys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExisting_keys([NotNull] TSqlParser.Existing_keysContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.existing_keys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExisting_keys([NotNull] TSqlParser.Existing_keysContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.private_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivate_key_options([NotNull] TSqlParser.Private_key_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.private_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivate_key_options([NotNull] TSqlParser.Private_key_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.generate_new_keys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenerate_new_keys([NotNull] TSqlParser.Generate_new_keysContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.generate_new_keys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenerate_new_keys([NotNull] TSqlParser.Generate_new_keysContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.date_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDate_options([NotNull] TSqlParser.Date_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.date_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDate_options([NotNull] TSqlParser.Date_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen_key([NotNull] TSqlParser.Open_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen_key([NotNull] TSqlParser.Open_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.close_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClose_key([NotNull] TSqlParser.Close_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.close_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClose_key([NotNull] TSqlParser.Close_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_key([NotNull] TSqlParser.Create_keyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_key"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_key([NotNull] TSqlParser.Create_keyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_options([NotNull] TSqlParser.Key_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_options([NotNull] TSqlParser.Key_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.algorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlgorithm([NotNull] TSqlParser.AlgorithmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.algorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlgorithm([NotNull] TSqlParser.AlgorithmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.encryption_mechanism"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEncryption_mechanism([NotNull] TSqlParser.Encryption_mechanismContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.encryption_mechanism"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEncryption_mechanism([NotNull] TSqlParser.Encryption_mechanismContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.decryption_mechanism"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecryption_mechanism([NotNull] TSqlParser.Decryption_mechanismContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.decryption_mechanism"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecryption_mechanism([NotNull] TSqlParser.Decryption_mechanismContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.grant_permission"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrant_permission([NotNull] TSqlParser.Grant_permissionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.grant_permission"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrant_permission([NotNull] TSqlParser.Grant_permissionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_statement([NotNull] TSqlParser.Set_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_statement([NotNull] TSqlParser.Set_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.transaction_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_statement([NotNull] TSqlParser.Transaction_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.transaction_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_statement([NotNull] TSqlParser.Transaction_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.go_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGo_statement([NotNull] TSqlParser.Go_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.go_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGo_statement([NotNull] TSqlParser.Go_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.use_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUse_statement([NotNull] TSqlParser.Use_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.use_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUse_statement([NotNull] TSqlParser.Use_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.setuser_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetuser_statement([NotNull] TSqlParser.Setuser_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.setuser_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetuser_statement([NotNull] TSqlParser.Setuser_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reconfigure_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReconfigure_statement([NotNull] TSqlParser.Reconfigure_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reconfigure_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReconfigure_statement([NotNull] TSqlParser.Reconfigure_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.shutdown_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShutdown_statement([NotNull] TSqlParser.Shutdown_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.shutdown_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShutdown_statement([NotNull] TSqlParser.Shutdown_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.checkpoint_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckpoint_statement([NotNull] TSqlParser.Checkpoint_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.checkpoint_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckpoint_statement([NotNull] TSqlParser.Checkpoint_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_special"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDbcc_special([NotNull] TSqlParser.Dbcc_specialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_special"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDbcc_special([NotNull] TSqlParser.Dbcc_specialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDbcc_clause([NotNull] TSqlParser.Dbcc_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDbcc_clause([NotNull] TSqlParser.Dbcc_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDbcc_command([NotNull] TSqlParser.Dbcc_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDbcc_command([NotNull] TSqlParser.Dbcc_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDbcc_options([NotNull] TSqlParser.Dbcc_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDbcc_options([NotNull] TSqlParser.Dbcc_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_clause([NotNull] TSqlParser.Execute_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_clause([NotNull] TSqlParser.Execute_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_local"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_local([NotNull] TSqlParser.Declare_localContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_local"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_local([NotNull] TSqlParser.Declare_localContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_type_definition([NotNull] TSqlParser.Table_type_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_type_definition([NotNull] TSqlParser.Table_type_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_type_indices"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_type_indices([NotNull] TSqlParser.Table_type_indicesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_type_indices"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_type_indices([NotNull] TSqlParser.Table_type_indicesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_type_definition([NotNull] TSqlParser.Xml_type_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_type_definition([NotNull] TSqlParser.Xml_type_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_schema_collection([NotNull] TSqlParser.Xml_schema_collectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_schema_collection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_schema_collection([NotNull] TSqlParser.Xml_schema_collectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_def_table_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_def_table_constraints([NotNull] TSqlParser.Column_def_table_constraintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_def_table_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_def_table_constraints([NotNull] TSqlParser.Column_def_table_constraintsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_def_table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_def_table_constraint([NotNull] TSqlParser.Column_def_table_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_def_table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_def_table_constraint([NotNull] TSqlParser.Column_def_table_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_definition([NotNull] TSqlParser.Column_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_definition([NotNull] TSqlParser.Column_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_definition_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_definition_element([NotNull] TSqlParser.Column_definition_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_definition_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_definition_element([NotNull] TSqlParser.Column_definition_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.materialized_column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaterialized_column_definition([NotNull] TSqlParser.Materialized_column_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.materialized_column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaterialized_column_definition([NotNull] TSqlParser.Materialized_column_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_constraint([NotNull] TSqlParser.Column_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_constraint([NotNull] TSqlParser.Column_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_index([NotNull] TSqlParser.Column_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_index([NotNull] TSqlParser.Column_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_partition_or_filegroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_partition_or_filegroup([NotNull] TSqlParser.On_partition_or_filegroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_partition_or_filegroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_partition_or_filegroup([NotNull] TSqlParser.On_partition_or_filegroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_constraint([NotNull] TSqlParser.Table_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_constraint([NotNull] TSqlParser.Table_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.connection_node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConnection_node([NotNull] TSqlParser.Connection_nodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.connection_node"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConnection_node([NotNull] TSqlParser.Connection_nodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.primary_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary_key_options([NotNull] TSqlParser.Primary_key_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.primary_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary_key_options([NotNull] TSqlParser.Primary_key_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.foreign_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_key_options([NotNull] TSqlParser.Foreign_key_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.foreign_key_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_key_options([NotNull] TSqlParser.Foreign_key_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.check_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheck_constraint([NotNull] TSqlParser.Check_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.check_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheck_constraint([NotNull] TSqlParser.Check_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_delete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_delete([NotNull] TSqlParser.On_deleteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_delete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_delete([NotNull] TSqlParser.On_deleteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_update"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_update([NotNull] TSqlParser.On_updateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_update"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_update([NotNull] TSqlParser.On_updateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_index_options([NotNull] TSqlParser.Alter_table_index_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table_index_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_index_options([NotNull] TSqlParser.Alter_table_index_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_index_option([NotNull] TSqlParser.Alter_table_index_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table_index_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_index_option([NotNull] TSqlParser.Alter_table_index_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_cursor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_cursor([NotNull] TSqlParser.Declare_cursorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_cursor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_cursor([NotNull] TSqlParser.Declare_cursorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_set_cursor_common([NotNull] TSqlParser.Declare_set_cursor_commonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_set_cursor_common([NotNull] TSqlParser.Declare_set_cursor_commonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common_partial"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_set_cursor_common_partial([NotNull] TSqlParser.Declare_set_cursor_common_partialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common_partial"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_set_cursor_common_partial([NotNull] TSqlParser.Declare_set_cursor_common_partialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.fetch_cursor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFetch_cursor([NotNull] TSqlParser.Fetch_cursorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.fetch_cursor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFetch_cursor([NotNull] TSqlParser.Fetch_cursorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_special"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_special([NotNull] TSqlParser.Set_specialContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_special"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_special([NotNull] TSqlParser.Set_specialContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.special_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecial_list([NotNull] TSqlParser.Special_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.special_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecial_list([NotNull] TSqlParser.Special_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant_LOCAL_ID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_LOCAL_ID([NotNull] TSqlParser.Constant_LOCAL_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant_LOCAL_ID"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_LOCAL_ID([NotNull] TSqlParser.Constant_LOCAL_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] TSqlParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] TSqlParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] TSqlParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] TSqlParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.time_zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTime_zone([NotNull] TSqlParser.Time_zoneContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.time_zone"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTime_zone([NotNull] TSqlParser.Time_zoneContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.primitive_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.primitive_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.case_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_expression([NotNull] TSqlParser.Case_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.case_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_expression([NotNull] TSqlParser.Case_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unary_operator_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator_expression([NotNull] TSqlParser.Unary_operator_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unary_operator_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator_expression([NotNull] TSqlParser.Unary_operator_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.bracket_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracket_expression([NotNull] TSqlParser.Bracket_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.bracket_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracket_expression([NotNull] TSqlParser.Bracket_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_expression([NotNull] TSqlParser.Constant_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_expression([NotNull] TSqlParser.Constant_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery([NotNull] TSqlParser.SubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery([NotNull] TSqlParser.SubqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.with_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_expression([NotNull] TSqlParser.With_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.with_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_expression([NotNull] TSqlParser.With_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_expression([NotNull] TSqlParser.Common_table_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_expression([NotNull] TSqlParser.Common_table_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_elem([NotNull] TSqlParser.Update_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_elem([NotNull] TSqlParser.Update_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_elem_merge"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_elem_merge([NotNull] TSqlParser.Update_elem_mergeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_elem_merge"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_elem_merge([NotNull] TSqlParser.Update_elem_mergeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.search_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSearch_condition([NotNull] TSqlParser.Search_conditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.search_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSearch_condition([NotNull] TSqlParser.Search_conditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicate([NotNull] TSqlParser.PredicateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicate([NotNull] TSqlParser.PredicateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_expression([NotNull] TSqlParser.Query_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_expression([NotNull] TSqlParser.Query_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_union"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_union([NotNull] TSqlParser.Sql_unionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_union"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_union([NotNull] TSqlParser.Sql_unionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_specification([NotNull] TSqlParser.Query_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_specification([NotNull] TSqlParser.Query_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTop_clause([NotNull] TSqlParser.Top_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTop_clause([NotNull] TSqlParser.Top_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_percent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTop_percent([NotNull] TSqlParser.Top_percentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_percent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTop_percent([NotNull] TSqlParser.Top_percentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_count"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTop_count([NotNull] TSqlParser.Top_countContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_count"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTop_count([NotNull] TSqlParser.Top_countContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_clause([NotNull] TSqlParser.Order_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_clause([NotNull] TSqlParser.Order_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_order_by_clause([NotNull] TSqlParser.Select_order_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_order_by_clause([NotNull] TSqlParser.Select_order_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.for_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_clause([NotNull] TSqlParser.For_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.for_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_clause([NotNull] TSqlParser.For_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_common_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_common_directives([NotNull] TSqlParser.Xml_common_directivesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_common_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_common_directives([NotNull] TSqlParser.Xml_common_directivesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.order_by_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_expression([NotNull] TSqlParser.Order_by_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.order_by_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_expression([NotNull] TSqlParser.Order_by_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.grouping_sets_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrouping_sets_item([NotNull] TSqlParser.Grouping_sets_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.grouping_sets_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrouping_sets_item([NotNull] TSqlParser.Grouping_sets_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.group_by_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_by_item([NotNull] TSqlParser.Group_by_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.group_by_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_by_item([NotNull] TSqlParser.Group_by_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.option_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption_clause([NotNull] TSqlParser.Option_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.option_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption_clause([NotNull] TSqlParser.Option_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption([NotNull] TSqlParser.OptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption([NotNull] TSqlParser.OptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.optimize_for_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptimize_for_arg([NotNull] TSqlParser.Optimize_for_argContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.optimize_for_arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptimize_for_arg([NotNull] TSqlParser.Optimize_for_argContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_list([NotNull] TSqlParser.Select_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_list([NotNull] TSqlParser.Select_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.udt_method_arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUdt_method_arguments([NotNull] TSqlParser.Udt_method_argumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.udt_method_arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUdt_method_arguments([NotNull] TSqlParser.Udt_method_argumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asterisk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsterisk([NotNull] TSqlParser.AsteriskContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asterisk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsterisk([NotNull] TSqlParser.AsteriskContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_elem([NotNull] TSqlParser.Column_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_elem([NotNull] TSqlParser.Column_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.udt_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUdt_elem([NotNull] TSqlParser.Udt_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.udt_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUdt_elem([NotNull] TSqlParser.Udt_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_elem([NotNull] TSqlParser.Expression_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_elem([NotNull] TSqlParser.Expression_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_list_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_list_elem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_sources"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_sources([NotNull] TSqlParser.Table_sourcesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_sources"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_sources([NotNull] TSqlParser.Table_sourcesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_source([NotNull] TSqlParser.Table_sourceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_source([NotNull] TSqlParser.Table_sourceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source_item_joined"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_source_item_joined([NotNull] TSqlParser.Table_source_item_joinedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source_item_joined"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_source_item_joined([NotNull] TSqlParser.Table_source_item_joinedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_source_item([NotNull] TSqlParser.Table_source_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_source_item([NotNull] TSqlParser.Table_source_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_xml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen_xml([NotNull] TSqlParser.Open_xmlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_xml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen_xml([NotNull] TSqlParser.Open_xmlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen_json([NotNull] TSqlParser.Open_jsonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_json"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen_json([NotNull] TSqlParser.Open_jsonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.json_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson_declaration([NotNull] TSqlParser.Json_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.json_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson_declaration([NotNull] TSqlParser.Json_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.json_column_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson_column_declaration([NotNull] TSqlParser.Json_column_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.json_column_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson_column_declaration([NotNull] TSqlParser.Json_column_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.schema_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_declaration([NotNull] TSqlParser.Schema_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.schema_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_declaration([NotNull] TSqlParser.Schema_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_declaration([NotNull] TSqlParser.Column_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_declaration([NotNull] TSqlParser.Column_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChange_table([NotNull] TSqlParser.Change_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChange_table([NotNull] TSqlParser.Change_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table_changes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChange_table_changes([NotNull] TSqlParser.Change_table_changesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table_changes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChange_table_changes([NotNull] TSqlParser.Change_table_changesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChange_table_version([NotNull] TSqlParser.Change_table_versionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table_version"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChange_table_version([NotNull] TSqlParser.Change_table_versionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.join_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_part([NotNull] TSqlParser.Join_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.join_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_part([NotNull] TSqlParser.Join_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.join_on"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_on([NotNull] TSqlParser.Join_onContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.join_on"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_on([NotNull] TSqlParser.Join_onContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cross_join"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCross_join([NotNull] TSqlParser.Cross_joinContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cross_join"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCross_join([NotNull] TSqlParser.Cross_joinContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.apply_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterApply_([NotNull] TSqlParser.Apply_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.apply_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitApply_([NotNull] TSqlParser.Apply_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.pivot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot([NotNull] TSqlParser.PivotContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.pivot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot([NotNull] TSqlParser.PivotContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unpivot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnpivot([NotNull] TSqlParser.UnpivotContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unpivot"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnpivot([NotNull] TSqlParser.UnpivotContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.pivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_clause([NotNull] TSqlParser.Pivot_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.pivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_clause([NotNull] TSqlParser.Pivot_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unpivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnpivot_clause([NotNull] TSqlParser.Unpivot_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unpivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnpivot_clause([NotNull] TSqlParser.Unpivot_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFull_column_name_list([NotNull] TSqlParser.Full_column_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFull_column_name_list([NotNull] TSqlParser.Full_column_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rowset_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowset_function([NotNull] TSqlParser.Rowset_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rowset_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowset_function([NotNull] TSqlParser.Rowset_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.bulk_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBulk_option([NotNull] TSqlParser.Bulk_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.bulk_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBulk_option([NotNull] TSqlParser.Bulk_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.derived_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDerived_table([NotNull] TSqlParser.Derived_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.derived_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDerived_table([NotNull] TSqlParser.Derived_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RANKING_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRANKING_WINDOWED_FUNC([NotNull] TSqlParser.RANKING_WINDOWED_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RANKING_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRANKING_WINDOWED_FUNC([NotNull] TSqlParser.RANKING_WINDOWED_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>AGGREGATE_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAGGREGATE_WINDOWED_FUNC([NotNull] TSqlParser.AGGREGATE_WINDOWED_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AGGREGATE_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAGGREGATE_WINDOWED_FUNC([NotNull] TSqlParser.AGGREGATE_WINDOWED_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ANALYTIC_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterANALYTIC_WINDOWED_FUNC([NotNull] TSqlParser.ANALYTIC_WINDOWED_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ANALYTIC_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitANALYTIC_WINDOWED_FUNC([NotNull] TSqlParser.ANALYTIC_WINDOWED_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BUILT_IN_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBUILT_IN_FUNC([NotNull] TSqlParser.BUILT_IN_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BUILT_IN_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBUILT_IN_FUNC([NotNull] TSqlParser.BUILT_IN_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SCALAR_FUNCTION</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSCALAR_FUNCTION([NotNull] TSqlParser.SCALAR_FUNCTIONContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SCALAR_FUNCTION</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSCALAR_FUNCTION([NotNull] TSqlParser.SCALAR_FUNCTIONContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FREE_TEXT</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFREE_TEXT([NotNull] TSqlParser.FREE_TEXTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FREE_TEXT</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFREE_TEXT([NotNull] TSqlParser.FREE_TEXTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PARTITION_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPARTITION_FUNC([NotNull] TSqlParser.PARTITION_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PARTITION_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPARTITION_FUNC([NotNull] TSqlParser.PARTITION_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>HIERARCHYID_METHOD</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHIERARCHYID_METHOD([NotNull] TSqlParser.HIERARCHYID_METHODContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>HIERARCHYID_METHOD</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHIERARCHYID_METHOD([NotNull] TSqlParser.HIERARCHYID_METHODContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_function([NotNull] TSqlParser.Partition_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partition_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_function([NotNull] TSqlParser.Partition_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.freetext_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFreetext_function([NotNull] TSqlParser.Freetext_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.freetext_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFreetext_function([NotNull] TSqlParser.Freetext_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.freetext_predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFreetext_predicate([NotNull] TSqlParser.Freetext_predicateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.freetext_predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFreetext_predicate([NotNull] TSqlParser.Freetext_predicateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>APP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAPP_NAME([NotNull] TSqlParser.APP_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>APP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAPP_NAME([NotNull] TSqlParser.APP_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>APPLOCK_MODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAPPLOCK_MODE([NotNull] TSqlParser.APPLOCK_MODEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>APPLOCK_MODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAPPLOCK_MODE([NotNull] TSqlParser.APPLOCK_MODEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>APPLOCK_TEST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAPPLOCK_TEST([NotNull] TSqlParser.APPLOCK_TESTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>APPLOCK_TEST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAPPLOCK_TEST([NotNull] TSqlParser.APPLOCK_TESTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ASSEMBLYPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterASSEMBLYPROPERTY([NotNull] TSqlParser.ASSEMBLYPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ASSEMBLYPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitASSEMBLYPROPERTY([NotNull] TSqlParser.ASSEMBLYPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>COL_LENGTH</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCOL_LENGTH([NotNull] TSqlParser.COL_LENGTHContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>COL_LENGTH</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCOL_LENGTH([NotNull] TSqlParser.COL_LENGTHContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>COL_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCOL_NAME([NotNull] TSqlParser.COL_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>COL_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCOL_NAME([NotNull] TSqlParser.COL_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>COLUMNPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCOLUMNPROPERTY([NotNull] TSqlParser.COLUMNPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>COLUMNPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCOLUMNPROPERTY([NotNull] TSqlParser.COLUMNPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DATABASEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDATABASEPROPERTYEX([NotNull] TSqlParser.DATABASEPROPERTYEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DATABASEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDATABASEPROPERTYEX([NotNull] TSqlParser.DATABASEPROPERTYEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DB_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDB_ID([NotNull] TSqlParser.DB_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DB_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDB_ID([NotNull] TSqlParser.DB_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDB_NAME([NotNull] TSqlParser.DB_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDB_NAME([NotNull] TSqlParser.DB_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILE_ID([NotNull] TSqlParser.FILE_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILE_ID([NotNull] TSqlParser.FILE_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_IDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILE_IDEX([NotNull] TSqlParser.FILE_IDEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_IDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILE_IDEX([NotNull] TSqlParser.FILE_IDEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILE_NAME([NotNull] TSqlParser.FILE_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILE_NAME([NotNull] TSqlParser.FILE_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUP_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILEGROUP_ID([NotNull] TSqlParser.FILEGROUP_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUP_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILEGROUP_ID([NotNull] TSqlParser.FILEGROUP_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILEGROUP_NAME([NotNull] TSqlParser.FILEGROUP_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILEGROUP_NAME([NotNull] TSqlParser.FILEGROUP_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUPPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILEGROUPPROPERTY([NotNull] TSqlParser.FILEGROUPPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUPPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILEGROUPPROPERTY([NotNull] TSqlParser.FILEGROUPPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILEPROPERTY([NotNull] TSqlParser.FILEPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILEPROPERTY([NotNull] TSqlParser.FILEPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFILEPROPERTYEX([NotNull] TSqlParser.FILEPROPERTYEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFILEPROPERTYEX([NotNull] TSqlParser.FILEPROPERTYEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FULLTEXTCATALOGPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFULLTEXTCATALOGPROPERTY([NotNull] TSqlParser.FULLTEXTCATALOGPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FULLTEXTCATALOGPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFULLTEXTCATALOGPROPERTY([NotNull] TSqlParser.FULLTEXTCATALOGPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FULLTEXTSERVICEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFULLTEXTSERVICEPROPERTY([NotNull] TSqlParser.FULLTEXTSERVICEPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FULLTEXTSERVICEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFULLTEXTSERVICEPROPERTY([NotNull] TSqlParser.FULLTEXTSERVICEPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEX_COL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterINDEX_COL([NotNull] TSqlParser.INDEX_COLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEX_COL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitINDEX_COL([NotNull] TSqlParser.INDEX_COLContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEXKEY_PROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterINDEXKEY_PROPERTY([NotNull] TSqlParser.INDEXKEY_PROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEXKEY_PROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitINDEXKEY_PROPERTY([NotNull] TSqlParser.INDEXKEY_PROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEXPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterINDEXPROPERTY([NotNull] TSqlParser.INDEXPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEXPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitINDEXPROPERTY([NotNull] TSqlParser.INDEXPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NEXT_VALUE_FOR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNEXT_VALUE_FOR([NotNull] TSqlParser.NEXT_VALUE_FORContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NEXT_VALUE_FOR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNEXT_VALUE_FOR([NotNull] TSqlParser.NEXT_VALUE_FORContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_DEFINITION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECT_DEFINITION([NotNull] TSqlParser.OBJECT_DEFINITIONContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_DEFINITION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECT_DEFINITION([NotNull] TSqlParser.OBJECT_DEFINITIONContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECT_ID([NotNull] TSqlParser.OBJECT_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECT_ID([NotNull] TSqlParser.OBJECT_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECT_NAME([NotNull] TSqlParser.OBJECT_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECT_NAME([NotNull] TSqlParser.OBJECT_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECT_SCHEMA_NAME([NotNull] TSqlParser.OBJECT_SCHEMA_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECT_SCHEMA_NAME([NotNull] TSqlParser.OBJECT_SCHEMA_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECTPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECTPROPERTY([NotNull] TSqlParser.OBJECTPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECTPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECTPROPERTY([NotNull] TSqlParser.OBJECTPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECTPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOBJECTPROPERTYEX([NotNull] TSqlParser.OBJECTPROPERTYEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECTPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOBJECTPROPERTYEX([NotNull] TSqlParser.OBJECTPROPERTYEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ORIGINAL_DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterORIGINAL_DB_NAME([NotNull] TSqlParser.ORIGINAL_DB_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ORIGINAL_DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitORIGINAL_DB_NAME([NotNull] TSqlParser.ORIGINAL_DB_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PARSENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPARSENAME([NotNull] TSqlParser.PARSENAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PARSENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPARSENAME([NotNull] TSqlParser.PARSENAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SCHEMA_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSCHEMA_ID([NotNull] TSqlParser.SCHEMA_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SCHEMA_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSCHEMA_ID([NotNull] TSqlParser.SCHEMA_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSCHEMA_NAME([NotNull] TSqlParser.SCHEMA_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSCHEMA_NAME([NotNull] TSqlParser.SCHEMA_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SCOPE_IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSCOPE_IDENTITY([NotNull] TSqlParser.SCOPE_IDENTITYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SCOPE_IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSCOPE_IDENTITY([NotNull] TSqlParser.SCOPE_IDENTITYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SERVERPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSERVERPROPERTY([NotNull] TSqlParser.SERVERPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SERVERPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSERVERPROPERTY([NotNull] TSqlParser.SERVERPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>STATS_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSTATS_DATE([NotNull] TSqlParser.STATS_DATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>STATS_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSTATS_DATE([NotNull] TSqlParser.STATS_DATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTYPE_ID([NotNull] TSqlParser.TYPE_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTYPE_ID([NotNull] TSqlParser.TYPE_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTYPE_NAME([NotNull] TSqlParser.TYPE_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTYPE_NAME([NotNull] TSqlParser.TYPE_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTYPEPROPERTY([NotNull] TSqlParser.TYPEPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTYPEPROPERTY([NotNull] TSqlParser.TYPEPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ASCII</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterASCII([NotNull] TSqlParser.ASCIIContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ASCII</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitASCII([NotNull] TSqlParser.ASCIIContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCHAR([NotNull] TSqlParser.CHARContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCHAR([NotNull] TSqlParser.CHARContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CHARINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCHARINDEX([NotNull] TSqlParser.CHARINDEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CHARINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCHARINDEX([NotNull] TSqlParser.CHARINDEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CONCAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCONCAT([NotNull] TSqlParser.CONCATContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CONCAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCONCAT([NotNull] TSqlParser.CONCATContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CONCAT_WS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCONCAT_WS([NotNull] TSqlParser.CONCAT_WSContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CONCAT_WS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCONCAT_WS([NotNull] TSqlParser.CONCAT_WSContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DIFFERENCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDIFFERENCE([NotNull] TSqlParser.DIFFERENCEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DIFFERENCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDIFFERENCE([NotNull] TSqlParser.DIFFERENCEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FORMAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFORMAT([NotNull] TSqlParser.FORMATContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FORMAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFORMAT([NotNull] TSqlParser.FORMATContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LEFT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLEFT([NotNull] TSqlParser.LEFTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LEFT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLEFT([NotNull] TSqlParser.LEFTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LEN</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLEN([NotNull] TSqlParser.LENContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LEN</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLEN([NotNull] TSqlParser.LENContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LOWER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLOWER([NotNull] TSqlParser.LOWERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LOWER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLOWER([NotNull] TSqlParser.LOWERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>LTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLTRIM([NotNull] TSqlParser.LTRIMContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>LTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLTRIM([NotNull] TSqlParser.LTRIMContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NCHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNCHAR([NotNull] TSqlParser.NCHARContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NCHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNCHAR([NotNull] TSqlParser.NCHARContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PATINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPATINDEX([NotNull] TSqlParser.PATINDEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PATINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPATINDEX([NotNull] TSqlParser.PATINDEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>QUOTENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQUOTENAME([NotNull] TSqlParser.QUOTENAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>QUOTENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQUOTENAME([NotNull] TSqlParser.QUOTENAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>REPLACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterREPLACE([NotNull] TSqlParser.REPLACEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>REPLACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitREPLACE([NotNull] TSqlParser.REPLACEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>REPLICATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterREPLICATE([NotNull] TSqlParser.REPLICATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>REPLICATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitREPLICATE([NotNull] TSqlParser.REPLICATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>REVERSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterREVERSE([NotNull] TSqlParser.REVERSEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>REVERSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitREVERSE([NotNull] TSqlParser.REVERSEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RIGHT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRIGHT([NotNull] TSqlParser.RIGHTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RIGHT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRIGHT([NotNull] TSqlParser.RIGHTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>RTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRTRIM([NotNull] TSqlParser.RTRIMContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>RTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRTRIM([NotNull] TSqlParser.RTRIMContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SOUNDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSOUNDEX([NotNull] TSqlParser.SOUNDEXContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SOUNDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSOUNDEX([NotNull] TSqlParser.SOUNDEXContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SPACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSPACE([NotNull] TSqlParser.SPACEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SPACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSPACE([NotNull] TSqlParser.SPACEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>STR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSTR([NotNull] TSqlParser.STRContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>STR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSTR([NotNull] TSqlParser.STRContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>STRINGAGG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSTRINGAGG([NotNull] TSqlParser.STRINGAGGContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>STRINGAGG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSTRINGAGG([NotNull] TSqlParser.STRINGAGGContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>STRING_ESCAPE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSTRING_ESCAPE([NotNull] TSqlParser.STRING_ESCAPEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>STRING_ESCAPE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSTRING_ESCAPE([NotNull] TSqlParser.STRING_ESCAPEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>STUFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSTUFF([NotNull] TSqlParser.STUFFContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>STUFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSTUFF([NotNull] TSqlParser.STUFFContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SUBSTRING</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSUBSTRING([NotNull] TSqlParser.SUBSTRINGContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SUBSTRING</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSUBSTRING([NotNull] TSqlParser.SUBSTRINGContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TRANSLATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTRANSLATE([NotNull] TSqlParser.TRANSLATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TRANSLATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTRANSLATE([NotNull] TSqlParser.TRANSLATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTRIM([NotNull] TSqlParser.TRIMContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTRIM([NotNull] TSqlParser.TRIMContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UNICODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUNICODE([NotNull] TSqlParser.UNICODEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UNICODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUNICODE([NotNull] TSqlParser.UNICODEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>UPPER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUPPER([NotNull] TSqlParser.UPPERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UPPER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUPPER([NotNull] TSqlParser.UPPERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>BINARY_CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBINARY_CHECKSUM([NotNull] TSqlParser.BINARY_CHECKSUMContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>BINARY_CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBINARY_CHECKSUM([NotNull] TSqlParser.BINARY_CHECKSUMContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCHECKSUM([NotNull] TSqlParser.CHECKSUMContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCHECKSUM([NotNull] TSqlParser.CHECKSUMContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>COMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCOMPRESS([NotNull] TSqlParser.COMPRESSContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>COMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCOMPRESS([NotNull] TSqlParser.COMPRESSContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CONNECTIONPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCONNECTIONPROPERTY([NotNull] TSqlParser.CONNECTIONPROPERTYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CONNECTIONPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCONNECTIONPROPERTY([NotNull] TSqlParser.CONNECTIONPROPERTYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CONTEXT_INFO</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCONTEXT_INFO([NotNull] TSqlParser.CONTEXT_INFOContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CONTEXT_INFO</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCONTEXT_INFO([NotNull] TSqlParser.CONTEXT_INFOContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_REQUEST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCURRENT_REQUEST_ID([NotNull] TSqlParser.CURRENT_REQUEST_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_REQUEST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCURRENT_REQUEST_ID([NotNull] TSqlParser.CURRENT_REQUEST_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_TRANSACTION_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCURRENT_TRANSACTION_ID([NotNull] TSqlParser.CURRENT_TRANSACTION_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_TRANSACTION_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCURRENT_TRANSACTION_ID([NotNull] TSqlParser.CURRENT_TRANSACTION_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DECOMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDECOMPRESS([NotNull] TSqlParser.DECOMPRESSContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DECOMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDECOMPRESS([NotNull] TSqlParser.DECOMPRESSContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_LINE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_LINE([NotNull] TSqlParser.ERROR_LINEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_LINE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_LINE([NotNull] TSqlParser.ERROR_LINEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_MESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_MESSAGE([NotNull] TSqlParser.ERROR_MESSAGEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_MESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_MESSAGE([NotNull] TSqlParser.ERROR_MESSAGEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_NUMBER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_NUMBER([NotNull] TSqlParser.ERROR_NUMBERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_NUMBER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_NUMBER([NotNull] TSqlParser.ERROR_NUMBERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_PROCEDURE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_PROCEDURE([NotNull] TSqlParser.ERROR_PROCEDUREContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_PROCEDURE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_PROCEDURE([NotNull] TSqlParser.ERROR_PROCEDUREContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_SEVERITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_SEVERITY([NotNull] TSqlParser.ERROR_SEVERITYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_SEVERITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_SEVERITY([NotNull] TSqlParser.ERROR_SEVERITYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterERROR_STATE([NotNull] TSqlParser.ERROR_STATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitERROR_STATE([NotNull] TSqlParser.ERROR_STATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>FORMATMESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFORMATMESSAGE([NotNull] TSqlParser.FORMATMESSAGEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>FORMATMESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFORMATMESSAGE([NotNull] TSqlParser.FORMATMESSAGEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GET_FILESTREAM_TRANSACTION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGET_FILESTREAM_TRANSACTION_CONTEXT([NotNull] TSqlParser.GET_FILESTREAM_TRANSACTION_CONTEXTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GET_FILESTREAM_TRANSACTION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGET_FILESTREAM_TRANSACTION_CONTEXT([NotNull] TSqlParser.GET_FILESTREAM_TRANSACTION_CONTEXTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GETANSINULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGETANSINULL([NotNull] TSqlParser.GETANSINULLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GETANSINULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGETANSINULL([NotNull] TSqlParser.GETANSINULLContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>HOST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHOST_ID([NotNull] TSqlParser.HOST_IDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>HOST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHOST_ID([NotNull] TSqlParser.HOST_IDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>HOST_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHOST_NAME([NotNull] TSqlParser.HOST_NAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>HOST_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHOST_NAME([NotNull] TSqlParser.HOST_NAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ISNULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterISNULL([NotNull] TSqlParser.ISNULLContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ISNULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitISNULL([NotNull] TSqlParser.ISNULLContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ISNUMERIC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterISNUMERIC([NotNull] TSqlParser.ISNUMERICContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ISNUMERIC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitISNUMERIC([NotNull] TSqlParser.ISNUMERICContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>MIN_ACTIVE_ROWVERSION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMIN_ACTIVE_ROWVERSION([NotNull] TSqlParser.MIN_ACTIVE_ROWVERSIONContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MIN_ACTIVE_ROWVERSION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMIN_ACTIVE_ROWVERSION([NotNull] TSqlParser.MIN_ACTIVE_ROWVERSIONContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NEWID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNEWID([NotNull] TSqlParser.NEWIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NEWID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNEWID([NotNull] TSqlParser.NEWIDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NEWSEQUENTIALID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNEWSEQUENTIALID([NotNull] TSqlParser.NEWSEQUENTIALIDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NEWSEQUENTIALID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNEWSEQUENTIALID([NotNull] TSqlParser.NEWSEQUENTIALIDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ROWCOUNT_BIG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterROWCOUNT_BIG([NotNull] TSqlParser.ROWCOUNT_BIGContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ROWCOUNT_BIG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitROWCOUNT_BIG([NotNull] TSqlParser.ROWCOUNT_BIGContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SESSION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSESSION_CONTEXT([NotNull] TSqlParser.SESSION_CONTEXTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SESSION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSESSION_CONTEXT([NotNull] TSqlParser.SESSION_CONTEXTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>XACT_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXACT_STATE([NotNull] TSqlParser.XACT_STATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>XACT_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXACT_STATE([NotNull] TSqlParser.XACT_STATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCAST([NotNull] TSqlParser.CASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCAST([NotNull] TSqlParser.CASTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>TRY_CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTRY_CAST([NotNull] TSqlParser.TRY_CASTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>TRY_CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTRY_CAST([NotNull] TSqlParser.TRY_CASTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CONVERT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCONVERT([NotNull] TSqlParser.CONVERTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CONVERT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCONVERT([NotNull] TSqlParser.CONVERTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>COALESCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCOALESCE([NotNull] TSqlParser.COALESCEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>COALESCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCOALESCE([NotNull] TSqlParser.COALESCEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCURRENT_DATE([NotNull] TSqlParser.CURRENT_DATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCURRENT_DATE([NotNull] TSqlParser.CURRENT_DATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_TIMESTAMP</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCURRENT_TIMESTAMP([NotNull] TSqlParser.CURRENT_TIMESTAMPContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_TIMESTAMP</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCURRENT_TIMESTAMP([NotNull] TSqlParser.CURRENT_TIMESTAMPContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCURRENT_USER([NotNull] TSqlParser.CURRENT_USERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCURRENT_USER([NotNull] TSqlParser.CURRENT_USERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEADD</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDATEADD([NotNull] TSqlParser.DATEADDContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEADD</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDATEADD([NotNull] TSqlParser.DATEADDContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEDIFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDATEDIFF([NotNull] TSqlParser.DATEDIFFContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEDIFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDATEDIFF([NotNull] TSqlParser.DATEDIFFContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DATENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDATENAME([NotNull] TSqlParser.DATENAMEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DATENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDATENAME([NotNull] TSqlParser.DATENAMEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEPART</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDATEPART([NotNull] TSqlParser.DATEPARTContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEPART</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDATEPART([NotNull] TSqlParser.DATEPARTContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GETDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGETDATE([NotNull] TSqlParser.GETDATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GETDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGETDATE([NotNull] TSqlParser.GETDATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>GETUTCDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGETUTCDATE([NotNull] TSqlParser.GETUTCDATEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>GETUTCDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGETUTCDATE([NotNull] TSqlParser.GETUTCDATEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIDENTITY([NotNull] TSqlParser.IDENTITYContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIDENTITY([NotNull] TSqlParser.IDENTITYContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>NULLIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNULLIF([NotNull] TSqlParser.NULLIFContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>NULLIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNULLIF([NotNull] TSqlParser.NULLIFContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SESSION_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSESSION_USER([NotNull] TSqlParser.SESSION_USERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SESSION_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSESSION_USER([NotNull] TSqlParser.SESSION_USERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>SYSTEM_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSYSTEM_USER([NotNull] TSqlParser.SYSTEM_USERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>SYSTEM_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSYSTEM_USER([NotNull] TSqlParser.SYSTEM_USERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUSER([NotNull] TSqlParser.USERContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUSER([NotNull] TSqlParser.USERContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>PARSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPARSE([NotNull] TSqlParser.PARSEContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>PARSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPARSE([NotNull] TSqlParser.PARSEContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>XML_DATA_TYPE_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXML_DATA_TYPE_FUNC([NotNull] TSqlParser.XML_DATA_TYPE_FUNCContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>XML_DATA_TYPE_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXML_DATA_TYPE_FUNC([NotNull] TSqlParser.XML_DATA_TYPE_FUNCContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>IIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIIF([NotNull] TSqlParser.IIFContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>IIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIIF([NotNull] TSqlParser.IIFContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_data_type_methods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_data_type_methods([NotNull] TSqlParser.Xml_data_type_methodsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_data_type_methods"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_data_type_methods([NotNull] TSqlParser.Xml_data_type_methodsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.value_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue_method([NotNull] TSqlParser.Value_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.value_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue_method([NotNull] TSqlParser.Value_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.value_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue_call([NotNull] TSqlParser.Value_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.value_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue_call([NotNull] TSqlParser.Value_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_method([NotNull] TSqlParser.Query_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_method([NotNull] TSqlParser.Query_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_call([NotNull] TSqlParser.Query_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_call([NotNull] TSqlParser.Query_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.exist_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExist_method([NotNull] TSqlParser.Exist_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.exist_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExist_method([NotNull] TSqlParser.Exist_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.exist_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExist_call([NotNull] TSqlParser.Exist_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.exist_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExist_call([NotNull] TSqlParser.Exist_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.modify_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_method([NotNull] TSqlParser.Modify_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.modify_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_method([NotNull] TSqlParser.Modify_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.modify_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_call([NotNull] TSqlParser.Modify_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.modify_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_call([NotNull] TSqlParser.Modify_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hierarchyid_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHierarchyid_call([NotNull] TSqlParser.Hierarchyid_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hierarchyid_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHierarchyid_call([NotNull] TSqlParser.Hierarchyid_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hierarchyid_static_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHierarchyid_static_method([NotNull] TSqlParser.Hierarchyid_static_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hierarchyid_static_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHierarchyid_static_method([NotNull] TSqlParser.Hierarchyid_static_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.nodes_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNodes_method([NotNull] TSqlParser.Nodes_methodContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.nodes_method"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNodes_method([NotNull] TSqlParser.Nodes_methodContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_section([NotNull] TSqlParser.Switch_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_section([NotNull] TSqlParser.Switch_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_search_condition_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_search_condition_section([NotNull] TSqlParser.Switch_search_condition_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_search_condition_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_search_condition_section([NotNull] TSqlParser.Switch_search_condition_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAs_column_alias([NotNull] TSqlParser.As_column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAs_column_alias([NotNull] TSqlParser.As_column_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAs_table_alias([NotNull] TSqlParser.As_table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAs_table_alias([NotNull] TSqlParser.As_table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] TSqlParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] TSqlParser.Table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.with_table_hints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_table_hints([NotNull] TSqlParser.With_table_hintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.with_table_hints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_table_hints([NotNull] TSqlParser.With_table_hintsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.deprecated_table_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeprecated_table_hint([NotNull] TSqlParser.Deprecated_table_hintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.deprecated_table_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeprecated_table_hint([NotNull] TSqlParser.Deprecated_table_hintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sybase_legacy_hints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSybase_legacy_hints([NotNull] TSqlParser.Sybase_legacy_hintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sybase_legacy_hints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSybase_legacy_hints([NotNull] TSqlParser.Sybase_legacy_hintsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sybase_legacy_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSybase_legacy_hint([NotNull] TSqlParser.Sybase_legacy_hintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sybase_legacy_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSybase_legacy_hint([NotNull] TSqlParser.Sybase_legacy_hintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_hint([NotNull] TSqlParser.Table_hintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_hint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_hint([NotNull] TSqlParser.Table_hintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.index_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_value([NotNull] TSqlParser.Index_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.index_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_value([NotNull] TSqlParser.Index_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_alias_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias_list([NotNull] TSqlParser.Column_alias_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_alias_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias_list([NotNull] TSqlParser.Column_alias_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias([NotNull] TSqlParser.Column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias([NotNull] TSqlParser.Column_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_value_constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_value_constructor([NotNull] TSqlParser.Table_value_constructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_value_constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_value_constructor([NotNull] TSqlParser.Table_value_constructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_list([NotNull] TSqlParser.Expression_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_list([NotNull] TSqlParser.Expression_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ranking_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRanking_windowed_function([NotNull] TSqlParser.Ranking_windowed_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ranking_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRanking_windowed_function([NotNull] TSqlParser.Ranking_windowed_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.aggregate_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_windowed_function([NotNull] TSqlParser.Aggregate_windowed_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.aggregate_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_windowed_function([NotNull] TSqlParser.Aggregate_windowed_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.analytic_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalytic_windowed_function([NotNull] TSqlParser.Analytic_windowed_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.analytic_windowed_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalytic_windowed_function([NotNull] TSqlParser.Analytic_windowed_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.all_distinct_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAll_distinct_expression([NotNull] TSqlParser.All_distinct_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.all_distinct_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAll_distinct_expression([NotNull] TSqlParser.All_distinct_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause([NotNull] TSqlParser.Over_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause([NotNull] TSqlParser.Over_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.row_or_range_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow_or_range_clause([NotNull] TSqlParser.Row_or_range_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.row_or_range_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow_or_range_clause([NotNull] TSqlParser.Row_or_range_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_extent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_frame_extent([NotNull] TSqlParser.Window_frame_extentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_extent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_frame_extent([NotNull] TSqlParser.Window_frame_extentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_frame_bound([NotNull] TSqlParser.Window_frame_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_frame_bound([NotNull] TSqlParser.Window_frame_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_preceding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_frame_preceding([NotNull] TSqlParser.Window_frame_precedingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_preceding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_frame_preceding([NotNull] TSqlParser.Window_frame_precedingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_following"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_frame_following([NotNull] TSqlParser.Window_frame_followingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_following"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_frame_following([NotNull] TSqlParser.Window_frame_followingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_database_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_database_option([NotNull] TSqlParser.Create_database_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_database_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_database_option([NotNull] TSqlParser.Create_database_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_filestream_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_filestream_option([NotNull] TSqlParser.Database_filestream_optionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_filestream_option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_filestream_option([NotNull] TSqlParser.Database_filestream_optionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_file_spec([NotNull] TSqlParser.Database_file_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_file_spec([NotNull] TSqlParser.Database_file_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_group([NotNull] TSqlParser.File_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_group([NotNull] TSqlParser.File_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_spec([NotNull] TSqlParser.File_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_spec([NotNull] TSqlParser.File_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_name([NotNull] TSqlParser.Entity_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_name([NotNull] TSqlParser.Entity_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_name_for_azure_dw([NotNull] TSqlParser.Entity_name_for_azure_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name_for_azure_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_name_for_azure_dw([NotNull] TSqlParser.Entity_name_for_azure_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEntity_name_for_parallel_dw([NotNull] TSqlParser.Entity_name_for_parallel_dwContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name_for_parallel_dw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEntity_name_for_parallel_dw([NotNull] TSqlParser.Entity_name_for_parallel_dwContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFull_table_name([NotNull] TSqlParser.Full_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFull_table_name([NotNull] TSqlParser.Full_table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_name([NotNull] TSqlParser.Table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_name([NotNull] TSqlParser.Table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.simple_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_name([NotNull] TSqlParser.Simple_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.simple_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_name([NotNull] TSqlParser.Simple_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_proc_name_schema([NotNull] TSqlParser.Func_proc_name_schemaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_proc_name_schema([NotNull] TSqlParser.Func_proc_name_schemaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_database_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_proc_name_database_schema([NotNull] TSqlParser.Func_proc_name_database_schemaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_database_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_proc_name_database_schema([NotNull] TSqlParser.Func_proc_name_database_schemaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_server_database_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_proc_name_server_database_schema([NotNull] TSqlParser.Func_proc_name_server_database_schemaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_server_database_schema"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_proc_name_server_database_schema([NotNull] TSqlParser.Func_proc_name_server_database_schemaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDdl_object([NotNull] TSqlParser.Ddl_objectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDdl_object([NotNull] TSqlParser.Ddl_objectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFull_column_name([NotNull] TSqlParser.Full_column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFull_column_name([NotNull] TSqlParser.Full_column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_name_list_with_order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name_list_with_order([NotNull] TSqlParser.Column_name_list_with_orderContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_name_list_with_order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name_list_with_order([NotNull] TSqlParser.Column_name_list_with_orderContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_column_name_list([NotNull] TSqlParser.Insert_column_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_column_name_list([NotNull] TSqlParser.Insert_column_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_column_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_column_id([NotNull] TSqlParser.Insert_column_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_column_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_column_id([NotNull] TSqlParser.Insert_column_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name_list([NotNull] TSqlParser.Column_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name_list([NotNull] TSqlParser.Column_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_name([NotNull] TSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_name([NotNull] TSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_off"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_off([NotNull] TSqlParser.On_offContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_off"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_off([NotNull] TSqlParser.On_offContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.clustered"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClustered([NotNull] TSqlParser.ClusteredContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.clustered"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClustered([NotNull] TSqlParser.ClusteredContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.null_notnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull_notnull([NotNull] TSqlParser.Null_notnullContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.null_notnull"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull_notnull([NotNull] TSqlParser.Null_notnullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.null_or_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull_or_default([NotNull] TSqlParser.Null_or_defaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.null_or_default"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull_or_default([NotNull] TSqlParser.Null_or_defaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.scalar_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScalar_function_name([NotNull] TSqlParser.Scalar_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.scalar_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScalar_function_name([NotNull] TSqlParser.Scalar_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.begin_conversation_timer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_conversation_timer([NotNull] TSqlParser.Begin_conversation_timerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.begin_conversation_timer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_conversation_timer([NotNull] TSqlParser.Begin_conversation_timerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.begin_conversation_dialog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_conversation_dialog([NotNull] TSqlParser.Begin_conversation_dialogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.begin_conversation_dialog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_conversation_dialog([NotNull] TSqlParser.Begin_conversation_dialogContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.contract_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContract_name([NotNull] TSqlParser.Contract_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.contract_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContract_name([NotNull] TSqlParser.Contract_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.service_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterService_name([NotNull] TSqlParser.Service_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.service_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitService_name([NotNull] TSqlParser.Service_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.end_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnd_conversation([NotNull] TSqlParser.End_conversationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.end_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnd_conversation([NotNull] TSqlParser.End_conversationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.waitfor_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWaitfor_conversation([NotNull] TSqlParser.Waitfor_conversationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.waitfor_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWaitfor_conversation([NotNull] TSqlParser.Waitfor_conversationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.get_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGet_conversation([NotNull] TSqlParser.Get_conversationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.get_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGet_conversation([NotNull] TSqlParser.Get_conversationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueue_id([NotNull] TSqlParser.Queue_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueue_id([NotNull] TSqlParser.Queue_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.send_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSend_conversation([NotNull] TSqlParser.Send_conversationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.send_conversation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSend_conversation([NotNull] TSqlParser.Send_conversationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.data_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterData_type([NotNull] TSqlParser.Data_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.data_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitData_type([NotNull] TSqlParser.Data_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_value([NotNull] TSqlParser.Default_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_value([NotNull] TSqlParser.Default_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] TSqlParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] TSqlParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSign([NotNull] TSqlParser.SignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSign([NotNull] TSqlParser.SignContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] TSqlParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] TSqlParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.id_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId_([NotNull] TSqlParser.Id_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.id_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId_([NotNull] TSqlParser.Id_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.simple_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_id([NotNull] TSqlParser.Simple_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.simple_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_id([NotNull] TSqlParser.Simple_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.id_or_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId_or_string([NotNull] TSqlParser.Id_or_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.id_or_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId_or_string([NotNull] TSqlParser.Id_or_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.comparison_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.comparison_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.assignment_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment_operator([NotNull] TSqlParser.Assignment_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.assignment_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment_operator([NotNull] TSqlParser.Assignment_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_size"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile_size([NotNull] TSqlParser.File_sizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_size"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile_size([NotNull] TSqlParser.File_sizeContext context);
}
