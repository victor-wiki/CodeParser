using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICSharpParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class CSharpParserBaseListener : ICSharpParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.compilation_unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilation_unit([NotNull] CSharpParser.Compilation_unitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.compilation_unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilation_unit([NotNull] CSharpParser.Compilation_unitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_or_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespace_or_type_name([NotNull] CSharpParser.Namespace_or_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_or_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespace_or_type_name([NotNull] CSharpParser.Namespace_or_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_([NotNull] CSharpParser.Type_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_([NotNull] CSharpParser.Type_Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.base_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBase_type([NotNull] CSharpParser.Base_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.base_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBase_type([NotNull] CSharpParser.Base_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.tuple_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTuple_type([NotNull] CSharpParser.Tuple_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.tuple_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTuple_type([NotNull] CSharpParser.Tuple_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.tuple_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTuple_element([NotNull] CSharpParser.Tuple_elementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.tuple_element"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTuple_element([NotNull] CSharpParser.Tuple_elementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.simple_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimple_type([NotNull] CSharpParser.Simple_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.simple_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimple_type([NotNull] CSharpParser.Simple_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.numeric_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumeric_type([NotNull] CSharpParser.Numeric_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.numeric_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumeric_type([NotNull] CSharpParser.Numeric_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.integral_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntegral_type([NotNull] CSharpParser.Integral_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.integral_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntegral_type([NotNull] CSharpParser.Integral_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.floating_point_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloating_point_type([NotNull] CSharpParser.Floating_point_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.floating_point_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloating_point_type([NotNull] CSharpParser.Floating_point_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_type([NotNull] CSharpParser.Class_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_type([NotNull] CSharpParser.Class_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_argument_list([NotNull] CSharpParser.Type_argument_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_argument_list([NotNull] CSharpParser.Type_argument_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument_list([NotNull] CSharpParser.Argument_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.argument_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument_list([NotNull] CSharpParser.Argument_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgument([NotNull] CSharpParser.ArgumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgument([NotNull] CSharpParser.ArgumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] CSharpParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] CSharpParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.non_assignment_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNon_assignment_expression([NotNull] CSharpParser.Non_assignment_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.non_assignment_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNon_assignment_expression([NotNull] CSharpParser.Non_assignment_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] CSharpParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] CSharpParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.assignment_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment_operator([NotNull] CSharpParser.Assignment_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.assignment_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment_operator([NotNull] CSharpParser.Assignment_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_expression([NotNull] CSharpParser.Conditional_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_expression([NotNull] CSharpParser.Conditional_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.null_coalescing_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull_coalescing_expression([NotNull] CSharpParser.Null_coalescing_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.null_coalescing_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull_coalescing_expression([NotNull] CSharpParser.Null_coalescing_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_or_expression([NotNull] CSharpParser.Conditional_or_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_or_expression([NotNull] CSharpParser.Conditional_or_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conditional_and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditional_and_expression([NotNull] CSharpParser.Conditional_and_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conditional_and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditional_and_expression([NotNull] CSharpParser.Conditional_and_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.inclusive_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInclusive_or_expression([NotNull] CSharpParser.Inclusive_or_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.inclusive_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInclusive_or_expression([NotNull] CSharpParser.Inclusive_or_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.exclusive_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusive_or_expression([NotNull] CSharpParser.Exclusive_or_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.exclusive_or_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusive_or_expression([NotNull] CSharpParser.Exclusive_or_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd_expression([NotNull] CSharpParser.And_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.and_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd_expression([NotNull] CSharpParser.And_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.equality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEquality_expression([NotNull] CSharpParser.Equality_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.equality_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEquality_expression([NotNull] CSharpParser.Equality_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.relational_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelational_expression([NotNull] CSharpParser.Relational_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.relational_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelational_expression([NotNull] CSharpParser.Relational_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.shift_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShift_expression([NotNull] CSharpParser.Shift_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.shift_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShift_expression([NotNull] CSharpParser.Shift_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.additive_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditive_expression([NotNull] CSharpParser.Additive_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.additive_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditive_expression([NotNull] CSharpParser.Additive_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.multiplicative_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicative_expression([NotNull] CSharpParser.Multiplicative_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.multiplicative_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicative_expression([NotNull] CSharpParser.Multiplicative_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_expression([NotNull] CSharpParser.Switch_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_expression([NotNull] CSharpParser.Switch_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression_arms"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_expression_arms([NotNull] CSharpParser.Switch_expression_armsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression_arms"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_expression_arms([NotNull] CSharpParser.Switch_expression_armsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_expression_arm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_expression_arm([NotNull] CSharpParser.Switch_expression_armContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_expression_arm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_expression_arm([NotNull] CSharpParser.Switch_expression_armContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.range_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRange_expression([NotNull] CSharpParser.Range_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.range_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRange_expression([NotNull] CSharpParser.Range_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_expression([NotNull] CSharpParser.Unary_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.unary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_expression([NotNull] CSharpParser.Unary_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.primary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary_expression([NotNull] CSharpParser.Primary_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.primary_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary_expression([NotNull] CSharpParser.Primary_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>literalExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralExpression([NotNull] CSharpParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>literalExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralExpression([NotNull] CSharpParser.LiteralExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleNameExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleNameExpression([NotNull] CSharpParser.SimpleNameExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleNameExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleNameExpression([NotNull] CSharpParser.SimpleNameExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenthesisExpressions</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenthesisExpressions([NotNull] CSharpParser.ParenthesisExpressionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenthesisExpressions</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenthesisExpressions([NotNull] CSharpParser.ParenthesisExpressionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>memberAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberAccessExpression([NotNull] CSharpParser.MemberAccessExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>memberAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberAccessExpression([NotNull] CSharpParser.MemberAccessExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>literalAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteralAccessExpression([NotNull] CSharpParser.LiteralAccessExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>literalAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteralAccessExpression([NotNull] CSharpParser.LiteralAccessExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>thisReferenceExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThisReferenceExpression([NotNull] CSharpParser.ThisReferenceExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>thisReferenceExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThisReferenceExpression([NotNull] CSharpParser.ThisReferenceExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>baseAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBaseAccessExpression([NotNull] CSharpParser.BaseAccessExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>baseAccessExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBaseAccessExpression([NotNull] CSharpParser.BaseAccessExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>objectCreationExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObjectCreationExpression([NotNull] CSharpParser.ObjectCreationExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>objectCreationExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObjectCreationExpression([NotNull] CSharpParser.ObjectCreationExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>tupleExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTupleExpression([NotNull] CSharpParser.TupleExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>tupleExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTupleExpression([NotNull] CSharpParser.TupleExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>typeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeofExpression([NotNull] CSharpParser.TypeofExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>typeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeofExpression([NotNull] CSharpParser.TypeofExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>checkedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckedExpression([NotNull] CSharpParser.CheckedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>checkedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckedExpression([NotNull] CSharpParser.CheckedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>uncheckedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUncheckedExpression([NotNull] CSharpParser.UncheckedExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>uncheckedExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUncheckedExpression([NotNull] CSharpParser.UncheckedExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>defaultValueExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultValueExpression([NotNull] CSharpParser.DefaultValueExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>defaultValueExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultValueExpression([NotNull] CSharpParser.DefaultValueExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>anonymousMethodExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymousMethodExpression([NotNull] CSharpParser.AnonymousMethodExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>anonymousMethodExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymousMethodExpression([NotNull] CSharpParser.AnonymousMethodExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>sizeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSizeofExpression([NotNull] CSharpParser.SizeofExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>sizeofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSizeofExpression([NotNull] CSharpParser.SizeofExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>nameofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNameofExpression([NotNull] CSharpParser.NameofExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>nameofExpression</c>
	/// labeled alternative in <see cref="CSharpParser.primary_expression_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNameofExpression([NotNull] CSharpParser.NameofExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.throwable_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowable_expression([NotNull] CSharpParser.Throwable_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.throwable_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowable_expression([NotNull] CSharpParser.Throwable_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.throw_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrow_expression([NotNull] CSharpParser.Throw_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.throw_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrow_expression([NotNull] CSharpParser.Throw_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_access"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_access([NotNull] CSharpParser.Member_accessContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_access"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_access([NotNull] CSharpParser.Member_accessContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.bracket_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBracket_expression([NotNull] CSharpParser.Bracket_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.bracket_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBracket_expression([NotNull] CSharpParser.Bracket_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.indexer_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexer_argument([NotNull] CSharpParser.Indexer_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.indexer_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexer_argument([NotNull] CSharpParser.Indexer_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.predefined_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredefined_type([NotNull] CSharpParser.Predefined_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.predefined_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredefined_type([NotNull] CSharpParser.Predefined_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.expression_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression_list([NotNull] CSharpParser.Expression_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.expression_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression_list([NotNull] CSharpParser.Expression_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_or_collection_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_or_collection_initializer([NotNull] CSharpParser.Object_or_collection_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_or_collection_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_or_collection_initializer([NotNull] CSharpParser.Object_or_collection_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_initializer([NotNull] CSharpParser.Object_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_initializer([NotNull] CSharpParser.Object_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_initializer_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_initializer_list([NotNull] CSharpParser.Member_initializer_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_initializer_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_initializer_list([NotNull] CSharpParser.Member_initializer_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_initializer([NotNull] CSharpParser.Member_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_initializer([NotNull] CSharpParser.Member_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.initializer_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializer_value([NotNull] CSharpParser.Initializer_valueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.initializer_value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializer_value([NotNull] CSharpParser.Initializer_valueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.collection_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollection_initializer([NotNull] CSharpParser.Collection_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.collection_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollection_initializer([NotNull] CSharpParser.Collection_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.element_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElement_initializer([NotNull] CSharpParser.Element_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.element_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElement_initializer([NotNull] CSharpParser.Element_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_object_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymous_object_initializer([NotNull] CSharpParser.Anonymous_object_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_object_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymous_object_initializer([NotNull] CSharpParser.Anonymous_object_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_declarator_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_declarator_list([NotNull] CSharpParser.Member_declarator_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_declarator_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_declarator_list([NotNull] CSharpParser.Member_declarator_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_declarator([NotNull] CSharpParser.Member_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_declarator([NotNull] CSharpParser.Member_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.unbound_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnbound_type_name([NotNull] CSharpParser.Unbound_type_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.unbound_type_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnbound_type_name([NotNull] CSharpParser.Unbound_type_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.generic_dimension_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneric_dimension_specifier([NotNull] CSharpParser.Generic_dimension_specifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.generic_dimension_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneric_dimension_specifier([NotNull] CSharpParser.Generic_dimension_specifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsType([NotNull] CSharpParser.IsTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsType([NotNull] CSharpParser.IsTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isTypePatternArms"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsTypePatternArms([NotNull] CSharpParser.IsTypePatternArmsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isTypePatternArms"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsTypePatternArms([NotNull] CSharpParser.IsTypePatternArmsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.isTypePatternArm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsTypePatternArm([NotNull] CSharpParser.IsTypePatternArmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.isTypePatternArm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsTypePatternArm([NotNull] CSharpParser.IsTypePatternArmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.lambda_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambda_expression([NotNull] CSharpParser.Lambda_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.lambda_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambda_expression([NotNull] CSharpParser.Lambda_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_function_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymous_function_signature([NotNull] CSharpParser.Anonymous_function_signatureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_function_signature"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymous_function_signature([NotNull] CSharpParser.Anonymous_function_signatureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Explicit_anonymous_function_parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Explicit_anonymous_function_parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicit_anonymous_function_parameter([NotNull] CSharpParser.Explicit_anonymous_function_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.explicit_anonymous_function_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicit_anonymous_function_parameter([NotNull] CSharpParser.Explicit_anonymous_function_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.implicit_anonymous_function_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Implicit_anonymous_function_parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.implicit_anonymous_function_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImplicit_anonymous_function_parameter_list([NotNull] CSharpParser.Implicit_anonymous_function_parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.anonymous_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnonymous_function_body([NotNull] CSharpParser.Anonymous_function_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.anonymous_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnonymous_function_body([NotNull] CSharpParser.Anonymous_function_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_expression([NotNull] CSharpParser.Query_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_expression([NotNull] CSharpParser.Query_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFrom_clause([NotNull] CSharpParser.From_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.from_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFrom_clause([NotNull] CSharpParser.From_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_body([NotNull] CSharpParser.Query_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_body([NotNull] CSharpParser.Query_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_body_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_body_clause([NotNull] CSharpParser.Query_body_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_body_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_body_clause([NotNull] CSharpParser.Query_body_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.let_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLet_clause([NotNull] CSharpParser.Let_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.let_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLet_clause([NotNull] CSharpParser.Let_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhere_clause([NotNull] CSharpParser.Where_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.where_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhere_clause([NotNull] CSharpParser.Where_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.combined_join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCombined_join_clause([NotNull] CSharpParser.Combined_join_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.combined_join_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCombined_join_clause([NotNull] CSharpParser.Combined_join_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.orderby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderby_clause([NotNull] CSharpParser.Orderby_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.orderby_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderby_clause([NotNull] CSharpParser.Orderby_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.ordering"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrdering([NotNull] CSharpParser.OrderingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.ordering"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrdering([NotNull] CSharpParser.OrderingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.select_or_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelect_or_group_clause([NotNull] CSharpParser.Select_or_group_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.select_or_group_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelect_or_group_clause([NotNull] CSharpParser.Select_or_group_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.query_continuation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery_continuation([NotNull] CSharpParser.Query_continuationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.query_continuation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery_continuation([NotNull] CSharpParser.Query_continuationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] CSharpParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] CSharpParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationStatement([NotNull] CSharpParser.DeclarationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.declarationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationStatement([NotNull] CSharpParser.DeclarationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_function_declaration([NotNull] CSharpParser.Local_function_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_function_declaration([NotNull] CSharpParser.Local_function_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_header"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_function_header([NotNull] CSharpParser.Local_function_headerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_header"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_function_header([NotNull] CSharpParser.Local_function_headerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_function_modifiers([NotNull] CSharpParser.Local_function_modifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_function_modifiers([NotNull] CSharpParser.Local_function_modifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_function_body([NotNull] CSharpParser.Local_function_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_function_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_function_body([NotNull] CSharpParser.Local_function_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.labeled_Statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeled_Statement([NotNull] CSharpParser.Labeled_StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.labeled_Statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeled_Statement([NotNull] CSharpParser.Labeled_StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmbedded_statement([NotNull] CSharpParser.Embedded_statementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmbedded_statement([NotNull] CSharpParser.Embedded_statementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>theEmptyStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTheEmptyStatement([NotNull] CSharpParser.TheEmptyStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>theEmptyStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTheEmptyStatement([NotNull] CSharpParser.TheEmptyStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] CSharpParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] CSharpParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>ifStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] CSharpParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>switchStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitchStatement([NotNull] CSharpParser.SwitchStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>switchStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitchStatement([NotNull] CSharpParser.SwitchStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileStatement([NotNull] CSharpParser.WhileStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>whileStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileStatement([NotNull] CSharpParser.WhileStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>doStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoStatement([NotNull] CSharpParser.DoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>doStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoStatement([NotNull] CSharpParser.DoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>forStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForStatement([NotNull] CSharpParser.ForStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>forStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForStatement([NotNull] CSharpParser.ForStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>foreachStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForeachStatement([NotNull] CSharpParser.ForeachStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>foreachStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForeachStatement([NotNull] CSharpParser.ForeachStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>breakStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBreakStatement([NotNull] CSharpParser.BreakStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>breakStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBreakStatement([NotNull] CSharpParser.BreakStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>continueStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterContinueStatement([NotNull] CSharpParser.ContinueStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>continueStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitContinueStatement([NotNull] CSharpParser.ContinueStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>gotoStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGotoStatement([NotNull] CSharpParser.GotoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>gotoStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGotoStatement([NotNull] CSharpParser.GotoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>returnStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] CSharpParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>returnStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] CSharpParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>throwStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowStatement([NotNull] CSharpParser.ThrowStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>throwStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowStatement([NotNull] CSharpParser.ThrowStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>tryStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryStatement([NotNull] CSharpParser.TryStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>tryStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryStatement([NotNull] CSharpParser.TryStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>checkedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckedStatement([NotNull] CSharpParser.CheckedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>checkedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckedStatement([NotNull] CSharpParser.CheckedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>uncheckedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUncheckedStatement([NotNull] CSharpParser.UncheckedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>uncheckedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUncheckedStatement([NotNull] CSharpParser.UncheckedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>lockStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockStatement([NotNull] CSharpParser.LockStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lockStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockStatement([NotNull] CSharpParser.LockStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>usingStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingStatement([NotNull] CSharpParser.UsingStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>usingStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingStatement([NotNull] CSharpParser.UsingStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>yieldStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterYieldStatement([NotNull] CSharpParser.YieldStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>yieldStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitYieldStatement([NotNull] CSharpParser.YieldStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>unsafeStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnsafeStatement([NotNull] CSharpParser.UnsafeStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>unsafeStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnsafeStatement([NotNull] CSharpParser.UnsafeStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>fixedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixedStatement([NotNull] CSharpParser.FixedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>fixedStatement</c>
	/// labeled alternative in <see cref="CSharpParser.simple_embedded_statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixedStatement([NotNull] CSharpParser.FixedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock([NotNull] CSharpParser.BlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.block"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock([NotNull] CSharpParser.BlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_variable_declaration([NotNull] CSharpParser.Local_variable_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_variable_declaration([NotNull] CSharpParser.Local_variable_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_variable_type([NotNull] CSharpParser.Local_variable_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_variable_type([NotNull] CSharpParser.Local_variable_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_variable_declarator([NotNull] CSharpParser.Local_variable_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_variable_declarator([NotNull] CSharpParser.Local_variable_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_variable_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_variable_initializer([NotNull] CSharpParser.Local_variable_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_variable_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_variable_initializer([NotNull] CSharpParser.Local_variable_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.local_constant_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLocal_constant_declaration([NotNull] CSharpParser.Local_constant_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.local_constant_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLocal_constant_declaration([NotNull] CSharpParser.Local_constant_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.if_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIf_body([NotNull] CSharpParser.If_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.if_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIf_body([NotNull] CSharpParser.If_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_section([NotNull] CSharpParser.Switch_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_section([NotNull] CSharpParser.Switch_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.switch_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSwitch_label([NotNull] CSharpParser.Switch_labelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.switch_label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSwitch_label([NotNull] CSharpParser.Switch_labelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.case_guard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCase_guard([NotNull] CSharpParser.Case_guardContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.case_guard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCase_guard([NotNull] CSharpParser.Case_guardContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.statement_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement_list([NotNull] CSharpParser.Statement_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.statement_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement_list([NotNull] CSharpParser.Statement_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.for_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_initializer([NotNull] CSharpParser.For_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.for_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_initializer([NotNull] CSharpParser.For_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.for_iterator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFor_iterator([NotNull] CSharpParser.For_iteratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.for_iterator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFor_iterator([NotNull] CSharpParser.For_iteratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.catch_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCatch_clauses([NotNull] CSharpParser.Catch_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.catch_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCatch_clauses([NotNull] CSharpParser.Catch_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.specific_catch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecific_catch_clause([NotNull] CSharpParser.Specific_catch_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.specific_catch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecific_catch_clause([NotNull] CSharpParser.Specific_catch_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.general_catch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeneral_catch_clause([NotNull] CSharpParser.General_catch_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.general_catch_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeneral_catch_clause([NotNull] CSharpParser.General_catch_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.exception_filter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterException_filter([NotNull] CSharpParser.Exception_filterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.exception_filter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitException_filter([NotNull] CSharpParser.Exception_filterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.finally_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFinally_clause([NotNull] CSharpParser.Finally_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.finally_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFinally_clause([NotNull] CSharpParser.Finally_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.resource_acquisition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResource_acquisition([NotNull] CSharpParser.Resource_acquisitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.resource_acquisition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResource_acquisition([NotNull] CSharpParser.Resource_acquisitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespace_declaration([NotNull] CSharpParser.Namespace_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespace_declaration([NotNull] CSharpParser.Namespace_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.qualified_identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_identifier([NotNull] CSharpParser.Qualified_identifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.qualified_identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_identifier([NotNull] CSharpParser.Qualified_identifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespace_body([NotNull] CSharpParser.Namespace_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespace_body([NotNull] CSharpParser.Namespace_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.extern_alias_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtern_alias_directives([NotNull] CSharpParser.Extern_alias_directivesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.extern_alias_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtern_alias_directives([NotNull] CSharpParser.Extern_alias_directivesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.extern_alias_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtern_alias_directive([NotNull] CSharpParser.Extern_alias_directiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.extern_alias_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtern_alias_directive([NotNull] CSharpParser.Extern_alias_directiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.using_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsing_directives([NotNull] CSharpParser.Using_directivesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.using_directives"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsing_directives([NotNull] CSharpParser.Using_directivesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>usingAliasDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingAliasDirective([NotNull] CSharpParser.UsingAliasDirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>usingAliasDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingAliasDirective([NotNull] CSharpParser.UsingAliasDirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>usingNamespaceDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingNamespaceDirective([NotNull] CSharpParser.UsingNamespaceDirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>usingNamespaceDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingNamespaceDirective([NotNull] CSharpParser.UsingNamespaceDirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>usingStaticDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingStaticDirective([NotNull] CSharpParser.UsingStaticDirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>usingStaticDirective</c>
	/// labeled alternative in <see cref="CSharpParser.using_directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingStaticDirective([NotNull] CSharpParser.UsingStaticDirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_member_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespace_member_declarations([NotNull] CSharpParser.Namespace_member_declarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_member_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespace_member_declarations([NotNull] CSharpParser.Namespace_member_declarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.namespace_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespace_member_declaration([NotNull] CSharpParser.Namespace_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.namespace_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespace_member_declaration([NotNull] CSharpParser.Namespace_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_declaration([NotNull] CSharpParser.Type_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_declaration([NotNull] CSharpParser.Type_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.qualified_alias_member"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualified_alias_member([NotNull] CSharpParser.Qualified_alias_memberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.qualified_alias_member"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualified_alias_member([NotNull] CSharpParser.Qualified_alias_memberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_parameter_list([NotNull] CSharpParser.Type_parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_parameter_list([NotNull] CSharpParser.Type_parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_parameter([NotNull] CSharpParser.Type_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_parameter([NotNull] CSharpParser.Type_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_base([NotNull] CSharpParser.Class_baseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_base([NotNull] CSharpParser.Class_baseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_type_list([NotNull] CSharpParser.Interface_type_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_type_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_type_list([NotNull] CSharpParser.Interface_type_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_parameter_constraints_clauses([NotNull] CSharpParser.Type_parameter_constraints_clausesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clauses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_parameter_constraints_clauses([NotNull] CSharpParser.Type_parameter_constraints_clausesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_parameter_constraints_clause([NotNull] CSharpParser.Type_parameter_constraints_clauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints_clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_parameter_constraints_clause([NotNull] CSharpParser.Type_parameter_constraints_clauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.type_parameter_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType_parameter_constraints([NotNull] CSharpParser.Type_parameter_constraintsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.type_parameter_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType_parameter_constraints([NotNull] CSharpParser.Type_parameter_constraintsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.primary_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimary_constraint([NotNull] CSharpParser.Primary_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.primary_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimary_constraint([NotNull] CSharpParser.Primary_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.secondary_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSecondary_constraints([NotNull] CSharpParser.Secondary_constraintsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.secondary_constraints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSecondary_constraints([NotNull] CSharpParser.Secondary_constraintsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructor_constraint([NotNull] CSharpParser.Constructor_constraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructor_constraint([NotNull] CSharpParser.Constructor_constraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_body([NotNull] CSharpParser.Class_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_body([NotNull] CSharpParser.Class_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_member_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_member_declarations([NotNull] CSharpParser.Class_member_declarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_member_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_member_declarations([NotNull] CSharpParser.Class_member_declarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_member_declaration([NotNull] CSharpParser.Class_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_member_declaration([NotNull] CSharpParser.Class_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.all_member_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAll_member_modifiers([NotNull] CSharpParser.All_member_modifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.all_member_modifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAll_member_modifiers([NotNull] CSharpParser.All_member_modifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.all_member_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAll_member_modifier([NotNull] CSharpParser.All_member_modifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.all_member_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAll_member_modifier([NotNull] CSharpParser.All_member_modifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.common_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommon_member_declaration([NotNull] CSharpParser.Common_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.common_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommon_member_declaration([NotNull] CSharpParser.Common_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.typed_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTyped_member_declaration([NotNull] CSharpParser.Typed_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.typed_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTyped_member_declaration([NotNull] CSharpParser.Typed_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant_declarators([NotNull] CSharpParser.Constant_declaratorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant_declarators([NotNull] CSharpParser.Constant_declaratorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant_declarator([NotNull] CSharpParser.Constant_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant_declarator([NotNull] CSharpParser.Constant_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_declarators([NotNull] CSharpParser.Variable_declaratorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_declarators([NotNull] CSharpParser.Variable_declaratorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_declarator([NotNull] CSharpParser.Variable_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_declarator([NotNull] CSharpParser.Variable_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variable_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable_initializer([NotNull] CSharpParser.Variable_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variable_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable_initializer([NotNull] CSharpParser.Variable_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.return_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturn_type([NotNull] CSharpParser.Return_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.return_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturn_type([NotNull] CSharpParser.Return_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.member_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMember_name([NotNull] CSharpParser.Member_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.member_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMember_name([NotNull] CSharpParser.Member_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_body([NotNull] CSharpParser.Method_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_body([NotNull] CSharpParser.Method_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.formal_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFormal_parameter_list([NotNull] CSharpParser.Formal_parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.formal_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFormal_parameter_list([NotNull] CSharpParser.Formal_parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_parameters([NotNull] CSharpParser.Fixed_parametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_parameters([NotNull] CSharpParser.Fixed_parametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_parameter([NotNull] CSharpParser.Fixed_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_parameter([NotNull] CSharpParser.Fixed_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameter_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_modifier([NotNull] CSharpParser.Parameter_modifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameter_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_modifier([NotNull] CSharpParser.Parameter_modifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.parameter_array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameter_array([NotNull] CSharpParser.Parameter_arrayContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.parameter_array"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameter_array([NotNull] CSharpParser.Parameter_arrayContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessor_declarations([NotNull] CSharpParser.Accessor_declarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessor_declarations([NotNull] CSharpParser.Accessor_declarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.get_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGet_accessor_declaration([NotNull] CSharpParser.Get_accessor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.get_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGet_accessor_declaration([NotNull] CSharpParser.Get_accessor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.set_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSet_accessor_declaration([NotNull] CSharpParser.Set_accessor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.set_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSet_accessor_declaration([NotNull] CSharpParser.Set_accessor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessor_modifier([NotNull] CSharpParser.Accessor_modifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_modifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessor_modifier([NotNull] CSharpParser.Accessor_modifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.accessor_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessor_body([NotNull] CSharpParser.Accessor_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.accessor_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessor_body([NotNull] CSharpParser.Accessor_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.event_accessor_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_accessor_declarations([NotNull] CSharpParser.Event_accessor_declarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.event_accessor_declarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_accessor_declarations([NotNull] CSharpParser.Event_accessor_declarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.add_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdd_accessor_declaration([NotNull] CSharpParser.Add_accessor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.add_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdd_accessor_declaration([NotNull] CSharpParser.Add_accessor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.remove_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemove_accessor_declaration([NotNull] CSharpParser.Remove_accessor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.remove_accessor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemove_accessor_declaration([NotNull] CSharpParser.Remove_accessor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.overloadable_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOverloadable_operator([NotNull] CSharpParser.Overloadable_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.overloadable_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOverloadable_operator([NotNull] CSharpParser.Overloadable_operatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.conversion_operator_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConversion_operator_declarator([NotNull] CSharpParser.Conversion_operator_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.conversion_operator_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConversion_operator_declarator([NotNull] CSharpParser.Conversion_operator_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructor_initializer([NotNull] CSharpParser.Constructor_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructor_initializer([NotNull] CSharpParser.Constructor_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBody([NotNull] CSharpParser.BodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBody([NotNull] CSharpParser.BodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_interfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStruct_interfaces([NotNull] CSharpParser.Struct_interfacesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_interfaces"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStruct_interfaces([NotNull] CSharpParser.Struct_interfacesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStruct_body([NotNull] CSharpParser.Struct_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStruct_body([NotNull] CSharpParser.Struct_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStruct_member_declaration([NotNull] CSharpParser.Struct_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStruct_member_declaration([NotNull] CSharpParser.Struct_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.array_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray_type([NotNull] CSharpParser.Array_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.array_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray_type([NotNull] CSharpParser.Array_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.rank_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRank_specifier([NotNull] CSharpParser.Rank_specifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.rank_specifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRank_specifier([NotNull] CSharpParser.Rank_specifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.array_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArray_initializer([NotNull] CSharpParser.Array_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.array_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArray_initializer([NotNull] CSharpParser.Array_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variant_type_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariant_type_parameter_list([NotNull] CSharpParser.Variant_type_parameter_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variant_type_parameter_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariant_type_parameter_list([NotNull] CSharpParser.Variant_type_parameter_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variant_type_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariant_type_parameter([NotNull] CSharpParser.Variant_type_parameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variant_type_parameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariant_type_parameter([NotNull] CSharpParser.Variant_type_parameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.variance_annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariance_annotation([NotNull] CSharpParser.Variance_annotationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.variance_annotation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariance_annotation([NotNull] CSharpParser.Variance_annotationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_base([NotNull] CSharpParser.Interface_baseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_base([NotNull] CSharpParser.Interface_baseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_body([NotNull] CSharpParser.Interface_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_body([NotNull] CSharpParser.Interface_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_member_declaration([NotNull] CSharpParser.Interface_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_member_declaration([NotNull] CSharpParser.Interface_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_accessors"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_accessors([NotNull] CSharpParser.Interface_accessorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_accessors"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_accessors([NotNull] CSharpParser.Interface_accessorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnum_base([NotNull] CSharpParser.Enum_baseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_base"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnum_base([NotNull] CSharpParser.Enum_baseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnum_body([NotNull] CSharpParser.Enum_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnum_body([NotNull] CSharpParser.Enum_bodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnum_member_declaration([NotNull] CSharpParser.Enum_member_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_member_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnum_member_declaration([NotNull] CSharpParser.Enum_member_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.global_attribute_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobal_attribute_section([NotNull] CSharpParser.Global_attribute_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.global_attribute_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobal_attribute_section([NotNull] CSharpParser.Global_attribute_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.global_attribute_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGlobal_attribute_target([NotNull] CSharpParser.Global_attribute_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.global_attribute_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGlobal_attribute_target([NotNull] CSharpParser.Global_attribute_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributes([NotNull] CSharpParser.AttributesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attributes"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributes([NotNull] CSharpParser.AttributesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_section([NotNull] CSharpParser.Attribute_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_section([NotNull] CSharpParser.Attribute_sectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_target([NotNull] CSharpParser.Attribute_targetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_target"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_target([NotNull] CSharpParser.Attribute_targetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_list([NotNull] CSharpParser.Attribute_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_list"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_list([NotNull] CSharpParser.Attribute_listContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute([NotNull] CSharpParser.AttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute([NotNull] CSharpParser.AttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.attribute_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute_argument([NotNull] CSharpParser.Attribute_argumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.attribute_argument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute_argument([NotNull] CSharpParser.Attribute_argumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.pointer_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointer_type([NotNull] CSharpParser.Pointer_typeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.pointer_type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointer_type([NotNull] CSharpParser.Pointer_typeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_pointer_declarators([NotNull] CSharpParser.Fixed_pointer_declaratorsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarators"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_pointer_declarators([NotNull] CSharpParser.Fixed_pointer_declaratorsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_pointer_declarator([NotNull] CSharpParser.Fixed_pointer_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_pointer_declarator([NotNull] CSharpParser.Fixed_pointer_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_pointer_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_pointer_initializer([NotNull] CSharpParser.Fixed_pointer_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_pointer_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_pointer_initializer([NotNull] CSharpParser.Fixed_pointer_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.fixed_size_buffer_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFixed_size_buffer_declarator([NotNull] CSharpParser.Fixed_size_buffer_declaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.fixed_size_buffer_declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFixed_size_buffer_declarator([NotNull] CSharpParser.Fixed_size_buffer_declaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.stackalloc_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStackalloc_initializer([NotNull] CSharpParser.Stackalloc_initializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.stackalloc_initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStackalloc_initializer([NotNull] CSharpParser.Stackalloc_initializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_arrow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRight_arrow([NotNull] CSharpParser.Right_arrowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_arrow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRight_arrow([NotNull] CSharpParser.Right_arrowContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_shift"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRight_shift([NotNull] CSharpParser.Right_shiftContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_shift"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRight_shift([NotNull] CSharpParser.Right_shiftContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.right_shift_assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRight_shift_assignment([NotNull] CSharpParser.Right_shift_assignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.right_shift_assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRight_shift_assignment([NotNull] CSharpParser.Right_shift_assignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] CSharpParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] CSharpParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.boolean_literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolean_literal([NotNull] CSharpParser.Boolean_literalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.boolean_literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolean_literal([NotNull] CSharpParser.Boolean_literalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.string_literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString_literal([NotNull] CSharpParser.String_literalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.string_literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString_literal([NotNull] CSharpParser.String_literalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_regular_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolated_regular_string([NotNull] CSharpParser.Interpolated_regular_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_regular_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolated_regular_string([NotNull] CSharpParser.Interpolated_regular_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolated_verbatium_string([NotNull] CSharpParser.Interpolated_verbatium_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolated_verbatium_string([NotNull] CSharpParser.Interpolated_verbatium_stringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_regular_string_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolated_regular_string_part([NotNull] CSharpParser.Interpolated_regular_string_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_regular_string_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolated_regular_string_part([NotNull] CSharpParser.Interpolated_regular_string_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolated_verbatium_string_part([NotNull] CSharpParser.Interpolated_verbatium_string_partContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_verbatium_string_part"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolated_verbatium_string_part([NotNull] CSharpParser.Interpolated_verbatium_string_partContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interpolated_string_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterpolated_string_expression([NotNull] CSharpParser.Interpolated_string_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interpolated_string_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterpolated_string_expression([NotNull] CSharpParser.Interpolated_string_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyword([NotNull] CSharpParser.KeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.keyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyword([NotNull] CSharpParser.KeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.class_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClass_definition([NotNull] CSharpParser.Class_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.class_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClass_definition([NotNull] CSharpParser.Class_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.struct_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStruct_definition([NotNull] CSharpParser.Struct_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.struct_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStruct_definition([NotNull] CSharpParser.Struct_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.interface_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterface_definition([NotNull] CSharpParser.Interface_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.interface_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterface_definition([NotNull] CSharpParser.Interface_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.enum_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnum_definition([NotNull] CSharpParser.Enum_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.enum_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnum_definition([NotNull] CSharpParser.Enum_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.delegate_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDelegate_definition([NotNull] CSharpParser.Delegate_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.delegate_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDelegate_definition([NotNull] CSharpParser.Delegate_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.event_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEvent_declaration([NotNull] CSharpParser.Event_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.event_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEvent_declaration([NotNull] CSharpParser.Event_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.field_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterField_declaration([NotNull] CSharpParser.Field_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.field_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitField_declaration([NotNull] CSharpParser.Field_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.property_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProperty_declaration([NotNull] CSharpParser.Property_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.property_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProperty_declaration([NotNull] CSharpParser.Property_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constant_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstant_declaration([NotNull] CSharpParser.Constant_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constant_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstant_declaration([NotNull] CSharpParser.Constant_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.indexer_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexer_declaration([NotNull] CSharpParser.Indexer_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.indexer_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexer_declaration([NotNull] CSharpParser.Indexer_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.destructor_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDestructor_definition([NotNull] CSharpParser.Destructor_definitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.destructor_definition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDestructor_definition([NotNull] CSharpParser.Destructor_definitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.constructor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstructor_declaration([NotNull] CSharpParser.Constructor_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.constructor_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstructor_declaration([NotNull] CSharpParser.Constructor_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_declaration([NotNull] CSharpParser.Method_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_declaration([NotNull] CSharpParser.Method_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_member_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_member_name([NotNull] CSharpParser.Method_member_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_member_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_member_name([NotNull] CSharpParser.Method_member_nameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.operator_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_declaration([NotNull] CSharpParser.Operator_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.operator_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_declaration([NotNull] CSharpParser.Operator_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.arg_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArg_declaration([NotNull] CSharpParser.Arg_declarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.arg_declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArg_declaration([NotNull] CSharpParser.Arg_declarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.method_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMethod_invocation([NotNull] CSharpParser.Method_invocationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.method_invocation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMethod_invocation([NotNull] CSharpParser.Method_invocationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.object_creation_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObject_creation_expression([NotNull] CSharpParser.Object_creation_expressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.object_creation_expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObject_creation_expression([NotNull] CSharpParser.Object_creation_expressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CSharpParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] CSharpParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CSharpParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] CSharpParser.IdentifierContext context) { }

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
