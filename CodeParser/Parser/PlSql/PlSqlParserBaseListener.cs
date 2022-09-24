using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IPlSqlParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class PlSqlParserBaseListener : IPlSqlParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_script([NotNull] PlSqlParser.Sql_scriptContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_script"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_script([NotNull] PlSqlParser.Sql_scriptContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnit_statement([NotNull] PlSqlParser.Unit_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnit_statement([NotNull] PlSqlParser.Unit_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_function([NotNull] PlSqlParser.Drop_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_function([NotNull] PlSqlParser.Drop_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_function([NotNull] PlSqlParser.Alter_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_function([NotNull] PlSqlParser.Alter_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_function_body([NotNull] PlSqlParser.Create_function_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_function_body([NotNull] PlSqlParser.Create_function_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parallel_enable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParallel_enable_clause([NotNull] PlSqlParser.Parallel_enable_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parallel_enable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParallel_enable_clause([NotNull] PlSqlParser.Parallel_enable_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_by_clause([NotNull] PlSqlParser.Partition_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_by_clause([NotNull] PlSqlParser.Partition_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.result_cache_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResult_cache_clause([NotNull] PlSqlParser.Result_cache_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.result_cache_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResult_cache_clause([NotNull] PlSqlParser.Result_cache_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relies_on_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelies_on_part([NotNull] PlSqlParser.Relies_on_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relies_on_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelies_on_part([NotNull] PlSqlParser.Relies_on_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.streaming_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStreaming_clause([NotNull] PlSqlParser.Streaming_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.streaming_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStreaming_clause([NotNull] PlSqlParser.Streaming_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_package([NotNull] PlSqlParser.Drop_packageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_package([NotNull] PlSqlParser.Drop_packageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_package([NotNull] PlSqlParser.Alter_packageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_package([NotNull] PlSqlParser.Alter_packageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_package([NotNull] PlSqlParser.Create_packageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_package"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_package([NotNull] PlSqlParser.Create_packageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_package_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_package_body([NotNull] PlSqlParser.Create_package_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_package_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_package_body([NotNull] PlSqlParser.Create_package_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_obj_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackage_obj_spec([NotNull] PlSqlParser.Package_obj_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_obj_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackage_obj_spec([NotNull] PlSqlParser.Package_obj_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_spec([NotNull] PlSqlParser.Procedure_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_spec([NotNull] PlSqlParser.Procedure_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_spec([NotNull] PlSqlParser.Function_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_spec([NotNull] PlSqlParser.Function_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_obj_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackage_obj_body([NotNull] PlSqlParser.Package_obj_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_obj_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackage_obj_body([NotNull] PlSqlParser.Package_obj_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_procedure([NotNull] PlSqlParser.Drop_procedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_procedure([NotNull] PlSqlParser.Drop_procedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_procedure([NotNull] PlSqlParser.Alter_procedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_procedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_procedure([NotNull] PlSqlParser.Alter_procedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_body([NotNull] PlSqlParser.Function_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_body([NotNull] PlSqlParser.Function_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_body([NotNull] PlSqlParser.Procedure_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_body([NotNull] PlSqlParser.Procedure_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_procedure_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_procedure_body([NotNull] PlSqlParser.Create_procedure_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_procedure_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_procedure_body([NotNull] PlSqlParser.Create_procedure_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_trigger([NotNull] PlSqlParser.Drop_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_trigger([NotNull] PlSqlParser.Drop_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_trigger([NotNull] PlSqlParser.Alter_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_trigger([NotNull] PlSqlParser.Alter_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_trigger([NotNull] PlSqlParser.Create_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_trigger([NotNull] PlSqlParser.Create_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_follows_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_follows_clause([NotNull] PlSqlParser.Trigger_follows_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_follows_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_follows_clause([NotNull] PlSqlParser.Trigger_follows_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_when_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_when_clause([NotNull] PlSqlParser.Trigger_when_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_when_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_when_clause([NotNull] PlSqlParser.Trigger_when_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_dml_trigger([NotNull] PlSqlParser.Simple_dml_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_dml_trigger([NotNull] PlSqlParser.Simple_dml_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_each_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_each_row([NotNull] PlSqlParser.For_each_rowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_each_row"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_each_row([NotNull] PlSqlParser.For_each_rowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_dml_trigger([NotNull] PlSqlParser.Compound_dml_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_dml_trigger([NotNull] PlSqlParser.Compound_dml_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNon_dml_trigger([NotNull] PlSqlParser.Non_dml_triggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_dml_trigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNon_dml_trigger([NotNull] PlSqlParser.Non_dml_triggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_body([NotNull] PlSqlParser.Trigger_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_body([NotNull] PlSqlParser.Trigger_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.routine_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutine_clause([NotNull] PlSqlParser.Routine_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.routine_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutine_clause([NotNull] PlSqlParser.Routine_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_trigger_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_trigger_block([NotNull] PlSqlParser.Compound_trigger_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_trigger_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_trigger_block([NotNull] PlSqlParser.Compound_trigger_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.timing_point_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTiming_point_section([NotNull] PlSqlParser.Timing_point_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.timing_point_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTiming_point_section([NotNull] PlSqlParser.Timing_point_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_dml_event"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNon_dml_event([NotNull] PlSqlParser.Non_dml_eventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_dml_event"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNon_dml_event([NotNull] PlSqlParser.Non_dml_eventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_event_clause([NotNull] PlSqlParser.Dml_event_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_event_clause([NotNull] PlSqlParser.Dml_event_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_event_element([NotNull] PlSqlParser.Dml_event_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_event_element([NotNull] PlSqlParser.Dml_event_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_nested_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_event_nested_clause([NotNull] PlSqlParser.Dml_event_nested_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_nested_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_event_nested_clause([NotNull] PlSqlParser.Dml_event_nested_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.referencing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferencing_clause([NotNull] PlSqlParser.Referencing_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.referencing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferencing_clause([NotNull] PlSqlParser.Referencing_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.referencing_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferencing_element([NotNull] PlSqlParser.Referencing_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.referencing_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferencing_element([NotNull] PlSqlParser.Referencing_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_type([NotNull] PlSqlParser.Drop_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_type([NotNull] PlSqlParser.Drop_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_type([NotNull] PlSqlParser.Alter_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_type([NotNull] PlSqlParser.Alter_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compile_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompile_type_clause([NotNull] PlSqlParser.Compile_type_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compile_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompile_type_clause([NotNull] PlSqlParser.Compile_type_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.replace_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplace_type_clause([NotNull] PlSqlParser.Replace_type_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.replace_type_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplace_type_clause([NotNull] PlSqlParser.Replace_type_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_method_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_method_spec([NotNull] PlSqlParser.Alter_method_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_method_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_method_spec([NotNull] PlSqlParser.Alter_method_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_method_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_method_element([NotNull] PlSqlParser.Alter_method_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_method_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_method_element([NotNull] PlSqlParser.Alter_method_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_attribute_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_attribute_definition([NotNull] PlSqlParser.Alter_attribute_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_attribute_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_attribute_definition([NotNull] PlSqlParser.Alter_attribute_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.attribute_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_definition([NotNull] PlSqlParser.Attribute_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.attribute_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_definition([NotNull] PlSqlParser.Attribute_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_collection_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_collection_clauses([NotNull] PlSqlParser.Alter_collection_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_collection_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_collection_clauses([NotNull] PlSqlParser.Alter_collection_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dependent_handling_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDependent_handling_clause([NotNull] PlSqlParser.Dependent_handling_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dependent_handling_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDependent_handling_clause([NotNull] PlSqlParser.Dependent_handling_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dependent_exceptions_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDependent_exceptions_part([NotNull] PlSqlParser.Dependent_exceptions_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dependent_exceptions_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDependent_exceptions_part([NotNull] PlSqlParser.Dependent_exceptions_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_type([NotNull] PlSqlParser.Create_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_type([NotNull] PlSqlParser.Create_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_definition([NotNull] PlSqlParser.Type_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_definition([NotNull] PlSqlParser.Type_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_type_def([NotNull] PlSqlParser.Object_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_type_def([NotNull] PlSqlParser.Object_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_as_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_as_part([NotNull] PlSqlParser.Object_as_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_as_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_as_part([NotNull] PlSqlParser.Object_as_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_under_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_under_part([NotNull] PlSqlParser.Object_under_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_under_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_under_part([NotNull] PlSqlParser.Object_under_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_table_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNested_table_type_def([NotNull] PlSqlParser.Nested_table_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_table_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNested_table_type_def([NotNull] PlSqlParser.Nested_table_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sqlj_object_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSqlj_object_type([NotNull] PlSqlParser.Sqlj_object_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sqlj_object_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSqlj_object_type([NotNull] PlSqlParser.Sqlj_object_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_body([NotNull] PlSqlParser.Type_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_body([NotNull] PlSqlParser.Type_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_body_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_body_elements([NotNull] PlSqlParser.Type_body_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_body_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_body_elements([NotNull] PlSqlParser.Type_body_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.map_order_func_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMap_order_func_declaration([NotNull] PlSqlParser.Map_order_func_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.map_order_func_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMap_order_func_declaration([NotNull] PlSqlParser.Map_order_func_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subprog_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubprog_decl_in_type([NotNull] PlSqlParser.Subprog_decl_in_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subprog_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubprog_decl_in_type([NotNull] PlSqlParser.Subprog_decl_in_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.proc_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProc_decl_in_type([NotNull] PlSqlParser.Proc_decl_in_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.proc_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProc_decl_in_type([NotNull] PlSqlParser.Proc_decl_in_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.func_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunc_decl_in_type([NotNull] PlSqlParser.Func_decl_in_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.func_decl_in_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunc_decl_in_type([NotNull] PlSqlParser.Func_decl_in_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constructor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructor_declaration([NotNull] PlSqlParser.Constructor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constructor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructor_declaration([NotNull] PlSqlParser.Constructor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modifier_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModifier_clause([NotNull] PlSqlParser.Modifier_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modifier_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModifier_clause([NotNull] PlSqlParser.Modifier_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_member_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_member_spec([NotNull] PlSqlParser.Object_member_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_member_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_member_spec([NotNull] PlSqlParser.Object_member_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sqlj_object_type_attr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSqlj_object_type_attr([NotNull] PlSqlParser.Sqlj_object_type_attrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sqlj_object_type_attr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSqlj_object_type_attr([NotNull] PlSqlParser.Sqlj_object_type_attrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.element_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElement_spec([NotNull] PlSqlParser.Element_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.element_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElement_spec([NotNull] PlSqlParser.Element_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.element_spec_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElement_spec_options([NotNull] PlSqlParser.Element_spec_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.element_spec_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElement_spec_options([NotNull] PlSqlParser.Element_spec_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subprogram_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubprogram_spec([NotNull] PlSqlParser.Subprogram_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subprogram_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubprogram_spec([NotNull] PlSqlParser.Subprogram_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.overriding_subprogram_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOverriding_subprogram_spec([NotNull] PlSqlParser.Overriding_subprogram_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.overriding_subprogram_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOverriding_subprogram_spec([NotNull] PlSqlParser.Overriding_subprogram_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.overriding_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOverriding_function_spec([NotNull] PlSqlParser.Overriding_function_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.overriding_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOverriding_function_spec([NotNull] PlSqlParser.Overriding_function_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_procedure_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_procedure_spec([NotNull] PlSqlParser.Type_procedure_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_procedure_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_procedure_spec([NotNull] PlSqlParser.Type_procedure_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_function_spec([NotNull] PlSqlParser.Type_function_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_function_spec([NotNull] PlSqlParser.Type_function_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constructor_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructor_spec([NotNull] PlSqlParser.Constructor_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constructor_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructor_spec([NotNull] PlSqlParser.Constructor_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.map_order_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMap_order_function_spec([NotNull] PlSqlParser.Map_order_function_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.map_order_function_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMap_order_function_spec([NotNull] PlSqlParser.Map_order_function_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_clause([NotNull] PlSqlParser.Pragma_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_clause([NotNull] PlSqlParser.Pragma_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_elements([NotNull] PlSqlParser.Pragma_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_elements([NotNull] PlSqlParser.Pragma_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_elements_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_elements_parameter([NotNull] PlSqlParser.Type_elements_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_elements_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_elements_parameter([NotNull] PlSqlParser.Type_elements_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_sequence([NotNull] PlSqlParser.Drop_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_sequence([NotNull] PlSqlParser.Drop_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_sequence([NotNull] PlSqlParser.Alter_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_sequence([NotNull] PlSqlParser.Alter_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_session([NotNull] PlSqlParser.Alter_sessionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_session"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_session([NotNull] PlSqlParser.Alter_sessionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_session_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_session_set_clause([NotNull] PlSqlParser.Alter_session_set_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_session_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_session_set_clause([NotNull] PlSqlParser.Alter_session_set_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_sequence([NotNull] PlSqlParser.Create_sequenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_sequence"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_sequence([NotNull] PlSqlParser.Create_sequenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSequence_spec([NotNull] PlSqlParser.Sequence_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSequence_spec([NotNull] PlSqlParser.Sequence_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_start_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSequence_start_clause([NotNull] PlSqlParser.Sequence_start_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_start_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSequence_start_clause([NotNull] PlSqlParser.Sequence_start_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_index([NotNull] PlSqlParser.Create_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_index([NotNull] PlSqlParser.Create_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cluster_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCluster_index_clause([NotNull] PlSqlParser.Cluster_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cluster_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCluster_index_clause([NotNull] PlSqlParser.Cluster_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cluster_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCluster_name([NotNull] PlSqlParser.Cluster_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cluster_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCluster_name([NotNull] PlSqlParser.Cluster_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_index_clause([NotNull] PlSqlParser.Table_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_index_clause([NotNull] PlSqlParser.Table_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bitmap_join_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitmap_join_index_clause([NotNull] PlSqlParser.Bitmap_join_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bitmap_join_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitmap_join_index_clause([NotNull] PlSqlParser.Bitmap_join_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_expr([NotNull] PlSqlParser.Index_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_expr([NotNull] PlSqlParser.Index_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_properties([NotNull] PlSqlParser.Index_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_properties([NotNull] PlSqlParser.Index_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.domain_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDomain_index_clause([NotNull] PlSqlParser.Domain_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.domain_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDomain_index_clause([NotNull] PlSqlParser.Domain_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_domain_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_domain_index_clause([NotNull] PlSqlParser.Local_domain_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_domain_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_domain_index_clause([NotNull] PlSqlParser.Local_domain_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlindex_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlindex_clause([NotNull] PlSqlParser.Xmlindex_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlindex_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlindex_clause([NotNull] PlSqlParser.Xmlindex_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_xmlindex_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_xmlindex_clause([NotNull] PlSqlParser.Local_xmlindex_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_xmlindex_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_xmlindex_clause([NotNull] PlSqlParser.Local_xmlindex_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.global_partitioned_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobal_partitioned_index([NotNull] PlSqlParser.Global_partitioned_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.global_partitioned_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobal_partitioned_index([NotNull] PlSqlParser.Global_partitioned_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_partitioning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_partitioning_clause([NotNull] PlSqlParser.Index_partitioning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_partitioning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_partitioning_clause([NotNull] PlSqlParser.Index_partitioning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_partitioned_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_partitioned_index([NotNull] PlSqlParser.Local_partitioned_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_partitioned_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_partitioned_index([NotNull] PlSqlParser.Local_partitioned_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_range_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_range_partitioned_table([NotNull] PlSqlParser.On_range_partitioned_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_range_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_range_partitioned_table([NotNull] PlSqlParser.On_range_partitioned_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_list_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_list_partitioned_table([NotNull] PlSqlParser.On_list_partitioned_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_list_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_list_partitioned_table([NotNull] PlSqlParser.On_list_partitioned_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitioned_table([NotNull] PlSqlParser.Partitioned_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitioned_table([NotNull] PlSqlParser.Partitioned_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_hash_partitioned_table([NotNull] PlSqlParser.On_hash_partitioned_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_hash_partitioned_table([NotNull] PlSqlParser.On_hash_partitioned_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_hash_partitioned_clause([NotNull] PlSqlParser.On_hash_partitioned_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_hash_partitioned_clause([NotNull] PlSqlParser.On_hash_partitioned_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_comp_partitioned_table([NotNull] PlSqlParser.On_comp_partitioned_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_comp_partitioned_table([NotNull] PlSqlParser.On_comp_partitioned_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_comp_partitioned_clause([NotNull] PlSqlParser.On_comp_partitioned_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_comp_partitioned_clause([NotNull] PlSqlParser.On_comp_partitioned_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_subpartition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_subpartition_clause([NotNull] PlSqlParser.Index_subpartition_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_subpartition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_subpartition_clause([NotNull] PlSqlParser.Index_subpartition_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_subpartition_subclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_subpartition_subclause([NotNull] PlSqlParser.Index_subpartition_subclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_subpartition_subclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_subpartition_subclause([NotNull] PlSqlParser.Index_subpartition_subclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.odci_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOdci_parameters([NotNull] PlSqlParser.Odci_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.odci_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOdci_parameters([NotNull] PlSqlParser.Odci_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.indextype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndextype([NotNull] PlSqlParser.IndextypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.indextype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndextype([NotNull] PlSqlParser.IndextypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_index([NotNull] PlSqlParser.Alter_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_index([NotNull] PlSqlParser.Alter_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_index_ops_set1([NotNull] PlSqlParser.Alter_index_ops_set1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_index_ops_set1([NotNull] PlSqlParser.Alter_index_ops_set1Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_index_ops_set2([NotNull] PlSqlParser.Alter_index_ops_set2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_index_ops_set2([NotNull] PlSqlParser.Alter_index_ops_set2Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.visible_or_invisible"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVisible_or_invisible([NotNull] PlSqlParser.Visible_or_invisibleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.visible_or_invisible"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVisible_or_invisible([NotNull] PlSqlParser.Visible_or_invisibleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.monitoring_nomonitoring"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMonitoring_nomonitoring([NotNull] PlSqlParser.Monitoring_nomonitoringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.monitoring_nomonitoring"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMonitoring_nomonitoring([NotNull] PlSqlParser.Monitoring_nomonitoringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rebuild_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRebuild_clause([NotNull] PlSqlParser.Rebuild_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rebuild_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRebuild_clause([NotNull] PlSqlParser.Rebuild_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_index_partitioning([NotNull] PlSqlParser.Alter_index_partitioningContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_index_partitioning([NotNull] PlSqlParser.Alter_index_partitioningContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_default_attrs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_index_default_attrs([NotNull] PlSqlParser.Modify_index_default_attrsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_default_attrs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_index_default_attrs([NotNull] PlSqlParser.Modify_index_default_attrsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_hash_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_hash_index_partition([NotNull] PlSqlParser.Add_hash_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_hash_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_hash_index_partition([NotNull] PlSqlParser.Add_hash_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.coalesce_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCoalesce_index_partition([NotNull] PlSqlParser.Coalesce_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.coalesce_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCoalesce_index_partition([NotNull] PlSqlParser.Coalesce_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_index_partition([NotNull] PlSqlParser.Modify_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_index_partition([NotNull] PlSqlParser.Modify_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_partitions_ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_index_partitions_ops([NotNull] PlSqlParser.Modify_index_partitions_opsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_partitions_ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_index_partitions_ops([NotNull] PlSqlParser.Modify_index_partitions_opsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRename_index_partition([NotNull] PlSqlParser.Rename_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRename_index_partition([NotNull] PlSqlParser.Rename_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_index_partition([NotNull] PlSqlParser.Drop_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_index_partition([NotNull] PlSqlParser.Drop_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.split_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSplit_index_partition([NotNull] PlSqlParser.Split_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.split_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSplit_index_partition([NotNull] PlSqlParser.Split_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_partition_description"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_partition_description([NotNull] PlSqlParser.Index_partition_descriptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_partition_description"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_partition_description([NotNull] PlSqlParser.Index_partition_descriptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_subpartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_index_subpartition([NotNull] PlSqlParser.Modify_index_subpartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_subpartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_index_subpartition([NotNull] PlSqlParser.Modify_index_subpartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_name_old"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_name_old([NotNull] PlSqlParser.Partition_name_oldContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_name_old"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_name_old([NotNull] PlSqlParser.Partition_name_oldContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_partition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_partition_name([NotNull] PlSqlParser.New_partition_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_partition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_partition_name([NotNull] PlSqlParser.New_partition_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_index_name([NotNull] PlSqlParser.New_index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_index_name([NotNull] PlSqlParser.New_index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_user([NotNull] PlSqlParser.Create_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_user([NotNull] PlSqlParser.Create_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_user([NotNull] PlSqlParser.Alter_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_user([NotNull] PlSqlParser.Alter_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_identified_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_identified_by([NotNull] PlSqlParser.Alter_identified_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_identified_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_identified_by([NotNull] PlSqlParser.Alter_identified_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identified_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentified_by([NotNull] PlSqlParser.Identified_byContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identified_by"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentified_by([NotNull] PlSqlParser.Identified_byContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identified_other_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentified_other_clause([NotNull] PlSqlParser.Identified_other_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identified_other_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentified_other_clause([NotNull] PlSqlParser.Identified_other_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser_tablespace_clause([NotNull] PlSqlParser.User_tablespace_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser_tablespace_clause([NotNull] PlSqlParser.User_tablespace_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quota_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuota_clause([NotNull] PlSqlParser.Quota_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quota_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuota_clause([NotNull] PlSqlParser.Quota_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.profile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProfile_clause([NotNull] PlSqlParser.Profile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.profile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProfile_clause([NotNull] PlSqlParser.Profile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.role_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRole_clause([NotNull] PlSqlParser.Role_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.role_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRole_clause([NotNull] PlSqlParser.Role_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_default_role_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser_default_role_clause([NotNull] PlSqlParser.User_default_role_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_default_role_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser_default_role_clause([NotNull] PlSqlParser.User_default_role_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.password_expire_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPassword_expire_clause([NotNull] PlSqlParser.Password_expire_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.password_expire_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPassword_expire_clause([NotNull] PlSqlParser.Password_expire_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_lock_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser_lock_clause([NotNull] PlSqlParser.User_lock_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_lock_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser_lock_clause([NotNull] PlSqlParser.User_lock_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_editions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser_editions_clause([NotNull] PlSqlParser.User_editions_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_editions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser_editions_clause([NotNull] PlSqlParser.User_editions_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_user_editions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_user_editions_clause([NotNull] PlSqlParser.Alter_user_editions_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_user_editions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_user_editions_clause([NotNull] PlSqlParser.Alter_user_editions_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.proxy_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProxy_clause([NotNull] PlSqlParser.Proxy_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.proxy_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProxy_clause([NotNull] PlSqlParser.Proxy_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContainer_names([NotNull] PlSqlParser.Container_namesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContainer_names([NotNull] PlSqlParser.Container_namesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_container_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_container_data([NotNull] PlSqlParser.Set_container_dataContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_container_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_container_data([NotNull] PlSqlParser.Set_container_dataContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_rem_container_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_rem_container_data([NotNull] PlSqlParser.Add_rem_container_dataContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_rem_container_data"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_rem_container_data([NotNull] PlSqlParser.Add_rem_container_dataContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_data_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContainer_data_clause([NotNull] PlSqlParser.Container_data_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_data_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContainer_data_clause([NotNull] PlSqlParser.Container_data_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.analyze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnalyze([NotNull] PlSqlParser.AnalyzeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.analyze"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnalyze([NotNull] PlSqlParser.AnalyzeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_extention_clause([NotNull] PlSqlParser.Partition_extention_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_extention_clause([NotNull] PlSqlParser.Partition_extention_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.validation_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValidation_clauses([NotNull] PlSqlParser.Validation_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.validation_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValidation_clauses([NotNull] PlSqlParser.Validation_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.online_or_offline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnline_or_offline([NotNull] PlSqlParser.Online_or_offlineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.online_or_offline"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnline_or_offline([NotNull] PlSqlParser.Online_or_offlineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.into_clause1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInto_clause1([NotNull] PlSqlParser.Into_clause1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.into_clause1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInto_clause1([NotNull] PlSqlParser.Into_clause1Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_key_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_key_value([NotNull] PlSqlParser.Partition_key_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_key_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_key_value([NotNull] PlSqlParser.Partition_key_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_key_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_key_value([NotNull] PlSqlParser.Subpartition_key_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_key_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_key_value([NotNull] PlSqlParser.Subpartition_key_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.associate_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssociate_statistics([NotNull] PlSqlParser.Associate_statisticsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.associate_statistics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssociate_statistics([NotNull] PlSqlParser.Associate_statisticsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_association"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_association([NotNull] PlSqlParser.Column_associationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_association"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_association([NotNull] PlSqlParser.Column_associationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_association"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_association([NotNull] PlSqlParser.Function_associationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_association"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_association([NotNull] PlSqlParser.Function_associationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.indextype_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndextype_name([NotNull] PlSqlParser.Indextype_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.indextype_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndextype_name([NotNull] PlSqlParser.Indextype_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_statistics_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_statistics_type([NotNull] PlSqlParser.Using_statistics_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_statistics_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_statistics_type([NotNull] PlSqlParser.Using_statistics_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.statistics_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatistics_type_name([NotNull] PlSqlParser.Statistics_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.statistics_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatistics_type_name([NotNull] PlSqlParser.Statistics_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_cost_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_cost_clause([NotNull] PlSqlParser.Default_cost_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_cost_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_cost_clause([NotNull] PlSqlParser.Default_cost_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cpu_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCpu_cost([NotNull] PlSqlParser.Cpu_costContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cpu_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCpu_cost([NotNull] PlSqlParser.Cpu_costContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.io_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIo_cost([NotNull] PlSqlParser.Io_costContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.io_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIo_cost([NotNull] PlSqlParser.Io_costContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.network_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNetwork_cost([NotNull] PlSqlParser.Network_costContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.network_cost"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNetwork_cost([NotNull] PlSqlParser.Network_costContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_selectivity_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_selectivity_clause([NotNull] PlSqlParser.Default_selectivity_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_selectivity_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_selectivity_clause([NotNull] PlSqlParser.Default_selectivity_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_selectivity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_selectivity([NotNull] PlSqlParser.Default_selectivityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_selectivity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_selectivity([NotNull] PlSqlParser.Default_selectivityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.storage_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStorage_table_clause([NotNull] PlSqlParser.Storage_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.storage_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStorage_table_clause([NotNull] PlSqlParser.Storage_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unified_auditing"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnified_auditing([NotNull] PlSqlParser.Unified_auditingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unified_auditing"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnified_auditing([NotNull] PlSqlParser.Unified_auditingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.policy_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPolicy_name([NotNull] PlSqlParser.Policy_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.policy_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPolicy_name([NotNull] PlSqlParser.Policy_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_traditional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_traditional([NotNull] PlSqlParser.Audit_traditionalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_traditional"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_traditional([NotNull] PlSqlParser.Audit_traditionalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_direct_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_direct_path([NotNull] PlSqlParser.Audit_direct_pathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_direct_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_direct_path([NotNull] PlSqlParser.Audit_direct_pathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_container_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_container_clause([NotNull] PlSqlParser.Audit_container_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_container_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_container_clause([NotNull] PlSqlParser.Audit_container_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_operation_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_operation_clause([NotNull] PlSqlParser.Audit_operation_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_operation_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_operation_clause([NotNull] PlSqlParser.Audit_operation_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.auditing_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAuditing_by_clause([NotNull] PlSqlParser.Auditing_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.auditing_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAuditing_by_clause([NotNull] PlSqlParser.Auditing_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_user([NotNull] PlSqlParser.Audit_userContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_user([NotNull] PlSqlParser.Audit_userContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_schema_object_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAudit_schema_object_clause([NotNull] PlSqlParser.Audit_schema_object_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_schema_object_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAudit_schema_object_clause([NotNull] PlSqlParser.Audit_schema_object_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_operation([NotNull] PlSqlParser.Sql_operationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_operation([NotNull] PlSqlParser.Sql_operationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.auditing_on_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAuditing_on_clause([NotNull] PlSqlParser.Auditing_on_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.auditing_on_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAuditing_on_clause([NotNull] PlSqlParser.Auditing_on_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_name([NotNull] PlSqlParser.Model_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_name([NotNull] PlSqlParser.Model_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_name([NotNull] PlSqlParser.Object_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_name([NotNull] PlSqlParser.Object_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.profile_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProfile_name([NotNull] PlSqlParser.Profile_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.profile_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProfile_name([NotNull] PlSqlParser.Profile_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_statement_shortcut"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_statement_shortcut([NotNull] PlSqlParser.Sql_statement_shortcutContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_statement_shortcut"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_statement_shortcut([NotNull] PlSqlParser.Sql_statement_shortcutContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_index([NotNull] PlSqlParser.Drop_indexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_index"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_index([NotNull] PlSqlParser.Drop_indexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRename_object([NotNull] PlSqlParser.Rename_objectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_object"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRename_object([NotNull] PlSqlParser.Rename_objectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grant_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrant_statement([NotNull] PlSqlParser.Grant_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grant_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrant_statement([NotNull] PlSqlParser.Grant_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContainer_clause([NotNull] PlSqlParser.Container_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContainer_clause([NotNull] PlSqlParser.Container_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_directory"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_directory([NotNull] PlSqlParser.Create_directoryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_directory"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_directory([NotNull] PlSqlParser.Create_directoryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.directory_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectory_name([NotNull] PlSqlParser.Directory_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.directory_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectory_name([NotNull] PlSqlParser.Directory_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.directory_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectory_path([NotNull] PlSqlParser.Directory_pathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.directory_path"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectory_path([NotNull] PlSqlParser.Directory_pathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_library([NotNull] PlSqlParser.Alter_libraryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_library"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_library([NotNull] PlSqlParser.Alter_libraryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_editionable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLibrary_editionable([NotNull] PlSqlParser.Library_editionableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_editionable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLibrary_editionable([NotNull] PlSqlParser.Library_editionableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_debug"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLibrary_debug([NotNull] PlSqlParser.Library_debugContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_debug"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLibrary_debug([NotNull] PlSqlParser.Library_debugContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compiler_parameters_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompiler_parameters_clause([NotNull] PlSqlParser.Compiler_parameters_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compiler_parameters_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompiler_parameters_clause([NotNull] PlSqlParser.Compiler_parameters_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_value([NotNull] PlSqlParser.Parameter_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_value([NotNull] PlSqlParser.Parameter_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLibrary_name([NotNull] PlSqlParser.Library_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLibrary_name([NotNull] PlSqlParser.Library_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_view([NotNull] PlSqlParser.Alter_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_view([NotNull] PlSqlParser.Alter_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_view_editionable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_view_editionable([NotNull] PlSqlParser.Alter_view_editionableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_view_editionable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_view_editionable([NotNull] PlSqlParser.Alter_view_editionableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_view([NotNull] PlSqlParser.Create_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_view([NotNull] PlSqlParser.Create_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.view_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterView_options([NotNull] PlSqlParser.View_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.view_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitView_options([NotNull] PlSqlParser.View_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.view_alias_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterView_alias_constraint([NotNull] PlSqlParser.View_alias_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.view_alias_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitView_alias_constraint([NotNull] PlSqlParser.View_alias_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_view_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_view_clause([NotNull] PlSqlParser.Object_view_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_view_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_view_clause([NotNull] PlSqlParser.Object_view_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.inline_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInline_constraint([NotNull] PlSqlParser.Inline_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.inline_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInline_constraint([NotNull] PlSqlParser.Inline_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.inline_ref_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInline_ref_constraint([NotNull] PlSqlParser.Inline_ref_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.inline_ref_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInline_ref_constraint([NotNull] PlSqlParser.Inline_ref_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_ref_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOut_of_line_ref_constraint([NotNull] PlSqlParser.Out_of_line_ref_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_ref_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOut_of_line_ref_constraint([NotNull] PlSqlParser.Out_of_line_ref_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOut_of_line_constraint([NotNull] PlSqlParser.Out_of_line_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOut_of_line_constraint([NotNull] PlSqlParser.Out_of_line_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_state"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraint_state([NotNull] PlSqlParser.Constraint_stateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_state"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraint_state([NotNull] PlSqlParser.Constraint_stateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_tablespace([NotNull] PlSqlParser.Alter_tablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_tablespace([NotNull] PlSqlParser.Alter_tablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatafile_tempfile_clauses([NotNull] PlSqlParser.Datafile_tempfile_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatafile_tempfile_clauses([NotNull] PlSqlParser.Datafile_tempfile_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_logging_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_logging_clauses([NotNull] PlSqlParser.Tablespace_logging_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_logging_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_logging_clauses([NotNull] PlSqlParser.Tablespace_logging_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_group_clause([NotNull] PlSqlParser.Tablespace_group_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_group_clause([NotNull] PlSqlParser.Tablespace_group_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_group_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_group_name([NotNull] PlSqlParser.Tablespace_group_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_group_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_group_name([NotNull] PlSqlParser.Tablespace_group_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_state_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_state_clauses([NotNull] PlSqlParser.Tablespace_state_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_state_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_state_clauses([NotNull] PlSqlParser.Tablespace_state_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_mode_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlashback_mode_clause([NotNull] PlSqlParser.Flashback_mode_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_mode_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlashback_mode_clause([NotNull] PlSqlParser.Flashback_mode_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_tablespace_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_tablespace_name([NotNull] PlSqlParser.New_tablespace_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_tablespace_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_tablespace_name([NotNull] PlSqlParser.New_tablespace_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_tablespace([NotNull] PlSqlParser.Create_tablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_tablespace([NotNull] PlSqlParser.Create_tablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.permanent_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPermanent_tablespace_clause([NotNull] PlSqlParser.Permanent_tablespace_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.permanent_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPermanent_tablespace_clause([NotNull] PlSqlParser.Permanent_tablespace_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_encryption_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_encryption_spec([NotNull] PlSqlParser.Tablespace_encryption_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_encryption_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_encryption_spec([NotNull] PlSqlParser.Tablespace_encryption_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logging_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogging_clause([NotNull] PlSqlParser.Logging_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logging_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogging_clause([NotNull] PlSqlParser.Logging_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.extent_management_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtent_management_clause([NotNull] PlSqlParser.Extent_management_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.extent_management_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtent_management_clause([NotNull] PlSqlParser.Extent_management_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.segment_management_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSegment_management_clause([NotNull] PlSqlParser.Segment_management_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.segment_management_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSegment_management_clause([NotNull] PlSqlParser.Segment_management_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.temporary_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemporary_tablespace_clause([NotNull] PlSqlParser.Temporary_tablespace_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.temporary_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemporary_tablespace_clause([NotNull] PlSqlParser.Temporary_tablespace_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.undo_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUndo_tablespace_clause([NotNull] PlSqlParser.Undo_tablespace_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.undo_tablespace_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUndo_tablespace_clause([NotNull] PlSqlParser.Undo_tablespace_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_retention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace_retention_clause([NotNull] PlSqlParser.Tablespace_retention_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_retention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace_retention_clause([NotNull] PlSqlParser.Tablespace_retention_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatafile_specification([NotNull] PlSqlParser.Datafile_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatafile_specification([NotNull] PlSqlParser.Datafile_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tempfile_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTempfile_specification([NotNull] PlSqlParser.Tempfile_specificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tempfile_specification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTempfile_specification([NotNull] PlSqlParser.Tempfile_specificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatafile_tempfile_spec([NotNull] PlSqlParser.Datafile_tempfile_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatafile_tempfile_spec([NotNull] PlSqlParser.Datafile_tempfile_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.redo_log_file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRedo_log_file_spec([NotNull] PlSqlParser.Redo_log_file_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.redo_log_file_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRedo_log_file_spec([NotNull] PlSqlParser.Redo_log_file_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.autoextend_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAutoextend_clause([NotNull] PlSqlParser.Autoextend_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.autoextend_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAutoextend_clause([NotNull] PlSqlParser.Autoextend_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.maxsize_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMaxsize_clause([NotNull] PlSqlParser.Maxsize_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.maxsize_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMaxsize_clause([NotNull] PlSqlParser.Maxsize_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.build_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBuild_clause([NotNull] PlSqlParser.Build_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.build_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBuild_clause([NotNull] PlSqlParser.Build_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parallel_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParallel_clause([NotNull] PlSqlParser.Parallel_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parallel_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParallel_clause([NotNull] PlSqlParser.Parallel_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_materialized_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_materialized_view([NotNull] PlSqlParser.Alter_materialized_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_materialized_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_materialized_view([NotNull] PlSqlParser.Alter_materialized_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mv_option1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_mv_option1([NotNull] PlSqlParser.Alter_mv_option1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mv_option1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_mv_option1([NotNull] PlSqlParser.Alter_mv_option1Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mv_refresh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_mv_refresh([NotNull] PlSqlParser.Alter_mv_refreshContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mv_refresh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_mv_refresh([NotNull] PlSqlParser.Alter_mv_refreshContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_segment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollback_segment([NotNull] PlSqlParser.Rollback_segmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_segment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollback_segment([NotNull] PlSqlParser.Rollback_segmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_mv_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_mv_column_clause([NotNull] PlSqlParser.Modify_mv_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_mv_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_mv_column_clause([NotNull] PlSqlParser.Modify_mv_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_materialized_view_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_materialized_view_log([NotNull] PlSqlParser.Alter_materialized_view_logContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_materialized_view_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_materialized_view_log([NotNull] PlSqlParser.Alter_materialized_view_logContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_mv_log_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_mv_log_column_clause([NotNull] PlSqlParser.Add_mv_log_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_mv_log_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_mv_log_column_clause([NotNull] PlSqlParser.Add_mv_log_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.move_mv_log_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMove_mv_log_clause([NotNull] PlSqlParser.Move_mv_log_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.move_mv_log_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMove_mv_log_clause([NotNull] PlSqlParser.Move_mv_log_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mv_log_augmentation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMv_log_augmentation([NotNull] PlSqlParser.Mv_log_augmentationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mv_log_augmentation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMv_log_augmentation([NotNull] PlSqlParser.Mv_log_augmentationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datetime_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatetime_expr([NotNull] PlSqlParser.Datetime_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datetime_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatetime_expr([NotNull] PlSqlParser.Datetime_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.interval_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterval_expr([NotNull] PlSqlParser.Interval_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.interval_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterval_expr([NotNull] PlSqlParser.Interval_exprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.synchronous_or_asynchronous"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSynchronous_or_asynchronous([NotNull] PlSqlParser.Synchronous_or_asynchronousContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.synchronous_or_asynchronous"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSynchronous_or_asynchronous([NotNull] PlSqlParser.Synchronous_or_asynchronousContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.including_or_excluding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIncluding_or_excluding([NotNull] PlSqlParser.Including_or_excludingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.including_or_excluding"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIncluding_or_excluding([NotNull] PlSqlParser.Including_or_excludingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_materialized_view_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_materialized_view_log([NotNull] PlSqlParser.Create_materialized_view_logContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_materialized_view_log"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_materialized_view_log([NotNull] PlSqlParser.Create_materialized_view_logContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_values_clause([NotNull] PlSqlParser.New_values_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_values_clause([NotNull] PlSqlParser.New_values_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mv_log_purge_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMv_log_purge_clause([NotNull] PlSqlParser.Mv_log_purge_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mv_log_purge_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMv_log_purge_clause([NotNull] PlSqlParser.Mv_log_purge_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_materialized_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_materialized_view([NotNull] PlSqlParser.Create_materialized_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_materialized_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_materialized_view([NotNull] PlSqlParser.Create_materialized_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_mv_refresh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_mv_refresh([NotNull] PlSqlParser.Create_mv_refreshContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_mv_refresh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_mv_refresh([NotNull] PlSqlParser.Create_mv_refreshContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_context"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_context([NotNull] PlSqlParser.Create_contextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_context"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_context([NotNull] PlSqlParser.Create_contextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oracle_namespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOracle_namespace([NotNull] PlSqlParser.Oracle_namespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oracle_namespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOracle_namespace([NotNull] PlSqlParser.Oracle_namespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_cluster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_cluster([NotNull] PlSqlParser.Create_clusterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_cluster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_cluster([NotNull] PlSqlParser.Create_clusterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_table([NotNull] PlSqlParser.Create_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_table([NotNull] PlSqlParser.Create_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltype_table([NotNull] PlSqlParser.Xmltype_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltype_table([NotNull] PlSqlParser.Xmltype_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_virtual_columns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltype_virtual_columns([NotNull] PlSqlParser.Xmltype_virtual_columnsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_virtual_columns"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltype_virtual_columns([NotNull] PlSqlParser.Xmltype_virtual_columnsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_column_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltype_column_properties([NotNull] PlSqlParser.Xmltype_column_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_column_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltype_column_properties([NotNull] PlSqlParser.Xmltype_column_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltype_storage([NotNull] PlSqlParser.Xmltype_storageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltype_storage([NotNull] PlSqlParser.Xmltype_storageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlschema_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlschema_spec([NotNull] PlSqlParser.Xmlschema_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlschema_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlschema_spec([NotNull] PlSqlParser.Xmlschema_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_table([NotNull] PlSqlParser.Object_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_table([NotNull] PlSqlParser.Object_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oid_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOid_index_clause([NotNull] PlSqlParser.Oid_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oid_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOid_index_clause([NotNull] PlSqlParser.Oid_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oid_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOid_clause([NotNull] PlSqlParser.Oid_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oid_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOid_clause([NotNull] PlSqlParser.Oid_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_properties([NotNull] PlSqlParser.Object_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_properties([NotNull] PlSqlParser.Object_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_table_substitution"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_table_substitution([NotNull] PlSqlParser.Object_table_substitutionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_table_substitution"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_table_substitution([NotNull] PlSqlParser.Object_table_substitutionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_table([NotNull] PlSqlParser.Relational_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_table([NotNull] PlSqlParser.Relational_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_property"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_property([NotNull] PlSqlParser.Relational_propertyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_property"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_property([NotNull] PlSqlParser.Relational_propertyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_partitioning_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_partitioning_clauses([NotNull] PlSqlParser.Table_partitioning_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_partitioning_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_partitioning_clauses([NotNull] PlSqlParser.Table_partitioning_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange_partitions([NotNull] PlSqlParser.Range_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange_partitions([NotNull] PlSqlParser.Range_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList_partitions([NotNull] PlSqlParser.List_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList_partitions([NotNull] PlSqlParser.List_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_partitions([NotNull] PlSqlParser.Hash_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_partitions([NotNull] PlSqlParser.Hash_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.individual_hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndividual_hash_partitions([NotNull] PlSqlParser.Individual_hash_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.individual_hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndividual_hash_partitions([NotNull] PlSqlParser.Individual_hash_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partitions_by_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_partitions_by_quantity([NotNull] PlSqlParser.Hash_partitions_by_quantityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partitions_by_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_partitions_by_quantity([NotNull] PlSqlParser.Hash_partitions_by_quantityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partition_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_partition_quantity([NotNull] PlSqlParser.Hash_partition_quantityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partition_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_partition_quantity([NotNull] PlSqlParser.Hash_partition_quantityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_range_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComposite_range_partitions([NotNull] PlSqlParser.Composite_range_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_range_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComposite_range_partitions([NotNull] PlSqlParser.Composite_range_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_list_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComposite_list_partitions([NotNull] PlSqlParser.Composite_list_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_list_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComposite_list_partitions([NotNull] PlSqlParser.Composite_list_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComposite_hash_partitions([NotNull] PlSqlParser.Composite_hash_partitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_hash_partitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComposite_hash_partitions([NotNull] PlSqlParser.Composite_hash_partitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReference_partitioning([NotNull] PlSqlParser.Reference_partitioningContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReference_partitioning([NotNull] PlSqlParser.Reference_partitioningContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReference_partition_desc([NotNull] PlSqlParser.Reference_partition_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReference_partition_desc([NotNull] PlSqlParser.Reference_partition_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.system_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSystem_partitioning([NotNull] PlSqlParser.System_partitioningContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.system_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSystem_partitioning([NotNull] PlSqlParser.System_partitioningContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange_partition_desc([NotNull] PlSqlParser.Range_partition_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange_partition_desc([NotNull] PlSqlParser.Range_partition_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList_partition_desc([NotNull] PlSqlParser.List_partition_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_partition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList_partition_desc([NotNull] PlSqlParser.List_partition_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_template"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_template([NotNull] PlSqlParser.Subpartition_templateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_template"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_template([NotNull] PlSqlParser.Subpartition_templateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_subpartition_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_subpartition_quantity([NotNull] PlSqlParser.Hash_subpartition_quantityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_subpartition_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_subpartition_quantity([NotNull] PlSqlParser.Hash_subpartition_quantityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_range"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_by_range([NotNull] PlSqlParser.Subpartition_by_rangeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_range"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_by_range([NotNull] PlSqlParser.Subpartition_by_rangeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_by_list([NotNull] PlSqlParser.Subpartition_by_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_by_list([NotNull] PlSqlParser.Subpartition_by_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_hash"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_by_hash([NotNull] PlSqlParser.Subpartition_by_hashContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_hash"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_by_hash([NotNull] PlSqlParser.Subpartition_by_hashContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_name([NotNull] PlSqlParser.Subpartition_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_name([NotNull] PlSqlParser.Subpartition_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_subpartition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange_subpartition_desc([NotNull] PlSqlParser.Range_subpartition_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_subpartition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange_subpartition_desc([NotNull] PlSqlParser.Range_subpartition_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_subpartition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList_subpartition_desc([NotNull] PlSqlParser.List_subpartition_descContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_subpartition_desc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList_subpartition_desc([NotNull] PlSqlParser.List_subpartition_descContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.individual_hash_subparts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndividual_hash_subparts([NotNull] PlSqlParser.Individual_hash_subpartsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.individual_hash_subparts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndividual_hash_subparts([NotNull] PlSqlParser.Individual_hash_subpartsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_subparts_by_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHash_subparts_by_quantity([NotNull] PlSqlParser.Hash_subparts_by_quantityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_subparts_by_quantity"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHash_subparts_by_quantity([NotNull] PlSqlParser.Hash_subparts_by_quantityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange_values_clause([NotNull] PlSqlParser.Range_values_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange_values_clause([NotNull] PlSqlParser.Range_values_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterList_values_clause([NotNull] PlSqlParser.List_values_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitList_values_clause([NotNull] PlSqlParser.List_values_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_partition_description"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_partition_description([NotNull] PlSqlParser.Table_partition_descriptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_partition_description"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_partition_description([NotNull] PlSqlParser.Table_partition_descriptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partitioning_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitioning_storage_clause([NotNull] PlSqlParser.Partitioning_storage_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partitioning_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitioning_storage_clause([NotNull] PlSqlParser.Partitioning_storage_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_partitioning_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_partitioning_storage([NotNull] PlSqlParser.Lob_partitioning_storageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_partitioning_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_partitioning_storage([NotNull] PlSqlParser.Lob_partitioning_storageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datatype_null_enable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatatype_null_enable([NotNull] PlSqlParser.Datatype_null_enableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datatype_null_enable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatatype_null_enable([NotNull] PlSqlParser.Datatype_null_enableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.size_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSize_clause([NotNull] PlSqlParser.Size_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.size_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSize_clause([NotNull] PlSqlParser.Size_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_compression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_compression([NotNull] PlSqlParser.Table_compressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_compression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_compression([NotNull] PlSqlParser.Table_compressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.physical_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhysical_attributes_clause([NotNull] PlSqlParser.Physical_attributes_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.physical_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhysical_attributes_clause([NotNull] PlSqlParser.Physical_attributes_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStorage_clause([NotNull] PlSqlParser.Storage_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStorage_clause([NotNull] PlSqlParser.Storage_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.deferred_segment_creation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeferred_segment_creation([NotNull] PlSqlParser.Deferred_segment_creationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.deferred_segment_creation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeferred_segment_creation([NotNull] PlSqlParser.Deferred_segment_creationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.segment_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSegment_attributes_clause([NotNull] PlSqlParser.Segment_attributes_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.segment_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSegment_attributes_clause([NotNull] PlSqlParser.Segment_attributes_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.physical_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPhysical_properties([NotNull] PlSqlParser.Physical_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.physical_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPhysical_properties([NotNull] PlSqlParser.Physical_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.row_movement_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRow_movement_clause([NotNull] PlSqlParser.Row_movement_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.row_movement_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRow_movement_clause([NotNull] PlSqlParser.Row_movement_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_archive_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlashback_archive_clause([NotNull] PlSqlParser.Flashback_archive_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_archive_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlashback_archive_clause([NotNull] PlSqlParser.Flashback_archive_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.log_grp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLog_grp([NotNull] PlSqlParser.Log_grpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.log_grp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLog_grp([NotNull] PlSqlParser.Log_grpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_table_logging"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_table_logging([NotNull] PlSqlParser.Supplemental_table_loggingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_table_logging"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_table_logging([NotNull] PlSqlParser.Supplemental_table_loggingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_log_grp_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_log_grp_clause([NotNull] PlSqlParser.Supplemental_log_grp_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_log_grp_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_log_grp_clause([NotNull] PlSqlParser.Supplemental_log_grp_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_id_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_id_key_clause([NotNull] PlSqlParser.Supplemental_id_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_id_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_id_key_clause([NotNull] PlSqlParser.Supplemental_id_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.allocate_extent_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAllocate_extent_clause([NotNull] PlSqlParser.Allocate_extent_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.allocate_extent_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAllocate_extent_clause([NotNull] PlSqlParser.Allocate_extent_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.deallocate_unused_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeallocate_unused_clause([NotNull] PlSqlParser.Deallocate_unused_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.deallocate_unused_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeallocate_unused_clause([NotNull] PlSqlParser.Deallocate_unused_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.shrink_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShrink_clause([NotNull] PlSqlParser.Shrink_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.shrink_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShrink_clause([NotNull] PlSqlParser.Shrink_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.records_per_block_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecords_per_block_clause([NotNull] PlSqlParser.Records_per_block_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.records_per_block_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecords_per_block_clause([NotNull] PlSqlParser.Records_per_block_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upgrade_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpgrade_table_clause([NotNull] PlSqlParser.Upgrade_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upgrade_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpgrade_table_clause([NotNull] PlSqlParser.Upgrade_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.truncate_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncate_table([NotNull] PlSqlParser.Truncate_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.truncate_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncate_table([NotNull] PlSqlParser.Truncate_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_table([NotNull] PlSqlParser.Drop_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_table([NotNull] PlSqlParser.Drop_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_view([NotNull] PlSqlParser.Drop_viewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_view"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_view([NotNull] PlSqlParser.Drop_viewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.comment_on_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComment_on_column([NotNull] PlSqlParser.Comment_on_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.comment_on_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComment_on_column([NotNull] PlSqlParser.Comment_on_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_or_disable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnable_or_disable([NotNull] PlSqlParser.Enable_or_disableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_or_disable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnable_or_disable([NotNull] PlSqlParser.Enable_or_disableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.allow_or_disallow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAllow_or_disallow([NotNull] PlSqlParser.Allow_or_disallowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.allow_or_disallow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAllow_or_disallow([NotNull] PlSqlParser.Allow_or_disallowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_synonym([NotNull] PlSqlParser.Create_synonymContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_synonym"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_synonym([NotNull] PlSqlParser.Create_synonymContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.comment_on_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComment_on_table([NotNull] PlSqlParser.Comment_on_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.comment_on_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComment_on_table([NotNull] PlSqlParser.Comment_on_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_cluster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_cluster([NotNull] PlSqlParser.Alter_clusterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_cluster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_cluster([NotNull] PlSqlParser.Alter_clusterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cache_or_nocache"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCache_or_nocache([NotNull] PlSqlParser.Cache_or_nocacheContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cache_or_nocache"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCache_or_nocache([NotNull] PlSqlParser.Cache_or_nocacheContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_name([NotNull] PlSqlParser.Database_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_name([NotNull] PlSqlParser.Database_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_database([NotNull] PlSqlParser.Alter_databaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_database([NotNull] PlSqlParser.Alter_databaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.startup_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartup_clauses([NotNull] PlSqlParser.Startup_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.startup_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartup_clauses([NotNull] PlSqlParser.Startup_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.resetlogs_or_noresetlogs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResetlogs_or_noresetlogs([NotNull] PlSqlParser.Resetlogs_or_noresetlogsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.resetlogs_or_noresetlogs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResetlogs_or_noresetlogs([NotNull] PlSqlParser.Resetlogs_or_noresetlogsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upgrade_or_downgrade"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpgrade_or_downgrade([NotNull] PlSqlParser.Upgrade_or_downgradeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upgrade_or_downgrade"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpgrade_or_downgrade([NotNull] PlSqlParser.Upgrade_or_downgradeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.recovery_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecovery_clauses([NotNull] PlSqlParser.Recovery_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.recovery_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecovery_clauses([NotNull] PlSqlParser.Recovery_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.begin_or_end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBegin_or_end([NotNull] PlSqlParser.Begin_or_endContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.begin_or_end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBegin_or_end([NotNull] PlSqlParser.Begin_or_endContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneral_recovery([NotNull] PlSqlParser.General_recoveryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneral_recovery([NotNull] PlSqlParser.General_recoveryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.full_database_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFull_database_recovery([NotNull] PlSqlParser.Full_database_recoveryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.full_database_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFull_database_recovery([NotNull] PlSqlParser.Full_database_recoveryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partial_database_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartial_database_recovery([NotNull] PlSqlParser.Partial_database_recoveryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partial_database_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartial_database_recovery([NotNull] PlSqlParser.Partial_database_recoveryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partial_database_recovery_10g"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartial_database_recovery_10g([NotNull] PlSqlParser.Partial_database_recovery_10gContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partial_database_recovery_10g"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartial_database_recovery_10g([NotNull] PlSqlParser.Partial_database_recovery_10gContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.managed_standby_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterManaged_standby_recovery([NotNull] PlSqlParser.Managed_standby_recoveryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.managed_standby_recovery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitManaged_standby_recovery([NotNull] PlSqlParser.Managed_standby_recoveryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.db_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDb_name([NotNull] PlSqlParser.Db_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.db_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDb_name([NotNull] PlSqlParser.Db_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database_file_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase_file_clauses([NotNull] PlSqlParser.Database_file_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database_file_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase_file_clauses([NotNull] PlSqlParser.Database_file_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_datafile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreate_datafile_clause([NotNull] PlSqlParser.Create_datafile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_datafile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreate_datafile_clause([NotNull] PlSqlParser.Create_datafile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_datafile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_datafile_clause([NotNull] PlSqlParser.Alter_datafile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_datafile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_datafile_clause([NotNull] PlSqlParser.Alter_datafile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_tempfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_tempfile_clause([NotNull] PlSqlParser.Alter_tempfile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_tempfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_tempfile_clause([NotNull] PlSqlParser.Alter_tempfile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfile_clauses([NotNull] PlSqlParser.Logfile_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfile_clauses([NotNull] PlSqlParser.Logfile_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_logfile_clauses([NotNull] PlSqlParser.Add_logfile_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_logfile_clauses([NotNull] PlSqlParser.Add_logfile_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.log_file_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLog_file_group([NotNull] PlSqlParser.Log_file_groupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.log_file_group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLog_file_group([NotNull] PlSqlParser.Log_file_groupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_logfile_clauses([NotNull] PlSqlParser.Drop_logfile_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_logfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_logfile_clauses([NotNull] PlSqlParser.Drop_logfile_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.switch_logfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_logfile_clause([NotNull] PlSqlParser.Switch_logfile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.switch_logfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_logfile_clause([NotNull] PlSqlParser.Switch_logfile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_db_logging"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_db_logging([NotNull] PlSqlParser.Supplemental_db_loggingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_db_logging"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_db_logging([NotNull] PlSqlParser.Supplemental_db_loggingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_or_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_or_drop([NotNull] PlSqlParser.Add_or_dropContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_or_drop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_or_drop([NotNull] PlSqlParser.Add_or_dropContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_plsql_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_plsql_clause([NotNull] PlSqlParser.Supplemental_plsql_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_plsql_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_plsql_clause([NotNull] PlSqlParser.Supplemental_plsql_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logfile_descriptor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfile_descriptor([NotNull] PlSqlParser.Logfile_descriptorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logfile_descriptor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfile_descriptor([NotNull] PlSqlParser.Logfile_descriptorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.controlfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterControlfile_clauses([NotNull] PlSqlParser.Controlfile_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.controlfile_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitControlfile_clauses([NotNull] PlSqlParser.Controlfile_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trace_file_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrace_file_clause([NotNull] PlSqlParser.Trace_file_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trace_file_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrace_file_clause([NotNull] PlSqlParser.Trace_file_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standby_database_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStandby_database_clauses([NotNull] PlSqlParser.Standby_database_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standby_database_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStandby_database_clauses([NotNull] PlSqlParser.Standby_database_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.activate_standby_db_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterActivate_standby_db_clause([NotNull] PlSqlParser.Activate_standby_db_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.activate_standby_db_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitActivate_standby_db_clause([NotNull] PlSqlParser.Activate_standby_db_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.maximize_standby_db_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMaximize_standby_db_clause([NotNull] PlSqlParser.Maximize_standby_db_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.maximize_standby_db_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMaximize_standby_db_clause([NotNull] PlSqlParser.Maximize_standby_db_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.register_logfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRegister_logfile_clause([NotNull] PlSqlParser.Register_logfile_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.register_logfile_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRegister_logfile_clause([NotNull] PlSqlParser.Register_logfile_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.commit_switchover_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommit_switchover_clause([NotNull] PlSqlParser.Commit_switchover_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.commit_switchover_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommit_switchover_clause([NotNull] PlSqlParser.Commit_switchover_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_standby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart_standby_clause([NotNull] PlSqlParser.Start_standby_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_standby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart_standby_clause([NotNull] PlSqlParser.Start_standby_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.stop_standby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStop_standby_clause([NotNull] PlSqlParser.Stop_standby_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.stop_standby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStop_standby_clause([NotNull] PlSqlParser.Stop_standby_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.convert_database_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConvert_database_clause([NotNull] PlSqlParser.Convert_database_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.convert_database_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConvert_database_clause([NotNull] PlSqlParser.Convert_database_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_settings_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_settings_clause([NotNull] PlSqlParser.Default_settings_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_settings_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_settings_clause([NotNull] PlSqlParser.Default_settings_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_time_zone_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_time_zone_clause([NotNull] PlSqlParser.Set_time_zone_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_time_zone_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_time_zone_clause([NotNull] PlSqlParser.Set_time_zone_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.instance_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstance_clauses([NotNull] PlSqlParser.Instance_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.instance_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstance_clauses([NotNull] PlSqlParser.Instance_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.security_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSecurity_clause([NotNull] PlSqlParser.Security_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.security_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSecurity_clause([NotNull] PlSqlParser.Security_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.domain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDomain([NotNull] PlSqlParser.DomainContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.domain"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDomain([NotNull] PlSqlParser.DomainContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatabase([NotNull] PlSqlParser.DatabaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatabase([NotNull] PlSqlParser.DatabaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.edition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEdition_name([NotNull] PlSqlParser.Edition_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.edition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEdition_name([NotNull] PlSqlParser.Edition_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.filenumber"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilenumber([NotNull] PlSqlParser.FilenumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.filenumber"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilenumber([NotNull] PlSqlParser.FilenumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilename([NotNull] PlSqlParser.FilenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.filename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilename([NotNull] PlSqlParser.FilenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table([NotNull] PlSqlParser.Alter_tableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table([NotNull] PlSqlParser.Alter_tableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_properties([NotNull] PlSqlParser.Alter_table_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_properties([NotNull] PlSqlParser.Alter_table_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_partitioning([NotNull] PlSqlParser.Alter_table_partitioningContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_partitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_partitioning([NotNull] PlSqlParser.Alter_table_partitioningContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_table_partition([NotNull] PlSqlParser.Add_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_table_partition([NotNull] PlSqlParser.Add_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_table_partition([NotNull] PlSqlParser.Drop_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_table_partition([NotNull] PlSqlParser.Drop_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_table_partition([NotNull] PlSqlParser.Merge_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_table_partition([NotNull] PlSqlParser.Merge_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_table_partition([NotNull] PlSqlParser.Modify_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_table_partition([NotNull] PlSqlParser.Modify_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.split_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSplit_table_partition([NotNull] PlSqlParser.Split_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.split_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSplit_table_partition([NotNull] PlSqlParser.Split_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.truncate_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncate_table_partition([NotNull] PlSqlParser.Truncate_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.truncate_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncate_table_partition([NotNull] PlSqlParser.Truncate_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exchange_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExchange_table_partition([NotNull] PlSqlParser.Exchange_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exchange_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExchange_table_partition([NotNull] PlSqlParser.Exchange_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.coalesce_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCoalesce_table_partition([NotNull] PlSqlParser.Coalesce_table_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.coalesce_table_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCoalesce_table_partition([NotNull] PlSqlParser.Coalesce_table_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_interval_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_interval_partition([NotNull] PlSqlParser.Alter_interval_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_interval_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_interval_partition([NotNull] PlSqlParser.Alter_interval_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extended_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_extended_names([NotNull] PlSqlParser.Partition_extended_namesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extended_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_extended_names([NotNull] PlSqlParser.Partition_extended_namesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_extended_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartition_extended_names([NotNull] PlSqlParser.Subpartition_extended_namesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_extended_names"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartition_extended_names([NotNull] PlSqlParser.Subpartition_extended_namesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_properties_1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_table_properties_1([NotNull] PlSqlParser.Alter_table_properties_1Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_properties_1"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_table_properties_1([NotNull] PlSqlParser.Alter_table_properties_1Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_iot_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_iot_clauses([NotNull] PlSqlParser.Alter_iot_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_iot_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_iot_clauses([NotNull] PlSqlParser.Alter_iot_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mapping_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_mapping_table_clause([NotNull] PlSqlParser.Alter_mapping_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mapping_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_mapping_table_clause([NotNull] PlSqlParser.Alter_mapping_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_overflow_clause([NotNull] PlSqlParser.Alter_overflow_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_overflow_clause([NotNull] PlSqlParser.Alter_overflow_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_overflow_clause([NotNull] PlSqlParser.Add_overflow_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_overflow_clause([NotNull] PlSqlParser.Add_overflow_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_index_clauses([NotNull] PlSqlParser.Update_index_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_index_clauses([NotNull] PlSqlParser.Update_index_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_global_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_global_index_clause([NotNull] PlSqlParser.Update_global_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_global_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_global_index_clause([NotNull] PlSqlParser.Update_global_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_all_indexes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_all_indexes_clause([NotNull] PlSqlParser.Update_all_indexes_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_all_indexes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_all_indexes_clause([NotNull] PlSqlParser.Update_all_indexes_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_all_indexes_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_all_indexes_index_clause([NotNull] PlSqlParser.Update_all_indexes_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_all_indexes_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_all_indexes_index_clause([NotNull] PlSqlParser.Update_all_indexes_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_index_partition([NotNull] PlSqlParser.Update_index_partitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_partition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_index_partition([NotNull] PlSqlParser.Update_index_partitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_subpartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_index_subpartition([NotNull] PlSqlParser.Update_index_subpartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_subpartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_index_subpartition([NotNull] PlSqlParser.Update_index_subpartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_disable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnable_disable_clause([NotNull] PlSqlParser.Enable_disable_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_disable_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnable_disable_clause([NotNull] PlSqlParser.Enable_disable_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_index_clause([NotNull] PlSqlParser.Using_index_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_index_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_index_clause([NotNull] PlSqlParser.Using_index_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_attributes([NotNull] PlSqlParser.Index_attributesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_attributes([NotNull] PlSqlParser.Index_attributesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sort_or_nosort"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSort_or_nosort([NotNull] PlSqlParser.Sort_or_nosortContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sort_or_nosort"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSort_or_nosort([NotNull] PlSqlParser.Sort_or_nosortContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exceptions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptions_clause([NotNull] PlSqlParser.Exceptions_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exceptions_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptions_clause([NotNull] PlSqlParser.Exceptions_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.move_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMove_table_clause([NotNull] PlSqlParser.Move_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.move_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMove_table_clause([NotNull] PlSqlParser.Move_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_org_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_org_table_clause([NotNull] PlSqlParser.Index_org_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_org_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_org_table_clause([NotNull] PlSqlParser.Index_org_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mapping_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMapping_table_clause([NotNull] PlSqlParser.Mapping_table_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mapping_table_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMapping_table_clause([NotNull] PlSqlParser.Mapping_table_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.key_compression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKey_compression([NotNull] PlSqlParser.Key_compressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.key_compression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKey_compression([NotNull] PlSqlParser.Key_compressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_org_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_org_overflow_clause([NotNull] PlSqlParser.Index_org_overflow_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_org_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_org_overflow_clause([NotNull] PlSqlParser.Index_org_overflow_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_clauses([NotNull] PlSqlParser.Column_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_clauses([NotNull] PlSqlParser.Column_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_collection_retrieval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_collection_retrieval([NotNull] PlSqlParser.Modify_collection_retrievalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_collection_retrieval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_collection_retrieval([NotNull] PlSqlParser.Modify_collection_retrievalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collection_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollection_item([NotNull] PlSqlParser.Collection_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collection_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollection_item([NotNull] PlSqlParser.Collection_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRename_column_clause([NotNull] PlSqlParser.Rename_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRename_column_clause([NotNull] PlSqlParser.Rename_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.old_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOld_column_name([NotNull] PlSqlParser.Old_column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.old_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOld_column_name([NotNull] PlSqlParser.Old_column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_column_name([NotNull] PlSqlParser.New_column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_column_name([NotNull] PlSqlParser.New_column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_modify_drop_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_modify_drop_column_clauses([NotNull] PlSqlParser.Add_modify_drop_column_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_modify_drop_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_modify_drop_column_clauses([NotNull] PlSqlParser.Add_modify_drop_column_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_column_clause([NotNull] PlSqlParser.Drop_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_column_clause([NotNull] PlSqlParser.Drop_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_column_clauses([NotNull] PlSqlParser.Modify_column_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_column_clauses([NotNull] PlSqlParser.Modify_column_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_col_properties([NotNull] PlSqlParser.Modify_col_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_col_properties([NotNull] PlSqlParser.Modify_col_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_col_substitutable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_col_substitutable([NotNull] PlSqlParser.Modify_col_substitutableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_col_substitutable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_col_substitutable([NotNull] PlSqlParser.Modify_col_substitutableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_column_clause([NotNull] PlSqlParser.Add_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_column_clause([NotNull] PlSqlParser.Add_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_varray_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlter_varray_col_properties([NotNull] PlSqlParser.Alter_varray_col_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_varray_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlter_varray_col_properties([NotNull] PlSqlParser.Alter_varray_col_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarray_col_properties([NotNull] PlSqlParser.Varray_col_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarray_col_properties([NotNull] PlSqlParser.Varray_col_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarray_storage_clause([NotNull] PlSqlParser.Varray_storage_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarray_storage_clause([NotNull] PlSqlParser.Varray_storage_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_segname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_segname([NotNull] PlSqlParser.Lob_segnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_segname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_segname([NotNull] PlSqlParser.Lob_segnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_item([NotNull] PlSqlParser.Lob_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_item([NotNull] PlSqlParser.Lob_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_storage_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_storage_parameters([NotNull] PlSqlParser.Lob_storage_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_storage_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_storage_parameters([NotNull] PlSqlParser.Lob_storage_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_storage_clause([NotNull] PlSqlParser.Lob_storage_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_storage_clause([NotNull] PlSqlParser.Lob_storage_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_lob_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_lob_storage_clause([NotNull] PlSqlParser.Modify_lob_storage_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_lob_storage_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_lob_storage_clause([NotNull] PlSqlParser.Modify_lob_storage_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_lob_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModify_lob_parameters([NotNull] PlSqlParser.Modify_lob_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_lob_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModify_lob_parameters([NotNull] PlSqlParser.Modify_lob_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_parameters([NotNull] PlSqlParser.Lob_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_parameters([NotNull] PlSqlParser.Lob_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_deduplicate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_deduplicate_clause([NotNull] PlSqlParser.Lob_deduplicate_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_deduplicate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_deduplicate_clause([NotNull] PlSqlParser.Lob_deduplicate_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_compression_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_compression_clause([NotNull] PlSqlParser.Lob_compression_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_compression_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_compression_clause([NotNull] PlSqlParser.Lob_compression_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_retention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLob_retention_clause([NotNull] PlSqlParser.Lob_retention_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_retention_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLob_retention_clause([NotNull] PlSqlParser.Lob_retention_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.encryption_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEncryption_spec([NotNull] PlSqlParser.Encryption_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.encryption_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEncryption_spec([NotNull] PlSqlParser.Encryption_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespace([NotNull] PlSqlParser.TablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespace([NotNull] PlSqlParser.TablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarray_item([NotNull] PlSqlParser.Varray_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarray_item([NotNull] PlSqlParser.Varray_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_properties([NotNull] PlSqlParser.Column_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_properties([NotNull] PlSqlParser.Column_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.period_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPeriod_definition([NotNull] PlSqlParser.Period_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.period_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPeriod_definition([NotNull] PlSqlParser.Period_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_time_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart_time_column([NotNull] PlSqlParser.Start_time_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_time_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart_time_column([NotNull] PlSqlParser.Start_time_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.end_time_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnd_time_column([NotNull] PlSqlParser.End_time_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.end_time_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnd_time_column([NotNull] PlSqlParser.End_time_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_definition([NotNull] PlSqlParser.Column_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_definition([NotNull] PlSqlParser.Column_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.virtual_column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVirtual_column_definition([NotNull] PlSqlParser.Virtual_column_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.virtual_column_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVirtual_column_definition([NotNull] PlSqlParser.Virtual_column_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.autogenerated_sequence_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAutogenerated_sequence_definition([NotNull] PlSqlParser.Autogenerated_sequence_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.autogenerated_sequence_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAutogenerated_sequence_definition([NotNull] PlSqlParser.Autogenerated_sequence_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_part_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOut_of_line_part_storage([NotNull] PlSqlParser.Out_of_line_part_storageContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_part_storage"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOut_of_line_part_storage([NotNull] PlSqlParser.Out_of_line_part_storageContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_table_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNested_table_col_properties([NotNull] PlSqlParser.Nested_table_col_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_table_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNested_table_col_properties([NotNull] PlSqlParser.Nested_table_col_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNested_item([NotNull] PlSqlParser.Nested_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNested_item([NotNull] PlSqlParser.Nested_itemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.substitutable_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubstitutable_column_clause([NotNull] PlSqlParser.Substitutable_column_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.substitutable_column_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubstitutable_column_clause([NotNull] PlSqlParser.Substitutable_column_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_name([NotNull] PlSqlParser.Partition_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_name([NotNull] PlSqlParser.Partition_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_logging_props"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSupplemental_logging_props([NotNull] PlSqlParser.Supplemental_logging_propsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_logging_props"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSupplemental_logging_props([NotNull] PlSqlParser.Supplemental_logging_propsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_or_attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_or_attribute([NotNull] PlSqlParser.Column_or_attributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_or_attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_or_attribute([NotNull] PlSqlParser.Column_or_attributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_type_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_type_col_properties([NotNull] PlSqlParser.Object_type_col_propertiesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_type_col_properties"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_type_col_properties([NotNull] PlSqlParser.Object_type_col_propertiesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraint_clauses([NotNull] PlSqlParser.Constraint_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraint_clauses([NotNull] PlSqlParser.Constraint_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.old_constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOld_constraint_name([NotNull] PlSqlParser.Old_constraint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.old_constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOld_constraint_name([NotNull] PlSqlParser.Old_constraint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNew_constraint_name([NotNull] PlSqlParser.New_constraint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNew_constraint_name([NotNull] PlSqlParser.New_constraint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_constraint_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_constraint_clause([NotNull] PlSqlParser.Drop_constraint_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_constraint_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_constraint_clause([NotNull] PlSqlParser.Drop_constraint_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_primary_key_or_unique_or_generic_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_primary_key_or_unique_or_generic_clause([NotNull] PlSqlParser.Drop_primary_key_or_unique_or_generic_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_primary_key_or_unique_or_generic_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_primary_key_or_unique_or_generic_clause([NotNull] PlSqlParser.Drop_primary_key_or_unique_or_generic_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_constraint([NotNull] PlSqlParser.Add_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_constraint([NotNull] PlSqlParser.Add_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_constraint_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_constraint_clause([NotNull] PlSqlParser.Add_constraint_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_constraint_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_constraint_clause([NotNull] PlSqlParser.Add_constraint_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.check_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheck_constraint([NotNull] PlSqlParser.Check_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.check_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheck_constraint([NotNull] PlSqlParser.Check_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrop_constraint([NotNull] PlSqlParser.Drop_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrop_constraint([NotNull] PlSqlParser.Drop_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnable_constraint([NotNull] PlSqlParser.Enable_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnable_constraint([NotNull] PlSqlParser.Enable_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.disable_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDisable_constraint([NotNull] PlSqlParser.Disable_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.disable_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDisable_constraint([NotNull] PlSqlParser.Disable_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeign_key_clause([NotNull] PlSqlParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.foreign_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeign_key_clause([NotNull] PlSqlParser.Foreign_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.references_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferences_clause([NotNull] PlSqlParser.References_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.references_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferences_clause([NotNull] PlSqlParser.References_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_delete_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOn_delete_clause([NotNull] PlSqlParser.On_delete_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_delete_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOn_delete_clause([NotNull] PlSqlParser.On_delete_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unique_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnique_key_clause([NotNull] PlSqlParser.Unique_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unique_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnique_key_clause([NotNull] PlSqlParser.Unique_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.primary_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary_key_clause([NotNull] PlSqlParser.Primary_key_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.primary_key_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary_key_clause([NotNull] PlSqlParser.Primary_key_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.anonymous_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymous_block([NotNull] PlSqlParser.Anonymous_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.anonymous_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymous_block([NotNull] PlSqlParser.Anonymous_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.invoker_rights_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInvoker_rights_clause([NotNull] PlSqlParser.Invoker_rights_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.invoker_rights_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInvoker_rights_clause([NotNull] PlSqlParser.Invoker_rights_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.call_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCall_spec([NotNull] PlSqlParser.Call_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.call_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCall_spec([NotNull] PlSqlParser.Call_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.java_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJava_spec([NotNull] PlSqlParser.Java_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.java_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJava_spec([NotNull] PlSqlParser.Java_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_spec([NotNull] PlSqlParser.C_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_spec([NotNull] PlSqlParser.C_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_agent_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_agent_in_clause([NotNull] PlSqlParser.C_agent_in_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_agent_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_agent_in_clause([NotNull] PlSqlParser.C_agent_in_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_parameters_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterC_parameters_clause([NotNull] PlSqlParser.C_parameters_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_parameters_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitC_parameters_clause([NotNull] PlSqlParser.C_parameters_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter([NotNull] PlSqlParser.ParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter([NotNull] PlSqlParser.ParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_value_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefault_value_part([NotNull] PlSqlParser.Default_value_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_value_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefault_value_part([NotNull] PlSqlParser.Default_value_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seq_of_declare_specs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeq_of_declare_specs([NotNull] PlSqlParser.Seq_of_declare_specsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seq_of_declare_specs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeq_of_declare_specs([NotNull] PlSqlParser.Seq_of_declare_specsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.declare_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclare_spec([NotNull] PlSqlParser.Declare_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.declare_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclare_spec([NotNull] PlSqlParser.Declare_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.variable_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_declaration([NotNull] PlSqlParser.Variable_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.variable_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_declaration([NotNull] PlSqlParser.Variable_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subtype_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubtype_declaration([NotNull] PlSqlParser.Subtype_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subtype_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubtype_declaration([NotNull] PlSqlParser.Subtype_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_declaration([NotNull] PlSqlParser.Cursor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_declaration([NotNull] PlSqlParser.Cursor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_spec([NotNull] PlSqlParser.Parameter_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_spec([NotNull] PlSqlParser.Parameter_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_declaration([NotNull] PlSqlParser.Exception_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_declaration([NotNull] PlSqlParser.Exception_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPragma_declaration([NotNull] PlSqlParser.Pragma_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPragma_declaration([NotNull] PlSqlParser.Pragma_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.record_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecord_type_def([NotNull] PlSqlParser.Record_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.record_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecord_type_def([NotNull] PlSqlParser.Record_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.field_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterField_spec([NotNull] PlSqlParser.Field_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.field_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitField_spec([NotNull] PlSqlParser.Field_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.ref_cursor_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRef_cursor_type_def([NotNull] PlSqlParser.Ref_cursor_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.ref_cursor_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRef_cursor_type_def([NotNull] PlSqlParser.Ref_cursor_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_declaration([NotNull] PlSqlParser.Type_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_declaration([NotNull] PlSqlParser.Type_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_type_def([NotNull] PlSqlParser.Table_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_type_def([NotNull] PlSqlParser.Table_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_indexed_by_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_indexed_by_part([NotNull] PlSqlParser.Table_indexed_by_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_indexed_by_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_indexed_by_part([NotNull] PlSqlParser.Table_indexed_by_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarray_type_def([NotNull] PlSqlParser.Varray_type_defContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_type_def"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarray_type_def([NotNull] PlSqlParser.Varray_type_defContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seq_of_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeq_of_statements([NotNull] PlSqlParser.Seq_of_statementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seq_of_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeq_of_statements([NotNull] PlSqlParser.Seq_of_statementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.label_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel_declaration([NotNull] PlSqlParser.Label_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.label_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel_declaration([NotNull] PlSqlParser.Label_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] PlSqlParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] PlSqlParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.swallow_to_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwallow_to_semi([NotNull] PlSqlParser.Swallow_to_semiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.swallow_to_semi"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwallow_to_semi([NotNull] PlSqlParser.Swallow_to_semiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.assignment_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_statement([NotNull] PlSqlParser.Assignment_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.assignment_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_statement([NotNull] PlSqlParser.Assignment_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.continue_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinue_statement([NotNull] PlSqlParser.Continue_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.continue_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinue_statement([NotNull] PlSqlParser.Continue_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExit_statement([NotNull] PlSqlParser.Exit_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExit_statement([NotNull] PlSqlParser.Exit_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.goto_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGoto_statement([NotNull] PlSqlParser.Goto_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.goto_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGoto_statement([NotNull] PlSqlParser.Goto_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_statement([NotNull] PlSqlParser.If_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.if_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_statement([NotNull] PlSqlParser.If_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.elsif_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElsif_part([NotNull] PlSqlParser.Elsif_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.elsif_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElsif_part([NotNull] PlSqlParser.Elsif_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElse_part([NotNull] PlSqlParser.Else_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElse_part([NotNull] PlSqlParser.Else_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.loop_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoop_statement([NotNull] PlSqlParser.Loop_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.loop_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoop_statement([NotNull] PlSqlParser.Loop_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_loop_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_loop_param([NotNull] PlSqlParser.Cursor_loop_paramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_loop_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_loop_param([NotNull] PlSqlParser.Cursor_loop_paramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.forall_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForall_statement([NotNull] PlSqlParser.Forall_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.forall_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForall_statement([NotNull] PlSqlParser.Forall_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bounds_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBounds_clause([NotNull] PlSqlParser.Bounds_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bounds_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBounds_clause([NotNull] PlSqlParser.Bounds_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.between_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBetween_bound([NotNull] PlSqlParser.Between_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.between_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBetween_bound([NotNull] PlSqlParser.Between_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lower_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLower_bound([NotNull] PlSqlParser.Lower_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lower_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLower_bound([NotNull] PlSqlParser.Lower_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upper_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpper_bound([NotNull] PlSqlParser.Upper_boundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upper_bound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpper_bound([NotNull] PlSqlParser.Upper_boundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull_statement([NotNull] PlSqlParser.Null_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.null_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull_statement([NotNull] PlSqlParser.Null_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.raise_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRaise_statement([NotNull] PlSqlParser.Raise_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.raise_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRaise_statement([NotNull] PlSqlParser.Raise_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_statement([NotNull] PlSqlParser.Return_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.return_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_statement([NotNull] PlSqlParser.Return_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_call([NotNull] PlSqlParser.Function_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_call([NotNull] PlSqlParser.Function_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_call([NotNull] PlSqlParser.Procedure_callContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_call"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_call([NotNull] PlSqlParser.Procedure_callContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pipe_row_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPipe_row_statement([NotNull] PlSqlParser.Pipe_row_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pipe_row_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPipe_row_statement([NotNull] PlSqlParser.Pipe_row_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBody([NotNull] PlSqlParser.BodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBody([NotNull] PlSqlParser.BodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_handler([NotNull] PlSqlParser.Exception_handlerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_handler([NotNull] PlSqlParser.Exception_handlerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_block([NotNull] PlSqlParser.Trigger_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_block([NotNull] PlSqlParser.Trigger_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] PlSqlParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] PlSqlParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_statement([NotNull] PlSqlParser.Sql_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_statement([NotNull] PlSqlParser.Sql_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.execute_immediate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecute_immediate([NotNull] PlSqlParser.Execute_immediateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.execute_immediate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecute_immediate([NotNull] PlSqlParser.Execute_immediateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dynamic_returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDynamic_returning_clause([NotNull] PlSqlParser.Dynamic_returning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dynamic_returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDynamic_returning_clause([NotNull] PlSqlParser.Dynamic_returning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.data_manipulation_language_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterData_manipulation_language_statements([NotNull] PlSqlParser.Data_manipulation_language_statementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.data_manipulation_language_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitData_manipulation_language_statements([NotNull] PlSqlParser.Data_manipulation_language_statementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_manipulation_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_manipulation_statements([NotNull] PlSqlParser.Cursor_manipulation_statementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_manipulation_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_manipulation_statements([NotNull] PlSqlParser.Cursor_manipulation_statementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.close_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClose_statement([NotNull] PlSqlParser.Close_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.close_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClose_statement([NotNull] PlSqlParser.Close_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.open_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpen_statement([NotNull] PlSqlParser.Open_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.open_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpen_statement([NotNull] PlSqlParser.Open_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.fetch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFetch_statement([NotNull] PlSqlParser.Fetch_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.fetch_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFetch_statement([NotNull] PlSqlParser.Fetch_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.open_for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpen_for_statement([NotNull] PlSqlParser.Open_for_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.open_for_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpen_for_statement([NotNull] PlSqlParser.Open_for_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.transaction_control_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransaction_control_statements([NotNull] PlSqlParser.Transaction_control_statementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.transaction_control_statements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransaction_control_statements([NotNull] PlSqlParser.Transaction_control_statementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_transaction_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_transaction_command([NotNull] PlSqlParser.Set_transaction_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_transaction_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_transaction_command([NotNull] PlSqlParser.Set_transaction_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_constraint_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_constraint_command([NotNull] PlSqlParser.Set_constraint_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_constraint_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_constraint_command([NotNull] PlSqlParser.Set_constraint_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.commit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommit_statement([NotNull] PlSqlParser.Commit_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.commit_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommit_statement([NotNull] PlSqlParser.Commit_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.write_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWrite_clause([NotNull] PlSqlParser.Write_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.write_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWrite_clause([NotNull] PlSqlParser.Write_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollback_statement([NotNull] PlSqlParser.Rollback_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollback_statement([NotNull] PlSqlParser.Rollback_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.savepoint_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_statement([NotNull] PlSqlParser.Savepoint_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.savepoint_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_statement([NotNull] PlSqlParser.Savepoint_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.explain_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplain_statement([NotNull] PlSqlParser.Explain_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.explain_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplain_statement([NotNull] PlSqlParser.Explain_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_only_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_only_statement([NotNull] PlSqlParser.Select_only_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_only_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_only_statement([NotNull] PlSqlParser.Select_only_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_statement([NotNull] PlSqlParser.Select_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_statement([NotNull] PlSqlParser.Select_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_factoring_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery_factoring_clause([NotNull] PlSqlParser.Subquery_factoring_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_factoring_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery_factoring_clause([NotNull] PlSqlParser.Subquery_factoring_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.factoring_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactoring_element([NotNull] PlSqlParser.Factoring_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.factoring_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactoring_element([NotNull] PlSqlParser.Factoring_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.search_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearch_clause([NotNull] PlSqlParser.Search_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.search_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearch_clause([NotNull] PlSqlParser.Search_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cycle_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCycle_clause([NotNull] PlSqlParser.Cycle_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cycle_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCycle_clause([NotNull] PlSqlParser.Cycle_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery([NotNull] PlSqlParser.SubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery([NotNull] PlSqlParser.SubqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_basic_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery_basic_elements([NotNull] PlSqlParser.Subquery_basic_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_basic_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery_basic_elements([NotNull] PlSqlParser.Subquery_basic_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_operation_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery_operation_part([NotNull] PlSqlParser.Subquery_operation_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_operation_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery_operation_part([NotNull] PlSqlParser.Subquery_operation_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_block([NotNull] PlSqlParser.Query_blockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_block([NotNull] PlSqlParser.Query_blockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.selected_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelected_list([NotNull] PlSqlParser.Selected_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.selected_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelected_list([NotNull] PlSqlParser.Selected_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrom_clause([NotNull] PlSqlParser.From_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrom_clause([NotNull] PlSqlParser.From_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_list_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_list_elements([NotNull] PlSqlParser.Select_list_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_list_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_list_elements([NotNull] PlSqlParser.Select_list_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref_list([NotNull] PlSqlParser.Table_ref_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref_list([NotNull] PlSqlParser.Table_ref_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref([NotNull] PlSqlParser.Table_refContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref([NotNull] PlSqlParser.Table_refContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref_aux"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref_aux([NotNull] PlSqlParser.Table_ref_auxContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref_aux"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref_aux([NotNull] PlSqlParser.Table_ref_auxContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_one</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref_aux_internal_one([NotNull] PlSqlParser.Table_ref_aux_internal_oneContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_one</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref_aux_internal_one([NotNull] PlSqlParser.Table_ref_aux_internal_oneContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_two</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref_aux_internal_two([NotNull] PlSqlParser.Table_ref_aux_internal_twoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_two</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref_aux_internal_two([NotNull] PlSqlParser.Table_ref_aux_internal_twoContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_three</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_ref_aux_internal_three([NotNull] PlSqlParser.Table_ref_aux_internal_threeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_three</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_ref_aux_internal_three([NotNull] PlSqlParser.Table_ref_aux_internal_threeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_clause([NotNull] PlSqlParser.Join_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_clause([NotNull] PlSqlParser.Join_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_on_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_on_part([NotNull] PlSqlParser.Join_on_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_on_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_on_part([NotNull] PlSqlParser.Join_on_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_using_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoin_using_part([NotNull] PlSqlParser.Join_using_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_using_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoin_using_part([NotNull] PlSqlParser.Join_using_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.outer_join_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOuter_join_type([NotNull] PlSqlParser.Outer_join_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.outer_join_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOuter_join_type([NotNull] PlSqlParser.Outer_join_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_partition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_partition_clause([NotNull] PlSqlParser.Query_partition_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_partition_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_partition_clause([NotNull] PlSqlParser.Query_partition_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_query_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlashback_query_clause([NotNull] PlSqlParser.Flashback_query_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_query_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlashback_query_clause([NotNull] PlSqlParser.Flashback_query_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_clause([NotNull] PlSqlParser.Pivot_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_clause([NotNull] PlSqlParser.Pivot_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_element([NotNull] PlSqlParser.Pivot_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_element([NotNull] PlSqlParser.Pivot_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_for_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_for_clause([NotNull] PlSqlParser.Pivot_for_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_for_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_for_clause([NotNull] PlSqlParser.Pivot_for_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_in_clause([NotNull] PlSqlParser.Pivot_in_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_in_clause([NotNull] PlSqlParser.Pivot_in_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_in_clause_element([NotNull] PlSqlParser.Pivot_in_clause_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_in_clause_element([NotNull] PlSqlParser.Pivot_in_clause_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPivot_in_clause_elements([NotNull] PlSqlParser.Pivot_in_clause_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPivot_in_clause_elements([NotNull] PlSqlParser.Pivot_in_clause_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnpivot_clause([NotNull] PlSqlParser.Unpivot_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnpivot_clause([NotNull] PlSqlParser.Unpivot_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnpivot_in_clause([NotNull] PlSqlParser.Unpivot_in_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_in_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnpivot_in_clause([NotNull] PlSqlParser.Unpivot_in_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_in_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnpivot_in_elements([NotNull] PlSqlParser.Unpivot_in_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_in_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnpivot_in_elements([NotNull] PlSqlParser.Unpivot_in_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hierarchical_query_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHierarchical_query_clause([NotNull] PlSqlParser.Hierarchical_query_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hierarchical_query_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHierarchical_query_clause([NotNull] PlSqlParser.Hierarchical_query_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart_part([NotNull] PlSqlParser.Start_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart_part([NotNull] PlSqlParser.Start_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.group_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_by_clause([NotNull] PlSqlParser.Group_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.group_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_by_clause([NotNull] PlSqlParser.Group_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.group_by_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup_by_elements([NotNull] PlSqlParser.Group_by_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.group_by_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup_by_elements([NotNull] PlSqlParser.Group_by_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollup_cube_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollup_cube_clause([NotNull] PlSqlParser.Rollup_cube_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollup_cube_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollup_cube_clause([NotNull] PlSqlParser.Rollup_cube_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grouping_sets_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrouping_sets_clause([NotNull] PlSqlParser.Grouping_sets_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grouping_sets_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrouping_sets_clause([NotNull] PlSqlParser.Grouping_sets_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grouping_sets_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrouping_sets_elements([NotNull] PlSqlParser.Grouping_sets_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grouping_sets_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrouping_sets_elements([NotNull] PlSqlParser.Grouping_sets_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.having_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHaving_clause([NotNull] PlSqlParser.Having_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.having_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHaving_clause([NotNull] PlSqlParser.Having_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_clause([NotNull] PlSqlParser.Model_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_clause([NotNull] PlSqlParser.Model_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cell_reference_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCell_reference_options([NotNull] PlSqlParser.Cell_reference_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cell_reference_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCell_reference_options([NotNull] PlSqlParser.Cell_reference_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.return_rows_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_rows_clause([NotNull] PlSqlParser.Return_rows_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.return_rows_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_rows_clause([NotNull] PlSqlParser.Return_rows_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_model"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReference_model([NotNull] PlSqlParser.Reference_modelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_model"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReference_model([NotNull] PlSqlParser.Reference_modelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.main_model"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMain_model([NotNull] PlSqlParser.Main_modelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.main_model"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMain_model([NotNull] PlSqlParser.Main_modelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_column_clauses([NotNull] PlSqlParser.Model_column_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_column_clauses([NotNull] PlSqlParser.Model_column_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_partition_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_column_partition_part([NotNull] PlSqlParser.Model_column_partition_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_partition_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_column_partition_part([NotNull] PlSqlParser.Model_column_partition_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_column_list([NotNull] PlSqlParser.Model_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_column_list([NotNull] PlSqlParser.Model_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_column([NotNull] PlSqlParser.Model_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_column([NotNull] PlSqlParser.Model_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_rules_clause([NotNull] PlSqlParser.Model_rules_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_rules_clause([NotNull] PlSqlParser.Model_rules_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_rules_part([NotNull] PlSqlParser.Model_rules_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_rules_part([NotNull] PlSqlParser.Model_rules_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_rules_element([NotNull] PlSqlParser.Model_rules_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_rules_element([NotNull] PlSqlParser.Model_rules_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cell_assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCell_assignment([NotNull] PlSqlParser.Cell_assignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cell_assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCell_assignment([NotNull] PlSqlParser.Cell_assignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_iterate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_iterate_clause([NotNull] PlSqlParser.Model_iterate_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_iterate_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_iterate_clause([NotNull] PlSqlParser.Model_iterate_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.until_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUntil_part([NotNull] PlSqlParser.Until_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.until_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUntil_part([NotNull] PlSqlParser.Until_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_clause([NotNull] PlSqlParser.Order_by_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.order_by_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_clause([NotNull] PlSqlParser.Order_by_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.order_by_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrder_by_elements([NotNull] PlSqlParser.Order_by_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.order_by_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrder_by_elements([NotNull] PlSqlParser.Order_by_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.offset_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOffset_clause([NotNull] PlSqlParser.Offset_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.offset_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOffset_clause([NotNull] PlSqlParser.Offset_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.fetch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFetch_clause([NotNull] PlSqlParser.Fetch_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.fetch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFetch_clause([NotNull] PlSqlParser.Fetch_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_update_clause([NotNull] PlSqlParser.For_update_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_update_clause([NotNull] PlSqlParser.For_update_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_of_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_update_of_part([NotNull] PlSqlParser.For_update_of_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_of_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_update_of_part([NotNull] PlSqlParser.For_update_of_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_update_options([NotNull] PlSqlParser.For_update_optionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_options"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_update_options([NotNull] PlSqlParser.For_update_optionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_statement([NotNull] PlSqlParser.Update_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_statement([NotNull] PlSqlParser.Update_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdate_set_clause([NotNull] PlSqlParser.Update_set_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdate_set_clause([NotNull] PlSqlParser.Update_set_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_based_update_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_based_update_set_clause([NotNull] PlSqlParser.Column_based_update_set_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_based_update_set_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_based_update_set_clause([NotNull] PlSqlParser.Column_based_update_set_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.delete_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelete_statement([NotNull] PlSqlParser.Delete_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.delete_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelete_statement([NotNull] PlSqlParser.Delete_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.insert_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_statement([NotNull] PlSqlParser.Insert_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.insert_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_statement([NotNull] PlSqlParser.Insert_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.single_table_insert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_table_insert([NotNull] PlSqlParser.Single_table_insertContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.single_table_insert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_table_insert([NotNull] PlSqlParser.Single_table_insertContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_table_insert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulti_table_insert([NotNull] PlSqlParser.Multi_table_insertContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_table_insert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulti_table_insert([NotNull] PlSqlParser.Multi_table_insertContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulti_table_element([NotNull] PlSqlParser.Multi_table_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulti_table_element([NotNull] PlSqlParser.Multi_table_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_insert_clause([NotNull] PlSqlParser.Conditional_insert_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_insert_clause([NotNull] PlSqlParser.Conditional_insert_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_insert_when_part([NotNull] PlSqlParser.Conditional_insert_when_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_insert_when_part([NotNull] PlSqlParser.Conditional_insert_when_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_insert_else_part([NotNull] PlSqlParser.Conditional_insert_else_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_insert_else_part([NotNull] PlSqlParser.Conditional_insert_else_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.insert_into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsert_into_clause([NotNull] PlSqlParser.Insert_into_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.insert_into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsert_into_clause([NotNull] PlSqlParser.Insert_into_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValues_clause([NotNull] PlSqlParser.Values_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.values_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValues_clause([NotNull] PlSqlParser.Values_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_statement([NotNull] PlSqlParser.Merge_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_statement([NotNull] PlSqlParser.Merge_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_update_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_update_clause([NotNull] PlSqlParser.Merge_update_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_update_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_update_clause([NotNull] PlSqlParser.Merge_update_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_element([NotNull] PlSqlParser.Merge_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_element([NotNull] PlSqlParser.Merge_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_update_delete_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_update_delete_part([NotNull] PlSqlParser.Merge_update_delete_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_update_delete_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_update_delete_part([NotNull] PlSqlParser.Merge_update_delete_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_insert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMerge_insert_clause([NotNull] PlSqlParser.Merge_insert_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_insert_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMerge_insert_clause([NotNull] PlSqlParser.Merge_insert_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.selected_tableview"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelected_tableview([NotNull] PlSqlParser.Selected_tableviewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.selected_tableview"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelected_tableview([NotNull] PlSqlParser.Selected_tableviewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_table_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLock_table_statement([NotNull] PlSqlParser.Lock_table_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_table_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLock_table_statement([NotNull] PlSqlParser.Lock_table_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.wait_nowait_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWait_nowait_part([NotNull] PlSqlParser.Wait_nowait_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.wait_nowait_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWait_nowait_part([NotNull] PlSqlParser.Wait_nowait_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLock_table_element([NotNull] PlSqlParser.Lock_table_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLock_table_element([NotNull] PlSqlParser.Lock_table_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_mode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLock_mode([NotNull] PlSqlParser.Lock_modeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_mode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLock_mode([NotNull] PlSqlParser.Lock_modeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneral_table_ref([NotNull] PlSqlParser.General_table_refContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_table_ref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneral_table_ref([NotNull] PlSqlParser.General_table_refContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.static_returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatic_returning_clause([NotNull] PlSqlParser.Static_returning_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.static_returning_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatic_returning_clause([NotNull] PlSqlParser.Static_returning_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_logging_clause([NotNull] PlSqlParser.Error_logging_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_logging_clause([NotNull] PlSqlParser.Error_logging_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_into_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_logging_into_part([NotNull] PlSqlParser.Error_logging_into_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_into_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_logging_into_part([NotNull] PlSqlParser.Error_logging_into_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_reject_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterError_logging_reject_part([NotNull] PlSqlParser.Error_logging_reject_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_reject_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitError_logging_reject_part([NotNull] PlSqlParser.Error_logging_reject_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_table_expression_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDml_table_expression_clause([NotNull] PlSqlParser.Dml_table_expression_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_table_expression_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDml_table_expression_clause([NotNull] PlSqlParser.Dml_table_expression_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_collection_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_collection_expression([NotNull] PlSqlParser.Table_collection_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_collection_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_collection_expression([NotNull] PlSqlParser.Table_collection_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_restriction_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery_restriction_clause([NotNull] PlSqlParser.Subquery_restriction_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_restriction_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery_restriction_clause([NotNull] PlSqlParser.Subquery_restriction_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sample_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSample_clause([NotNull] PlSqlParser.Sample_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sample_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSample_clause([NotNull] PlSqlParser.Sample_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seed_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSeed_part([NotNull] PlSqlParser.Seed_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seed_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSeed_part([NotNull] PlSqlParser.Seed_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] PlSqlParser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] PlSqlParser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.json_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJson_condition([NotNull] PlSqlParser.Json_conditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.json_condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJson_condition([NotNull] PlSqlParser.Json_conditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.expressions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressions([NotNull] PlSqlParser.ExpressionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.expressions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressions([NotNull] PlSqlParser.ExpressionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] PlSqlParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] PlSqlParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_expression([NotNull] PlSqlParser.Cursor_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_expression([NotNull] PlSqlParser.Cursor_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logical_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogical_expression([NotNull] PlSqlParser.Logical_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logical_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogical_expression([NotNull] PlSqlParser.Logical_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unary_logical_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_logical_expression([NotNull] PlSqlParser.Unary_logical_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unary_logical_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_logical_expression([NotNull] PlSqlParser.Unary_logical_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logical_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogical_operation([NotNull] PlSqlParser.Logical_operationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logical_operation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogical_operation([NotNull] PlSqlParser.Logical_operationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multiset_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiset_expression([NotNull] PlSqlParser.Multiset_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multiset_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiset_expression([NotNull] PlSqlParser.Multiset_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_expression([NotNull] PlSqlParser.Relational_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_expression([NotNull] PlSqlParser.Relational_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_expression([NotNull] PlSqlParser.Compound_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_expression([NotNull] PlSqlParser.Compound_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_operator([NotNull] PlSqlParser.Relational_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_operator([NotNull] PlSqlParser.Relational_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.in_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIn_elements([NotNull] PlSqlParser.In_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.in_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIn_elements([NotNull] PlSqlParser.In_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.between_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBetween_elements([NotNull] PlSqlParser.Between_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.between_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBetween_elements([NotNull] PlSqlParser.Between_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.concatenation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConcatenation([NotNull] PlSqlParser.ConcatenationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.concatenation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConcatenation([NotNull] PlSqlParser.ConcatenationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.interval_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterval_expression([NotNull] PlSqlParser.Interval_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.interval_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterval_expression([NotNull] PlSqlParser.Interval_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_expression([NotNull] PlSqlParser.Model_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_expression([NotNull] PlSqlParser.Model_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_expression_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterModel_expression_element([NotNull] PlSqlParser.Model_expression_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_expression_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitModel_expression_element([NotNull] PlSqlParser.Model_expression_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.single_column_for_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_column_for_loop([NotNull] PlSqlParser.Single_column_for_loopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.single_column_for_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_column_for_loop([NotNull] PlSqlParser.Single_column_for_loopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_column_for_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMulti_column_for_loop([NotNull] PlSqlParser.Multi_column_for_loopContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_column_for_loop"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMulti_column_for_loop([NotNull] PlSqlParser.Multi_column_for_loopContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_expression([NotNull] PlSqlParser.Unary_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_expression([NotNull] PlSqlParser.Unary_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_statement([NotNull] PlSqlParser.Case_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_statement([NotNull] PlSqlParser.Case_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_case_statement([NotNull] PlSqlParser.Simple_case_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_case_statement([NotNull] PlSqlParser.Simple_case_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_case_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_case_when_part([NotNull] PlSqlParser.Simple_case_when_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_case_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_case_when_part([NotNull] PlSqlParser.Simple_case_when_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.searched_case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearched_case_statement([NotNull] PlSqlParser.Searched_case_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.searched_case_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearched_case_statement([NotNull] PlSqlParser.Searched_case_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.searched_case_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSearched_case_when_part([NotNull] PlSqlParser.Searched_case_when_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.searched_case_when_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSearched_case_when_part([NotNull] PlSqlParser.Searched_case_when_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.case_else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_else_part([NotNull] PlSqlParser.Case_else_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.case_else_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_else_part([NotNull] PlSqlParser.Case_else_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] PlSqlParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] PlSqlParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quantified_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuantified_expression([NotNull] PlSqlParser.Quantified_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quantified_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuantified_expression([NotNull] PlSqlParser.Quantified_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.string_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString_function([NotNull] PlSqlParser.String_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.string_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString_function([NotNull] PlSqlParser.String_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standard_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStandard_function([NotNull] PlSqlParser.Standard_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standard_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStandard_function([NotNull] PlSqlParser.Standard_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] PlSqlParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] PlSqlParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function_wrapper"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric_function_wrapper([NotNull] PlSqlParser.Numeric_function_wrapperContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function_wrapper"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric_function_wrapper([NotNull] PlSqlParser.Numeric_function_wrapperContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric_function([NotNull] PlSqlParser.Numeric_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric_function([NotNull] PlSqlParser.Numeric_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.listagg_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterListagg_overflow_clause([NotNull] PlSqlParser.Listagg_overflow_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.listagg_overflow_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitListagg_overflow_clause([NotNull] PlSqlParser.Listagg_overflow_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.other_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOther_function([NotNull] PlSqlParser.Other_functionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.other_function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOther_function([NotNull] PlSqlParser.Other_functionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.over_clause_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause_keyword([NotNull] PlSqlParser.Over_clause_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.over_clause_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause_keyword([NotNull] PlSqlParser.Over_clause_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.within_or_over_clause_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithin_or_over_clause_keyword([NotNull] PlSqlParser.Within_or_over_clause_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.within_or_over_clause_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithin_or_over_clause_keyword([NotNull] PlSqlParser.Within_or_over_clause_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standard_prediction_function_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStandard_prediction_function_keyword([NotNull] PlSqlParser.Standard_prediction_function_keywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standard_prediction_function_keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStandard_prediction_function_keyword([NotNull] PlSqlParser.Standard_prediction_function_keywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOver_clause([NotNull] PlSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.over_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOver_clause([NotNull] PlSqlParser.Over_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowing_clause([NotNull] PlSqlParser.Windowing_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowing_clause([NotNull] PlSqlParser.Windowing_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowing_type([NotNull] PlSqlParser.Windowing_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowing_type([NotNull] PlSqlParser.Windowing_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowing_elements([NotNull] PlSqlParser.Windowing_elementsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_elements"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowing_elements([NotNull] PlSqlParser.Windowing_elementsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_clause([NotNull] PlSqlParser.Using_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_clause([NotNull] PlSqlParser.Using_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_element([NotNull] PlSqlParser.Using_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_element([NotNull] PlSqlParser.Using_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collect_order_by_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollect_order_by_part([NotNull] PlSqlParser.Collect_order_by_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collect_order_by_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollect_order_by_part([NotNull] PlSqlParser.Collect_order_by_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.within_or_over_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithin_or_over_part([NotNull] PlSqlParser.Within_or_over_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.within_or_over_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithin_or_over_part([NotNull] PlSqlParser.Within_or_over_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cost_matrix_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCost_matrix_clause([NotNull] PlSqlParser.Cost_matrix_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cost_matrix_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCost_matrix_clause([NotNull] PlSqlParser.Cost_matrix_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_passing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_passing_clause([NotNull] PlSqlParser.Xml_passing_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_passing_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_passing_clause([NotNull] PlSqlParser.Xml_passing_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_attributes_clause([NotNull] PlSqlParser.Xml_attributes_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_attributes_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_attributes_clause([NotNull] PlSqlParser.Xml_attributes_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_namespaces_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_namespaces_clause([NotNull] PlSqlParser.Xml_namespaces_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_namespaces_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_namespaces_clause([NotNull] PlSqlParser.Xml_namespaces_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_table_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_table_column([NotNull] PlSqlParser.Xml_table_columnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_table_column"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_table_column([NotNull] PlSqlParser.Xml_table_columnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_general_default_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_general_default_part([NotNull] PlSqlParser.Xml_general_default_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_general_default_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_general_default_part([NotNull] PlSqlParser.Xml_general_default_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_multiuse_expression_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_multiuse_expression_element([NotNull] PlSqlParser.Xml_multiuse_expression_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_multiuse_expression_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_multiuse_expression_element([NotNull] PlSqlParser.Xml_multiuse_expression_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlroot_param_version_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlroot_param_version_part([NotNull] PlSqlParser.Xmlroot_param_version_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlroot_param_version_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlroot_param_version_part([NotNull] PlSqlParser.Xmlroot_param_version_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlroot_param_standalone_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlroot_param_standalone_part([NotNull] PlSqlParser.Xmlroot_param_standalone_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlroot_param_standalone_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlroot_param_standalone_part([NotNull] PlSqlParser.Xmlroot_param_standalone_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_enconding_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlserialize_param_enconding_part([NotNull] PlSqlParser.Xmlserialize_param_enconding_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_enconding_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlserialize_param_enconding_part([NotNull] PlSqlParser.Xmlserialize_param_enconding_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_version_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlserialize_param_version_part([NotNull] PlSqlParser.Xmlserialize_param_version_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_version_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlserialize_param_version_part([NotNull] PlSqlParser.Xmlserialize_param_version_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_ident_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlserialize_param_ident_part([NotNull] PlSqlParser.Xmlserialize_param_ident_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_ident_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlserialize_param_ident_part([NotNull] PlSqlParser.Xmlserialize_param_ident_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_plus_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSql_plus_command([NotNull] PlSqlParser.Sql_plus_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_plus_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSql_plus_command([NotNull] PlSqlParser.Sql_plus_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.whenever_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhenever_command([NotNull] PlSqlParser.Whenever_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.whenever_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhenever_command([NotNull] PlSqlParser.Whenever_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_command([NotNull] PlSqlParser.Set_commandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_command([NotNull] PlSqlParser.Set_commandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extension_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartition_extension_clause([NotNull] PlSqlParser.Partition_extension_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extension_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartition_extension_clause([NotNull] PlSqlParser.Partition_extension_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_alias([NotNull] PlSqlParser.Column_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_alias([NotNull] PlSqlParser.Column_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_alias([NotNull] PlSqlParser.Table_aliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_alias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_alias([NotNull] PlSqlParser.Table_aliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhere_clause([NotNull] PlSqlParser.Where_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhere_clause([NotNull] PlSqlParser.Where_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInto_clause([NotNull] PlSqlParser.Into_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.into_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInto_clause([NotNull] PlSqlParser.Into_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXml_column_name([NotNull] PlSqlParser.Xml_column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXml_column_name([NotNull] PlSqlParser.Xml_column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cost_class_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCost_class_name([NotNull] PlSqlParser.Cost_class_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cost_class_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCost_class_name([NotNull] PlSqlParser.Cost_class_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.attribute_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_name([NotNull] PlSqlParser.Attribute_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.attribute_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_name([NotNull] PlSqlParser.Attribute_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepoint_name([NotNull] PlSqlParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.savepoint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepoint_name([NotNull] PlSqlParser.Savepoint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_segment_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRollback_segment_name([NotNull] PlSqlParser.Rollback_segment_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_segment_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRollback_segment_name([NotNull] PlSqlParser.Rollback_segment_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_var_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_var_name([NotNull] PlSqlParser.Table_var_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_var_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_var_name([NotNull] PlSqlParser.Table_var_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_name([NotNull] PlSqlParser.Schema_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.schema_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_name([NotNull] PlSqlParser.Schema_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.routine_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutine_name([NotNull] PlSqlParser.Routine_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.routine_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutine_name([NotNull] PlSqlParser.Routine_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPackage_name([NotNull] PlSqlParser.Package_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPackage_name([NotNull] PlSqlParser.Package_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.implementation_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImplementation_type_name([NotNull] PlSqlParser.Implementation_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.implementation_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImplementation_type_name([NotNull] PlSqlParser.Implementation_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_name([NotNull] PlSqlParser.Parameter_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_name([NotNull] PlSqlParser.Parameter_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReference_model_name([NotNull] PlSqlParser.Reference_model_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReference_model_name([NotNull] PlSqlParser.Reference_model_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.main_model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMain_model_name([NotNull] PlSqlParser.Main_model_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.main_model_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMain_model_name([NotNull] PlSqlParser.Main_model_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_tableview_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContainer_tableview_name([NotNull] PlSqlParser.Container_tableview_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_tableview_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContainer_tableview_name([NotNull] PlSqlParser.Container_tableview_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.aggregate_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAggregate_function_name([NotNull] PlSqlParser.Aggregate_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.aggregate_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAggregate_function_name([NotNull] PlSqlParser.Aggregate_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_name([NotNull] PlSqlParser.Query_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_name([NotNull] PlSqlParser.Query_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grantee_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantee_name([NotNull] PlSqlParser.Grantee_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grantee_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantee_name([NotNull] PlSqlParser.Grantee_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.role_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRole_name([NotNull] PlSqlParser.Role_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.role_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRole_name([NotNull] PlSqlParser.Role_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraint_name([NotNull] PlSqlParser.Constraint_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraint_name([NotNull] PlSqlParser.Constraint_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.label_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel_name([NotNull] PlSqlParser.Label_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.label_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel_name([NotNull] PlSqlParser.Label_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_name([NotNull] PlSqlParser.Type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_name([NotNull] PlSqlParser.Type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSequence_name([NotNull] PlSqlParser.Sequence_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSequence_name([NotNull] PlSqlParser.Sequence_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_name([NotNull] PlSqlParser.Exception_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_name([NotNull] PlSqlParser.Exception_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_name([NotNull] PlSqlParser.Function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_name([NotNull] PlSqlParser.Function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedure_name([NotNull] PlSqlParser.Procedure_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedure_name([NotNull] PlSqlParser.Procedure_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrigger_name([NotNull] PlSqlParser.Trigger_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrigger_name([NotNull] PlSqlParser.Trigger_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.variable_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_name([NotNull] PlSqlParser.Variable_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.variable_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_name([NotNull] PlSqlParser.Variable_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndex_name([NotNull] PlSqlParser.Index_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndex_name([NotNull] PlSqlParser.Index_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursor_name([NotNull] PlSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursor_name([NotNull] PlSqlParser.Cursor_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.record_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRecord_name([NotNull] PlSqlParser.Record_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.record_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRecord_name([NotNull] PlSqlParser.Record_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collection_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollection_name([NotNull] PlSqlParser.Collection_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collection_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollection_name([NotNull] PlSqlParser.Collection_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.link_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLink_name([NotNull] PlSqlParser.Link_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.link_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLink_name([NotNull] PlSqlParser.Link_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_name([NotNull] PlSqlParser.Column_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_name([NotNull] PlSqlParser.Column_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tableview_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableview_name([NotNull] PlSqlParser.Tableview_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tableview_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableview_name([NotNull] PlSqlParser.Tableview_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmltable([NotNull] PlSqlParser.XmltableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmltable([NotNull] PlSqlParser.XmltableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.char_set_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChar_set_name([NotNull] PlSqlParser.Char_set_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.char_set_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChar_set_name([NotNull] PlSqlParser.Char_set_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.synonym_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSynonym_name([NotNull] PlSqlParser.Synonym_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.synonym_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSynonym_name([NotNull] PlSqlParser.Synonym_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.schema_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchema_object_name([NotNull] PlSqlParser.Schema_object_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.schema_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchema_object_name([NotNull] PlSqlParser.Schema_object_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dir_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDir_object_name([NotNull] PlSqlParser.Dir_object_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dir_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDir_object_name([NotNull] PlSqlParser.Dir_object_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser_object_name([NotNull] PlSqlParser.User_object_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser_object_name([NotNull] PlSqlParser.User_object_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grant_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrant_object_name([NotNull] PlSqlParser.Grant_object_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grant_object_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrant_object_name([NotNull] PlSqlParser.Grant_object_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumn_list([NotNull] PlSqlParser.Column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumn_list([NotNull] PlSqlParser.Column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.paren_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParen_column_list([NotNull] PlSqlParser.Paren_column_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.paren_column_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParen_column_list([NotNull] PlSqlParser.Paren_column_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.keep_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeep_clause([NotNull] PlSqlParser.Keep_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.keep_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeep_clause([NotNull] PlSqlParser.Keep_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_argument([NotNull] PlSqlParser.Function_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_argument([NotNull] PlSqlParser.Function_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument_analytic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_argument_analytic([NotNull] PlSqlParser.Function_argument_analyticContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument_analytic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_argument_analytic([NotNull] PlSqlParser.Function_argument_analyticContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument_modeling"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction_argument_modeling([NotNull] PlSqlParser.Function_argument_modelingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument_modeling"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction_argument_modeling([NotNull] PlSqlParser.Function_argument_modelingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.respect_or_ignore_nulls"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRespect_or_ignore_nulls([NotNull] PlSqlParser.Respect_or_ignore_nullsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.respect_or_ignore_nulls"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRespect_or_ignore_nulls([NotNull] PlSqlParser.Respect_or_ignore_nullsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument([NotNull] PlSqlParser.ArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument([NotNull] PlSqlParser.ArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_spec([NotNull] PlSqlParser.Type_specContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_spec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_spec([NotNull] PlSqlParser.Type_specContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datatype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatatype([NotNull] PlSqlParser.DatatypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datatype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatatype([NotNull] PlSqlParser.DatatypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.precision_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrecision_part([NotNull] PlSqlParser.Precision_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.precision_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrecision_part([NotNull] PlSqlParser.Precision_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.native_datatype_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNative_datatype_element([NotNull] PlSqlParser.Native_datatype_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.native_datatype_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNative_datatype_element([NotNull] PlSqlParser.Native_datatype_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bind_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBind_variable([NotNull] PlSqlParser.Bind_variableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bind_variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBind_variable([NotNull] PlSqlParser.Bind_variableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneral_element([NotNull] PlSqlParser.General_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneral_element([NotNull] PlSqlParser.General_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_element_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneral_element_part([NotNull] PlSqlParser.General_element_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_element_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneral_element_part([NotNull] PlSqlParser.General_element_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTable_element([NotNull] PlSqlParser.Table_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTable_element([NotNull] PlSqlParser.Table_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_privilege([NotNull] PlSqlParser.Object_privilegeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_privilege([NotNull] PlSqlParser.Object_privilegeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.system_privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSystem_privilege([NotNull] PlSqlParser.System_privilegeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.system_privilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSystem_privilege([NotNull] PlSqlParser.System_privilegeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant([NotNull] PlSqlParser.ConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant([NotNull] PlSqlParser.ConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric([NotNull] PlSqlParser.NumericContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric([NotNull] PlSqlParser.NumericContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_negative"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric_negative([NotNull] PlSqlParser.Numeric_negativeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_negative"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric_negative([NotNull] PlSqlParser.Numeric_negativeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quoted_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuoted_string([NotNull] PlSqlParser.Quoted_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quoted_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuoted_string([NotNull] PlSqlParser.Quoted_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] PlSqlParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] PlSqlParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.id_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterId_expression([NotNull] PlSqlParser.Id_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.id_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitId_expression([NotNull] PlSqlParser.Id_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.outer_join_sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOuter_join_sign([NotNull] PlSqlParser.Outer_join_signContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.outer_join_sign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOuter_join_sign([NotNull] PlSqlParser.Outer_join_signContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.regular_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRegular_id([NotNull] PlSqlParser.Regular_idContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.regular_id"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRegular_id([NotNull] PlSqlParser.Regular_idContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_in_12c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNon_reserved_keywords_in_12c([NotNull] PlSqlParser.Non_reserved_keywords_in_12cContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_in_12c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNon_reserved_keywords_in_12c([NotNull] PlSqlParser.Non_reserved_keywords_in_12cContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_pre12c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNon_reserved_keywords_pre12c([NotNull] PlSqlParser.Non_reserved_keywords_pre12cContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_pre12c"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNon_reserved_keywords_pre12c([NotNull] PlSqlParser.Non_reserved_keywords_pre12cContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.string_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString_function_name([NotNull] PlSqlParser.String_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.string_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString_function_name([NotNull] PlSqlParser.String_function_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric_function_name([NotNull] PlSqlParser.Numeric_function_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric_function_name([NotNull] PlSqlParser.Numeric_function_nameContext context) { }

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
