using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SQLiteParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ISQLiteParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParse([NotNull] SQLiteParser.ParseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParse([NotNull] SQLiteParser.ParseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_def([NotNull] SQLiteParser.Column_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_def([NotNull] SQLiteParser.Column_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name([NotNull] SQLiteParser.Type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name([NotNull] SQLiteParser.Type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSigned_number([NotNull] SQLiteParser.Signed_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSigned_number([NotNull] SQLiteParser.Signed_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_constraint([NotNull] SQLiteParser.Table_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_constraint([NotNull] SQLiteParser.Table_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWith_clause([NotNull] SQLiteParser.With_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWith_clause([NotNull] SQLiteParser.With_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.recursive_cte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecursive_cte([NotNull] SQLiteParser.Recursive_cteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.recursive_cte"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecursive_cte([NotNull] SQLiteParser.Recursive_cteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.drop_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_stmt([NotNull] SQLiteParser.Drop_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.drop_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_stmt([NotNull] SQLiteParser.Drop_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] SQLiteParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] SQLiteParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRaise_function([NotNull] SQLiteParser.Raise_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRaise_function([NotNull] SQLiteParser.Raise_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral_value([NotNull] SQLiteParser.Literal_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral_value([NotNull] SQLiteParser.Literal_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturning_clause([NotNull] SQLiteParser.Returning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturning_clause([NotNull] SQLiteParser.Returning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.upsert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpsert_clause([NotNull] SQLiteParser.Upsert_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.upsert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpsert_clause([NotNull] SQLiteParser.Upsert_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_value([NotNull] SQLiteParser.Pragma_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_value([NotNull] SQLiteParser.Pragma_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_clause([NotNull] SQLiteParser.Join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_clause([NotNull] SQLiteParser.Join_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_core([NotNull] SQLiteParser.Select_coreContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_core([NotNull] SQLiteParser.Select_coreContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult_column([NotNull] SQLiteParser.Result_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult_column([NotNull] SQLiteParser.Result_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_operator([NotNull] SQLiteParser.Join_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_operator([NotNull] SQLiteParser.Join_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name_list([NotNull] SQLiteParser.Column_name_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_name_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name_list([NotNull] SQLiteParser.Column_name_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilter_clause([NotNull] SQLiteParser.Filter_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.filter_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilter_clause([NotNull] SQLiteParser.Filter_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_defn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_defn([NotNull] SQLiteParser.Window_defnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_defn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_defn([NotNull] SQLiteParser.Window_defnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause([NotNull] SQLiteParser.Over_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause([NotNull] SQLiteParser.Over_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_spec([NotNull] SQLiteParser.Frame_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_spec([NotNull] SQLiteParser.Frame_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_clause([NotNull] SQLiteParser.Frame_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_clause([NotNull] SQLiteParser.Frame_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_function_invocation([NotNull] SQLiteParser.Simple_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_function_invocation([NotNull] SQLiteParser.Simple_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.aggregate_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_function_invocation([NotNull] SQLiteParser.Aggregate_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.aggregate_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_function_invocation([NotNull] SQLiteParser.Aggregate_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_function_invocation([NotNull] SQLiteParser.Window_function_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_function_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_function_invocation([NotNull] SQLiteParser.Window_function_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.common_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_table_stmt([NotNull] SQLiteParser.Common_table_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.common_table_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_table_stmt([NotNull] SQLiteParser.Common_table_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_stmt([NotNull] SQLiteParser.Order_by_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_stmt([NotNull] SQLiteParser.Order_by_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.limit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimit_stmt([NotNull] SQLiteParser.Limit_stmtContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.limit_stmt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimit_stmt([NotNull] SQLiteParser.Limit_stmtContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrdering_term([NotNull] SQLiteParser.Ordering_termContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrdering_term([NotNull] SQLiteParser.Ordering_termContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsc_desc([NotNull] SQLiteParser.Asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsc_desc([NotNull] SQLiteParser.Asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_left"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_left([NotNull] SQLiteParser.Frame_leftContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_left"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_left([NotNull] SQLiteParser.Frame_leftContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_right"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_right([NotNull] SQLiteParser.Frame_rightContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_right"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_right([NotNull] SQLiteParser.Frame_rightContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_single"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrame_single([NotNull] SQLiteParser.Frame_singleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_single"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrame_single([NotNull] SQLiteParser.Frame_singleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_function([NotNull] SQLiteParser.Window_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_function([NotNull] SQLiteParser.Window_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.offset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffset([NotNull] SQLiteParser.OffsetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.offset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffset([NotNull] SQLiteParser.OffsetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_value([NotNull] SQLiteParser.Default_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.default_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_value([NotNull] SQLiteParser.Default_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.partition_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_by([NotNull] SQLiteParser.Partition_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.partition_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_by([NotNull] SQLiteParser.Partition_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_expr([NotNull] SQLiteParser.Order_by_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_expr([NotNull] SQLiteParser.Order_by_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_expr_asc_desc([NotNull] SQLiteParser.Order_by_expr_asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_expr_asc_desc([NotNull] SQLiteParser.Order_by_expr_asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr_asc_desc([NotNull] SQLiteParser.Expr_asc_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.expr_asc_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr_asc_desc([NotNull] SQLiteParser.Expr_asc_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.initial_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitial_select([NotNull] SQLiteParser.Initial_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.initial_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitial_select([NotNull] SQLiteParser.Initial_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.recursive_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecursive_select([NotNull] SQLiteParser.Recursive_selectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.recursive_select"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecursive_select([NotNull] SQLiteParser.Recursive_selectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_message([NotNull] SQLiteParser.Error_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_message([NotNull] SQLiteParser.Error_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_argument([NotNull] SQLiteParser.Module_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_argument([NotNull] SQLiteParser.Module_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias([NotNull] SQLiteParser.Column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias([NotNull] SQLiteParser.Column_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] SQLiteParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] SQLiteParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterName([NotNull] SQLiteParser.NameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitName([NotNull] SQLiteParser.NameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_name([NotNull] SQLiteParser.Function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_name([NotNull] SQLiteParser.Function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_name([NotNull] SQLiteParser.Schema_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_name([NotNull] SQLiteParser.Schema_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_name([NotNull] SQLiteParser.Table_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_name([NotNull] SQLiteParser.Table_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name([NotNull] SQLiteParser.Column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name([NotNull] SQLiteParser.Column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollation_name([NotNull] SQLiteParser.Collation_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollation_name([NotNull] SQLiteParser.Collation_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_table([NotNull] SQLiteParser.Foreign_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_table([NotNull] SQLiteParser.Foreign_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_name([NotNull] SQLiteParser.Index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_name([NotNull] SQLiteParser.Index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_name([NotNull] SQLiteParser.View_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_name([NotNull] SQLiteParser.View_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModule_name([NotNull] SQLiteParser.Module_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModule_name([NotNull] SQLiteParser.Module_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_name([NotNull] SQLiteParser.Pragma_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_name([NotNull] SQLiteParser.Pragma_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] SQLiteParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] SQLiteParser.Table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindow_name([NotNull] SQLiteParser.Window_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindow_name([NotNull] SQLiteParser.Window_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlias([NotNull] SQLiteParser.AliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlias([NotNull] SQLiteParser.AliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilename([NotNull] SQLiteParser.FilenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilename([NotNull] SQLiteParser.FilenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.base_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBase_window_name([NotNull] SQLiteParser.Base_window_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.base_window_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBase_window_name([NotNull] SQLiteParser.Base_window_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_func([NotNull] SQLiteParser.Simple_funcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_func([NotNull] SQLiteParser.Simple_funcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.aggregate_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_func([NotNull] SQLiteParser.Aggregate_funcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.aggregate_func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_func([NotNull] SQLiteParser.Aggregate_funcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_function_name([NotNull] SQLiteParser.Table_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_function_name([NotNull] SQLiteParser.Table_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAny_name([NotNull] SQLiteParser.Any_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAny_name([NotNull] SQLiteParser.Any_nameContext context);
}
