using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ISQLiteParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class SQLiteParserBaseListener : ISQLiteParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParse([NotNull] SQLiteParser.ParseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParse([NotNull] SQLiteParser.ParseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.sql_stmt_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_stmt_list([NotNull] SQLiteParser.Sql_stmt_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.sql_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_stmt([NotNull] SQLiteParser.Sql_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.alter_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_stmt([NotNull] SQLiteParser.Alter_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.analyze_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalyze_stmt([NotNull] SQLiteParser.Analyze_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.attach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttach_stmt([NotNull] SQLiteParser.Attach_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.begin_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBegin_stmt([NotNull] SQLiteParser.Begin_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.commit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommit_stmt([NotNull] SQLiteParser.Commit_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.rollback_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollback_stmt([NotNull] SQLiteParser.Rollback_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.savepoint_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_stmt([NotNull] SQLiteParser.Savepoint_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.release_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelease_stmt([NotNull] SQLiteParser.Release_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_index_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_index_stmt([NotNull] SQLiteParser.Create_index_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.indexed_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexed_column([NotNull] SQLiteParser.Indexed_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table_stmt([NotNull] SQLiteParser.Create_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_def([NotNull] SQLiteParser.Column_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_def([NotNull] SQLiteParser.Column_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_name([NotNull] SQLiteParser.Type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_name([NotNull] SQLiteParser.Type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_constraint([NotNull] SQLiteParser.Column_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSigned_number([NotNull] SQLiteParser.Signed_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSigned_number([NotNull] SQLiteParser.Signed_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_constraint([NotNull] SQLiteParser.Table_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_constraint([NotNull] SQLiteParser.Table_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_key_clause([NotNull] SQLiteParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.conflict_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConflict_clause([NotNull] SQLiteParser.Conflict_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_trigger_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_trigger_stmt([NotNull] SQLiteParser.Create_trigger_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_view_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_view_stmt([NotNull] SQLiteParser.Create_view_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.create_virtual_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_virtual_table_stmt([NotNull] SQLiteParser.Create_virtual_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWith_clause([NotNull] SQLiteParser.With_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.with_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWith_clause([NotNull] SQLiteParser.With_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.cte_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCte_table_name([NotNull] SQLiteParser.Cte_table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.recursive_cte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecursive_cte([NotNull] SQLiteParser.Recursive_cteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.recursive_cte"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecursive_cte([NotNull] SQLiteParser.Recursive_cteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.common_table_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_expression([NotNull] SQLiteParser.Common_table_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.delete_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_stmt([NotNull] SQLiteParser.Delete_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.delete_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_stmt_limited([NotNull] SQLiteParser.Delete_stmt_limitedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.detach_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDetach_stmt([NotNull] SQLiteParser.Detach_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.drop_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_stmt([NotNull] SQLiteParser.Drop_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.drop_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_stmt([NotNull] SQLiteParser.Drop_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] SQLiteParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] SQLiteParser.ExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRaise_function([NotNull] SQLiteParser.Raise_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.raise_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRaise_function([NotNull] SQLiteParser.Raise_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral_value([NotNull] SQLiteParser.Literal_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.literal_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral_value([NotNull] SQLiteParser.Literal_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.insert_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_stmt([NotNull] SQLiteParser.Insert_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturning_clause([NotNull] SQLiteParser.Returning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturning_clause([NotNull] SQLiteParser.Returning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.upsert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpsert_clause([NotNull] SQLiteParser.Upsert_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.upsert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpsert_clause([NotNull] SQLiteParser.Upsert_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_stmt([NotNull] SQLiteParser.Pragma_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_value([NotNull] SQLiteParser.Pragma_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_value([NotNull] SQLiteParser.Pragma_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.reindex_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReindex_stmt([NotNull] SQLiteParser.Reindex_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_stmt([NotNull] SQLiteParser.Select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_clause([NotNull] SQLiteParser.Join_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_clause([NotNull] SQLiteParser.Join_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_core([NotNull] SQLiteParser.Select_coreContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.select_core"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_core([NotNull] SQLiteParser.Select_coreContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.factored_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactored_select_stmt([NotNull] SQLiteParser.Factored_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_select_stmt([NotNull] SQLiteParser.Simple_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.compound_select_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_select_stmt([NotNull] SQLiteParser.Compound_select_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_or_subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_or_subquery([NotNull] SQLiteParser.Table_or_subqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_column([NotNull] SQLiteParser.Result_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.result_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_column([NotNull] SQLiteParser.Result_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_operator([NotNull] SQLiteParser.Join_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_operator([NotNull] SQLiteParser.Join_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.join_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_constraint([NotNull] SQLiteParser.Join_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.compound_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_operator([NotNull] SQLiteParser.Compound_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.update_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_stmt([NotNull] SQLiteParser.Update_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name_list([NotNull] SQLiteParser.Column_name_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_name_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name_list([NotNull] SQLiteParser.Column_name_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.update_stmt_limited"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_stmt_limited([NotNull] SQLiteParser.Update_stmt_limitedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.qualified_table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_table_name([NotNull] SQLiteParser.Qualified_table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.vacuum_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVacuum_stmt([NotNull] SQLiteParser.Vacuum_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilter_clause([NotNull] SQLiteParser.Filter_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.filter_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilter_clause([NotNull] SQLiteParser.Filter_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_defn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_defn([NotNull] SQLiteParser.Window_defnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_defn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_defn([NotNull] SQLiteParser.Window_defnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause([NotNull] SQLiteParser.Over_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause([NotNull] SQLiteParser.Over_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_spec([NotNull] SQLiteParser.Frame_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_spec([NotNull] SQLiteParser.Frame_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_clause([NotNull] SQLiteParser.Frame_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_clause([NotNull] SQLiteParser.Frame_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_function_invocation([NotNull] SQLiteParser.Simple_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_function_invocation([NotNull] SQLiteParser.Simple_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.aggregate_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_function_invocation([NotNull] SQLiteParser.Aggregate_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.aggregate_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_function_invocation([NotNull] SQLiteParser.Aggregate_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_function_invocation([NotNull] SQLiteParser.Window_function_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_function_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_function_invocation([NotNull] SQLiteParser.Window_function_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.common_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_table_stmt([NotNull] SQLiteParser.Common_table_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.common_table_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_table_stmt([NotNull] SQLiteParser.Common_table_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_stmt([NotNull] SQLiteParser.Order_by_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_stmt([NotNull] SQLiteParser.Order_by_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.limit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimit_stmt([NotNull] SQLiteParser.Limit_stmtContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.limit_stmt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimit_stmt([NotNull] SQLiteParser.Limit_stmtContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrdering_term([NotNull] SQLiteParser.Ordering_termContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.ordering_term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrdering_term([NotNull] SQLiteParser.Ordering_termContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsc_desc([NotNull] SQLiteParser.Asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsc_desc([NotNull] SQLiteParser.Asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_left"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_left([NotNull] SQLiteParser.Frame_leftContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_left"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_left([NotNull] SQLiteParser.Frame_leftContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_right"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_right([NotNull] SQLiteParser.Frame_rightContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_right"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_right([NotNull] SQLiteParser.Frame_rightContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.frame_single"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrame_single([NotNull] SQLiteParser.Frame_singleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.frame_single"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrame_single([NotNull] SQLiteParser.Frame_singleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_function([NotNull] SQLiteParser.Window_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_function([NotNull] SQLiteParser.Window_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.offset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOffset([NotNull] SQLiteParser.OffsetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.offset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOffset([NotNull] SQLiteParser.OffsetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_value([NotNull] SQLiteParser.Default_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.default_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_value([NotNull] SQLiteParser.Default_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.partition_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_by([NotNull] SQLiteParser.Partition_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.partition_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_by([NotNull] SQLiteParser.Partition_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_expr([NotNull] SQLiteParser.Order_by_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_expr([NotNull] SQLiteParser.Order_by_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.order_by_expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_expr_asc_desc([NotNull] SQLiteParser.Order_by_expr_asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.order_by_expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_expr_asc_desc([NotNull] SQLiteParser.Order_by_expr_asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr_asc_desc([NotNull] SQLiteParser.Expr_asc_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.expr_asc_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr_asc_desc([NotNull] SQLiteParser.Expr_asc_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.initial_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitial_select([NotNull] SQLiteParser.Initial_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.initial_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitial_select([NotNull] SQLiteParser.Initial_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.recursive_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecursive_select([NotNull] SQLiteParser.Recursive_selectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.recursive_select"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecursive_select([NotNull] SQLiteParser.Recursive_selectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_operator([NotNull] SQLiteParser.Unary_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_message([NotNull] SQLiteParser.Error_messageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.error_message"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_message([NotNull] SQLiteParser.Error_messageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule_argument([NotNull] SQLiteParser.Module_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.module_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule_argument([NotNull] SQLiteParser.Module_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_alias([NotNull] SQLiteParser.Column_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_alias([NotNull] SQLiteParser.Column_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] SQLiteParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] SQLiteParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] SQLiteParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] SQLiteParser.NameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_name([NotNull] SQLiteParser.Function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_name([NotNull] SQLiteParser.Function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_name([NotNull] SQLiteParser.Schema_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_name([NotNull] SQLiteParser.Schema_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_name([NotNull] SQLiteParser.Table_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_name([NotNull] SQLiteParser.Table_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_or_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_or_index_name([NotNull] SQLiteParser.Table_or_index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name([NotNull] SQLiteParser.Column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name([NotNull] SQLiteParser.Column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollation_name([NotNull] SQLiteParser.Collation_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.collation_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollation_name([NotNull] SQLiteParser.Collation_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_table([NotNull] SQLiteParser.Foreign_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.foreign_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_table([NotNull] SQLiteParser.Foreign_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_name([NotNull] SQLiteParser.Index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_name([NotNull] SQLiteParser.Index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_name([NotNull] SQLiteParser.Trigger_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterView_name([NotNull] SQLiteParser.View_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.view_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitView_name([NotNull] SQLiteParser.View_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModule_name([NotNull] SQLiteParser.Module_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.module_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModule_name([NotNull] SQLiteParser.Module_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_name([NotNull] SQLiteParser.Pragma_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.pragma_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_name([NotNull] SQLiteParser.Pragma_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_name([NotNull] SQLiteParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_alias([NotNull] SQLiteParser.Table_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_alias([NotNull] SQLiteParser.Table_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.transaction_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_name([NotNull] SQLiteParser.Transaction_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindow_name([NotNull] SQLiteParser.Window_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindow_name([NotNull] SQLiteParser.Window_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlias([NotNull] SQLiteParser.AliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlias([NotNull] SQLiteParser.AliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilename([NotNull] SQLiteParser.FilenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilename([NotNull] SQLiteParser.FilenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.base_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBase_window_name([NotNull] SQLiteParser.Base_window_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.base_window_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBase_window_name([NotNull] SQLiteParser.Base_window_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.simple_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_func([NotNull] SQLiteParser.Simple_funcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.simple_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_func([NotNull] SQLiteParser.Simple_funcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.aggregate_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_func([NotNull] SQLiteParser.Aggregate_funcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.aggregate_func"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_func([NotNull] SQLiteParser.Aggregate_funcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.table_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_function_name([NotNull] SQLiteParser.Table_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.table_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_function_name([NotNull] SQLiteParser.Table_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAny_name([NotNull] SQLiteParser.Any_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="SQLiteParser.any_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAny_name([NotNull] SQLiteParser.Any_nameContext context) { }

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
