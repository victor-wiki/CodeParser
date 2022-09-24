using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ITSqlParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class TSqlParserBaseListener : ITSqlParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.tsql_file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsql_file([NotNull] TSqlParser.Tsql_fileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.tsql_file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsql_file([NotNull] TSqlParser.Tsql_fileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.batch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBatch([NotNull] TSqlParser.BatchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.batch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBatch([NotNull] TSqlParser.BatchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.batch_level_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBatch_level_statement([NotNull] TSqlParser.Batch_level_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.batch_level_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBatch_level_statement([NotNull] TSqlParser.Batch_level_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_clauses([NotNull] TSqlParser.Sql_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_clauses([NotNull] TSqlParser.Sql_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_clause([NotNull] TSqlParser.Dml_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_clause([NotNull] TSqlParser.Dml_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDdl_clause([NotNull] TSqlParser.Ddl_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDdl_clause([NotNull] TSqlParser.Ddl_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_statement([NotNull] TSqlParser.Backup_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_statement([NotNull] TSqlParser.Backup_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cfl_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCfl_statement([NotNull] TSqlParser.Cfl_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cfl_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCfl_statement([NotNull] TSqlParser.Cfl_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.block_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock_statement([NotNull] TSqlParser.Block_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.block_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock_statement([NotNull] TSqlParser.Block_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreak_statement([NotNull] TSqlParser.Break_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.break_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreak_statement([NotNull] TSqlParser.Break_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.continue_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinue_statement([NotNull] TSqlParser.Continue_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.continue_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinue_statement([NotNull] TSqlParser.Continue_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.goto_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGoto_statement([NotNull] TSqlParser.Goto_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.goto_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGoto_statement([NotNull] TSqlParser.Goto_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_statement([NotNull] TSqlParser.Return_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_statement([NotNull] TSqlParser.Return_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_statement([NotNull] TSqlParser.If_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_statement([NotNull] TSqlParser.If_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrow_statement([NotNull] TSqlParser.Throw_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrow_statement([NotNull] TSqlParser.Throw_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_error_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrow_error_number([NotNull] TSqlParser.Throw_error_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_error_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrow_error_number([NotNull] TSqlParser.Throw_error_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrow_message([NotNull] TSqlParser.Throw_messageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrow_message([NotNull] TSqlParser.Throw_messageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.throw_state"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrow_state([NotNull] TSqlParser.Throw_stateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.throw_state"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrow_state([NotNull] TSqlParser.Throw_stateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.try_catch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTry_catch_statement([NotNull] TSqlParser.Try_catch_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.try_catch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTry_catch_statement([NotNull] TSqlParser.Try_catch_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.waitfor_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWaitfor_statement([NotNull] TSqlParser.Waitfor_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.waitfor_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWaitfor_statement([NotNull] TSqlParser.Waitfor_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhile_statement([NotNull] TSqlParser.While_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.while_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhile_statement([NotNull] TSqlParser.While_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.print_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrint_statement([NotNull] TSqlParser.Print_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.print_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrint_statement([NotNull] TSqlParser.Print_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.raiseerror_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRaiseerror_statement([NotNull] TSqlParser.Raiseerror_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.raiseerror_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRaiseerror_statement([NotNull] TSqlParser.Raiseerror_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.empty_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmpty_statement([NotNull] TSqlParser.Empty_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.empty_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmpty_statement([NotNull] TSqlParser.Empty_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.another_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnother_statement([NotNull] TSqlParser.Another_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.another_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnother_statement([NotNull] TSqlParser.Another_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_application_role([NotNull] TSqlParser.Alter_application_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_application_role([NotNull] TSqlParser.Alter_application_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_application_role([NotNull] TSqlParser.Create_application_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_application_role([NotNull] TSqlParser.Create_application_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_aggregate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_aggregate([NotNull] TSqlParser.Drop_aggregateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_aggregate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_aggregate([NotNull] TSqlParser.Drop_aggregateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_application_role([NotNull] TSqlParser.Drop_application_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_application_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_application_role([NotNull] TSqlParser.Drop_application_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly([NotNull] TSqlParser.Alter_assemblyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly([NotNull] TSqlParser.Alter_assemblyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_start([NotNull] TSqlParser.Alter_assembly_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_start([NotNull] TSqlParser.Alter_assembly_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_clause([NotNull] TSqlParser.Alter_assembly_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_clause([NotNull] TSqlParser.Alter_assembly_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_from_clause([NotNull] TSqlParser.Alter_assembly_from_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_from_clause([NotNull] TSqlParser.Alter_assembly_from_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_from_clause_start([NotNull] TSqlParser.Alter_assembly_from_clause_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_from_clause_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_from_clause_start([NotNull] TSqlParser.Alter_assembly_from_clause_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_drop_clause([NotNull] TSqlParser.Alter_assembly_drop_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_drop_clause([NotNull] TSqlParser.Alter_assembly_drop_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_multiple_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_drop_multiple_files([NotNull] TSqlParser.Alter_assembly_drop_multiple_filesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop_multiple_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_drop_multiple_files([NotNull] TSqlParser.Alter_assembly_drop_multiple_filesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_drop([NotNull] TSqlParser.Alter_assembly_dropContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_drop([NotNull] TSqlParser.Alter_assembly_dropContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_add_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_add_clause([NotNull] TSqlParser.Alter_assembly_add_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_add_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_add_clause([NotNull] TSqlParser.Alter_assembly_add_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asssembly_add_clause_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_asssembly_add_clause_start([NotNull] TSqlParser.Alter_asssembly_add_clause_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asssembly_add_clause_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_asssembly_add_clause_start([NotNull] TSqlParser.Alter_asssembly_add_clause_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_client_file_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_client_file_clause([NotNull] TSqlParser.Alter_assembly_client_file_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_client_file_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_client_file_clause([NotNull] TSqlParser.Alter_assembly_client_file_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_file_name([NotNull] TSqlParser.Alter_assembly_file_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_file_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_file_name([NotNull] TSqlParser.Alter_assembly_file_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_file_bits"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_file_bits([NotNull] TSqlParser.Alter_assembly_file_bitsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_file_bits"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_file_bits([NotNull] TSqlParser.Alter_assembly_file_bitsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_as([NotNull] TSqlParser.Alter_assembly_asContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_as"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_as([NotNull] TSqlParser.Alter_assembly_asContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_with_clause([NotNull] TSqlParser.Alter_assembly_with_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_with_clause([NotNull] TSqlParser.Alter_assembly_with_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_assembly_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_assembly_with([NotNull] TSqlParser.Alter_assembly_withContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_assembly_with"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_assembly_with([NotNull] TSqlParser.Alter_assembly_withContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.client_assembly_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClient_assembly_specifier([NotNull] TSqlParser.Client_assembly_specifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.client_assembly_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClient_assembly_specifier([NotNull] TSqlParser.Client_assembly_specifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.assembly_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssembly_option([NotNull] TSqlParser.Assembly_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.assembly_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssembly_option([NotNull] TSqlParser.Assembly_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_file_share"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNetwork_file_share([NotNull] TSqlParser.Network_file_shareContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_file_share"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNetwork_file_share([NotNull] TSqlParser.Network_file_shareContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_computer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNetwork_computer([NotNull] TSqlParser.Network_computerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_computer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNetwork_computer([NotNull] TSqlParser.Network_computerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.network_file_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNetwork_file_start([NotNull] TSqlParser.Network_file_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.network_file_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNetwork_file_start([NotNull] TSqlParser.Network_file_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_path([NotNull] TSqlParser.File_pathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_path([NotNull] TSqlParser.File_pathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_directory_path_separator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_directory_path_separator([NotNull] TSqlParser.File_directory_path_separatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_directory_path_separator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_directory_path_separator([NotNull] TSqlParser.File_directory_path_separatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.local_file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_file([NotNull] TSqlParser.Local_fileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.local_file"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_file([NotNull] TSqlParser.Local_fileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.local_drive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_drive([NotNull] TSqlParser.Local_driveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.local_drive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_drive([NotNull] TSqlParser.Local_driveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.multiple_local_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiple_local_files([NotNull] TSqlParser.Multiple_local_filesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.multiple_local_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiple_local_files([NotNull] TSqlParser.Multiple_local_filesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.multiple_local_file_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiple_local_file_start([NotNull] TSqlParser.Multiple_local_file_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.multiple_local_file_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiple_local_file_start([NotNull] TSqlParser.Multiple_local_file_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_assembly([NotNull] TSqlParser.Create_assemblyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_assembly([NotNull] TSqlParser.Create_assemblyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_assembly([NotNull] TSqlParser.Drop_assemblyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_assembly"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_assembly([NotNull] TSqlParser.Drop_assemblyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_asymmetric_key([NotNull] TSqlParser.Alter_asymmetric_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_asymmetric_key([NotNull] TSqlParser.Alter_asymmetric_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_asymmetric_key_start([NotNull] TSqlParser.Alter_asymmetric_key_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_asymmetric_key_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_asymmetric_key_start([NotNull] TSqlParser.Alter_asymmetric_key_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsymmetric_key_option([NotNull] TSqlParser.Asymmetric_key_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsymmetric_key_option([NotNull] TSqlParser.Asymmetric_key_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_option_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsymmetric_key_option_start([NotNull] TSqlParser.Asymmetric_key_option_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_option_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsymmetric_key_option_start([NotNull] TSqlParser.Asymmetric_key_option_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asymmetric_key_password_change_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsymmetric_key_password_change_option([NotNull] TSqlParser.Asymmetric_key_password_change_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asymmetric_key_password_change_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsymmetric_key_password_change_option([NotNull] TSqlParser.Asymmetric_key_password_change_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_asymmetric_key([NotNull] TSqlParser.Create_asymmetric_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_asymmetric_key([NotNull] TSqlParser.Create_asymmetric_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_asymmetric_key([NotNull] TSqlParser.Drop_asymmetric_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_asymmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_asymmetric_key([NotNull] TSqlParser.Drop_asymmetric_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_authorization([NotNull] TSqlParser.Alter_authorizationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_authorization([NotNull] TSqlParser.Alter_authorizationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.authorization_grantee"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAuthorization_grantee([NotNull] TSqlParser.Authorization_granteeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.authorization_grantee"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAuthorization_grantee([NotNull] TSqlParser.Authorization_granteeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_to"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntity_to([NotNull] TSqlParser.Entity_toContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_to"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntity_to([NotNull] TSqlParser.Entity_toContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.colon_colon"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColon_colon([NotNull] TSqlParser.Colon_colonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.colon_colon"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColon_colon([NotNull] TSqlParser.Colon_colonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_authorization_start([NotNull] TSqlParser.Alter_authorization_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_authorization_start([NotNull] TSqlParser.Alter_authorization_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_sql_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_authorization_for_sql_database([NotNull] TSqlParser.Alter_authorization_for_sql_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_sql_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_authorization_for_sql_database([NotNull] TSqlParser.Alter_authorization_for_sql_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_authorization_for_azure_dw([NotNull] TSqlParser.Alter_authorization_for_azure_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_authorization_for_azure_dw([NotNull] TSqlParser.Alter_authorization_for_azure_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_authorization_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_authorization_for_parallel_dw([NotNull] TSqlParser.Alter_authorization_for_parallel_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_authorization_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_authorization_for_parallel_dw([NotNull] TSqlParser.Alter_authorization_for_parallel_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type([NotNull] TSqlParser.Class_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type([NotNull] TSqlParser.Class_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_sql_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type_for_sql_database([NotNull] TSqlParser.Class_type_for_sql_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_sql_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type_for_sql_database([NotNull] TSqlParser.Class_type_for_sql_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type_for_azure_dw([NotNull] TSqlParser.Class_type_for_azure_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type_for_azure_dw([NotNull] TSqlParser.Class_type_for_azure_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type_for_parallel_dw([NotNull] TSqlParser.Class_type_for_parallel_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type_for_parallel_dw([NotNull] TSqlParser.Class_type_for_parallel_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.class_type_for_grant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type_for_grant([NotNull] TSqlParser.Class_type_for_grantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.class_type_for_grant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type_for_grant([NotNull] TSqlParser.Class_type_for_grantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_availability_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_availability_group([NotNull] TSqlParser.Drop_availability_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_availability_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_availability_group([NotNull] TSqlParser.Drop_availability_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_availability_group([NotNull] TSqlParser.Alter_availability_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_availability_group([NotNull] TSqlParser.Alter_availability_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_availability_group_start([NotNull] TSqlParser.Alter_availability_group_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_availability_group_start([NotNull] TSqlParser.Alter_availability_group_startContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_availability_group_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_availability_group_options([NotNull] TSqlParser.Alter_availability_group_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_availability_group_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_availability_group_options([NotNull] TSqlParser.Alter_availability_group_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ip_v4_failover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIp_v4_failover([NotNull] TSqlParser.Ip_v4_failoverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ip_v4_failover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIp_v4_failover([NotNull] TSqlParser.Ip_v4_failoverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ip_v6_failover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIp_v6_failover([NotNull] TSqlParser.Ip_v6_failoverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ip_v6_failover"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIp_v6_failover([NotNull] TSqlParser.Ip_v6_failoverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_broker_priority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_broker_priority([NotNull] TSqlParser.Create_or_alter_broker_priorityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_broker_priority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_broker_priority([NotNull] TSqlParser.Create_or_alter_broker_priorityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_broker_priority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_broker_priority([NotNull] TSqlParser.Drop_broker_priorityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_broker_priority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_broker_priority([NotNull] TSqlParser.Drop_broker_priorityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_certificate([NotNull] TSqlParser.Alter_certificateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_certificate([NotNull] TSqlParser.Alter_certificateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_column_encryption_key([NotNull] TSqlParser.Alter_column_encryption_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_column_encryption_key([NotNull] TSqlParser.Alter_column_encryption_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_column_encryption_key([NotNull] TSqlParser.Create_column_encryption_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_column_encryption_key([NotNull] TSqlParser.Create_column_encryption_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_certificate([NotNull] TSqlParser.Drop_certificateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_certificate([NotNull] TSqlParser.Drop_certificateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_column_encryption_key([NotNull] TSqlParser.Drop_column_encryption_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_column_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_column_encryption_key([NotNull] TSqlParser.Drop_column_encryption_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_column_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_column_master_key([NotNull] TSqlParser.Drop_column_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_column_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_column_master_key([NotNull] TSqlParser.Drop_column_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_contract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_contract([NotNull] TSqlParser.Drop_contractContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_contract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_contract([NotNull] TSqlParser.Drop_contractContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_credential([NotNull] TSqlParser.Drop_credentialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_credential([NotNull] TSqlParser.Drop_credentialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_cryptograhic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_cryptograhic_provider([NotNull] TSqlParser.Drop_cryptograhic_providerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_cryptograhic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_cryptograhic_provider([NotNull] TSqlParser.Drop_cryptograhic_providerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_database([NotNull] TSqlParser.Drop_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_database([NotNull] TSqlParser.Drop_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_database_audit_specification([NotNull] TSqlParser.Drop_database_audit_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_database_audit_specification([NotNull] TSqlParser.Drop_database_audit_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_database_encryption_key([NotNull] TSqlParser.Drop_database_encryption_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_encryption_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_database_encryption_key([NotNull] TSqlParser.Drop_database_encryption_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_database_scoped_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_database_scoped_credential([NotNull] TSqlParser.Drop_database_scoped_credentialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_database_scoped_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_database_scoped_credential([NotNull] TSqlParser.Drop_database_scoped_credentialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_default([NotNull] TSqlParser.Drop_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_default([NotNull] TSqlParser.Drop_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_endpoint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_endpoint([NotNull] TSqlParser.Drop_endpointContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_endpoint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_endpoint([NotNull] TSqlParser.Drop_endpointContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_data_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_external_data_source([NotNull] TSqlParser.Drop_external_data_sourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_data_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_external_data_source([NotNull] TSqlParser.Drop_external_data_sourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_file_format"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_external_file_format([NotNull] TSqlParser.Drop_external_file_formatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_file_format"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_external_file_format([NotNull] TSqlParser.Drop_external_file_formatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_external_library([NotNull] TSqlParser.Drop_external_libraryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_external_library([NotNull] TSqlParser.Drop_external_libraryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_external_resource_pool([NotNull] TSqlParser.Drop_external_resource_poolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_external_resource_pool([NotNull] TSqlParser.Drop_external_resource_poolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_external_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_external_table([NotNull] TSqlParser.Drop_external_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_external_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_external_table([NotNull] TSqlParser.Drop_external_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_event_notifications"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_event_notifications([NotNull] TSqlParser.Drop_event_notificationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_event_notifications"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_event_notifications([NotNull] TSqlParser.Drop_event_notificationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_event_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_event_session([NotNull] TSqlParser.Drop_event_sessionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_event_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_event_session([NotNull] TSqlParser.Drop_event_sessionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_fulltext_catalog([NotNull] TSqlParser.Drop_fulltext_catalogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_fulltext_catalog([NotNull] TSqlParser.Drop_fulltext_catalogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_fulltext_index([NotNull] TSqlParser.Drop_fulltext_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_fulltext_index([NotNull] TSqlParser.Drop_fulltext_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_fulltext_stoplist([NotNull] TSqlParser.Drop_fulltext_stoplistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_fulltext_stoplist([NotNull] TSqlParser.Drop_fulltext_stoplistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_login"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_login([NotNull] TSqlParser.Drop_loginContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_login"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_login([NotNull] TSqlParser.Drop_loginContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_master_key([NotNull] TSqlParser.Drop_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_master_key([NotNull] TSqlParser.Drop_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_message_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_message_type([NotNull] TSqlParser.Drop_message_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_message_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_message_type([NotNull] TSqlParser.Drop_message_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_partition_function([NotNull] TSqlParser.Drop_partition_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_partition_function([NotNull] TSqlParser.Drop_partition_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_partition_scheme([NotNull] TSqlParser.Drop_partition_schemeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_partition_scheme([NotNull] TSqlParser.Drop_partition_schemeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_queue([NotNull] TSqlParser.Drop_queueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_queue([NotNull] TSqlParser.Drop_queueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_remote_service_binding([NotNull] TSqlParser.Drop_remote_service_bindingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_remote_service_binding([NotNull] TSqlParser.Drop_remote_service_bindingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_resource_pool([NotNull] TSqlParser.Drop_resource_poolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_resource_pool([NotNull] TSqlParser.Drop_resource_poolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_db_role([NotNull] TSqlParser.Drop_db_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_db_role([NotNull] TSqlParser.Drop_db_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_route"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_route([NotNull] TSqlParser.Drop_routeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_route"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_route([NotNull] TSqlParser.Drop_routeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_rule([NotNull] TSqlParser.Drop_ruleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_rule([NotNull] TSqlParser.Drop_ruleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_schema([NotNull] TSqlParser.Drop_schemaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_schema([NotNull] TSqlParser.Drop_schemaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_search_property_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_search_property_list([NotNull] TSqlParser.Drop_search_property_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_search_property_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_search_property_list([NotNull] TSqlParser.Drop_search_property_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_security_policy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_security_policy([NotNull] TSqlParser.Drop_security_policyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_security_policy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_security_policy([NotNull] TSqlParser.Drop_security_policyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_sequence([NotNull] TSqlParser.Drop_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_sequence([NotNull] TSqlParser.Drop_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_server_audit([NotNull] TSqlParser.Drop_server_auditContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_server_audit([NotNull] TSqlParser.Drop_server_auditContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_server_audit_specification([NotNull] TSqlParser.Drop_server_audit_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_server_audit_specification([NotNull] TSqlParser.Drop_server_audit_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_server_role([NotNull] TSqlParser.Drop_server_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_server_role([NotNull] TSqlParser.Drop_server_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_service([NotNull] TSqlParser.Drop_serviceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_service([NotNull] TSqlParser.Drop_serviceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_signature([NotNull] TSqlParser.Drop_signatureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_signature([NotNull] TSqlParser.Drop_signatureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_statistics_name_azure_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_statistics_name_azure_dw_and_pdw([NotNull] TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_statistics_name_azure_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_statistics_name_azure_dw_and_pdw([NotNull] TSqlParser.Drop_statistics_name_azure_dw_and_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_symmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_symmetric_key([NotNull] TSqlParser.Drop_symmetric_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_symmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_symmetric_key([NotNull] TSqlParser.Drop_symmetric_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_synonym([NotNull] TSqlParser.Drop_synonymContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_synonym([NotNull] TSqlParser.Drop_synonymContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_user([NotNull] TSqlParser.Drop_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_user([NotNull] TSqlParser.Drop_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_workload_group([NotNull] TSqlParser.Drop_workload_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_workload_group([NotNull] TSqlParser.Drop_workload_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_xml_schema_collection([NotNull] TSqlParser.Drop_xml_schema_collectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_xml_schema_collection([NotNull] TSqlParser.Drop_xml_schema_collectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.disable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDisable_trigger([NotNull] TSqlParser.Disable_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.disable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDisable_trigger([NotNull] TSqlParser.Disable_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.enable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnable_trigger([NotNull] TSqlParser.Enable_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.enable_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnable_trigger([NotNull] TSqlParser.Enable_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.lock_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLock_table([NotNull] TSqlParser.Lock_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.lock_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLock_table([NotNull] TSqlParser.Lock_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.truncate_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncate_table([NotNull] TSqlParser.Truncate_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.truncate_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncate_table([NotNull] TSqlParser.Truncate_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_column_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_column_master_key([NotNull] TSqlParser.Create_column_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_column_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_column_master_key([NotNull] TSqlParser.Create_column_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_credential([NotNull] TSqlParser.Alter_credentialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_credential([NotNull] TSqlParser.Alter_credentialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_credential([NotNull] TSqlParser.Create_credentialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_credential"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_credential([NotNull] TSqlParser.Create_credentialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_cryptographic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_cryptographic_provider([NotNull] TSqlParser.Alter_cryptographic_providerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_cryptographic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_cryptographic_provider([NotNull] TSqlParser.Alter_cryptographic_providerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_cryptographic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_cryptographic_provider([NotNull] TSqlParser.Create_cryptographic_providerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_cryptographic_provider"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_cryptographic_provider([NotNull] TSqlParser.Create_cryptographic_providerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_event_notification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_event_notification([NotNull] TSqlParser.Create_event_notificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_event_notification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_event_notification([NotNull] TSqlParser.Create_event_notificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_event_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_event_session([NotNull] TSqlParser.Create_or_alter_event_sessionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_event_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_event_session([NotNull] TSqlParser.Create_or_alter_event_sessionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_session_predicate_expression([NotNull] TSqlParser.Event_session_predicate_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_session_predicate_factor([NotNull] TSqlParser.Event_session_predicate_factorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_session_predicate_factor([NotNull] TSqlParser.Event_session_predicate_factorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.event_session_predicate_leaf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_session_predicate_leaf([NotNull] TSqlParser.Event_session_predicate_leafContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.event_session_predicate_leaf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_session_predicate_leaf([NotNull] TSqlParser.Event_session_predicate_leafContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_data_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_external_data_source([NotNull] TSqlParser.Alter_external_data_sourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_data_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_external_data_source([NotNull] TSqlParser.Alter_external_data_sourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_external_library([NotNull] TSqlParser.Alter_external_libraryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_external_library([NotNull] TSqlParser.Alter_external_libraryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_external_library([NotNull] TSqlParser.Create_external_libraryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_external_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_external_library([NotNull] TSqlParser.Create_external_libraryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_external_resource_pool([NotNull] TSqlParser.Alter_external_resource_poolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_external_resource_pool([NotNull] TSqlParser.Alter_external_resource_poolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_external_resource_pool([NotNull] TSqlParser.Create_external_resource_poolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_external_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_external_resource_pool([NotNull] TSqlParser.Create_external_resource_poolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_fulltext_catalog([NotNull] TSqlParser.Alter_fulltext_catalogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_fulltext_catalog([NotNull] TSqlParser.Alter_fulltext_catalogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_fulltext_catalog([NotNull] TSqlParser.Create_fulltext_catalogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_fulltext_catalog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_fulltext_catalog([NotNull] TSqlParser.Create_fulltext_catalogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_fulltext_stoplist([NotNull] TSqlParser.Alter_fulltext_stoplistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_fulltext_stoplist([NotNull] TSqlParser.Alter_fulltext_stoplistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_fulltext_stoplist([NotNull] TSqlParser.Create_fulltext_stoplistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_fulltext_stoplist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_fulltext_stoplist([NotNull] TSqlParser.Create_fulltext_stoplistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_login_sql_server([NotNull] TSqlParser.Alter_login_sql_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_login_sql_server([NotNull] TSqlParser.Alter_login_sql_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_login_sql_server([NotNull] TSqlParser.Create_login_sql_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_login_sql_server([NotNull] TSqlParser.Create_login_sql_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_login_azure_sql([NotNull] TSqlParser.Alter_login_azure_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_login_azure_sql([NotNull] TSqlParser.Alter_login_azure_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_login_azure_sql([NotNull] TSqlParser.Create_login_azure_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_login_azure_sql([NotNull] TSqlParser.Create_login_azure_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_login_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_login_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_login_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_login_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_login_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_login_pdw([NotNull] TSqlParser.Create_login_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_login_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_login_pdw([NotNull] TSqlParser.Create_login_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_master_key_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_master_key_sql_server([NotNull] TSqlParser.Alter_master_key_sql_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_master_key_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_master_key_sql_server([NotNull] TSqlParser.Alter_master_key_sql_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_master_key_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_master_key_sql_server([NotNull] TSqlParser.Create_master_key_sql_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_master_key_sql_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_master_key_sql_server([NotNull] TSqlParser.Create_master_key_sql_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_master_key_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_master_key_azure_sql([NotNull] TSqlParser.Alter_master_key_azure_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_master_key_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_master_key_azure_sql([NotNull] TSqlParser.Alter_master_key_azure_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_master_key_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_master_key_azure_sql([NotNull] TSqlParser.Create_master_key_azure_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_master_key_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_master_key_azure_sql([NotNull] TSqlParser.Create_master_key_azure_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_message_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_message_type([NotNull] TSqlParser.Alter_message_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_message_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_message_type([NotNull] TSqlParser.Alter_message_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_partition_function([NotNull] TSqlParser.Alter_partition_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_partition_function([NotNull] TSqlParser.Alter_partition_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_partition_scheme([NotNull] TSqlParser.Alter_partition_schemeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_partition_scheme([NotNull] TSqlParser.Alter_partition_schemeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_remote_service_binding([NotNull] TSqlParser.Alter_remote_service_bindingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_remote_service_binding([NotNull] TSqlParser.Alter_remote_service_bindingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_remote_service_binding([NotNull] TSqlParser.Create_remote_service_bindingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_remote_service_binding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_remote_service_binding([NotNull] TSqlParser.Create_remote_service_bindingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_resource_pool([NotNull] TSqlParser.Create_resource_poolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_resource_pool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_resource_pool([NotNull] TSqlParser.Create_resource_poolContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_resource_governor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_resource_governor([NotNull] TSqlParser.Alter_resource_governorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_resource_governor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_resource_governor([NotNull] TSqlParser.Alter_resource_governorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_db_role([NotNull] TSqlParser.Alter_db_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_db_role([NotNull] TSqlParser.Alter_db_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_db_role([NotNull] TSqlParser.Create_db_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_db_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_db_role([NotNull] TSqlParser.Create_db_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_route"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_route([NotNull] TSqlParser.Create_routeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_route"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_route([NotNull] TSqlParser.Create_routeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_rule([NotNull] TSqlParser.Create_ruleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_rule([NotNull] TSqlParser.Create_ruleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_schema_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_schema_sql([NotNull] TSqlParser.Alter_schema_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_schema_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_schema_sql([NotNull] TSqlParser.Alter_schema_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_schema([NotNull] TSqlParser.Create_schemaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_schema([NotNull] TSqlParser.Create_schemaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_schema_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_schema_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Create_schema_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_schema_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_schema_azure_sql_dw_and_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_schema_azure_sql_dw_and_pdw([NotNull] TSqlParser.Alter_schema_azure_sql_dw_and_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_search_property_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_search_property_list([NotNull] TSqlParser.Create_search_property_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_search_property_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_search_property_list([NotNull] TSqlParser.Create_search_property_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_security_policy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_security_policy([NotNull] TSqlParser.Create_security_policyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_security_policy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_security_policy([NotNull] TSqlParser.Create_security_policyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_sequence([NotNull] TSqlParser.Alter_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_sequence([NotNull] TSqlParser.Alter_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_sequence([NotNull] TSqlParser.Create_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_sequence([NotNull] TSqlParser.Create_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_server_audit([NotNull] TSqlParser.Alter_server_auditContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_server_audit([NotNull] TSqlParser.Alter_server_auditContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_server_audit([NotNull] TSqlParser.Create_server_auditContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_audit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_server_audit([NotNull] TSqlParser.Create_server_auditContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_server_audit_specification([NotNull] TSqlParser.Alter_server_audit_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_server_audit_specification([NotNull] TSqlParser.Alter_server_audit_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_server_audit_specification([NotNull] TSqlParser.Create_server_audit_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_audit_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_server_audit_specification([NotNull] TSqlParser.Create_server_audit_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_configuration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_server_configuration([NotNull] TSqlParser.Alter_server_configurationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_configuration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_server_configuration([NotNull] TSqlParser.Alter_server_configurationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_server_role([NotNull] TSqlParser.Alter_server_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_server_role([NotNull] TSqlParser.Alter_server_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_server_role([NotNull] TSqlParser.Create_server_roleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_server_role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_server_role([NotNull] TSqlParser.Create_server_roleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_server_role_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_server_role_pdw([NotNull] TSqlParser.Alter_server_role_pdwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_server_role_pdw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_server_role_pdw([NotNull] TSqlParser.Alter_server_role_pdwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_service([NotNull] TSqlParser.Alter_serviceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_service([NotNull] TSqlParser.Alter_serviceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_service([NotNull] TSqlParser.Create_serviceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_service"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_service([NotNull] TSqlParser.Create_serviceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_service_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_service_master_key([NotNull] TSqlParser.Alter_service_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_service_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_service_master_key([NotNull] TSqlParser.Alter_service_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_symmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_symmetric_key([NotNull] TSqlParser.Alter_symmetric_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_symmetric_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_symmetric_key([NotNull] TSqlParser.Alter_symmetric_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_synonym([NotNull] TSqlParser.Create_synonymContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_synonym([NotNull] TSqlParser.Create_synonymContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_user([NotNull] TSqlParser.Alter_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_user([NotNull] TSqlParser.Alter_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_user([NotNull] TSqlParser.Create_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_user([NotNull] TSqlParser.Create_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_user_azure_sql_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_user_azure_sql_dw([NotNull] TSqlParser.Create_user_azure_sql_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_user_azure_sql_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_user_azure_sql_dw([NotNull] TSqlParser.Create_user_azure_sql_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_user_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_user_azure_sql([NotNull] TSqlParser.Alter_user_azure_sqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_user_azure_sql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_user_azure_sql([NotNull] TSqlParser.Alter_user_azure_sqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_workload_group([NotNull] TSqlParser.Alter_workload_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_workload_group([NotNull] TSqlParser.Alter_workload_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_workload_group([NotNull] TSqlParser.Create_workload_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_workload_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_workload_group([NotNull] TSqlParser.Create_workload_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_xml_schema_collection([NotNull] TSqlParser.Create_xml_schema_collectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_xml_schema_collection([NotNull] TSqlParser.Create_xml_schema_collectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_partition_function([NotNull] TSqlParser.Create_partition_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_partition_function([NotNull] TSqlParser.Create_partition_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_partition_scheme([NotNull] TSqlParser.Create_partition_schemeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_partition_scheme"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_partition_scheme([NotNull] TSqlParser.Create_partition_schemeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_queue([NotNull] TSqlParser.Create_queueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_queue([NotNull] TSqlParser.Create_queueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_settings"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueue_settings([NotNull] TSqlParser.Queue_settingsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_settings"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueue_settings([NotNull] TSqlParser.Queue_settingsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_queue([NotNull] TSqlParser.Alter_queueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_queue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_queue([NotNull] TSqlParser.Alter_queueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_action"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueue_action([NotNull] TSqlParser.Queue_actionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_action"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueue_action([NotNull] TSqlParser.Queue_actionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_rebuild_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueue_rebuild_options([NotNull] TSqlParser.Queue_rebuild_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_rebuild_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueue_rebuild_options([NotNull] TSqlParser.Queue_rebuild_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_contract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_contract([NotNull] TSqlParser.Create_contractContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_contract"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_contract([NotNull] TSqlParser.Create_contractContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.conversation_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConversation_statement([NotNull] TSqlParser.Conversation_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.conversation_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConversation_statement([NotNull] TSqlParser.Conversation_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.message_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMessage_statement([NotNull] TSqlParser.Message_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.message_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMessage_statement([NotNull] TSqlParser.Message_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_statement([NotNull] TSqlParser.Merge_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_statement([NotNull] TSqlParser.Merge_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.when_matches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhen_matches([NotNull] TSqlParser.When_matchesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.when_matches"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhen_matches([NotNull] TSqlParser.When_matchesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_matched"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_matched([NotNull] TSqlParser.Merge_matchedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_matched"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_matched([NotNull] TSqlParser.Merge_matchedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.merge_not_matched"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_not_matched([NotNull] TSqlParser.Merge_not_matchedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.merge_not_matched"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_not_matched([NotNull] TSqlParser.Merge_not_matchedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delete_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_statement([NotNull] TSqlParser.Delete_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delete_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_statement([NotNull] TSqlParser.Delete_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delete_statement_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_statement_from([NotNull] TSqlParser.Delete_statement_fromContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delete_statement_from"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_statement_from([NotNull] TSqlParser.Delete_statement_fromContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_statement([NotNull] TSqlParser.Insert_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_statement([NotNull] TSqlParser.Insert_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_statement_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_statement_value([NotNull] TSqlParser.Insert_statement_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_statement_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_statement_value([NotNull] TSqlParser.Insert_statement_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.receive_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReceive_statement([NotNull] TSqlParser.Receive_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.receive_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReceive_statement([NotNull] TSqlParser.Receive_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_statement_standalone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_statement_standalone([NotNull] TSqlParser.Select_statement_standaloneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_statement_standalone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_statement_standalone([NotNull] TSqlParser.Select_statement_standaloneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_statement([NotNull] TSqlParser.Select_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_statement([NotNull] TSqlParser.Select_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.time"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTime([NotNull] TSqlParser.TimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.time"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTime([NotNull] TSqlParser.TimeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_statement([NotNull] TSqlParser.Update_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_statement([NotNull] TSqlParser.Update_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.output_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutput_clause([NotNull] TSqlParser.Output_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.output_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutput_clause([NotNull] TSqlParser.Output_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.output_dml_list_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOutput_dml_list_elem([NotNull] TSqlParser.Output_dml_list_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.output_dml_list_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOutput_dml_list_elem([NotNull] TSqlParser.Output_dml_list_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_database([NotNull] TSqlParser.Create_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_database([NotNull] TSqlParser.Create_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_index([NotNull] TSqlParser.Create_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_index([NotNull] TSqlParser.Create_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_index_options([NotNull] TSqlParser.Create_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_index_options([NotNull] TSqlParser.Create_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.relational_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_index_option([NotNull] TSqlParser.Relational_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.relational_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_index_option([NotNull] TSqlParser.Relational_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_index([NotNull] TSqlParser.Alter_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_index([NotNull] TSqlParser.Alter_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.resumable_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResumable_index_options([NotNull] TSqlParser.Resumable_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.resumable_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResumable_index_options([NotNull] TSqlParser.Resumable_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.resumable_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResumable_index_option([NotNull] TSqlParser.Resumable_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.resumable_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResumable_index_option([NotNull] TSqlParser.Resumable_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReorganize_partition([NotNull] TSqlParser.Reorganize_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReorganize_partition([NotNull] TSqlParser.Reorganize_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReorganize_options([NotNull] TSqlParser.Reorganize_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReorganize_options([NotNull] TSqlParser.Reorganize_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reorganize_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReorganize_option([NotNull] TSqlParser.Reorganize_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reorganize_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReorganize_option([NotNull] TSqlParser.Reorganize_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_index_options([NotNull] TSqlParser.Set_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_index_options([NotNull] TSqlParser.Set_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_index_option([NotNull] TSqlParser.Set_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_index_option([NotNull] TSqlParser.Set_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRebuild_partition([NotNull] TSqlParser.Rebuild_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRebuild_partition([NotNull] TSqlParser.Rebuild_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRebuild_index_options([NotNull] TSqlParser.Rebuild_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRebuild_index_options([NotNull] TSqlParser.Rebuild_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rebuild_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRebuild_index_option([NotNull] TSqlParser.Rebuild_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rebuild_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRebuild_index_option([NotNull] TSqlParser.Rebuild_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_partition_rebuild_index_options([NotNull] TSqlParser.Single_partition_rebuild_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_partition_rebuild_index_options([NotNull] TSqlParser.Single_partition_rebuild_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_partition_rebuild_index_option([NotNull] TSqlParser.Single_partition_rebuild_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.single_partition_rebuild_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_partition_rebuild_index_option([NotNull] TSqlParser.Single_partition_rebuild_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_partitions([NotNull] TSqlParser.On_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_partitions([NotNull] TSqlParser.On_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_columnstore_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_columnstore_index([NotNull] TSqlParser.Create_columnstore_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_columnstore_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_columnstore_index([NotNull] TSqlParser.Create_columnstore_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_columnstore_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_columnstore_index_options([NotNull] TSqlParser.Create_columnstore_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_columnstore_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_columnstore_index_options([NotNull] TSqlParser.Create_columnstore_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.columnstore_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnstore_index_option([NotNull] TSqlParser.Columnstore_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.columnstore_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnstore_index_option([NotNull] TSqlParser.Columnstore_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_nonclustered_columnstore_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_nonclustered_columnstore_index([NotNull] TSqlParser.Create_nonclustered_columnstore_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_nonclustered_columnstore_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_nonclustered_columnstore_index([NotNull] TSqlParser.Create_nonclustered_columnstore_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_xml_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_xml_index([NotNull] TSqlParser.Create_xml_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_xml_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_xml_index([NotNull] TSqlParser.Create_xml_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_index_options([NotNull] TSqlParser.Xml_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_index_options([NotNull] TSqlParser.Xml_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_index_option([NotNull] TSqlParser.Xml_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_index_option([NotNull] TSqlParser.Xml_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_procedure([NotNull] TSqlParser.Create_or_alter_procedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_procedure([NotNull] TSqlParser.Create_or_alter_procedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_external_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAs_external_name([NotNull] TSqlParser.As_external_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_external_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAs_external_name([NotNull] TSqlParser.As_external_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_trigger([NotNull] TSqlParser.Create_or_alter_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_trigger([NotNull] TSqlParser.Create_or_alter_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_dml_trigger([NotNull] TSqlParser.Create_or_alter_dml_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_dml_trigger([NotNull] TSqlParser.Create_or_alter_dml_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_trigger_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_trigger_option([NotNull] TSqlParser.Dml_trigger_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_trigger_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_trigger_option([NotNull] TSqlParser.Dml_trigger_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dml_trigger_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_trigger_operation([NotNull] TSqlParser.Dml_trigger_operationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dml_trigger_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_trigger_operation([NotNull] TSqlParser.Dml_trigger_operationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_ddl_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_ddl_trigger([NotNull] TSqlParser.Create_or_alter_ddl_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_ddl_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_ddl_trigger([NotNull] TSqlParser.Create_or_alter_ddl_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_trigger_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDdl_trigger_operation([NotNull] TSqlParser.Ddl_trigger_operationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_trigger_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDdl_trigger_operation([NotNull] TSqlParser.Ddl_trigger_operationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_or_alter_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_or_alter_function([NotNull] TSqlParser.Create_or_alter_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_or_alter_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_or_alter_function([NotNull] TSqlParser.Create_or_alter_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_body_returns_select([NotNull] TSqlParser.Func_body_returns_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_body_returns_select([NotNull] TSqlParser.Func_body_returns_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_body_returns_table([NotNull] TSqlParser.Func_body_returns_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_body_returns_table([NotNull] TSqlParser.Func_body_returns_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_body_returns_scalar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_body_returns_scalar([NotNull] TSqlParser.Func_body_returns_scalarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_body_returns_scalar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_body_returns_scalar([NotNull] TSqlParser.Func_body_returns_scalarContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.procedure_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_param([NotNull] TSqlParser.Procedure_paramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.procedure_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_param([NotNull] TSqlParser.Procedure_paramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.procedure_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_option([NotNull] TSqlParser.Procedure_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.procedure_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_option([NotNull] TSqlParser.Procedure_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.function_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_option([NotNull] TSqlParser.Function_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.function_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_option([NotNull] TSqlParser.Function_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_statistics([NotNull] TSqlParser.Create_statisticsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_statistics([NotNull] TSqlParser.Create_statisticsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_statistics([NotNull] TSqlParser.Update_statisticsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_statistics([NotNull] TSqlParser.Update_statisticsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_statistics_options([NotNull] TSqlParser.Update_statistics_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_statistics_options([NotNull] TSqlParser.Update_statistics_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_statistics_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_statistics_option([NotNull] TSqlParser.Update_statistics_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_statistics_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_statistics_option([NotNull] TSqlParser.Update_statistics_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table([NotNull] TSqlParser.Create_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table([NotNull] TSqlParser.Create_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_indices"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_indices([NotNull] TSqlParser.Table_indicesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_indices"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_indices([NotNull] TSqlParser.Table_indicesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_options([NotNull] TSqlParser.Table_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_options([NotNull] TSqlParser.Table_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_option([NotNull] TSqlParser.Table_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_option([NotNull] TSqlParser.Table_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table_index_options([NotNull] TSqlParser.Create_table_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table_index_options([NotNull] TSqlParser.Create_table_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_table_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table_index_option([NotNull] TSqlParser.Create_table_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_table_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table_index_option([NotNull] TSqlParser.Create_table_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_view([NotNull] TSqlParser.Create_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_view([NotNull] TSqlParser.Create_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.view_attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterView_attribute([NotNull] TSqlParser.View_attributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.view_attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitView_attribute([NotNull] TSqlParser.View_attributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table([NotNull] TSqlParser.Alter_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table([NotNull] TSqlParser.Alter_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_partition([NotNull] TSqlParser.Switch_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_partition([NotNull] TSqlParser.Switch_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.low_priority_lock_wait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLow_priority_lock_wait([NotNull] TSqlParser.Low_priority_lock_waitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.low_priority_lock_wait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLow_priority_lock_wait([NotNull] TSqlParser.Low_priority_lock_waitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_database([NotNull] TSqlParser.Alter_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_database([NotNull] TSqlParser.Alter_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.add_or_modify_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_or_modify_files([NotNull] TSqlParser.Add_or_modify_filesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.add_or_modify_files"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_or_modify_files([NotNull] TSqlParser.Add_or_modify_filesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.filespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilespec([NotNull] TSqlParser.FilespecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.filespec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilespec([NotNull] TSqlParser.FilespecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.add_or_modify_filegroups"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_or_modify_filegroups([NotNull] TSqlParser.Add_or_modify_filegroupsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.add_or_modify_filegroups"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_or_modify_filegroups([NotNull] TSqlParser.Add_or_modify_filegroupsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.filegroup_updatability_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilegroup_updatability_option([NotNull] TSqlParser.Filegroup_updatability_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.filegroup_updatability_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilegroup_updatability_option([NotNull] TSqlParser.Filegroup_updatability_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_optionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_optionspec([NotNull] TSqlParser.Database_optionspecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_optionspec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_optionspec([NotNull] TSqlParser.Database_optionspecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.auto_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAuto_option([NotNull] TSqlParser.Auto_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.auto_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAuto_option([NotNull] TSqlParser.Auto_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_tracking_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChange_tracking_option([NotNull] TSqlParser.Change_tracking_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_tracking_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChange_tracking_option([NotNull] TSqlParser.Change_tracking_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_tracking_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChange_tracking_option_list([NotNull] TSqlParser.Change_tracking_option_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_tracking_option_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChange_tracking_option_list([NotNull] TSqlParser.Change_tracking_option_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.containment_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContainment_option([NotNull] TSqlParser.Containment_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.containment_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContainment_option([NotNull] TSqlParser.Containment_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_option([NotNull] TSqlParser.Cursor_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_option([NotNull] TSqlParser.Cursor_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_endpoint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_endpoint([NotNull] TSqlParser.Alter_endpointContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_endpoint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_endpoint([NotNull] TSqlParser.Alter_endpointContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_mirroring_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_mirroring_option([NotNull] TSqlParser.Database_mirroring_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_mirroring_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_mirroring_option([NotNull] TSqlParser.Database_mirroring_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_set_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMirroring_set_option([NotNull] TSqlParser.Mirroring_set_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_set_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMirroring_set_option([NotNull] TSqlParser.Mirroring_set_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_partner"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMirroring_partner([NotNull] TSqlParser.Mirroring_partnerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_partner"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMirroring_partner([NotNull] TSqlParser.Mirroring_partnerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_witness"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMirroring_witness([NotNull] TSqlParser.Mirroring_witnessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_witness"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMirroring_witness([NotNull] TSqlParser.Mirroring_witnessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_partner_equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWitness_partner_equal([NotNull] TSqlParser.Witness_partner_equalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_partner_equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWitness_partner_equal([NotNull] TSqlParser.Witness_partner_equalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartner_option([NotNull] TSqlParser.Partner_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartner_option([NotNull] TSqlParser.Partner_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWitness_option([NotNull] TSqlParser.Witness_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWitness_option([NotNull] TSqlParser.Witness_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.witness_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWitness_server([NotNull] TSqlParser.Witness_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.witness_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWitness_server([NotNull] TSqlParser.Witness_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartner_server([NotNull] TSqlParser.Partner_serverContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_server"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartner_server([NotNull] TSqlParser.Partner_serverContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mirroring_host_port_seperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMirroring_host_port_seperator([NotNull] TSqlParser.Mirroring_host_port_seperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mirroring_host_port_seperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMirroring_host_port_seperator([NotNull] TSqlParser.Mirroring_host_port_seperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partner_server_tcp_prefix"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartner_server_tcp_prefix([NotNull] TSqlParser.Partner_server_tcp_prefixContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partner_server_tcp_prefix"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartner_server_tcp_prefix([NotNull] TSqlParser.Partner_server_tcp_prefixContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.port_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPort_number([NotNull] TSqlParser.Port_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.port_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPort_number([NotNull] TSqlParser.Port_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.host"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHost([NotNull] TSqlParser.HostContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.host"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHost([NotNull] TSqlParser.HostContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.date_correlation_optimization_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDate_correlation_optimization_option([NotNull] TSqlParser.Date_correlation_optimization_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.date_correlation_optimization_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDate_correlation_optimization_option([NotNull] TSqlParser.Date_correlation_optimization_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_encryption_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDb_encryption_option([NotNull] TSqlParser.Db_encryption_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_encryption_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDb_encryption_option([NotNull] TSqlParser.Db_encryption_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_state_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDb_state_option([NotNull] TSqlParser.Db_state_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_state_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDb_state_option([NotNull] TSqlParser.Db_state_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_update_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDb_update_option([NotNull] TSqlParser.Db_update_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_update_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDb_update_option([NotNull] TSqlParser.Db_update_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.db_user_access_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDb_user_access_option([NotNull] TSqlParser.Db_user_access_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.db_user_access_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDb_user_access_option([NotNull] TSqlParser.Db_user_access_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.delayed_durability_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelayed_durability_option([NotNull] TSqlParser.Delayed_durability_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.delayed_durability_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelayed_durability_option([NotNull] TSqlParser.Delayed_durability_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.external_access_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExternal_access_option([NotNull] TSqlParser.External_access_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.external_access_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExternal_access_option([NotNull] TSqlParser.External_access_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hadr_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHadr_options([NotNull] TSqlParser.Hadr_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hadr_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHadr_options([NotNull] TSqlParser.Hadr_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.mixed_page_allocation_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMixed_page_allocation_option([NotNull] TSqlParser.Mixed_page_allocation_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.mixed_page_allocation_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMixed_page_allocation_option([NotNull] TSqlParser.Mixed_page_allocation_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.parameterization_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterization_option([NotNull] TSqlParser.Parameterization_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.parameterization_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterization_option([NotNull] TSqlParser.Parameterization_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.recovery_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecovery_option([NotNull] TSqlParser.Recovery_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.recovery_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecovery_option([NotNull] TSqlParser.Recovery_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.service_broker_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterService_broker_option([NotNull] TSqlParser.Service_broker_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.service_broker_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitService_broker_option([NotNull] TSqlParser.Service_broker_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.snapshot_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSnapshot_option([NotNull] TSqlParser.Snapshot_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.snapshot_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSnapshot_option([NotNull] TSqlParser.Snapshot_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_option([NotNull] TSqlParser.Sql_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_option([NotNull] TSqlParser.Sql_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.target_recovery_time_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTarget_recovery_time_option([NotNull] TSqlParser.Target_recovery_time_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.target_recovery_time_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTarget_recovery_time_option([NotNull] TSqlParser.Target_recovery_time_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.termination"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermination([NotNull] TSqlParser.TerminationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.termination"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermination([NotNull] TSqlParser.TerminationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_index([NotNull] TSqlParser.Drop_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_index([NotNull] TSqlParser.Drop_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_relational_or_xml_or_spatial_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_relational_or_xml_or_spatial_index([NotNull] TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_relational_or_xml_or_spatial_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_relational_or_xml_or_spatial_index([NotNull] TSqlParser.Drop_relational_or_xml_or_spatial_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_backward_compatible_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_backward_compatible_index([NotNull] TSqlParser.Drop_backward_compatible_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_backward_compatible_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_backward_compatible_index([NotNull] TSqlParser.Drop_backward_compatible_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_procedure([NotNull] TSqlParser.Drop_procedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_procedure([NotNull] TSqlParser.Drop_procedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_trigger([NotNull] TSqlParser.Drop_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_trigger([NotNull] TSqlParser.Drop_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_dml_trigger([NotNull] TSqlParser.Drop_dml_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_dml_trigger([NotNull] TSqlParser.Drop_dml_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_ddl_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_ddl_trigger([NotNull] TSqlParser.Drop_ddl_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_ddl_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_ddl_trigger([NotNull] TSqlParser.Drop_ddl_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_function([NotNull] TSqlParser.Drop_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_function([NotNull] TSqlParser.Drop_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_statistics([NotNull] TSqlParser.Drop_statisticsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_statistics([NotNull] TSqlParser.Drop_statisticsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_table([NotNull] TSqlParser.Drop_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_table([NotNull] TSqlParser.Drop_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_view([NotNull] TSqlParser.Drop_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_view([NotNull] TSqlParser.Drop_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_type([NotNull] TSqlParser.Create_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_type([NotNull] TSqlParser.Create_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.drop_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_type([NotNull] TSqlParser.Drop_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.drop_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_type([NotNull] TSqlParser.Drop_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rowset_function_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowset_function_limited([NotNull] TSqlParser.Rowset_function_limitedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rowset_function_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowset_function_limited([NotNull] TSqlParser.Rowset_function_limitedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.openquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpenquery([NotNull] TSqlParser.OpenqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.openquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpenquery([NotNull] TSqlParser.OpenqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.opendatasource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpendatasource([NotNull] TSqlParser.OpendatasourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.opendatasource"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpendatasource([NotNull] TSqlParser.OpendatasourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_statement([NotNull] TSqlParser.Declare_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_statement([NotNull] TSqlParser.Declare_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_declaration([NotNull] TSqlParser.Xml_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_declaration([NotNull] TSqlParser.Xml_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_statement([NotNull] TSqlParser.Cursor_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_statement([NotNull] TSqlParser.Cursor_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_database([NotNull] TSqlParser.Backup_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_database([NotNull] TSqlParser.Backup_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_log([NotNull] TSqlParser.Backup_logContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_log([NotNull] TSqlParser.Backup_logContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_certificate([NotNull] TSqlParser.Backup_certificateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_certificate([NotNull] TSqlParser.Backup_certificateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_master_key([NotNull] TSqlParser.Backup_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_master_key([NotNull] TSqlParser.Backup_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.backup_service_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackup_service_master_key([NotNull] TSqlParser.Backup_service_master_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.backup_service_master_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackup_service_master_key([NotNull] TSqlParser.Backup_service_master_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKill_statement([NotNull] TSqlParser.Kill_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKill_statement([NotNull] TSqlParser.Kill_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_process"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKill_process([NotNull] TSqlParser.Kill_processContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_process"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKill_process([NotNull] TSqlParser.Kill_processContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_query_notification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKill_query_notification([NotNull] TSqlParser.Kill_query_notificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_query_notification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKill_query_notification([NotNull] TSqlParser.Kill_query_notificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.kill_stats_job"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKill_stats_job([NotNull] TSqlParser.Kill_stats_jobContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.kill_stats_job"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKill_stats_job([NotNull] TSqlParser.Kill_stats_jobContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_statement([NotNull] TSqlParser.Execute_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_statement([NotNull] TSqlParser.Execute_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_body_batch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_body_batch([NotNull] TSqlParser.Execute_body_batchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_body_batch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_body_batch([NotNull] TSqlParser.Execute_body_batchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_body([NotNull] TSqlParser.Execute_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_body([NotNull] TSqlParser.Execute_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_statement_arg([NotNull] TSqlParser.Execute_statement_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_statement_arg([NotNull] TSqlParser.Execute_statement_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg_named"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_statement_arg_named([NotNull] TSqlParser.Execute_statement_arg_namedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg_named"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_statement_arg_named([NotNull] TSqlParser.Execute_statement_arg_namedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_statement_arg_unnamed"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_statement_arg_unnamed([NotNull] TSqlParser.Execute_statement_arg_unnamedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_statement_arg_unnamed"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_statement_arg_unnamed([NotNull] TSqlParser.Execute_statement_arg_unnamedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_parameter([NotNull] TSqlParser.Execute_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_parameter([NotNull] TSqlParser.Execute_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_var_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_var_string([NotNull] TSqlParser.Execute_var_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_var_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_var_string([NotNull] TSqlParser.Execute_var_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.security_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSecurity_statement([NotNull] TSqlParser.Security_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.security_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSecurity_statement([NotNull] TSqlParser.Security_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.principal_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrincipal_id([NotNull] TSqlParser.Principal_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.principal_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrincipal_id([NotNull] TSqlParser.Principal_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_certificate([NotNull] TSqlParser.Create_certificateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_certificate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_certificate([NotNull] TSqlParser.Create_certificateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.existing_keys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExisting_keys([NotNull] TSqlParser.Existing_keysContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.existing_keys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExisting_keys([NotNull] TSqlParser.Existing_keysContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.private_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivate_key_options([NotNull] TSqlParser.Private_key_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.private_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivate_key_options([NotNull] TSqlParser.Private_key_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.generate_new_keys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenerate_new_keys([NotNull] TSqlParser.Generate_new_keysContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.generate_new_keys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenerate_new_keys([NotNull] TSqlParser.Generate_new_keysContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.date_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDate_options([NotNull] TSqlParser.Date_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.date_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDate_options([NotNull] TSqlParser.Date_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpen_key([NotNull] TSqlParser.Open_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpen_key([NotNull] TSqlParser.Open_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.close_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClose_key([NotNull] TSqlParser.Close_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.close_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClose_key([NotNull] TSqlParser.Close_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_key([NotNull] TSqlParser.Create_keyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_key"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_key([NotNull] TSqlParser.Create_keyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_options([NotNull] TSqlParser.Key_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_options([NotNull] TSqlParser.Key_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.algorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlgorithm([NotNull] TSqlParser.AlgorithmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.algorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlgorithm([NotNull] TSqlParser.AlgorithmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.encryption_mechanism"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEncryption_mechanism([NotNull] TSqlParser.Encryption_mechanismContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.encryption_mechanism"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEncryption_mechanism([NotNull] TSqlParser.Encryption_mechanismContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.decryption_mechanism"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecryption_mechanism([NotNull] TSqlParser.Decryption_mechanismContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.decryption_mechanism"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecryption_mechanism([NotNull] TSqlParser.Decryption_mechanismContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.grant_permission"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrant_permission([NotNull] TSqlParser.Grant_permissionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.grant_permission"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrant_permission([NotNull] TSqlParser.Grant_permissionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_statement([NotNull] TSqlParser.Set_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_statement([NotNull] TSqlParser.Set_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.transaction_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_statement([NotNull] TSqlParser.Transaction_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.transaction_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_statement([NotNull] TSqlParser.Transaction_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.go_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGo_statement([NotNull] TSqlParser.Go_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.go_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGo_statement([NotNull] TSqlParser.Go_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.use_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUse_statement([NotNull] TSqlParser.Use_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.use_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUse_statement([NotNull] TSqlParser.Use_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.setuser_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetuser_statement([NotNull] TSqlParser.Setuser_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.setuser_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetuser_statement([NotNull] TSqlParser.Setuser_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.reconfigure_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReconfigure_statement([NotNull] TSqlParser.Reconfigure_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.reconfigure_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReconfigure_statement([NotNull] TSqlParser.Reconfigure_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.shutdown_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShutdown_statement([NotNull] TSqlParser.Shutdown_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.shutdown_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShutdown_statement([NotNull] TSqlParser.Shutdown_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.checkpoint_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckpoint_statement([NotNull] TSqlParser.Checkpoint_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.checkpoint_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckpoint_statement([NotNull] TSqlParser.Checkpoint_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDbcc_special([NotNull] TSqlParser.Dbcc_specialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDbcc_special([NotNull] TSqlParser.Dbcc_specialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDbcc_clause([NotNull] TSqlParser.Dbcc_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDbcc_clause([NotNull] TSqlParser.Dbcc_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDbcc_command([NotNull] TSqlParser.Dbcc_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDbcc_command([NotNull] TSqlParser.Dbcc_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.dbcc_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDbcc_options([NotNull] TSqlParser.Dbcc_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.dbcc_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDbcc_options([NotNull] TSqlParser.Dbcc_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.execute_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_clause([NotNull] TSqlParser.Execute_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.execute_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_clause([NotNull] TSqlParser.Execute_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_local"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_local([NotNull] TSqlParser.Declare_localContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_local"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_local([NotNull] TSqlParser.Declare_localContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_type_definition([NotNull] TSqlParser.Table_type_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_type_definition([NotNull] TSqlParser.Table_type_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_type_indices"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_type_indices([NotNull] TSqlParser.Table_type_indicesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_type_indices"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_type_indices([NotNull] TSqlParser.Table_type_indicesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_type_definition([NotNull] TSqlParser.Xml_type_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_type_definition([NotNull] TSqlParser.Xml_type_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_schema_collection([NotNull] TSqlParser.Xml_schema_collectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_schema_collection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_schema_collection([NotNull] TSqlParser.Xml_schema_collectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_def_table_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_def_table_constraints([NotNull] TSqlParser.Column_def_table_constraintsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_def_table_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_def_table_constraints([NotNull] TSqlParser.Column_def_table_constraintsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_def_table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_def_table_constraint([NotNull] TSqlParser.Column_def_table_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_def_table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_def_table_constraint([NotNull] TSqlParser.Column_def_table_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_definition([NotNull] TSqlParser.Column_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_definition([NotNull] TSqlParser.Column_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_definition_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_definition_element([NotNull] TSqlParser.Column_definition_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_definition_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_definition_element([NotNull] TSqlParser.Column_definition_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.materialized_column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMaterialized_column_definition([NotNull] TSqlParser.Materialized_column_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.materialized_column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMaterialized_column_definition([NotNull] TSqlParser.Materialized_column_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_constraint([NotNull] TSqlParser.Column_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_constraint([NotNull] TSqlParser.Column_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_index([NotNull] TSqlParser.Column_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_index([NotNull] TSqlParser.Column_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_partition_or_filegroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_partition_or_filegroup([NotNull] TSqlParser.On_partition_or_filegroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_partition_or_filegroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_partition_or_filegroup([NotNull] TSqlParser.On_partition_or_filegroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_constraint([NotNull] TSqlParser.Table_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_constraint([NotNull] TSqlParser.Table_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.connection_node"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConnection_node([NotNull] TSqlParser.Connection_nodeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.connection_node"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConnection_node([NotNull] TSqlParser.Connection_nodeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.primary_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary_key_options([NotNull] TSqlParser.Primary_key_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.primary_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary_key_options([NotNull] TSqlParser.Primary_key_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.foreign_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_key_options([NotNull] TSqlParser.Foreign_key_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.foreign_key_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_key_options([NotNull] TSqlParser.Foreign_key_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.check_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheck_constraint([NotNull] TSqlParser.Check_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.check_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheck_constraint([NotNull] TSqlParser.Check_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_delete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_delete([NotNull] TSqlParser.On_deleteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_delete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_delete([NotNull] TSqlParser.On_deleteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_update"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_update([NotNull] TSqlParser.On_updateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_update"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_update([NotNull] TSqlParser.On_updateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_index_options([NotNull] TSqlParser.Alter_table_index_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table_index_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_index_options([NotNull] TSqlParser.Alter_table_index_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.alter_table_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_index_option([NotNull] TSqlParser.Alter_table_index_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.alter_table_index_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_index_option([NotNull] TSqlParser.Alter_table_index_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_cursor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_cursor([NotNull] TSqlParser.Declare_cursorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_cursor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_cursor([NotNull] TSqlParser.Declare_cursorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_set_cursor_common([NotNull] TSqlParser.Declare_set_cursor_commonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_set_cursor_common([NotNull] TSqlParser.Declare_set_cursor_commonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common_partial"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_set_cursor_common_partial([NotNull] TSqlParser.Declare_set_cursor_common_partialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.declare_set_cursor_common_partial"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_set_cursor_common_partial([NotNull] TSqlParser.Declare_set_cursor_common_partialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.fetch_cursor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFetch_cursor([NotNull] TSqlParser.Fetch_cursorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.fetch_cursor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFetch_cursor([NotNull] TSqlParser.Fetch_cursorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.set_special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_special([NotNull] TSqlParser.Set_specialContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.set_special"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_special([NotNull] TSqlParser.Set_specialContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.special_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecial_list([NotNull] TSqlParser.Special_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.special_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecial_list([NotNull] TSqlParser.Special_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant_LOCAL_ID"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant_LOCAL_ID([NotNull] TSqlParser.Constant_LOCAL_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant_LOCAL_ID"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant_LOCAL_ID([NotNull] TSqlParser.Constant_LOCAL_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] TSqlParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] TSqlParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] TSqlParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] TSqlParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.time_zone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTime_zone([NotNull] TSqlParser.Time_zoneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.time_zone"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTime_zone([NotNull] TSqlParser.Time_zoneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.primitive_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.primitive_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimitive_expression([NotNull] TSqlParser.Primitive_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.case_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_expression([NotNull] TSqlParser.Case_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.case_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_expression([NotNull] TSqlParser.Case_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unary_operator_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_operator_expression([NotNull] TSqlParser.Unary_operator_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unary_operator_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_operator_expression([NotNull] TSqlParser.Unary_operator_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.bracket_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBracket_expression([NotNull] TSqlParser.Bracket_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.bracket_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBracket_expression([NotNull] TSqlParser.Bracket_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant_expression([NotNull] TSqlParser.Constant_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant_expression([NotNull] TSqlParser.Constant_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery([NotNull] TSqlParser.SubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery([NotNull] TSqlParser.SubqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.with_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_expression([NotNull] TSqlParser.With_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.with_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_expression([NotNull] TSqlParser.With_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_expression([NotNull] TSqlParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_expression([NotNull] TSqlParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_elem([NotNull] TSqlParser.Update_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_elem([NotNull] TSqlParser.Update_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.update_elem_merge"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_elem_merge([NotNull] TSqlParser.Update_elem_mergeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.update_elem_merge"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_elem_merge([NotNull] TSqlParser.Update_elem_mergeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.search_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearch_condition([NotNull] TSqlParser.Search_conditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.search_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearch_condition([NotNull] TSqlParser.Search_conditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicate([NotNull] TSqlParser.PredicateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicate([NotNull] TSqlParser.PredicateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_expression([NotNull] TSqlParser.Query_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_expression([NotNull] TSqlParser.Query_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sql_union"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_union([NotNull] TSqlParser.Sql_unionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sql_union"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_union([NotNull] TSqlParser.Sql_unionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_specification([NotNull] TSqlParser.Query_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_specification([NotNull] TSqlParser.Query_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTop_clause([NotNull] TSqlParser.Top_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTop_clause([NotNull] TSqlParser.Top_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_percent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTop_percent([NotNull] TSqlParser.Top_percentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_percent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTop_percent([NotNull] TSqlParser.Top_percentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.top_count"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTop_count([NotNull] TSqlParser.Top_countContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.top_count"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTop_count([NotNull] TSqlParser.Top_countContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_clause([NotNull] TSqlParser.Order_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_clause([NotNull] TSqlParser.Order_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_order_by_clause([NotNull] TSqlParser.Select_order_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_order_by_clause([NotNull] TSqlParser.Select_order_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.for_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_clause([NotNull] TSqlParser.For_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.for_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_clause([NotNull] TSqlParser.For_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_common_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_common_directives([NotNull] TSqlParser.Xml_common_directivesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_common_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_common_directives([NotNull] TSqlParser.Xml_common_directivesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.order_by_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_expression([NotNull] TSqlParser.Order_by_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.order_by_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_expression([NotNull] TSqlParser.Order_by_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.grouping_sets_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrouping_sets_item([NotNull] TSqlParser.Grouping_sets_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.grouping_sets_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrouping_sets_item([NotNull] TSqlParser.Grouping_sets_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.group_by_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_by_item([NotNull] TSqlParser.Group_by_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.group_by_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_by_item([NotNull] TSqlParser.Group_by_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.option_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOption_clause([NotNull] TSqlParser.Option_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.option_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOption_clause([NotNull] TSqlParser.Option_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOption([NotNull] TSqlParser.OptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOption([NotNull] TSqlParser.OptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.optimize_for_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptimize_for_arg([NotNull] TSqlParser.Optimize_for_argContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.optimize_for_arg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptimize_for_arg([NotNull] TSqlParser.Optimize_for_argContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_list([NotNull] TSqlParser.Select_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_list([NotNull] TSqlParser.Select_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.udt_method_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUdt_method_arguments([NotNull] TSqlParser.Udt_method_argumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.udt_method_arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUdt_method_arguments([NotNull] TSqlParser.Udt_method_argumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.asterisk"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsterisk([NotNull] TSqlParser.AsteriskContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.asterisk"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsterisk([NotNull] TSqlParser.AsteriskContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_elem([NotNull] TSqlParser.Column_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_elem([NotNull] TSqlParser.Column_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.udt_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUdt_elem([NotNull] TSqlParser.Udt_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.udt_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUdt_elem([NotNull] TSqlParser.Udt_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression_elem([NotNull] TSqlParser.Expression_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression_elem([NotNull] TSqlParser.Expression_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.select_list_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.select_list_elem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_list_elem([NotNull] TSqlParser.Select_list_elemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_sources"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_sources([NotNull] TSqlParser.Table_sourcesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_sources"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_sources([NotNull] TSqlParser.Table_sourcesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_source([NotNull] TSqlParser.Table_sourceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_source([NotNull] TSqlParser.Table_sourceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source_item_joined"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_source_item_joined([NotNull] TSqlParser.Table_source_item_joinedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source_item_joined"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_source_item_joined([NotNull] TSqlParser.Table_source_item_joinedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_source_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_source_item([NotNull] TSqlParser.Table_source_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_source_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_source_item([NotNull] TSqlParser.Table_source_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_xml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpen_xml([NotNull] TSqlParser.Open_xmlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_xml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpen_xml([NotNull] TSqlParser.Open_xmlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.open_json"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpen_json([NotNull] TSqlParser.Open_jsonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.open_json"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpen_json([NotNull] TSqlParser.Open_jsonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.json_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJson_declaration([NotNull] TSqlParser.Json_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.json_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJson_declaration([NotNull] TSqlParser.Json_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.json_column_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJson_column_declaration([NotNull] TSqlParser.Json_column_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.json_column_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJson_column_declaration([NotNull] TSqlParser.Json_column_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.schema_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_declaration([NotNull] TSqlParser.Schema_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.schema_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_declaration([NotNull] TSqlParser.Schema_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_declaration([NotNull] TSqlParser.Column_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_declaration([NotNull] TSqlParser.Column_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChange_table([NotNull] TSqlParser.Change_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChange_table([NotNull] TSqlParser.Change_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table_changes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChange_table_changes([NotNull] TSqlParser.Change_table_changesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table_changes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChange_table_changes([NotNull] TSqlParser.Change_table_changesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.change_table_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChange_table_version([NotNull] TSqlParser.Change_table_versionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.change_table_version"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChange_table_version([NotNull] TSqlParser.Change_table_versionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.join_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_part([NotNull] TSqlParser.Join_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.join_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_part([NotNull] TSqlParser.Join_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.join_on"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_on([NotNull] TSqlParser.Join_onContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.join_on"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_on([NotNull] TSqlParser.Join_onContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cross_join"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCross_join([NotNull] TSqlParser.Cross_joinContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cross_join"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCross_join([NotNull] TSqlParser.Cross_joinContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.apply_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterApply_([NotNull] TSqlParser.Apply_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.apply_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitApply_([NotNull] TSqlParser.Apply_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.pivot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot([NotNull] TSqlParser.PivotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.pivot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot([NotNull] TSqlParser.PivotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unpivot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnpivot([NotNull] TSqlParser.UnpivotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unpivot"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnpivot([NotNull] TSqlParser.UnpivotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.pivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_clause([NotNull] TSqlParser.Pivot_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.pivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_clause([NotNull] TSqlParser.Pivot_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.unpivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnpivot_clause([NotNull] TSqlParser.Unpivot_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.unpivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnpivot_clause([NotNull] TSqlParser.Unpivot_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFull_column_name_list([NotNull] TSqlParser.Full_column_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFull_column_name_list([NotNull] TSqlParser.Full_column_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.rowset_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowset_function([NotNull] TSqlParser.Rowset_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.rowset_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowset_function([NotNull] TSqlParser.Rowset_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.bulk_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBulk_option([NotNull] TSqlParser.Bulk_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.bulk_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBulk_option([NotNull] TSqlParser.Bulk_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.derived_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDerived_table([NotNull] TSqlParser.Derived_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.derived_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDerived_table([NotNull] TSqlParser.Derived_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RANKING_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRANKING_WINDOWED_FUNC([NotNull] TSqlParser.RANKING_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RANKING_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRANKING_WINDOWED_FUNC([NotNull] TSqlParser.RANKING_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>AGGREGATE_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAGGREGATE_WINDOWED_FUNC([NotNull] TSqlParser.AGGREGATE_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>AGGREGATE_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAGGREGATE_WINDOWED_FUNC([NotNull] TSqlParser.AGGREGATE_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ANALYTIC_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterANALYTIC_WINDOWED_FUNC([NotNull] TSqlParser.ANALYTIC_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ANALYTIC_WINDOWED_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitANALYTIC_WINDOWED_FUNC([NotNull] TSqlParser.ANALYTIC_WINDOWED_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BUILT_IN_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBUILT_IN_FUNC([NotNull] TSqlParser.BUILT_IN_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BUILT_IN_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBUILT_IN_FUNC([NotNull] TSqlParser.BUILT_IN_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SCALAR_FUNCTION</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSCALAR_FUNCTION([NotNull] TSqlParser.SCALAR_FUNCTIONContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SCALAR_FUNCTION</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSCALAR_FUNCTION([NotNull] TSqlParser.SCALAR_FUNCTIONContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FREE_TEXT</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFREE_TEXT([NotNull] TSqlParser.FREE_TEXTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FREE_TEXT</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFREE_TEXT([NotNull] TSqlParser.FREE_TEXTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PARTITION_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPARTITION_FUNC([NotNull] TSqlParser.PARTITION_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PARTITION_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPARTITION_FUNC([NotNull] TSqlParser.PARTITION_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>HIERARCHYID_METHOD</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHIERARCHYID_METHOD([NotNull] TSqlParser.HIERARCHYID_METHODContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>HIERARCHYID_METHOD</c>
	/// labeled alternative in <see cref="TSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHIERARCHYID_METHOD([NotNull] TSqlParser.HIERARCHYID_METHODContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_function([NotNull] TSqlParser.Partition_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.partition_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_function([NotNull] TSqlParser.Partition_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.freetext_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFreetext_function([NotNull] TSqlParser.Freetext_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.freetext_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFreetext_function([NotNull] TSqlParser.Freetext_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.freetext_predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFreetext_predicate([NotNull] TSqlParser.Freetext_predicateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.freetext_predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFreetext_predicate([NotNull] TSqlParser.Freetext_predicateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>APP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAPP_NAME([NotNull] TSqlParser.APP_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>APP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAPP_NAME([NotNull] TSqlParser.APP_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>APPLOCK_MODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAPPLOCK_MODE([NotNull] TSqlParser.APPLOCK_MODEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>APPLOCK_MODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAPPLOCK_MODE([NotNull] TSqlParser.APPLOCK_MODEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>APPLOCK_TEST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAPPLOCK_TEST([NotNull] TSqlParser.APPLOCK_TESTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>APPLOCK_TEST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAPPLOCK_TEST([NotNull] TSqlParser.APPLOCK_TESTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ASSEMBLYPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterASSEMBLYPROPERTY([NotNull] TSqlParser.ASSEMBLYPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ASSEMBLYPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitASSEMBLYPROPERTY([NotNull] TSqlParser.ASSEMBLYPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>COL_LENGTH</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCOL_LENGTH([NotNull] TSqlParser.COL_LENGTHContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>COL_LENGTH</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCOL_LENGTH([NotNull] TSqlParser.COL_LENGTHContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>COL_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCOL_NAME([NotNull] TSqlParser.COL_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>COL_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCOL_NAME([NotNull] TSqlParser.COL_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>COLUMNPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCOLUMNPROPERTY([NotNull] TSqlParser.COLUMNPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>COLUMNPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCOLUMNPROPERTY([NotNull] TSqlParser.COLUMNPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DATABASEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDATABASEPROPERTYEX([NotNull] TSqlParser.DATABASEPROPERTYEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DATABASEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDATABASEPROPERTYEX([NotNull] TSqlParser.DATABASEPROPERTYEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DB_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDB_ID([NotNull] TSqlParser.DB_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DB_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDB_ID([NotNull] TSqlParser.DB_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDB_NAME([NotNull] TSqlParser.DB_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDB_NAME([NotNull] TSqlParser.DB_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILE_ID([NotNull] TSqlParser.FILE_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILE_ID([NotNull] TSqlParser.FILE_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_IDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILE_IDEX([NotNull] TSqlParser.FILE_IDEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_IDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILE_IDEX([NotNull] TSqlParser.FILE_IDEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILE_NAME([NotNull] TSqlParser.FILE_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILE_NAME([NotNull] TSqlParser.FILE_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUP_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILEGROUP_ID([NotNull] TSqlParser.FILEGROUP_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUP_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILEGROUP_ID([NotNull] TSqlParser.FILEGROUP_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILEGROUP_NAME([NotNull] TSqlParser.FILEGROUP_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUP_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILEGROUP_NAME([NotNull] TSqlParser.FILEGROUP_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEGROUPPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILEGROUPPROPERTY([NotNull] TSqlParser.FILEGROUPPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEGROUPPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILEGROUPPROPERTY([NotNull] TSqlParser.FILEGROUPPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILEPROPERTY([NotNull] TSqlParser.FILEPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILEPROPERTY([NotNull] TSqlParser.FILEPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FILEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFILEPROPERTYEX([NotNull] TSqlParser.FILEPROPERTYEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FILEPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFILEPROPERTYEX([NotNull] TSqlParser.FILEPROPERTYEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FULLTEXTCATALOGPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFULLTEXTCATALOGPROPERTY([NotNull] TSqlParser.FULLTEXTCATALOGPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FULLTEXTCATALOGPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFULLTEXTCATALOGPROPERTY([NotNull] TSqlParser.FULLTEXTCATALOGPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FULLTEXTSERVICEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFULLTEXTSERVICEPROPERTY([NotNull] TSqlParser.FULLTEXTSERVICEPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FULLTEXTSERVICEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFULLTEXTSERVICEPROPERTY([NotNull] TSqlParser.FULLTEXTSERVICEPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEX_COL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterINDEX_COL([NotNull] TSqlParser.INDEX_COLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEX_COL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitINDEX_COL([NotNull] TSqlParser.INDEX_COLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEXKEY_PROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterINDEXKEY_PROPERTY([NotNull] TSqlParser.INDEXKEY_PROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEXKEY_PROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitINDEXKEY_PROPERTY([NotNull] TSqlParser.INDEXKEY_PROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>INDEXPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterINDEXPROPERTY([NotNull] TSqlParser.INDEXPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>INDEXPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitINDEXPROPERTY([NotNull] TSqlParser.INDEXPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NEXT_VALUE_FOR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNEXT_VALUE_FOR([NotNull] TSqlParser.NEXT_VALUE_FORContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NEXT_VALUE_FOR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNEXT_VALUE_FOR([NotNull] TSqlParser.NEXT_VALUE_FORContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_DEFINITION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECT_DEFINITION([NotNull] TSqlParser.OBJECT_DEFINITIONContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_DEFINITION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECT_DEFINITION([NotNull] TSqlParser.OBJECT_DEFINITIONContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECT_ID([NotNull] TSqlParser.OBJECT_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECT_ID([NotNull] TSqlParser.OBJECT_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECT_NAME([NotNull] TSqlParser.OBJECT_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECT_NAME([NotNull] TSqlParser.OBJECT_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECT_SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECT_SCHEMA_NAME([NotNull] TSqlParser.OBJECT_SCHEMA_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECT_SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECT_SCHEMA_NAME([NotNull] TSqlParser.OBJECT_SCHEMA_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECTPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECTPROPERTY([NotNull] TSqlParser.OBJECTPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECTPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECTPROPERTY([NotNull] TSqlParser.OBJECTPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>OBJECTPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOBJECTPROPERTYEX([NotNull] TSqlParser.OBJECTPROPERTYEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>OBJECTPROPERTYEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOBJECTPROPERTYEX([NotNull] TSqlParser.OBJECTPROPERTYEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ORIGINAL_DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterORIGINAL_DB_NAME([NotNull] TSqlParser.ORIGINAL_DB_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ORIGINAL_DB_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitORIGINAL_DB_NAME([NotNull] TSqlParser.ORIGINAL_DB_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PARSENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPARSENAME([NotNull] TSqlParser.PARSENAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PARSENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPARSENAME([NotNull] TSqlParser.PARSENAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SCHEMA_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSCHEMA_ID([NotNull] TSqlParser.SCHEMA_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SCHEMA_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSCHEMA_ID([NotNull] TSqlParser.SCHEMA_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSCHEMA_NAME([NotNull] TSqlParser.SCHEMA_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SCHEMA_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSCHEMA_NAME([NotNull] TSqlParser.SCHEMA_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SCOPE_IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSCOPE_IDENTITY([NotNull] TSqlParser.SCOPE_IDENTITYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SCOPE_IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSCOPE_IDENTITY([NotNull] TSqlParser.SCOPE_IDENTITYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SERVERPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSERVERPROPERTY([NotNull] TSqlParser.SERVERPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SERVERPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSERVERPROPERTY([NotNull] TSqlParser.SERVERPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>STATS_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSTATS_DATE([NotNull] TSqlParser.STATS_DATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>STATS_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSTATS_DATE([NotNull] TSqlParser.STATS_DATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTYPE_ID([NotNull] TSqlParser.TYPE_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPE_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTYPE_ID([NotNull] TSqlParser.TYPE_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTYPE_NAME([NotNull] TSqlParser.TYPE_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPE_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTYPE_NAME([NotNull] TSqlParser.TYPE_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TYPEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTYPEPROPERTY([NotNull] TSqlParser.TYPEPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TYPEPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTYPEPROPERTY([NotNull] TSqlParser.TYPEPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ASCII</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterASCII([NotNull] TSqlParser.ASCIIContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ASCII</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitASCII([NotNull] TSqlParser.ASCIIContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCHAR([NotNull] TSqlParser.CHARContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCHAR([NotNull] TSqlParser.CHARContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CHARINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCHARINDEX([NotNull] TSqlParser.CHARINDEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CHARINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCHARINDEX([NotNull] TSqlParser.CHARINDEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CONCAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCONCAT([NotNull] TSqlParser.CONCATContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CONCAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCONCAT([NotNull] TSqlParser.CONCATContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CONCAT_WS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCONCAT_WS([NotNull] TSqlParser.CONCAT_WSContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CONCAT_WS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCONCAT_WS([NotNull] TSqlParser.CONCAT_WSContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DIFFERENCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDIFFERENCE([NotNull] TSqlParser.DIFFERENCEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DIFFERENCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDIFFERENCE([NotNull] TSqlParser.DIFFERENCEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FORMAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFORMAT([NotNull] TSqlParser.FORMATContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FORMAT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFORMAT([NotNull] TSqlParser.FORMATContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LEFT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLEFT([NotNull] TSqlParser.LEFTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LEFT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLEFT([NotNull] TSqlParser.LEFTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LEN</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLEN([NotNull] TSqlParser.LENContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LEN</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLEN([NotNull] TSqlParser.LENContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LOWER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLOWER([NotNull] TSqlParser.LOWERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LOWER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLOWER([NotNull] TSqlParser.LOWERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>LTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLTRIM([NotNull] TSqlParser.LTRIMContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>LTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLTRIM([NotNull] TSqlParser.LTRIMContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NCHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNCHAR([NotNull] TSqlParser.NCHARContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NCHAR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNCHAR([NotNull] TSqlParser.NCHARContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PATINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPATINDEX([NotNull] TSqlParser.PATINDEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PATINDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPATINDEX([NotNull] TSqlParser.PATINDEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>QUOTENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQUOTENAME([NotNull] TSqlParser.QUOTENAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>QUOTENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQUOTENAME([NotNull] TSqlParser.QUOTENAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>REPLACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterREPLACE([NotNull] TSqlParser.REPLACEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>REPLACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitREPLACE([NotNull] TSqlParser.REPLACEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>REPLICATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterREPLICATE([NotNull] TSqlParser.REPLICATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>REPLICATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitREPLICATE([NotNull] TSqlParser.REPLICATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>REVERSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterREVERSE([NotNull] TSqlParser.REVERSEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>REVERSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitREVERSE([NotNull] TSqlParser.REVERSEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RIGHT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRIGHT([NotNull] TSqlParser.RIGHTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RIGHT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRIGHT([NotNull] TSqlParser.RIGHTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>RTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRTRIM([NotNull] TSqlParser.RTRIMContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>RTRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRTRIM([NotNull] TSqlParser.RTRIMContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SOUNDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSOUNDEX([NotNull] TSqlParser.SOUNDEXContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SOUNDEX</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSOUNDEX([NotNull] TSqlParser.SOUNDEXContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SPACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSPACE([NotNull] TSqlParser.SPACEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SPACE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSPACE([NotNull] TSqlParser.SPACEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>STR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSTR([NotNull] TSqlParser.STRContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>STR</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSTR([NotNull] TSqlParser.STRContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>STRINGAGG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSTRINGAGG([NotNull] TSqlParser.STRINGAGGContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>STRINGAGG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSTRINGAGG([NotNull] TSqlParser.STRINGAGGContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>STRING_ESCAPE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSTRING_ESCAPE([NotNull] TSqlParser.STRING_ESCAPEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>STRING_ESCAPE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSTRING_ESCAPE([NotNull] TSqlParser.STRING_ESCAPEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>STUFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSTUFF([NotNull] TSqlParser.STUFFContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>STUFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSTUFF([NotNull] TSqlParser.STUFFContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SUBSTRING</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSUBSTRING([NotNull] TSqlParser.SUBSTRINGContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SUBSTRING</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSUBSTRING([NotNull] TSqlParser.SUBSTRINGContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TRANSLATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTRANSLATE([NotNull] TSqlParser.TRANSLATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TRANSLATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTRANSLATE([NotNull] TSqlParser.TRANSLATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTRIM([NotNull] TSqlParser.TRIMContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TRIM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTRIM([NotNull] TSqlParser.TRIMContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UNICODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUNICODE([NotNull] TSqlParser.UNICODEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UNICODE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUNICODE([NotNull] TSqlParser.UNICODEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>UPPER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUPPER([NotNull] TSqlParser.UPPERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>UPPER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUPPER([NotNull] TSqlParser.UPPERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>BINARY_CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBINARY_CHECKSUM([NotNull] TSqlParser.BINARY_CHECKSUMContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>BINARY_CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBINARY_CHECKSUM([NotNull] TSqlParser.BINARY_CHECKSUMContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCHECKSUM([NotNull] TSqlParser.CHECKSUMContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CHECKSUM</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCHECKSUM([NotNull] TSqlParser.CHECKSUMContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>COMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCOMPRESS([NotNull] TSqlParser.COMPRESSContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>COMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCOMPRESS([NotNull] TSqlParser.COMPRESSContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CONNECTIONPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCONNECTIONPROPERTY([NotNull] TSqlParser.CONNECTIONPROPERTYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CONNECTIONPROPERTY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCONNECTIONPROPERTY([NotNull] TSqlParser.CONNECTIONPROPERTYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CONTEXT_INFO</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCONTEXT_INFO([NotNull] TSqlParser.CONTEXT_INFOContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CONTEXT_INFO</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCONTEXT_INFO([NotNull] TSqlParser.CONTEXT_INFOContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_REQUEST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCURRENT_REQUEST_ID([NotNull] TSqlParser.CURRENT_REQUEST_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_REQUEST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCURRENT_REQUEST_ID([NotNull] TSqlParser.CURRENT_REQUEST_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_TRANSACTION_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCURRENT_TRANSACTION_ID([NotNull] TSqlParser.CURRENT_TRANSACTION_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_TRANSACTION_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCURRENT_TRANSACTION_ID([NotNull] TSqlParser.CURRENT_TRANSACTION_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DECOMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDECOMPRESS([NotNull] TSqlParser.DECOMPRESSContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DECOMPRESS</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDECOMPRESS([NotNull] TSqlParser.DECOMPRESSContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_LINE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_LINE([NotNull] TSqlParser.ERROR_LINEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_LINE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_LINE([NotNull] TSqlParser.ERROR_LINEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_MESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_MESSAGE([NotNull] TSqlParser.ERROR_MESSAGEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_MESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_MESSAGE([NotNull] TSqlParser.ERROR_MESSAGEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_NUMBER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_NUMBER([NotNull] TSqlParser.ERROR_NUMBERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_NUMBER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_NUMBER([NotNull] TSqlParser.ERROR_NUMBERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_PROCEDURE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_PROCEDURE([NotNull] TSqlParser.ERROR_PROCEDUREContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_PROCEDURE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_PROCEDURE([NotNull] TSqlParser.ERROR_PROCEDUREContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_SEVERITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_SEVERITY([NotNull] TSqlParser.ERROR_SEVERITYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_SEVERITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_SEVERITY([NotNull] TSqlParser.ERROR_SEVERITYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ERROR_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterERROR_STATE([NotNull] TSqlParser.ERROR_STATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ERROR_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitERROR_STATE([NotNull] TSqlParser.ERROR_STATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>FORMATMESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFORMATMESSAGE([NotNull] TSqlParser.FORMATMESSAGEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>FORMATMESSAGE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFORMATMESSAGE([NotNull] TSqlParser.FORMATMESSAGEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GET_FILESTREAM_TRANSACTION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGET_FILESTREAM_TRANSACTION_CONTEXT([NotNull] TSqlParser.GET_FILESTREAM_TRANSACTION_CONTEXTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GET_FILESTREAM_TRANSACTION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGET_FILESTREAM_TRANSACTION_CONTEXT([NotNull] TSqlParser.GET_FILESTREAM_TRANSACTION_CONTEXTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GETANSINULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGETANSINULL([NotNull] TSqlParser.GETANSINULLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GETANSINULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGETANSINULL([NotNull] TSqlParser.GETANSINULLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>HOST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHOST_ID([NotNull] TSqlParser.HOST_IDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>HOST_ID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHOST_ID([NotNull] TSqlParser.HOST_IDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>HOST_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHOST_NAME([NotNull] TSqlParser.HOST_NAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>HOST_NAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHOST_NAME([NotNull] TSqlParser.HOST_NAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ISNULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterISNULL([NotNull] TSqlParser.ISNULLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ISNULL</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitISNULL([NotNull] TSqlParser.ISNULLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ISNUMERIC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterISNUMERIC([NotNull] TSqlParser.ISNUMERICContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ISNUMERIC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitISNUMERIC([NotNull] TSqlParser.ISNUMERICContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>MIN_ACTIVE_ROWVERSION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMIN_ACTIVE_ROWVERSION([NotNull] TSqlParser.MIN_ACTIVE_ROWVERSIONContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>MIN_ACTIVE_ROWVERSION</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMIN_ACTIVE_ROWVERSION([NotNull] TSqlParser.MIN_ACTIVE_ROWVERSIONContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NEWID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNEWID([NotNull] TSqlParser.NEWIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NEWID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNEWID([NotNull] TSqlParser.NEWIDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NEWSEQUENTIALID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNEWSEQUENTIALID([NotNull] TSqlParser.NEWSEQUENTIALIDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NEWSEQUENTIALID</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNEWSEQUENTIALID([NotNull] TSqlParser.NEWSEQUENTIALIDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ROWCOUNT_BIG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterROWCOUNT_BIG([NotNull] TSqlParser.ROWCOUNT_BIGContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ROWCOUNT_BIG</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitROWCOUNT_BIG([NotNull] TSqlParser.ROWCOUNT_BIGContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SESSION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSESSION_CONTEXT([NotNull] TSqlParser.SESSION_CONTEXTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SESSION_CONTEXT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSESSION_CONTEXT([NotNull] TSqlParser.SESSION_CONTEXTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>XACT_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXACT_STATE([NotNull] TSqlParser.XACT_STATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>XACT_STATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXACT_STATE([NotNull] TSqlParser.XACT_STATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCAST([NotNull] TSqlParser.CASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCAST([NotNull] TSqlParser.CASTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>TRY_CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTRY_CAST([NotNull] TSqlParser.TRY_CASTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>TRY_CAST</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTRY_CAST([NotNull] TSqlParser.TRY_CASTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CONVERT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCONVERT([NotNull] TSqlParser.CONVERTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CONVERT</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCONVERT([NotNull] TSqlParser.CONVERTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>COALESCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCOALESCE([NotNull] TSqlParser.COALESCEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>COALESCE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCOALESCE([NotNull] TSqlParser.COALESCEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCURRENT_DATE([NotNull] TSqlParser.CURRENT_DATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_DATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCURRENT_DATE([NotNull] TSqlParser.CURRENT_DATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_TIMESTAMP</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCURRENT_TIMESTAMP([NotNull] TSqlParser.CURRENT_TIMESTAMPContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_TIMESTAMP</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCURRENT_TIMESTAMP([NotNull] TSqlParser.CURRENT_TIMESTAMPContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>CURRENT_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCURRENT_USER([NotNull] TSqlParser.CURRENT_USERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>CURRENT_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCURRENT_USER([NotNull] TSqlParser.CURRENT_USERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEADD</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDATEADD([NotNull] TSqlParser.DATEADDContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEADD</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDATEADD([NotNull] TSqlParser.DATEADDContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEDIFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDATEDIFF([NotNull] TSqlParser.DATEDIFFContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEDIFF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDATEDIFF([NotNull] TSqlParser.DATEDIFFContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DATENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDATENAME([NotNull] TSqlParser.DATENAMEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DATENAME</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDATENAME([NotNull] TSqlParser.DATENAMEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>DATEPART</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDATEPART([NotNull] TSqlParser.DATEPARTContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>DATEPART</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDATEPART([NotNull] TSqlParser.DATEPARTContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GETDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGETDATE([NotNull] TSqlParser.GETDATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GETDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGETDATE([NotNull] TSqlParser.GETDATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>GETUTCDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGETUTCDATE([NotNull] TSqlParser.GETUTCDATEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>GETUTCDATE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGETUTCDATE([NotNull] TSqlParser.GETUTCDATEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIDENTITY([NotNull] TSqlParser.IDENTITYContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IDENTITY</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIDENTITY([NotNull] TSqlParser.IDENTITYContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>NULLIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNULLIF([NotNull] TSqlParser.NULLIFContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>NULLIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNULLIF([NotNull] TSqlParser.NULLIFContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SESSION_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSESSION_USER([NotNull] TSqlParser.SESSION_USERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SESSION_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSESSION_USER([NotNull] TSqlParser.SESSION_USERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>SYSTEM_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSYSTEM_USER([NotNull] TSqlParser.SYSTEM_USERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>SYSTEM_USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSYSTEM_USER([NotNull] TSqlParser.SYSTEM_USERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUSER([NotNull] TSqlParser.USERContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>USER</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUSER([NotNull] TSqlParser.USERContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>PARSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPARSE([NotNull] TSqlParser.PARSEContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>PARSE</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPARSE([NotNull] TSqlParser.PARSEContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>XML_DATA_TYPE_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXML_DATA_TYPE_FUNC([NotNull] TSqlParser.XML_DATA_TYPE_FUNCContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>XML_DATA_TYPE_FUNC</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXML_DATA_TYPE_FUNC([NotNull] TSqlParser.XML_DATA_TYPE_FUNCContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>IIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIIF([NotNull] TSqlParser.IIFContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>IIF</c>
	/// labeled alternative in <see cref="TSqlParser.built_in_functions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIIF([NotNull] TSqlParser.IIFContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.xml_data_type_methods"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_data_type_methods([NotNull] TSqlParser.Xml_data_type_methodsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.xml_data_type_methods"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_data_type_methods([NotNull] TSqlParser.Xml_data_type_methodsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.value_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue_method([NotNull] TSqlParser.Value_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.value_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue_method([NotNull] TSqlParser.Value_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.value_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue_call([NotNull] TSqlParser.Value_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.value_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue_call([NotNull] TSqlParser.Value_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_method([NotNull] TSqlParser.Query_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_method([NotNull] TSqlParser.Query_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.query_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_call([NotNull] TSqlParser.Query_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.query_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_call([NotNull] TSqlParser.Query_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.exist_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExist_method([NotNull] TSqlParser.Exist_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.exist_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExist_method([NotNull] TSqlParser.Exist_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.exist_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExist_call([NotNull] TSqlParser.Exist_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.exist_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExist_call([NotNull] TSqlParser.Exist_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.modify_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_method([NotNull] TSqlParser.Modify_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.modify_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_method([NotNull] TSqlParser.Modify_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.modify_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_call([NotNull] TSqlParser.Modify_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.modify_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_call([NotNull] TSqlParser.Modify_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hierarchyid_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHierarchyid_call([NotNull] TSqlParser.Hierarchyid_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hierarchyid_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHierarchyid_call([NotNull] TSqlParser.Hierarchyid_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.hierarchyid_static_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHierarchyid_static_method([NotNull] TSqlParser.Hierarchyid_static_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.hierarchyid_static_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHierarchyid_static_method([NotNull] TSqlParser.Hierarchyid_static_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.nodes_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNodes_method([NotNull] TSqlParser.Nodes_methodContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.nodes_method"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNodes_method([NotNull] TSqlParser.Nodes_methodContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_section([NotNull] TSqlParser.Switch_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_section([NotNull] TSqlParser.Switch_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.switch_search_condition_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_search_condition_section([NotNull] TSqlParser.Switch_search_condition_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.switch_search_condition_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_search_condition_section([NotNull] TSqlParser.Switch_search_condition_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAs_column_alias([NotNull] TSqlParser.As_column_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAs_column_alias([NotNull] TSqlParser.As_column_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.as_table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAs_table_alias([NotNull] TSqlParser.As_table_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.as_table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAs_table_alias([NotNull] TSqlParser.As_table_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_alias([NotNull] TSqlParser.Table_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_alias([NotNull] TSqlParser.Table_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.with_table_hints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_table_hints([NotNull] TSqlParser.With_table_hintsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.with_table_hints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_table_hints([NotNull] TSqlParser.With_table_hintsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.deprecated_table_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeprecated_table_hint([NotNull] TSqlParser.Deprecated_table_hintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.deprecated_table_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeprecated_table_hint([NotNull] TSqlParser.Deprecated_table_hintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sybase_legacy_hints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSybase_legacy_hints([NotNull] TSqlParser.Sybase_legacy_hintsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sybase_legacy_hints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSybase_legacy_hints([NotNull] TSqlParser.Sybase_legacy_hintsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sybase_legacy_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSybase_legacy_hint([NotNull] TSqlParser.Sybase_legacy_hintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sybase_legacy_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSybase_legacy_hint([NotNull] TSqlParser.Sybase_legacy_hintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_hint([NotNull] TSqlParser.Table_hintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_hint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_hint([NotNull] TSqlParser.Table_hintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.index_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_value([NotNull] TSqlParser.Index_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.index_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_value([NotNull] TSqlParser.Index_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_alias_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_alias_list([NotNull] TSqlParser.Column_alias_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_alias_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_alias_list([NotNull] TSqlParser.Column_alias_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_alias([NotNull] TSqlParser.Column_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_alias([NotNull] TSqlParser.Column_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_value_constructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_value_constructor([NotNull] TSqlParser.Table_value_constructorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_value_constructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_value_constructor([NotNull] TSqlParser.Table_value_constructorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.expression_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression_list([NotNull] TSqlParser.Expression_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.expression_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression_list([NotNull] TSqlParser.Expression_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ranking_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRanking_windowed_function([NotNull] TSqlParser.Ranking_windowed_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ranking_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRanking_windowed_function([NotNull] TSqlParser.Ranking_windowed_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.aggregate_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_windowed_function([NotNull] TSqlParser.Aggregate_windowed_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.aggregate_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_windowed_function([NotNull] TSqlParser.Aggregate_windowed_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.analytic_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalytic_windowed_function([NotNull] TSqlParser.Analytic_windowed_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.analytic_windowed_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalytic_windowed_function([NotNull] TSqlParser.Analytic_windowed_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.all_distinct_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAll_distinct_expression([NotNull] TSqlParser.All_distinct_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.all_distinct_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAll_distinct_expression([NotNull] TSqlParser.All_distinct_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause([NotNull] TSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause([NotNull] TSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.row_or_range_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRow_or_range_clause([NotNull] TSqlParser.Row_or_range_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.row_or_range_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRow_or_range_clause([NotNull] TSqlParser.Row_or_range_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_extent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_frame_extent([NotNull] TSqlParser.Window_frame_extentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_extent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_frame_extent([NotNull] TSqlParser.Window_frame_extentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_frame_bound([NotNull] TSqlParser.Window_frame_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_frame_bound([NotNull] TSqlParser.Window_frame_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_preceding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_frame_preceding([NotNull] TSqlParser.Window_frame_precedingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_preceding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_frame_preceding([NotNull] TSqlParser.Window_frame_precedingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.window_frame_following"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_frame_following([NotNull] TSqlParser.Window_frame_followingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.window_frame_following"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_frame_following([NotNull] TSqlParser.Window_frame_followingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.create_database_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_database_option([NotNull] TSqlParser.Create_database_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.create_database_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_database_option([NotNull] TSqlParser.Create_database_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_filestream_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_filestream_option([NotNull] TSqlParser.Database_filestream_optionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_filestream_option"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_filestream_option([NotNull] TSqlParser.Database_filestream_optionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.database_file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_file_spec([NotNull] TSqlParser.Database_file_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.database_file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_file_spec([NotNull] TSqlParser.Database_file_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_group([NotNull] TSqlParser.File_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_group([NotNull] TSqlParser.File_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_spec([NotNull] TSqlParser.File_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_spec([NotNull] TSqlParser.File_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntity_name([NotNull] TSqlParser.Entity_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntity_name([NotNull] TSqlParser.Entity_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntity_name_for_azure_dw([NotNull] TSqlParser.Entity_name_for_azure_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name_for_azure_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntity_name_for_azure_dw([NotNull] TSqlParser.Entity_name_for_azure_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.entity_name_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEntity_name_for_parallel_dw([NotNull] TSqlParser.Entity_name_for_parallel_dwContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.entity_name_for_parallel_dw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEntity_name_for_parallel_dw([NotNull] TSqlParser.Entity_name_for_parallel_dwContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFull_table_name([NotNull] TSqlParser.Full_table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFull_table_name([NotNull] TSqlParser.Full_table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_name([NotNull] TSqlParser.Table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_name([NotNull] TSqlParser.Table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.simple_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_name([NotNull] TSqlParser.Simple_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.simple_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_name([NotNull] TSqlParser.Simple_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_proc_name_schema([NotNull] TSqlParser.Func_proc_name_schemaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_proc_name_schema([NotNull] TSqlParser.Func_proc_name_schemaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_database_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_proc_name_database_schema([NotNull] TSqlParser.Func_proc_name_database_schemaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_database_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_proc_name_database_schema([NotNull] TSqlParser.Func_proc_name_database_schemaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.func_proc_name_server_database_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_proc_name_server_database_schema([NotNull] TSqlParser.Func_proc_name_server_database_schemaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.func_proc_name_server_database_schema"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_proc_name_server_database_schema([NotNull] TSqlParser.Func_proc_name_server_database_schemaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.ddl_object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDdl_object([NotNull] TSqlParser.Ddl_objectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.ddl_object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDdl_object([NotNull] TSqlParser.Ddl_objectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.full_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFull_column_name([NotNull] TSqlParser.Full_column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.full_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFull_column_name([NotNull] TSqlParser.Full_column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_name_list_with_order"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name_list_with_order([NotNull] TSqlParser.Column_name_list_with_orderContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_name_list_with_order"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name_list_with_order([NotNull] TSqlParser.Column_name_list_with_orderContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_column_name_list([NotNull] TSqlParser.Insert_column_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_column_name_list([NotNull] TSqlParser.Insert_column_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.insert_column_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_column_id([NotNull] TSqlParser.Insert_column_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.insert_column_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_column_id([NotNull] TSqlParser.Insert_column_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name_list([NotNull] TSqlParser.Column_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name_list([NotNull] TSqlParser.Column_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_name([NotNull] TSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_name([NotNull] TSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.on_off"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_off([NotNull] TSqlParser.On_offContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.on_off"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_off([NotNull] TSqlParser.On_offContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.clustered"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClustered([NotNull] TSqlParser.ClusteredContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.clustered"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClustered([NotNull] TSqlParser.ClusteredContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.null_notnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull_notnull([NotNull] TSqlParser.Null_notnullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.null_notnull"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull_notnull([NotNull] TSqlParser.Null_notnullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.null_or_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull_or_default([NotNull] TSqlParser.Null_or_defaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.null_or_default"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull_or_default([NotNull] TSqlParser.Null_or_defaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.scalar_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterScalar_function_name([NotNull] TSqlParser.Scalar_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.scalar_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitScalar_function_name([NotNull] TSqlParser.Scalar_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.begin_conversation_timer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBegin_conversation_timer([NotNull] TSqlParser.Begin_conversation_timerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.begin_conversation_timer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBegin_conversation_timer([NotNull] TSqlParser.Begin_conversation_timerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.begin_conversation_dialog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBegin_conversation_dialog([NotNull] TSqlParser.Begin_conversation_dialogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.begin_conversation_dialog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBegin_conversation_dialog([NotNull] TSqlParser.Begin_conversation_dialogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.contract_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContract_name([NotNull] TSqlParser.Contract_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.contract_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContract_name([NotNull] TSqlParser.Contract_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.service_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterService_name([NotNull] TSqlParser.Service_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.service_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitService_name([NotNull] TSqlParser.Service_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.end_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnd_conversation([NotNull] TSqlParser.End_conversationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.end_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnd_conversation([NotNull] TSqlParser.End_conversationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.waitfor_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWaitfor_conversation([NotNull] TSqlParser.Waitfor_conversationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.waitfor_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWaitfor_conversation([NotNull] TSqlParser.Waitfor_conversationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.get_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGet_conversation([NotNull] TSqlParser.Get_conversationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.get_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGet_conversation([NotNull] TSqlParser.Get_conversationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.queue_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueue_id([NotNull] TSqlParser.Queue_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.queue_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueue_id([NotNull] TSqlParser.Queue_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.send_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSend_conversation([NotNull] TSqlParser.Send_conversationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.send_conversation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSend_conversation([NotNull] TSqlParser.Send_conversationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.data_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterData_type([NotNull] TSqlParser.Data_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.data_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitData_type([NotNull] TSqlParser.Data_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_value([NotNull] TSqlParser.Default_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_value([NotNull] TSqlParser.Default_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] TSqlParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] TSqlParser.ConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSign([NotNull] TSqlParser.SignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSign([NotNull] TSqlParser.SignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] TSqlParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] TSqlParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.id_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId_([NotNull] TSqlParser.Id_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.id_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId_([NotNull] TSqlParser.Id_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.simple_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_id([NotNull] TSqlParser.Simple_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.simple_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_id([NotNull] TSqlParser.Simple_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.id_or_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId_or_string([NotNull] TSqlParser.Id_or_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.id_or_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId_or_string([NotNull] TSqlParser.Id_or_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.comparison_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.comparison_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison_operator([NotNull] TSqlParser.Comparison_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.assignment_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_operator([NotNull] TSqlParser.Assignment_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.assignment_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_operator([NotNull] TSqlParser.Assignment_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="TSqlParser.file_size"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFile_size([NotNull] TSqlParser.File_sizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="TSqlParser.file_size"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFile_size([NotNull] TSqlParser.File_sizeContext context) { }

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
