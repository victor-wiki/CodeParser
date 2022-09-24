using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ICListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class CBaseListener : ICListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.primaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExpression([NotNull] CParser.PrimaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.primaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExpression([NotNull] CParser.PrimaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericSelection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenericSelection([NotNull] CParser.GenericSelectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericSelection"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenericSelection([NotNull] CParser.GenericSelectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericAssocList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenericAssocList([NotNull] CParser.GenericAssocListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericAssocList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenericAssocList([NotNull] CParser.GenericAssocListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericAssociation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGenericAssociation([NotNull] CParser.GenericAssociationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericAssociation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGenericAssociation([NotNull] CParser.GenericAssociationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPostfixExpression([NotNull] CParser.PostfixExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.postfixExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPostfixExpression([NotNull] CParser.PostfixExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.argumentExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArgumentExpressionList([NotNull] CParser.ArgumentExpressionListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.argumentExpressionList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArgumentExpressionList([NotNull] CParser.ArgumentExpressionListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryExpression([NotNull] CParser.UnaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.unaryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryExpression([NotNull] CParser.UnaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.unaryOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnaryOperator([NotNull] CParser.UnaryOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.unaryOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnaryOperator([NotNull] CParser.UnaryOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastExpression([NotNull] CParser.CastExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.castExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastExpression([NotNull] CParser.CastExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMultiplicativeExpression([NotNull] CParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.multiplicativeExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMultiplicativeExpression([NotNull] CParser.MultiplicativeExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdditiveExpression([NotNull] CParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.additiveExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdditiveExpression([NotNull] CParser.AdditiveExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShiftExpression([NotNull] CParser.ShiftExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.shiftExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShiftExpression([NotNull] CParser.ShiftExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRelationalExpression([NotNull] CParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.relationalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRelationalExpression([NotNull] CParser.RelationalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqualityExpression([NotNull] CParser.EqualityExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.equalityExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqualityExpression([NotNull] CParser.EqualityExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndExpression([NotNull] CParser.AndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.andExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndExpression([NotNull] CParser.AndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExclusiveOrExpression([NotNull] CParser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.exclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExclusiveOrExpression([NotNull] CParser.ExclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInclusiveOrExpression([NotNull] CParser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.inclusiveOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInclusiveOrExpression([NotNull] CParser.InclusiveOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.logicalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalAndExpression([NotNull] CParser.LogicalAndExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.logicalAndExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalAndExpression([NotNull] CParser.LogicalAndExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.logicalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogicalOrExpression([NotNull] CParser.LogicalOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.logicalOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogicalOrExpression([NotNull] CParser.LogicalOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionalExpression([NotNull] CParser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.conditionalExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionalExpression([NotNull] CParser.ConditionalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentExpression([NotNull] CParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.assignmentExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentExpression([NotNull] CParser.AssignmentExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignmentOperator([NotNull] CParser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.assignmentOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignmentOperator([NotNull] CParser.AssignmentOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] CParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] CParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstantExpression([NotNull] CParser.ConstantExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.constantExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstantExpression([NotNull] CParser.ConstantExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] CParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] CParser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationSpecifiers([NotNull] CParser.DeclarationSpecifiersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifiers"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationSpecifiers([NotNull] CParser.DeclarationSpecifiersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifiers2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationSpecifiers2([NotNull] CParser.DeclarationSpecifiers2Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifiers2"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationSpecifiers2([NotNull] CParser.DeclarationSpecifiers2Context context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationSpecifier([NotNull] CParser.DeclarationSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationSpecifier([NotNull] CParser.DeclarationSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitDeclaratorList([NotNull] CParser.InitDeclaratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitDeclaratorList([NotNull] CParser.InitDeclaratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitDeclarator([NotNull] CParser.InitDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitDeclarator([NotNull] CParser.InitDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.storageClassSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStorageClassSpecifier([NotNull] CParser.StorageClassSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.storageClassSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStorageClassSpecifier([NotNull] CParser.StorageClassSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeSpecifier([NotNull] CParser.TypeSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeSpecifier([NotNull] CParser.TypeSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structOrUnionSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructOrUnionSpecifier([NotNull] CParser.StructOrUnionSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structOrUnionSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructOrUnionSpecifier([NotNull] CParser.StructOrUnionSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structOrUnion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructOrUnion([NotNull] CParser.StructOrUnionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structOrUnion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructOrUnion([NotNull] CParser.StructOrUnionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructDeclarationList([NotNull] CParser.StructDeclarationListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructDeclarationList([NotNull] CParser.StructDeclarationListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructDeclaration([NotNull] CParser.StructDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructDeclaration([NotNull] CParser.StructDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.specifierQualifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecifierQualifierList([NotNull] CParser.SpecifierQualifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.specifierQualifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecifierQualifierList([NotNull] CParser.SpecifierQualifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructDeclaratorList([NotNull] CParser.StructDeclaratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclaratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructDeclaratorList([NotNull] CParser.StructDeclaratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStructDeclarator([NotNull] CParser.StructDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStructDeclarator([NotNull] CParser.StructDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumSpecifier([NotNull] CParser.EnumSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumSpecifier([NotNull] CParser.EnumSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumeratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumeratorList([NotNull] CParser.EnumeratorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumeratorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumeratorList([NotNull] CParser.EnumeratorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumerator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumerator([NotNull] CParser.EnumeratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumerator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumerator([NotNull] CParser.EnumeratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumerationConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEnumerationConstant([NotNull] CParser.EnumerationConstantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumerationConstant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEnumerationConstant([NotNull] CParser.EnumerationConstantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.atomicTypeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtomicTypeSpecifier([NotNull] CParser.AtomicTypeSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.atomicTypeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtomicTypeSpecifier([NotNull] CParser.AtomicTypeSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeQualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeQualifier([NotNull] CParser.TypeQualifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeQualifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeQualifier([NotNull] CParser.TypeQualifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.functionSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionSpecifier([NotNull] CParser.FunctionSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.functionSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionSpecifier([NotNull] CParser.FunctionSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.alignmentSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlignmentSpecifier([NotNull] CParser.AlignmentSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.alignmentSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlignmentSpecifier([NotNull] CParser.AlignmentSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarator([NotNull] CParser.DeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarator([NotNull] CParser.DeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.directDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectDeclarator([NotNull] CParser.DirectDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.directDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectDeclarator([NotNull] CParser.DirectDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.vcSpecificModifer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVcSpecificModifer([NotNull] CParser.VcSpecificModiferContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.vcSpecificModifer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVcSpecificModifer([NotNull] CParser.VcSpecificModiferContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccDeclaratorExtension"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGccDeclaratorExtension([NotNull] CParser.GccDeclaratorExtensionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccDeclaratorExtension"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGccDeclaratorExtension([NotNull] CParser.GccDeclaratorExtensionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttributeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGccAttributeSpecifier([NotNull] CParser.GccAttributeSpecifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttributeSpecifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGccAttributeSpecifier([NotNull] CParser.GccAttributeSpecifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttributeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGccAttributeList([NotNull] CParser.GccAttributeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttributeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGccAttributeList([NotNull] CParser.GccAttributeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGccAttribute([NotNull] CParser.GccAttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGccAttribute([NotNull] CParser.GccAttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.nestedParenthesesBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNestedParenthesesBlock([NotNull] CParser.NestedParenthesesBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.nestedParenthesesBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNestedParenthesesBlock([NotNull] CParser.NestedParenthesesBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.pointer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointer([NotNull] CParser.PointerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.pointer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointer([NotNull] CParser.PointerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeQualifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeQualifierList([NotNull] CParser.TypeQualifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeQualifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeQualifierList([NotNull] CParser.TypeQualifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterTypeList([NotNull] CParser.ParameterTypeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterTypeList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterTypeList([NotNull] CParser.ParameterTypeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] CParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] CParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterDeclaration([NotNull] CParser.ParameterDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterDeclaration([NotNull] CParser.ParameterDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierList([NotNull] CParser.IdentifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierList([NotNull] CParser.IdentifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeName([NotNull] CParser.TypeNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeName([NotNull] CParser.TypeNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.abstractDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAbstractDeclarator([NotNull] CParser.AbstractDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.abstractDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAbstractDeclarator([NotNull] CParser.AbstractDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.directAbstractDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectAbstractDeclarator([NotNull] CParser.DirectAbstractDeclaratorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.directAbstractDeclarator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectAbstractDeclarator([NotNull] CParser.DirectAbstractDeclaratorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typedefName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypedefName([NotNull] CParser.TypedefNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typedefName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypedefName([NotNull] CParser.TypedefNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializer([NotNull] CParser.InitializerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initializer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializer([NotNull] CParser.InitializerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInitializerList([NotNull] CParser.InitializerListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initializerList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInitializerList([NotNull] CParser.InitializerListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDesignation([NotNull] CParser.DesignationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDesignation([NotNull] CParser.DesignationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designatorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDesignatorList([NotNull] CParser.DesignatorListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designatorList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDesignatorList([NotNull] CParser.DesignatorListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDesignator([NotNull] CParser.DesignatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDesignator([NotNull] CParser.DesignatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.staticAssertDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStaticAssertDeclaration([NotNull] CParser.StaticAssertDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.staticAssertDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStaticAssertDeclaration([NotNull] CParser.StaticAssertDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] CParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] CParser.StatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledStatement([NotNull] CParser.LabeledStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.labeledStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledStatement([NotNull] CParser.LabeledStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundStatement([NotNull] CParser.CompoundStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundStatement([NotNull] CParser.CompoundStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.blockItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockItemList([NotNull] CParser.BlockItemListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.blockItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockItemList([NotNull] CParser.BlockItemListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.blockItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlockItem([NotNull] CParser.BlockItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.blockItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlockItem([NotNull] CParser.BlockItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpressionStatement([NotNull] CParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.expressionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpressionStatement([NotNull] CParser.ExpressionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.selectionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectionStatement([NotNull] CParser.SelectionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.selectionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectionStatement([NotNull] CParser.SelectionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIterationStatement([NotNull] CParser.IterationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.iterationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIterationStatement([NotNull] CParser.IterationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForCondition([NotNull] CParser.ForConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForCondition([NotNull] CParser.ForConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForDeclaration([NotNull] CParser.ForDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForDeclaration([NotNull] CParser.ForDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterForExpression([NotNull] CParser.ForExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitForExpression([NotNull] CParser.ForExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.jumpStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJumpStatement([NotNull] CParser.JumpStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.jumpStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJumpStatement([NotNull] CParser.JumpStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompilationUnit([NotNull] CParser.CompilationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.compilationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompilationUnit([NotNull] CParser.CompilationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.translationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTranslationUnit([NotNull] CParser.TranslationUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.translationUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTranslationUnit([NotNull] CParser.TranslationUnitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.externalDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExternalDeclaration([NotNull] CParser.ExternalDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.externalDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExternalDeclaration([NotNull] CParser.ExternalDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.functionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDefinition([NotNull] CParser.FunctionDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.functionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDefinition([NotNull] CParser.FunctionDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclarationList([NotNull] CParser.DeclarationListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclarationList([NotNull] CParser.DeclarationListContext context) { }

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
