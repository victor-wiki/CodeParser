/*
 * Copyright (c) 2018, 2020, Oracle and/or its affiliates. All rights reserved.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License, version 2.0,
 * as published by the Free Software Foundation.
 *
 * This program is also distributed with certain software (including
 * but not limited to OpenSSL) that is licensed under separate terms, as
 * designated in a particular file or component or in included license
 * documentation. The authors of mySql hereby grant you an additional
 * permission to link the program and your derivative works with the
 * separately licensed software that they have included with mySql.
 * This program is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See
 * the GNU General Public License, version 2.0, for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software Foundation, Inc.,
 * 51 Franklin St, Fifth Floor, Boston, MA 02110-1301 USA
 */

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="mySqlParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
public interface IMySqlParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuery([NotNull] MySqlParser.QueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.query"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuery([NotNull] MySqlParser.QueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleStatement([NotNull] MySqlParser.SimpleStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleStatement([NotNull] MySqlParser.SimpleStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterStatement([NotNull] MySqlParser.AlterStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterStatement([NotNull] MySqlParser.AlterStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterDatabase([NotNull] MySqlParser.AlterDatabaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterDatabase([NotNull] MySqlParser.AlterDatabaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterEvent([NotNull] MySqlParser.AlterEventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterEvent([NotNull] MySqlParser.AlterEventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterLogfileGroup([NotNull] MySqlParser.AlterLogfileGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterLogfileGroup([NotNull] MySqlParser.AlterLogfileGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterLogfileGroupOptions([NotNull] MySqlParser.AlterLogfileGroupOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterLogfileGroupOptions([NotNull] MySqlParser.AlterLogfileGroupOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterLogfileGroupOption([NotNull] MySqlParser.AlterLogfileGroupOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterLogfileGroupOption([NotNull] MySqlParser.AlterLogfileGroupOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterServer([NotNull] MySqlParser.AlterServerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterServer([NotNull] MySqlParser.AlterServerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTable([NotNull] MySqlParser.AlterTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTable([NotNull] MySqlParser.AlterTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTableActions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTableActions([NotNull] MySqlParser.AlterTableActionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTableActions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTableActions([NotNull] MySqlParser.AlterTableActionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterCommandList([NotNull] MySqlParser.AlterCommandListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterCommandList([NotNull] MySqlParser.AlterCommandListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandsModifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterCommandsModifierList([NotNull] MySqlParser.AlterCommandsModifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandsModifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterCommandsModifierList([NotNull] MySqlParser.AlterCommandsModifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.standaloneAlterCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStandaloneAlterCommands([NotNull] MySqlParser.StandaloneAlterCommandsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.standaloneAlterCommands"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStandaloneAlterCommands([NotNull] MySqlParser.StandaloneAlterCommandsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterPartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterPartition([NotNull] MySqlParser.AlterPartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterPartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterPartition([NotNull] MySqlParser.AlterPartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterList([NotNull] MySqlParser.AlterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterList([NotNull] MySqlParser.AlterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandsModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterCommandsModifier([NotNull] MySqlParser.AlterCommandsModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandsModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterCommandsModifier([NotNull] MySqlParser.AlterCommandsModifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterListItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterListItem([NotNull] MySqlParser.AlterListItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterListItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterListItem([NotNull] MySqlParser.AlterListItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPlace([NotNull] MySqlParser.PlaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.place"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPlace([NotNull] MySqlParser.PlaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.restrict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRestrict([NotNull] MySqlParser.RestrictContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.restrict"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRestrict([NotNull] MySqlParser.RestrictContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterOrderList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterOrderList([NotNull] MySqlParser.AlterOrderListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterOrderList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterOrderList([NotNull] MySqlParser.AlterOrderListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterAlgorithmOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterAlgorithmOption([NotNull] MySqlParser.AlterAlgorithmOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterAlgorithmOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterAlgorithmOption([NotNull] MySqlParser.AlterAlgorithmOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterLockOption([NotNull] MySqlParser.AlterLockOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterLockOption([NotNull] MySqlParser.AlterLockOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexLockAndAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexLockAndAlgorithm([NotNull] MySqlParser.IndexLockAndAlgorithmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexLockAndAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexLockAndAlgorithm([NotNull] MySqlParser.IndexLockAndAlgorithmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withValidation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithValidation([NotNull] MySqlParser.WithValidationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withValidation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithValidation([NotNull] MySqlParser.WithValidationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.removePartitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRemovePartitioning([NotNull] MySqlParser.RemovePartitioningContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.removePartitioning"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRemovePartitioning([NotNull] MySqlParser.RemovePartitioningContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.allOrPartitionNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAllOrPartitionNameList([NotNull] MySqlParser.AllOrPartitionNameListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.allOrPartitionNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAllOrPartitionNameList([NotNull] MySqlParser.AllOrPartitionNameListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTablespace([NotNull] MySqlParser.AlterTablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTablespace([NotNull] MySqlParser.AlterTablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterUndoTablespace([NotNull] MySqlParser.AlterUndoTablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterUndoTablespace([NotNull] MySqlParser.AlterUndoTablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.undoTableSpaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUndoTableSpaceOptions([NotNull] MySqlParser.UndoTableSpaceOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.undoTableSpaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUndoTableSpaceOptions([NotNull] MySqlParser.UndoTableSpaceOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.undoTableSpaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUndoTableSpaceOption([NotNull] MySqlParser.UndoTableSpaceOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.undoTableSpaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUndoTableSpaceOption([NotNull] MySqlParser.UndoTableSpaceOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTablespaceOptions([NotNull] MySqlParser.AlterTablespaceOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTablespaceOptions([NotNull] MySqlParser.AlterTablespaceOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterTablespaceOption([NotNull] MySqlParser.AlterTablespaceOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterTablespaceOption([NotNull] MySqlParser.AlterTablespaceOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeTablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChangeTablespaceOption([NotNull] MySqlParser.ChangeTablespaceOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeTablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChangeTablespaceOption([NotNull] MySqlParser.ChangeTablespaceOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterView([NotNull] MySqlParser.AlterViewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterView([NotNull] MySqlParser.AlterViewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewTail([NotNull] MySqlParser.ViewTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewTail([NotNull] MySqlParser.ViewTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewSelect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewSelect([NotNull] MySqlParser.ViewSelectContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewSelect"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewSelect([NotNull] MySqlParser.ViewSelectContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewCheckOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewCheckOption([NotNull] MySqlParser.ViewCheckOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewCheckOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewCheckOption([NotNull] MySqlParser.ViewCheckOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateStatement([NotNull] MySqlParser.CreateStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateStatement([NotNull] MySqlParser.CreateStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateDatabase([NotNull] MySqlParser.CreateDatabaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateDatabase([NotNull] MySqlParser.CreateDatabaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createDatabaseOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateDatabaseOption([NotNull] MySqlParser.CreateDatabaseOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createDatabaseOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateDatabaseOption([NotNull] MySqlParser.CreateDatabaseOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTable([NotNull] MySqlParser.CreateTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTable([NotNull] MySqlParser.CreateTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableElementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElementList([NotNull] MySqlParser.TableElementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableElementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElementList([NotNull] MySqlParser.TableElementListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableElement([NotNull] MySqlParser.TableElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableElement([NotNull] MySqlParser.TableElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.duplicateAsQueryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDuplicateAsQueryExpression([NotNull] MySqlParser.DuplicateAsQueryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.duplicateAsQueryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDuplicateAsQueryExpression([NotNull] MySqlParser.DuplicateAsQueryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionOrParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryExpressionOrParens([NotNull] MySqlParser.QueryExpressionOrParensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionOrParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryExpressionOrParens([NotNull] MySqlParser.QueryExpressionOrParensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createRoutine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateRoutine([NotNull] MySqlParser.CreateRoutineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createRoutine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateRoutine([NotNull] MySqlParser.CreateRoutineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createProcedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateProcedure([NotNull] MySqlParser.CreateProcedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createProcedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateProcedure([NotNull] MySqlParser.CreateProcedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateFunction([NotNull] MySqlParser.CreateFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateFunction([NotNull] MySqlParser.CreateFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUdf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUdf([NotNull] MySqlParser.CreateUdfContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUdf"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUdf([NotNull] MySqlParser.CreateUdfContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineCreateOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoutineCreateOption([NotNull] MySqlParser.RoutineCreateOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineCreateOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoutineCreateOption([NotNull] MySqlParser.RoutineCreateOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineAlterOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoutineAlterOptions([NotNull] MySqlParser.RoutineAlterOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineAlterOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoutineAlterOptions([NotNull] MySqlParser.RoutineAlterOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoutineOption([NotNull] MySqlParser.RoutineOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoutineOption([NotNull] MySqlParser.RoutineOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateIndex([NotNull] MySqlParser.CreateIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateIndex([NotNull] MySqlParser.CreateIndexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexNameAndType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexNameAndType([NotNull] MySqlParser.IndexNameAndTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexNameAndType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexNameAndType([NotNull] MySqlParser.IndexNameAndTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createIndexTarget"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateIndexTarget([NotNull] MySqlParser.CreateIndexTargetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createIndexTarget"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateIndexTarget([NotNull] MySqlParser.CreateIndexTargetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateLogfileGroup([NotNull] MySqlParser.CreateLogfileGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateLogfileGroup([NotNull] MySqlParser.CreateLogfileGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfileGroupOptions([NotNull] MySqlParser.LogfileGroupOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfileGroupOptions([NotNull] MySqlParser.LogfileGroupOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfileGroupOption([NotNull] MySqlParser.LogfileGroupOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfileGroupOption([NotNull] MySqlParser.LogfileGroupOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateServer([NotNull] MySqlParser.CreateServerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateServer([NotNull] MySqlParser.CreateServerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterServerOptions([NotNull] MySqlParser.ServerOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitServerOptions([NotNull] MySqlParser.ServerOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterServerOption([NotNull] MySqlParser.ServerOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitServerOption([NotNull] MySqlParser.ServerOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTablespace([NotNull] MySqlParser.CreateTablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTablespace([NotNull] MySqlParser.CreateTablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUndoTablespace([NotNull] MySqlParser.CreateUndoTablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUndoTablespace([NotNull] MySqlParser.CreateUndoTablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsDataFileName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsDataFileName([NotNull] MySqlParser.TsDataFileNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsDataFileName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsDataFileName([NotNull] MySqlParser.TsDataFileNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsDataFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsDataFile([NotNull] MySqlParser.TsDataFileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsDataFile"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsDataFile([NotNull] MySqlParser.TsDataFileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespaceOptions([NotNull] MySqlParser.TablespaceOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespaceOptions([NotNull] MySqlParser.TablespaceOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespaceOption([NotNull] MySqlParser.TablespaceOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespaceOption([NotNull] MySqlParser.TablespaceOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionInitialSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionInitialSize([NotNull] MySqlParser.TsOptionInitialSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionInitialSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionInitialSize([NotNull] MySqlParser.TsOptionInitialSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionUndoRedoBufferSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionUndoRedoBufferSize([NotNull] MySqlParser.TsOptionUndoRedoBufferSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionUndoRedoBufferSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionUndoRedoBufferSize([NotNull] MySqlParser.TsOptionUndoRedoBufferSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionAutoextendSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionAutoextendSize([NotNull] MySqlParser.TsOptionAutoextendSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionAutoextendSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionAutoextendSize([NotNull] MySqlParser.TsOptionAutoextendSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionMaxSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionMaxSize([NotNull] MySqlParser.TsOptionMaxSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionMaxSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionMaxSize([NotNull] MySqlParser.TsOptionMaxSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionExtentSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionExtentSize([NotNull] MySqlParser.TsOptionExtentSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionExtentSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionExtentSize([NotNull] MySqlParser.TsOptionExtentSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionNodegroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionNodegroup([NotNull] MySqlParser.TsOptionNodegroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionNodegroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionNodegroup([NotNull] MySqlParser.TsOptionNodegroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionEngine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionEngine([NotNull] MySqlParser.TsOptionEngineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionEngine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionEngine([NotNull] MySqlParser.TsOptionEngineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionWait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionWait([NotNull] MySqlParser.TsOptionWaitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionWait"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionWait([NotNull] MySqlParser.TsOptionWaitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionComment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionComment([NotNull] MySqlParser.TsOptionCommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionComment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionComment([NotNull] MySqlParser.TsOptionCommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionFileblockSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionFileblockSize([NotNull] MySqlParser.TsOptionFileblockSizeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionFileblockSize"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionFileblockSize([NotNull] MySqlParser.TsOptionFileblockSizeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionEncryption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTsOptionEncryption([NotNull] MySqlParser.TsOptionEncryptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionEncryption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTsOptionEncryption([NotNull] MySqlParser.TsOptionEncryptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateView([NotNull] MySqlParser.CreateViewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateView([NotNull] MySqlParser.CreateViewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewReplaceOrAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewReplaceOrAlgorithm([NotNull] MySqlParser.ViewReplaceOrAlgorithmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewReplaceOrAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewReplaceOrAlgorithm([NotNull] MySqlParser.ViewReplaceOrAlgorithmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewAlgorithm([NotNull] MySqlParser.ViewAlgorithmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewAlgorithm([NotNull] MySqlParser.ViewAlgorithmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewSuid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewSuid([NotNull] MySqlParser.ViewSuidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewSuid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewSuid([NotNull] MySqlParser.ViewSuidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTrigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTrigger([NotNull] MySqlParser.CreateTriggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTrigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTrigger([NotNull] MySqlParser.CreateTriggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerFollowsPrecedesClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerFollowsPrecedesClause([NotNull] MySqlParser.TriggerFollowsPrecedesClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerFollowsPrecedesClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerFollowsPrecedesClause([NotNull] MySqlParser.TriggerFollowsPrecedesClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateEvent([NotNull] MySqlParser.CreateEventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateEvent([NotNull] MySqlParser.CreateEventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateRole([NotNull] MySqlParser.CreateRoleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateRole([NotNull] MySqlParser.CreateRoleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createSpatialReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateSpatialReference([NotNull] MySqlParser.CreateSpatialReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createSpatialReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateSpatialReference([NotNull] MySqlParser.CreateSpatialReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.srsAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSrsAttribute([NotNull] MySqlParser.SrsAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.srsAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSrsAttribute([NotNull] MySqlParser.SrsAttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropStatement([NotNull] MySqlParser.DropStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropStatement([NotNull] MySqlParser.DropStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropDatabase([NotNull] MySqlParser.DropDatabaseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropDatabase"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropDatabase([NotNull] MySqlParser.DropDatabaseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropEvent([NotNull] MySqlParser.DropEventContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropEvent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropEvent([NotNull] MySqlParser.DropEventContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropFunction([NotNull] MySqlParser.DropFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropFunction([NotNull] MySqlParser.DropFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropProcedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropProcedure([NotNull] MySqlParser.DropProcedureContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropProcedure"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropProcedure([NotNull] MySqlParser.DropProcedureContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropIndex([NotNull] MySqlParser.DropIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropIndex([NotNull] MySqlParser.DropIndexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropLogfileGroup([NotNull] MySqlParser.DropLogfileGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropLogfileGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropLogfileGroup([NotNull] MySqlParser.DropLogfileGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropLogfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropLogfileGroupOption([NotNull] MySqlParser.DropLogfileGroupOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropLogfileGroupOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropLogfileGroupOption([NotNull] MySqlParser.DropLogfileGroupOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropServer([NotNull] MySqlParser.DropServerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropServer([NotNull] MySqlParser.DropServerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropTable([NotNull] MySqlParser.DropTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropTable([NotNull] MySqlParser.DropTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTableSpace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropTableSpace([NotNull] MySqlParser.DropTableSpaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTableSpace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropTableSpace([NotNull] MySqlParser.DropTableSpaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTrigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropTrigger([NotNull] MySqlParser.DropTriggerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTrigger"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropTrigger([NotNull] MySqlParser.DropTriggerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropView([NotNull] MySqlParser.DropViewContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropView"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropView([NotNull] MySqlParser.DropViewContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropRole([NotNull] MySqlParser.DropRoleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropRole([NotNull] MySqlParser.DropRoleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropSpatialReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropSpatialReference([NotNull] MySqlParser.DropSpatialReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropSpatialReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropSpatialReference([NotNull] MySqlParser.DropSpatialReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropUndoTablespace([NotNull] MySqlParser.DropUndoTablespaceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropUndoTablespace"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropUndoTablespace([NotNull] MySqlParser.DropUndoTablespaceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renameTableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRenameTableStatement([NotNull] MySqlParser.RenameTableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renameTableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRenameTableStatement([NotNull] MySqlParser.RenameTableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renamePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRenamePair([NotNull] MySqlParser.RenamePairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renamePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRenamePair([NotNull] MySqlParser.RenamePairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.truncateTableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTruncateTableStatement([NotNull] MySqlParser.TruncateTableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.truncateTableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTruncateTableStatement([NotNull] MySqlParser.TruncateTableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportStatement([NotNull] MySqlParser.ImportStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportStatement([NotNull] MySqlParser.ImportStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.callStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCallStatement([NotNull] MySqlParser.CallStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.callStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCallStatement([NotNull] MySqlParser.CallStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteStatement([NotNull] MySqlParser.DeleteStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteStatement([NotNull] MySqlParser.DeleteStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDelete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDelete([NotNull] MySqlParser.PartitionDeleteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDelete"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDelete([NotNull] MySqlParser.PartitionDeleteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteStatementOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteStatementOption([NotNull] MySqlParser.DeleteStatementOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteStatementOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteStatementOption([NotNull] MySqlParser.DeleteStatementOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDoStatement([NotNull] MySqlParser.DoStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.doStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDoStatement([NotNull] MySqlParser.DoStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandlerStatement([NotNull] MySqlParser.HandlerStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandlerStatement([NotNull] MySqlParser.HandlerStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerReadOrScan"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandlerReadOrScan([NotNull] MySqlParser.HandlerReadOrScanContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerReadOrScan"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandlerReadOrScan([NotNull] MySqlParser.HandlerReadOrScanContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertStatement([NotNull] MySqlParser.InsertStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertStatement([NotNull] MySqlParser.InsertStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertLockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertLockOption([NotNull] MySqlParser.InsertLockOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertLockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertLockOption([NotNull] MySqlParser.InsertLockOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertFromConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertFromConstructor([NotNull] MySqlParser.InsertFromConstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertFromConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertFromConstructor([NotNull] MySqlParser.InsertFromConstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fields"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFields([NotNull] MySqlParser.FieldsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fields"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFields([NotNull] MySqlParser.FieldsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertValues([NotNull] MySqlParser.InsertValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertValues"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertValues([NotNull] MySqlParser.InsertValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertQueryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertQueryExpression([NotNull] MySqlParser.InsertQueryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertQueryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertQueryExpression([NotNull] MySqlParser.InsertQueryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.valueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValueList([NotNull] MySqlParser.ValueListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.valueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValueList([NotNull] MySqlParser.ValueListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>values</c>
	/// labeled alternative in <see cref="MySqlParser.exprexprexprexprexprboolPriboolPriboolPriboolPripredicateOperationspredicateOperationspredicateOperationspredicateOperationssimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprpartitionTypeDefpartitionTypeDefpartitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValues([NotNull] MySqlParser.ValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>values</c>
	/// labeled alternative in <see cref="MySqlParser.exprexprexprexprexprboolPriboolPriboolPriboolPripredicateOperationspredicateOperationspredicateOperationspredicateOperationssimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprpartitionTypeDefpartitionTypeDefpartitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValues([NotNull] MySqlParser.ValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.valuesReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValuesReference([NotNull] MySqlParser.ValuesReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.valuesReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValuesReference([NotNull] MySqlParser.ValuesReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertUpdateList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertUpdateList([NotNull] MySqlParser.InsertUpdateListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertUpdateList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertUpdateList([NotNull] MySqlParser.InsertUpdateListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoadStatement([NotNull] MySqlParser.LoadStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoadStatement([NotNull] MySqlParser.LoadStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataOrXml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataOrXml([NotNull] MySqlParser.DataOrXmlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataOrXml"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataOrXml([NotNull] MySqlParser.DataOrXmlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xmlRowsIdentifiedBy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXmlRowsIdentifiedBy([NotNull] MySqlParser.XmlRowsIdentifiedByContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xmlRowsIdentifiedBy"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXmlRowsIdentifiedBy([NotNull] MySqlParser.XmlRowsIdentifiedByContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadDataFileTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoadDataFileTail([NotNull] MySqlParser.LoadDataFileTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadDataFileTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoadDataFileTail([NotNull] MySqlParser.LoadDataFileTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadDataFileTargetList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoadDataFileTargetList([NotNull] MySqlParser.LoadDataFileTargetListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadDataFileTargetList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoadDataFileTargetList([NotNull] MySqlParser.LoadDataFileTargetListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldOrVariableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldOrVariableList([NotNull] MySqlParser.FieldOrVariableListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldOrVariableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldOrVariableList([NotNull] MySqlParser.FieldOrVariableListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replaceStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplaceStatement([NotNull] MySqlParser.ReplaceStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replaceStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplaceStatement([NotNull] MySqlParser.ReplaceStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectStatement([NotNull] MySqlParser.SelectStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectStatement([NotNull] MySqlParser.SelectStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectStatementWithInto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectStatementWithInto([NotNull] MySqlParser.SelectStatementWithIntoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectStatementWithInto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectStatementWithInto([NotNull] MySqlParser.SelectStatementWithIntoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryExpression([NotNull] MySqlParser.QueryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryExpression([NotNull] MySqlParser.QueryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryExpressionBody([NotNull] MySqlParser.QueryExpressionBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryExpressionBody([NotNull] MySqlParser.QueryExpressionBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryExpressionParens([NotNull] MySqlParser.QueryExpressionParensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryExpressionParens([NotNull] MySqlParser.QueryExpressionParensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryPrimary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQueryPrimary([NotNull] MySqlParser.QueryPrimaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryPrimary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQueryPrimary([NotNull] MySqlParser.QueryPrimaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.querySpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuerySpecification([NotNull] MySqlParser.QuerySpecificationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.querySpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuerySpecification([NotNull] MySqlParser.QuerySpecificationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubquery([NotNull] MySqlParser.SubqueryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subquery"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubquery([NotNull] MySqlParser.SubqueryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.querySpecOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQuerySpecOption([NotNull] MySqlParser.QuerySpecOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.querySpecOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQuerySpecOption([NotNull] MySqlParser.QuerySpecOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitClause([NotNull] MySqlParser.LimitClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitClause([NotNull] MySqlParser.LimitClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleLimitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleLimitClause([NotNull] MySqlParser.SimpleLimitClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleLimitClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleLimitClause([NotNull] MySqlParser.SimpleLimitClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitOptions([NotNull] MySqlParser.LimitOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitOptions([NotNull] MySqlParser.LimitOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitOption([NotNull] MySqlParser.LimitOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitOption([NotNull] MySqlParser.LimitOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.intoClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntoClause([NotNull] MySqlParser.IntoClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.intoClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntoClause([NotNull] MySqlParser.IntoClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureAnalyseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedureAnalyseClause([NotNull] MySqlParser.ProcedureAnalyseClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureAnalyseClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedureAnalyseClause([NotNull] MySqlParser.ProcedureAnalyseClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.havingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHavingClause([NotNull] MySqlParser.HavingClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.havingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHavingClause([NotNull] MySqlParser.HavingClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowClause([NotNull] MySqlParser.WindowClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowClause([NotNull] MySqlParser.WindowClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowDefinition([NotNull] MySqlParser.WindowDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowDefinition([NotNull] MySqlParser.WindowDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowSpec([NotNull] MySqlParser.WindowSpecContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowSpec"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowSpec([NotNull] MySqlParser.WindowSpecContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowSpecDetails"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowSpecDetails([NotNull] MySqlParser.WindowSpecDetailsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowSpecDetails"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowSpecDetails([NotNull] MySqlParser.WindowSpecDetailsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameClause([NotNull] MySqlParser.WindowFrameClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameClause([NotNull] MySqlParser.WindowFrameClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameUnits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameUnits([NotNull] MySqlParser.WindowFrameUnitsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameUnits"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameUnits([NotNull] MySqlParser.WindowFrameUnitsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameExtent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameExtent([NotNull] MySqlParser.WindowFrameExtentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameExtent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameExtent([NotNull] MySqlParser.WindowFrameExtentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameStart([NotNull] MySqlParser.WindowFrameStartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameStart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameStart([NotNull] MySqlParser.WindowFrameStartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameBetween"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameBetween([NotNull] MySqlParser.WindowFrameBetweenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameBetween"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameBetween([NotNull] MySqlParser.WindowFrameBetweenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameBound([NotNull] MySqlParser.WindowFrameBoundContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameBound([NotNull] MySqlParser.WindowFrameBoundContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameExclusion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFrameExclusion([NotNull] MySqlParser.WindowFrameExclusionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameExclusion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFrameExclusion([NotNull] MySqlParser.WindowFrameExclusionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithClause([NotNull] MySqlParser.WithClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithClause([NotNull] MySqlParser.WithClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.commonTableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommonTableExpression([NotNull] MySqlParser.CommonTableExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.commonTableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommonTableExpression([NotNull] MySqlParser.CommonTableExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupByClause([NotNull] MySqlParser.GroupByClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupByClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupByClause([NotNull] MySqlParser.GroupByClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.olapOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOlapOption([NotNull] MySqlParser.OlapOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.olapOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOlapOption([NotNull] MySqlParser.OlapOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderClause([NotNull] MySqlParser.OrderClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderClause([NotNull] MySqlParser.OrderClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirection([NotNull] MySqlParser.DirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirection([NotNull] MySqlParser.DirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fromClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFromClause([NotNull] MySqlParser.FromClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fromClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFromClause([NotNull] MySqlParser.FromClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReferenceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableReferenceList([NotNull] MySqlParser.TableReferenceListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReferenceList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableReferenceList([NotNull] MySqlParser.TableReferenceListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableValueConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableValueConstructor([NotNull] MySqlParser.TableValueConstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableValueConstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableValueConstructor([NotNull] MySqlParser.TableValueConstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explicitTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplicitTable([NotNull] MySqlParser.ExplicitTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explicitTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplicitTable([NotNull] MySqlParser.ExplicitTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.rowValueExplicit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRowValueExplicit([NotNull] MySqlParser.RowValueExplicitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.rowValueExplicit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRowValueExplicit([NotNull] MySqlParser.RowValueExplicitContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectOption([NotNull] MySqlParser.SelectOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectOption([NotNull] MySqlParser.SelectOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockingClauseList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockingClauseList([NotNull] MySqlParser.LockingClauseListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockingClauseList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockingClauseList([NotNull] MySqlParser.LockingClauseListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockingClause([NotNull] MySqlParser.LockingClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockingClause([NotNull] MySqlParser.LockingClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockStrengh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockStrengh([NotNull] MySqlParser.LockStrenghContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockStrengh"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockStrengh([NotNull] MySqlParser.LockStrenghContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockedRowAction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockedRowAction([NotNull] MySqlParser.LockedRowActionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockedRowAction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockedRowAction([NotNull] MySqlParser.LockedRowActionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectItemList([NotNull] MySqlParser.SelectItemListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectItemList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectItemList([NotNull] MySqlParser.SelectItemListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectItem([NotNull] MySqlParser.SelectItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectItem([NotNull] MySqlParser.SelectItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelectAlias([NotNull] MySqlParser.SelectAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelectAlias([NotNull] MySqlParser.SelectAliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhereClause([NotNull] MySqlParser.WhereClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whereClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhereClause([NotNull] MySqlParser.WhereClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableReference([NotNull] MySqlParser.TableReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableReference([NotNull] MySqlParser.TableReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.escapedTableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEscapedTableReference([NotNull] MySqlParser.EscapedTableReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.escapedTableReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEscapedTableReference([NotNull] MySqlParser.EscapedTableReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.joinedTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJoinedTable([NotNull] MySqlParser.JoinedTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.joinedTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJoinedTable([NotNull] MySqlParser.JoinedTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.naturalJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNaturalJoinType([NotNull] MySqlParser.NaturalJoinTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.naturalJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNaturalJoinType([NotNull] MySqlParser.NaturalJoinTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.innerJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInnerJoinType([NotNull] MySqlParser.InnerJoinTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.innerJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInnerJoinType([NotNull] MySqlParser.InnerJoinTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.outerJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOuterJoinType([NotNull] MySqlParser.OuterJoinTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.outerJoinType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOuterJoinType([NotNull] MySqlParser.OuterJoinTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableFactor([NotNull] MySqlParser.TableFactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableFactor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableFactor([NotNull] MySqlParser.TableFactorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.singleTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleTable([NotNull] MySqlParser.SingleTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.singleTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleTable([NotNull] MySqlParser.SingleTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.singleTableParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingleTableParens([NotNull] MySqlParser.SingleTableParensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.singleTableParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingleTableParens([NotNull] MySqlParser.SingleTableParensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.derivedTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDerivedTable([NotNull] MySqlParser.DerivedTableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.derivedTable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDerivedTable([NotNull] MySqlParser.DerivedTableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReferenceListParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableReferenceListParens([NotNull] MySqlParser.TableReferenceListParensContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReferenceListParens"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableReferenceListParens([NotNull] MySqlParser.TableReferenceListParensContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableFunction([NotNull] MySqlParser.TableFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableFunction([NotNull] MySqlParser.TableFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnsClause([NotNull] MySqlParser.ColumnsClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnsClause([NotNull] MySqlParser.ColumnsClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jtColumn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJtColumn([NotNull] MySqlParser.JtColumnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jtColumn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJtColumn([NotNull] MySqlParser.JtColumnContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onEmptyOrError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnEmptyOrError([NotNull] MySqlParser.OnEmptyOrErrorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onEmptyOrError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnEmptyOrError([NotNull] MySqlParser.OnEmptyOrErrorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnEmpty([NotNull] MySqlParser.OnEmptyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onEmpty"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnEmpty([NotNull] MySqlParser.OnEmptyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnError([NotNull] MySqlParser.OnErrorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onError"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnError([NotNull] MySqlParser.OnErrorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jtOnResponse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJtOnResponse([NotNull] MySqlParser.JtOnResponseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jtOnResponse"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJtOnResponse([NotNull] MySqlParser.JtOnResponseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unionOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnionOption([NotNull] MySqlParser.UnionOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unionOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnionOption([NotNull] MySqlParser.UnionOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableAlias([NotNull] MySqlParser.TableAliasContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAlias"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableAlias([NotNull] MySqlParser.TableAliasContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexHintList([NotNull] MySqlParser.IndexHintListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexHintList([NotNull] MySqlParser.IndexHintListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexHint([NotNull] MySqlParser.IndexHintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexHint([NotNull] MySqlParser.IndexHintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexHintType([NotNull] MySqlParser.IndexHintTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexHintType([NotNull] MySqlParser.IndexHintTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyOrIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyOrIndex([NotNull] MySqlParser.KeyOrIndexContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyOrIndex"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyOrIndex([NotNull] MySqlParser.KeyOrIndexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintKeyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintKeyType([NotNull] MySqlParser.ConstraintKeyTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintKeyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintKeyType([NotNull] MySqlParser.ConstraintKeyTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexHintClause([NotNull] MySqlParser.IndexHintClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexHintClause([NotNull] MySqlParser.IndexHintClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexList([NotNull] MySqlParser.IndexListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexList([NotNull] MySqlParser.IndexListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexListElement([NotNull] MySqlParser.IndexListElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexListElement([NotNull] MySqlParser.IndexListElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateStatement([NotNull] MySqlParser.UpdateStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateStatement([NotNull] MySqlParser.UpdateStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionOrLockingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionOrLockingStatement([NotNull] MySqlParser.TransactionOrLockingStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionOrLockingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionOrLockingStatement([NotNull] MySqlParser.TransactionOrLockingStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionStatement([NotNull] MySqlParser.TransactionStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionStatement([NotNull] MySqlParser.TransactionStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.beginWork"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBeginWork([NotNull] MySqlParser.BeginWorkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.beginWork"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBeginWork([NotNull] MySqlParser.BeginWorkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionCharacteristic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionCharacteristic([NotNull] MySqlParser.TransactionCharacteristicContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionCharacteristic"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionCharacteristic([NotNull] MySqlParser.TransactionCharacteristicContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.savepointStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSavepointStatement([NotNull] MySqlParser.SavepointStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.savepointStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSavepointStatement([NotNull] MySqlParser.SavepointStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockStatement([NotNull] MySqlParser.LockStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockStatement([NotNull] MySqlParser.LockStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockItem([NotNull] MySqlParser.LockItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockItem([NotNull] MySqlParser.LockItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLockOption([NotNull] MySqlParser.LockOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLockOption([NotNull] MySqlParser.LockOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xaStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXaStatement([NotNull] MySqlParser.XaStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xaStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXaStatement([NotNull] MySqlParser.XaStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xaConvert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXaConvert([NotNull] MySqlParser.XaConvertContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xaConvert"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXaConvert([NotNull] MySqlParser.XaConvertContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterXid([NotNull] MySqlParser.XidContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitXid([NotNull] MySqlParser.XidContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replicationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplicationStatement([NotNull] MySqlParser.ReplicationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replicationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplicationStatement([NotNull] MySqlParser.ReplicationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resetOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResetOption([NotNull] MySqlParser.ResetOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resetOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResetOption([NotNull] MySqlParser.ResetOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterResetOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMasterResetOptions([NotNull] MySqlParser.MasterResetOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterResetOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMasterResetOptions([NotNull] MySqlParser.MasterResetOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replicationLoad"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplicationLoad([NotNull] MySqlParser.ReplicationLoadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replicationLoad"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplicationLoad([NotNull] MySqlParser.ReplicationLoadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeMaster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChangeMaster([NotNull] MySqlParser.ChangeMasterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeMaster"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChangeMaster([NotNull] MySqlParser.ChangeMasterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeMasterOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChangeMasterOptions([NotNull] MySqlParser.ChangeMasterOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeMasterOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChangeMasterOptions([NotNull] MySqlParser.ChangeMasterOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMasterOption([NotNull] MySqlParser.MasterOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMasterOption([NotNull] MySqlParser.MasterOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.privilegeCheckDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrivilegeCheckDef([NotNull] MySqlParser.PrivilegeCheckDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.privilegeCheckDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrivilegeCheckDef([NotNull] MySqlParser.PrivilegeCheckDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablePrimaryKeyCheckDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablePrimaryKeyCheckDef([NotNull] MySqlParser.TablePrimaryKeyCheckDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablePrimaryKeyCheckDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablePrimaryKeyCheckDef([NotNull] MySqlParser.TablePrimaryKeyCheckDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterTlsCiphersuitesDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMasterTlsCiphersuitesDef([NotNull] MySqlParser.MasterTlsCiphersuitesDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterTlsCiphersuitesDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMasterTlsCiphersuitesDef([NotNull] MySqlParser.MasterTlsCiphersuitesDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterFileDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMasterFileDef([NotNull] MySqlParser.MasterFileDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterFileDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMasterFileDef([NotNull] MySqlParser.MasterFileDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverIdList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterServerIdList([NotNull] MySqlParser.ServerIdListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverIdList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitServerIdList([NotNull] MySqlParser.ServerIdListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeReplication"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChangeReplication([NotNull] MySqlParser.ChangeReplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeReplication"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChangeReplication([NotNull] MySqlParser.ChangeReplicationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterDefinition([NotNull] MySqlParser.FilterDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterDefinition([NotNull] MySqlParser.FilterDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDbList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterDbList([NotNull] MySqlParser.FilterDbListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDbList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterDbList([NotNull] MySqlParser.FilterDbListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterTableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterTableList([NotNull] MySqlParser.FilterTableListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterTableList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterTableList([NotNull] MySqlParser.FilterTableListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterStringList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterStringList([NotNull] MySqlParser.FilterStringListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterStringList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterStringList([NotNull] MySqlParser.FilterStringListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterWildDbTableString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterWildDbTableString([NotNull] MySqlParser.FilterWildDbTableStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterWildDbTableString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterWildDbTableString([NotNull] MySqlParser.FilterWildDbTableStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDbPairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterDbPairList([NotNull] MySqlParser.FilterDbPairListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDbPairList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterDbPairList([NotNull] MySqlParser.FilterDbPairListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slave"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlave([NotNull] MySqlParser.SlaveContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slave"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlave([NotNull] MySqlParser.SlaveContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveUntilOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlaveUntilOptions([NotNull] MySqlParser.SlaveUntilOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveUntilOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlaveUntilOptions([NotNull] MySqlParser.SlaveUntilOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveConnectionOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlaveConnectionOptions([NotNull] MySqlParser.SlaveConnectionOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveConnectionOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlaveConnectionOptions([NotNull] MySqlParser.SlaveConnectionOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveThreadOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlaveThreadOptions([NotNull] MySqlParser.SlaveThreadOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveThreadOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlaveThreadOptions([NotNull] MySqlParser.SlaveThreadOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveThreadOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSlaveThreadOption([NotNull] MySqlParser.SlaveThreadOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveThreadOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSlaveThreadOption([NotNull] MySqlParser.SlaveThreadOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupReplication"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupReplication([NotNull] MySqlParser.GroupReplicationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupReplication"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupReplication([NotNull] MySqlParser.GroupReplicationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preparedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreparedStatement([NotNull] MySqlParser.PreparedStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preparedStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreparedStatement([NotNull] MySqlParser.PreparedStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.executeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecuteStatement([NotNull] MySqlParser.ExecuteStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.executeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecuteStatement([NotNull] MySqlParser.ExecuteStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.executeVarList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExecuteVarList([NotNull] MySqlParser.ExecuteVarListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.executeVarList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExecuteVarList([NotNull] MySqlParser.ExecuteVarListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cloneStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCloneStatement([NotNull] MySqlParser.CloneStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cloneStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCloneStatement([NotNull] MySqlParser.CloneStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataDirSSL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataDirSSL([NotNull] MySqlParser.DataDirSSLContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataDirSSL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataDirSSL([NotNull] MySqlParser.DataDirSSLContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ssl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSsl([NotNull] MySqlParser.SslContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ssl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSsl([NotNull] MySqlParser.SslContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.accountManagementStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccountManagementStatement([NotNull] MySqlParser.AccountManagementStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.accountManagementStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccountManagementStatement([NotNull] MySqlParser.AccountManagementStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterUser([NotNull] MySqlParser.AlterUserContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterUser([NotNull] MySqlParser.AlterUserContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterUserTail([NotNull] MySqlParser.AlterUserTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterUserTail([NotNull] MySqlParser.AlterUserTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUserFunction([NotNull] MySqlParser.UserFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUserFunction([NotNull] MySqlParser.UserFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUser([NotNull] MySqlParser.CreateUserContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUser([NotNull] MySqlParser.CreateUserContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUserTail([NotNull] MySqlParser.CreateUserTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUserTail([NotNull] MySqlParser.CreateUserTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultRoleClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultRoleClause([NotNull] MySqlParser.DefaultRoleClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultRoleClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultRoleClause([NotNull] MySqlParser.DefaultRoleClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRequireClause([NotNull] MySqlParser.RequireClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRequireClause([NotNull] MySqlParser.RequireClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.connectOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConnectOptions([NotNull] MySqlParser.ConnectOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.connectOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConnectOptions([NotNull] MySqlParser.ConnectOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.accountLockPasswordExpireOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccountLockPasswordExpireOptions([NotNull] MySqlParser.AccountLockPasswordExpireOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.accountLockPasswordExpireOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccountLockPasswordExpireOptions([NotNull] MySqlParser.AccountLockPasswordExpireOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropUser([NotNull] MySqlParser.DropUserContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropUser([NotNull] MySqlParser.DropUserContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrant([NotNull] MySqlParser.GrantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrant([NotNull] MySqlParser.GrantContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantTargetList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantTargetList([NotNull] MySqlParser.GrantTargetListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantTargetList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantTargetList([NotNull] MySqlParser.GrantTargetListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantOptions([NotNull] MySqlParser.GrantOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantOptions([NotNull] MySqlParser.GrantOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exceptRoleList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExceptRoleList([NotNull] MySqlParser.ExceptRoleListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exceptRoleList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExceptRoleList([NotNull] MySqlParser.ExceptRoleListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withRoles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWithRoles([NotNull] MySqlParser.WithRolesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withRoles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWithRoles([NotNull] MySqlParser.WithRolesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantAs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantAs([NotNull] MySqlParser.GrantAsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantAs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantAs([NotNull] MySqlParser.GrantAsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.versionedRequireClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVersionedRequireClause([NotNull] MySqlParser.VersionedRequireClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.versionedRequireClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVersionedRequireClause([NotNull] MySqlParser.VersionedRequireClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renameUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRenameUser([NotNull] MySqlParser.RenameUserContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renameUser"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRenameUser([NotNull] MySqlParser.RenameUserContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.revoke"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRevoke([NotNull] MySqlParser.RevokeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.revoke"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRevoke([NotNull] MySqlParser.RevokeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onTypeTo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnTypeTo([NotNull] MySqlParser.OnTypeToContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onTypeTo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnTypeTo([NotNull] MySqlParser.OnTypeToContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.aclType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAclType([NotNull] MySqlParser.AclTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.aclType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAclType([NotNull] MySqlParser.AclTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrPrivilegesList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleOrPrivilegesList([NotNull] MySqlParser.RoleOrPrivilegesListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrPrivilegesList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleOrPrivilegesList([NotNull] MySqlParser.RoleOrPrivilegesListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrPrivilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleOrPrivilege([NotNull] MySqlParser.RoleOrPrivilegeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrPrivilege"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleOrPrivilege([NotNull] MySqlParser.RoleOrPrivilegeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantIdentifier([NotNull] MySqlParser.GrantIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantIdentifier([NotNull] MySqlParser.GrantIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRequireList([NotNull] MySqlParser.RequireListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRequireList([NotNull] MySqlParser.RequireListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRequireListElement([NotNull] MySqlParser.RequireListElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireListElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRequireListElement([NotNull] MySqlParser.RequireListElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGrantOption([NotNull] MySqlParser.GrantOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGrantOption([NotNull] MySqlParser.GrantOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetRole([NotNull] MySqlParser.SetRoleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setRole"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetRole([NotNull] MySqlParser.SetRoleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleList([NotNull] MySqlParser.RoleListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleList([NotNull] MySqlParser.RoleListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRole([NotNull] MySqlParser.RoleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.role"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRole([NotNull] MySqlParser.RoleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAdministrationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableAdministrationStatement([NotNull] MySqlParser.TableAdministrationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAdministrationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableAdministrationStatement([NotNull] MySqlParser.TableAdministrationStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.histogram"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHistogram([NotNull] MySqlParser.HistogramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.histogram"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHistogram([NotNull] MySqlParser.HistogramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckOption([NotNull] MySqlParser.CheckOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckOption([NotNull] MySqlParser.CheckOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.repairType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepairType([NotNull] MySqlParser.RepairTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.repairType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepairType([NotNull] MySqlParser.RepairTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.installUninstallStatment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInstallUninstallStatment([NotNull] MySqlParser.InstallUninstallStatmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.installUninstallStatment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInstallUninstallStatment([NotNull] MySqlParser.InstallUninstallStatmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetStatement([NotNull] MySqlParser.SetStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetStatement([NotNull] MySqlParser.SetStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.startOptionValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStartOptionValueList([NotNull] MySqlParser.StartOptionValueListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.startOptionValueList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStartOptionValueList([NotNull] MySqlParser.StartOptionValueListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionCharacteristics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionCharacteristics([NotNull] MySqlParser.TransactionCharacteristicsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionCharacteristics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionCharacteristics([NotNull] MySqlParser.TransactionCharacteristicsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionAccessMode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTransactionAccessMode([NotNull] MySqlParser.TransactionAccessModeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionAccessMode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTransactionAccessMode([NotNull] MySqlParser.TransactionAccessModeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.isolationLevel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIsolationLevel([NotNull] MySqlParser.IsolationLevelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.isolationLevel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIsolationLevel([NotNull] MySqlParser.IsolationLevelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueListContinued"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionValueListContinued([NotNull] MySqlParser.OptionValueListContinuedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueListContinued"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionValueListContinued([NotNull] MySqlParser.OptionValueListContinuedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueNoOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionValueNoOptionType([NotNull] MySqlParser.OptionValueNoOptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueNoOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionValueNoOptionType([NotNull] MySqlParser.OptionValueNoOptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionValue([NotNull] MySqlParser.OptionValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionValue([NotNull] MySqlParser.OptionValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setSystemVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetSystemVariable([NotNull] MySqlParser.SetSystemVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setSystemVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetSystemVariable([NotNull] MySqlParser.SetSystemVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.startOptionValueListFollowingOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStartOptionValueListFollowingOptionType([NotNull] MySqlParser.StartOptionValueListFollowingOptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.startOptionValueListFollowingOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStartOptionValueListFollowingOptionType([NotNull] MySqlParser.StartOptionValueListFollowingOptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueFollowingOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionValueFollowingOptionType([NotNull] MySqlParser.OptionValueFollowingOptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueFollowingOptionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionValueFollowingOptionType([NotNull] MySqlParser.OptionValueFollowingOptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setExprOrDefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetExprOrDefault([NotNull] MySqlParser.SetExprOrDefaultContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setExprOrDefault"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetExprOrDefault([NotNull] MySqlParser.SetExprOrDefaultContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.showStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowStatement([NotNull] MySqlParser.ShowStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.showStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowStatement([NotNull] MySqlParser.ShowStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.showCommandType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShowCommandType([NotNull] MySqlParser.ShowCommandTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.showCommandType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShowCommandType([NotNull] MySqlParser.ShowCommandTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nonBlocking"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNonBlocking([NotNull] MySqlParser.NonBlockingContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nonBlocking"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNonBlocking([NotNull] MySqlParser.NonBlockingContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fromOrIn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFromOrIn([NotNull] MySqlParser.FromOrInContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fromOrIn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFromOrIn([NotNull] MySqlParser.FromOrInContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.inDb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInDb([NotNull] MySqlParser.InDbContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.inDb"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInDb([NotNull] MySqlParser.InDbContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.profileType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProfileType([NotNull] MySqlParser.ProfileTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.profileType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProfileType([NotNull] MySqlParser.ProfileTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.otherAdministrativeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOtherAdministrativeStatement([NotNull] MySqlParser.OtherAdministrativeStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.otherAdministrativeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOtherAdministrativeStatement([NotNull] MySqlParser.OtherAdministrativeStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyCacheListOrParts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyCacheListOrParts([NotNull] MySqlParser.KeyCacheListOrPartsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyCacheListOrParts"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyCacheListOrParts([NotNull] MySqlParser.KeyCacheListOrPartsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyCacheList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyCacheList([NotNull] MySqlParser.KeyCacheListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyCacheList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyCacheList([NotNull] MySqlParser.KeyCacheListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.assignToKeycache"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignToKeycache([NotNull] MySqlParser.AssignToKeycacheContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.assignToKeycache"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignToKeycache([NotNull] MySqlParser.AssignToKeycacheContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.assignToKeycachePartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignToKeycachePartition([NotNull] MySqlParser.AssignToKeycachePartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.assignToKeycachePartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignToKeycachePartition([NotNull] MySqlParser.AssignToKeycachePartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cacheKeyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCacheKeyList([NotNull] MySqlParser.CacheKeyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cacheKeyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCacheKeyList([NotNull] MySqlParser.CacheKeyListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyUsageElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyUsageElement([NotNull] MySqlParser.KeyUsageElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyUsageElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyUsageElement([NotNull] MySqlParser.KeyUsageElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyUsageList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyUsageList([NotNull] MySqlParser.KeyUsageListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyUsageList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyUsageList([NotNull] MySqlParser.KeyUsageListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlushOption([NotNull] MySqlParser.FlushOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlushOption([NotNull] MySqlParser.FlushOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogType([NotNull] MySqlParser.LogTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogType([NotNull] MySqlParser.LogTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushTables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlushTables([NotNull] MySqlParser.FlushTablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushTables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlushTables([NotNull] MySqlParser.FlushTablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushTablesOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFlushTablesOptions([NotNull] MySqlParser.FlushTablesOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushTablesOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFlushTablesOptions([NotNull] MySqlParser.FlushTablesOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreloadTail([NotNull] MySqlParser.PreloadTailContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadTail"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreloadTail([NotNull] MySqlParser.PreloadTailContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreloadList([NotNull] MySqlParser.PreloadListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreloadList([NotNull] MySqlParser.PreloadListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadKeys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPreloadKeys([NotNull] MySqlParser.PreloadKeysContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadKeys"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPreloadKeys([NotNull] MySqlParser.PreloadKeysContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.adminPartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdminPartition([NotNull] MySqlParser.AdminPartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.adminPartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdminPartition([NotNull] MySqlParser.AdminPartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupManagement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceGroupManagement([NotNull] MySqlParser.ResourceGroupManagementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupManagement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceGroupManagement([NotNull] MySqlParser.ResourceGroupManagementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateResourceGroup([NotNull] MySqlParser.CreateResourceGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateResourceGroup([NotNull] MySqlParser.CreateResourceGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupVcpuList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceGroupVcpuList([NotNull] MySqlParser.ResourceGroupVcpuListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupVcpuList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceGroupVcpuList([NotNull] MySqlParser.ResourceGroupVcpuListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.vcpuNumOrRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVcpuNumOrRange([NotNull] MySqlParser.VcpuNumOrRangeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.vcpuNumOrRange"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVcpuNumOrRange([NotNull] MySqlParser.VcpuNumOrRangeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupPriority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceGroupPriority([NotNull] MySqlParser.ResourceGroupPriorityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupPriority"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceGroupPriority([NotNull] MySqlParser.ResourceGroupPriorityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupEnableDisable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceGroupEnableDisable([NotNull] MySqlParser.ResourceGroupEnableDisableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupEnableDisable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceGroupEnableDisable([NotNull] MySqlParser.ResourceGroupEnableDisableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterResourceGroup([NotNull] MySqlParser.AlterResourceGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterResourceGroup([NotNull] MySqlParser.AlterResourceGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetResourceGroup([NotNull] MySqlParser.SetResourceGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetResourceGroup([NotNull] MySqlParser.SetResourceGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.threadIdList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThreadIdList([NotNull] MySqlParser.ThreadIdListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.threadIdList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThreadIdList([NotNull] MySqlParser.ThreadIdListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDropResourceGroup([NotNull] MySqlParser.DropResourceGroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropResourceGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDropResourceGroup([NotNull] MySqlParser.DropResourceGroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.utilityStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUtilityStatement([NotNull] MySqlParser.UtilityStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.utilityStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUtilityStatement([NotNull] MySqlParser.UtilityStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.describeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDescribeStatement([NotNull] MySqlParser.DescribeStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.describeStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDescribeStatement([NotNull] MySqlParser.DescribeStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explainStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainStatement([NotNull] MySqlParser.ExplainStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explainStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainStatement([NotNull] MySqlParser.ExplainStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explainableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplainableStatement([NotNull] MySqlParser.ExplainableStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explainableStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplainableStatement([NotNull] MySqlParser.ExplainableStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.helpCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHelpCommand([NotNull] MySqlParser.HelpCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.helpCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHelpCommand([NotNull] MySqlParser.HelpCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.useCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUseCommand([NotNull] MySqlParser.UseCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.useCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUseCommand([NotNull] MySqlParser.UseCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.restartServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRestartServer([NotNull] MySqlParser.RestartServerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.restartServer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRestartServer([NotNull] MySqlParser.RestartServerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprOr([NotNull] MySqlParser.ExprOrContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprOr([NotNull] MySqlParser.ExprOrContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprNot([NotNull] MySqlParser.ExprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprNot([NotNull] MySqlParser.ExprNotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprIs</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprIs([NotNull] MySqlParser.ExprIsContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprIs</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprIs([NotNull] MySqlParser.ExprIsContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprAnd([NotNull] MySqlParser.ExprAndContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprAnd([NotNull] MySqlParser.ExprAndContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>exprXor</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprXor([NotNull] MySqlParser.ExprXorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>exprXor</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprXor([NotNull] MySqlParser.ExprXorContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprPredicate</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExprPredicate([NotNull] MySqlParser.PrimaryExprPredicateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprPredicate</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExprPredicate([NotNull] MySqlParser.PrimaryExprPredicateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprCompare</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExprCompare([NotNull] MySqlParser.PrimaryExprCompareContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprCompare</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExprCompare([NotNull] MySqlParser.PrimaryExprCompareContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprAllAny</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExprAllAny([NotNull] MySqlParser.PrimaryExprAllAnyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprAllAny</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExprAllAny([NotNull] MySqlParser.PrimaryExprAllAnyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprIsNull</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExprIsNull([NotNull] MySqlParser.PrimaryExprIsNullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprIsNull</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExprIsNull([NotNull] MySqlParser.PrimaryExprIsNullContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompOp([NotNull] MySqlParser.CompOpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compOp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompOp([NotNull] MySqlParser.CompOpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicate([NotNull] MySqlParser.PredicateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.predicate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicate([NotNull] MySqlParser.PredicateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprIn</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicateExprIn([NotNull] MySqlParser.PredicateExprInContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprIn</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicateExprIn([NotNull] MySqlParser.PredicateExprInContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprBetween</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicateExprBetween([NotNull] MySqlParser.PredicateExprBetweenContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprBetween</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicateExprBetween([NotNull] MySqlParser.PredicateExprBetweenContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprLike</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicateExprLike([NotNull] MySqlParser.PredicateExprLikeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprLike</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicateExprLike([NotNull] MySqlParser.PredicateExprLikeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprRegex</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPredicateExprRegex([NotNull] MySqlParser.PredicateExprRegexContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprRegex</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPredicateExprRegex([NotNull] MySqlParser.PredicateExprRegexContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.bitExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBitExpr([NotNull] MySqlParser.BitExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.bitExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBitExpr([NotNull] MySqlParser.BitExprContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConvert</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprConvert([NotNull] MySqlParser.SimpleExprConvertContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConvert</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprConvert([NotNull] MySqlParser.SimpleExprConvertContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprVariable</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprVariable([NotNull] MySqlParser.SimpleExprVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprVariable</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprVariable([NotNull] MySqlParser.SimpleExprVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCast</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprCast([NotNull] MySqlParser.SimpleExprCastContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCast</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprCast([NotNull] MySqlParser.SimpleExprCastContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprUnary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprUnary([NotNull] MySqlParser.SimpleExprUnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprUnary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprUnary([NotNull] MySqlParser.SimpleExprUnaryContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprOdbc</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprOdbc([NotNull] MySqlParser.SimpleExprOdbcContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprOdbc</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprOdbc([NotNull] MySqlParser.SimpleExprOdbcContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprRuntimeFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprRuntimeFunction([NotNull] MySqlParser.SimpleExprRuntimeFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprRuntimeFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprRuntimeFunction([NotNull] MySqlParser.SimpleExprRuntimeFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprFunction([NotNull] MySqlParser.SimpleExprFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprFunction([NotNull] MySqlParser.SimpleExprFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCollate</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprCollate([NotNull] MySqlParser.SimpleExprCollateContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCollate</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprCollate([NotNull] MySqlParser.SimpleExprCollateContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprMatch</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprMatch([NotNull] MySqlParser.SimpleExprMatchContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprMatch</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprMatch([NotNull] MySqlParser.SimpleExprMatchContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprWindowingFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprWindowingFunction([NotNull] MySqlParser.SimpleExprWindowingFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprWindowingFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprWindowingFunction([NotNull] MySqlParser.SimpleExprWindowingFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprBinary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprBinary([NotNull] MySqlParser.SimpleExprBinaryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprBinary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprBinary([NotNull] MySqlParser.SimpleExprBinaryContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprColumnRef</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprColumnRef([NotNull] MySqlParser.SimpleExprColumnRefContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprColumnRef</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprColumnRef([NotNull] MySqlParser.SimpleExprColumnRefContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprParamMarker</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprParamMarker([NotNull] MySqlParser.SimpleExprParamMarkerContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprParamMarker</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprParamMarker([NotNull] MySqlParser.SimpleExprParamMarkerContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprSum</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprSum([NotNull] MySqlParser.SimpleExprSumContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprSum</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprSum([NotNull] MySqlParser.SimpleExprSumContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConvertUsing</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprConvertUsing([NotNull] MySqlParser.SimpleExprConvertUsingContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConvertUsing</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprConvertUsing([NotNull] MySqlParser.SimpleExprConvertUsingContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprSubQuery</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprSubQuery([NotNull] MySqlParser.SimpleExprSubQueryContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprSubQuery</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprSubQuery([NotNull] MySqlParser.SimpleExprSubQueryContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprGroupingOperation</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprGroupingOperation([NotNull] MySqlParser.SimpleExprGroupingOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprGroupingOperation</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprGroupingOperation([NotNull] MySqlParser.SimpleExprGroupingOperationContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprNot</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprNot([NotNull] MySqlParser.SimpleExprNotContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprNot</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprNot([NotNull] MySqlParser.SimpleExprNotContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprValues</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprValues([NotNull] MySqlParser.SimpleExprValuesContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprValues</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprValues([NotNull] MySqlParser.SimpleExprValuesContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprDefault</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprDefault([NotNull] MySqlParser.SimpleExprDefaultContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprDefault</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprDefault([NotNull] MySqlParser.SimpleExprDefaultContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprList</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprList([NotNull] MySqlParser.SimpleExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprList</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprList([NotNull] MySqlParser.SimpleExprListContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprInterval</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprInterval([NotNull] MySqlParser.SimpleExprIntervalContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprInterval</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprInterval([NotNull] MySqlParser.SimpleExprIntervalContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCase</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprCase([NotNull] MySqlParser.SimpleExprCaseContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCase</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprCase([NotNull] MySqlParser.SimpleExprCaseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConcat</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprConcat([NotNull] MySqlParser.SimpleExprConcatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConcat</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprConcat([NotNull] MySqlParser.SimpleExprConcatContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprLiteral</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprLiteral([NotNull] MySqlParser.SimpleExprLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprLiteral</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprLiteral([NotNull] MySqlParser.SimpleExprLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.arrayCast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayCast([NotNull] MySqlParser.ArrayCastContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.arrayCast"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayCast([NotNull] MySqlParser.ArrayCastContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jsonOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonOperator([NotNull] MySqlParser.JsonOperatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jsonOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonOperator([NotNull] MySqlParser.JsonOperatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sumExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSumExpr([NotNull] MySqlParser.SumExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sumExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSumExpr([NotNull] MySqlParser.SumExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupingOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupingOperation([NotNull] MySqlParser.GroupingOperationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupingOperation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupingOperation([NotNull] MySqlParser.GroupingOperationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFunctionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowFunctionCall([NotNull] MySqlParser.WindowFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFunctionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowFunctionCall([NotNull] MySqlParser.WindowFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowingClause([NotNull] MySqlParser.WindowingClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowingClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowingClause([NotNull] MySqlParser.WindowingClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.leadLagInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeadLagInfo([NotNull] MySqlParser.LeadLagInfoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.leadLagInfo"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeadLagInfo([NotNull] MySqlParser.LeadLagInfoContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nullTreatment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullTreatment([NotNull] MySqlParser.NullTreatmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nullTreatment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullTreatment([NotNull] MySqlParser.NullTreatmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jsonFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterJsonFunction([NotNull] MySqlParser.JsonFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jsonFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitJsonFunction([NotNull] MySqlParser.JsonFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.inSumExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInSumExpr([NotNull] MySqlParser.InSumExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.inSumExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInSumExpr([NotNull] MySqlParser.InSumExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identListArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentListArg([NotNull] MySqlParser.IdentListArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identListArg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentListArg([NotNull] MySqlParser.IdentListArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentList([NotNull] MySqlParser.IdentListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentList([NotNull] MySqlParser.IdentListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fulltextOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFulltextOptions([NotNull] MySqlParser.FulltextOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fulltextOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFulltextOptions([NotNull] MySqlParser.FulltextOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.runtimeFunctionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRuntimeFunctionCall([NotNull] MySqlParser.RuntimeFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.runtimeFunctionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRuntimeFunctionCall([NotNull] MySqlParser.RuntimeFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.geometryFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGeometryFunction([NotNull] MySqlParser.GeometryFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.geometryFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGeometryFunction([NotNull] MySqlParser.GeometryFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.timeFunctionParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTimeFunctionParameters([NotNull] MySqlParser.TimeFunctionParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.timeFunctionParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTimeFunctionParameters([NotNull] MySqlParser.TimeFunctionParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fractionalPrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFractionalPrecision([NotNull] MySqlParser.FractionalPrecisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fractionalPrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFractionalPrecision([NotNull] MySqlParser.FractionalPrecisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.weightStringLevels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeightStringLevels([NotNull] MySqlParser.WeightStringLevelsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.weightStringLevels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeightStringLevels([NotNull] MySqlParser.WeightStringLevelsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.weightStringLevelListItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWeightStringLevelListItem([NotNull] MySqlParser.WeightStringLevelListItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.weightStringLevelListItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWeightStringLevelListItem([NotNull] MySqlParser.WeightStringLevelListItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dateTimeTtype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDateTimeTtype([NotNull] MySqlParser.DateTimeTtypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dateTimeTtype"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDateTimeTtype([NotNull] MySqlParser.DateTimeTtypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.trimFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrimFunction([NotNull] MySqlParser.TrimFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.trimFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrimFunction([NotNull] MySqlParser.TrimFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.substringFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubstringFunction([NotNull] MySqlParser.SubstringFunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.substringFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubstringFunction([NotNull] MySqlParser.SubstringFunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] MySqlParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] MySqlParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUdfExprList([NotNull] MySqlParser.UdfExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfExprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUdfExprList([NotNull] MySqlParser.UdfExprListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUdfExpr([NotNull] MySqlParser.UdfExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUdfExpr([NotNull] MySqlParser.UdfExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable([NotNull] MySqlParser.VariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable([NotNull] MySqlParser.VariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUserVariable([NotNull] MySqlParser.UserVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUserVariable([NotNull] MySqlParser.UserVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.systemVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSystemVariable([NotNull] MySqlParser.SystemVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.systemVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSystemVariable([NotNull] MySqlParser.SystemVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.internalVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInternalVariableName([NotNull] MySqlParser.InternalVariableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.internalVariableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInternalVariableName([NotNull] MySqlParser.InternalVariableNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whenExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhenExpression([NotNull] MySqlParser.WhenExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whenExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhenExpression([NotNull] MySqlParser.WhenExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.thenExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThenExpression([NotNull] MySqlParser.ThenExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.thenExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThenExpression([NotNull] MySqlParser.ThenExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.elseExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseExpression([NotNull] MySqlParser.ElseExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.elseExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseExpression([NotNull] MySqlParser.ElseExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.castType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCastType([NotNull] MySqlParser.CastTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.castType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCastType([NotNull] MySqlParser.CastTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprList([NotNull] MySqlParser.ExprListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprList([NotNull] MySqlParser.ExprListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharset([NotNull] MySqlParser.CharsetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharset([NotNull] MySqlParser.CharsetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.notRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotRule([NotNull] MySqlParser.NotRuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.notRule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotRule([NotNull] MySqlParser.NotRuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.not2Rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNot2Rule([NotNull] MySqlParser.Not2RuleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.not2Rule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNot2Rule([NotNull] MySqlParser.Not2RuleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInterval([NotNull] MySqlParser.IntervalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.interval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInterval([NotNull] MySqlParser.IntervalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.intervalTimeStamp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntervalTimeStamp([NotNull] MySqlParser.IntervalTimeStampContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.intervalTimeStamp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntervalTimeStamp([NotNull] MySqlParser.IntervalTimeStampContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprListWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprListWithParentheses([NotNull] MySqlParser.ExprListWithParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprListWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprListWithParentheses([NotNull] MySqlParser.ExprListWithParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprWithParentheses([NotNull] MySqlParser.ExprWithParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprWithParentheses([NotNull] MySqlParser.ExprWithParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleExprWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleExprWithParentheses([NotNull] MySqlParser.SimpleExprWithParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleExprWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleExprWithParentheses([NotNull] MySqlParser.SimpleExprWithParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderList([NotNull] MySqlParser.OrderListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderList([NotNull] MySqlParser.OrderListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderExpression([NotNull] MySqlParser.OrderExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderExpression([NotNull] MySqlParser.OrderExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupList([NotNull] MySqlParser.GroupListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupList([NotNull] MySqlParser.GroupListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroupingExpression([NotNull] MySqlParser.GroupingExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupingExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroupingExpression([NotNull] MySqlParser.GroupingExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.channel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChannel([NotNull] MySqlParser.ChannelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.channel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChannel([NotNull] MySqlParser.ChannelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundStatement([NotNull] MySqlParser.CompoundStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compoundStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundStatement([NotNull] MySqlParser.CompoundStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] MySqlParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] MySqlParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] MySqlParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] MySqlParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBody([NotNull] MySqlParser.IfBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBody([NotNull] MySqlParser.IfBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.thenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterThenStatement([NotNull] MySqlParser.ThenStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.thenStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitThenStatement([NotNull] MySqlParser.ThenStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compoundStatementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompoundStatementList([NotNull] MySqlParser.CompoundStatementListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compoundStatementList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompoundStatementList([NotNull] MySqlParser.CompoundStatementListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.caseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCaseStatement([NotNull] MySqlParser.CaseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.caseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCaseStatement([NotNull] MySqlParser.CaseStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseStatement([NotNull] MySqlParser.ElseStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.elseStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseStatement([NotNull] MySqlParser.ElseStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labeledBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledBlock([NotNull] MySqlParser.LabeledBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labeledBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledBlock([NotNull] MySqlParser.LabeledBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unlabeledBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnlabeledBlock([NotNull] MySqlParser.UnlabeledBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unlabeledBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnlabeledBlock([NotNull] MySqlParser.UnlabeledBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] MySqlParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] MySqlParser.LabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.beginEndBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBeginEndBlock([NotNull] MySqlParser.BeginEndBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.beginEndBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBeginEndBlock([NotNull] MySqlParser.BeginEndBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labeledControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabeledControl([NotNull] MySqlParser.LabeledControlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labeledControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabeledControl([NotNull] MySqlParser.LabeledControlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unlabeledControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnlabeledControl([NotNull] MySqlParser.UnlabeledControlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unlabeledControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnlabeledControl([NotNull] MySqlParser.UnlabeledControlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loopBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoopBlock([NotNull] MySqlParser.LoopBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loopBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoopBlock([NotNull] MySqlParser.LoopBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whileDoBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileDoBlock([NotNull] MySqlParser.WhileDoBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whileDoBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileDoBlock([NotNull] MySqlParser.WhileDoBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.repeatUntilBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeatUntilBlock([NotNull] MySqlParser.RepeatUntilBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.repeatUntilBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeatUntilBlock([NotNull] MySqlParser.RepeatUntilBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpDeclarations([NotNull] MySqlParser.SpDeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpDeclarations([NotNull] MySqlParser.SpDeclarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpDeclaration([NotNull] MySqlParser.SpDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpDeclaration([NotNull] MySqlParser.SpDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaration([NotNull] MySqlParser.VariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaration([NotNull] MySqlParser.VariableDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.conditionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionDeclaration([NotNull] MySqlParser.ConditionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.conditionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionDeclaration([NotNull] MySqlParser.ConditionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpCondition([NotNull] MySqlParser.SpConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpCondition([NotNull] MySqlParser.SpConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sqlstate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSqlstate([NotNull] MySqlParser.SqlstateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sqlstate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSqlstate([NotNull] MySqlParser.SqlstateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandlerDeclaration([NotNull] MySqlParser.HandlerDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandlerDeclaration([NotNull] MySqlParser.HandlerDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterHandlerCondition([NotNull] MySqlParser.HandlerConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerCondition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitHandlerCondition([NotNull] MySqlParser.HandlerConditionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursorDeclaration([NotNull] MySqlParser.CursorDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursorDeclaration([NotNull] MySqlParser.CursorDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.iterateStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterateStatement([NotNull] MySqlParser.IterateStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.iterateStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterateStatement([NotNull] MySqlParser.IterateStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.leaveStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeaveStatement([NotNull] MySqlParser.LeaveStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.leaveStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeaveStatement([NotNull] MySqlParser.LeaveStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.getDiagnostics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGetDiagnostics([NotNull] MySqlParser.GetDiagnosticsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.getDiagnostics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGetDiagnostics([NotNull] MySqlParser.GetDiagnosticsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalAllowedExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignalAllowedExpr([NotNull] MySqlParser.SignalAllowedExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalAllowedExpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignalAllowedExpr([NotNull] MySqlParser.SignalAllowedExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.statementInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementInformationItem([NotNull] MySqlParser.StatementInformationItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.statementInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementInformationItem([NotNull] MySqlParser.StatementInformationItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.conditionInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConditionInformationItem([NotNull] MySqlParser.ConditionInformationItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.conditionInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConditionInformationItem([NotNull] MySqlParser.ConditionInformationItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalInformationItemName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignalInformationItemName([NotNull] MySqlParser.SignalInformationItemNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalInformationItemName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignalInformationItemName([NotNull] MySqlParser.SignalInformationItemNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignalStatement([NotNull] MySqlParser.SignalStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignalStatement([NotNull] MySqlParser.SignalStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resignalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResignalStatement([NotNull] MySqlParser.ResignalStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resignalStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResignalStatement([NotNull] MySqlParser.ResignalStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignalInformationItem([NotNull] MySqlParser.SignalInformationItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalInformationItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignalInformationItem([NotNull] MySqlParser.SignalInformationItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorOpen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursorOpen([NotNull] MySqlParser.CursorOpenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorOpen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursorOpen([NotNull] MySqlParser.CursorOpenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorClose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursorClose([NotNull] MySqlParser.CursorCloseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorClose"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursorClose([NotNull] MySqlParser.CursorCloseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorFetch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCursorFetch([NotNull] MySqlParser.CursorFetchContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorFetch"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCursorFetch([NotNull] MySqlParser.CursorFetchContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schedule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchedule([NotNull] MySqlParser.ScheduleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schedule"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchedule([NotNull] MySqlParser.ScheduleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnDefinition([NotNull] MySqlParser.ColumnDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnDefinition([NotNull] MySqlParser.ColumnDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkOrReferences"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckOrReferences([NotNull] MySqlParser.CheckOrReferencesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkOrReferences"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckOrReferences([NotNull] MySqlParser.CheckOrReferencesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCheckConstraint([NotNull] MySqlParser.CheckConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCheckConstraint([NotNull] MySqlParser.CheckConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintEnforcement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintEnforcement([NotNull] MySqlParser.ConstraintEnforcementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintEnforcement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintEnforcement([NotNull] MySqlParser.ConstraintEnforcementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableConstraintDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableConstraintDef([NotNull] MySqlParser.TableConstraintDefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableConstraintDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableConstraintDef([NotNull] MySqlParser.TableConstraintDefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraintName([NotNull] MySqlParser.ConstraintNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraintName([NotNull] MySqlParser.ConstraintNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldDefinition([NotNull] MySqlParser.FieldDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldDefinition([NotNull] MySqlParser.FieldDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnAttribute([NotNull] MySqlParser.ColumnAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnAttribute([NotNull] MySqlParser.ColumnAttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnFormat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnFormat([NotNull] MySqlParser.ColumnFormatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnFormat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnFormat([NotNull] MySqlParser.ColumnFormatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.storageMedia"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStorageMedia([NotNull] MySqlParser.StorageMediaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.storageMedia"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStorageMedia([NotNull] MySqlParser.StorageMediaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.gcolAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGcolAttribute([NotNull] MySqlParser.GcolAttributeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.gcolAttribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGcolAttribute([NotNull] MySqlParser.GcolAttributeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.references"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReferences([NotNull] MySqlParser.ReferencesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.references"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReferences([NotNull] MySqlParser.ReferencesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeleteOption([NotNull] MySqlParser.DeleteOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeleteOption([NotNull] MySqlParser.DeleteOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyList([NotNull] MySqlParser.KeyListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyList([NotNull] MySqlParser.KeyListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyPart([NotNull] MySqlParser.KeyPartContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyPart"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyPart([NotNull] MySqlParser.KeyPartContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyListWithExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyListWithExpression([NotNull] MySqlParser.KeyListWithExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyListWithExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyListWithExpression([NotNull] MySqlParser.KeyListWithExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyPartOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyPartOrExpression([NotNull] MySqlParser.KeyPartOrExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyPartOrExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyPartOrExpression([NotNull] MySqlParser.KeyPartOrExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyListVariants"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyListVariants([NotNull] MySqlParser.KeyListVariantsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyListVariants"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyListVariants([NotNull] MySqlParser.KeyListVariantsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexType([NotNull] MySqlParser.IndexTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexType([NotNull] MySqlParser.IndexTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexOption([NotNull] MySqlParser.IndexOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexOption([NotNull] MySqlParser.IndexOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.commonIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommonIndexOption([NotNull] MySqlParser.CommonIndexOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.commonIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommonIndexOption([NotNull] MySqlParser.CommonIndexOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.visibility"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVisibility([NotNull] MySqlParser.VisibilityContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.visibility"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVisibility([NotNull] MySqlParser.VisibilityContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexTypeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexTypeClause([NotNull] MySqlParser.IndexTypeClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexTypeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexTypeClause([NotNull] MySqlParser.IndexTypeClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fulltextIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFulltextIndexOption([NotNull] MySqlParser.FulltextIndexOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fulltextIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFulltextIndexOption([NotNull] MySqlParser.FulltextIndexOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spatialIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSpatialIndexOption([NotNull] MySqlParser.SpatialIndexOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spatialIndexOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSpatialIndexOption([NotNull] MySqlParser.SpatialIndexOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataTypeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataTypeDefinition([NotNull] MySqlParser.DataTypeDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataTypeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataTypeDefinition([NotNull] MySqlParser.DataTypeDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDataType([NotNull] MySqlParser.DataTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDataType([NotNull] MySqlParser.DataTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nchar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNchar([NotNull] MySqlParser.NcharContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nchar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNchar([NotNull] MySqlParser.NcharContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.realType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRealType([NotNull] MySqlParser.RealTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.realType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRealType([NotNull] MySqlParser.RealTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldLength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldLength([NotNull] MySqlParser.FieldLengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldLength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldLength([NotNull] MySqlParser.FieldLengthContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldOptions([NotNull] MySqlParser.FieldOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldOptions([NotNull] MySqlParser.FieldOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetWithOptBinary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharsetWithOptBinary([NotNull] MySqlParser.CharsetWithOptBinaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetWithOptBinary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharsetWithOptBinary([NotNull] MySqlParser.CharsetWithOptBinaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ascii"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAscii([NotNull] MySqlParser.AsciiContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ascii"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAscii([NotNull] MySqlParser.AsciiContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unicode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnicode([NotNull] MySqlParser.UnicodeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unicode"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnicode([NotNull] MySqlParser.UnicodeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.wsNumCodepoints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWsNumCodepoints([NotNull] MySqlParser.WsNumCodepointsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.wsNumCodepoints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWsNumCodepoints([NotNull] MySqlParser.WsNumCodepointsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.typeDatetimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDatetimePrecision([NotNull] MySqlParser.TypeDatetimePrecisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.typeDatetimePrecision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDatetimePrecision([NotNull] MySqlParser.TypeDatetimePrecisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharsetName([NotNull] MySqlParser.CharsetNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharsetName([NotNull] MySqlParser.CharsetNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.collationName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollationName([NotNull] MySqlParser.CollationNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.collationName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollationName([NotNull] MySqlParser.CollationNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTableOptions([NotNull] MySqlParser.CreateTableOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTableOptions([NotNull] MySqlParser.CreateTableOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOptionsSpaceSeparated"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTableOptionsSpaceSeparated([NotNull] MySqlParser.CreateTableOptionsSpaceSeparatedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOptionsSpaceSeparated"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTableOptionsSpaceSeparated([NotNull] MySqlParser.CreateTableOptionsSpaceSeparatedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateTableOption([NotNull] MySqlParser.CreateTableOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateTableOption([NotNull] MySqlParser.CreateTableOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ternaryOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTernaryOption([NotNull] MySqlParser.TernaryOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ternaryOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTernaryOption([NotNull] MySqlParser.TernaryOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultCollation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultCollation([NotNull] MySqlParser.DefaultCollationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultCollation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultCollation([NotNull] MySqlParser.DefaultCollationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultEncryption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultEncryption([NotNull] MySqlParser.DefaultEncryptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultEncryption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultEncryption([NotNull] MySqlParser.DefaultEncryptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultCharset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefaultCharset([NotNull] MySqlParser.DefaultCharsetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultCharset"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefaultCharset([NotNull] MySqlParser.DefaultCharsetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionClause([NotNull] MySqlParser.PartitionClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionClause([NotNull] MySqlParser.PartitionClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefKey</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDefKey([NotNull] MySqlParser.PartitionDefKeyContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefKey</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDefKey([NotNull] MySqlParser.PartitionDefKeyContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefHash</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDefHash([NotNull] MySqlParser.PartitionDefHashContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefHash</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDefHash([NotNull] MySqlParser.PartitionDefHashContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefRangeList</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDefRangeList([NotNull] MySqlParser.PartitionDefRangeListContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefRangeList</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDefRangeList([NotNull] MySqlParser.PartitionDefRangeListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subPartitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubPartitions([NotNull] MySqlParser.SubPartitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subPartitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubPartitions([NotNull] MySqlParser.SubPartitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionKeyAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionKeyAlgorithm([NotNull] MySqlParser.PartitionKeyAlgorithmContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionKeyAlgorithm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionKeyAlgorithm([NotNull] MySqlParser.PartitionKeyAlgorithmContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDefinitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDefinitions([NotNull] MySqlParser.PartitionDefinitionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDefinitions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDefinitions([NotNull] MySqlParser.PartitionDefinitionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionDefinition([NotNull] MySqlParser.PartitionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionDefinition([NotNull] MySqlParser.PartitionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValuesIn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionValuesIn([NotNull] MySqlParser.PartitionValuesInContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValuesIn"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionValuesIn([NotNull] MySqlParser.PartitionValuesInContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionOption([NotNull] MySqlParser.PartitionOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionOption([NotNull] MySqlParser.PartitionOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subpartitionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSubpartitionDefinition([NotNull] MySqlParser.SubpartitionDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subpartitionDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSubpartitionDefinition([NotNull] MySqlParser.SubpartitionDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValueItemListParen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionValueItemListParen([NotNull] MySqlParser.PartitionValueItemListParenContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValueItemListParen"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionValueItemListParen([NotNull] MySqlParser.PartitionValueItemListParenContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValueItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPartitionValueItem([NotNull] MySqlParser.PartitionValueItemContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValueItem"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPartitionValueItem([NotNull] MySqlParser.PartitionValueItemContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.definerClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDefinerClause([NotNull] MySqlParser.DefinerClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.definerClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDefinerClause([NotNull] MySqlParser.DefinerClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifExists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfExists([NotNull] MySqlParser.IfExistsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifExists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfExists([NotNull] MySqlParser.IfExistsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifNotExists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfNotExists([NotNull] MySqlParser.IfNotExistsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifNotExists"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfNotExists([NotNull] MySqlParser.IfNotExistsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedureParameter([NotNull] MySqlParser.ProcedureParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedureParameter([NotNull] MySqlParser.ProcedureParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionParameter([NotNull] MySqlParser.FunctionParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionParameter([NotNull] MySqlParser.FunctionParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCollate([NotNull] MySqlParser.CollateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.collate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCollate([NotNull] MySqlParser.CollateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.typeWithOptCollate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeWithOptCollate([NotNull] MySqlParser.TypeWithOptCollateContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.typeWithOptCollate"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeWithOptCollate([NotNull] MySqlParser.TypeWithOptCollateContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaIdentifierPair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaIdentifierPair([NotNull] MySqlParser.SchemaIdentifierPairContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaIdentifierPair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaIdentifierPair([NotNull] MySqlParser.SchemaIdentifierPairContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewRefList([NotNull] MySqlParser.ViewRefListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewRefList([NotNull] MySqlParser.ViewRefListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateList([NotNull] MySqlParser.UpdateListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateList([NotNull] MySqlParser.UpdateListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUpdateElement([NotNull] MySqlParser.UpdateElementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateElement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUpdateElement([NotNull] MySqlParser.UpdateElementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCharsetClause([NotNull] MySqlParser.CharsetClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCharsetClause([NotNull] MySqlParser.CharsetClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldsClause([NotNull] MySqlParser.FieldsClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldsClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldsClause([NotNull] MySqlParser.FieldsClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldTerm([NotNull] MySqlParser.FieldTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldTerm([NotNull] MySqlParser.FieldTermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.linesClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLinesClause([NotNull] MySqlParser.LinesClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.linesClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLinesClause([NotNull] MySqlParser.LinesClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lineTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineTerm([NotNull] MySqlParser.LineTermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lineTerm"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineTerm([NotNull] MySqlParser.LineTermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUserList([NotNull] MySqlParser.UserListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUserList([NotNull] MySqlParser.UserListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUserList([NotNull] MySqlParser.CreateUserListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUserList([NotNull] MySqlParser.CreateUserListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterUserList([NotNull] MySqlParser.AlterUserListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterUserList([NotNull] MySqlParser.AlterUserListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreateUserEntry([NotNull] MySqlParser.CreateUserEntryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreateUserEntry([NotNull] MySqlParser.CreateUserEntryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAlterUserEntry([NotNull] MySqlParser.AlterUserEntryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserEntry"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAlterUserEntry([NotNull] MySqlParser.AlterUserEntryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.retainCurrentPassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRetainCurrentPassword([NotNull] MySqlParser.RetainCurrentPasswordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.retainCurrentPassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRetainCurrentPassword([NotNull] MySqlParser.RetainCurrentPasswordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.discardOldPassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDiscardOldPassword([NotNull] MySqlParser.DiscardOldPasswordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.discardOldPassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDiscardOldPassword([NotNull] MySqlParser.DiscardOldPasswordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replacePassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReplacePassword([NotNull] MySqlParser.ReplacePasswordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replacePassword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReplacePassword([NotNull] MySqlParser.ReplacePasswordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userIdentifierOrText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUserIdentifierOrText([NotNull] MySqlParser.UserIdentifierOrTextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userIdentifierOrText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUserIdentifierOrText([NotNull] MySqlParser.UserIdentifierOrTextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUser([NotNull] MySqlParser.UserContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.user"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUser([NotNull] MySqlParser.UserContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.likeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikeClause([NotNull] MySqlParser.LikeClauseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.likeClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikeClause([NotNull] MySqlParser.LikeClauseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.likeOrWhere"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLikeOrWhere([NotNull] MySqlParser.LikeOrWhereContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.likeOrWhere"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLikeOrWhere([NotNull] MySqlParser.LikeOrWhereContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onlineOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOnlineOption([NotNull] MySqlParser.OnlineOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onlineOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOnlineOption([NotNull] MySqlParser.OnlineOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.noWriteToBinLog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNoWriteToBinLog([NotNull] MySqlParser.NoWriteToBinLogContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.noWriteToBinLog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNoWriteToBinLog([NotNull] MySqlParser.NoWriteToBinLogContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.usePartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUsePartition([NotNull] MySqlParser.UsePartitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.usePartition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUsePartition([NotNull] MySqlParser.UsePartitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldIdentifier([NotNull] MySqlParser.FieldIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldIdentifier([NotNull] MySqlParser.FieldIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnName([NotNull] MySqlParser.ColumnNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnName([NotNull] MySqlParser.ColumnNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnInternalRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnInternalRef([NotNull] MySqlParser.ColumnInternalRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnInternalRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnInternalRef([NotNull] MySqlParser.ColumnInternalRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnInternalRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnInternalRefList([NotNull] MySqlParser.ColumnInternalRefListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnInternalRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnInternalRefList([NotNull] MySqlParser.ColumnInternalRefListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterColumnRef([NotNull] MySqlParser.ColumnRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitColumnRef([NotNull] MySqlParser.ColumnRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInsertIdentifier([NotNull] MySqlParser.InsertIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInsertIdentifier([NotNull] MySqlParser.InsertIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexName([NotNull] MySqlParser.IndexNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexName([NotNull] MySqlParser.IndexNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIndexRef([NotNull] MySqlParser.IndexRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIndexRef([NotNull] MySqlParser.IndexRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableWild"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableWild([NotNull] MySqlParser.TableWildContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableWild"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableWild([NotNull] MySqlParser.TableWildContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaName([NotNull] MySqlParser.SchemaNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaName([NotNull] MySqlParser.SchemaNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSchemaRef([NotNull] MySqlParser.SchemaRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSchemaRef([NotNull] MySqlParser.SchemaRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedureName([NotNull] MySqlParser.ProcedureNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedureName([NotNull] MySqlParser.ProcedureNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProcedureRef([NotNull] MySqlParser.ProcedureRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProcedureRef([NotNull] MySqlParser.ProcedureRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionName([NotNull] MySqlParser.FunctionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionName([NotNull] MySqlParser.FunctionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionRef([NotNull] MySqlParser.FunctionRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionRef([NotNull] MySqlParser.FunctionRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerName([NotNull] MySqlParser.TriggerNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerName([NotNull] MySqlParser.TriggerNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTriggerRef([NotNull] MySqlParser.TriggerRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTriggerRef([NotNull] MySqlParser.TriggerRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewName([NotNull] MySqlParser.ViewNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewName([NotNull] MySqlParser.ViewNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterViewRef([NotNull] MySqlParser.ViewRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitViewRef([NotNull] MySqlParser.ViewRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespaceName([NotNull] MySqlParser.TablespaceNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespaceName([NotNull] MySqlParser.TablespaceNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTablespaceRef([NotNull] MySqlParser.TablespaceRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTablespaceRef([NotNull] MySqlParser.TablespaceRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfileGroupName([NotNull] MySqlParser.LogfileGroupNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfileGroupName([NotNull] MySqlParser.LogfileGroupNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLogfileGroupRef([NotNull] MySqlParser.LogfileGroupRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLogfileGroupRef([NotNull] MySqlParser.LogfileGroupRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.eventName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEventName([NotNull] MySqlParser.EventNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.eventName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEventName([NotNull] MySqlParser.EventNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.eventRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEventRef([NotNull] MySqlParser.EventRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.eventRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEventRef([NotNull] MySqlParser.EventRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUdfName([NotNull] MySqlParser.UdfNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUdfName([NotNull] MySqlParser.UdfNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterServerName([NotNull] MySqlParser.ServerNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitServerName([NotNull] MySqlParser.ServerNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterServerRef([NotNull] MySqlParser.ServerRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitServerRef([NotNull] MySqlParser.ServerRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.engineRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEngineRef([NotNull] MySqlParser.EngineRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.engineRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEngineRef([NotNull] MySqlParser.EngineRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableName([NotNull] MySqlParser.TableNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableName([NotNull] MySqlParser.TableNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterTableRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFilterTableRef([NotNull] MySqlParser.FilterTableRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterTableRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFilterTableRef([NotNull] MySqlParser.FilterTableRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRefWithWildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRefWithWildcard([NotNull] MySqlParser.TableRefWithWildcardContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRefWithWildcard"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRefWithWildcard([NotNull] MySqlParser.TableRefWithWildcardContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRef([NotNull] MySqlParser.TableRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRef([NotNull] MySqlParser.TableRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableRefList([NotNull] MySqlParser.TableRefListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableRefList([NotNull] MySqlParser.TableRefListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAliasRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableAliasRefList([NotNull] MySqlParser.TableAliasRefListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAliasRefList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableAliasRefList([NotNull] MySqlParser.TableAliasRefListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterName([NotNull] MySqlParser.ParameterNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.parameterName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterName([NotNull] MySqlParser.ParameterNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelIdentifier([NotNull] MySqlParser.LabelIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelIdentifier([NotNull] MySqlParser.LabelIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelRef([NotNull] MySqlParser.LabelRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelRef([NotNull] MySqlParser.LabelRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleIdentifier([NotNull] MySqlParser.RoleIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleIdentifier([NotNull] MySqlParser.RoleIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleRef([NotNull] MySqlParser.RoleRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleRef([NotNull] MySqlParser.RoleRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.pluginRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPluginRef([NotNull] MySqlParser.PluginRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.pluginRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPluginRef([NotNull] MySqlParser.PluginRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.componentRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComponentRef([NotNull] MySqlParser.ComponentRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.componentRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComponentRef([NotNull] MySqlParser.ComponentRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterResourceGroupRef([NotNull] MySqlParser.ResourceGroupRefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupRef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitResourceGroupRef([NotNull] MySqlParser.ResourceGroupRefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWindowName([NotNull] MySqlParser.WindowNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWindowName([NotNull] MySqlParser.WindowNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.pureIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPureIdentifier([NotNull] MySqlParser.PureIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.pureIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPureIdentifier([NotNull] MySqlParser.PureIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] MySqlParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] MySqlParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierList([NotNull] MySqlParser.IdentifierListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierList([NotNull] MySqlParser.IdentifierListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierListWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierListWithParentheses([NotNull] MySqlParser.IdentifierListWithParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierListWithParentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierListWithParentheses([NotNull] MySqlParser.IdentifierListWithParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterQualifiedIdentifier([NotNull] MySqlParser.QualifiedIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.qualifiedIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitQualifiedIdentifier([NotNull] MySqlParser.QualifiedIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSimpleIdentifier([NotNull] MySqlParser.SimpleIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSimpleIdentifier([NotNull] MySqlParser.SimpleIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dotIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDotIdentifier([NotNull] MySqlParser.DotIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dotIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDotIdentifier([NotNull] MySqlParser.DotIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ulong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUlong_number([NotNull] MySqlParser.Ulong_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ulong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUlong_number([NotNull] MySqlParser.Ulong_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.real_ulong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReal_ulong_number([NotNull] MySqlParser.Real_ulong_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.real_ulong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReal_ulong_number([NotNull] MySqlParser.Real_ulong_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ulonglong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUlonglong_number([NotNull] MySqlParser.Ulonglong_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ulonglong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUlonglong_number([NotNull] MySqlParser.Ulonglong_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.real_ulonglong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReal_ulonglong_number([NotNull] MySqlParser.Real_ulonglong_numberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.real_ulonglong_number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReal_ulonglong_number([NotNull] MySqlParser.Real_ulonglong_numberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] MySqlParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] MySqlParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signedLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignedLiteral([NotNull] MySqlParser.SignedLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signedLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignedLiteral([NotNull] MySqlParser.SignedLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.stringList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringList([NotNull] MySqlParser.StringListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.stringList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringList([NotNull] MySqlParser.StringListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextStringLiteral([NotNull] MySqlParser.TextStringLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextStringLiteral([NotNull] MySqlParser.TextStringLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextString([NotNull] MySqlParser.TextStringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textString"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextString([NotNull] MySqlParser.TextStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringHash"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextStringHash([NotNull] MySqlParser.TextStringHashContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringHash"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextStringHash([NotNull] MySqlParser.TextStringHashContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextLiteral([NotNull] MySqlParser.TextLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextLiteral([NotNull] MySqlParser.TextLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringNoLinebreak"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextStringNoLinebreak([NotNull] MySqlParser.TextStringNoLinebreakContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringNoLinebreak"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextStringNoLinebreak([NotNull] MySqlParser.TextStringNoLinebreakContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringLiteralList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextStringLiteralList([NotNull] MySqlParser.TextStringLiteralListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringLiteralList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextStringLiteralList([NotNull] MySqlParser.TextStringLiteralListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.numLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumLiteral([NotNull] MySqlParser.NumLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.numLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumLiteral([NotNull] MySqlParser.NumLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.boolLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolLiteral([NotNull] MySqlParser.BoolLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.boolLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolLiteral([NotNull] MySqlParser.BoolLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNullLiteral([NotNull] MySqlParser.NullLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nullLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNullLiteral([NotNull] MySqlParser.NullLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.temporalLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemporalLiteral([NotNull] MySqlParser.TemporalLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.temporalLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemporalLiteral([NotNull] MySqlParser.TemporalLiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.floatOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatOptions([NotNull] MySqlParser.FloatOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.floatOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatOptions([NotNull] MySqlParser.FloatOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.standardFloatOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStandardFloatOptions([NotNull] MySqlParser.StandardFloatOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.standardFloatOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStandardFloatOptions([NotNull] MySqlParser.StandardFloatOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.precision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrecision([NotNull] MySqlParser.PrecisionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.precision"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrecision([NotNull] MySqlParser.PrecisionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textOrIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTextOrIdentifier([NotNull] MySqlParser.TextOrIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textOrIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTextOrIdentifier([NotNull] MySqlParser.TextOrIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lValueIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLValueIdentifier([NotNull] MySqlParser.LValueIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lValueIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLValueIdentifier([NotNull] MySqlParser.LValueIdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleIdentifierOrText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleIdentifierOrText([NotNull] MySqlParser.RoleIdentifierOrTextContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleIdentifierOrText"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleIdentifierOrText([NotNull] MySqlParser.RoleIdentifierOrTextContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sizeNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSizeNumber([NotNull] MySqlParser.SizeNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sizeNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSizeNumber([NotNull] MySqlParser.SizeNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.parentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParentheses([NotNull] MySqlParser.ParenthesesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.parentheses"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParentheses([NotNull] MySqlParser.ParenthesesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEqual([NotNull] MySqlParser.EqualContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.equal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEqual([NotNull] MySqlParser.EqualContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionType([NotNull] MySqlParser.OptionTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionType([NotNull] MySqlParser.OptionTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.varIdentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarIdentType([NotNull] MySqlParser.VarIdentTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.varIdentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarIdentType([NotNull] MySqlParser.VarIdentTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setVarIdentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSetVarIdentType([NotNull] MySqlParser.SetVarIdentTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setVarIdentType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSetVarIdentType([NotNull] MySqlParser.SetVarIdentTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeyword([NotNull] MySqlParser.IdentifierKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeyword([NotNull] MySqlParser.IdentifierKeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous1RolesAndLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeywordsAmbiguous1RolesAndLabels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous1RolesAndLabelsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous1RolesAndLabels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeywordsAmbiguous1RolesAndLabels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous1RolesAndLabelsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous2Labels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeywordsAmbiguous2Labels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous2LabelsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous2Labels"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeywordsAmbiguous2Labels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous2LabelsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabelKeyword([NotNull] MySqlParser.LabelKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabelKeyword([NotNull] MySqlParser.LabelKeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous3Roles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeywordsAmbiguous3Roles([NotNull] MySqlParser.IdentifierKeywordsAmbiguous3RolesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous3Roles"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeywordsAmbiguous3Roles([NotNull] MySqlParser.IdentifierKeywordsAmbiguous3RolesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsUnambiguous"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeywordsUnambiguous([NotNull] MySqlParser.IdentifierKeywordsUnambiguousContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsUnambiguous"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeywordsUnambiguous([NotNull] MySqlParser.IdentifierKeywordsUnambiguousContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleKeyword([NotNull] MySqlParser.RoleKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleKeyword([NotNull] MySqlParser.RoleKeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lValueKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLValueKeyword([NotNull] MySqlParser.LValueKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lValueKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLValueKeyword([NotNull] MySqlParser.LValueKeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous4SystemVariables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierKeywordsAmbiguous4SystemVariables([NotNull] MySqlParser.IdentifierKeywordsAmbiguous4SystemVariablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous4SystemVariables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierKeywordsAmbiguous4SystemVariables([NotNull] MySqlParser.IdentifierKeywordsAmbiguous4SystemVariablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrIdentifierKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleOrIdentifierKeyword([NotNull] MySqlParser.RoleOrIdentifierKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrIdentifierKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleOrIdentifierKeyword([NotNull] MySqlParser.RoleOrIdentifierKeywordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrLabelKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRoleOrLabelKeyword([NotNull] MySqlParser.RoleOrLabelKeywordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrLabelKeyword"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRoleOrLabelKeyword([NotNull] MySqlParser.RoleOrLabelKeywordContext context);
}
