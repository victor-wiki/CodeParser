using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface ICListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] CParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] CParser.PrimaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericSelection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenericSelection([NotNull] CParser.GenericSelectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericSelection"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenericSelection([NotNull] CParser.GenericSelectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericAssocList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenericAssocList([NotNull] CParser.GenericAssocListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericAssocList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenericAssocList([NotNull] CParser.GenericAssocListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.genericAssociation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGenericAssociation([NotNull] CParser.GenericAssociationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.genericAssociation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGenericAssociation([NotNull] CParser.GenericAssociationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPostfixExpression([NotNull] CParser.PostfixExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.postfixExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPostfixExpression([NotNull] CParser.PostfixExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgumentExpressionList([NotNull] CParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.argumentExpressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgumentExpressionList([NotNull] CParser.ArgumentExpressionListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpression([NotNull] CParser.UnaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.unaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpression([NotNull] CParser.UnaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.unaryOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryOperator([NotNull] CParser.UnaryOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.unaryOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryOperator([NotNull] CParser.UnaryOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastExpression([NotNull] CParser.CastExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.castExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastExpression([NotNull] CParser.CastExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultiplicativeExpression([NotNull] CParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.multiplicativeExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultiplicativeExpression([NotNull] CParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdditiveExpression([NotNull] CParser.AdditiveExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.additiveExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdditiveExpression([NotNull] CParser.AdditiveExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShiftExpression([NotNull] CParser.ShiftExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.shiftExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShiftExpression([NotNull] CParser.ShiftExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelationalExpression([NotNull] CParser.RelationalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.relationalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelationalExpression([NotNull] CParser.RelationalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqualityExpression([NotNull] CParser.EqualityExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.equalityExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqualityExpression([NotNull] CParser.EqualityExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAndExpression([NotNull] CParser.AndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.andExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAndExpression([NotNull] CParser.AndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExclusiveOrExpression([NotNull] CParser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.exclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExclusiveOrExpression([NotNull] CParser.ExclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInclusiveOrExpression([NotNull] CParser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.inclusiveOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInclusiveOrExpression([NotNull] CParser.InclusiveOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalAndExpression([NotNull] CParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.logicalAndExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalAndExpression([NotNull] CParser.LogicalAndExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogicalOrExpression([NotNull] CParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.logicalOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogicalOrExpression([NotNull] CParser.LogicalOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionalExpression([NotNull] CParser.ConditionalExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.conditionalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionalExpression([NotNull] CParser.ConditionalExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentExpression([NotNull] CParser.AssignmentExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.assignmentExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentExpression([NotNull] CParser.AssignmentExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentOperator([NotNull] CParser.AssignmentOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.assignmentOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentOperator([NotNull] CParser.AssignmentOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] CParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] CParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] CParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.constantExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] CParser.ConstantExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] CParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] CParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationSpecifiers([NotNull] CParser.DeclarationSpecifiersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifiers"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationSpecifiers([NotNull] CParser.DeclarationSpecifiersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifiers2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationSpecifiers2([NotNull] CParser.DeclarationSpecifiers2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifiers2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationSpecifiers2([NotNull] CParser.DeclarationSpecifiers2Context context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationSpecifier([NotNull] CParser.DeclarationSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationSpecifier([NotNull] CParser.DeclarationSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitDeclaratorList([NotNull] CParser.InitDeclaratorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitDeclaratorList([NotNull] CParser.InitDeclaratorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitDeclarator([NotNull] CParser.InitDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitDeclarator([NotNull] CParser.InitDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.storageClassSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStorageClassSpecifier([NotNull] CParser.StorageClassSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.storageClassSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStorageClassSpecifier([NotNull] CParser.StorageClassSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeSpecifier([NotNull] CParser.TypeSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeSpecifier([NotNull] CParser.TypeSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structOrUnionSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructOrUnionSpecifier([NotNull] CParser.StructOrUnionSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structOrUnionSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructOrUnionSpecifier([NotNull] CParser.StructOrUnionSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structOrUnion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructOrUnion([NotNull] CParser.StructOrUnionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structOrUnion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructOrUnion([NotNull] CParser.StructOrUnionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclarationList([NotNull] CParser.StructDeclarationListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclarationList([NotNull] CParser.StructDeclarationListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclaration([NotNull] CParser.StructDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclaration([NotNull] CParser.StructDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.specifierQualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpecifierQualifierList([NotNull] CParser.SpecifierQualifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.specifierQualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpecifierQualifierList([NotNull] CParser.SpecifierQualifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclaratorList([NotNull] CParser.StructDeclaratorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclaratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclaratorList([NotNull] CParser.StructDeclaratorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.structDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclarator([NotNull] CParser.StructDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.structDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclarator([NotNull] CParser.StructDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumSpecifier([NotNull] CParser.EnumSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumSpecifier([NotNull] CParser.EnumSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumeratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumeratorList([NotNull] CParser.EnumeratorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumeratorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumeratorList([NotNull] CParser.EnumeratorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumerator([NotNull] CParser.EnumeratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumerator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumerator([NotNull] CParser.EnumeratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.enumerationConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumerationConstant([NotNull] CParser.EnumerationConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.enumerationConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumerationConstant([NotNull] CParser.EnumerationConstantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.atomicTypeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtomicTypeSpecifier([NotNull] CParser.AtomicTypeSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.atomicTypeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtomicTypeSpecifier([NotNull] CParser.AtomicTypeSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeQualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeQualifier([NotNull] CParser.TypeQualifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeQualifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeQualifier([NotNull] CParser.TypeQualifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.functionSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionSpecifier([NotNull] CParser.FunctionSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.functionSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionSpecifier([NotNull] CParser.FunctionSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.alignmentSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlignmentSpecifier([NotNull] CParser.AlignmentSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.alignmentSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlignmentSpecifier([NotNull] CParser.AlignmentSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarator([NotNull] CParser.DeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarator([NotNull] CParser.DeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.directDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectDeclarator([NotNull] CParser.DirectDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.directDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectDeclarator([NotNull] CParser.DirectDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.vcSpecificModifer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVcSpecificModifer([NotNull] CParser.VcSpecificModiferContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.vcSpecificModifer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVcSpecificModifer([NotNull] CParser.VcSpecificModiferContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccDeclaratorExtension"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGccDeclaratorExtension([NotNull] CParser.GccDeclaratorExtensionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccDeclaratorExtension"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGccDeclaratorExtension([NotNull] CParser.GccDeclaratorExtensionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttributeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGccAttributeSpecifier([NotNull] CParser.GccAttributeSpecifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttributeSpecifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGccAttributeSpecifier([NotNull] CParser.GccAttributeSpecifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttributeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGccAttributeList([NotNull] CParser.GccAttributeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttributeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGccAttributeList([NotNull] CParser.GccAttributeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.gccAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGccAttribute([NotNull] CParser.GccAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.gccAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGccAttribute([NotNull] CParser.GccAttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.nestedParenthesesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNestedParenthesesBlock([NotNull] CParser.NestedParenthesesBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.nestedParenthesesBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNestedParenthesesBlock([NotNull] CParser.NestedParenthesesBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.pointer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointer([NotNull] CParser.PointerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.pointer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointer([NotNull] CParser.PointerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeQualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeQualifierList([NotNull] CParser.TypeQualifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeQualifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeQualifierList([NotNull] CParser.TypeQualifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterTypeList([NotNull] CParser.ParameterTypeListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterTypeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterTypeList([NotNull] CParser.ParameterTypeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] CParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] CParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.parameterDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterDeclaration([NotNull] CParser.ParameterDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.parameterDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterDeclaration([NotNull] CParser.ParameterDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierList([NotNull] CParser.IdentifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierList([NotNull] CParser.IdentifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] CParser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] CParser.TypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.abstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAbstractDeclarator([NotNull] CParser.AbstractDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.abstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAbstractDeclarator([NotNull] CParser.AbstractDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.directAbstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectAbstractDeclarator([NotNull] CParser.DirectAbstractDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.directAbstractDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectAbstractDeclarator([NotNull] CParser.DirectAbstractDeclaratorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.typedefName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypedefName([NotNull] CParser.TypedefNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.typedefName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypedefName([NotNull] CParser.TypedefNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializer([NotNull] CParser.InitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializer([NotNull] CParser.InitializerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.initializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInitializerList([NotNull] CParser.InitializerListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.initializerList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInitializerList([NotNull] CParser.InitializerListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDesignation([NotNull] CParser.DesignationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDesignation([NotNull] CParser.DesignationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designatorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDesignatorList([NotNull] CParser.DesignatorListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designatorList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDesignatorList([NotNull] CParser.DesignatorListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDesignator([NotNull] CParser.DesignatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.designator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDesignator([NotNull] CParser.DesignatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.staticAssertDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStaticAssertDeclaration([NotNull] CParser.StaticAssertDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.staticAssertDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStaticAssertDeclaration([NotNull] CParser.StaticAssertDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] CParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] CParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledStatement([NotNull] CParser.LabeledStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.labeledStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledStatement([NotNull] CParser.LabeledStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundStatement([NotNull] CParser.CompoundStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundStatement([NotNull] CParser.CompoundStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockItemList([NotNull] CParser.BlockItemListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.blockItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockItemList([NotNull] CParser.BlockItemListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlockItem([NotNull] CParser.BlockItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.blockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlockItem([NotNull] CParser.BlockItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionStatement([NotNull] CParser.ExpressionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.expressionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionStatement([NotNull] CParser.ExpressionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectionStatement([NotNull] CParser.SelectionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.selectionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectionStatement([NotNull] CParser.SelectionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterationStatement([NotNull] CParser.IterationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.iterationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterationStatement([NotNull] CParser.IterationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForCondition([NotNull] CParser.ForConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForCondition([NotNull] CParser.ForConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForDeclaration([NotNull] CParser.ForDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForDeclaration([NotNull] CParser.ForDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.forExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForExpression([NotNull] CParser.ForExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.forExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForExpression([NotNull] CParser.ForExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJumpStatement([NotNull] CParser.JumpStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.jumpStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJumpStatement([NotNull] CParser.JumpStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] CParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] CParser.CompilationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTranslationUnit([NotNull] CParser.TranslationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.translationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTranslationUnit([NotNull] CParser.TranslationUnitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExternalDeclaration([NotNull] CParser.ExternalDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.externalDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExternalDeclaration([NotNull] CParser.ExternalDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDefinition([NotNull] CParser.FunctionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.functionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDefinition([NotNull] CParser.FunctionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="CParser.declarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarationList([NotNull] CParser.DeclarationListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CParser.declarationList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarationList([NotNull] CParser.DeclarationListContext context);
}
