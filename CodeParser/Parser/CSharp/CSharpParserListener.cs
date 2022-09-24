using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CSharpParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ICSharpParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.compilation_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilation_unit([NotNull] CSharpParser.Compilation_unitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.compilation_unit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilation_unit([NotNull] CSharpParser.Compilation_unitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_or_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_or_type_name([NotNull] CSharpParser.Namespace_or_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_or_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_or_type_name([NotNull] CSharpParser.Namespace_or_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_([NotNull] CSharpParser.Type_Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_([NotNull] CSharpParser.Type_Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.base_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBase_type([NotNull] CSharpParser.Base_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.base_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBase_type([NotNull] CSharpParser.Base_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.tuple_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTuple_type([NotNull] CSharpParser.Tuple_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.tuple_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTuple_type([NotNull] CSharpParser.Tuple_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.tuple_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTuple_element([NotNull] CSharpParser.Tuple_elementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.tuple_element"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTuple_element([NotNull] CSharpParser.Tuple_elementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.simple_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimple_type([NotNull] CSharpParser.Simple_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.simple_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimple_type([NotNull] CSharpParser.Simple_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.numeric_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_type([NotNull] CSharpParser.Numeric_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.numeric_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_type([NotNull] CSharpParser.Numeric_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.integral_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegral_type([NotNull] CSharpParser.Integral_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.integral_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegral_type([NotNull] CSharpParser.Integral_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.floating_point_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloating_point_type([NotNull] CSharpParser.Floating_point_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.floating_point_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloating_point_type([NotNull] CSharpParser.Floating_point_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_type([NotNull] CSharpParser.Class_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_type([NotNull] CSharpParser.Class_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_argument_list([NotNull] CSharpParser.Type_argument_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_argument_list([NotNull] CSharpParser.Type_argument_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument_list([NotNull] CSharpParser.Argument_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.argument_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument_list([NotNull] CSharpParser.Argument_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgument([NotNull] CSharpParser.ArgumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgument([NotNull] CSharpParser.ArgumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CSharpParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CSharpParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.non_assignment_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNon_assignment_expression([NotNull] CSharpParser.Non_assignment_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.non_assignment_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNon_assignment_expression([NotNull] CSharpParser.Non_assignment_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] CSharpParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] CSharpParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.assignment_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment_operator([NotNull] CSharpParser.Assignment_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.assignment_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment_operator([NotNull] CSharpParser.Assignment_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_expression([NotNull] CSharpParser.Conditional_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_expression([NotNull] CSharpParser.Conditional_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.null_coalescing_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull_coalescing_expression([NotNull] CSharpParser.Null_coalescing_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.null_coalescing_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull_coalescing_expression([NotNull] CSharpParser.Null_coalescing_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_or_expression([NotNull] CSharpParser.Conditional_or_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_or_expression([NotNull] CSharpParser.Conditional_or_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditional_and_expression([NotNull] CSharpParser.Conditional_and_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditional_and_expression([NotNull] CSharpParser.Conditional_and_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.inclusive_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclusive_or_expression([NotNull] CSharpParser.Inclusive_or_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.inclusive_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclusive_or_expression([NotNull] CSharpParser.Inclusive_or_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.exclusive_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusive_or_expression([NotNull] CSharpParser.Exclusive_or_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.exclusive_or_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusive_or_expression([NotNull] CSharpParser.Exclusive_or_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd_expression([NotNull] CSharpParser.And_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.and_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd_expression([NotNull] CSharpParser.And_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.equality_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquality_expression([NotNull] CSharpParser.Equality_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.equality_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquality_expression([NotNull] CSharpParser.Equality_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.relational_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelational_expression([NotNull] CSharpParser.Relational_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.relational_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelational_expression([NotNull] CSharpParser.Relational_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.shift_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShift_expression([NotNull] CSharpParser.Shift_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.shift_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShift_expression([NotNull] CSharpParser.Shift_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.additive_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditive_expression([NotNull] CSharpParser.Additive_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.additive_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditive_expression([NotNull] CSharpParser.Additive_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.multiplicative_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicative_expression([NotNull] CSharpParser.Multiplicative_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.multiplicative_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicative_expression([NotNull] CSharpParser.Multiplicative_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_expression([NotNull] CSharpParser.Switch_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_expression([NotNull] CSharpParser.Switch_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression_arms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_expression_arms([NotNull] CSharpParser.Switch_expression_armsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression_arms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_expression_arms([NotNull] CSharpParser.Switch_expression_armsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression_arm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_expression_arm([NotNull] CSharpParser.Switch_expression_armContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression_arm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_expression_arm([NotNull] CSharpParser.Switch_expression_armContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.range_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange_expression([NotNull] CSharpParser.Range_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.range_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange_expression([NotNull] CSharpParser.Range_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnary_expression([NotNull] CSharpParser.Unary_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.unary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnary_expression([NotNull] CSharpParser.Unary_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.primary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary_expression([NotNull] CSharpParser.Primary_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.primary_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary_expression([NotNull] CSharpParser.Primary_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>literalExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralExpression([NotNull] CSharpParser.LiteralExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>literalExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralExpression([NotNull] CSharpParser.LiteralExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleNameExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleNameExpression([NotNull] CSharpParser.SimpleNameExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleNameExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleNameExpression([NotNull] CSharpParser.SimpleNameExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExpressions</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenthesisExpressions([NotNull] CSharpParser.ParenthesisExpressionsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExpressions</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenthesisExpressions([NotNull] CSharpParser.ParenthesisExpressionsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>memberAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberAccessExpression([NotNull] CSharpParser.MemberAccessExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>memberAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberAccessExpression([NotNull] CSharpParser.MemberAccessExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>literalAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteralAccessExpression([NotNull] CSharpParser.LiteralAccessExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>literalAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteralAccessExpression([NotNull] CSharpParser.LiteralAccessExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>thisReferenceExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThisReferenceExpression([NotNull] CSharpParser.ThisReferenceExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>thisReferenceExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThisReferenceExpression([NotNull] CSharpParser.ThisReferenceExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>baseAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseAccessExpression([NotNull] CSharpParser.BaseAccessExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>baseAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseAccessExpression([NotNull] CSharpParser.BaseAccessExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>objectCreationExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectCreationExpression([NotNull] CSharpParser.ObjectCreationExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>objectCreationExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectCreationExpression([NotNull] CSharpParser.ObjectCreationExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tupleExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTupleExpression([NotNull] CSharpParser.TupleExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tupleExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTupleExpression([NotNull] CSharpParser.TupleExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>typeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeofExpression([NotNull] CSharpParser.TypeofExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>typeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeofExpression([NotNull] CSharpParser.TypeofExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>checkedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckedExpression([NotNull] CSharpParser.CheckedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>checkedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckedExpression([NotNull] CSharpParser.CheckedExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>uncheckedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUncheckedExpression([NotNull] CSharpParser.UncheckedExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>uncheckedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUncheckedExpression([NotNull] CSharpParser.UncheckedExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>defaultValueExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultValueExpression([NotNull] CSharpParser.DefaultValueExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>defaultValueExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultValueExpression([NotNull] CSharpParser.DefaultValueExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>anonymousMethodExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymousMethodExpression([NotNull] CSharpParser.AnonymousMethodExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>anonymousMethodExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymousMethodExpression([NotNull] CSharpParser.AnonymousMethodExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>sizeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSizeofExpression([NotNull] CSharpParser.SizeofExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sizeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSizeofExpression([NotNull] CSharpParser.SizeofExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>nameofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameofExpression([NotNull] CSharpParser.NameofExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>nameofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameofExpression([NotNull] CSharpParser.NameofExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.throwable_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowable_expression([NotNull] CSharpParser.Throwable_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.throwable_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowable_expression([NotNull] CSharpParser.Throwable_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.throw_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrow_expression([NotNull] CSharpParser.Throw_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.throw_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrow_expression([NotNull] CSharpParser.Throw_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_access"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_access([NotNull] CSharpParser.Member_accessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_access"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_access([NotNull] CSharpParser.Member_accessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.bracket_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracket_expression([NotNull] CSharpParser.Bracket_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.bracket_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracket_expression([NotNull] CSharpParser.Bracket_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.indexer_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexer_argument([NotNull] CSharpParser.Indexer_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.indexer_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexer_argument([NotNull] CSharpParser.Indexer_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.predefined_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredefined_type([NotNull] CSharpParser.Predefined_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.predefined_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredefined_type([NotNull] CSharpParser.Predefined_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression_list([NotNull] CSharpParser.Expression_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expression_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression_list([NotNull] CSharpParser.Expression_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_or_collection_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_or_collection_initializer([NotNull] CSharpParser.Object_or_collection_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_or_collection_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_or_collection_initializer([NotNull] CSharpParser.Object_or_collection_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_initializer([NotNull] CSharpParser.Object_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_initializer([NotNull] CSharpParser.Object_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_initializer_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_initializer_list([NotNull] CSharpParser.Member_initializer_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_initializer_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_initializer_list([NotNull] CSharpParser.Member_initializer_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_initializer([NotNull] CSharpParser.Member_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_initializer([NotNull] CSharpParser.Member_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.initializer_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializer_value([NotNull] CSharpParser.Initializer_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.initializer_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializer_value([NotNull] CSharpParser.Initializer_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.collection_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollection_initializer([NotNull] CSharpParser.Collection_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.collection_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollection_initializer([NotNull] CSharpParser.Collection_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.element_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElement_initializer([NotNull] CSharpParser.Element_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.element_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElement_initializer([NotNull] CSharpParser.Element_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_object_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymous_object_initializer([NotNull] CSharpParser.Anonymous_object_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_object_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymous_object_initializer([NotNull] CSharpParser.Anonymous_object_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_declarator_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_declarator_list([NotNull] CSharpParser.Member_declarator_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_declarator_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_declarator_list([NotNull] CSharpParser.Member_declarator_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_declarator([NotNull] CSharpParser.Member_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_declarator([NotNull] CSharpParser.Member_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.unbound_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnbound_type_name([NotNull] CSharpParser.Unbound_type_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.unbound_type_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnbound_type_name([NotNull] CSharpParser.Unbound_type_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.generic_dimension_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneric_dimension_specifier([NotNull] CSharpParser.Generic_dimension_specifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.generic_dimension_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneric_dimension_specifier([NotNull] CSharpParser.Generic_dimension_specifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIsType([NotNull] CSharpParser.IsTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIsType([NotNull] CSharpParser.IsTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isTypePatternArms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIsTypePatternArms([NotNull] CSharpParser.IsTypePatternArmsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isTypePatternArms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIsTypePatternArms([NotNull] CSharpParser.IsTypePatternArmsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isTypePatternArm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIsTypePatternArm([NotNull] CSharpParser.IsTypePatternArmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isTypePatternArm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIsTypePatternArm([NotNull] CSharpParser.IsTypePatternArmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.lambda_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambda_expression([NotNull] CSharpParser.Lambda_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.lambda_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambda_expression([NotNull] CSharpParser.Lambda_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_function_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymous_function_signature([NotNull] CSharpParser.Anonymous_function_signatureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_function_signature"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymous_function_signature([NotNull] CSharpParser.Anonymous_function_signatureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Explicit_anonymous_function_parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Explicit_anonymous_function_parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicit_anonymous_function_parameter([NotNull] CSharpParser.Explicit_anonymous_function_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicit_anonymous_function_parameter([NotNull] CSharpParser.Explicit_anonymous_function_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.implicit_anonymous_function_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Implicit_anonymous_function_parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.implicit_anonymous_function_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Implicit_anonymous_function_parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnonymous_function_body([NotNull] CSharpParser.Anonymous_function_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnonymous_function_body([NotNull] CSharpParser.Anonymous_function_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_expression([NotNull] CSharpParser.Query_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_expression([NotNull] CSharpParser.Query_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFrom_clause([NotNull] CSharpParser.From_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.from_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFrom_clause([NotNull] CSharpParser.From_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_body([NotNull] CSharpParser.Query_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_body([NotNull] CSharpParser.Query_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_body_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_body_clause([NotNull] CSharpParser.Query_body_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_body_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_body_clause([NotNull] CSharpParser.Query_body_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.let_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLet_clause([NotNull] CSharpParser.Let_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.let_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLet_clause([NotNull] CSharpParser.Let_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhere_clause([NotNull] CSharpParser.Where_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.where_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhere_clause([NotNull] CSharpParser.Where_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.combined_join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCombined_join_clause([NotNull] CSharpParser.Combined_join_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.combined_join_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCombined_join_clause([NotNull] CSharpParser.Combined_join_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.orderby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderby_clause([NotNull] CSharpParser.Orderby_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.orderby_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderby_clause([NotNull] CSharpParser.Orderby_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.ordering"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrdering([NotNull] CSharpParser.OrderingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.ordering"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrdering([NotNull] CSharpParser.OrderingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.select_or_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelect_or_group_clause([NotNull] CSharpParser.Select_or_group_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.select_or_group_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelect_or_group_clause([NotNull] CSharpParser.Select_or_group_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_continuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery_continuation([NotNull] CSharpParser.Query_continuationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_continuation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery_continuation([NotNull] CSharpParser.Query_continuationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CSharpParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CSharpParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.declarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationStatement([NotNull] CSharpParser.DeclarationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.declarationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationStatement([NotNull] CSharpParser.DeclarationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_function_declaration([NotNull] CSharpParser.Local_function_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_function_declaration([NotNull] CSharpParser.Local_function_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_header"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_function_header([NotNull] CSharpParser.Local_function_headerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_header"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_function_header([NotNull] CSharpParser.Local_function_headerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_function_modifiers([NotNull] CSharpParser.Local_function_modifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_function_modifiers([NotNull] CSharpParser.Local_function_modifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_function_body([NotNull] CSharpParser.Local_function_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_function_body([NotNull] CSharpParser.Local_function_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.labeled_Statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeled_Statement([NotNull] CSharpParser.Labeled_StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.labeled_Statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeled_Statement([NotNull] CSharpParser.Labeled_StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmbedded_statement([NotNull] CSharpParser.Embedded_statementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmbedded_statement([NotNull] CSharpParser.Embedded_statementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>theEmptyStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTheEmptyStatement([NotNull] CSharpParser.TheEmptyStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>theEmptyStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTheEmptyStatement([NotNull] CSharpParser.TheEmptyStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] CSharpParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] CSharpParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>switchStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitchStatement([NotNull] CSharpParser.SwitchStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>switchStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitchStatement([NotNull] CSharpParser.SwitchStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] CSharpParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] CSharpParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>doStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoStatement([NotNull] CSharpParser.DoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>doStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoStatement([NotNull] CSharpParser.DoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>forStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] CSharpParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>forStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] CSharpParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>foreachStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForeachStatement([NotNull] CSharpParser.ForeachStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>foreachStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForeachStatement([NotNull] CSharpParser.ForeachStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>breakStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBreakStatement([NotNull] CSharpParser.BreakStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>breakStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBreakStatement([NotNull] CSharpParser.BreakStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>continueStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterContinueStatement([NotNull] CSharpParser.ContinueStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>continueStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitContinueStatement([NotNull] CSharpParser.ContinueStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>gotoStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGotoStatement([NotNull] CSharpParser.GotoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>gotoStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGotoStatement([NotNull] CSharpParser.GotoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>returnStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] CSharpParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>returnStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] CSharpParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>throwStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowStatement([NotNull] CSharpParser.ThrowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>throwStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowStatement([NotNull] CSharpParser.ThrowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>tryStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryStatement([NotNull] CSharpParser.TryStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>tryStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryStatement([NotNull] CSharpParser.TryStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>checkedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckedStatement([NotNull] CSharpParser.CheckedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>checkedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckedStatement([NotNull] CSharpParser.CheckedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>uncheckedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUncheckedStatement([NotNull] CSharpParser.UncheckedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>uncheckedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUncheckedStatement([NotNull] CSharpParser.UncheckedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lockStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockStatement([NotNull] CSharpParser.LockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lockStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockStatement([NotNull] CSharpParser.LockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>usingStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingStatement([NotNull] CSharpParser.UsingStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>usingStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingStatement([NotNull] CSharpParser.UsingStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>yieldStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterYieldStatement([NotNull] CSharpParser.YieldStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>yieldStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitYieldStatement([NotNull] CSharpParser.YieldStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>unsafeStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnsafeStatement([NotNull] CSharpParser.UnsafeStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unsafeStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnsafeStatement([NotNull] CSharpParser.UnsafeStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>fixedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixedStatement([NotNull] CSharpParser.FixedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fixedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixedStatement([NotNull] CSharpParser.FixedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] CSharpParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] CSharpParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_variable_declaration([NotNull] CSharpParser.Local_variable_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_variable_declaration([NotNull] CSharpParser.Local_variable_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_variable_type([NotNull] CSharpParser.Local_variable_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_variable_type([NotNull] CSharpParser.Local_variable_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_variable_declarator([NotNull] CSharpParser.Local_variable_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_variable_declarator([NotNull] CSharpParser.Local_variable_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_variable_initializer([NotNull] CSharpParser.Local_variable_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_variable_initializer([NotNull] CSharpParser.Local_variable_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocal_constant_declaration([NotNull] CSharpParser.Local_constant_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocal_constant_declaration([NotNull] CSharpParser.Local_constant_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.if_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIf_body([NotNull] CSharpParser.If_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.if_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIf_body([NotNull] CSharpParser.If_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_section([NotNull] CSharpParser.Switch_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_section([NotNull] CSharpParser.Switch_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSwitch_label([NotNull] CSharpParser.Switch_labelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSwitch_label([NotNull] CSharpParser.Switch_labelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.case_guard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCase_guard([NotNull] CSharpParser.Case_guardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.case_guard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCase_guard([NotNull] CSharpParser.Case_guardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.statement_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement_list([NotNull] CSharpParser.Statement_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.statement_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement_list([NotNull] CSharpParser.Statement_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.for_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_initializer([NotNull] CSharpParser.For_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.for_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_initializer([NotNull] CSharpParser.For_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.for_iterator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFor_iterator([NotNull] CSharpParser.For_iteratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.for_iterator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFor_iterator([NotNull] CSharpParser.For_iteratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.catch_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCatch_clauses([NotNull] CSharpParser.Catch_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.catch_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCatch_clauses([NotNull] CSharpParser.Catch_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.specific_catch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecific_catch_clause([NotNull] CSharpParser.Specific_catch_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.specific_catch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecific_catch_clause([NotNull] CSharpParser.Specific_catch_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.general_catch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeneral_catch_clause([NotNull] CSharpParser.General_catch_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.general_catch_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeneral_catch_clause([NotNull] CSharpParser.General_catch_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.exception_filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterException_filter([NotNull] CSharpParser.Exception_filterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.exception_filter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitException_filter([NotNull] CSharpParser.Exception_filterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.finally_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFinally_clause([NotNull] CSharpParser.Finally_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.finally_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFinally_clause([NotNull] CSharpParser.Finally_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.resource_acquisition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResource_acquisition([NotNull] CSharpParser.Resource_acquisitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.resource_acquisition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResource_acquisition([NotNull] CSharpParser.Resource_acquisitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_declaration([NotNull] CSharpParser.Namespace_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_declaration([NotNull] CSharpParser.Namespace_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.qualified_identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_identifier([NotNull] CSharpParser.Qualified_identifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.qualified_identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_identifier([NotNull] CSharpParser.Qualified_identifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_body([NotNull] CSharpParser.Namespace_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_body([NotNull] CSharpParser.Namespace_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.extern_alias_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtern_alias_directives([NotNull] CSharpParser.Extern_alias_directivesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.extern_alias_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtern_alias_directives([NotNull] CSharpParser.Extern_alias_directivesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.extern_alias_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtern_alias_directive([NotNull] CSharpParser.Extern_alias_directiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.extern_alias_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtern_alias_directive([NotNull] CSharpParser.Extern_alias_directiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.using_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsing_directives([NotNull] CSharpParser.Using_directivesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.using_directives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsing_directives([NotNull] CSharpParser.Using_directivesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>usingAliasDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingAliasDirective([NotNull] CSharpParser.UsingAliasDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>usingAliasDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingAliasDirective([NotNull] CSharpParser.UsingAliasDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>usingNamespaceDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingNamespaceDirective([NotNull] CSharpParser.UsingNamespaceDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>usingNamespaceDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingNamespaceDirective([NotNull] CSharpParser.UsingNamespaceDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>usingStaticDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingStaticDirective([NotNull] CSharpParser.UsingStaticDirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>usingStaticDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingStaticDirective([NotNull] CSharpParser.UsingStaticDirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_member_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_member_declarations([NotNull] CSharpParser.Namespace_member_declarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_member_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_member_declarations([NotNull] CSharpParser.Namespace_member_declarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespace_member_declaration([NotNull] CSharpParser.Namespace_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespace_member_declaration([NotNull] CSharpParser.Namespace_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_declaration([NotNull] CSharpParser.Type_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_declaration([NotNull] CSharpParser.Type_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.qualified_alias_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualified_alias_member([NotNull] CSharpParser.Qualified_alias_memberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.qualified_alias_member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualified_alias_member([NotNull] CSharpParser.Qualified_alias_memberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_parameter_list([NotNull] CSharpParser.Type_parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_parameter_list([NotNull] CSharpParser.Type_parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_parameter([NotNull] CSharpParser.Type_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_parameter([NotNull] CSharpParser.Type_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_base([NotNull] CSharpParser.Class_baseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_base([NotNull] CSharpParser.Class_baseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_type_list([NotNull] CSharpParser.Interface_type_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_type_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_type_list([NotNull] CSharpParser.Interface_type_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_parameter_constraints_clauses([NotNull] CSharpParser.Type_parameter_constraints_clausesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clauses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_parameter_constraints_clauses([NotNull] CSharpParser.Type_parameter_constraints_clausesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_parameter_constraints_clause([NotNull] CSharpParser.Type_parameter_constraints_clauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_parameter_constraints_clause([NotNull] CSharpParser.Type_parameter_constraints_clauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType_parameter_constraints([NotNull] CSharpParser.Type_parameter_constraintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType_parameter_constraints([NotNull] CSharpParser.Type_parameter_constraintsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.primary_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary_constraint([NotNull] CSharpParser.Primary_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.primary_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary_constraint([NotNull] CSharpParser.Primary_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.secondary_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSecondary_constraints([NotNull] CSharpParser.Secondary_constraintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.secondary_constraints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSecondary_constraints([NotNull] CSharpParser.Secondary_constraintsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor_constraint([NotNull] CSharpParser.Constructor_constraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor_constraint([NotNull] CSharpParser.Constructor_constraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_body([NotNull] CSharpParser.Class_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_body([NotNull] CSharpParser.Class_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_member_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_member_declarations([NotNull] CSharpParser.Class_member_declarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_member_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_member_declarations([NotNull] CSharpParser.Class_member_declarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_member_declaration([NotNull] CSharpParser.Class_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_member_declaration([NotNull] CSharpParser.Class_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.all_member_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAll_member_modifiers([NotNull] CSharpParser.All_member_modifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.all_member_modifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAll_member_modifiers([NotNull] CSharpParser.All_member_modifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.all_member_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAll_member_modifier([NotNull] CSharpParser.All_member_modifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.all_member_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAll_member_modifier([NotNull] CSharpParser.All_member_modifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.common_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommon_member_declaration([NotNull] CSharpParser.Common_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.common_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommon_member_declaration([NotNull] CSharpParser.Common_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.typed_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTyped_member_declaration([NotNull] CSharpParser.Typed_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.typed_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTyped_member_declaration([NotNull] CSharpParser.Typed_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_declarators([NotNull] CSharpParser.Constant_declaratorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_declarators([NotNull] CSharpParser.Constant_declaratorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_declarator([NotNull] CSharpParser.Constant_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_declarator([NotNull] CSharpParser.Constant_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_declarators([NotNull] CSharpParser.Variable_declaratorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_declarators([NotNull] CSharpParser.Variable_declaratorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_declarator([NotNull] CSharpParser.Variable_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_declarator([NotNull] CSharpParser.Variable_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_initializer([NotNull] CSharpParser.Variable_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_initializer([NotNull] CSharpParser.Variable_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.return_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturn_type([NotNull] CSharpParser.Return_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.return_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturn_type([NotNull] CSharpParser.Return_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMember_name([NotNull] CSharpParser.Member_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMember_name([NotNull] CSharpParser.Member_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_body([NotNull] CSharpParser.Method_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_body([NotNull] CSharpParser.Method_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.formal_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormal_parameter_list([NotNull] CSharpParser.Formal_parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.formal_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormal_parameter_list([NotNull] CSharpParser.Formal_parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_parameters([NotNull] CSharpParser.Fixed_parametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_parameters([NotNull] CSharpParser.Fixed_parametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_parameter([NotNull] CSharpParser.Fixed_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_parameter([NotNull] CSharpParser.Fixed_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameter_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_modifier([NotNull] CSharpParser.Parameter_modifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameter_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_modifier([NotNull] CSharpParser.Parameter_modifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameter_array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameter_array([NotNull] CSharpParser.Parameter_arrayContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameter_array"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameter_array([NotNull] CSharpParser.Parameter_arrayContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessor_declarations([NotNull] CSharpParser.Accessor_declarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessor_declarations([NotNull] CSharpParser.Accessor_declarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.get_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGet_accessor_declaration([NotNull] CSharpParser.Get_accessor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.get_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGet_accessor_declaration([NotNull] CSharpParser.Get_accessor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.set_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_accessor_declaration([NotNull] CSharpParser.Set_accessor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.set_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_accessor_declaration([NotNull] CSharpParser.Set_accessor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessor_modifier([NotNull] CSharpParser.Accessor_modifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessor_modifier([NotNull] CSharpParser.Accessor_modifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessor_body([NotNull] CSharpParser.Accessor_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessor_body([NotNull] CSharpParser.Accessor_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.event_accessor_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_accessor_declarations([NotNull] CSharpParser.Event_accessor_declarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.event_accessor_declarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_accessor_declarations([NotNull] CSharpParser.Event_accessor_declarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.add_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_accessor_declaration([NotNull] CSharpParser.Add_accessor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.add_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_accessor_declaration([NotNull] CSharpParser.Add_accessor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.remove_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemove_accessor_declaration([NotNull] CSharpParser.Remove_accessor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.remove_accessor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemove_accessor_declaration([NotNull] CSharpParser.Remove_accessor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.overloadable_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOverloadable_operator([NotNull] CSharpParser.Overloadable_operatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.overloadable_operator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOverloadable_operator([NotNull] CSharpParser.Overloadable_operatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conversion_operator_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversion_operator_declarator([NotNull] CSharpParser.Conversion_operator_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conversion_operator_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversion_operator_declarator([NotNull] CSharpParser.Conversion_operator_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor_initializer([NotNull] CSharpParser.Constructor_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor_initializer([NotNull] CSharpParser.Constructor_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBody([NotNull] CSharpParser.BodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBody([NotNull] CSharpParser.BodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_interfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_interfaces([NotNull] CSharpParser.Struct_interfacesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_interfaces"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_interfaces([NotNull] CSharpParser.Struct_interfacesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_body([NotNull] CSharpParser.Struct_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_body([NotNull] CSharpParser.Struct_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_member_declaration([NotNull] CSharpParser.Struct_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_member_declaration([NotNull] CSharpParser.Struct_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_type([NotNull] CSharpParser.Array_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_type([NotNull] CSharpParser.Array_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.rank_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRank_specifier([NotNull] CSharpParser.Rank_specifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.rank_specifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRank_specifier([NotNull] CSharpParser.Rank_specifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.array_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_initializer([NotNull] CSharpParser.Array_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.array_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_initializer([NotNull] CSharpParser.Array_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variant_type_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariant_type_parameter_list([NotNull] CSharpParser.Variant_type_parameter_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variant_type_parameter_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariant_type_parameter_list([NotNull] CSharpParser.Variant_type_parameter_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variant_type_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariant_type_parameter([NotNull] CSharpParser.Variant_type_parameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variant_type_parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariant_type_parameter([NotNull] CSharpParser.Variant_type_parameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variance_annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariance_annotation([NotNull] CSharpParser.Variance_annotationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variance_annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariance_annotation([NotNull] CSharpParser.Variance_annotationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_base([NotNull] CSharpParser.Interface_baseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_base([NotNull] CSharpParser.Interface_baseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_body([NotNull] CSharpParser.Interface_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_body([NotNull] CSharpParser.Interface_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_member_declaration([NotNull] CSharpParser.Interface_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_member_declaration([NotNull] CSharpParser.Interface_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_accessors"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_accessors([NotNull] CSharpParser.Interface_accessorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_accessors"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_accessors([NotNull] CSharpParser.Interface_accessorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_base([NotNull] CSharpParser.Enum_baseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_base"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_base([NotNull] CSharpParser.Enum_baseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_body([NotNull] CSharpParser.Enum_bodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_body([NotNull] CSharpParser.Enum_bodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_member_declaration([NotNull] CSharpParser.Enum_member_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_member_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_member_declaration([NotNull] CSharpParser.Enum_member_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.global_attribute_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_attribute_section([NotNull] CSharpParser.Global_attribute_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.global_attribute_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_attribute_section([NotNull] CSharpParser.Global_attribute_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.global_attribute_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGlobal_attribute_target([NotNull] CSharpParser.Global_attribute_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.global_attribute_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGlobal_attribute_target([NotNull] CSharpParser.Global_attribute_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributes([NotNull] CSharpParser.AttributesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attributes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributes([NotNull] CSharpParser.AttributesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_section([NotNull] CSharpParser.Attribute_sectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_section"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_section([NotNull] CSharpParser.Attribute_sectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_target([NotNull] CSharpParser.Attribute_targetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_target"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_target([NotNull] CSharpParser.Attribute_targetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_list([NotNull] CSharpParser.Attribute_listContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_list([NotNull] CSharpParser.Attribute_listContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] CSharpParser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] CSharpParser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute_argument([NotNull] CSharpParser.Attribute_argumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_argument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute_argument([NotNull] CSharpParser.Attribute_argumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.pointer_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointer_type([NotNull] CSharpParser.Pointer_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.pointer_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointer_type([NotNull] CSharpParser.Pointer_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_pointer_declarators([NotNull] CSharpParser.Fixed_pointer_declaratorsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_pointer_declarators([NotNull] CSharpParser.Fixed_pointer_declaratorsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_pointer_declarator([NotNull] CSharpParser.Fixed_pointer_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_pointer_declarator([NotNull] CSharpParser.Fixed_pointer_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_pointer_initializer([NotNull] CSharpParser.Fixed_pointer_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_pointer_initializer([NotNull] CSharpParser.Fixed_pointer_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_size_buffer_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_size_buffer_declarator([NotNull] CSharpParser.Fixed_size_buffer_declaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_size_buffer_declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_size_buffer_declarator([NotNull] CSharpParser.Fixed_size_buffer_declaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.stackalloc_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStackalloc_initializer([NotNull] CSharpParser.Stackalloc_initializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.stackalloc_initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStackalloc_initializer([NotNull] CSharpParser.Stackalloc_initializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_arrow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRight_arrow([NotNull] CSharpParser.Right_arrowContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_arrow"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRight_arrow([NotNull] CSharpParser.Right_arrowContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_shift"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRight_shift([NotNull] CSharpParser.Right_shiftContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_shift"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRight_shift([NotNull] CSharpParser.Right_shiftContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_shift_assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRight_shift_assignment([NotNull] CSharpParser.Right_shift_assignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_shift_assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRight_shift_assignment([NotNull] CSharpParser.Right_shift_assignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] CSharpParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] CSharpParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.boolean_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean_literal([NotNull] CSharpParser.Boolean_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.boolean_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean_literal([NotNull] CSharpParser.Boolean_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.string_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_literal([NotNull] CSharpParser.String_literalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.string_literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_literal([NotNull] CSharpParser.String_literalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_regular_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolated_regular_string([NotNull] CSharpParser.Interpolated_regular_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_regular_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolated_regular_string([NotNull] CSharpParser.Interpolated_regular_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolated_verbatium_string([NotNull] CSharpParser.Interpolated_verbatium_stringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolated_verbatium_string([NotNull] CSharpParser.Interpolated_verbatium_stringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_regular_string_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolated_regular_string_part([NotNull] CSharpParser.Interpolated_regular_string_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_regular_string_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolated_regular_string_part([NotNull] CSharpParser.Interpolated_regular_string_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolated_verbatium_string_part([NotNull] CSharpParser.Interpolated_verbatium_string_partContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string_part"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolated_verbatium_string_part([NotNull] CSharpParser.Interpolated_verbatium_string_partContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_string_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterpolated_string_expression([NotNull] CSharpParser.Interpolated_string_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_string_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterpolated_string_expression([NotNull] CSharpParser.Interpolated_string_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyword([NotNull] CSharpParser.KeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.keyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyword([NotNull] CSharpParser.KeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClass_definition([NotNull] CSharpParser.Class_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClass_definition([NotNull] CSharpParser.Class_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStruct_definition([NotNull] CSharpParser.Struct_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStruct_definition([NotNull] CSharpParser.Struct_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterface_definition([NotNull] CSharpParser.Interface_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterface_definition([NotNull] CSharpParser.Interface_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum_definition([NotNull] CSharpParser.Enum_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum_definition([NotNull] CSharpParser.Enum_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.delegate_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDelegate_definition([NotNull] CSharpParser.Delegate_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.delegate_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDelegate_definition([NotNull] CSharpParser.Delegate_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.event_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEvent_declaration([NotNull] CSharpParser.Event_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.event_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEvent_declaration([NotNull] CSharpParser.Event_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.field_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField_declaration([NotNull] CSharpParser.Field_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.field_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField_declaration([NotNull] CSharpParser.Field_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.property_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProperty_declaration([NotNull] CSharpParser.Property_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.property_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProperty_declaration([NotNull] CSharpParser.Property_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_declaration([NotNull] CSharpParser.Constant_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_declaration([NotNull] CSharpParser.Constant_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.indexer_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexer_declaration([NotNull] CSharpParser.Indexer_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.indexer_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexer_declaration([NotNull] CSharpParser.Indexer_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.destructor_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDestructor_definition([NotNull] CSharpParser.Destructor_definitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.destructor_definition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDestructor_definition([NotNull] CSharpParser.Destructor_definitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructor_declaration([NotNull] CSharpParser.Constructor_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructor_declaration([NotNull] CSharpParser.Constructor_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_declaration([NotNull] CSharpParser.Method_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_declaration([NotNull] CSharpParser.Method_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_member_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_member_name([NotNull] CSharpParser.Method_member_nameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_member_name"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_member_name([NotNull] CSharpParser.Method_member_nameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.operator_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperator_declaration([NotNull] CSharpParser.Operator_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.operator_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperator_declaration([NotNull] CSharpParser.Operator_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.arg_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArg_declaration([NotNull] CSharpParser.Arg_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.arg_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArg_declaration([NotNull] CSharpParser.Arg_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethod_invocation([NotNull] CSharpParser.Method_invocationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_invocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethod_invocation([NotNull] CSharpParser.Method_invocationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_creation_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObject_creation_expression([NotNull] CSharpParser.Object_creation_expressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_creation_expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObject_creation_expression([NotNull] CSharpParser.Object_creation_expressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] CSharpParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] CSharpParser.IdentifierContext context);
}
