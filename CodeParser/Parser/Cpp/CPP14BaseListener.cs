using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICPP14Listener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class CPP14BaseListener : ICPP14Listener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.translationunit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTranslationunit([NotNull] CPP14Parser.TranslationunitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.translationunit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTranslationunit([NotNull] CPP14Parser.TranslationunitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.primaryexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryexpression([NotNull] CPP14Parser.PrimaryexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.primaryexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryexpression([NotNull] CPP14Parser.PrimaryexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.idexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdexpression([NotNull] CPP14Parser.IdexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.idexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdexpression([NotNull] CPP14Parser.IdexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unqualifiedid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnqualifiedid([NotNull] CPP14Parser.UnqualifiedidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unqualifiedid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnqualifiedid([NotNull] CPP14Parser.UnqualifiedidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.qualifiedid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiedid([NotNull] CPP14Parser.QualifiedidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.qualifiedid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiedid([NotNull] CPP14Parser.QualifiedidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.nestednamespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNestednamespecifier([NotNull] CPP14Parser.NestednamespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.nestednamespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNestednamespecifier([NotNull] CPP14Parser.NestednamespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdaexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaexpression([NotNull] CPP14Parser.LambdaexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdaexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaexpression([NotNull] CPP14Parser.LambdaexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdaintroducer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdaintroducer([NotNull] CPP14Parser.LambdaintroducerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdaintroducer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdaintroducer([NotNull] CPP14Parser.LambdaintroducerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdacapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdacapture([NotNull] CPP14Parser.LambdacaptureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdacapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdacapture([NotNull] CPP14Parser.LambdacaptureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capturedefault"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCapturedefault([NotNull] CPP14Parser.CapturedefaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capturedefault"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCapturedefault([NotNull] CPP14Parser.CapturedefaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capturelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCapturelist([NotNull] CPP14Parser.CapturelistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capturelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCapturelist([NotNull] CPP14Parser.CapturelistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.capture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCapture([NotNull] CPP14Parser.CaptureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.capture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCapture([NotNull] CPP14Parser.CaptureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simplecapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimplecapture([NotNull] CPP14Parser.SimplecaptureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simplecapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimplecapture([NotNull] CPP14Parser.SimplecaptureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initcapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitcapture([NotNull] CPP14Parser.InitcaptureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initcapture"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitcapture([NotNull] CPP14Parser.InitcaptureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.lambdadeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLambdadeclarator([NotNull] CPP14Parser.LambdadeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.lambdadeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLambdadeclarator([NotNull] CPP14Parser.LambdadeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.postfixexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixexpression([NotNull] CPP14Parser.PostfixexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.postfixexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixexpression([NotNull] CPP14Parser.PostfixexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidofexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeidofexpr([NotNull] CPP14Parser.TypeidofexprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidofexpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeidofexpr([NotNull] CPP14Parser.TypeidofexprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidofthetypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeidofthetypeid([NotNull] CPP14Parser.TypeidofthetypeidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidofthetypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeidofthetypeid([NotNull] CPP14Parser.TypeidofthetypeidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expressionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionlist([NotNull] CPP14Parser.ExpressionlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expressionlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionlist([NotNull] CPP14Parser.ExpressionlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pseudodestructorname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPseudodestructorname([NotNull] CPP14Parser.PseudodestructornameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pseudodestructorname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPseudodestructorname([NotNull] CPP14Parser.PseudodestructornameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unaryexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryexpression([NotNull] CPP14Parser.UnaryexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unaryexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryexpression([NotNull] CPP14Parser.UnaryexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unaryoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryoperator([NotNull] CPP14Parser.UnaryoperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unaryoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryoperator([NotNull] CPP14Parser.UnaryoperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewexpression([NotNull] CPP14Parser.NewexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewexpression([NotNull] CPP14Parser.NewexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newplacement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewplacement([NotNull] CPP14Parser.NewplacementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newplacement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewplacement([NotNull] CPP14Parser.NewplacementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newtypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewtypeid([NotNull] CPP14Parser.NewtypeidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newtypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewtypeid([NotNull] CPP14Parser.NewtypeidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewdeclarator([NotNull] CPP14Parser.NewdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewdeclarator([NotNull] CPP14Parser.NewdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrnewdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoptrnewdeclarator([NotNull] CPP14Parser.NoptrnewdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrnewdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoptrnewdeclarator([NotNull] CPP14Parser.NoptrnewdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.newinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNewinitializer([NotNull] CPP14Parser.NewinitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.newinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNewinitializer([NotNull] CPP14Parser.NewinitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.deleteexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteexpression([NotNull] CPP14Parser.DeleteexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.deleteexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteexpression([NotNull] CPP14Parser.DeleteexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noexceptexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoexceptexpression([NotNull] CPP14Parser.NoexceptexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noexceptexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoexceptexpression([NotNull] CPP14Parser.NoexceptexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.castexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastexpression([NotNull] CPP14Parser.CastexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.castexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastexpression([NotNull] CPP14Parser.CastexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pmexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPmexpression([NotNull] CPP14Parser.PmexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pmexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPmexpression([NotNull] CPP14Parser.PmexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.multiplicativeexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeexpression([NotNull] CPP14Parser.MultiplicativeexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.multiplicativeexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeexpression([NotNull] CPP14Parser.MultiplicativeexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.additiveexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveexpression([NotNull] CPP14Parser.AdditiveexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.additiveexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveexpression([NotNull] CPP14Parser.AdditiveexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.shiftexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftexpression([NotNull] CPP14Parser.ShiftexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.shiftexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftexpression([NotNull] CPP14Parser.ShiftexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.shiftoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftoperator([NotNull] CPP14Parser.ShiftoperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.shiftoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftoperator([NotNull] CPP14Parser.ShiftoperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.relationalexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalexpression([NotNull] CPP14Parser.RelationalexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.relationalexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalexpression([NotNull] CPP14Parser.RelationalexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.equalityexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityexpression([NotNull] CPP14Parser.EqualityexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.equalityexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityexpression([NotNull] CPP14Parser.EqualityexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.andexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndexpression([NotNull] CPP14Parser.AndexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.andexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndexpression([NotNull] CPP14Parser.AndexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exclusiveorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusiveorexpression([NotNull] CPP14Parser.ExclusiveorexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exclusiveorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusiveorexpression([NotNull] CPP14Parser.ExclusiveorexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.inclusiveorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInclusiveorexpression([NotNull] CPP14Parser.InclusiveorexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.inclusiveorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInclusiveorexpression([NotNull] CPP14Parser.InclusiveorexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.logicalandexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalandexpression([NotNull] CPP14Parser.LogicalandexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.logicalandexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalandexpression([NotNull] CPP14Parser.LogicalandexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.logicalorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalorexpression([NotNull] CPP14Parser.LogicalorexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.logicalorexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalorexpression([NotNull] CPP14Parser.LogicalorexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conditionalexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalexpression([NotNull] CPP14Parser.ConditionalexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conditionalexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalexpression([NotNull] CPP14Parser.ConditionalexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.assignmentexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentexpression([NotNull] CPP14Parser.AssignmentexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.assignmentexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentexpression([NotNull] CPP14Parser.AssignmentexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.assignmentoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentoperator([NotNull] CPP14Parser.AssignmentoperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.assignmentoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentoperator([NotNull] CPP14Parser.AssignmentoperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] CPP14Parser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] CPP14Parser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.constantexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantexpression([NotNull] CPP14Parser.ConstantexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.constantexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantexpression([NotNull] CPP14Parser.ConstantexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] CPP14Parser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] CPP14Parser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.labeledstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledstatement([NotNull] CPP14Parser.LabeledstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.labeledstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledstatement([NotNull] CPP14Parser.LabeledstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.expressionstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionstatement([NotNull] CPP14Parser.ExpressionstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.expressionstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionstatement([NotNull] CPP14Parser.ExpressionstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.compoundstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundstatement([NotNull] CPP14Parser.CompoundstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.compoundstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundstatement([NotNull] CPP14Parser.CompoundstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.statementseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementseq([NotNull] CPP14Parser.StatementseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.statementseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementseq([NotNull] CPP14Parser.StatementseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.selectionstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectionstatement([NotNull] CPP14Parser.SelectionstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.selectionstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectionstatement([NotNull] CPP14Parser.SelectionstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCondition([NotNull] CPP14Parser.ConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.condition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCondition([NotNull] CPP14Parser.ConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.iterationstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIterationstatement([NotNull] CPP14Parser.IterationstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.iterationstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIterationstatement([NotNull] CPP14Parser.IterationstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forinitstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForinitstatement([NotNull] CPP14Parser.ForinitstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forinitstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForinitstatement([NotNull] CPP14Parser.ForinitstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forrangedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForrangedeclaration([NotNull] CPP14Parser.ForrangedeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forrangedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForrangedeclaration([NotNull] CPP14Parser.ForrangedeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.forrangeinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForrangeinitializer([NotNull] CPP14Parser.ForrangeinitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.forrangeinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForrangeinitializer([NotNull] CPP14Parser.ForrangeinitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.jumpstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJumpstatement([NotNull] CPP14Parser.JumpstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.jumpstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJumpstatement([NotNull] CPP14Parser.JumpstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarationstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationstatement([NotNull] CPP14Parser.DeclarationstatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarationstatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationstatement([NotNull] CPP14Parser.DeclarationstatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarationseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationseq([NotNull] CPP14Parser.DeclarationseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarationseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationseq([NotNull] CPP14Parser.DeclarationseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] CPP14Parser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] CPP14Parser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.blockdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockdeclaration([NotNull] CPP14Parser.BlockdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.blockdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockdeclaration([NotNull] CPP14Parser.BlockdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.aliasdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAliasdeclaration([NotNull] CPP14Parser.AliasdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.aliasdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAliasdeclaration([NotNull] CPP14Parser.AliasdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpledeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpledeclaration([NotNull] CPP14Parser.SimpledeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpledeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpledeclaration([NotNull] CPP14Parser.SimpledeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.static_assertdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatic_assertdeclaration([NotNull] CPP14Parser.Static_assertdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.static_assertdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatic_assertdeclaration([NotNull] CPP14Parser.Static_assertdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.emptydeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmptydeclaration([NotNull] CPP14Parser.EmptydeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.emptydeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmptydeclaration([NotNull] CPP14Parser.EmptydeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributedeclaration([NotNull] CPP14Parser.AttributedeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributedeclaration([NotNull] CPP14Parser.AttributedeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclspecifier([NotNull] CPP14Parser.DeclspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclspecifier([NotNull] CPP14Parser.DeclspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declspecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclspecifierseq([NotNull] CPP14Parser.DeclspecifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declspecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclspecifierseq([NotNull] CPP14Parser.DeclspecifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.storageclassspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStorageclassspecifier([NotNull] CPP14Parser.StorageclassspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.storageclassspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStorageclassspecifier([NotNull] CPP14Parser.StorageclassspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functionspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionspecifier([NotNull] CPP14Parser.FunctionspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functionspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionspecifier([NotNull] CPP14Parser.FunctionspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typedefname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypedefname([NotNull] CPP14Parser.TypedefnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typedefname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypedefname([NotNull] CPP14Parser.TypedefnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypespecifier([NotNull] CPP14Parser.TypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypespecifier([NotNull] CPP14Parser.TypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingtypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrailingtypespecifier([NotNull] CPP14Parser.TrailingtypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingtypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrailingtypespecifier([NotNull] CPP14Parser.TrailingtypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypespecifierseq([NotNull] CPP14Parser.TypespecifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypespecifierseq([NotNull] CPP14Parser.TypespecifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingtypespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrailingtypespecifierseq([NotNull] CPP14Parser.TrailingtypespecifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingtypespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrailingtypespecifierseq([NotNull] CPP14Parser.TrailingtypespecifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpletypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpletypespecifier([NotNull] CPP14Parser.SimpletypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpletypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpletypespecifier([NotNull] CPP14Parser.SimpletypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.thetypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThetypename([NotNull] CPP14Parser.ThetypenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.thetypename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThetypename([NotNull] CPP14Parser.ThetypenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.decltypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecltypespecifier([NotNull] CPP14Parser.DecltypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.decltypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecltypespecifier([NotNull] CPP14Parser.DecltypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.elaboratedtypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElaboratedtypespecifier([NotNull] CPP14Parser.ElaboratedtypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.elaboratedtypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElaboratedtypespecifier([NotNull] CPP14Parser.ElaboratedtypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumname([NotNull] CPP14Parser.EnumnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumname([NotNull] CPP14Parser.EnumnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumspecifier([NotNull] CPP14Parser.EnumspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumspecifier([NotNull] CPP14Parser.EnumspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumhead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumhead([NotNull] CPP14Parser.EnumheadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumhead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumhead([NotNull] CPP14Parser.EnumheadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.opaqueenumdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOpaqueenumdeclaration([NotNull] CPP14Parser.OpaqueenumdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.opaqueenumdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOpaqueenumdeclaration([NotNull] CPP14Parser.OpaqueenumdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumkey([NotNull] CPP14Parser.EnumkeyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumkey([NotNull] CPP14Parser.EnumkeyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumbase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumbase([NotNull] CPP14Parser.EnumbaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumbase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumbase([NotNull] CPP14Parser.EnumbaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumeratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumeratorlist([NotNull] CPP14Parser.EnumeratorlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumeratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumeratorlist([NotNull] CPP14Parser.EnumeratorlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumeratordefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumeratordefinition([NotNull] CPP14Parser.EnumeratordefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumeratordefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumeratordefinition([NotNull] CPP14Parser.EnumeratordefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.enumerator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumerator([NotNull] CPP14Parser.EnumeratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.enumerator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumerator([NotNull] CPP14Parser.EnumeratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespacename([NotNull] CPP14Parser.NamespacenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespacename([NotNull] CPP14Parser.NamespacenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.originalnamespacename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOriginalnamespacename([NotNull] CPP14Parser.OriginalnamespacenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.originalnamespacename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOriginalnamespacename([NotNull] CPP14Parser.OriginalnamespacenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespacedefinition([NotNull] CPP14Parser.NamespacedefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespacedefinition([NotNull] CPP14Parser.NamespacedefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namednamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamednamespacedefinition([NotNull] CPP14Parser.NamednamespacedefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namednamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamednamespacedefinition([NotNull] CPP14Parser.NamednamespacedefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.originalnamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOriginalnamespacedefinition([NotNull] CPP14Parser.OriginalnamespacedefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.originalnamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOriginalnamespacedefinition([NotNull] CPP14Parser.OriginalnamespacedefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.extensionnamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExtensionnamespacedefinition([NotNull] CPP14Parser.ExtensionnamespacedefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.extensionnamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExtensionnamespacedefinition([NotNull] CPP14Parser.ExtensionnamespacedefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.unnamednamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnnamednamespacedefinition([NotNull] CPP14Parser.UnnamednamespacedefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.unnamednamespacedefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnnamednamespacedefinition([NotNull] CPP14Parser.UnnamednamespacedefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacebody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespacebody([NotNull] CPP14Parser.NamespacebodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacebody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespacebody([NotNull] CPP14Parser.NamespacebodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacealias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespacealias([NotNull] CPP14Parser.NamespacealiasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacealias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespacealias([NotNull] CPP14Parser.NamespacealiasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.namespacealiasdefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNamespacealiasdefinition([NotNull] CPP14Parser.NamespacealiasdefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.namespacealiasdefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNamespacealiasdefinition([NotNull] CPP14Parser.NamespacealiasdefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.qualifiednamespacespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiednamespacespecifier([NotNull] CPP14Parser.QualifiednamespacespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.qualifiednamespacespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiednamespacespecifier([NotNull] CPP14Parser.QualifiednamespacespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.usingdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingdeclaration([NotNull] CPP14Parser.UsingdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.usingdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingdeclaration([NotNull] CPP14Parser.UsingdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.usingdirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsingdirective([NotNull] CPP14Parser.UsingdirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.usingdirective"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsingdirective([NotNull] CPP14Parser.UsingdirectiveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.asmdefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsmdefinition([NotNull] CPP14Parser.AsmdefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.asmdefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsmdefinition([NotNull] CPP14Parser.AsmdefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.linkagespecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLinkagespecification([NotNull] CPP14Parser.LinkagespecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.linkagespecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLinkagespecification([NotNull] CPP14Parser.LinkagespecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributespecifierseq([NotNull] CPP14Parser.AttributespecifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributespecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributespecifierseq([NotNull] CPP14Parser.AttributespecifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributespecifier([NotNull] CPP14Parser.AttributespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributespecifier([NotNull] CPP14Parser.AttributespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.alignmentspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlignmentspecifier([NotNull] CPP14Parser.AlignmentspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.alignmentspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlignmentspecifier([NotNull] CPP14Parser.AlignmentspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributelist([NotNull] CPP14Parser.AttributelistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributelist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributelist([NotNull] CPP14Parser.AttributelistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttribute([NotNull] CPP14Parser.AttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttribute([NotNull] CPP14Parser.AttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributetoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributetoken([NotNull] CPP14Parser.AttributetokenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributetoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributetoken([NotNull] CPP14Parser.AttributetokenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributescopedtoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributescopedtoken([NotNull] CPP14Parser.AttributescopedtokenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributescopedtoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributescopedtoken([NotNull] CPP14Parser.AttributescopedtokenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributenamespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributenamespace([NotNull] CPP14Parser.AttributenamespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributenamespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributenamespace([NotNull] CPP14Parser.AttributenamespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.attributeargumentclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttributeargumentclause([NotNull] CPP14Parser.AttributeargumentclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.attributeargumentclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttributeargumentclause([NotNull] CPP14Parser.AttributeargumentclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.balancedtokenseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBalancedtokenseq([NotNull] CPP14Parser.BalancedtokenseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.balancedtokenseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBalancedtokenseq([NotNull] CPP14Parser.BalancedtokenseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.balancedtoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBalancedtoken([NotNull] CPP14Parser.BalancedtokenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.balancedtoken"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBalancedtoken([NotNull] CPP14Parser.BalancedtokenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initdeclaratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitdeclaratorlist([NotNull] CPP14Parser.InitdeclaratorlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initdeclaratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitdeclaratorlist([NotNull] CPP14Parser.InitdeclaratorlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitdeclarator([NotNull] CPP14Parser.InitdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitdeclarator([NotNull] CPP14Parser.InitdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarator([NotNull] CPP14Parser.DeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarator([NotNull] CPP14Parser.DeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptrdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPtrdeclarator([NotNull] CPP14Parser.PtrdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptrdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPtrdeclarator([NotNull] CPP14Parser.PtrdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoptrdeclarator([NotNull] CPP14Parser.NoptrdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoptrdeclarator([NotNull] CPP14Parser.NoptrdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parametersandqualifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParametersandqualifiers([NotNull] CPP14Parser.ParametersandqualifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parametersandqualifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParametersandqualifiers([NotNull] CPP14Parser.ParametersandqualifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.trailingreturntype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrailingreturntype([NotNull] CPP14Parser.TrailingreturntypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.trailingreturntype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrailingreturntype([NotNull] CPP14Parser.TrailingreturntypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptroperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPtroperator([NotNull] CPP14Parser.PtroperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptroperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPtroperator([NotNull] CPP14Parser.PtroperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.cvqualifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCvqualifierseq([NotNull] CPP14Parser.CvqualifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.cvqualifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCvqualifierseq([NotNull] CPP14Parser.CvqualifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.cvqualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCvqualifier([NotNull] CPP14Parser.CvqualifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.cvqualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCvqualifier([NotNull] CPP14Parser.CvqualifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.refqualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRefqualifier([NotNull] CPP14Parser.RefqualifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.refqualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRefqualifier([NotNull] CPP14Parser.RefqualifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.declaratorid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaratorid([NotNull] CPP14Parser.DeclaratoridContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.declaratorid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaratorid([NotNull] CPP14Parser.DeclaratoridContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.thetypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThetypeid([NotNull] CPP14Parser.ThetypeidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.thetypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThetypeid([NotNull] CPP14Parser.ThetypeidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.abstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAbstractdeclarator([NotNull] CPP14Parser.AbstractdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.abstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAbstractdeclarator([NotNull] CPP14Parser.AbstractdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ptrabstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPtrabstractdeclarator([NotNull] CPP14Parser.PtrabstractdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ptrabstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPtrabstractdeclarator([NotNull] CPP14Parser.PtrabstractdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrabstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoptrabstractdeclarator([NotNull] CPP14Parser.NoptrabstractdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrabstractdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoptrabstractdeclarator([NotNull] CPP14Parser.NoptrabstractdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.abstractpackdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAbstractpackdeclarator([NotNull] CPP14Parser.AbstractpackdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.abstractpackdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAbstractpackdeclarator([NotNull] CPP14Parser.AbstractpackdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noptrabstractpackdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoptrabstractpackdeclarator([NotNull] CPP14Parser.NoptrabstractpackdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noptrabstractpackdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoptrabstractpackdeclarator([NotNull] CPP14Parser.NoptrabstractpackdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclarationclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterdeclarationclause([NotNull] CPP14Parser.ParameterdeclarationclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclarationclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterdeclarationclause([NotNull] CPP14Parser.ParameterdeclarationclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclarationlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterdeclarationlist([NotNull] CPP14Parser.ParameterdeclarationlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclarationlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterdeclarationlist([NotNull] CPP14Parser.ParameterdeclarationlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.parameterdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterdeclaration([NotNull] CPP14Parser.ParameterdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.parameterdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterdeclaration([NotNull] CPP14Parser.ParameterdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functiondefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctiondefinition([NotNull] CPP14Parser.FunctiondefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functiondefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctiondefinition([NotNull] CPP14Parser.FunctiondefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functionbody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionbody([NotNull] CPP14Parser.FunctionbodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functionbody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionbody([NotNull] CPP14Parser.FunctionbodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializer([NotNull] CPP14Parser.InitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializer([NotNull] CPP14Parser.InitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.braceorequalinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBraceorequalinitializer([NotNull] CPP14Parser.BraceorequalinitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.braceorequalinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBraceorequalinitializer([NotNull] CPP14Parser.BraceorequalinitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializerclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializerclause([NotNull] CPP14Parser.InitializerclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializerclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializerclause([NotNull] CPP14Parser.InitializerclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.initializerlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializerlist([NotNull] CPP14Parser.InitializerlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.initializerlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializerlist([NotNull] CPP14Parser.InitializerlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.bracedinitlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBracedinitlist([NotNull] CPP14Parser.BracedinitlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.bracedinitlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBracedinitlist([NotNull] CPP14Parser.BracedinitlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassname([NotNull] CPP14Parser.ClassnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassname([NotNull] CPP14Parser.ClassnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassspecifier([NotNull] CPP14Parser.ClassspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassspecifier([NotNull] CPP14Parser.ClassspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classhead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClasshead([NotNull] CPP14Parser.ClassheadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classhead"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClasshead([NotNull] CPP14Parser.ClassheadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classheadname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassheadname([NotNull] CPP14Parser.ClassheadnameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classheadname"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassheadname([NotNull] CPP14Parser.ClassheadnameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classvirtspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassvirtspecifier([NotNull] CPP14Parser.ClassvirtspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classvirtspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassvirtspecifier([NotNull] CPP14Parser.ClassvirtspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClasskey([NotNull] CPP14Parser.ClasskeyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classkey"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClasskey([NotNull] CPP14Parser.ClasskeyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberspecification([NotNull] CPP14Parser.MemberspecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberspecification([NotNull] CPP14Parser.MemberspecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberdeclaration([NotNull] CPP14Parser.MemberdeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberdeclaration([NotNull] CPP14Parser.MemberdeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclaratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberdeclaratorlist([NotNull] CPP14Parser.MemberdeclaratorlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclaratorlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberdeclaratorlist([NotNull] CPP14Parser.MemberdeclaratorlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.memberdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMemberdeclarator([NotNull] CPP14Parser.MemberdeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.memberdeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMemberdeclarator([NotNull] CPP14Parser.MemberdeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.virtspecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVirtspecifierseq([NotNull] CPP14Parser.VirtspecifierseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.virtspecifierseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVirtspecifierseq([NotNull] CPP14Parser.VirtspecifierseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.virtspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVirtspecifier([NotNull] CPP14Parser.VirtspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.virtspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVirtspecifier([NotNull] CPP14Parser.VirtspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.purespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPurespecifier([NotNull] CPP14Parser.PurespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.purespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPurespecifier([NotNull] CPP14Parser.PurespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.baseclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBaseclause([NotNull] CPP14Parser.BaseclauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.baseclause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBaseclause([NotNull] CPP14Parser.BaseclauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basespecifierlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasespecifierlist([NotNull] CPP14Parser.BasespecifierlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basespecifierlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasespecifierlist([NotNull] CPP14Parser.BasespecifierlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasespecifier([NotNull] CPP14Parser.BasespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasespecifier([NotNull] CPP14Parser.BasespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.classordecltype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClassordecltype([NotNull] CPP14Parser.ClassordecltypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.classordecltype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClassordecltype([NotNull] CPP14Parser.ClassordecltypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.basetypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBasetypespecifier([NotNull] CPP14Parser.BasetypespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.basetypespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBasetypespecifier([NotNull] CPP14Parser.BasetypespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.accessspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccessspecifier([NotNull] CPP14Parser.AccessspecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.accessspecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccessspecifier([NotNull] CPP14Parser.AccessspecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversionfunctionid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConversionfunctionid([NotNull] CPP14Parser.ConversionfunctionidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversionfunctionid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConversionfunctionid([NotNull] CPP14Parser.ConversionfunctionidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversiontypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConversiontypeid([NotNull] CPP14Parser.ConversiontypeidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversiontypeid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConversiontypeid([NotNull] CPP14Parser.ConversiontypeidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.conversiondeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConversiondeclarator([NotNull] CPP14Parser.ConversiondeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.conversiondeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConversiondeclarator([NotNull] CPP14Parser.ConversiondeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.ctorinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCtorinitializer([NotNull] CPP14Parser.CtorinitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.ctorinitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCtorinitializer([NotNull] CPP14Parser.CtorinitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializerlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMeminitializerlist([NotNull] CPP14Parser.MeminitializerlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializerlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMeminitializerlist([NotNull] CPP14Parser.MeminitializerlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMeminitializer([NotNull] CPP14Parser.MeminitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMeminitializer([NotNull] CPP14Parser.MeminitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.meminitializerid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMeminitializerid([NotNull] CPP14Parser.MeminitializeridContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.meminitializerid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMeminitializerid([NotNull] CPP14Parser.MeminitializeridContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.operatorfunctionid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperatorfunctionid([NotNull] CPP14Parser.OperatorfunctionidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.operatorfunctionid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperatorfunctionid([NotNull] CPP14Parser.OperatorfunctionidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.literaloperatorid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteraloperatorid([NotNull] CPP14Parser.LiteraloperatoridContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.literaloperatorid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteraloperatorid([NotNull] CPP14Parser.LiteraloperatoridContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templatedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplatedeclaration([NotNull] CPP14Parser.TemplatedeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templatedeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplatedeclaration([NotNull] CPP14Parser.TemplatedeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateparameterlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplateparameterlist([NotNull] CPP14Parser.TemplateparameterlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateparameterlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplateparameterlist([NotNull] CPP14Parser.TemplateparameterlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateparameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplateparameter([NotNull] CPP14Parser.TemplateparameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateparameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplateparameter([NotNull] CPP14Parser.TemplateparameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeparameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeparameter([NotNull] CPP14Parser.TypeparameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeparameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeparameter([NotNull] CPP14Parser.TypeparameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.simpletemplateid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpletemplateid([NotNull] CPP14Parser.SimpletemplateidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.simpletemplateid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpletemplateid([NotNull] CPP14Parser.SimpletemplateidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplateid([NotNull] CPP14Parser.TemplateidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplateid([NotNull] CPP14Parser.TemplateidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templatename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplatename([NotNull] CPP14Parser.TemplatenameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templatename"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplatename([NotNull] CPP14Parser.TemplatenameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateargumentlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplateargumentlist([NotNull] CPP14Parser.TemplateargumentlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateargumentlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplateargumentlist([NotNull] CPP14Parser.TemplateargumentlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.templateargument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemplateargument([NotNull] CPP14Parser.TemplateargumentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.templateargument"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemplateargument([NotNull] CPP14Parser.TemplateargumentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typenamespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypenamespecifier([NotNull] CPP14Parser.TypenamespecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typenamespecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypenamespecifier([NotNull] CPP14Parser.TypenamespecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.explicitinstantiation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicitinstantiation([NotNull] CPP14Parser.ExplicitinstantiationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.explicitinstantiation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicitinstantiation([NotNull] CPP14Parser.ExplicitinstantiationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.explicitspecialization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicitspecialization([NotNull] CPP14Parser.ExplicitspecializationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.explicitspecialization"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicitspecialization([NotNull] CPP14Parser.ExplicitspecializationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.tryblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTryblock([NotNull] CPP14Parser.TryblockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.tryblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTryblock([NotNull] CPP14Parser.TryblockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.functiontryblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctiontryblock([NotNull] CPP14Parser.FunctiontryblockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.functiontryblock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctiontryblock([NotNull] CPP14Parser.FunctiontryblockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.handlerseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandlerseq([NotNull] CPP14Parser.HandlerseqContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.handlerseq"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandlerseq([NotNull] CPP14Parser.HandlerseqContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandler([NotNull] CPP14Parser.HandlerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.handler"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandler([NotNull] CPP14Parser.HandlerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exceptiondeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptiondeclaration([NotNull] CPP14Parser.ExceptiondeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exceptiondeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptiondeclaration([NotNull] CPP14Parser.ExceptiondeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.throwexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThrowexpression([NotNull] CPP14Parser.ThrowexpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.throwexpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThrowexpression([NotNull] CPP14Parser.ThrowexpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.exceptionspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptionspecification([NotNull] CPP14Parser.ExceptionspecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.exceptionspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptionspecification([NotNull] CPP14Parser.ExceptionspecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.dynamicexceptionspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDynamicexceptionspecification([NotNull] CPP14Parser.DynamicexceptionspecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.dynamicexceptionspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDynamicexceptionspecification([NotNull] CPP14Parser.DynamicexceptionspecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.typeidlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeidlist([NotNull] CPP14Parser.TypeidlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.typeidlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeidlist([NotNull] CPP14Parser.TypeidlistContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.noexceptspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoexceptspecification([NotNull] CPP14Parser.NoexceptspecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.noexceptspecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoexceptspecification([NotNull] CPP14Parser.NoexceptspecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.theoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTheoperator([NotNull] CPP14Parser.TheoperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.theoperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTheoperator([NotNull] CPP14Parser.TheoperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] CPP14Parser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] CPP14Parser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.booleanliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanliteral([NotNull] CPP14Parser.BooleanliteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.booleanliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanliteral([NotNull] CPP14Parser.BooleanliteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.pointerliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointerliteral([NotNull] CPP14Parser.PointerliteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.pointerliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointerliteral([NotNull] CPP14Parser.PointerliteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CPP14Parser.userdefinedliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUserdefinedliteral([NotNull] CPP14Parser.UserdefinedliteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CPP14Parser.userdefinedliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUserdefinedliteral([NotNull] CPP14Parser.UserdefinedliteralContext context) { }

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
