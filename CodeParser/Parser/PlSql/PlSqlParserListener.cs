using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="PlSqlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IPlSqlParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_script([NotNull] PlSqlParser.Sql_scriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_script([NotNull] PlSqlParser.Sql_scriptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnit_statement([NotNull] PlSqlParser.Unit_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnit_statement([NotNull] PlSqlParser.Unit_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_function([NotNull] PlSqlParser.Drop_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_function([NotNull] PlSqlParser.Drop_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_function([NotNull] PlSqlParser.Alter_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_function([NotNull] PlSqlParser.Alter_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_function_body([NotNull] PlSqlParser.Create_function_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_function_body([NotNull] PlSqlParser.Create_function_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parallel_enable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParallel_enable_clause([NotNull] PlSqlParser.Parallel_enable_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parallel_enable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParallel_enable_clause([NotNull] PlSqlParser.Parallel_enable_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_by_clause([NotNull] PlSqlParser.Partition_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_by_clause([NotNull] PlSqlParser.Partition_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.result_cache_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResult_cache_clause([NotNull] PlSqlParser.Result_cache_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.result_cache_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResult_cache_clause([NotNull] PlSqlParser.Result_cache_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relies_on_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelies_on_part([NotNull] PlSqlParser.Relies_on_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relies_on_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelies_on_part([NotNull] PlSqlParser.Relies_on_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.streaming_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStreaming_clause([NotNull] PlSqlParser.Streaming_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.streaming_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStreaming_clause([NotNull] PlSqlParser.Streaming_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_package([NotNull] PlSqlParser.Drop_packageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_package([NotNull] PlSqlParser.Drop_packageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_package([NotNull] PlSqlParser.Alter_packageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_package([NotNull] PlSqlParser.Alter_packageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_package([NotNull] PlSqlParser.Create_packageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_package([NotNull] PlSqlParser.Create_packageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_package_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_package_body([NotNull] PlSqlParser.Create_package_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_package_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_package_body([NotNull] PlSqlParser.Create_package_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_obj_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackage_obj_spec([NotNull] PlSqlParser.Package_obj_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_obj_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackage_obj_spec([NotNull] PlSqlParser.Package_obj_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_spec([NotNull] PlSqlParser.Procedure_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_spec([NotNull] PlSqlParser.Procedure_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_spec([NotNull] PlSqlParser.Function_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_spec([NotNull] PlSqlParser.Function_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_obj_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackage_obj_body([NotNull] PlSqlParser.Package_obj_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_obj_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackage_obj_body([NotNull] PlSqlParser.Package_obj_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_procedure([NotNull] PlSqlParser.Drop_procedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_procedure([NotNull] PlSqlParser.Drop_procedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_procedure([NotNull] PlSqlParser.Alter_procedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_procedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_procedure([NotNull] PlSqlParser.Alter_procedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_body([NotNull] PlSqlParser.Function_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_body([NotNull] PlSqlParser.Function_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_body([NotNull] PlSqlParser.Procedure_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_body([NotNull] PlSqlParser.Procedure_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_procedure_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_procedure_body([NotNull] PlSqlParser.Create_procedure_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_procedure_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_procedure_body([NotNull] PlSqlParser.Create_procedure_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_trigger([NotNull] PlSqlParser.Drop_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_trigger([NotNull] PlSqlParser.Drop_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_trigger([NotNull] PlSqlParser.Alter_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_trigger([NotNull] PlSqlParser.Alter_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_trigger([NotNull] PlSqlParser.Create_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_trigger([NotNull] PlSqlParser.Create_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_follows_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_follows_clause([NotNull] PlSqlParser.Trigger_follows_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_follows_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_follows_clause([NotNull] PlSqlParser.Trigger_follows_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_when_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_when_clause([NotNull] PlSqlParser.Trigger_when_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_when_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_when_clause([NotNull] PlSqlParser.Trigger_when_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_dml_trigger([NotNull] PlSqlParser.Simple_dml_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_dml_trigger([NotNull] PlSqlParser.Simple_dml_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_each_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_each_row([NotNull] PlSqlParser.For_each_rowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_each_row"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_each_row([NotNull] PlSqlParser.For_each_rowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_dml_trigger([NotNull] PlSqlParser.Compound_dml_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_dml_trigger([NotNull] PlSqlParser.Compound_dml_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_dml_trigger([NotNull] PlSqlParser.Non_dml_triggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_dml_trigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_dml_trigger([NotNull] PlSqlParser.Non_dml_triggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_body([NotNull] PlSqlParser.Trigger_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_body([NotNull] PlSqlParser.Trigger_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.routine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoutine_clause([NotNull] PlSqlParser.Routine_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.routine_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoutine_clause([NotNull] PlSqlParser.Routine_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_trigger_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_trigger_block([NotNull] PlSqlParser.Compound_trigger_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_trigger_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_trigger_block([NotNull] PlSqlParser.Compound_trigger_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.timing_point_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTiming_point_section([NotNull] PlSqlParser.Timing_point_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.timing_point_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTiming_point_section([NotNull] PlSqlParser.Timing_point_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_dml_event"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_dml_event([NotNull] PlSqlParser.Non_dml_eventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_dml_event"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_dml_event([NotNull] PlSqlParser.Non_dml_eventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_event_clause([NotNull] PlSqlParser.Dml_event_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_event_clause([NotNull] PlSqlParser.Dml_event_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_event_element([NotNull] PlSqlParser.Dml_event_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_event_element([NotNull] PlSqlParser.Dml_event_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_event_nested_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_event_nested_clause([NotNull] PlSqlParser.Dml_event_nested_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_event_nested_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_event_nested_clause([NotNull] PlSqlParser.Dml_event_nested_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.referencing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferencing_clause([NotNull] PlSqlParser.Referencing_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.referencing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferencing_clause([NotNull] PlSqlParser.Referencing_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.referencing_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferencing_element([NotNull] PlSqlParser.Referencing_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.referencing_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferencing_element([NotNull] PlSqlParser.Referencing_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_type([NotNull] PlSqlParser.Drop_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_type([NotNull] PlSqlParser.Drop_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_type([NotNull] PlSqlParser.Alter_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_type([NotNull] PlSqlParser.Alter_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compile_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompile_type_clause([NotNull] PlSqlParser.Compile_type_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compile_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompile_type_clause([NotNull] PlSqlParser.Compile_type_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.replace_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplace_type_clause([NotNull] PlSqlParser.Replace_type_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.replace_type_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplace_type_clause([NotNull] PlSqlParser.Replace_type_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_method_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_method_spec([NotNull] PlSqlParser.Alter_method_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_method_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_method_spec([NotNull] PlSqlParser.Alter_method_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_method_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_method_element([NotNull] PlSqlParser.Alter_method_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_method_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_method_element([NotNull] PlSqlParser.Alter_method_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_attribute_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_attribute_definition([NotNull] PlSqlParser.Alter_attribute_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_attribute_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_attribute_definition([NotNull] PlSqlParser.Alter_attribute_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.attribute_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_definition([NotNull] PlSqlParser.Attribute_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.attribute_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_definition([NotNull] PlSqlParser.Attribute_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_collection_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_collection_clauses([NotNull] PlSqlParser.Alter_collection_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_collection_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_collection_clauses([NotNull] PlSqlParser.Alter_collection_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dependent_handling_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDependent_handling_clause([NotNull] PlSqlParser.Dependent_handling_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dependent_handling_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDependent_handling_clause([NotNull] PlSqlParser.Dependent_handling_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dependent_exceptions_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDependent_exceptions_part([NotNull] PlSqlParser.Dependent_exceptions_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dependent_exceptions_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDependent_exceptions_part([NotNull] PlSqlParser.Dependent_exceptions_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_type([NotNull] PlSqlParser.Create_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_type([NotNull] PlSqlParser.Create_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_definition([NotNull] PlSqlParser.Type_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_definition([NotNull] PlSqlParser.Type_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_type_def([NotNull] PlSqlParser.Object_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_type_def([NotNull] PlSqlParser.Object_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_as_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_as_part([NotNull] PlSqlParser.Object_as_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_as_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_as_part([NotNull] PlSqlParser.Object_as_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_under_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_under_part([NotNull] PlSqlParser.Object_under_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_under_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_under_part([NotNull] PlSqlParser.Object_under_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_table_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNested_table_type_def([NotNull] PlSqlParser.Nested_table_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_table_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNested_table_type_def([NotNull] PlSqlParser.Nested_table_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sqlj_object_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqlj_object_type([NotNull] PlSqlParser.Sqlj_object_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sqlj_object_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqlj_object_type([NotNull] PlSqlParser.Sqlj_object_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_body([NotNull] PlSqlParser.Type_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_body([NotNull] PlSqlParser.Type_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_body_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_body_elements([NotNull] PlSqlParser.Type_body_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_body_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_body_elements([NotNull] PlSqlParser.Type_body_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.map_order_func_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap_order_func_declaration([NotNull] PlSqlParser.Map_order_func_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.map_order_func_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap_order_func_declaration([NotNull] PlSqlParser.Map_order_func_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subprog_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubprog_decl_in_type([NotNull] PlSqlParser.Subprog_decl_in_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subprog_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubprog_decl_in_type([NotNull] PlSqlParser.Subprog_decl_in_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.proc_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProc_decl_in_type([NotNull] PlSqlParser.Proc_decl_in_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.proc_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProc_decl_in_type([NotNull] PlSqlParser.Proc_decl_in_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.func_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc_decl_in_type([NotNull] PlSqlParser.Func_decl_in_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.func_decl_in_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc_decl_in_type([NotNull] PlSqlParser.Func_decl_in_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constructor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor_declaration([NotNull] PlSqlParser.Constructor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constructor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor_declaration([NotNull] PlSqlParser.Constructor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modifier_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModifier_clause([NotNull] PlSqlParser.Modifier_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modifier_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModifier_clause([NotNull] PlSqlParser.Modifier_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_member_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_member_spec([NotNull] PlSqlParser.Object_member_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_member_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_member_spec([NotNull] PlSqlParser.Object_member_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sqlj_object_type_attr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqlj_object_type_attr([NotNull] PlSqlParser.Sqlj_object_type_attrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sqlj_object_type_attr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqlj_object_type_attr([NotNull] PlSqlParser.Sqlj_object_type_attrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.element_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement_spec([NotNull] PlSqlParser.Element_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.element_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement_spec([NotNull] PlSqlParser.Element_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.element_spec_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement_spec_options([NotNull] PlSqlParser.Element_spec_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.element_spec_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement_spec_options([NotNull] PlSqlParser.Element_spec_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subprogram_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubprogram_spec([NotNull] PlSqlParser.Subprogram_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subprogram_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubprogram_spec([NotNull] PlSqlParser.Subprogram_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.overriding_subprogram_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverriding_subprogram_spec([NotNull] PlSqlParser.Overriding_subprogram_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.overriding_subprogram_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverriding_subprogram_spec([NotNull] PlSqlParser.Overriding_subprogram_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.overriding_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverriding_function_spec([NotNull] PlSqlParser.Overriding_function_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.overriding_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverriding_function_spec([NotNull] PlSqlParser.Overriding_function_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_procedure_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_procedure_spec([NotNull] PlSqlParser.Type_procedure_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_procedure_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_procedure_spec([NotNull] PlSqlParser.Type_procedure_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_function_spec([NotNull] PlSqlParser.Type_function_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_function_spec([NotNull] PlSqlParser.Type_function_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constructor_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor_spec([NotNull] PlSqlParser.Constructor_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constructor_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor_spec([NotNull] PlSqlParser.Constructor_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.map_order_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap_order_function_spec([NotNull] PlSqlParser.Map_order_function_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.map_order_function_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap_order_function_spec([NotNull] PlSqlParser.Map_order_function_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_clause([NotNull] PlSqlParser.Pragma_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_clause([NotNull] PlSqlParser.Pragma_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_elements([NotNull] PlSqlParser.Pragma_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_elements([NotNull] PlSqlParser.Pragma_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_elements_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_elements_parameter([NotNull] PlSqlParser.Type_elements_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_elements_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_elements_parameter([NotNull] PlSqlParser.Type_elements_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_sequence([NotNull] PlSqlParser.Drop_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_sequence([NotNull] PlSqlParser.Drop_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_sequence([NotNull] PlSqlParser.Alter_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_sequence([NotNull] PlSqlParser.Alter_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_session([NotNull] PlSqlParser.Alter_sessionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_session"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_session([NotNull] PlSqlParser.Alter_sessionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_session_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_session_set_clause([NotNull] PlSqlParser.Alter_session_set_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_session_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_session_set_clause([NotNull] PlSqlParser.Alter_session_set_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_sequence([NotNull] PlSqlParser.Create_sequenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_sequence"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_sequence([NotNull] PlSqlParser.Create_sequenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSequence_spec([NotNull] PlSqlParser.Sequence_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSequence_spec([NotNull] PlSqlParser.Sequence_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_start_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSequence_start_clause([NotNull] PlSqlParser.Sequence_start_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_start_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSequence_start_clause([NotNull] PlSqlParser.Sequence_start_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_index([NotNull] PlSqlParser.Create_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_index([NotNull] PlSqlParser.Create_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cluster_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCluster_index_clause([NotNull] PlSqlParser.Cluster_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cluster_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCluster_index_clause([NotNull] PlSqlParser.Cluster_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cluster_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCluster_name([NotNull] PlSqlParser.Cluster_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cluster_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCluster_name([NotNull] PlSqlParser.Cluster_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_index_clause([NotNull] PlSqlParser.Table_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_index_clause([NotNull] PlSqlParser.Table_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bitmap_join_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitmap_join_index_clause([NotNull] PlSqlParser.Bitmap_join_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bitmap_join_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitmap_join_index_clause([NotNull] PlSqlParser.Bitmap_join_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_expr([NotNull] PlSqlParser.Index_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_expr([NotNull] PlSqlParser.Index_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_properties([NotNull] PlSqlParser.Index_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_properties([NotNull] PlSqlParser.Index_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.domain_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDomain_index_clause([NotNull] PlSqlParser.Domain_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.domain_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDomain_index_clause([NotNull] PlSqlParser.Domain_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_domain_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_domain_index_clause([NotNull] PlSqlParser.Local_domain_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_domain_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_domain_index_clause([NotNull] PlSqlParser.Local_domain_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlindex_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlindex_clause([NotNull] PlSqlParser.Xmlindex_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlindex_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlindex_clause([NotNull] PlSqlParser.Xmlindex_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_xmlindex_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_xmlindex_clause([NotNull] PlSqlParser.Local_xmlindex_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_xmlindex_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_xmlindex_clause([NotNull] PlSqlParser.Local_xmlindex_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.global_partitioned_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_partitioned_index([NotNull] PlSqlParser.Global_partitioned_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.global_partitioned_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_partitioned_index([NotNull] PlSqlParser.Global_partitioned_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_partitioning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_partitioning_clause([NotNull] PlSqlParser.Index_partitioning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_partitioning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_partitioning_clause([NotNull] PlSqlParser.Index_partitioning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.local_partitioned_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_partitioned_index([NotNull] PlSqlParser.Local_partitioned_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.local_partitioned_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_partitioned_index([NotNull] PlSqlParser.Local_partitioned_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_range_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_range_partitioned_table([NotNull] PlSqlParser.On_range_partitioned_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_range_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_range_partitioned_table([NotNull] PlSqlParser.On_range_partitioned_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_list_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_list_partitioned_table([NotNull] PlSqlParser.On_list_partitioned_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_list_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_list_partitioned_table([NotNull] PlSqlParser.On_list_partitioned_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitioned_table([NotNull] PlSqlParser.Partitioned_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitioned_table([NotNull] PlSqlParser.Partitioned_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_hash_partitioned_table([NotNull] PlSqlParser.On_hash_partitioned_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_hash_partitioned_table([NotNull] PlSqlParser.On_hash_partitioned_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_hash_partitioned_clause([NotNull] PlSqlParser.On_hash_partitioned_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_hash_partitioned_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_hash_partitioned_clause([NotNull] PlSqlParser.On_hash_partitioned_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_comp_partitioned_table([NotNull] PlSqlParser.On_comp_partitioned_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_comp_partitioned_table([NotNull] PlSqlParser.On_comp_partitioned_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_comp_partitioned_clause([NotNull] PlSqlParser.On_comp_partitioned_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_comp_partitioned_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_comp_partitioned_clause([NotNull] PlSqlParser.On_comp_partitioned_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_subpartition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_subpartition_clause([NotNull] PlSqlParser.Index_subpartition_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_subpartition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_subpartition_clause([NotNull] PlSqlParser.Index_subpartition_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_subpartition_subclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_subpartition_subclause([NotNull] PlSqlParser.Index_subpartition_subclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_subpartition_subclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_subpartition_subclause([NotNull] PlSqlParser.Index_subpartition_subclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.odci_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOdci_parameters([NotNull] PlSqlParser.Odci_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.odci_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOdci_parameters([NotNull] PlSqlParser.Odci_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.indextype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndextype([NotNull] PlSqlParser.IndextypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.indextype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndextype([NotNull] PlSqlParser.IndextypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_index([NotNull] PlSqlParser.Alter_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_index([NotNull] PlSqlParser.Alter_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_index_ops_set1([NotNull] PlSqlParser.Alter_index_ops_set1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_index_ops_set1([NotNull] PlSqlParser.Alter_index_ops_set1Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_index_ops_set2([NotNull] PlSqlParser.Alter_index_ops_set2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_ops_set2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_index_ops_set2([NotNull] PlSqlParser.Alter_index_ops_set2Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.visible_or_invisible"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVisible_or_invisible([NotNull] PlSqlParser.Visible_or_invisibleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.visible_or_invisible"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVisible_or_invisible([NotNull] PlSqlParser.Visible_or_invisibleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.monitoring_nomonitoring"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMonitoring_nomonitoring([NotNull] PlSqlParser.Monitoring_nomonitoringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.monitoring_nomonitoring"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMonitoring_nomonitoring([NotNull] PlSqlParser.Monitoring_nomonitoringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rebuild_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRebuild_clause([NotNull] PlSqlParser.Rebuild_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rebuild_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRebuild_clause([NotNull] PlSqlParser.Rebuild_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_index_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_index_partitioning([NotNull] PlSqlParser.Alter_index_partitioningContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_index_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_index_partitioning([NotNull] PlSqlParser.Alter_index_partitioningContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_default_attrs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_index_default_attrs([NotNull] PlSqlParser.Modify_index_default_attrsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_default_attrs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_index_default_attrs([NotNull] PlSqlParser.Modify_index_default_attrsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_hash_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_hash_index_partition([NotNull] PlSqlParser.Add_hash_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_hash_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_hash_index_partition([NotNull] PlSqlParser.Add_hash_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.coalesce_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCoalesce_index_partition([NotNull] PlSqlParser.Coalesce_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.coalesce_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCoalesce_index_partition([NotNull] PlSqlParser.Coalesce_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_index_partition([NotNull] PlSqlParser.Modify_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_index_partition([NotNull] PlSqlParser.Modify_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_partitions_ops"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_index_partitions_ops([NotNull] PlSqlParser.Modify_index_partitions_opsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_partitions_ops"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_index_partitions_ops([NotNull] PlSqlParser.Modify_index_partitions_opsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRename_index_partition([NotNull] PlSqlParser.Rename_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRename_index_partition([NotNull] PlSqlParser.Rename_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_index_partition([NotNull] PlSqlParser.Drop_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_index_partition([NotNull] PlSqlParser.Drop_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.split_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSplit_index_partition([NotNull] PlSqlParser.Split_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.split_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSplit_index_partition([NotNull] PlSqlParser.Split_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_partition_description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_partition_description([NotNull] PlSqlParser.Index_partition_descriptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_partition_description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_partition_description([NotNull] PlSqlParser.Index_partition_descriptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_index_subpartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_index_subpartition([NotNull] PlSqlParser.Modify_index_subpartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_index_subpartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_index_subpartition([NotNull] PlSqlParser.Modify_index_subpartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_name_old"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_name_old([NotNull] PlSqlParser.Partition_name_oldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_name_old"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_name_old([NotNull] PlSqlParser.Partition_name_oldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_partition_name([NotNull] PlSqlParser.New_partition_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_partition_name([NotNull] PlSqlParser.New_partition_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_index_name([NotNull] PlSqlParser.New_index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_index_name([NotNull] PlSqlParser.New_index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_user([NotNull] PlSqlParser.Create_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_user([NotNull] PlSqlParser.Create_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_user([NotNull] PlSqlParser.Alter_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_user([NotNull] PlSqlParser.Alter_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_identified_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_identified_by([NotNull] PlSqlParser.Alter_identified_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_identified_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_identified_by([NotNull] PlSqlParser.Alter_identified_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identified_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentified_by([NotNull] PlSqlParser.Identified_byContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identified_by"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentified_by([NotNull] PlSqlParser.Identified_byContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identified_other_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentified_other_clause([NotNull] PlSqlParser.Identified_other_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identified_other_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentified_other_clause([NotNull] PlSqlParser.Identified_other_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser_tablespace_clause([NotNull] PlSqlParser.User_tablespace_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser_tablespace_clause([NotNull] PlSqlParser.User_tablespace_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quota_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuota_clause([NotNull] PlSqlParser.Quota_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quota_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuota_clause([NotNull] PlSqlParser.Quota_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.profile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProfile_clause([NotNull] PlSqlParser.Profile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.profile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProfile_clause([NotNull] PlSqlParser.Profile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.role_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRole_clause([NotNull] PlSqlParser.Role_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.role_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRole_clause([NotNull] PlSqlParser.Role_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_default_role_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser_default_role_clause([NotNull] PlSqlParser.User_default_role_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_default_role_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser_default_role_clause([NotNull] PlSqlParser.User_default_role_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.password_expire_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPassword_expire_clause([NotNull] PlSqlParser.Password_expire_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.password_expire_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPassword_expire_clause([NotNull] PlSqlParser.Password_expire_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_lock_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser_lock_clause([NotNull] PlSqlParser.User_lock_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_lock_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser_lock_clause([NotNull] PlSqlParser.User_lock_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_editions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser_editions_clause([NotNull] PlSqlParser.User_editions_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_editions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser_editions_clause([NotNull] PlSqlParser.User_editions_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_user_editions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_user_editions_clause([NotNull] PlSqlParser.Alter_user_editions_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_user_editions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_user_editions_clause([NotNull] PlSqlParser.Alter_user_editions_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.proxy_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProxy_clause([NotNull] PlSqlParser.Proxy_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.proxy_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProxy_clause([NotNull] PlSqlParser.Proxy_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainer_names([NotNull] PlSqlParser.Container_namesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainer_names([NotNull] PlSqlParser.Container_namesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_container_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_container_data([NotNull] PlSqlParser.Set_container_dataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_container_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_container_data([NotNull] PlSqlParser.Set_container_dataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_rem_container_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_rem_container_data([NotNull] PlSqlParser.Add_rem_container_dataContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_rem_container_data"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_rem_container_data([NotNull] PlSqlParser.Add_rem_container_dataContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_data_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainer_data_clause([NotNull] PlSqlParser.Container_data_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_data_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainer_data_clause([NotNull] PlSqlParser.Container_data_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.analyze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnalyze([NotNull] PlSqlParser.AnalyzeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.analyze"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnalyze([NotNull] PlSqlParser.AnalyzeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_extention_clause([NotNull] PlSqlParser.Partition_extention_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_extention_clause([NotNull] PlSqlParser.Partition_extention_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.validation_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValidation_clauses([NotNull] PlSqlParser.Validation_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.validation_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValidation_clauses([NotNull] PlSqlParser.Validation_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.online_or_offline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnline_or_offline([NotNull] PlSqlParser.Online_or_offlineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.online_or_offline"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnline_or_offline([NotNull] PlSqlParser.Online_or_offlineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.into_clause1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInto_clause1([NotNull] PlSqlParser.Into_clause1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.into_clause1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInto_clause1([NotNull] PlSqlParser.Into_clause1Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_key_value([NotNull] PlSqlParser.Partition_key_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_key_value([NotNull] PlSqlParser.Partition_key_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_key_value([NotNull] PlSqlParser.Subpartition_key_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_key_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_key_value([NotNull] PlSqlParser.Subpartition_key_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.associate_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssociate_statistics([NotNull] PlSqlParser.Associate_statisticsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.associate_statistics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssociate_statistics([NotNull] PlSqlParser.Associate_statisticsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_association"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_association([NotNull] PlSqlParser.Column_associationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_association"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_association([NotNull] PlSqlParser.Column_associationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_association"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_association([NotNull] PlSqlParser.Function_associationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_association"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_association([NotNull] PlSqlParser.Function_associationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.indextype_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndextype_name([NotNull] PlSqlParser.Indextype_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.indextype_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndextype_name([NotNull] PlSqlParser.Indextype_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_statistics_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_statistics_type([NotNull] PlSqlParser.Using_statistics_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_statistics_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_statistics_type([NotNull] PlSqlParser.Using_statistics_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.statistics_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatistics_type_name([NotNull] PlSqlParser.Statistics_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.statistics_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatistics_type_name([NotNull] PlSqlParser.Statistics_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_cost_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_cost_clause([NotNull] PlSqlParser.Default_cost_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_cost_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_cost_clause([NotNull] PlSqlParser.Default_cost_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cpu_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCpu_cost([NotNull] PlSqlParser.Cpu_costContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cpu_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCpu_cost([NotNull] PlSqlParser.Cpu_costContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.io_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIo_cost([NotNull] PlSqlParser.Io_costContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.io_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIo_cost([NotNull] PlSqlParser.Io_costContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.network_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNetwork_cost([NotNull] PlSqlParser.Network_costContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.network_cost"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNetwork_cost([NotNull] PlSqlParser.Network_costContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_selectivity_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_selectivity_clause([NotNull] PlSqlParser.Default_selectivity_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_selectivity_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_selectivity_clause([NotNull] PlSqlParser.Default_selectivity_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_selectivity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_selectivity([NotNull] PlSqlParser.Default_selectivityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_selectivity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_selectivity([NotNull] PlSqlParser.Default_selectivityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.storage_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStorage_table_clause([NotNull] PlSqlParser.Storage_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.storage_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStorage_table_clause([NotNull] PlSqlParser.Storage_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unified_auditing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnified_auditing([NotNull] PlSqlParser.Unified_auditingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unified_auditing"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnified_auditing([NotNull] PlSqlParser.Unified_auditingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.policy_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPolicy_name([NotNull] PlSqlParser.Policy_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.policy_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPolicy_name([NotNull] PlSqlParser.Policy_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_traditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_traditional([NotNull] PlSqlParser.Audit_traditionalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_traditional"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_traditional([NotNull] PlSqlParser.Audit_traditionalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_direct_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_direct_path([NotNull] PlSqlParser.Audit_direct_pathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_direct_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_direct_path([NotNull] PlSqlParser.Audit_direct_pathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_container_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_container_clause([NotNull] PlSqlParser.Audit_container_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_container_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_container_clause([NotNull] PlSqlParser.Audit_container_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_operation_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_operation_clause([NotNull] PlSqlParser.Audit_operation_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_operation_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_operation_clause([NotNull] PlSqlParser.Audit_operation_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.auditing_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuditing_by_clause([NotNull] PlSqlParser.Auditing_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.auditing_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuditing_by_clause([NotNull] PlSqlParser.Auditing_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_user([NotNull] PlSqlParser.Audit_userContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_user([NotNull] PlSqlParser.Audit_userContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.audit_schema_object_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAudit_schema_object_clause([NotNull] PlSqlParser.Audit_schema_object_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.audit_schema_object_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAudit_schema_object_clause([NotNull] PlSqlParser.Audit_schema_object_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_operation([NotNull] PlSqlParser.Sql_operationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_operation([NotNull] PlSqlParser.Sql_operationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.auditing_on_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAuditing_on_clause([NotNull] PlSqlParser.Auditing_on_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.auditing_on_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAuditing_on_clause([NotNull] PlSqlParser.Auditing_on_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_name([NotNull] PlSqlParser.Model_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_name([NotNull] PlSqlParser.Model_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_name([NotNull] PlSqlParser.Object_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_name([NotNull] PlSqlParser.Object_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.profile_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProfile_name([NotNull] PlSqlParser.Profile_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.profile_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProfile_name([NotNull] PlSqlParser.Profile_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_statement_shortcut"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_statement_shortcut([NotNull] PlSqlParser.Sql_statement_shortcutContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_statement_shortcut"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_statement_shortcut([NotNull] PlSqlParser.Sql_statement_shortcutContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_index([NotNull] PlSqlParser.Drop_indexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_index"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_index([NotNull] PlSqlParser.Drop_indexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRename_object([NotNull] PlSqlParser.Rename_objectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_object"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRename_object([NotNull] PlSqlParser.Rename_objectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grant_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrant_statement([NotNull] PlSqlParser.Grant_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grant_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrant_statement([NotNull] PlSqlParser.Grant_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainer_clause([NotNull] PlSqlParser.Container_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainer_clause([NotNull] PlSqlParser.Container_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_directory"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_directory([NotNull] PlSqlParser.Create_directoryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_directory"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_directory([NotNull] PlSqlParser.Create_directoryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.directory_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectory_name([NotNull] PlSqlParser.Directory_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.directory_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectory_name([NotNull] PlSqlParser.Directory_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.directory_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectory_path([NotNull] PlSqlParser.Directory_pathContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.directory_path"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectory_path([NotNull] PlSqlParser.Directory_pathContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_library([NotNull] PlSqlParser.Alter_libraryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_library"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_library([NotNull] PlSqlParser.Alter_libraryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_editionable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLibrary_editionable([NotNull] PlSqlParser.Library_editionableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_editionable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLibrary_editionable([NotNull] PlSqlParser.Library_editionableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_debug"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLibrary_debug([NotNull] PlSqlParser.Library_debugContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_debug"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLibrary_debug([NotNull] PlSqlParser.Library_debugContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compiler_parameters_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompiler_parameters_clause([NotNull] PlSqlParser.Compiler_parameters_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compiler_parameters_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompiler_parameters_clause([NotNull] PlSqlParser.Compiler_parameters_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_value([NotNull] PlSqlParser.Parameter_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_value([NotNull] PlSqlParser.Parameter_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.library_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLibrary_name([NotNull] PlSqlParser.Library_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.library_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLibrary_name([NotNull] PlSqlParser.Library_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_view([NotNull] PlSqlParser.Alter_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_view([NotNull] PlSqlParser.Alter_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_view_editionable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_view_editionable([NotNull] PlSqlParser.Alter_view_editionableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_view_editionable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_view_editionable([NotNull] PlSqlParser.Alter_view_editionableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_view([NotNull] PlSqlParser.Create_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_view([NotNull] PlSqlParser.Create_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.view_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_options([NotNull] PlSqlParser.View_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.view_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_options([NotNull] PlSqlParser.View_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.view_alias_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterView_alias_constraint([NotNull] PlSqlParser.View_alias_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.view_alias_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitView_alias_constraint([NotNull] PlSqlParser.View_alias_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_view_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_view_clause([NotNull] PlSqlParser.Object_view_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_view_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_view_clause([NotNull] PlSqlParser.Object_view_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.inline_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInline_constraint([NotNull] PlSqlParser.Inline_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.inline_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInline_constraint([NotNull] PlSqlParser.Inline_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.inline_ref_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInline_ref_constraint([NotNull] PlSqlParser.Inline_ref_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.inline_ref_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInline_ref_constraint([NotNull] PlSqlParser.Inline_ref_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_ref_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOut_of_line_ref_constraint([NotNull] PlSqlParser.Out_of_line_ref_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_ref_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOut_of_line_ref_constraint([NotNull] PlSqlParser.Out_of_line_ref_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOut_of_line_constraint([NotNull] PlSqlParser.Out_of_line_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOut_of_line_constraint([NotNull] PlSqlParser.Out_of_line_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint_state([NotNull] PlSqlParser.Constraint_stateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_state"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint_state([NotNull] PlSqlParser.Constraint_stateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_tablespace([NotNull] PlSqlParser.Alter_tablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_tablespace([NotNull] PlSqlParser.Alter_tablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatafile_tempfile_clauses([NotNull] PlSqlParser.Datafile_tempfile_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatafile_tempfile_clauses([NotNull] PlSqlParser.Datafile_tempfile_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_logging_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_logging_clauses([NotNull] PlSqlParser.Tablespace_logging_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_logging_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_logging_clauses([NotNull] PlSqlParser.Tablespace_logging_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_group_clause([NotNull] PlSqlParser.Tablespace_group_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_group_clause([NotNull] PlSqlParser.Tablespace_group_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_group_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_group_name([NotNull] PlSqlParser.Tablespace_group_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_group_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_group_name([NotNull] PlSqlParser.Tablespace_group_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_state_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_state_clauses([NotNull] PlSqlParser.Tablespace_state_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_state_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_state_clauses([NotNull] PlSqlParser.Tablespace_state_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_mode_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlashback_mode_clause([NotNull] PlSqlParser.Flashback_mode_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_mode_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlashback_mode_clause([NotNull] PlSqlParser.Flashback_mode_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_tablespace_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_tablespace_name([NotNull] PlSqlParser.New_tablespace_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_tablespace_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_tablespace_name([NotNull] PlSqlParser.New_tablespace_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_tablespace([NotNull] PlSqlParser.Create_tablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_tablespace([NotNull] PlSqlParser.Create_tablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.permanent_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPermanent_tablespace_clause([NotNull] PlSqlParser.Permanent_tablespace_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.permanent_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPermanent_tablespace_clause([NotNull] PlSqlParser.Permanent_tablespace_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_encryption_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_encryption_spec([NotNull] PlSqlParser.Tablespace_encryption_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_encryption_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_encryption_spec([NotNull] PlSqlParser.Tablespace_encryption_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logging_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogging_clause([NotNull] PlSqlParser.Logging_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logging_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogging_clause([NotNull] PlSqlParser.Logging_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.extent_management_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtent_management_clause([NotNull] PlSqlParser.Extent_management_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.extent_management_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtent_management_clause([NotNull] PlSqlParser.Extent_management_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.segment_management_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSegment_management_clause([NotNull] PlSqlParser.Segment_management_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.segment_management_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSegment_management_clause([NotNull] PlSqlParser.Segment_management_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.temporary_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemporary_tablespace_clause([NotNull] PlSqlParser.Temporary_tablespace_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.temporary_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemporary_tablespace_clause([NotNull] PlSqlParser.Temporary_tablespace_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.undo_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUndo_tablespace_clause([NotNull] PlSqlParser.Undo_tablespace_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.undo_tablespace_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUndo_tablespace_clause([NotNull] PlSqlParser.Undo_tablespace_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace_retention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace_retention_clause([NotNull] PlSqlParser.Tablespace_retention_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace_retention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace_retention_clause([NotNull] PlSqlParser.Tablespace_retention_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatafile_specification([NotNull] PlSqlParser.Datafile_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatafile_specification([NotNull] PlSqlParser.Datafile_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tempfile_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTempfile_specification([NotNull] PlSqlParser.Tempfile_specificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tempfile_specification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTempfile_specification([NotNull] PlSqlParser.Tempfile_specificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatafile_tempfile_spec([NotNull] PlSqlParser.Datafile_tempfile_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datafile_tempfile_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatafile_tempfile_spec([NotNull] PlSqlParser.Datafile_tempfile_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.redo_log_file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRedo_log_file_spec([NotNull] PlSqlParser.Redo_log_file_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.redo_log_file_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRedo_log_file_spec([NotNull] PlSqlParser.Redo_log_file_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.autoextend_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAutoextend_clause([NotNull] PlSqlParser.Autoextend_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.autoextend_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAutoextend_clause([NotNull] PlSqlParser.Autoextend_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.maxsize_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaxsize_clause([NotNull] PlSqlParser.Maxsize_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.maxsize_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaxsize_clause([NotNull] PlSqlParser.Maxsize_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.build_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBuild_clause([NotNull] PlSqlParser.Build_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.build_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBuild_clause([NotNull] PlSqlParser.Build_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parallel_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParallel_clause([NotNull] PlSqlParser.Parallel_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parallel_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParallel_clause([NotNull] PlSqlParser.Parallel_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_materialized_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_materialized_view([NotNull] PlSqlParser.Alter_materialized_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_materialized_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_materialized_view([NotNull] PlSqlParser.Alter_materialized_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mv_option1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_mv_option1([NotNull] PlSqlParser.Alter_mv_option1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mv_option1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_mv_option1([NotNull] PlSqlParser.Alter_mv_option1Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mv_refresh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_mv_refresh([NotNull] PlSqlParser.Alter_mv_refreshContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mv_refresh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_mv_refresh([NotNull] PlSqlParser.Alter_mv_refreshContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_segment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_segment([NotNull] PlSqlParser.Rollback_segmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_segment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_segment([NotNull] PlSqlParser.Rollback_segmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_mv_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_mv_column_clause([NotNull] PlSqlParser.Modify_mv_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_mv_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_mv_column_clause([NotNull] PlSqlParser.Modify_mv_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_materialized_view_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_materialized_view_log([NotNull] PlSqlParser.Alter_materialized_view_logContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_materialized_view_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_materialized_view_log([NotNull] PlSqlParser.Alter_materialized_view_logContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_mv_log_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_mv_log_column_clause([NotNull] PlSqlParser.Add_mv_log_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_mv_log_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_mv_log_column_clause([NotNull] PlSqlParser.Add_mv_log_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.move_mv_log_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMove_mv_log_clause([NotNull] PlSqlParser.Move_mv_log_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.move_mv_log_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMove_mv_log_clause([NotNull] PlSqlParser.Move_mv_log_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mv_log_augmentation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMv_log_augmentation([NotNull] PlSqlParser.Mv_log_augmentationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mv_log_augmentation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMv_log_augmentation([NotNull] PlSqlParser.Mv_log_augmentationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datetime_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatetime_expr([NotNull] PlSqlParser.Datetime_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datetime_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatetime_expr([NotNull] PlSqlParser.Datetime_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.interval_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterval_expr([NotNull] PlSqlParser.Interval_exprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.interval_expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterval_expr([NotNull] PlSqlParser.Interval_exprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.synchronous_or_asynchronous"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSynchronous_or_asynchronous([NotNull] PlSqlParser.Synchronous_or_asynchronousContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.synchronous_or_asynchronous"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSynchronous_or_asynchronous([NotNull] PlSqlParser.Synchronous_or_asynchronousContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.including_or_excluding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIncluding_or_excluding([NotNull] PlSqlParser.Including_or_excludingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.including_or_excluding"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIncluding_or_excluding([NotNull] PlSqlParser.Including_or_excludingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_materialized_view_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_materialized_view_log([NotNull] PlSqlParser.Create_materialized_view_logContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_materialized_view_log"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_materialized_view_log([NotNull] PlSqlParser.Create_materialized_view_logContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_values_clause([NotNull] PlSqlParser.New_values_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_values_clause([NotNull] PlSqlParser.New_values_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mv_log_purge_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMv_log_purge_clause([NotNull] PlSqlParser.Mv_log_purge_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mv_log_purge_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMv_log_purge_clause([NotNull] PlSqlParser.Mv_log_purge_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_materialized_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_materialized_view([NotNull] PlSqlParser.Create_materialized_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_materialized_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_materialized_view([NotNull] PlSqlParser.Create_materialized_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_mv_refresh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_mv_refresh([NotNull] PlSqlParser.Create_mv_refreshContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_mv_refresh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_mv_refresh([NotNull] PlSqlParser.Create_mv_refreshContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_context"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_context([NotNull] PlSqlParser.Create_contextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_context"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_context([NotNull] PlSqlParser.Create_contextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oracle_namespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOracle_namespace([NotNull] PlSqlParser.Oracle_namespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oracle_namespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOracle_namespace([NotNull] PlSqlParser.Oracle_namespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_cluster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_cluster([NotNull] PlSqlParser.Create_clusterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_cluster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_cluster([NotNull] PlSqlParser.Create_clusterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_table([NotNull] PlSqlParser.Create_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_table([NotNull] PlSqlParser.Create_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltype_table([NotNull] PlSqlParser.Xmltype_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltype_table([NotNull] PlSqlParser.Xmltype_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_virtual_columns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltype_virtual_columns([NotNull] PlSqlParser.Xmltype_virtual_columnsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_virtual_columns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltype_virtual_columns([NotNull] PlSqlParser.Xmltype_virtual_columnsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_column_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltype_column_properties([NotNull] PlSqlParser.Xmltype_column_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_column_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltype_column_properties([NotNull] PlSqlParser.Xmltype_column_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltype_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltype_storage([NotNull] PlSqlParser.Xmltype_storageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltype_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltype_storage([NotNull] PlSqlParser.Xmltype_storageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlschema_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlschema_spec([NotNull] PlSqlParser.Xmlschema_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlschema_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlschema_spec([NotNull] PlSqlParser.Xmlschema_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_table([NotNull] PlSqlParser.Object_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_table([NotNull] PlSqlParser.Object_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oid_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOid_index_clause([NotNull] PlSqlParser.Oid_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oid_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOid_index_clause([NotNull] PlSqlParser.Oid_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.oid_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOid_clause([NotNull] PlSqlParser.Oid_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.oid_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOid_clause([NotNull] PlSqlParser.Oid_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_properties([NotNull] PlSqlParser.Object_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_properties([NotNull] PlSqlParser.Object_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_table_substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_table_substitution([NotNull] PlSqlParser.Object_table_substitutionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_table_substitution"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_table_substitution([NotNull] PlSqlParser.Object_table_substitutionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_table([NotNull] PlSqlParser.Relational_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_table([NotNull] PlSqlParser.Relational_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_property([NotNull] PlSqlParser.Relational_propertyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_property"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_property([NotNull] PlSqlParser.Relational_propertyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_partitioning_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_partitioning_clauses([NotNull] PlSqlParser.Table_partitioning_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_partitioning_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_partitioning_clauses([NotNull] PlSqlParser.Table_partitioning_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_partitions([NotNull] PlSqlParser.Range_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_partitions([NotNull] PlSqlParser.Range_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_partitions([NotNull] PlSqlParser.List_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_partitions([NotNull] PlSqlParser.List_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_partitions([NotNull] PlSqlParser.Hash_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_partitions([NotNull] PlSqlParser.Hash_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.individual_hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndividual_hash_partitions([NotNull] PlSqlParser.Individual_hash_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.individual_hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndividual_hash_partitions([NotNull] PlSqlParser.Individual_hash_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partitions_by_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_partitions_by_quantity([NotNull] PlSqlParser.Hash_partitions_by_quantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partitions_by_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_partitions_by_quantity([NotNull] PlSqlParser.Hash_partitions_by_quantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_partition_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_partition_quantity([NotNull] PlSqlParser.Hash_partition_quantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_partition_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_partition_quantity([NotNull] PlSqlParser.Hash_partition_quantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_range_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComposite_range_partitions([NotNull] PlSqlParser.Composite_range_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_range_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComposite_range_partitions([NotNull] PlSqlParser.Composite_range_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_list_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComposite_list_partitions([NotNull] PlSqlParser.Composite_list_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_list_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComposite_list_partitions([NotNull] PlSqlParser.Composite_list_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.composite_hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComposite_hash_partitions([NotNull] PlSqlParser.Composite_hash_partitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.composite_hash_partitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComposite_hash_partitions([NotNull] PlSqlParser.Composite_hash_partitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference_partitioning([NotNull] PlSqlParser.Reference_partitioningContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference_partitioning([NotNull] PlSqlParser.Reference_partitioningContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference_partition_desc([NotNull] PlSqlParser.Reference_partition_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference_partition_desc([NotNull] PlSqlParser.Reference_partition_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.system_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSystem_partitioning([NotNull] PlSqlParser.System_partitioningContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.system_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSystem_partitioning([NotNull] PlSqlParser.System_partitioningContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_partition_desc([NotNull] PlSqlParser.Range_partition_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_partition_desc([NotNull] PlSqlParser.Range_partition_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_partition_desc([NotNull] PlSqlParser.List_partition_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_partition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_partition_desc([NotNull] PlSqlParser.List_partition_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_template"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_template([NotNull] PlSqlParser.Subpartition_templateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_template"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_template([NotNull] PlSqlParser.Subpartition_templateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_subpartition_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_subpartition_quantity([NotNull] PlSqlParser.Hash_subpartition_quantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_subpartition_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_subpartition_quantity([NotNull] PlSqlParser.Hash_subpartition_quantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_range"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_by_range([NotNull] PlSqlParser.Subpartition_by_rangeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_range"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_by_range([NotNull] PlSqlParser.Subpartition_by_rangeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_by_list([NotNull] PlSqlParser.Subpartition_by_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_by_list([NotNull] PlSqlParser.Subpartition_by_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_by_hash"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_by_hash([NotNull] PlSqlParser.Subpartition_by_hashContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_by_hash"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_by_hash([NotNull] PlSqlParser.Subpartition_by_hashContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_name([NotNull] PlSqlParser.Subpartition_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_name([NotNull] PlSqlParser.Subpartition_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_subpartition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_subpartition_desc([NotNull] PlSqlParser.Range_subpartition_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_subpartition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_subpartition_desc([NotNull] PlSqlParser.Range_subpartition_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_subpartition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_subpartition_desc([NotNull] PlSqlParser.List_subpartition_descContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_subpartition_desc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_subpartition_desc([NotNull] PlSqlParser.List_subpartition_descContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.individual_hash_subparts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndividual_hash_subparts([NotNull] PlSqlParser.Individual_hash_subpartsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.individual_hash_subparts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndividual_hash_subparts([NotNull] PlSqlParser.Individual_hash_subpartsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hash_subparts_by_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHash_subparts_by_quantity([NotNull] PlSqlParser.Hash_subparts_by_quantityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hash_subparts_by_quantity"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHash_subparts_by_quantity([NotNull] PlSqlParser.Hash_subparts_by_quantityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.range_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_values_clause([NotNull] PlSqlParser.Range_values_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.range_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_values_clause([NotNull] PlSqlParser.Range_values_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.list_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList_values_clause([NotNull] PlSqlParser.List_values_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.list_values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList_values_clause([NotNull] PlSqlParser.List_values_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_partition_description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_partition_description([NotNull] PlSqlParser.Table_partition_descriptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_partition_description"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_partition_description([NotNull] PlSqlParser.Table_partition_descriptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partitioning_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitioning_storage_clause([NotNull] PlSqlParser.Partitioning_storage_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partitioning_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitioning_storage_clause([NotNull] PlSqlParser.Partitioning_storage_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_partitioning_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_partitioning_storage([NotNull] PlSqlParser.Lob_partitioning_storageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_partitioning_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_partitioning_storage([NotNull] PlSqlParser.Lob_partitioning_storageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datatype_null_enable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatatype_null_enable([NotNull] PlSqlParser.Datatype_null_enableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datatype_null_enable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatatype_null_enable([NotNull] PlSqlParser.Datatype_null_enableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.size_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSize_clause([NotNull] PlSqlParser.Size_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.size_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSize_clause([NotNull] PlSqlParser.Size_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_compression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_compression([NotNull] PlSqlParser.Table_compressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_compression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_compression([NotNull] PlSqlParser.Table_compressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.physical_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPhysical_attributes_clause([NotNull] PlSqlParser.Physical_attributes_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.physical_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPhysical_attributes_clause([NotNull] PlSqlParser.Physical_attributes_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStorage_clause([NotNull] PlSqlParser.Storage_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStorage_clause([NotNull] PlSqlParser.Storage_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.deferred_segment_creation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeferred_segment_creation([NotNull] PlSqlParser.Deferred_segment_creationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.deferred_segment_creation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeferred_segment_creation([NotNull] PlSqlParser.Deferred_segment_creationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.segment_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSegment_attributes_clause([NotNull] PlSqlParser.Segment_attributes_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.segment_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSegment_attributes_clause([NotNull] PlSqlParser.Segment_attributes_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.physical_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPhysical_properties([NotNull] PlSqlParser.Physical_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.physical_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPhysical_properties([NotNull] PlSqlParser.Physical_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.row_movement_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRow_movement_clause([NotNull] PlSqlParser.Row_movement_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.row_movement_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRow_movement_clause([NotNull] PlSqlParser.Row_movement_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_archive_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlashback_archive_clause([NotNull] PlSqlParser.Flashback_archive_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_archive_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlashback_archive_clause([NotNull] PlSqlParser.Flashback_archive_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.log_grp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLog_grp([NotNull] PlSqlParser.Log_grpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.log_grp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLog_grp([NotNull] PlSqlParser.Log_grpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_table_logging"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_table_logging([NotNull] PlSqlParser.Supplemental_table_loggingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_table_logging"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_table_logging([NotNull] PlSqlParser.Supplemental_table_loggingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_log_grp_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_log_grp_clause([NotNull] PlSqlParser.Supplemental_log_grp_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_log_grp_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_log_grp_clause([NotNull] PlSqlParser.Supplemental_log_grp_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_id_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_id_key_clause([NotNull] PlSqlParser.Supplemental_id_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_id_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_id_key_clause([NotNull] PlSqlParser.Supplemental_id_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.allocate_extent_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAllocate_extent_clause([NotNull] PlSqlParser.Allocate_extent_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.allocate_extent_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAllocate_extent_clause([NotNull] PlSqlParser.Allocate_extent_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.deallocate_unused_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeallocate_unused_clause([NotNull] PlSqlParser.Deallocate_unused_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.deallocate_unused_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeallocate_unused_clause([NotNull] PlSqlParser.Deallocate_unused_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.shrink_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShrink_clause([NotNull] PlSqlParser.Shrink_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.shrink_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShrink_clause([NotNull] PlSqlParser.Shrink_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.records_per_block_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecords_per_block_clause([NotNull] PlSqlParser.Records_per_block_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.records_per_block_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecords_per_block_clause([NotNull] PlSqlParser.Records_per_block_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upgrade_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpgrade_table_clause([NotNull] PlSqlParser.Upgrade_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upgrade_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpgrade_table_clause([NotNull] PlSqlParser.Upgrade_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.truncate_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncate_table([NotNull] PlSqlParser.Truncate_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.truncate_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncate_table([NotNull] PlSqlParser.Truncate_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_table([NotNull] PlSqlParser.Drop_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_table([NotNull] PlSqlParser.Drop_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_view([NotNull] PlSqlParser.Drop_viewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_view"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_view([NotNull] PlSqlParser.Drop_viewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.comment_on_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment_on_column([NotNull] PlSqlParser.Comment_on_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.comment_on_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment_on_column([NotNull] PlSqlParser.Comment_on_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_or_disable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnable_or_disable([NotNull] PlSqlParser.Enable_or_disableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_or_disable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnable_or_disable([NotNull] PlSqlParser.Enable_or_disableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.allow_or_disallow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAllow_or_disallow([NotNull] PlSqlParser.Allow_or_disallowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.allow_or_disallow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAllow_or_disallow([NotNull] PlSqlParser.Allow_or_disallowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_synonym([NotNull] PlSqlParser.Create_synonymContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_synonym"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_synonym([NotNull] PlSqlParser.Create_synonymContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.comment_on_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment_on_table([NotNull] PlSqlParser.Comment_on_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.comment_on_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment_on_table([NotNull] PlSqlParser.Comment_on_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_cluster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_cluster([NotNull] PlSqlParser.Alter_clusterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_cluster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_cluster([NotNull] PlSqlParser.Alter_clusterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cache_or_nocache"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCache_or_nocache([NotNull] PlSqlParser.Cache_or_nocacheContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cache_or_nocache"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCache_or_nocache([NotNull] PlSqlParser.Cache_or_nocacheContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_name([NotNull] PlSqlParser.Database_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_name([NotNull] PlSqlParser.Database_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_database([NotNull] PlSqlParser.Alter_databaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_database([NotNull] PlSqlParser.Alter_databaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.startup_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStartup_clauses([NotNull] PlSqlParser.Startup_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.startup_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStartup_clauses([NotNull] PlSqlParser.Startup_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.resetlogs_or_noresetlogs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResetlogs_or_noresetlogs([NotNull] PlSqlParser.Resetlogs_or_noresetlogsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.resetlogs_or_noresetlogs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResetlogs_or_noresetlogs([NotNull] PlSqlParser.Resetlogs_or_noresetlogsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upgrade_or_downgrade"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpgrade_or_downgrade([NotNull] PlSqlParser.Upgrade_or_downgradeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upgrade_or_downgrade"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpgrade_or_downgrade([NotNull] PlSqlParser.Upgrade_or_downgradeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.recovery_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecovery_clauses([NotNull] PlSqlParser.Recovery_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.recovery_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecovery_clauses([NotNull] PlSqlParser.Recovery_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.begin_or_end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBegin_or_end([NotNull] PlSqlParser.Begin_or_endContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.begin_or_end"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBegin_or_end([NotNull] PlSqlParser.Begin_or_endContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneral_recovery([NotNull] PlSqlParser.General_recoveryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneral_recovery([NotNull] PlSqlParser.General_recoveryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.full_database_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFull_database_recovery([NotNull] PlSqlParser.Full_database_recoveryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.full_database_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFull_database_recovery([NotNull] PlSqlParser.Full_database_recoveryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partial_database_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartial_database_recovery([NotNull] PlSqlParser.Partial_database_recoveryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partial_database_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartial_database_recovery([NotNull] PlSqlParser.Partial_database_recoveryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partial_database_recovery_10g"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartial_database_recovery_10g([NotNull] PlSqlParser.Partial_database_recovery_10gContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partial_database_recovery_10g"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartial_database_recovery_10g([NotNull] PlSqlParser.Partial_database_recovery_10gContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.managed_standby_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterManaged_standby_recovery([NotNull] PlSqlParser.Managed_standby_recoveryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.managed_standby_recovery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitManaged_standby_recovery([NotNull] PlSqlParser.Managed_standby_recoveryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.db_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDb_name([NotNull] PlSqlParser.Db_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.db_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDb_name([NotNull] PlSqlParser.Db_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database_file_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase_file_clauses([NotNull] PlSqlParser.Database_file_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database_file_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase_file_clauses([NotNull] PlSqlParser.Database_file_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.create_datafile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreate_datafile_clause([NotNull] PlSqlParser.Create_datafile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.create_datafile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreate_datafile_clause([NotNull] PlSqlParser.Create_datafile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_datafile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_datafile_clause([NotNull] PlSqlParser.Alter_datafile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_datafile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_datafile_clause([NotNull] PlSqlParser.Alter_datafile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_tempfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_tempfile_clause([NotNull] PlSqlParser.Alter_tempfile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_tempfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_tempfile_clause([NotNull] PlSqlParser.Alter_tempfile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfile_clauses([NotNull] PlSqlParser.Logfile_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfile_clauses([NotNull] PlSqlParser.Logfile_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_logfile_clauses([NotNull] PlSqlParser.Add_logfile_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_logfile_clauses([NotNull] PlSqlParser.Add_logfile_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.log_file_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLog_file_group([NotNull] PlSqlParser.Log_file_groupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.log_file_group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLog_file_group([NotNull] PlSqlParser.Log_file_groupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_logfile_clauses([NotNull] PlSqlParser.Drop_logfile_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_logfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_logfile_clauses([NotNull] PlSqlParser.Drop_logfile_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.switch_logfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_logfile_clause([NotNull] PlSqlParser.Switch_logfile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.switch_logfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_logfile_clause([NotNull] PlSqlParser.Switch_logfile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_db_logging"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_db_logging([NotNull] PlSqlParser.Supplemental_db_loggingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_db_logging"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_db_logging([NotNull] PlSqlParser.Supplemental_db_loggingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_or_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_or_drop([NotNull] PlSqlParser.Add_or_dropContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_or_drop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_or_drop([NotNull] PlSqlParser.Add_or_dropContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_plsql_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_plsql_clause([NotNull] PlSqlParser.Supplemental_plsql_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_plsql_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_plsql_clause([NotNull] PlSqlParser.Supplemental_plsql_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logfile_descriptor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfile_descriptor([NotNull] PlSqlParser.Logfile_descriptorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logfile_descriptor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfile_descriptor([NotNull] PlSqlParser.Logfile_descriptorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.controlfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterControlfile_clauses([NotNull] PlSqlParser.Controlfile_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.controlfile_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitControlfile_clauses([NotNull] PlSqlParser.Controlfile_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trace_file_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrace_file_clause([NotNull] PlSqlParser.Trace_file_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trace_file_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrace_file_clause([NotNull] PlSqlParser.Trace_file_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standby_database_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStandby_database_clauses([NotNull] PlSqlParser.Standby_database_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standby_database_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStandby_database_clauses([NotNull] PlSqlParser.Standby_database_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.activate_standby_db_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterActivate_standby_db_clause([NotNull] PlSqlParser.Activate_standby_db_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.activate_standby_db_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitActivate_standby_db_clause([NotNull] PlSqlParser.Activate_standby_db_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.maximize_standby_db_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMaximize_standby_db_clause([NotNull] PlSqlParser.Maximize_standby_db_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.maximize_standby_db_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMaximize_standby_db_clause([NotNull] PlSqlParser.Maximize_standby_db_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.register_logfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegister_logfile_clause([NotNull] PlSqlParser.Register_logfile_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.register_logfile_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegister_logfile_clause([NotNull] PlSqlParser.Register_logfile_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.commit_switchover_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommit_switchover_clause([NotNull] PlSqlParser.Commit_switchover_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.commit_switchover_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommit_switchover_clause([NotNull] PlSqlParser.Commit_switchover_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_standby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart_standby_clause([NotNull] PlSqlParser.Start_standby_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_standby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart_standby_clause([NotNull] PlSqlParser.Start_standby_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.stop_standby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStop_standby_clause([NotNull] PlSqlParser.Stop_standby_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.stop_standby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStop_standby_clause([NotNull] PlSqlParser.Stop_standby_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.convert_database_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConvert_database_clause([NotNull] PlSqlParser.Convert_database_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.convert_database_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConvert_database_clause([NotNull] PlSqlParser.Convert_database_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_settings_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_settings_clause([NotNull] PlSqlParser.Default_settings_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_settings_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_settings_clause([NotNull] PlSqlParser.Default_settings_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_time_zone_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_time_zone_clause([NotNull] PlSqlParser.Set_time_zone_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_time_zone_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_time_zone_clause([NotNull] PlSqlParser.Set_time_zone_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.instance_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstance_clauses([NotNull] PlSqlParser.Instance_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.instance_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstance_clauses([NotNull] PlSqlParser.Instance_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.security_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSecurity_clause([NotNull] PlSqlParser.Security_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.security_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSecurity_clause([NotNull] PlSqlParser.Security_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.domain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDomain([NotNull] PlSqlParser.DomainContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.domain"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDomain([NotNull] PlSqlParser.DomainContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatabase([NotNull] PlSqlParser.DatabaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.database"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatabase([NotNull] PlSqlParser.DatabaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.edition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEdition_name([NotNull] PlSqlParser.Edition_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.edition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEdition_name([NotNull] PlSqlParser.Edition_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.filenumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilenumber([NotNull] PlSqlParser.FilenumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.filenumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilenumber([NotNull] PlSqlParser.FilenumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilename([NotNull] PlSqlParser.FilenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.filename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilename([NotNull] PlSqlParser.FilenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table([NotNull] PlSqlParser.Alter_tableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table([NotNull] PlSqlParser.Alter_tableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_properties([NotNull] PlSqlParser.Alter_table_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_properties([NotNull] PlSqlParser.Alter_table_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_partitioning([NotNull] PlSqlParser.Alter_table_partitioningContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_partitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_partitioning([NotNull] PlSqlParser.Alter_table_partitioningContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_table_partition([NotNull] PlSqlParser.Add_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_table_partition([NotNull] PlSqlParser.Add_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_table_partition([NotNull] PlSqlParser.Drop_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_table_partition([NotNull] PlSqlParser.Drop_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_table_partition([NotNull] PlSqlParser.Merge_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_table_partition([NotNull] PlSqlParser.Merge_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_table_partition([NotNull] PlSqlParser.Modify_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_table_partition([NotNull] PlSqlParser.Modify_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.split_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSplit_table_partition([NotNull] PlSqlParser.Split_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.split_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSplit_table_partition([NotNull] PlSqlParser.Split_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.truncate_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncate_table_partition([NotNull] PlSqlParser.Truncate_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.truncate_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncate_table_partition([NotNull] PlSqlParser.Truncate_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exchange_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExchange_table_partition([NotNull] PlSqlParser.Exchange_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exchange_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExchange_table_partition([NotNull] PlSqlParser.Exchange_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.coalesce_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCoalesce_table_partition([NotNull] PlSqlParser.Coalesce_table_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.coalesce_table_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCoalesce_table_partition([NotNull] PlSqlParser.Coalesce_table_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_interval_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_interval_partition([NotNull] PlSqlParser.Alter_interval_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_interval_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_interval_partition([NotNull] PlSqlParser.Alter_interval_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extended_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_extended_names([NotNull] PlSqlParser.Partition_extended_namesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extended_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_extended_names([NotNull] PlSqlParser.Partition_extended_namesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subpartition_extended_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartition_extended_names([NotNull] PlSqlParser.Subpartition_extended_namesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subpartition_extended_names"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartition_extended_names([NotNull] PlSqlParser.Subpartition_extended_namesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_table_properties_1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_table_properties_1([NotNull] PlSqlParser.Alter_table_properties_1Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_table_properties_1"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_table_properties_1([NotNull] PlSqlParser.Alter_table_properties_1Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_iot_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_iot_clauses([NotNull] PlSqlParser.Alter_iot_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_iot_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_iot_clauses([NotNull] PlSqlParser.Alter_iot_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_mapping_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_mapping_table_clause([NotNull] PlSqlParser.Alter_mapping_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_mapping_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_mapping_table_clause([NotNull] PlSqlParser.Alter_mapping_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_overflow_clause([NotNull] PlSqlParser.Alter_overflow_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_overflow_clause([NotNull] PlSqlParser.Alter_overflow_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_overflow_clause([NotNull] PlSqlParser.Add_overflow_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_overflow_clause([NotNull] PlSqlParser.Add_overflow_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_index_clauses([NotNull] PlSqlParser.Update_index_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_index_clauses([NotNull] PlSqlParser.Update_index_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_global_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_global_index_clause([NotNull] PlSqlParser.Update_global_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_global_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_global_index_clause([NotNull] PlSqlParser.Update_global_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_all_indexes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_all_indexes_clause([NotNull] PlSqlParser.Update_all_indexes_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_all_indexes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_all_indexes_clause([NotNull] PlSqlParser.Update_all_indexes_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_all_indexes_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_all_indexes_index_clause([NotNull] PlSqlParser.Update_all_indexes_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_all_indexes_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_all_indexes_index_clause([NotNull] PlSqlParser.Update_all_indexes_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_index_partition([NotNull] PlSqlParser.Update_index_partitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_partition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_index_partition([NotNull] PlSqlParser.Update_index_partitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_index_subpartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_index_subpartition([NotNull] PlSqlParser.Update_index_subpartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_index_subpartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_index_subpartition([NotNull] PlSqlParser.Update_index_subpartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_disable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnable_disable_clause([NotNull] PlSqlParser.Enable_disable_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_disable_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnable_disable_clause([NotNull] PlSqlParser.Enable_disable_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_index_clause([NotNull] PlSqlParser.Using_index_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_index_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_index_clause([NotNull] PlSqlParser.Using_index_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_attributes([NotNull] PlSqlParser.Index_attributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_attributes([NotNull] PlSqlParser.Index_attributesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sort_or_nosort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSort_or_nosort([NotNull] PlSqlParser.Sort_or_nosortContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sort_or_nosort"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSort_or_nosort([NotNull] PlSqlParser.Sort_or_nosortContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exceptions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptions_clause([NotNull] PlSqlParser.Exceptions_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exceptions_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptions_clause([NotNull] PlSqlParser.Exceptions_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.move_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMove_table_clause([NotNull] PlSqlParser.Move_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.move_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMove_table_clause([NotNull] PlSqlParser.Move_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_org_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_org_table_clause([NotNull] PlSqlParser.Index_org_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_org_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_org_table_clause([NotNull] PlSqlParser.Index_org_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.mapping_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMapping_table_clause([NotNull] PlSqlParser.Mapping_table_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.mapping_table_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMapping_table_clause([NotNull] PlSqlParser.Mapping_table_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.key_compression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKey_compression([NotNull] PlSqlParser.Key_compressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.key_compression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKey_compression([NotNull] PlSqlParser.Key_compressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_org_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_org_overflow_clause([NotNull] PlSqlParser.Index_org_overflow_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_org_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_org_overflow_clause([NotNull] PlSqlParser.Index_org_overflow_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_clauses([NotNull] PlSqlParser.Column_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_clauses([NotNull] PlSqlParser.Column_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_collection_retrieval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_collection_retrieval([NotNull] PlSqlParser.Modify_collection_retrievalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_collection_retrieval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_collection_retrieval([NotNull] PlSqlParser.Modify_collection_retrievalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collection_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection_item([NotNull] PlSqlParser.Collection_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collection_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection_item([NotNull] PlSqlParser.Collection_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rename_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRename_column_clause([NotNull] PlSqlParser.Rename_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rename_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRename_column_clause([NotNull] PlSqlParser.Rename_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.old_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOld_column_name([NotNull] PlSqlParser.Old_column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.old_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOld_column_name([NotNull] PlSqlParser.Old_column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_column_name([NotNull] PlSqlParser.New_column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_column_name([NotNull] PlSqlParser.New_column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_modify_drop_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_modify_drop_column_clauses([NotNull] PlSqlParser.Add_modify_drop_column_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_modify_drop_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_modify_drop_column_clauses([NotNull] PlSqlParser.Add_modify_drop_column_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_column_clause([NotNull] PlSqlParser.Drop_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_column_clause([NotNull] PlSqlParser.Drop_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_column_clauses([NotNull] PlSqlParser.Modify_column_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_column_clauses([NotNull] PlSqlParser.Modify_column_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_col_properties([NotNull] PlSqlParser.Modify_col_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_col_properties([NotNull] PlSqlParser.Modify_col_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_col_substitutable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_col_substitutable([NotNull] PlSqlParser.Modify_col_substitutableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_col_substitutable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_col_substitutable([NotNull] PlSqlParser.Modify_col_substitutableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_column_clause([NotNull] PlSqlParser.Add_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_column_clause([NotNull] PlSqlParser.Add_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.alter_varray_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlter_varray_col_properties([NotNull] PlSqlParser.Alter_varray_col_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.alter_varray_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlter_varray_col_properties([NotNull] PlSqlParser.Alter_varray_col_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarray_col_properties([NotNull] PlSqlParser.Varray_col_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarray_col_properties([NotNull] PlSqlParser.Varray_col_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarray_storage_clause([NotNull] PlSqlParser.Varray_storage_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarray_storage_clause([NotNull] PlSqlParser.Varray_storage_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_segname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_segname([NotNull] PlSqlParser.Lob_segnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_segname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_segname([NotNull] PlSqlParser.Lob_segnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_item([NotNull] PlSqlParser.Lob_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_item([NotNull] PlSqlParser.Lob_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_storage_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_storage_parameters([NotNull] PlSqlParser.Lob_storage_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_storage_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_storage_parameters([NotNull] PlSqlParser.Lob_storage_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_storage_clause([NotNull] PlSqlParser.Lob_storage_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_storage_clause([NotNull] PlSqlParser.Lob_storage_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_lob_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_lob_storage_clause([NotNull] PlSqlParser.Modify_lob_storage_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_lob_storage_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_lob_storage_clause([NotNull] PlSqlParser.Modify_lob_storage_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.modify_lob_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModify_lob_parameters([NotNull] PlSqlParser.Modify_lob_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.modify_lob_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModify_lob_parameters([NotNull] PlSqlParser.Modify_lob_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_parameters([NotNull] PlSqlParser.Lob_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_parameters([NotNull] PlSqlParser.Lob_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_deduplicate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_deduplicate_clause([NotNull] PlSqlParser.Lob_deduplicate_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_deduplicate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_deduplicate_clause([NotNull] PlSqlParser.Lob_deduplicate_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_compression_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_compression_clause([NotNull] PlSqlParser.Lob_compression_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_compression_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_compression_clause([NotNull] PlSqlParser.Lob_compression_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lob_retention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLob_retention_clause([NotNull] PlSqlParser.Lob_retention_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lob_retention_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLob_retention_clause([NotNull] PlSqlParser.Lob_retention_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.encryption_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEncryption_spec([NotNull] PlSqlParser.Encryption_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.encryption_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEncryption_spec([NotNull] PlSqlParser.Encryption_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespace([NotNull] PlSqlParser.TablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespace([NotNull] PlSqlParser.TablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarray_item([NotNull] PlSqlParser.Varray_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarray_item([NotNull] PlSqlParser.Varray_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_properties([NotNull] PlSqlParser.Column_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_properties([NotNull] PlSqlParser.Column_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.period_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPeriod_definition([NotNull] PlSqlParser.Period_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.period_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPeriod_definition([NotNull] PlSqlParser.Period_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_time_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart_time_column([NotNull] PlSqlParser.Start_time_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_time_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart_time_column([NotNull] PlSqlParser.Start_time_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.end_time_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnd_time_column([NotNull] PlSqlParser.End_time_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.end_time_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnd_time_column([NotNull] PlSqlParser.End_time_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_definition([NotNull] PlSqlParser.Column_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_definition([NotNull] PlSqlParser.Column_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.virtual_column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVirtual_column_definition([NotNull] PlSqlParser.Virtual_column_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.virtual_column_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVirtual_column_definition([NotNull] PlSqlParser.Virtual_column_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.autogenerated_sequence_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAutogenerated_sequence_definition([NotNull] PlSqlParser.Autogenerated_sequence_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.autogenerated_sequence_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAutogenerated_sequence_definition([NotNull] PlSqlParser.Autogenerated_sequence_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.out_of_line_part_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOut_of_line_part_storage([NotNull] PlSqlParser.Out_of_line_part_storageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.out_of_line_part_storage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOut_of_line_part_storage([NotNull] PlSqlParser.Out_of_line_part_storageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_table_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNested_table_col_properties([NotNull] PlSqlParser.Nested_table_col_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_table_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNested_table_col_properties([NotNull] PlSqlParser.Nested_table_col_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.nested_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNested_item([NotNull] PlSqlParser.Nested_itemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.nested_item"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNested_item([NotNull] PlSqlParser.Nested_itemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.substitutable_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstitutable_column_clause([NotNull] PlSqlParser.Substitutable_column_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.substitutable_column_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstitutable_column_clause([NotNull] PlSqlParser.Substitutable_column_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_name([NotNull] PlSqlParser.Partition_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_name([NotNull] PlSqlParser.Partition_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.supplemental_logging_props"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSupplemental_logging_props([NotNull] PlSqlParser.Supplemental_logging_propsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.supplemental_logging_props"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSupplemental_logging_props([NotNull] PlSqlParser.Supplemental_logging_propsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_or_attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_or_attribute([NotNull] PlSqlParser.Column_or_attributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_or_attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_or_attribute([NotNull] PlSqlParser.Column_or_attributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_type_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_type_col_properties([NotNull] PlSqlParser.Object_type_col_propertiesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_type_col_properties"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_type_col_properties([NotNull] PlSqlParser.Object_type_col_propertiesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint_clauses([NotNull] PlSqlParser.Constraint_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint_clauses([NotNull] PlSqlParser.Constraint_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.old_constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOld_constraint_name([NotNull] PlSqlParser.Old_constraint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.old_constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOld_constraint_name([NotNull] PlSqlParser.Old_constraint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.new_constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNew_constraint_name([NotNull] PlSqlParser.New_constraint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.new_constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNew_constraint_name([NotNull] PlSqlParser.New_constraint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_constraint_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_constraint_clause([NotNull] PlSqlParser.Drop_constraint_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_constraint_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_constraint_clause([NotNull] PlSqlParser.Drop_constraint_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_primary_key_or_unique_or_generic_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_primary_key_or_unique_or_generic_clause([NotNull] PlSqlParser.Drop_primary_key_or_unique_or_generic_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_primary_key_or_unique_or_generic_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_primary_key_or_unique_or_generic_clause([NotNull] PlSqlParser.Drop_primary_key_or_unique_or_generic_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_constraint([NotNull] PlSqlParser.Add_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_constraint([NotNull] PlSqlParser.Add_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.add_constraint_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_constraint_clause([NotNull] PlSqlParser.Add_constraint_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.add_constraint_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_constraint_clause([NotNull] PlSqlParser.Add_constraint_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.check_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheck_constraint([NotNull] PlSqlParser.Check_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.check_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheck_constraint([NotNull] PlSqlParser.Check_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.drop_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrop_constraint([NotNull] PlSqlParser.Drop_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.drop_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrop_constraint([NotNull] PlSqlParser.Drop_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.enable_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnable_constraint([NotNull] PlSqlParser.Enable_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.enable_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnable_constraint([NotNull] PlSqlParser.Enable_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.disable_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDisable_constraint([NotNull] PlSqlParser.Disable_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.disable_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDisable_constraint([NotNull] PlSqlParser.Disable_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeign_key_clause([NotNull] PlSqlParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.foreign_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeign_key_clause([NotNull] PlSqlParser.Foreign_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.references_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferences_clause([NotNull] PlSqlParser.References_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.references_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferences_clause([NotNull] PlSqlParser.References_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.on_delete_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOn_delete_clause([NotNull] PlSqlParser.On_delete_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.on_delete_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOn_delete_clause([NotNull] PlSqlParser.On_delete_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unique_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnique_key_clause([NotNull] PlSqlParser.Unique_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unique_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnique_key_clause([NotNull] PlSqlParser.Unique_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.primary_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary_key_clause([NotNull] PlSqlParser.Primary_key_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.primary_key_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary_key_clause([NotNull] PlSqlParser.Primary_key_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.anonymous_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymous_block([NotNull] PlSqlParser.Anonymous_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.anonymous_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymous_block([NotNull] PlSqlParser.Anonymous_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.invoker_rights_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInvoker_rights_clause([NotNull] PlSqlParser.Invoker_rights_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.invoker_rights_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInvoker_rights_clause([NotNull] PlSqlParser.Invoker_rights_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.call_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCall_spec([NotNull] PlSqlParser.Call_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.call_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCall_spec([NotNull] PlSqlParser.Call_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.java_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJava_spec([NotNull] PlSqlParser.Java_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.java_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJava_spec([NotNull] PlSqlParser.Java_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_spec([NotNull] PlSqlParser.C_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_spec([NotNull] PlSqlParser.C_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_agent_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_agent_in_clause([NotNull] PlSqlParser.C_agent_in_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_agent_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_agent_in_clause([NotNull] PlSqlParser.C_agent_in_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.c_parameters_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterC_parameters_clause([NotNull] PlSqlParser.C_parameters_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.c_parameters_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitC_parameters_clause([NotNull] PlSqlParser.C_parameters_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter([NotNull] PlSqlParser.ParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter([NotNull] PlSqlParser.ParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.default_value_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefault_value_part([NotNull] PlSqlParser.Default_value_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.default_value_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefault_value_part([NotNull] PlSqlParser.Default_value_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seq_of_declare_specs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeq_of_declare_specs([NotNull] PlSqlParser.Seq_of_declare_specsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seq_of_declare_specs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeq_of_declare_specs([NotNull] PlSqlParser.Seq_of_declare_specsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.declare_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_spec([NotNull] PlSqlParser.Declare_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.declare_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_spec([NotNull] PlSqlParser.Declare_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_declaration([NotNull] PlSqlParser.Variable_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_declaration([NotNull] PlSqlParser.Variable_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subtype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubtype_declaration([NotNull] PlSqlParser.Subtype_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subtype_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubtype_declaration([NotNull] PlSqlParser.Subtype_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_declaration([NotNull] PlSqlParser.Cursor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_declaration([NotNull] PlSqlParser.Cursor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_spec([NotNull] PlSqlParser.Parameter_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_spec([NotNull] PlSqlParser.Parameter_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_declaration([NotNull] PlSqlParser.Exception_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_declaration([NotNull] PlSqlParser.Exception_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pragma_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPragma_declaration([NotNull] PlSqlParser.Pragma_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pragma_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPragma_declaration([NotNull] PlSqlParser.Pragma_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.record_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecord_type_def([NotNull] PlSqlParser.Record_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.record_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecord_type_def([NotNull] PlSqlParser.Record_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.field_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField_spec([NotNull] PlSqlParser.Field_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.field_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField_spec([NotNull] PlSqlParser.Field_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.ref_cursor_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRef_cursor_type_def([NotNull] PlSqlParser.Ref_cursor_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.ref_cursor_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRef_cursor_type_def([NotNull] PlSqlParser.Ref_cursor_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_declaration([NotNull] PlSqlParser.Type_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_declaration([NotNull] PlSqlParser.Type_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_type_def([NotNull] PlSqlParser.Table_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_type_def([NotNull] PlSqlParser.Table_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_indexed_by_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_indexed_by_part([NotNull] PlSqlParser.Table_indexed_by_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_indexed_by_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_indexed_by_part([NotNull] PlSqlParser.Table_indexed_by_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.varray_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarray_type_def([NotNull] PlSqlParser.Varray_type_defContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.varray_type_def"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarray_type_def([NotNull] PlSqlParser.Varray_type_defContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seq_of_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeq_of_statements([NotNull] PlSqlParser.Seq_of_statementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seq_of_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeq_of_statements([NotNull] PlSqlParser.Seq_of_statementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.label_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel_declaration([NotNull] PlSqlParser.Label_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.label_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel_declaration([NotNull] PlSqlParser.Label_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] PlSqlParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] PlSqlParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.swallow_to_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwallow_to_semi([NotNull] PlSqlParser.Swallow_to_semiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.swallow_to_semi"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwallow_to_semi([NotNull] PlSqlParser.Swallow_to_semiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.assignment_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment_statement([NotNull] PlSqlParser.Assignment_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.assignment_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment_statement([NotNull] PlSqlParser.Assignment_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.continue_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinue_statement([NotNull] PlSqlParser.Continue_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.continue_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinue_statement([NotNull] PlSqlParser.Continue_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExit_statement([NotNull] PlSqlParser.Exit_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExit_statement([NotNull] PlSqlParser.Exit_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.goto_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGoto_statement([NotNull] PlSqlParser.Goto_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.goto_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGoto_statement([NotNull] PlSqlParser.Goto_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_statement([NotNull] PlSqlParser.If_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_statement([NotNull] PlSqlParser.If_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.elsif_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElsif_part([NotNull] PlSqlParser.Elsif_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.elsif_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElsif_part([NotNull] PlSqlParser.Elsif_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElse_part([NotNull] PlSqlParser.Else_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElse_part([NotNull] PlSqlParser.Else_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.loop_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoop_statement([NotNull] PlSqlParser.Loop_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.loop_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoop_statement([NotNull] PlSqlParser.Loop_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_loop_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_loop_param([NotNull] PlSqlParser.Cursor_loop_paramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_loop_param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_loop_param([NotNull] PlSqlParser.Cursor_loop_paramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.forall_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForall_statement([NotNull] PlSqlParser.Forall_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.forall_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForall_statement([NotNull] PlSqlParser.Forall_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bounds_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBounds_clause([NotNull] PlSqlParser.Bounds_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bounds_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBounds_clause([NotNull] PlSqlParser.Bounds_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.between_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBetween_bound([NotNull] PlSqlParser.Between_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.between_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBetween_bound([NotNull] PlSqlParser.Between_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lower_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLower_bound([NotNull] PlSqlParser.Lower_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lower_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLower_bound([NotNull] PlSqlParser.Lower_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.upper_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpper_bound([NotNull] PlSqlParser.Upper_boundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.upper_bound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpper_bound([NotNull] PlSqlParser.Upper_boundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull_statement([NotNull] PlSqlParser.Null_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.null_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull_statement([NotNull] PlSqlParser.Null_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.raise_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRaise_statement([NotNull] PlSqlParser.Raise_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.raise_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRaise_statement([NotNull] PlSqlParser.Raise_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_statement([NotNull] PlSqlParser.Return_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.return_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_statement([NotNull] PlSqlParser.Return_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_call([NotNull] PlSqlParser.Function_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_call([NotNull] PlSqlParser.Function_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_call([NotNull] PlSqlParser.Procedure_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_call([NotNull] PlSqlParser.Procedure_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pipe_row_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPipe_row_statement([NotNull] PlSqlParser.Pipe_row_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pipe_row_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPipe_row_statement([NotNull] PlSqlParser.Pipe_row_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBody([NotNull] PlSqlParser.BodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBody([NotNull] PlSqlParser.BodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_handler([NotNull] PlSqlParser.Exception_handlerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_handler([NotNull] PlSqlParser.Exception_handlerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_block([NotNull] PlSqlParser.Trigger_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_block([NotNull] PlSqlParser.Trigger_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] PlSqlParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] PlSqlParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_statement([NotNull] PlSqlParser.Sql_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_statement([NotNull] PlSqlParser.Sql_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.execute_immediate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecute_immediate([NotNull] PlSqlParser.Execute_immediateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.execute_immediate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecute_immediate([NotNull] PlSqlParser.Execute_immediateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dynamic_returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDynamic_returning_clause([NotNull] PlSqlParser.Dynamic_returning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dynamic_returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDynamic_returning_clause([NotNull] PlSqlParser.Dynamic_returning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.data_manipulation_language_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterData_manipulation_language_statements([NotNull] PlSqlParser.Data_manipulation_language_statementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.data_manipulation_language_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitData_manipulation_language_statements([NotNull] PlSqlParser.Data_manipulation_language_statementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_manipulation_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_manipulation_statements([NotNull] PlSqlParser.Cursor_manipulation_statementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_manipulation_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_manipulation_statements([NotNull] PlSqlParser.Cursor_manipulation_statementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.close_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClose_statement([NotNull] PlSqlParser.Close_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.close_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClose_statement([NotNull] PlSqlParser.Close_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.open_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen_statement([NotNull] PlSqlParser.Open_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.open_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen_statement([NotNull] PlSqlParser.Open_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.fetch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFetch_statement([NotNull] PlSqlParser.Fetch_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.fetch_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFetch_statement([NotNull] PlSqlParser.Fetch_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.open_for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpen_for_statement([NotNull] PlSqlParser.Open_for_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.open_for_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpen_for_statement([NotNull] PlSqlParser.Open_for_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.transaction_control_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransaction_control_statements([NotNull] PlSqlParser.Transaction_control_statementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.transaction_control_statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransaction_control_statements([NotNull] PlSqlParser.Transaction_control_statementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_transaction_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_transaction_command([NotNull] PlSqlParser.Set_transaction_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_transaction_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_transaction_command([NotNull] PlSqlParser.Set_transaction_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_constraint_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_constraint_command([NotNull] PlSqlParser.Set_constraint_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_constraint_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_constraint_command([NotNull] PlSqlParser.Set_constraint_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.commit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommit_statement([NotNull] PlSqlParser.Commit_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.commit_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommit_statement([NotNull] PlSqlParser.Commit_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.write_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWrite_clause([NotNull] PlSqlParser.Write_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.write_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWrite_clause([NotNull] PlSqlParser.Write_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_statement([NotNull] PlSqlParser.Rollback_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_statement([NotNull] PlSqlParser.Rollback_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.savepoint_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_statement([NotNull] PlSqlParser.Savepoint_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.savepoint_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_statement([NotNull] PlSqlParser.Savepoint_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.explain_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplain_statement([NotNull] PlSqlParser.Explain_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.explain_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplain_statement([NotNull] PlSqlParser.Explain_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_only_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_only_statement([NotNull] PlSqlParser.Select_only_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_only_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_only_statement([NotNull] PlSqlParser.Select_only_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_statement([NotNull] PlSqlParser.Select_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_statement([NotNull] PlSqlParser.Select_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_factoring_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_factoring_clause([NotNull] PlSqlParser.Subquery_factoring_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_factoring_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_factoring_clause([NotNull] PlSqlParser.Subquery_factoring_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.factoring_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactoring_element([NotNull] PlSqlParser.Factoring_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.factoring_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactoring_element([NotNull] PlSqlParser.Factoring_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.search_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSearch_clause([NotNull] PlSqlParser.Search_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.search_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSearch_clause([NotNull] PlSqlParser.Search_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cycle_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCycle_clause([NotNull] PlSqlParser.Cycle_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cycle_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCycle_clause([NotNull] PlSqlParser.Cycle_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery([NotNull] PlSqlParser.SubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery([NotNull] PlSqlParser.SubqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_basic_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_basic_elements([NotNull] PlSqlParser.Subquery_basic_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_basic_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_basic_elements([NotNull] PlSqlParser.Subquery_basic_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_operation_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_operation_part([NotNull] PlSqlParser.Subquery_operation_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_operation_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_operation_part([NotNull] PlSqlParser.Subquery_operation_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_block([NotNull] PlSqlParser.Query_blockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_block([NotNull] PlSqlParser.Query_blockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.selected_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelected_list([NotNull] PlSqlParser.Selected_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.selected_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelected_list([NotNull] PlSqlParser.Selected_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_clause([NotNull] PlSqlParser.From_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_clause([NotNull] PlSqlParser.From_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.select_list_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_list_elements([NotNull] PlSqlParser.Select_list_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.select_list_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_list_elements([NotNull] PlSqlParser.Select_list_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref_list([NotNull] PlSqlParser.Table_ref_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref_list([NotNull] PlSqlParser.Table_ref_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref([NotNull] PlSqlParser.Table_refContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref([NotNull] PlSqlParser.Table_refContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_ref_aux"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref_aux([NotNull] PlSqlParser.Table_ref_auxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_ref_aux"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref_aux([NotNull] PlSqlParser.Table_ref_auxContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_one</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref_aux_internal_one([NotNull] PlSqlParser.Table_ref_aux_internal_oneContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_one</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref_aux_internal_one([NotNull] PlSqlParser.Table_ref_aux_internal_oneContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_two</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref_aux_internal_two([NotNull] PlSqlParser.Table_ref_aux_internal_twoContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_two</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref_aux_internal_two([NotNull] PlSqlParser.Table_ref_aux_internal_twoContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>table_ref_aux_internal_three</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_ref_aux_internal_three([NotNull] PlSqlParser.Table_ref_aux_internal_threeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>table_ref_aux_internal_three</c>
	/// labeled alternative in <see cref="PlSqlParser.table_ref_aux_internal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_ref_aux_internal_three([NotNull] PlSqlParser.Table_ref_aux_internal_threeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_clause([NotNull] PlSqlParser.Join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_clause([NotNull] PlSqlParser.Join_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_on_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_on_part([NotNull] PlSqlParser.Join_on_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_on_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_on_part([NotNull] PlSqlParser.Join_on_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.join_using_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoin_using_part([NotNull] PlSqlParser.Join_using_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.join_using_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoin_using_part([NotNull] PlSqlParser.Join_using_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.outer_join_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOuter_join_type([NotNull] PlSqlParser.Outer_join_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.outer_join_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOuter_join_type([NotNull] PlSqlParser.Outer_join_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_partition_clause([NotNull] PlSqlParser.Query_partition_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_partition_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_partition_clause([NotNull] PlSqlParser.Query_partition_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.flashback_query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlashback_query_clause([NotNull] PlSqlParser.Flashback_query_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.flashback_query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlashback_query_clause([NotNull] PlSqlParser.Flashback_query_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_clause([NotNull] PlSqlParser.Pivot_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_clause([NotNull] PlSqlParser.Pivot_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_element([NotNull] PlSqlParser.Pivot_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_element([NotNull] PlSqlParser.Pivot_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_for_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_for_clause([NotNull] PlSqlParser.Pivot_for_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_for_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_for_clause([NotNull] PlSqlParser.Pivot_for_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_in_clause([NotNull] PlSqlParser.Pivot_in_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_in_clause([NotNull] PlSqlParser.Pivot_in_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_in_clause_element([NotNull] PlSqlParser.Pivot_in_clause_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_in_clause_element([NotNull] PlSqlParser.Pivot_in_clause_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPivot_in_clause_elements([NotNull] PlSqlParser.Pivot_in_clause_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.pivot_in_clause_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPivot_in_clause_elements([NotNull] PlSqlParser.Pivot_in_clause_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnpivot_clause([NotNull] PlSqlParser.Unpivot_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnpivot_clause([NotNull] PlSqlParser.Unpivot_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnpivot_in_clause([NotNull] PlSqlParser.Unpivot_in_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_in_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnpivot_in_clause([NotNull] PlSqlParser.Unpivot_in_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unpivot_in_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnpivot_in_elements([NotNull] PlSqlParser.Unpivot_in_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unpivot_in_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnpivot_in_elements([NotNull] PlSqlParser.Unpivot_in_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.hierarchical_query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHierarchical_query_clause([NotNull] PlSqlParser.Hierarchical_query_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.hierarchical_query_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHierarchical_query_clause([NotNull] PlSqlParser.Hierarchical_query_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.start_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStart_part([NotNull] PlSqlParser.Start_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.start_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStart_part([NotNull] PlSqlParser.Start_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.group_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_by_clause([NotNull] PlSqlParser.Group_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.group_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_by_clause([NotNull] PlSqlParser.Group_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.group_by_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup_by_elements([NotNull] PlSqlParser.Group_by_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.group_by_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup_by_elements([NotNull] PlSqlParser.Group_by_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollup_cube_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollup_cube_clause([NotNull] PlSqlParser.Rollup_cube_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollup_cube_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollup_cube_clause([NotNull] PlSqlParser.Rollup_cube_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grouping_sets_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrouping_sets_clause([NotNull] PlSqlParser.Grouping_sets_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grouping_sets_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrouping_sets_clause([NotNull] PlSqlParser.Grouping_sets_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grouping_sets_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrouping_sets_elements([NotNull] PlSqlParser.Grouping_sets_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grouping_sets_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrouping_sets_elements([NotNull] PlSqlParser.Grouping_sets_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.having_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHaving_clause([NotNull] PlSqlParser.Having_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.having_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHaving_clause([NotNull] PlSqlParser.Having_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_clause([NotNull] PlSqlParser.Model_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_clause([NotNull] PlSqlParser.Model_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cell_reference_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCell_reference_options([NotNull] PlSqlParser.Cell_reference_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cell_reference_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCell_reference_options([NotNull] PlSqlParser.Cell_reference_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.return_rows_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_rows_clause([NotNull] PlSqlParser.Return_rows_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.return_rows_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_rows_clause([NotNull] PlSqlParser.Return_rows_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_model"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference_model([NotNull] PlSqlParser.Reference_modelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_model"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference_model([NotNull] PlSqlParser.Reference_modelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.main_model"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMain_model([NotNull] PlSqlParser.Main_modelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.main_model"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMain_model([NotNull] PlSqlParser.Main_modelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_column_clauses([NotNull] PlSqlParser.Model_column_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_column_clauses([NotNull] PlSqlParser.Model_column_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_partition_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_column_partition_part([NotNull] PlSqlParser.Model_column_partition_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_partition_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_column_partition_part([NotNull] PlSqlParser.Model_column_partition_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_column_list([NotNull] PlSqlParser.Model_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_column_list([NotNull] PlSqlParser.Model_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_column([NotNull] PlSqlParser.Model_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_column([NotNull] PlSqlParser.Model_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_rules_clause([NotNull] PlSqlParser.Model_rules_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_rules_clause([NotNull] PlSqlParser.Model_rules_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_rules_part([NotNull] PlSqlParser.Model_rules_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_rules_part([NotNull] PlSqlParser.Model_rules_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_rules_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_rules_element([NotNull] PlSqlParser.Model_rules_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_rules_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_rules_element([NotNull] PlSqlParser.Model_rules_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cell_assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCell_assignment([NotNull] PlSqlParser.Cell_assignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cell_assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCell_assignment([NotNull] PlSqlParser.Cell_assignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_iterate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_iterate_clause([NotNull] PlSqlParser.Model_iterate_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_iterate_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_iterate_clause([NotNull] PlSqlParser.Model_iterate_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.until_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUntil_part([NotNull] PlSqlParser.Until_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.until_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUntil_part([NotNull] PlSqlParser.Until_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_clause([NotNull] PlSqlParser.Order_by_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.order_by_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_clause([NotNull] PlSqlParser.Order_by_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.order_by_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrder_by_elements([NotNull] PlSqlParser.Order_by_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.order_by_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrder_by_elements([NotNull] PlSqlParser.Order_by_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.offset_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOffset_clause([NotNull] PlSqlParser.Offset_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.offset_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOffset_clause([NotNull] PlSqlParser.Offset_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.fetch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFetch_clause([NotNull] PlSqlParser.Fetch_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.fetch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFetch_clause([NotNull] PlSqlParser.Fetch_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_update_clause([NotNull] PlSqlParser.For_update_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_update_clause([NotNull] PlSqlParser.For_update_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_of_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_update_of_part([NotNull] PlSqlParser.For_update_of_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_of_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_update_of_part([NotNull] PlSqlParser.For_update_of_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.for_update_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_update_options([NotNull] PlSqlParser.For_update_optionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.for_update_options"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_update_options([NotNull] PlSqlParser.For_update_optionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_statement([NotNull] PlSqlParser.Update_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_statement([NotNull] PlSqlParser.Update_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.update_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdate_set_clause([NotNull] PlSqlParser.Update_set_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.update_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdate_set_clause([NotNull] PlSqlParser.Update_set_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_based_update_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_based_update_set_clause([NotNull] PlSqlParser.Column_based_update_set_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_based_update_set_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_based_update_set_clause([NotNull] PlSqlParser.Column_based_update_set_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.delete_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelete_statement([NotNull] PlSqlParser.Delete_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.delete_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelete_statement([NotNull] PlSqlParser.Delete_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.insert_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_statement([NotNull] PlSqlParser.Insert_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.insert_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_statement([NotNull] PlSqlParser.Insert_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.single_table_insert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_table_insert([NotNull] PlSqlParser.Single_table_insertContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.single_table_insert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_table_insert([NotNull] PlSqlParser.Single_table_insertContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_table_insert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulti_table_insert([NotNull] PlSqlParser.Multi_table_insertContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_table_insert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulti_table_insert([NotNull] PlSqlParser.Multi_table_insertContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulti_table_element([NotNull] PlSqlParser.Multi_table_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulti_table_element([NotNull] PlSqlParser.Multi_table_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_insert_clause([NotNull] PlSqlParser.Conditional_insert_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_insert_clause([NotNull] PlSqlParser.Conditional_insert_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_insert_when_part([NotNull] PlSqlParser.Conditional_insert_when_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_insert_when_part([NotNull] PlSqlParser.Conditional_insert_when_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.conditional_insert_else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_insert_else_part([NotNull] PlSqlParser.Conditional_insert_else_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.conditional_insert_else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_insert_else_part([NotNull] PlSqlParser.Conditional_insert_else_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.insert_into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsert_into_clause([NotNull] PlSqlParser.Insert_into_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.insert_into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsert_into_clause([NotNull] PlSqlParser.Insert_into_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValues_clause([NotNull] PlSqlParser.Values_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.values_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValues_clause([NotNull] PlSqlParser.Values_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_statement([NotNull] PlSqlParser.Merge_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_statement([NotNull] PlSqlParser.Merge_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_update_clause([NotNull] PlSqlParser.Merge_update_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_update_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_update_clause([NotNull] PlSqlParser.Merge_update_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_element([NotNull] PlSqlParser.Merge_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_element([NotNull] PlSqlParser.Merge_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_update_delete_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_update_delete_part([NotNull] PlSqlParser.Merge_update_delete_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_update_delete_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_update_delete_part([NotNull] PlSqlParser.Merge_update_delete_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.merge_insert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMerge_insert_clause([NotNull] PlSqlParser.Merge_insert_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.merge_insert_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMerge_insert_clause([NotNull] PlSqlParser.Merge_insert_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.selected_tableview"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelected_tableview([NotNull] PlSqlParser.Selected_tableviewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.selected_tableview"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelected_tableview([NotNull] PlSqlParser.Selected_tableviewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_table_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLock_table_statement([NotNull] PlSqlParser.Lock_table_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_table_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLock_table_statement([NotNull] PlSqlParser.Lock_table_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.wait_nowait_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWait_nowait_part([NotNull] PlSqlParser.Wait_nowait_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.wait_nowait_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWait_nowait_part([NotNull] PlSqlParser.Wait_nowait_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLock_table_element([NotNull] PlSqlParser.Lock_table_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLock_table_element([NotNull] PlSqlParser.Lock_table_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.lock_mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLock_mode([NotNull] PlSqlParser.Lock_modeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.lock_mode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLock_mode([NotNull] PlSqlParser.Lock_modeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneral_table_ref([NotNull] PlSqlParser.General_table_refContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_table_ref"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneral_table_ref([NotNull] PlSqlParser.General_table_refContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.static_returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatic_returning_clause([NotNull] PlSqlParser.Static_returning_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.static_returning_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatic_returning_clause([NotNull] PlSqlParser.Static_returning_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_logging_clause([NotNull] PlSqlParser.Error_logging_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_logging_clause([NotNull] PlSqlParser.Error_logging_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_into_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_logging_into_part([NotNull] PlSqlParser.Error_logging_into_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_into_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_logging_into_part([NotNull] PlSqlParser.Error_logging_into_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.error_logging_reject_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterError_logging_reject_part([NotNull] PlSqlParser.Error_logging_reject_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.error_logging_reject_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitError_logging_reject_part([NotNull] PlSqlParser.Error_logging_reject_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dml_table_expression_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDml_table_expression_clause([NotNull] PlSqlParser.Dml_table_expression_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dml_table_expression_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDml_table_expression_clause([NotNull] PlSqlParser.Dml_table_expression_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_collection_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_collection_expression([NotNull] PlSqlParser.Table_collection_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_collection_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_collection_expression([NotNull] PlSqlParser.Table_collection_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.subquery_restriction_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery_restriction_clause([NotNull] PlSqlParser.Subquery_restriction_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.subquery_restriction_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery_restriction_clause([NotNull] PlSqlParser.Subquery_restriction_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sample_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSample_clause([NotNull] PlSqlParser.Sample_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sample_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSample_clause([NotNull] PlSqlParser.Sample_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.seed_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSeed_part([NotNull] PlSqlParser.Seed_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.seed_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSeed_part([NotNull] PlSqlParser.Seed_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] PlSqlParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] PlSqlParser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.json_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJson_condition([NotNull] PlSqlParser.Json_conditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.json_condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJson_condition([NotNull] PlSqlParser.Json_conditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.expressions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressions([NotNull] PlSqlParser.ExpressionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.expressions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressions([NotNull] PlSqlParser.ExpressionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] PlSqlParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] PlSqlParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_expression([NotNull] PlSqlParser.Cursor_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_expression([NotNull] PlSqlParser.Cursor_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logical_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogical_expression([NotNull] PlSqlParser.Logical_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logical_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogical_expression([NotNull] PlSqlParser.Logical_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unary_logical_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_logical_expression([NotNull] PlSqlParser.Unary_logical_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unary_logical_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_logical_expression([NotNull] PlSqlParser.Unary_logical_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.logical_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogical_operation([NotNull] PlSqlParser.Logical_operationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.logical_operation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogical_operation([NotNull] PlSqlParser.Logical_operationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multiset_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiset_expression([NotNull] PlSqlParser.Multiset_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multiset_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiset_expression([NotNull] PlSqlParser.Multiset_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_expression([NotNull] PlSqlParser.Relational_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_expression([NotNull] PlSqlParser.Relational_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.compound_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompound_expression([NotNull] PlSqlParser.Compound_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.compound_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompound_expression([NotNull] PlSqlParser.Compound_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.relational_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_operator([NotNull] PlSqlParser.Relational_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.relational_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_operator([NotNull] PlSqlParser.Relational_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.in_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIn_elements([NotNull] PlSqlParser.In_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.in_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIn_elements([NotNull] PlSqlParser.In_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.between_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBetween_elements([NotNull] PlSqlParser.Between_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.between_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBetween_elements([NotNull] PlSqlParser.Between_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.concatenation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConcatenation([NotNull] PlSqlParser.ConcatenationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.concatenation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConcatenation([NotNull] PlSqlParser.ConcatenationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.interval_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterval_expression([NotNull] PlSqlParser.Interval_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.interval_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterval_expression([NotNull] PlSqlParser.Interval_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_expression([NotNull] PlSqlParser.Model_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_expression([NotNull] PlSqlParser.Model_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.model_expression_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModel_expression_element([NotNull] PlSqlParser.Model_expression_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.model_expression_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModel_expression_element([NotNull] PlSqlParser.Model_expression_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.single_column_for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_column_for_loop([NotNull] PlSqlParser.Single_column_for_loopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.single_column_for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_column_for_loop([NotNull] PlSqlParser.Single_column_for_loopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.multi_column_for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulti_column_for_loop([NotNull] PlSqlParser.Multi_column_for_loopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.multi_column_for_loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulti_column_for_loop([NotNull] PlSqlParser.Multi_column_for_loopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_expression([NotNull] PlSqlParser.Unary_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_expression([NotNull] PlSqlParser.Unary_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_statement([NotNull] PlSqlParser.Case_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_statement([NotNull] PlSqlParser.Case_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_case_statement([NotNull] PlSqlParser.Simple_case_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_case_statement([NotNull] PlSqlParser.Simple_case_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.simple_case_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_case_when_part([NotNull] PlSqlParser.Simple_case_when_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.simple_case_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_case_when_part([NotNull] PlSqlParser.Simple_case_when_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.searched_case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSearched_case_statement([NotNull] PlSqlParser.Searched_case_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.searched_case_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSearched_case_statement([NotNull] PlSqlParser.Searched_case_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.searched_case_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSearched_case_when_part([NotNull] PlSqlParser.Searched_case_when_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.searched_case_when_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSearched_case_when_part([NotNull] PlSqlParser.Searched_case_when_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.case_else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_else_part([NotNull] PlSqlParser.Case_else_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.case_else_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_else_part([NotNull] PlSqlParser.Case_else_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] PlSqlParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] PlSqlParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quantified_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuantified_expression([NotNull] PlSqlParser.Quantified_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quantified_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuantified_expression([NotNull] PlSqlParser.Quantified_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.string_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_function([NotNull] PlSqlParser.String_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.string_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_function([NotNull] PlSqlParser.String_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standard_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStandard_function([NotNull] PlSqlParser.Standard_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standard_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStandard_function([NotNull] PlSqlParser.Standard_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] PlSqlParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] PlSqlParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function_wrapper"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_function_wrapper([NotNull] PlSqlParser.Numeric_function_wrapperContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function_wrapper"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_function_wrapper([NotNull] PlSqlParser.Numeric_function_wrapperContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_function([NotNull] PlSqlParser.Numeric_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_function([NotNull] PlSqlParser.Numeric_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.listagg_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterListagg_overflow_clause([NotNull] PlSqlParser.Listagg_overflow_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.listagg_overflow_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitListagg_overflow_clause([NotNull] PlSqlParser.Listagg_overflow_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.other_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOther_function([NotNull] PlSqlParser.Other_functionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.other_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOther_function([NotNull] PlSqlParser.Other_functionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.over_clause_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause_keyword([NotNull] PlSqlParser.Over_clause_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.over_clause_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause_keyword([NotNull] PlSqlParser.Over_clause_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.within_or_over_clause_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithin_or_over_clause_keyword([NotNull] PlSqlParser.Within_or_over_clause_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.within_or_over_clause_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithin_or_over_clause_keyword([NotNull] PlSqlParser.Within_or_over_clause_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.standard_prediction_function_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStandard_prediction_function_keyword([NotNull] PlSqlParser.Standard_prediction_function_keywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.standard_prediction_function_keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStandard_prediction_function_keyword([NotNull] PlSqlParser.Standard_prediction_function_keywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOver_clause([NotNull] PlSqlParser.Over_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.over_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOver_clause([NotNull] PlSqlParser.Over_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowing_clause([NotNull] PlSqlParser.Windowing_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowing_clause([NotNull] PlSqlParser.Windowing_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowing_type([NotNull] PlSqlParser.Windowing_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowing_type([NotNull] PlSqlParser.Windowing_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.windowing_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowing_elements([NotNull] PlSqlParser.Windowing_elementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.windowing_elements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowing_elements([NotNull] PlSqlParser.Windowing_elementsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_clause([NotNull] PlSqlParser.Using_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_clause([NotNull] PlSqlParser.Using_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.using_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_element([NotNull] PlSqlParser.Using_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.using_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_element([NotNull] PlSqlParser.Using_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collect_order_by_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollect_order_by_part([NotNull] PlSqlParser.Collect_order_by_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collect_order_by_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollect_order_by_part([NotNull] PlSqlParser.Collect_order_by_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.within_or_over_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithin_or_over_part([NotNull] PlSqlParser.Within_or_over_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.within_or_over_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithin_or_over_part([NotNull] PlSqlParser.Within_or_over_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cost_matrix_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCost_matrix_clause([NotNull] PlSqlParser.Cost_matrix_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cost_matrix_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCost_matrix_clause([NotNull] PlSqlParser.Cost_matrix_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_passing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_passing_clause([NotNull] PlSqlParser.Xml_passing_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_passing_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_passing_clause([NotNull] PlSqlParser.Xml_passing_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_attributes_clause([NotNull] PlSqlParser.Xml_attributes_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_attributes_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_attributes_clause([NotNull] PlSqlParser.Xml_attributes_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_namespaces_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_namespaces_clause([NotNull] PlSqlParser.Xml_namespaces_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_namespaces_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_namespaces_clause([NotNull] PlSqlParser.Xml_namespaces_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_table_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_table_column([NotNull] PlSqlParser.Xml_table_columnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_table_column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_table_column([NotNull] PlSqlParser.Xml_table_columnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_general_default_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_general_default_part([NotNull] PlSqlParser.Xml_general_default_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_general_default_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_general_default_part([NotNull] PlSqlParser.Xml_general_default_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_multiuse_expression_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_multiuse_expression_element([NotNull] PlSqlParser.Xml_multiuse_expression_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_multiuse_expression_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_multiuse_expression_element([NotNull] PlSqlParser.Xml_multiuse_expression_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlroot_param_version_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlroot_param_version_part([NotNull] PlSqlParser.Xmlroot_param_version_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlroot_param_version_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlroot_param_version_part([NotNull] PlSqlParser.Xmlroot_param_version_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlroot_param_standalone_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlroot_param_standalone_part([NotNull] PlSqlParser.Xmlroot_param_standalone_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlroot_param_standalone_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlroot_param_standalone_part([NotNull] PlSqlParser.Xmlroot_param_standalone_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_enconding_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlserialize_param_enconding_part([NotNull] PlSqlParser.Xmlserialize_param_enconding_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_enconding_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlserialize_param_enconding_part([NotNull] PlSqlParser.Xmlserialize_param_enconding_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_version_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlserialize_param_version_part([NotNull] PlSqlParser.Xmlserialize_param_version_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_version_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlserialize_param_version_part([NotNull] PlSqlParser.Xmlserialize_param_version_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_ident_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlserialize_param_ident_part([NotNull] PlSqlParser.Xmlserialize_param_ident_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmlserialize_param_ident_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlserialize_param_ident_part([NotNull] PlSqlParser.Xmlserialize_param_ident_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sql_plus_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSql_plus_command([NotNull] PlSqlParser.Sql_plus_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sql_plus_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSql_plus_command([NotNull] PlSqlParser.Sql_plus_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.whenever_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhenever_command([NotNull] PlSqlParser.Whenever_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.whenever_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhenever_command([NotNull] PlSqlParser.Whenever_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.set_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_command([NotNull] PlSqlParser.Set_commandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.set_command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_command([NotNull] PlSqlParser.Set_commandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.partition_extension_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartition_extension_clause([NotNull] PlSqlParser.Partition_extension_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.partition_extension_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartition_extension_clause([NotNull] PlSqlParser.Partition_extension_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_alias([NotNull] PlSqlParser.Column_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_alias([NotNull] PlSqlParser.Column_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_alias([NotNull] PlSqlParser.Table_aliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_alias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_alias([NotNull] PlSqlParser.Table_aliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_clause([NotNull] PlSqlParser.Where_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_clause([NotNull] PlSqlParser.Where_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInto_clause([NotNull] PlSqlParser.Into_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.into_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInto_clause([NotNull] PlSqlParser.Into_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xml_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXml_column_name([NotNull] PlSqlParser.Xml_column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xml_column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXml_column_name([NotNull] PlSqlParser.Xml_column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cost_class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCost_class_name([NotNull] PlSqlParser.Cost_class_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cost_class_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCost_class_name([NotNull] PlSqlParser.Cost_class_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.attribute_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_name([NotNull] PlSqlParser.Attribute_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.attribute_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_name([NotNull] PlSqlParser.Attribute_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepoint_name([NotNull] PlSqlParser.Savepoint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.savepoint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepoint_name([NotNull] PlSqlParser.Savepoint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.rollback_segment_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRollback_segment_name([NotNull] PlSqlParser.Rollback_segment_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.rollback_segment_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRollback_segment_name([NotNull] PlSqlParser.Rollback_segment_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_var_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_var_name([NotNull] PlSqlParser.Table_var_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_var_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_var_name([NotNull] PlSqlParser.Table_var_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_name([NotNull] PlSqlParser.Schema_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.schema_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_name([NotNull] PlSqlParser.Schema_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.routine_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoutine_name([NotNull] PlSqlParser.Routine_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.routine_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoutine_name([NotNull] PlSqlParser.Routine_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.package_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackage_name([NotNull] PlSqlParser.Package_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.package_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackage_name([NotNull] PlSqlParser.Package_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.implementation_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImplementation_type_name([NotNull] PlSqlParser.Implementation_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.implementation_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImplementation_type_name([NotNull] PlSqlParser.Implementation_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.parameter_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_name([NotNull] PlSqlParser.Parameter_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.parameter_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_name([NotNull] PlSqlParser.Parameter_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.reference_model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReference_model_name([NotNull] PlSqlParser.Reference_model_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.reference_model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReference_model_name([NotNull] PlSqlParser.Reference_model_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.main_model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMain_model_name([NotNull] PlSqlParser.Main_model_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.main_model_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMain_model_name([NotNull] PlSqlParser.Main_model_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.container_tableview_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContainer_tableview_name([NotNull] PlSqlParser.Container_tableview_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.container_tableview_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContainer_tableview_name([NotNull] PlSqlParser.Container_tableview_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.aggregate_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAggregate_function_name([NotNull] PlSqlParser.Aggregate_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.aggregate_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAggregate_function_name([NotNull] PlSqlParser.Aggregate_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.query_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_name([NotNull] PlSqlParser.Query_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.query_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_name([NotNull] PlSqlParser.Query_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grantee_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantee_name([NotNull] PlSqlParser.Grantee_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grantee_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantee_name([NotNull] PlSqlParser.Grantee_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.role_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRole_name([NotNull] PlSqlParser.Role_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.role_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRole_name([NotNull] PlSqlParser.Role_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint_name([NotNull] PlSqlParser.Constraint_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constraint_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint_name([NotNull] PlSqlParser.Constraint_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.label_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel_name([NotNull] PlSqlParser.Label_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.label_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel_name([NotNull] PlSqlParser.Label_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_name([NotNull] PlSqlParser.Type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_name([NotNull] PlSqlParser.Type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.sequence_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSequence_name([NotNull] PlSqlParser.Sequence_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.sequence_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSequence_name([NotNull] PlSqlParser.Sequence_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.exception_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_name([NotNull] PlSqlParser.Exception_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.exception_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_name([NotNull] PlSqlParser.Exception_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_name([NotNull] PlSqlParser.Function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_name([NotNull] PlSqlParser.Function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.procedure_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedure_name([NotNull] PlSqlParser.Procedure_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.procedure_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedure_name([NotNull] PlSqlParser.Procedure_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrigger_name([NotNull] PlSqlParser.Trigger_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.trigger_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrigger_name([NotNull] PlSqlParser.Trigger_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.variable_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_name([NotNull] PlSqlParser.Variable_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.variable_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_name([NotNull] PlSqlParser.Variable_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndex_name([NotNull] PlSqlParser.Index_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.index_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndex_name([NotNull] PlSqlParser.Index_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursor_name([NotNull] PlSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.cursor_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursor_name([NotNull] PlSqlParser.Cursor_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.record_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRecord_name([NotNull] PlSqlParser.Record_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.record_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRecord_name([NotNull] PlSqlParser.Record_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.collection_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection_name([NotNull] PlSqlParser.Collection_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.collection_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection_name([NotNull] PlSqlParser.Collection_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.link_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLink_name([NotNull] PlSqlParser.Link_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.link_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLink_name([NotNull] PlSqlParser.Link_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_name([NotNull] PlSqlParser.Column_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_name([NotNull] PlSqlParser.Column_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.tableview_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableview_name([NotNull] PlSqlParser.Tableview_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.tableview_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableview_name([NotNull] PlSqlParser.Tableview_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.xmltable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmltable([NotNull] PlSqlParser.XmltableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.xmltable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmltable([NotNull] PlSqlParser.XmltableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.char_set_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChar_set_name([NotNull] PlSqlParser.Char_set_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.char_set_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChar_set_name([NotNull] PlSqlParser.Char_set_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.synonym_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSynonym_name([NotNull] PlSqlParser.Synonym_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.synonym_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSynonym_name([NotNull] PlSqlParser.Synonym_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.schema_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchema_object_name([NotNull] PlSqlParser.Schema_object_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.schema_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchema_object_name([NotNull] PlSqlParser.Schema_object_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.dir_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDir_object_name([NotNull] PlSqlParser.Dir_object_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.dir_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDir_object_name([NotNull] PlSqlParser.Dir_object_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.user_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser_object_name([NotNull] PlSqlParser.User_object_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.user_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser_object_name([NotNull] PlSqlParser.User_object_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.grant_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrant_object_name([NotNull] PlSqlParser.Grant_object_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.grant_object_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrant_object_name([NotNull] PlSqlParser.Grant_object_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumn_list([NotNull] PlSqlParser.Column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumn_list([NotNull] PlSqlParser.Column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.paren_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParen_column_list([NotNull] PlSqlParser.Paren_column_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.paren_column_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParen_column_list([NotNull] PlSqlParser.Paren_column_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.keep_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeep_clause([NotNull] PlSqlParser.Keep_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.keep_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeep_clause([NotNull] PlSqlParser.Keep_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_argument([NotNull] PlSqlParser.Function_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_argument([NotNull] PlSqlParser.Function_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument_analytic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_argument_analytic([NotNull] PlSqlParser.Function_argument_analyticContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument_analytic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_argument_analytic([NotNull] PlSqlParser.Function_argument_analyticContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.function_argument_modeling"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction_argument_modeling([NotNull] PlSqlParser.Function_argument_modelingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.function_argument_modeling"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction_argument_modeling([NotNull] PlSqlParser.Function_argument_modelingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.respect_or_ignore_nulls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRespect_or_ignore_nulls([NotNull] PlSqlParser.Respect_or_ignore_nullsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.respect_or_ignore_nulls"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRespect_or_ignore_nulls([NotNull] PlSqlParser.Respect_or_ignore_nullsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument([NotNull] PlSqlParser.ArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument([NotNull] PlSqlParser.ArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.type_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_spec([NotNull] PlSqlParser.Type_specContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.type_spec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_spec([NotNull] PlSqlParser.Type_specContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDatatype([NotNull] PlSqlParser.DatatypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.datatype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDatatype([NotNull] PlSqlParser.DatatypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.precision_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrecision_part([NotNull] PlSqlParser.Precision_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.precision_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrecision_part([NotNull] PlSqlParser.Precision_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.native_datatype_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNative_datatype_element([NotNull] PlSqlParser.Native_datatype_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.native_datatype_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNative_datatype_element([NotNull] PlSqlParser.Native_datatype_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.bind_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBind_variable([NotNull] PlSqlParser.Bind_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.bind_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBind_variable([NotNull] PlSqlParser.Bind_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneral_element([NotNull] PlSqlParser.General_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneral_element([NotNull] PlSqlParser.General_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.general_element_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneral_element_part([NotNull] PlSqlParser.General_element_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.general_element_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneral_element_part([NotNull] PlSqlParser.General_element_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTable_element([NotNull] PlSqlParser.Table_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.table_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTable_element([NotNull] PlSqlParser.Table_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.object_privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_privilege([NotNull] PlSqlParser.Object_privilegeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.object_privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_privilege([NotNull] PlSqlParser.Object_privilegeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.system_privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSystem_privilege([NotNull] PlSqlParser.System_privilegeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.system_privilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSystem_privilege([NotNull] PlSqlParser.System_privilegeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] PlSqlParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] PlSqlParser.ConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric([NotNull] PlSqlParser.NumericContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric([NotNull] PlSqlParser.NumericContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_negative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_negative([NotNull] PlSqlParser.Numeric_negativeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_negative"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_negative([NotNull] PlSqlParser.Numeric_negativeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.quoted_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuoted_string([NotNull] PlSqlParser.Quoted_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.quoted_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuoted_string([NotNull] PlSqlParser.Quoted_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] PlSqlParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] PlSqlParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.id_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId_expression([NotNull] PlSqlParser.Id_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.id_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId_expression([NotNull] PlSqlParser.Id_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.outer_join_sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOuter_join_sign([NotNull] PlSqlParser.Outer_join_signContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.outer_join_sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOuter_join_sign([NotNull] PlSqlParser.Outer_join_signContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.regular_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRegular_id([NotNull] PlSqlParser.Regular_idContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.regular_id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRegular_id([NotNull] PlSqlParser.Regular_idContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_in_12c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_reserved_keywords_in_12c([NotNull] PlSqlParser.Non_reserved_keywords_in_12cContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_in_12c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_reserved_keywords_in_12c([NotNull] PlSqlParser.Non_reserved_keywords_in_12cContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_pre12c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_reserved_keywords_pre12c([NotNull] PlSqlParser.Non_reserved_keywords_pre12cContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.non_reserved_keywords_pre12c"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_reserved_keywords_pre12c([NotNull] PlSqlParser.Non_reserved_keywords_pre12cContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.string_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_function_name([NotNull] PlSqlParser.String_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.string_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_function_name([NotNull] PlSqlParser.String_function_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="PlSqlParser.numeric_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_function_name([NotNull] PlSqlParser.Numeric_function_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="PlSqlParser.numeric_function_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_function_name([NotNull] PlSqlParser.Numeric_function_nameContext context);
}
