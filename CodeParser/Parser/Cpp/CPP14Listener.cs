using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CPP14Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ICPP14Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.translationunit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTranslationunit([NotNull] CPP14Parser.TranslationunitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.translationunit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTranslationunit([NotNull] CPP14Parser.TranslationunitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.primaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryexpression([NotNull] CPP14Parser.PrimaryexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.primaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryexpression([NotNull] CPP14Parser.PrimaryexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.idexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdexpression([NotNull] CPP14Parser.IdexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.idexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdexpression([NotNull] CPP14Parser.IdexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unqualifiedid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnqualifiedid([NotNull] CPP14Parser.UnqualifiedidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unqualifiedid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnqualifiedid([NotNull] CPP14Parser.UnqualifiedidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.qualifiedid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedid([NotNull] CPP14Parser.QualifiedidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.qualifiedid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedid([NotNull] CPP14Parser.QualifiedidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.nestednamespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestednamespecifier([NotNull] CPP14Parser.NestednamespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.nestednamespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestednamespecifier([NotNull] CPP14Parser.NestednamespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdaexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaexpression([NotNull] CPP14Parser.LambdaexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdaexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaexpression([NotNull] CPP14Parser.LambdaexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdaintroducer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaintroducer([NotNull] CPP14Parser.LambdaintroducerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdaintroducer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaintroducer([NotNull] CPP14Parser.LambdaintroducerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdacapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdacapture([NotNull] CPP14Parser.LambdacaptureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdacapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdacapture([NotNull] CPP14Parser.LambdacaptureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capturedefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCapturedefault([NotNull] CPP14Parser.CapturedefaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capturedefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCapturedefault([NotNull] CPP14Parser.CapturedefaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capturelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCapturelist([NotNull] CPP14Parser.CapturelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capturelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCapturelist([NotNull] CPP14Parser.CapturelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCapture([NotNull] CPP14Parser.CaptureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCapture([NotNull] CPP14Parser.CaptureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simplecapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimplecapture([NotNull] CPP14Parser.SimplecaptureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simplecapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimplecapture([NotNull] CPP14Parser.SimplecaptureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initcapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitcapture([NotNull] CPP14Parser.InitcaptureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initcapture"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitcapture([NotNull] CPP14Parser.InitcaptureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdadeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdadeclarator([NotNull] CPP14Parser.LambdadeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdadeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdadeclarator([NotNull] CPP14Parser.LambdadeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.postfixexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixexpression([NotNull] CPP14Parser.PostfixexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.postfixexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixexpression([NotNull] CPP14Parser.PostfixexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidofexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeidofexpr([NotNull] CPP14Parser.TypeidofexprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidofexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeidofexpr([NotNull] CPP14Parser.TypeidofexprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidofthetypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeidofthetypeid([NotNull] CPP14Parser.TypeidofthetypeidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidofthetypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeidofthetypeid([NotNull] CPP14Parser.TypeidofthetypeidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expressionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionlist([NotNull] CPP14Parser.ExpressionlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expressionlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionlist([NotNull] CPP14Parser.ExpressionlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pseudodestructorname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPseudodestructorname([NotNull] CPP14Parser.PseudodestructornameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pseudodestructorname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPseudodestructorname([NotNull] CPP14Parser.PseudodestructornameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryexpression([NotNull] CPP14Parser.UnaryexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unaryexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryexpression([NotNull] CPP14Parser.UnaryexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unaryoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryoperator([NotNull] CPP14Parser.UnaryoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unaryoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryoperator([NotNull] CPP14Parser.UnaryoperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewexpression([NotNull] CPP14Parser.NewexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewexpression([NotNull] CPP14Parser.NewexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newplacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewplacement([NotNull] CPP14Parser.NewplacementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newplacement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewplacement([NotNull] CPP14Parser.NewplacementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newtypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewtypeid([NotNull] CPP14Parser.NewtypeidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newtypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewtypeid([NotNull] CPP14Parser.NewtypeidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewdeclarator([NotNull] CPP14Parser.NewdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewdeclarator([NotNull] CPP14Parser.NewdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrnewdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoptrnewdeclarator([NotNull] CPP14Parser.NoptrnewdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrnewdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoptrnewdeclarator([NotNull] CPP14Parser.NoptrnewdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNewinitializer([NotNull] CPP14Parser.NewinitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNewinitializer([NotNull] CPP14Parser.NewinitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.deleteexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteexpression([NotNull] CPP14Parser.DeleteexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.deleteexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteexpression([NotNull] CPP14Parser.DeleteexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noexceptexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoexceptexpression([NotNull] CPP14Parser.NoexceptexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noexceptexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoexceptexpression([NotNull] CPP14Parser.NoexceptexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.castexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastexpression([NotNull] CPP14Parser.CastexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.castexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastexpression([NotNull] CPP14Parser.CastexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pmexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPmexpression([NotNull] CPP14Parser.PmexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pmexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPmexpression([NotNull] CPP14Parser.PmexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.multiplicativeexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeexpression([NotNull] CPP14Parser.MultiplicativeexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.multiplicativeexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeexpression([NotNull] CPP14Parser.MultiplicativeexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.additiveexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveexpression([NotNull] CPP14Parser.AdditiveexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.additiveexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveexpression([NotNull] CPP14Parser.AdditiveexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.shiftexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftexpression([NotNull] CPP14Parser.ShiftexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.shiftexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftexpression([NotNull] CPP14Parser.ShiftexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.shiftoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftoperator([NotNull] CPP14Parser.ShiftoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.shiftoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftoperator([NotNull] CPP14Parser.ShiftoperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.relationalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalexpression([NotNull] CPP14Parser.RelationalexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.relationalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalexpression([NotNull] CPP14Parser.RelationalexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.equalityexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityexpression([NotNull] CPP14Parser.EqualityexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.equalityexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityexpression([NotNull] CPP14Parser.EqualityexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.andexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndexpression([NotNull] CPP14Parser.AndexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.andexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndexpression([NotNull] CPP14Parser.AndexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exclusiveorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusiveorexpression([NotNull] CPP14Parser.ExclusiveorexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exclusiveorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusiveorexpression([NotNull] CPP14Parser.ExclusiveorexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.inclusiveorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclusiveorexpression([NotNull] CPP14Parser.InclusiveorexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.inclusiveorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclusiveorexpression([NotNull] CPP14Parser.InclusiveorexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.logicalandexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalandexpression([NotNull] CPP14Parser.LogicalandexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.logicalandexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalandexpression([NotNull] CPP14Parser.LogicalandexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.logicalorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalorexpression([NotNull] CPP14Parser.LogicalorexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.logicalorexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalorexpression([NotNull] CPP14Parser.LogicalorexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conditionalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalexpression([NotNull] CPP14Parser.ConditionalexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conditionalexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalexpression([NotNull] CPP14Parser.ConditionalexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.assignmentexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentexpression([NotNull] CPP14Parser.AssignmentexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.assignmentexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentexpression([NotNull] CPP14Parser.AssignmentexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.assignmentoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentoperator([NotNull] CPP14Parser.AssignmentoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.assignmentoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentoperator([NotNull] CPP14Parser.AssignmentoperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CPP14Parser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CPP14Parser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.constantexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantexpression([NotNull] CPP14Parser.ConstantexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.constantexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantexpression([NotNull] CPP14Parser.ConstantexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CPP14Parser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CPP14Parser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.labeledstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledstatement([NotNull] CPP14Parser.LabeledstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.labeledstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledstatement([NotNull] CPP14Parser.LabeledstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expressionstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionstatement([NotNull] CPP14Parser.ExpressionstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expressionstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionstatement([NotNull] CPP14Parser.ExpressionstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.compoundstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundstatement([NotNull] CPP14Parser.CompoundstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.compoundstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundstatement([NotNull] CPP14Parser.CompoundstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.statementseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementseq([NotNull] CPP14Parser.StatementseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.statementseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementseq([NotNull] CPP14Parser.StatementseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.selectionstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectionstatement([NotNull] CPP14Parser.SelectionstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.selectionstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectionstatement([NotNull] CPP14Parser.SelectionstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] CPP14Parser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] CPP14Parser.ConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.iterationstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterationstatement([NotNull] CPP14Parser.IterationstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.iterationstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterationstatement([NotNull] CPP14Parser.IterationstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forinitstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForinitstatement([NotNull] CPP14Parser.ForinitstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forinitstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForinitstatement([NotNull] CPP14Parser.ForinitstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forrangedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForrangedeclaration([NotNull] CPP14Parser.ForrangedeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forrangedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForrangedeclaration([NotNull] CPP14Parser.ForrangedeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forrangeinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForrangeinitializer([NotNull] CPP14Parser.ForrangeinitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forrangeinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForrangeinitializer([NotNull] CPP14Parser.ForrangeinitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.jumpstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJumpstatement([NotNull] CPP14Parser.JumpstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.jumpstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJumpstatement([NotNull] CPP14Parser.JumpstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarationstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationstatement([NotNull] CPP14Parser.DeclarationstatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarationstatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationstatement([NotNull] CPP14Parser.DeclarationstatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarationseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationseq([NotNull] CPP14Parser.DeclarationseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarationseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationseq([NotNull] CPP14Parser.DeclarationseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] CPP14Parser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] CPP14Parser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.blockdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockdeclaration([NotNull] CPP14Parser.BlockdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.blockdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockdeclaration([NotNull] CPP14Parser.BlockdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.aliasdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAliasdeclaration([NotNull] CPP14Parser.AliasdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.aliasdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAliasdeclaration([NotNull] CPP14Parser.AliasdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpledeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpledeclaration([NotNull] CPP14Parser.SimpledeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpledeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpledeclaration([NotNull] CPP14Parser.SimpledeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.static_assertdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatic_assertdeclaration([NotNull] CPP14Parser.Static_assertdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.static_assertdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatic_assertdeclaration([NotNull] CPP14Parser.Static_assertdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.emptydeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEmptydeclaration([NotNull] CPP14Parser.EmptydeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.emptydeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEmptydeclaration([NotNull] CPP14Parser.EmptydeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributedeclaration([NotNull] CPP14Parser.AttributedeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributedeclaration([NotNull] CPP14Parser.AttributedeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclspecifier([NotNull] CPP14Parser.DeclspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclspecifier([NotNull] CPP14Parser.DeclspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declspecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclspecifierseq([NotNull] CPP14Parser.DeclspecifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declspecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclspecifierseq([NotNull] CPP14Parser.DeclspecifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.storageclassspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStorageclassspecifier([NotNull] CPP14Parser.StorageclassspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.storageclassspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStorageclassspecifier([NotNull] CPP14Parser.StorageclassspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functionspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionspecifier([NotNull] CPP14Parser.FunctionspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functionspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionspecifier([NotNull] CPP14Parser.FunctionspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typedefname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypedefname([NotNull] CPP14Parser.TypedefnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typedefname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypedefname([NotNull] CPP14Parser.TypedefnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypespecifier([NotNull] CPP14Parser.TypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypespecifier([NotNull] CPP14Parser.TypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingtypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrailingtypespecifier([NotNull] CPP14Parser.TrailingtypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingtypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrailingtypespecifier([NotNull] CPP14Parser.TrailingtypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypespecifierseq([NotNull] CPP14Parser.TypespecifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypespecifierseq([NotNull] CPP14Parser.TypespecifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingtypespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrailingtypespecifierseq([NotNull] CPP14Parser.TrailingtypespecifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingtypespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrailingtypespecifierseq([NotNull] CPP14Parser.TrailingtypespecifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpletypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpletypespecifier([NotNull] CPP14Parser.SimpletypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpletypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpletypespecifier([NotNull] CPP14Parser.SimpletypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.thetypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThetypename([NotNull] CPP14Parser.ThetypenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.thetypename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThetypename([NotNull] CPP14Parser.ThetypenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.decltypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDecltypespecifier([NotNull] CPP14Parser.DecltypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.decltypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDecltypespecifier([NotNull] CPP14Parser.DecltypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.elaboratedtypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElaboratedtypespecifier([NotNull] CPP14Parser.ElaboratedtypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.elaboratedtypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElaboratedtypespecifier([NotNull] CPP14Parser.ElaboratedtypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumname([NotNull] CPP14Parser.EnumnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumname([NotNull] CPP14Parser.EnumnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumspecifier([NotNull] CPP14Parser.EnumspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumspecifier([NotNull] CPP14Parser.EnumspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumhead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumhead([NotNull] CPP14Parser.EnumheadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumhead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumhead([NotNull] CPP14Parser.EnumheadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.opaqueenumdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOpaqueenumdeclaration([NotNull] CPP14Parser.OpaqueenumdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.opaqueenumdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOpaqueenumdeclaration([NotNull] CPP14Parser.OpaqueenumdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumkey([NotNull] CPP14Parser.EnumkeyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumkey([NotNull] CPP14Parser.EnumkeyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumbase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumbase([NotNull] CPP14Parser.EnumbaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumbase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumbase([NotNull] CPP14Parser.EnumbaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumeratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumeratorlist([NotNull] CPP14Parser.EnumeratorlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumeratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumeratorlist([NotNull] CPP14Parser.EnumeratorlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumeratordefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumeratordefinition([NotNull] CPP14Parser.EnumeratordefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumeratordefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumeratordefinition([NotNull] CPP14Parser.EnumeratordefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumerator([NotNull] CPP14Parser.EnumeratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumerator([NotNull] CPP14Parser.EnumeratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespacename([NotNull] CPP14Parser.NamespacenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespacename([NotNull] CPP14Parser.NamespacenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.originalnamespacename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOriginalnamespacename([NotNull] CPP14Parser.OriginalnamespacenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.originalnamespacename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOriginalnamespacename([NotNull] CPP14Parser.OriginalnamespacenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespacedefinition([NotNull] CPP14Parser.NamespacedefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespacedefinition([NotNull] CPP14Parser.NamespacedefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namednamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamednamespacedefinition([NotNull] CPP14Parser.NamednamespacedefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namednamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamednamespacedefinition([NotNull] CPP14Parser.NamednamespacedefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.originalnamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOriginalnamespacedefinition([NotNull] CPP14Parser.OriginalnamespacedefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.originalnamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOriginalnamespacedefinition([NotNull] CPP14Parser.OriginalnamespacedefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.extensionnamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExtensionnamespacedefinition([NotNull] CPP14Parser.ExtensionnamespacedefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.extensionnamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExtensionnamespacedefinition([NotNull] CPP14Parser.ExtensionnamespacedefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unnamednamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnnamednamespacedefinition([NotNull] CPP14Parser.UnnamednamespacedefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unnamednamespacedefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnnamednamespacedefinition([NotNull] CPP14Parser.UnnamednamespacedefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacebody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespacebody([NotNull] CPP14Parser.NamespacebodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacebody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespacebody([NotNull] CPP14Parser.NamespacebodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacealias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespacealias([NotNull] CPP14Parser.NamespacealiasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacealias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespacealias([NotNull] CPP14Parser.NamespacealiasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacealiasdefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamespacealiasdefinition([NotNull] CPP14Parser.NamespacealiasdefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacealiasdefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamespacealiasdefinition([NotNull] CPP14Parser.NamespacealiasdefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.qualifiednamespacespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiednamespacespecifier([NotNull] CPP14Parser.QualifiednamespacespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.qualifiednamespacespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiednamespacespecifier([NotNull] CPP14Parser.QualifiednamespacespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.usingdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingdeclaration([NotNull] CPP14Parser.UsingdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.usingdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingdeclaration([NotNull] CPP14Parser.UsingdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.usingdirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsingdirective([NotNull] CPP14Parser.UsingdirectiveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.usingdirective"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsingdirective([NotNull] CPP14Parser.UsingdirectiveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.asmdefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsmdefinition([NotNull] CPP14Parser.AsmdefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.asmdefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsmdefinition([NotNull] CPP14Parser.AsmdefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.linkagespecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLinkagespecification([NotNull] CPP14Parser.LinkagespecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.linkagespecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLinkagespecification([NotNull] CPP14Parser.LinkagespecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributespecifierseq([NotNull] CPP14Parser.AttributespecifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributespecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributespecifierseq([NotNull] CPP14Parser.AttributespecifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributespecifier([NotNull] CPP14Parser.AttributespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributespecifier([NotNull] CPP14Parser.AttributespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.alignmentspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlignmentspecifier([NotNull] CPP14Parser.AlignmentspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.alignmentspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlignmentspecifier([NotNull] CPP14Parser.AlignmentspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributelist([NotNull] CPP14Parser.AttributelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributelist([NotNull] CPP14Parser.AttributelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttribute([NotNull] CPP14Parser.AttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttribute([NotNull] CPP14Parser.AttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributetoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributetoken([NotNull] CPP14Parser.AttributetokenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributetoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributetoken([NotNull] CPP14Parser.AttributetokenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributescopedtoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributescopedtoken([NotNull] CPP14Parser.AttributescopedtokenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributescopedtoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributescopedtoken([NotNull] CPP14Parser.AttributescopedtokenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributenamespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributenamespace([NotNull] CPP14Parser.AttributenamespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributenamespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributenamespace([NotNull] CPP14Parser.AttributenamespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributeargumentclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAttributeargumentclause([NotNull] CPP14Parser.AttributeargumentclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributeargumentclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAttributeargumentclause([NotNull] CPP14Parser.AttributeargumentclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.balancedtokenseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBalancedtokenseq([NotNull] CPP14Parser.BalancedtokenseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.balancedtokenseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBalancedtokenseq([NotNull] CPP14Parser.BalancedtokenseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.balancedtoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBalancedtoken([NotNull] CPP14Parser.BalancedtokenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.balancedtoken"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBalancedtoken([NotNull] CPP14Parser.BalancedtokenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initdeclaratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitdeclaratorlist([NotNull] CPP14Parser.InitdeclaratorlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initdeclaratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitdeclaratorlist([NotNull] CPP14Parser.InitdeclaratorlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitdeclarator([NotNull] CPP14Parser.InitdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitdeclarator([NotNull] CPP14Parser.InitdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarator([NotNull] CPP14Parser.DeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarator([NotNull] CPP14Parser.DeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptrdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPtrdeclarator([NotNull] CPP14Parser.PtrdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptrdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPtrdeclarator([NotNull] CPP14Parser.PtrdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoptrdeclarator([NotNull] CPP14Parser.NoptrdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoptrdeclarator([NotNull] CPP14Parser.NoptrdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parametersandqualifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParametersandqualifiers([NotNull] CPP14Parser.ParametersandqualifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parametersandqualifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParametersandqualifiers([NotNull] CPP14Parser.ParametersandqualifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingreturntype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrailingreturntype([NotNull] CPP14Parser.TrailingreturntypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingreturntype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrailingreturntype([NotNull] CPP14Parser.TrailingreturntypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptroperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPtroperator([NotNull] CPP14Parser.PtroperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptroperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPtroperator([NotNull] CPP14Parser.PtroperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.cvqualifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCvqualifierseq([NotNull] CPP14Parser.CvqualifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.cvqualifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCvqualifierseq([NotNull] CPP14Parser.CvqualifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.cvqualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCvqualifier([NotNull] CPP14Parser.CvqualifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.cvqualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCvqualifier([NotNull] CPP14Parser.CvqualifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.refqualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRefqualifier([NotNull] CPP14Parser.RefqualifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.refqualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRefqualifier([NotNull] CPP14Parser.RefqualifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declaratorid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaratorid([NotNull] CPP14Parser.DeclaratoridContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declaratorid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaratorid([NotNull] CPP14Parser.DeclaratoridContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.thetypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThetypeid([NotNull] CPP14Parser.ThetypeidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.thetypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThetypeid([NotNull] CPP14Parser.ThetypeidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.abstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAbstractdeclarator([NotNull] CPP14Parser.AbstractdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.abstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAbstractdeclarator([NotNull] CPP14Parser.AbstractdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptrabstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPtrabstractdeclarator([NotNull] CPP14Parser.PtrabstractdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptrabstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPtrabstractdeclarator([NotNull] CPP14Parser.PtrabstractdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrabstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoptrabstractdeclarator([NotNull] CPP14Parser.NoptrabstractdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrabstractdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoptrabstractdeclarator([NotNull] CPP14Parser.NoptrabstractdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.abstractpackdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAbstractpackdeclarator([NotNull] CPP14Parser.AbstractpackdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.abstractpackdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAbstractpackdeclarator([NotNull] CPP14Parser.AbstractpackdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrabstractpackdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoptrabstractpackdeclarator([NotNull] CPP14Parser.NoptrabstractpackdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrabstractpackdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoptrabstractpackdeclarator([NotNull] CPP14Parser.NoptrabstractpackdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclarationclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterdeclarationclause([NotNull] CPP14Parser.ParameterdeclarationclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclarationclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterdeclarationclause([NotNull] CPP14Parser.ParameterdeclarationclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclarationlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterdeclarationlist([NotNull] CPP14Parser.ParameterdeclarationlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclarationlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterdeclarationlist([NotNull] CPP14Parser.ParameterdeclarationlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterdeclaration([NotNull] CPP14Parser.ParameterdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterdeclaration([NotNull] CPP14Parser.ParameterdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functiondefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctiondefinition([NotNull] CPP14Parser.FunctiondefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functiondefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctiondefinition([NotNull] CPP14Parser.FunctiondefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functionbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionbody([NotNull] CPP14Parser.FunctionbodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functionbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionbody([NotNull] CPP14Parser.FunctionbodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializer([NotNull] CPP14Parser.InitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializer([NotNull] CPP14Parser.InitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.braceorequalinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBraceorequalinitializer([NotNull] CPP14Parser.BraceorequalinitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.braceorequalinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBraceorequalinitializer([NotNull] CPP14Parser.BraceorequalinitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializerclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializerclause([NotNull] CPP14Parser.InitializerclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializerclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializerclause([NotNull] CPP14Parser.InitializerclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializerlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializerlist([NotNull] CPP14Parser.InitializerlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializerlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializerlist([NotNull] CPP14Parser.InitializerlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.bracedinitlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBracedinitlist([NotNull] CPP14Parser.BracedinitlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.bracedinitlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBracedinitlist([NotNull] CPP14Parser.BracedinitlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassname([NotNull] CPP14Parser.ClassnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassname([NotNull] CPP14Parser.ClassnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassspecifier([NotNull] CPP14Parser.ClassspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassspecifier([NotNull] CPP14Parser.ClassspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classhead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClasshead([NotNull] CPP14Parser.ClassheadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classhead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClasshead([NotNull] CPP14Parser.ClassheadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classheadname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassheadname([NotNull] CPP14Parser.ClassheadnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classheadname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassheadname([NotNull] CPP14Parser.ClassheadnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classvirtspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassvirtspecifier([NotNull] CPP14Parser.ClassvirtspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classvirtspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassvirtspecifier([NotNull] CPP14Parser.ClassvirtspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClasskey([NotNull] CPP14Parser.ClasskeyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classkey"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClasskey([NotNull] CPP14Parser.ClasskeyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberspecification([NotNull] CPP14Parser.MemberspecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberspecification([NotNull] CPP14Parser.MemberspecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberdeclaration([NotNull] CPP14Parser.MemberdeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberdeclaration([NotNull] CPP14Parser.MemberdeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclaratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberdeclaratorlist([NotNull] CPP14Parser.MemberdeclaratorlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclaratorlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberdeclaratorlist([NotNull] CPP14Parser.MemberdeclaratorlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberdeclarator([NotNull] CPP14Parser.MemberdeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberdeclarator([NotNull] CPP14Parser.MemberdeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.virtspecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVirtspecifierseq([NotNull] CPP14Parser.VirtspecifierseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.virtspecifierseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVirtspecifierseq([NotNull] CPP14Parser.VirtspecifierseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.virtspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVirtspecifier([NotNull] CPP14Parser.VirtspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.virtspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVirtspecifier([NotNull] CPP14Parser.VirtspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.purespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPurespecifier([NotNull] CPP14Parser.PurespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.purespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPurespecifier([NotNull] CPP14Parser.PurespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.baseclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBaseclause([NotNull] CPP14Parser.BaseclauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.baseclause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBaseclause([NotNull] CPP14Parser.BaseclauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basespecifierlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasespecifierlist([NotNull] CPP14Parser.BasespecifierlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basespecifierlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasespecifierlist([NotNull] CPP14Parser.BasespecifierlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasespecifier([NotNull] CPP14Parser.BasespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasespecifier([NotNull] CPP14Parser.BasespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classordecltype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassordecltype([NotNull] CPP14Parser.ClassordecltypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classordecltype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassordecltype([NotNull] CPP14Parser.ClassordecltypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basetypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBasetypespecifier([NotNull] CPP14Parser.BasetypespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basetypespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBasetypespecifier([NotNull] CPP14Parser.BasetypespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.accessspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccessspecifier([NotNull] CPP14Parser.AccessspecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.accessspecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccessspecifier([NotNull] CPP14Parser.AccessspecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversionfunctionid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversionfunctionid([NotNull] CPP14Parser.ConversionfunctionidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversionfunctionid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversionfunctionid([NotNull] CPP14Parser.ConversionfunctionidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversiontypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversiontypeid([NotNull] CPP14Parser.ConversiontypeidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversiontypeid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversiontypeid([NotNull] CPP14Parser.ConversiontypeidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversiondeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConversiondeclarator([NotNull] CPP14Parser.ConversiondeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversiondeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConversiondeclarator([NotNull] CPP14Parser.ConversiondeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ctorinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCtorinitializer([NotNull] CPP14Parser.CtorinitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ctorinitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCtorinitializer([NotNull] CPP14Parser.CtorinitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializerlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMeminitializerlist([NotNull] CPP14Parser.MeminitializerlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializerlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMeminitializerlist([NotNull] CPP14Parser.MeminitializerlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMeminitializer([NotNull] CPP14Parser.MeminitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMeminitializer([NotNull] CPP14Parser.MeminitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializerid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMeminitializerid([NotNull] CPP14Parser.MeminitializeridContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializerid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMeminitializerid([NotNull] CPP14Parser.MeminitializeridContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.operatorfunctionid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorfunctionid([NotNull] CPP14Parser.OperatorfunctionidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.operatorfunctionid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorfunctionid([NotNull] CPP14Parser.OperatorfunctionidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.literaloperatorid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteraloperatorid([NotNull] CPP14Parser.LiteraloperatoridContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.literaloperatorid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteraloperatorid([NotNull] CPP14Parser.LiteraloperatoridContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templatedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplatedeclaration([NotNull] CPP14Parser.TemplatedeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templatedeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplatedeclaration([NotNull] CPP14Parser.TemplatedeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateparameterlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateparameterlist([NotNull] CPP14Parser.TemplateparameterlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateparameterlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateparameterlist([NotNull] CPP14Parser.TemplateparameterlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateparameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateparameter([NotNull] CPP14Parser.TemplateparameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateparameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateparameter([NotNull] CPP14Parser.TemplateparameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeparameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeparameter([NotNull] CPP14Parser.TypeparameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeparameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeparameter([NotNull] CPP14Parser.TypeparameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpletemplateid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpletemplateid([NotNull] CPP14Parser.SimpletemplateidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpletemplateid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpletemplateid([NotNull] CPP14Parser.SimpletemplateidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateid([NotNull] CPP14Parser.TemplateidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateid([NotNull] CPP14Parser.TemplateidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templatename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplatename([NotNull] CPP14Parser.TemplatenameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templatename"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplatename([NotNull] CPP14Parser.TemplatenameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateargumentlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateargumentlist([NotNull] CPP14Parser.TemplateargumentlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateargumentlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateargumentlist([NotNull] CPP14Parser.TemplateargumentlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateargument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemplateargument([NotNull] CPP14Parser.TemplateargumentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateargument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemplateargument([NotNull] CPP14Parser.TemplateargumentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typenamespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypenamespecifier([NotNull] CPP14Parser.TypenamespecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typenamespecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypenamespecifier([NotNull] CPP14Parser.TypenamespecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.explicitinstantiation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicitinstantiation([NotNull] CPP14Parser.ExplicitinstantiationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.explicitinstantiation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicitinstantiation([NotNull] CPP14Parser.ExplicitinstantiationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.explicitspecialization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicitspecialization([NotNull] CPP14Parser.ExplicitspecializationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.explicitspecialization"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicitspecialization([NotNull] CPP14Parser.ExplicitspecializationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.tryblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTryblock([NotNull] CPP14Parser.TryblockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.tryblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTryblock([NotNull] CPP14Parser.TryblockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functiontryblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctiontryblock([NotNull] CPP14Parser.FunctiontryblockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functiontryblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctiontryblock([NotNull] CPP14Parser.FunctiontryblockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.handlerseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandlerseq([NotNull] CPP14Parser.HandlerseqContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.handlerseq"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandlerseq([NotNull] CPP14Parser.HandlerseqContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandler([NotNull] CPP14Parser.HandlerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.handler"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandler([NotNull] CPP14Parser.HandlerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exceptiondeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptiondeclaration([NotNull] CPP14Parser.ExceptiondeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exceptiondeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptiondeclaration([NotNull] CPP14Parser.ExceptiondeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.throwexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThrowexpression([NotNull] CPP14Parser.ThrowexpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.throwexpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThrowexpression([NotNull] CPP14Parser.ThrowexpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exceptionspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptionspecification([NotNull] CPP14Parser.ExceptionspecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exceptionspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptionspecification([NotNull] CPP14Parser.ExceptionspecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.dynamicexceptionspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDynamicexceptionspecification([NotNull] CPP14Parser.DynamicexceptionspecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.dynamicexceptionspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDynamicexceptionspecification([NotNull] CPP14Parser.DynamicexceptionspecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeidlist([NotNull] CPP14Parser.TypeidlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeidlist([NotNull] CPP14Parser.TypeidlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noexceptspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoexceptspecification([NotNull] CPP14Parser.NoexceptspecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noexceptspecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoexceptspecification([NotNull] CPP14Parser.NoexceptspecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.theoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTheoperator([NotNull] CPP14Parser.TheoperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.theoperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTheoperator([NotNull] CPP14Parser.TheoperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] CPP14Parser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] CPP14Parser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.booleanliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanliteral([NotNull] CPP14Parser.BooleanliteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.booleanliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanliteral([NotNull] CPP14Parser.BooleanliteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pointerliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointerliteral([NotNull] CPP14Parser.PointerliteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pointerliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointerliteral([NotNull] CPP14Parser.PointerliteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.userdefinedliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUserdefinedliteral([NotNull] CPP14Parser.UserdefinedliteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.userdefinedliteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUserdefinedliteral([NotNull] CPP14Parser.UserdefinedliteralContext context);
}
