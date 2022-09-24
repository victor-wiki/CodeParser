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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="ImySqlParserListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.10.1")]
[System.Diagnostics.DebuggerNonUserCode]
public partial class MySqlParserBaseListener : IMySqlParserListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuery([NotNull] MySqlParser.QueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuery([NotNull] MySqlParser.QueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleStatement([NotNull] MySqlParser.SimpleStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleStatement([NotNull] MySqlParser.SimpleStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterStatement([NotNull] MySqlParser.AlterStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterStatement([NotNull] MySqlParser.AlterStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterDatabase([NotNull] MySqlParser.AlterDatabaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterDatabase([NotNull] MySqlParser.AlterDatabaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterEvent([NotNull] MySqlParser.AlterEventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterEvent([NotNull] MySqlParser.AlterEventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterLogfileGroup([NotNull] MySqlParser.AlterLogfileGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterLogfileGroup([NotNull] MySqlParser.AlterLogfileGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterLogfileGroupOptions([NotNull] MySqlParser.AlterLogfileGroupOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterLogfileGroupOptions([NotNull] MySqlParser.AlterLogfileGroupOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterLogfileGroupOption([NotNull] MySqlParser.AlterLogfileGroupOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLogfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterLogfileGroupOption([NotNull] MySqlParser.AlterLogfileGroupOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterServer([NotNull] MySqlParser.AlterServerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterServer([NotNull] MySqlParser.AlterServerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTable([NotNull] MySqlParser.AlterTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTable([NotNull] MySqlParser.AlterTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTableActions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTableActions([NotNull] MySqlParser.AlterTableActionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTableActions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTableActions([NotNull] MySqlParser.AlterTableActionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterCommandList([NotNull] MySqlParser.AlterCommandListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterCommandList([NotNull] MySqlParser.AlterCommandListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandsModifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterCommandsModifierList([NotNull] MySqlParser.AlterCommandsModifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandsModifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterCommandsModifierList([NotNull] MySqlParser.AlterCommandsModifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.standaloneAlterCommands"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStandaloneAlterCommands([NotNull] MySqlParser.StandaloneAlterCommandsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.standaloneAlterCommands"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStandaloneAlterCommands([NotNull] MySqlParser.StandaloneAlterCommandsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterPartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterPartition([NotNull] MySqlParser.AlterPartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterPartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterPartition([NotNull] MySqlParser.AlterPartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterList([NotNull] MySqlParser.AlterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterList([NotNull] MySqlParser.AlterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterCommandsModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterCommandsModifier([NotNull] MySqlParser.AlterCommandsModifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterCommandsModifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterCommandsModifier([NotNull] MySqlParser.AlterCommandsModifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterListItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterListItem([NotNull] MySqlParser.AlterListItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterListItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterListItem([NotNull] MySqlParser.AlterListItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.place"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPlace([NotNull] MySqlParser.PlaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.place"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPlace([NotNull] MySqlParser.PlaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.restrict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRestrict([NotNull] MySqlParser.RestrictContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.restrict"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRestrict([NotNull] MySqlParser.RestrictContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterOrderList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterOrderList([NotNull] MySqlParser.AlterOrderListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterOrderList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterOrderList([NotNull] MySqlParser.AlterOrderListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterAlgorithmOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterAlgorithmOption([NotNull] MySqlParser.AlterAlgorithmOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterAlgorithmOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterAlgorithmOption([NotNull] MySqlParser.AlterAlgorithmOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterLockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterLockOption([NotNull] MySqlParser.AlterLockOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterLockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterLockOption([NotNull] MySqlParser.AlterLockOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexLockAndAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexLockAndAlgorithm([NotNull] MySqlParser.IndexLockAndAlgorithmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexLockAndAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexLockAndAlgorithm([NotNull] MySqlParser.IndexLockAndAlgorithmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withValidation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithValidation([NotNull] MySqlParser.WithValidationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withValidation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithValidation([NotNull] MySqlParser.WithValidationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.removePartitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRemovePartitioning([NotNull] MySqlParser.RemovePartitioningContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.removePartitioning"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRemovePartitioning([NotNull] MySqlParser.RemovePartitioningContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.allOrPartitionNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAllOrPartitionNameList([NotNull] MySqlParser.AllOrPartitionNameListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.allOrPartitionNameList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAllOrPartitionNameList([NotNull] MySqlParser.AllOrPartitionNameListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTablespace([NotNull] MySqlParser.AlterTablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTablespace([NotNull] MySqlParser.AlterTablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterUndoTablespace([NotNull] MySqlParser.AlterUndoTablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterUndoTablespace([NotNull] MySqlParser.AlterUndoTablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.undoTableSpaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUndoTableSpaceOptions([NotNull] MySqlParser.UndoTableSpaceOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.undoTableSpaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUndoTableSpaceOptions([NotNull] MySqlParser.UndoTableSpaceOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.undoTableSpaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUndoTableSpaceOption([NotNull] MySqlParser.UndoTableSpaceOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.undoTableSpaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUndoTableSpaceOption([NotNull] MySqlParser.UndoTableSpaceOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTablespaceOptions([NotNull] MySqlParser.AlterTablespaceOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTablespaceOptions([NotNull] MySqlParser.AlterTablespaceOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterTablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterTablespaceOption([NotNull] MySqlParser.AlterTablespaceOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterTablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterTablespaceOption([NotNull] MySqlParser.AlterTablespaceOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeTablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChangeTablespaceOption([NotNull] MySqlParser.ChangeTablespaceOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeTablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChangeTablespaceOption([NotNull] MySqlParser.ChangeTablespaceOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterView([NotNull] MySqlParser.AlterViewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterView([NotNull] MySqlParser.AlterViewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewTail([NotNull] MySqlParser.ViewTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewTail([NotNull] MySqlParser.ViewTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewSelect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewSelect([NotNull] MySqlParser.ViewSelectContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewSelect"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewSelect([NotNull] MySqlParser.ViewSelectContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewCheckOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewCheckOption([NotNull] MySqlParser.ViewCheckOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewCheckOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewCheckOption([NotNull] MySqlParser.ViewCheckOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateStatement([NotNull] MySqlParser.CreateStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateStatement([NotNull] MySqlParser.CreateStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateDatabase([NotNull] MySqlParser.CreateDatabaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateDatabase([NotNull] MySqlParser.CreateDatabaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createDatabaseOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateDatabaseOption([NotNull] MySqlParser.CreateDatabaseOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createDatabaseOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateDatabaseOption([NotNull] MySqlParser.CreateDatabaseOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTable([NotNull] MySqlParser.CreateTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTable([NotNull] MySqlParser.CreateTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableElementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElementList([NotNull] MySqlParser.TableElementListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableElementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElementList([NotNull] MySqlParser.TableElementListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableElement([NotNull] MySqlParser.TableElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableElement([NotNull] MySqlParser.TableElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.duplicateAsQueryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDuplicateAsQueryExpression([NotNull] MySqlParser.DuplicateAsQueryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.duplicateAsQueryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDuplicateAsQueryExpression([NotNull] MySqlParser.DuplicateAsQueryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionOrParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryExpressionOrParens([NotNull] MySqlParser.QueryExpressionOrParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionOrParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryExpressionOrParens([NotNull] MySqlParser.QueryExpressionOrParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createRoutine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateRoutine([NotNull] MySqlParser.CreateRoutineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createRoutine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateRoutine([NotNull] MySqlParser.CreateRoutineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createProcedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateProcedure([NotNull] MySqlParser.CreateProcedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createProcedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateProcedure([NotNull] MySqlParser.CreateProcedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateFunction([NotNull] MySqlParser.CreateFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateFunction([NotNull] MySqlParser.CreateFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUdf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUdf([NotNull] MySqlParser.CreateUdfContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUdf"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUdf([NotNull] MySqlParser.CreateUdfContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineCreateOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutineCreateOption([NotNull] MySqlParser.RoutineCreateOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineCreateOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutineCreateOption([NotNull] MySqlParser.RoutineCreateOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineAlterOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutineAlterOptions([NotNull] MySqlParser.RoutineAlterOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineAlterOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutineAlterOptions([NotNull] MySqlParser.RoutineAlterOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.routineOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoutineOption([NotNull] MySqlParser.RoutineOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.routineOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoutineOption([NotNull] MySqlParser.RoutineOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateIndex([NotNull] MySqlParser.CreateIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateIndex([NotNull] MySqlParser.CreateIndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexNameAndType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexNameAndType([NotNull] MySqlParser.IndexNameAndTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexNameAndType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexNameAndType([NotNull] MySqlParser.IndexNameAndTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createIndexTarget"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateIndexTarget([NotNull] MySqlParser.CreateIndexTargetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createIndexTarget"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateIndexTarget([NotNull] MySqlParser.CreateIndexTargetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateLogfileGroup([NotNull] MySqlParser.CreateLogfileGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateLogfileGroup([NotNull] MySqlParser.CreateLogfileGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfileGroupOptions([NotNull] MySqlParser.LogfileGroupOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfileGroupOptions([NotNull] MySqlParser.LogfileGroupOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfileGroupOption([NotNull] MySqlParser.LogfileGroupOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfileGroupOption([NotNull] MySqlParser.LogfileGroupOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateServer([NotNull] MySqlParser.CreateServerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateServer([NotNull] MySqlParser.CreateServerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterServerOptions([NotNull] MySqlParser.ServerOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitServerOptions([NotNull] MySqlParser.ServerOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterServerOption([NotNull] MySqlParser.ServerOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitServerOption([NotNull] MySqlParser.ServerOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTablespace([NotNull] MySqlParser.CreateTablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTablespace([NotNull] MySqlParser.CreateTablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUndoTablespace([NotNull] MySqlParser.CreateUndoTablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUndoTablespace([NotNull] MySqlParser.CreateUndoTablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsDataFileName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsDataFileName([NotNull] MySqlParser.TsDataFileNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsDataFileName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsDataFileName([NotNull] MySqlParser.TsDataFileNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsDataFile"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsDataFile([NotNull] MySqlParser.TsDataFileContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsDataFile"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsDataFile([NotNull] MySqlParser.TsDataFileContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespaceOptions([NotNull] MySqlParser.TablespaceOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespaceOptions([NotNull] MySqlParser.TablespaceOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespaceOption([NotNull] MySqlParser.TablespaceOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespaceOption([NotNull] MySqlParser.TablespaceOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionInitialSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionInitialSize([NotNull] MySqlParser.TsOptionInitialSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionInitialSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionInitialSize([NotNull] MySqlParser.TsOptionInitialSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionUndoRedoBufferSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionUndoRedoBufferSize([NotNull] MySqlParser.TsOptionUndoRedoBufferSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionUndoRedoBufferSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionUndoRedoBufferSize([NotNull] MySqlParser.TsOptionUndoRedoBufferSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionAutoextendSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionAutoextendSize([NotNull] MySqlParser.TsOptionAutoextendSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionAutoextendSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionAutoextendSize([NotNull] MySqlParser.TsOptionAutoextendSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionMaxSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionMaxSize([NotNull] MySqlParser.TsOptionMaxSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionMaxSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionMaxSize([NotNull] MySqlParser.TsOptionMaxSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionExtentSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionExtentSize([NotNull] MySqlParser.TsOptionExtentSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionExtentSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionExtentSize([NotNull] MySqlParser.TsOptionExtentSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionNodegroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionNodegroup([NotNull] MySqlParser.TsOptionNodegroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionNodegroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionNodegroup([NotNull] MySqlParser.TsOptionNodegroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionEngine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionEngine([NotNull] MySqlParser.TsOptionEngineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionEngine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionEngine([NotNull] MySqlParser.TsOptionEngineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionWait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionWait([NotNull] MySqlParser.TsOptionWaitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionWait"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionWait([NotNull] MySqlParser.TsOptionWaitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionComment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionComment([NotNull] MySqlParser.TsOptionCommentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionComment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionComment([NotNull] MySqlParser.TsOptionCommentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionFileblockSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionFileblockSize([NotNull] MySqlParser.TsOptionFileblockSizeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionFileblockSize"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionFileblockSize([NotNull] MySqlParser.TsOptionFileblockSizeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tsOptionEncryption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTsOptionEncryption([NotNull] MySqlParser.TsOptionEncryptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tsOptionEncryption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTsOptionEncryption([NotNull] MySqlParser.TsOptionEncryptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateView([NotNull] MySqlParser.CreateViewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateView([NotNull] MySqlParser.CreateViewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewReplaceOrAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewReplaceOrAlgorithm([NotNull] MySqlParser.ViewReplaceOrAlgorithmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewReplaceOrAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewReplaceOrAlgorithm([NotNull] MySqlParser.ViewReplaceOrAlgorithmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewAlgorithm([NotNull] MySqlParser.ViewAlgorithmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewAlgorithm([NotNull] MySqlParser.ViewAlgorithmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewSuid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewSuid([NotNull] MySqlParser.ViewSuidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewSuid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewSuid([NotNull] MySqlParser.ViewSuidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTrigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTrigger([NotNull] MySqlParser.CreateTriggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTrigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTrigger([NotNull] MySqlParser.CreateTriggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerFollowsPrecedesClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerFollowsPrecedesClause([NotNull] MySqlParser.TriggerFollowsPrecedesClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerFollowsPrecedesClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerFollowsPrecedesClause([NotNull] MySqlParser.TriggerFollowsPrecedesClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateEvent([NotNull] MySqlParser.CreateEventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateEvent([NotNull] MySqlParser.CreateEventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateRole([NotNull] MySqlParser.CreateRoleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateRole([NotNull] MySqlParser.CreateRoleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createSpatialReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateSpatialReference([NotNull] MySqlParser.CreateSpatialReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createSpatialReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateSpatialReference([NotNull] MySqlParser.CreateSpatialReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.srsAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSrsAttribute([NotNull] MySqlParser.SrsAttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.srsAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSrsAttribute([NotNull] MySqlParser.SrsAttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropStatement([NotNull] MySqlParser.DropStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropStatement([NotNull] MySqlParser.DropStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropDatabase([NotNull] MySqlParser.DropDatabaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropDatabase"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropDatabase([NotNull] MySqlParser.DropDatabaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropEvent([NotNull] MySqlParser.DropEventContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropEvent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropEvent([NotNull] MySqlParser.DropEventContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropFunction([NotNull] MySqlParser.DropFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropFunction([NotNull] MySqlParser.DropFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropProcedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropProcedure([NotNull] MySqlParser.DropProcedureContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropProcedure"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropProcedure([NotNull] MySqlParser.DropProcedureContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropIndex([NotNull] MySqlParser.DropIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropIndex([NotNull] MySqlParser.DropIndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropLogfileGroup([NotNull] MySqlParser.DropLogfileGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropLogfileGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropLogfileGroup([NotNull] MySqlParser.DropLogfileGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropLogfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropLogfileGroupOption([NotNull] MySqlParser.DropLogfileGroupOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropLogfileGroupOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropLogfileGroupOption([NotNull] MySqlParser.DropLogfileGroupOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropServer([NotNull] MySqlParser.DropServerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropServer([NotNull] MySqlParser.DropServerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropTable([NotNull] MySqlParser.DropTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropTable([NotNull] MySqlParser.DropTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTableSpace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropTableSpace([NotNull] MySqlParser.DropTableSpaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTableSpace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropTableSpace([NotNull] MySqlParser.DropTableSpaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropTrigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropTrigger([NotNull] MySqlParser.DropTriggerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropTrigger"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropTrigger([NotNull] MySqlParser.DropTriggerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropView([NotNull] MySqlParser.DropViewContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropView"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropView([NotNull] MySqlParser.DropViewContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropRole([NotNull] MySqlParser.DropRoleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropRole([NotNull] MySqlParser.DropRoleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropSpatialReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropSpatialReference([NotNull] MySqlParser.DropSpatialReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropSpatialReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropSpatialReference([NotNull] MySqlParser.DropSpatialReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropUndoTablespace([NotNull] MySqlParser.DropUndoTablespaceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropUndoTablespace"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropUndoTablespace([NotNull] MySqlParser.DropUndoTablespaceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renameTableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRenameTableStatement([NotNull] MySqlParser.RenameTableStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renameTableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRenameTableStatement([NotNull] MySqlParser.RenameTableStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renamePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRenamePair([NotNull] MySqlParser.RenamePairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renamePair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRenamePair([NotNull] MySqlParser.RenamePairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.truncateTableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTruncateTableStatement([NotNull] MySqlParser.TruncateTableStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.truncateTableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTruncateTableStatement([NotNull] MySqlParser.TruncateTableStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterImportStatement([NotNull] MySqlParser.ImportStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.importStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitImportStatement([NotNull] MySqlParser.ImportStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.callStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCallStatement([NotNull] MySqlParser.CallStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.callStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCallStatement([NotNull] MySqlParser.CallStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteStatement([NotNull] MySqlParser.DeleteStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteStatement([NotNull] MySqlParser.DeleteStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDelete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDelete([NotNull] MySqlParser.PartitionDeleteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDelete"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDelete([NotNull] MySqlParser.PartitionDeleteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteStatementOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteStatementOption([NotNull] MySqlParser.DeleteStatementOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteStatementOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteStatementOption([NotNull] MySqlParser.DeleteStatementOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDoStatement([NotNull] MySqlParser.DoStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.doStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDoStatement([NotNull] MySqlParser.DoStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandlerStatement([NotNull] MySqlParser.HandlerStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandlerStatement([NotNull] MySqlParser.HandlerStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerReadOrScan"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandlerReadOrScan([NotNull] MySqlParser.HandlerReadOrScanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerReadOrScan"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandlerReadOrScan([NotNull] MySqlParser.HandlerReadOrScanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertStatement([NotNull] MySqlParser.InsertStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertStatement([NotNull] MySqlParser.InsertStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertLockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertLockOption([NotNull] MySqlParser.InsertLockOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertLockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertLockOption([NotNull] MySqlParser.InsertLockOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertFromConstructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertFromConstructor([NotNull] MySqlParser.InsertFromConstructorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertFromConstructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertFromConstructor([NotNull] MySqlParser.InsertFromConstructorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fields"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFields([NotNull] MySqlParser.FieldsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fields"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFields([NotNull] MySqlParser.FieldsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertValues"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertValues([NotNull] MySqlParser.InsertValuesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertValues"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertValues([NotNull] MySqlParser.InsertValuesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertQueryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertQueryExpression([NotNull] MySqlParser.InsertQueryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertQueryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertQueryExpression([NotNull] MySqlParser.InsertQueryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.valueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValueList([NotNull] MySqlParser.ValueListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.valueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValueList([NotNull] MySqlParser.ValueListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>values</c>
	/// labeled alternative in <see cref="MySqlParser.exprexprexprexprexprboolPriboolPriboolPriboolPripredicateOperationspredicateOperationspredicateOperationspredicateOperationssimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprpartitionTypeDefpartitionTypeDefpartitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValues([NotNull] MySqlParser.ValuesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>values</c>
	/// labeled alternative in <see cref="MySqlParser.exprexprexprexprexprboolPriboolPriboolPriboolPripredicateOperationspredicateOperationspredicateOperationspredicateOperationssimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprsimpleExprpartitionTypeDefpartitionTypeDefpartitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValues([NotNull] MySqlParser.ValuesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.valuesReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValuesReference([NotNull] MySqlParser.ValuesReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.valuesReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValuesReference([NotNull] MySqlParser.ValuesReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertUpdateList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertUpdateList([NotNull] MySqlParser.InsertUpdateListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertUpdateList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertUpdateList([NotNull] MySqlParser.InsertUpdateListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoadStatement([NotNull] MySqlParser.LoadStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoadStatement([NotNull] MySqlParser.LoadStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataOrXml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataOrXml([NotNull] MySqlParser.DataOrXmlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataOrXml"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataOrXml([NotNull] MySqlParser.DataOrXmlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xmlRowsIdentifiedBy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXmlRowsIdentifiedBy([NotNull] MySqlParser.XmlRowsIdentifiedByContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xmlRowsIdentifiedBy"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXmlRowsIdentifiedBy([NotNull] MySqlParser.XmlRowsIdentifiedByContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadDataFileTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoadDataFileTail([NotNull] MySqlParser.LoadDataFileTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadDataFileTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoadDataFileTail([NotNull] MySqlParser.LoadDataFileTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loadDataFileTargetList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoadDataFileTargetList([NotNull] MySqlParser.LoadDataFileTargetListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loadDataFileTargetList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoadDataFileTargetList([NotNull] MySqlParser.LoadDataFileTargetListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldOrVariableList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldOrVariableList([NotNull] MySqlParser.FieldOrVariableListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldOrVariableList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldOrVariableList([NotNull] MySqlParser.FieldOrVariableListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replaceStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplaceStatement([NotNull] MySqlParser.ReplaceStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replaceStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplaceStatement([NotNull] MySqlParser.ReplaceStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectStatement([NotNull] MySqlParser.SelectStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectStatement([NotNull] MySqlParser.SelectStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectStatementWithInto"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectStatementWithInto([NotNull] MySqlParser.SelectStatementWithIntoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectStatementWithInto"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectStatementWithInto([NotNull] MySqlParser.SelectStatementWithIntoContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryExpression([NotNull] MySqlParser.QueryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryExpression([NotNull] MySqlParser.QueryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryExpressionBody([NotNull] MySqlParser.QueryExpressionBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryExpressionBody([NotNull] MySqlParser.QueryExpressionBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryExpressionParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryExpressionParens([NotNull] MySqlParser.QueryExpressionParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryExpressionParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryExpressionParens([NotNull] MySqlParser.QueryExpressionParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.queryPrimary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQueryPrimary([NotNull] MySqlParser.QueryPrimaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.queryPrimary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQueryPrimary([NotNull] MySqlParser.QueryPrimaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.querySpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuerySpecification([NotNull] MySqlParser.QuerySpecificationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.querySpecification"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuerySpecification([NotNull] MySqlParser.QuerySpecificationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubquery([NotNull] MySqlParser.SubqueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subquery"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubquery([NotNull] MySqlParser.SubqueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.querySpecOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuerySpecOption([NotNull] MySqlParser.QuerySpecOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.querySpecOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuerySpecOption([NotNull] MySqlParser.QuerySpecOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitClause([NotNull] MySqlParser.LimitClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitClause([NotNull] MySqlParser.LimitClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleLimitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleLimitClause([NotNull] MySqlParser.SimpleLimitClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleLimitClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleLimitClause([NotNull] MySqlParser.SimpleLimitClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitOptions([NotNull] MySqlParser.LimitOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitOptions([NotNull] MySqlParser.LimitOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.limitOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLimitOption([NotNull] MySqlParser.LimitOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.limitOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLimitOption([NotNull] MySqlParser.LimitOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.intoClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntoClause([NotNull] MySqlParser.IntoClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.intoClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntoClause([NotNull] MySqlParser.IntoClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureAnalyseClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureAnalyseClause([NotNull] MySqlParser.ProcedureAnalyseClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureAnalyseClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureAnalyseClause([NotNull] MySqlParser.ProcedureAnalyseClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.havingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHavingClause([NotNull] MySqlParser.HavingClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.havingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHavingClause([NotNull] MySqlParser.HavingClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowClause([NotNull] MySqlParser.WindowClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowClause([NotNull] MySqlParser.WindowClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowDefinition([NotNull] MySqlParser.WindowDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowDefinition([NotNull] MySqlParser.WindowDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowSpec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowSpec([NotNull] MySqlParser.WindowSpecContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowSpec"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowSpec([NotNull] MySqlParser.WindowSpecContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowSpecDetails"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowSpecDetails([NotNull] MySqlParser.WindowSpecDetailsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowSpecDetails"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowSpecDetails([NotNull] MySqlParser.WindowSpecDetailsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameClause([NotNull] MySqlParser.WindowFrameClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameClause([NotNull] MySqlParser.WindowFrameClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameUnits"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameUnits([NotNull] MySqlParser.WindowFrameUnitsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameUnits"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameUnits([NotNull] MySqlParser.WindowFrameUnitsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameExtent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameExtent([NotNull] MySqlParser.WindowFrameExtentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameExtent"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameExtent([NotNull] MySqlParser.WindowFrameExtentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameStart([NotNull] MySqlParser.WindowFrameStartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameStart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameStart([NotNull] MySqlParser.WindowFrameStartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameBetween"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameBetween([NotNull] MySqlParser.WindowFrameBetweenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameBetween"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameBetween([NotNull] MySqlParser.WindowFrameBetweenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameBound([NotNull] MySqlParser.WindowFrameBoundContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameBound"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameBound([NotNull] MySqlParser.WindowFrameBoundContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFrameExclusion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFrameExclusion([NotNull] MySqlParser.WindowFrameExclusionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFrameExclusion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFrameExclusion([NotNull] MySqlParser.WindowFrameExclusionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithClause([NotNull] MySqlParser.WithClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithClause([NotNull] MySqlParser.WithClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.commonTableExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommonTableExpression([NotNull] MySqlParser.CommonTableExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.commonTableExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommonTableExpression([NotNull] MySqlParser.CommonTableExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupByClause([NotNull] MySqlParser.GroupByClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupByClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupByClause([NotNull] MySqlParser.GroupByClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.olapOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOlapOption([NotNull] MySqlParser.OlapOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.olapOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOlapOption([NotNull] MySqlParser.OlapOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderClause([NotNull] MySqlParser.OrderClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderClause([NotNull] MySqlParser.OrderClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirection([NotNull] MySqlParser.DirectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.direction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirection([NotNull] MySqlParser.DirectionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fromClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFromClause([NotNull] MySqlParser.FromClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fromClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFromClause([NotNull] MySqlParser.FromClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReferenceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableReferenceList([NotNull] MySqlParser.TableReferenceListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReferenceList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableReferenceList([NotNull] MySqlParser.TableReferenceListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableValueConstructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableValueConstructor([NotNull] MySqlParser.TableValueConstructorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableValueConstructor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableValueConstructor([NotNull] MySqlParser.TableValueConstructorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explicitTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplicitTable([NotNull] MySqlParser.ExplicitTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explicitTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplicitTable([NotNull] MySqlParser.ExplicitTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.rowValueExplicit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRowValueExplicit([NotNull] MySqlParser.RowValueExplicitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.rowValueExplicit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRowValueExplicit([NotNull] MySqlParser.RowValueExplicitContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectOption([NotNull] MySqlParser.SelectOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectOption([NotNull] MySqlParser.SelectOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockingClauseList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockingClauseList([NotNull] MySqlParser.LockingClauseListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockingClauseList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockingClauseList([NotNull] MySqlParser.LockingClauseListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockingClause([NotNull] MySqlParser.LockingClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockingClause([NotNull] MySqlParser.LockingClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockStrengh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockStrengh([NotNull] MySqlParser.LockStrenghContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockStrengh"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockStrengh([NotNull] MySqlParser.LockStrenghContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockedRowAction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockedRowAction([NotNull] MySqlParser.LockedRowActionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockedRowAction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockedRowAction([NotNull] MySqlParser.LockedRowActionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectItemList([NotNull] MySqlParser.SelectItemListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectItemList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectItemList([NotNull] MySqlParser.SelectItemListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectItem([NotNull] MySqlParser.SelectItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectItem([NotNull] MySqlParser.SelectItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.selectAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelectAlias([NotNull] MySqlParser.SelectAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.selectAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelectAlias([NotNull] MySqlParser.SelectAliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhereClause([NotNull] MySqlParser.WhereClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whereClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhereClause([NotNull] MySqlParser.WhereClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableReference([NotNull] MySqlParser.TableReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableReference([NotNull] MySqlParser.TableReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.escapedTableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEscapedTableReference([NotNull] MySqlParser.EscapedTableReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.escapedTableReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEscapedTableReference([NotNull] MySqlParser.EscapedTableReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.joinedTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJoinedTable([NotNull] MySqlParser.JoinedTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.joinedTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJoinedTable([NotNull] MySqlParser.JoinedTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.naturalJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNaturalJoinType([NotNull] MySqlParser.NaturalJoinTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.naturalJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNaturalJoinType([NotNull] MySqlParser.NaturalJoinTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.innerJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInnerJoinType([NotNull] MySqlParser.InnerJoinTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.innerJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInnerJoinType([NotNull] MySqlParser.InnerJoinTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.outerJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOuterJoinType([NotNull] MySqlParser.OuterJoinTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.outerJoinType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOuterJoinType([NotNull] MySqlParser.OuterJoinTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableFactor([NotNull] MySqlParser.TableFactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableFactor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableFactor([NotNull] MySqlParser.TableFactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.singleTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleTable([NotNull] MySqlParser.SingleTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.singleTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleTable([NotNull] MySqlParser.SingleTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.singleTableParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingleTableParens([NotNull] MySqlParser.SingleTableParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.singleTableParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingleTableParens([NotNull] MySqlParser.SingleTableParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.derivedTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDerivedTable([NotNull] MySqlParser.DerivedTableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.derivedTable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDerivedTable([NotNull] MySqlParser.DerivedTableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableReferenceListParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableReferenceListParens([NotNull] MySqlParser.TableReferenceListParensContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableReferenceListParens"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableReferenceListParens([NotNull] MySqlParser.TableReferenceListParensContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableFunction([NotNull] MySqlParser.TableFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableFunction([NotNull] MySqlParser.TableFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnsClause([NotNull] MySqlParser.ColumnsClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnsClause([NotNull] MySqlParser.ColumnsClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jtColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJtColumn([NotNull] MySqlParser.JtColumnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jtColumn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJtColumn([NotNull] MySqlParser.JtColumnContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onEmptyOrError"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnEmptyOrError([NotNull] MySqlParser.OnEmptyOrErrorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onEmptyOrError"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnEmptyOrError([NotNull] MySqlParser.OnEmptyOrErrorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onEmpty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnEmpty([NotNull] MySqlParser.OnEmptyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onEmpty"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnEmpty([NotNull] MySqlParser.OnEmptyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onError"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnError([NotNull] MySqlParser.OnErrorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onError"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnError([NotNull] MySqlParser.OnErrorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jtOnResponse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJtOnResponse([NotNull] MySqlParser.JtOnResponseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jtOnResponse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJtOnResponse([NotNull] MySqlParser.JtOnResponseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unionOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnionOption([NotNull] MySqlParser.UnionOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unionOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnionOption([NotNull] MySqlParser.UnionOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableAlias([NotNull] MySqlParser.TableAliasContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAlias"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableAlias([NotNull] MySqlParser.TableAliasContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexHintList([NotNull] MySqlParser.IndexHintListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexHintList([NotNull] MySqlParser.IndexHintListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexHint([NotNull] MySqlParser.IndexHintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexHint([NotNull] MySqlParser.IndexHintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexHintType([NotNull] MySqlParser.IndexHintTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexHintType([NotNull] MySqlParser.IndexHintTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyOrIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyOrIndex([NotNull] MySqlParser.KeyOrIndexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyOrIndex"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyOrIndex([NotNull] MySqlParser.KeyOrIndexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintKeyType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintKeyType([NotNull] MySqlParser.ConstraintKeyTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintKeyType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintKeyType([NotNull] MySqlParser.ConstraintKeyTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexHintClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexHintClause([NotNull] MySqlParser.IndexHintClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexHintClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexHintClause([NotNull] MySqlParser.IndexHintClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexList([NotNull] MySqlParser.IndexListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexList([NotNull] MySqlParser.IndexListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexListElement([NotNull] MySqlParser.IndexListElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexListElement([NotNull] MySqlParser.IndexListElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdateStatement([NotNull] MySqlParser.UpdateStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdateStatement([NotNull] MySqlParser.UpdateStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionOrLockingStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionOrLockingStatement([NotNull] MySqlParser.TransactionOrLockingStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionOrLockingStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionOrLockingStatement([NotNull] MySqlParser.TransactionOrLockingStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionStatement([NotNull] MySqlParser.TransactionStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionStatement([NotNull] MySqlParser.TransactionStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.beginWork"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBeginWork([NotNull] MySqlParser.BeginWorkContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.beginWork"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBeginWork([NotNull] MySqlParser.BeginWorkContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionCharacteristic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionCharacteristic([NotNull] MySqlParser.TransactionCharacteristicContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionCharacteristic"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionCharacteristic([NotNull] MySqlParser.TransactionCharacteristicContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.savepointStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSavepointStatement([NotNull] MySqlParser.SavepointStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.savepointStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSavepointStatement([NotNull] MySqlParser.SavepointStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockStatement([NotNull] MySqlParser.LockStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockStatement([NotNull] MySqlParser.LockStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockItem([NotNull] MySqlParser.LockItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockItem([NotNull] MySqlParser.LockItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLockOption([NotNull] MySqlParser.LockOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lockOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLockOption([NotNull] MySqlParser.LockOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xaStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXaStatement([NotNull] MySqlParser.XaStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xaStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXaStatement([NotNull] MySqlParser.XaStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xaConvert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXaConvert([NotNull] MySqlParser.XaConvertContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xaConvert"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXaConvert([NotNull] MySqlParser.XaConvertContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.xid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterXid([NotNull] MySqlParser.XidContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.xid"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitXid([NotNull] MySqlParser.XidContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replicationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplicationStatement([NotNull] MySqlParser.ReplicationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replicationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplicationStatement([NotNull] MySqlParser.ReplicationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resetOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResetOption([NotNull] MySqlParser.ResetOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resetOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResetOption([NotNull] MySqlParser.ResetOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterResetOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMasterResetOptions([NotNull] MySqlParser.MasterResetOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterResetOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMasterResetOptions([NotNull] MySqlParser.MasterResetOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replicationLoad"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplicationLoad([NotNull] MySqlParser.ReplicationLoadContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replicationLoad"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplicationLoad([NotNull] MySqlParser.ReplicationLoadContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeMaster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChangeMaster([NotNull] MySqlParser.ChangeMasterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeMaster"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChangeMaster([NotNull] MySqlParser.ChangeMasterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeMasterOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChangeMasterOptions([NotNull] MySqlParser.ChangeMasterOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeMasterOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChangeMasterOptions([NotNull] MySqlParser.ChangeMasterOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMasterOption([NotNull] MySqlParser.MasterOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMasterOption([NotNull] MySqlParser.MasterOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.privilegeCheckDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrivilegeCheckDef([NotNull] MySqlParser.PrivilegeCheckDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.privilegeCheckDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrivilegeCheckDef([NotNull] MySqlParser.PrivilegeCheckDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablePrimaryKeyCheckDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablePrimaryKeyCheckDef([NotNull] MySqlParser.TablePrimaryKeyCheckDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablePrimaryKeyCheckDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablePrimaryKeyCheckDef([NotNull] MySqlParser.TablePrimaryKeyCheckDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterTlsCiphersuitesDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMasterTlsCiphersuitesDef([NotNull] MySqlParser.MasterTlsCiphersuitesDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterTlsCiphersuitesDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMasterTlsCiphersuitesDef([NotNull] MySqlParser.MasterTlsCiphersuitesDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.masterFileDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMasterFileDef([NotNull] MySqlParser.MasterFileDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.masterFileDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMasterFileDef([NotNull] MySqlParser.MasterFileDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverIdList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterServerIdList([NotNull] MySqlParser.ServerIdListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverIdList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitServerIdList([NotNull] MySqlParser.ServerIdListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.changeReplication"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChangeReplication([NotNull] MySqlParser.ChangeReplicationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.changeReplication"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChangeReplication([NotNull] MySqlParser.ChangeReplicationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterDefinition([NotNull] MySqlParser.FilterDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterDefinition([NotNull] MySqlParser.FilterDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDbList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterDbList([NotNull] MySqlParser.FilterDbListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDbList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterDbList([NotNull] MySqlParser.FilterDbListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterTableList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterTableList([NotNull] MySqlParser.FilterTableListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterTableList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterTableList([NotNull] MySqlParser.FilterTableListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterStringList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterStringList([NotNull] MySqlParser.FilterStringListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterStringList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterStringList([NotNull] MySqlParser.FilterStringListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterWildDbTableString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterWildDbTableString([NotNull] MySqlParser.FilterWildDbTableStringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterWildDbTableString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterWildDbTableString([NotNull] MySqlParser.FilterWildDbTableStringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterDbPairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterDbPairList([NotNull] MySqlParser.FilterDbPairListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterDbPairList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterDbPairList([NotNull] MySqlParser.FilterDbPairListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slave"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSlave([NotNull] MySqlParser.SlaveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slave"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSlave([NotNull] MySqlParser.SlaveContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveUntilOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSlaveUntilOptions([NotNull] MySqlParser.SlaveUntilOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveUntilOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSlaveUntilOptions([NotNull] MySqlParser.SlaveUntilOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveConnectionOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSlaveConnectionOptions([NotNull] MySqlParser.SlaveConnectionOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveConnectionOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSlaveConnectionOptions([NotNull] MySqlParser.SlaveConnectionOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveThreadOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSlaveThreadOptions([NotNull] MySqlParser.SlaveThreadOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveThreadOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSlaveThreadOptions([NotNull] MySqlParser.SlaveThreadOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.slaveThreadOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSlaveThreadOption([NotNull] MySqlParser.SlaveThreadOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.slaveThreadOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSlaveThreadOption([NotNull] MySqlParser.SlaveThreadOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupReplication"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupReplication([NotNull] MySqlParser.GroupReplicationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupReplication"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupReplication([NotNull] MySqlParser.GroupReplicationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preparedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreparedStatement([NotNull] MySqlParser.PreparedStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preparedStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreparedStatement([NotNull] MySqlParser.PreparedStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.executeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecuteStatement([NotNull] MySqlParser.ExecuteStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.executeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecuteStatement([NotNull] MySqlParser.ExecuteStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.executeVarList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExecuteVarList([NotNull] MySqlParser.ExecuteVarListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.executeVarList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExecuteVarList([NotNull] MySqlParser.ExecuteVarListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cloneStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCloneStatement([NotNull] MySqlParser.CloneStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cloneStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCloneStatement([NotNull] MySqlParser.CloneStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataDirSSL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataDirSSL([NotNull] MySqlParser.DataDirSSLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataDirSSL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataDirSSL([NotNull] MySqlParser.DataDirSSLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ssl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSsl([NotNull] MySqlParser.SslContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ssl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSsl([NotNull] MySqlParser.SslContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.accountManagementStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccountManagementStatement([NotNull] MySqlParser.AccountManagementStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.accountManagementStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccountManagementStatement([NotNull] MySqlParser.AccountManagementStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterUser([NotNull] MySqlParser.AlterUserContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterUser([NotNull] MySqlParser.AlterUserContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterUserTail([NotNull] MySqlParser.AlterUserTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterUserTail([NotNull] MySqlParser.AlterUserTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUserFunction([NotNull] MySqlParser.UserFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUserFunction([NotNull] MySqlParser.UserFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUser([NotNull] MySqlParser.CreateUserContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUser([NotNull] MySqlParser.CreateUserContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUserTail([NotNull] MySqlParser.CreateUserTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUserTail([NotNull] MySqlParser.CreateUserTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultRoleClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultRoleClause([NotNull] MySqlParser.DefaultRoleClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultRoleClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultRoleClause([NotNull] MySqlParser.DefaultRoleClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRequireClause([NotNull] MySqlParser.RequireClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRequireClause([NotNull] MySqlParser.RequireClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.connectOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConnectOptions([NotNull] MySqlParser.ConnectOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.connectOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConnectOptions([NotNull] MySqlParser.ConnectOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.accountLockPasswordExpireOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAccountLockPasswordExpireOptions([NotNull] MySqlParser.AccountLockPasswordExpireOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.accountLockPasswordExpireOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAccountLockPasswordExpireOptions([NotNull] MySqlParser.AccountLockPasswordExpireOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropUser([NotNull] MySqlParser.DropUserContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropUser([NotNull] MySqlParser.DropUserContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrant([NotNull] MySqlParser.GrantContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grant"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrant([NotNull] MySqlParser.GrantContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantTargetList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantTargetList([NotNull] MySqlParser.GrantTargetListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantTargetList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantTargetList([NotNull] MySqlParser.GrantTargetListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantOptions([NotNull] MySqlParser.GrantOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantOptions([NotNull] MySqlParser.GrantOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exceptRoleList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExceptRoleList([NotNull] MySqlParser.ExceptRoleListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exceptRoleList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExceptRoleList([NotNull] MySqlParser.ExceptRoleListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.withRoles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWithRoles([NotNull] MySqlParser.WithRolesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.withRoles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWithRoles([NotNull] MySqlParser.WithRolesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantAs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantAs([NotNull] MySqlParser.GrantAsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantAs"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantAs([NotNull] MySqlParser.GrantAsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.versionedRequireClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVersionedRequireClause([NotNull] MySqlParser.VersionedRequireClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.versionedRequireClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVersionedRequireClause([NotNull] MySqlParser.VersionedRequireClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.renameUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRenameUser([NotNull] MySqlParser.RenameUserContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.renameUser"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRenameUser([NotNull] MySqlParser.RenameUserContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.revoke"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRevoke([NotNull] MySqlParser.RevokeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.revoke"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRevoke([NotNull] MySqlParser.RevokeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onTypeTo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnTypeTo([NotNull] MySqlParser.OnTypeToContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onTypeTo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnTypeTo([NotNull] MySqlParser.OnTypeToContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.aclType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAclType([NotNull] MySqlParser.AclTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.aclType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAclType([NotNull] MySqlParser.AclTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrPrivilegesList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleOrPrivilegesList([NotNull] MySqlParser.RoleOrPrivilegesListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrPrivilegesList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleOrPrivilegesList([NotNull] MySqlParser.RoleOrPrivilegesListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrPrivilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleOrPrivilege([NotNull] MySqlParser.RoleOrPrivilegeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrPrivilege"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleOrPrivilege([NotNull] MySqlParser.RoleOrPrivilegeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantIdentifier([NotNull] MySqlParser.GrantIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantIdentifier([NotNull] MySqlParser.GrantIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRequireList([NotNull] MySqlParser.RequireListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRequireList([NotNull] MySqlParser.RequireListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.requireListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRequireListElement([NotNull] MySqlParser.RequireListElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.requireListElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRequireListElement([NotNull] MySqlParser.RequireListElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.grantOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGrantOption([NotNull] MySqlParser.GrantOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.grantOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGrantOption([NotNull] MySqlParser.GrantOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetRole([NotNull] MySqlParser.SetRoleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setRole"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetRole([NotNull] MySqlParser.SetRoleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleList([NotNull] MySqlParser.RoleListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleList([NotNull] MySqlParser.RoleListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRole([NotNull] MySqlParser.RoleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.role"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRole([NotNull] MySqlParser.RoleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAdministrationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableAdministrationStatement([NotNull] MySqlParser.TableAdministrationStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAdministrationStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableAdministrationStatement([NotNull] MySqlParser.TableAdministrationStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.histogram"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHistogram([NotNull] MySqlParser.HistogramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.histogram"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHistogram([NotNull] MySqlParser.HistogramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckOption([NotNull] MySqlParser.CheckOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckOption([NotNull] MySqlParser.CheckOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.repairType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRepairType([NotNull] MySqlParser.RepairTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.repairType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRepairType([NotNull] MySqlParser.RepairTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.installUninstallStatment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInstallUninstallStatment([NotNull] MySqlParser.InstallUninstallStatmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.installUninstallStatment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInstallUninstallStatment([NotNull] MySqlParser.InstallUninstallStatmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetStatement([NotNull] MySqlParser.SetStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetStatement([NotNull] MySqlParser.SetStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.startOptionValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartOptionValueList([NotNull] MySqlParser.StartOptionValueListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.startOptionValueList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartOptionValueList([NotNull] MySqlParser.StartOptionValueListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionCharacteristics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionCharacteristics([NotNull] MySqlParser.TransactionCharacteristicsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionCharacteristics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionCharacteristics([NotNull] MySqlParser.TransactionCharacteristicsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.transactionAccessMode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTransactionAccessMode([NotNull] MySqlParser.TransactionAccessModeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.transactionAccessMode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTransactionAccessMode([NotNull] MySqlParser.TransactionAccessModeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.isolationLevel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIsolationLevel([NotNull] MySqlParser.IsolationLevelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.isolationLevel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIsolationLevel([NotNull] MySqlParser.IsolationLevelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueListContinued"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionValueListContinued([NotNull] MySqlParser.OptionValueListContinuedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueListContinued"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionValueListContinued([NotNull] MySqlParser.OptionValueListContinuedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueNoOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionValueNoOptionType([NotNull] MySqlParser.OptionValueNoOptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueNoOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionValueNoOptionType([NotNull] MySqlParser.OptionValueNoOptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionValue([NotNull] MySqlParser.OptionValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionValue([NotNull] MySqlParser.OptionValueContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setSystemVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetSystemVariable([NotNull] MySqlParser.SetSystemVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setSystemVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetSystemVariable([NotNull] MySqlParser.SetSystemVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.startOptionValueListFollowingOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartOptionValueListFollowingOptionType([NotNull] MySqlParser.StartOptionValueListFollowingOptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.startOptionValueListFollowingOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartOptionValueListFollowingOptionType([NotNull] MySqlParser.StartOptionValueListFollowingOptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionValueFollowingOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionValueFollowingOptionType([NotNull] MySqlParser.OptionValueFollowingOptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionValueFollowingOptionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionValueFollowingOptionType([NotNull] MySqlParser.OptionValueFollowingOptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setExprOrDefault"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetExprOrDefault([NotNull] MySqlParser.SetExprOrDefaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setExprOrDefault"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetExprOrDefault([NotNull] MySqlParser.SetExprOrDefaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.showStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowStatement([NotNull] MySqlParser.ShowStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.showStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowStatement([NotNull] MySqlParser.ShowStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.showCommandType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShowCommandType([NotNull] MySqlParser.ShowCommandTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.showCommandType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShowCommandType([NotNull] MySqlParser.ShowCommandTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nonBlocking"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNonBlocking([NotNull] MySqlParser.NonBlockingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nonBlocking"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNonBlocking([NotNull] MySqlParser.NonBlockingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fromOrIn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFromOrIn([NotNull] MySqlParser.FromOrInContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fromOrIn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFromOrIn([NotNull] MySqlParser.FromOrInContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.inDb"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInDb([NotNull] MySqlParser.InDbContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.inDb"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInDb([NotNull] MySqlParser.InDbContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.profileType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProfileType([NotNull] MySqlParser.ProfileTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.profileType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProfileType([NotNull] MySqlParser.ProfileTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.otherAdministrativeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOtherAdministrativeStatement([NotNull] MySqlParser.OtherAdministrativeStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.otherAdministrativeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOtherAdministrativeStatement([NotNull] MySqlParser.OtherAdministrativeStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyCacheListOrParts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyCacheListOrParts([NotNull] MySqlParser.KeyCacheListOrPartsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyCacheListOrParts"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyCacheListOrParts([NotNull] MySqlParser.KeyCacheListOrPartsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyCacheList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyCacheList([NotNull] MySqlParser.KeyCacheListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyCacheList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyCacheList([NotNull] MySqlParser.KeyCacheListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.assignToKeycache"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignToKeycache([NotNull] MySqlParser.AssignToKeycacheContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.assignToKeycache"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignToKeycache([NotNull] MySqlParser.AssignToKeycacheContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.assignToKeycachePartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignToKeycachePartition([NotNull] MySqlParser.AssignToKeycachePartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.assignToKeycachePartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignToKeycachePartition([NotNull] MySqlParser.AssignToKeycachePartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cacheKeyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCacheKeyList([NotNull] MySqlParser.CacheKeyListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cacheKeyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCacheKeyList([NotNull] MySqlParser.CacheKeyListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyUsageElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyUsageElement([NotNull] MySqlParser.KeyUsageElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyUsageElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyUsageElement([NotNull] MySqlParser.KeyUsageElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyUsageList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyUsageList([NotNull] MySqlParser.KeyUsageListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyUsageList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyUsageList([NotNull] MySqlParser.KeyUsageListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlushOption([NotNull] MySqlParser.FlushOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlushOption([NotNull] MySqlParser.FlushOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogType([NotNull] MySqlParser.LogTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogType([NotNull] MySqlParser.LogTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushTables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlushTables([NotNull] MySqlParser.FlushTablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushTables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlushTables([NotNull] MySqlParser.FlushTablesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.flushTablesOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFlushTablesOptions([NotNull] MySqlParser.FlushTablesOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.flushTablesOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFlushTablesOptions([NotNull] MySqlParser.FlushTablesOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreloadTail([NotNull] MySqlParser.PreloadTailContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadTail"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreloadTail([NotNull] MySqlParser.PreloadTailContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreloadList([NotNull] MySqlParser.PreloadListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreloadList([NotNull] MySqlParser.PreloadListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.preloadKeys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreloadKeys([NotNull] MySqlParser.PreloadKeysContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.preloadKeys"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreloadKeys([NotNull] MySqlParser.PreloadKeysContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.adminPartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAdminPartition([NotNull] MySqlParser.AdminPartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.adminPartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAdminPartition([NotNull] MySqlParser.AdminPartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupManagement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceGroupManagement([NotNull] MySqlParser.ResourceGroupManagementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupManagement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceGroupManagement([NotNull] MySqlParser.ResourceGroupManagementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateResourceGroup([NotNull] MySqlParser.CreateResourceGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateResourceGroup([NotNull] MySqlParser.CreateResourceGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupVcpuList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceGroupVcpuList([NotNull] MySqlParser.ResourceGroupVcpuListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupVcpuList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceGroupVcpuList([NotNull] MySqlParser.ResourceGroupVcpuListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.vcpuNumOrRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVcpuNumOrRange([NotNull] MySqlParser.VcpuNumOrRangeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.vcpuNumOrRange"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVcpuNumOrRange([NotNull] MySqlParser.VcpuNumOrRangeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupPriority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceGroupPriority([NotNull] MySqlParser.ResourceGroupPriorityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupPriority"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceGroupPriority([NotNull] MySqlParser.ResourceGroupPriorityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupEnableDisable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceGroupEnableDisable([NotNull] MySqlParser.ResourceGroupEnableDisableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupEnableDisable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceGroupEnableDisable([NotNull] MySqlParser.ResourceGroupEnableDisableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterResourceGroup([NotNull] MySqlParser.AlterResourceGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterResourceGroup([NotNull] MySqlParser.AlterResourceGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetResourceGroup([NotNull] MySqlParser.SetResourceGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetResourceGroup([NotNull] MySqlParser.SetResourceGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.threadIdList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThreadIdList([NotNull] MySqlParser.ThreadIdListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.threadIdList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThreadIdList([NotNull] MySqlParser.ThreadIdListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dropResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDropResourceGroup([NotNull] MySqlParser.DropResourceGroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dropResourceGroup"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDropResourceGroup([NotNull] MySqlParser.DropResourceGroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.utilityStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUtilityStatement([NotNull] MySqlParser.UtilityStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.utilityStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUtilityStatement([NotNull] MySqlParser.UtilityStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.describeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDescribeStatement([NotNull] MySqlParser.DescribeStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.describeStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDescribeStatement([NotNull] MySqlParser.DescribeStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explainStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainStatement([NotNull] MySqlParser.ExplainStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explainStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainStatement([NotNull] MySqlParser.ExplainStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.explainableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExplainableStatement([NotNull] MySqlParser.ExplainableStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.explainableStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExplainableStatement([NotNull] MySqlParser.ExplainableStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.helpCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHelpCommand([NotNull] MySqlParser.HelpCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.helpCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHelpCommand([NotNull] MySqlParser.HelpCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.useCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUseCommand([NotNull] MySqlParser.UseCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.useCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUseCommand([NotNull] MySqlParser.UseCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.restartServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRestartServer([NotNull] MySqlParser.RestartServerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.restartServer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRestartServer([NotNull] MySqlParser.RestartServerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprOr([NotNull] MySqlParser.ExprOrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprOr</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprOr([NotNull] MySqlParser.ExprOrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprNot([NotNull] MySqlParser.ExprNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprNot</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprNot([NotNull] MySqlParser.ExprNotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprIs</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprIs([NotNull] MySqlParser.ExprIsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprIs</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprIs([NotNull] MySqlParser.ExprIsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprAnd([NotNull] MySqlParser.ExprAndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprAnd</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprAnd([NotNull] MySqlParser.ExprAndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>exprXor</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprXor([NotNull] MySqlParser.ExprXorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>exprXor</c>
	/// labeled alternative in <see cref="MySqlParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprXor([NotNull] MySqlParser.ExprXorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprPredicate</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExprPredicate([NotNull] MySqlParser.PrimaryExprPredicateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprPredicate</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExprPredicate([NotNull] MySqlParser.PrimaryExprPredicateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprCompare</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExprCompare([NotNull] MySqlParser.PrimaryExprCompareContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprCompare</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExprCompare([NotNull] MySqlParser.PrimaryExprCompareContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprAllAny</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExprAllAny([NotNull] MySqlParser.PrimaryExprAllAnyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprAllAny</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExprAllAny([NotNull] MySqlParser.PrimaryExprAllAnyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExprIsNull</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrimaryExprIsNull([NotNull] MySqlParser.PrimaryExprIsNullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExprIsNull</c>
	/// labeled alternative in <see cref="MySqlParser.boolPri"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrimaryExprIsNull([NotNull] MySqlParser.PrimaryExprIsNullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompOp([NotNull] MySqlParser.CompOpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compOp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompOp([NotNull] MySqlParser.CompOpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicate([NotNull] MySqlParser.PredicateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.predicate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicate([NotNull] MySqlParser.PredicateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprIn</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicateExprIn([NotNull] MySqlParser.PredicateExprInContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprIn</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicateExprIn([NotNull] MySqlParser.PredicateExprInContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprBetween</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicateExprBetween([NotNull] MySqlParser.PredicateExprBetweenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprBetween</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicateExprBetween([NotNull] MySqlParser.PredicateExprBetweenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprLike</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicateExprLike([NotNull] MySqlParser.PredicateExprLikeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprLike</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicateExprLike([NotNull] MySqlParser.PredicateExprLikeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>predicateExprRegex</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPredicateExprRegex([NotNull] MySqlParser.PredicateExprRegexContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>predicateExprRegex</c>
	/// labeled alternative in <see cref="MySqlParser.predicateOperations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPredicateExprRegex([NotNull] MySqlParser.PredicateExprRegexContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.bitExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBitExpr([NotNull] MySqlParser.BitExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.bitExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBitExpr([NotNull] MySqlParser.BitExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConvert</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprConvert([NotNull] MySqlParser.SimpleExprConvertContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConvert</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprConvert([NotNull] MySqlParser.SimpleExprConvertContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprVariable</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprVariable([NotNull] MySqlParser.SimpleExprVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprVariable</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprVariable([NotNull] MySqlParser.SimpleExprVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCast</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprCast([NotNull] MySqlParser.SimpleExprCastContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCast</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprCast([NotNull] MySqlParser.SimpleExprCastContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprUnary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprUnary([NotNull] MySqlParser.SimpleExprUnaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprUnary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprUnary([NotNull] MySqlParser.SimpleExprUnaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprOdbc</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprOdbc([NotNull] MySqlParser.SimpleExprOdbcContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprOdbc</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprOdbc([NotNull] MySqlParser.SimpleExprOdbcContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprRuntimeFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprRuntimeFunction([NotNull] MySqlParser.SimpleExprRuntimeFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprRuntimeFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprRuntimeFunction([NotNull] MySqlParser.SimpleExprRuntimeFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprFunction([NotNull] MySqlParser.SimpleExprFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprFunction([NotNull] MySqlParser.SimpleExprFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCollate</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprCollate([NotNull] MySqlParser.SimpleExprCollateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCollate</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprCollate([NotNull] MySqlParser.SimpleExprCollateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprMatch</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprMatch([NotNull] MySqlParser.SimpleExprMatchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprMatch</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprMatch([NotNull] MySqlParser.SimpleExprMatchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprWindowingFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprWindowingFunction([NotNull] MySqlParser.SimpleExprWindowingFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprWindowingFunction</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprWindowingFunction([NotNull] MySqlParser.SimpleExprWindowingFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprBinary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprBinary([NotNull] MySqlParser.SimpleExprBinaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprBinary</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprBinary([NotNull] MySqlParser.SimpleExprBinaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprColumnRef</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprColumnRef([NotNull] MySqlParser.SimpleExprColumnRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprColumnRef</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprColumnRef([NotNull] MySqlParser.SimpleExprColumnRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprParamMarker</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprParamMarker([NotNull] MySqlParser.SimpleExprParamMarkerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprParamMarker</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprParamMarker([NotNull] MySqlParser.SimpleExprParamMarkerContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprSum</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprSum([NotNull] MySqlParser.SimpleExprSumContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprSum</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprSum([NotNull] MySqlParser.SimpleExprSumContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConvertUsing</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprConvertUsing([NotNull] MySqlParser.SimpleExprConvertUsingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConvertUsing</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprConvertUsing([NotNull] MySqlParser.SimpleExprConvertUsingContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprSubQuery</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprSubQuery([NotNull] MySqlParser.SimpleExprSubQueryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprSubQuery</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprSubQuery([NotNull] MySqlParser.SimpleExprSubQueryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprGroupingOperation</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprGroupingOperation([NotNull] MySqlParser.SimpleExprGroupingOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprGroupingOperation</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprGroupingOperation([NotNull] MySqlParser.SimpleExprGroupingOperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprNot</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprNot([NotNull] MySqlParser.SimpleExprNotContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprNot</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprNot([NotNull] MySqlParser.SimpleExprNotContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprValues</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprValues([NotNull] MySqlParser.SimpleExprValuesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprValues</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprValues([NotNull] MySqlParser.SimpleExprValuesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprDefault</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprDefault([NotNull] MySqlParser.SimpleExprDefaultContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprDefault</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprDefault([NotNull] MySqlParser.SimpleExprDefaultContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprList</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprList([NotNull] MySqlParser.SimpleExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprList</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprList([NotNull] MySqlParser.SimpleExprListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprInterval</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprInterval([NotNull] MySqlParser.SimpleExprIntervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprInterval</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprInterval([NotNull] MySqlParser.SimpleExprIntervalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprCase</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprCase([NotNull] MySqlParser.SimpleExprCaseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprCase</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprCase([NotNull] MySqlParser.SimpleExprCaseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprConcat</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprConcat([NotNull] MySqlParser.SimpleExprConcatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprConcat</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprConcat([NotNull] MySqlParser.SimpleExprConcatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>simpleExprLiteral</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprLiteral([NotNull] MySqlParser.SimpleExprLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>simpleExprLiteral</c>
	/// labeled alternative in <see cref="MySqlParser.simpleExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprLiteral([NotNull] MySqlParser.SimpleExprLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.arrayCast"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArrayCast([NotNull] MySqlParser.ArrayCastContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.arrayCast"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArrayCast([NotNull] MySqlParser.ArrayCastContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jsonOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJsonOperator([NotNull] MySqlParser.JsonOperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jsonOperator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJsonOperator([NotNull] MySqlParser.JsonOperatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sumExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSumExpr([NotNull] MySqlParser.SumExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sumExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSumExpr([NotNull] MySqlParser.SumExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupingOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupingOperation([NotNull] MySqlParser.GroupingOperationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupingOperation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupingOperation([NotNull] MySqlParser.GroupingOperationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowFunctionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowFunctionCall([NotNull] MySqlParser.WindowFunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowFunctionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowFunctionCall([NotNull] MySqlParser.WindowFunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowingClause([NotNull] MySqlParser.WindowingClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowingClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowingClause([NotNull] MySqlParser.WindowingClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.leadLagInfo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLeadLagInfo([NotNull] MySqlParser.LeadLagInfoContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.leadLagInfo"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLeadLagInfo([NotNull] MySqlParser.LeadLagInfoContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nullTreatment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNullTreatment([NotNull] MySqlParser.NullTreatmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nullTreatment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNullTreatment([NotNull] MySqlParser.NullTreatmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.jsonFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterJsonFunction([NotNull] MySqlParser.JsonFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.jsonFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitJsonFunction([NotNull] MySqlParser.JsonFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.inSumExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInSumExpr([NotNull] MySqlParser.InSumExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.inSumExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInSumExpr([NotNull] MySqlParser.InSumExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identListArg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentListArg([NotNull] MySqlParser.IdentListArgContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identListArg"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentListArg([NotNull] MySqlParser.IdentListArgContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentList([NotNull] MySqlParser.IdentListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentList([NotNull] MySqlParser.IdentListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fulltextOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFulltextOptions([NotNull] MySqlParser.FulltextOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fulltextOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFulltextOptions([NotNull] MySqlParser.FulltextOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.runtimeFunctionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRuntimeFunctionCall([NotNull] MySqlParser.RuntimeFunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.runtimeFunctionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRuntimeFunctionCall([NotNull] MySqlParser.RuntimeFunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.geometryFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGeometryFunction([NotNull] MySqlParser.GeometryFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.geometryFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGeometryFunction([NotNull] MySqlParser.GeometryFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.timeFunctionParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTimeFunctionParameters([NotNull] MySqlParser.TimeFunctionParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.timeFunctionParameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTimeFunctionParameters([NotNull] MySqlParser.TimeFunctionParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fractionalPrecision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFractionalPrecision([NotNull] MySqlParser.FractionalPrecisionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fractionalPrecision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFractionalPrecision([NotNull] MySqlParser.FractionalPrecisionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.weightStringLevels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWeightStringLevels([NotNull] MySqlParser.WeightStringLevelsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.weightStringLevels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWeightStringLevels([NotNull] MySqlParser.WeightStringLevelsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.weightStringLevelListItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWeightStringLevelListItem([NotNull] MySqlParser.WeightStringLevelListItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.weightStringLevelListItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWeightStringLevelListItem([NotNull] MySqlParser.WeightStringLevelListItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dateTimeTtype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDateTimeTtype([NotNull] MySqlParser.DateTimeTtypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dateTimeTtype"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDateTimeTtype([NotNull] MySqlParser.DateTimeTtypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.trimFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTrimFunction([NotNull] MySqlParser.TrimFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.trimFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTrimFunction([NotNull] MySqlParser.TrimFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.substringFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubstringFunction([NotNull] MySqlParser.SubstringFunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.substringFunction"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubstringFunction([NotNull] MySqlParser.SubstringFunctionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] MySqlParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] MySqlParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUdfExprList([NotNull] MySqlParser.UdfExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfExprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUdfExprList([NotNull] MySqlParser.UdfExprListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUdfExpr([NotNull] MySqlParser.UdfExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUdfExpr([NotNull] MySqlParser.UdfExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariable([NotNull] MySqlParser.VariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.variable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariable([NotNull] MySqlParser.VariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUserVariable([NotNull] MySqlParser.UserVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUserVariable([NotNull] MySqlParser.UserVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.systemVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSystemVariable([NotNull] MySqlParser.SystemVariableContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.systemVariable"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSystemVariable([NotNull] MySqlParser.SystemVariableContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.internalVariableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInternalVariableName([NotNull] MySqlParser.InternalVariableNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.internalVariableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInternalVariableName([NotNull] MySqlParser.InternalVariableNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whenExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhenExpression([NotNull] MySqlParser.WhenExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whenExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhenExpression([NotNull] MySqlParser.WhenExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.thenExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThenExpression([NotNull] MySqlParser.ThenExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.thenExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThenExpression([NotNull] MySqlParser.ThenExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.elseExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseExpression([NotNull] MySqlParser.ElseExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.elseExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseExpression([NotNull] MySqlParser.ElseExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.castType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCastType([NotNull] MySqlParser.CastTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.castType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCastType([NotNull] MySqlParser.CastTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprList([NotNull] MySqlParser.ExprListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprList([NotNull] MySqlParser.ExprListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharset([NotNull] MySqlParser.CharsetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharset([NotNull] MySqlParser.CharsetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.notRule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotRule([NotNull] MySqlParser.NotRuleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.notRule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotRule([NotNull] MySqlParser.NotRuleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.not2Rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNot2Rule([NotNull] MySqlParser.Not2RuleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.not2Rule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNot2Rule([NotNull] MySqlParser.Not2RuleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInterval([NotNull] MySqlParser.IntervalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.interval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInterval([NotNull] MySqlParser.IntervalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.intervalTimeStamp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIntervalTimeStamp([NotNull] MySqlParser.IntervalTimeStampContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.intervalTimeStamp"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIntervalTimeStamp([NotNull] MySqlParser.IntervalTimeStampContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprListWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprListWithParentheses([NotNull] MySqlParser.ExprListWithParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprListWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprListWithParentheses([NotNull] MySqlParser.ExprListWithParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.exprWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExprWithParentheses([NotNull] MySqlParser.ExprWithParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.exprWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExprWithParentheses([NotNull] MySqlParser.ExprWithParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleExprWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleExprWithParentheses([NotNull] MySqlParser.SimpleExprWithParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleExprWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleExprWithParentheses([NotNull] MySqlParser.SimpleExprWithParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderList([NotNull] MySqlParser.OrderListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderList([NotNull] MySqlParser.OrderListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.orderExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrderExpression([NotNull] MySqlParser.OrderExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.orderExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrderExpression([NotNull] MySqlParser.OrderExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupList([NotNull] MySqlParser.GroupListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupList([NotNull] MySqlParser.GroupListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.groupingExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroupingExpression([NotNull] MySqlParser.GroupingExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.groupingExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroupingExpression([NotNull] MySqlParser.GroupingExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.channel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterChannel([NotNull] MySqlParser.ChannelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.channel"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitChannel([NotNull] MySqlParser.ChannelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundStatement([NotNull] MySqlParser.CompoundStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compoundStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundStatement([NotNull] MySqlParser.CompoundStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] MySqlParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] MySqlParser.ReturnStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfStatement([NotNull] MySqlParser.IfStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfStatement([NotNull] MySqlParser.IfStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfBody([NotNull] MySqlParser.IfBodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifBody"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfBody([NotNull] MySqlParser.IfBodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.thenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterThenStatement([NotNull] MySqlParser.ThenStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.thenStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitThenStatement([NotNull] MySqlParser.ThenStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.compoundStatementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompoundStatementList([NotNull] MySqlParser.CompoundStatementListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.compoundStatementList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompoundStatementList([NotNull] MySqlParser.CompoundStatementListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.caseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCaseStatement([NotNull] MySqlParser.CaseStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.caseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCaseStatement([NotNull] MySqlParser.CaseStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.elseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterElseStatement([NotNull] MySqlParser.ElseStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.elseStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitElseStatement([NotNull] MySqlParser.ElseStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labeledBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledBlock([NotNull] MySqlParser.LabeledBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labeledBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledBlock([NotNull] MySqlParser.LabeledBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unlabeledBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnlabeledBlock([NotNull] MySqlParser.UnlabeledBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unlabeledBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnlabeledBlock([NotNull] MySqlParser.UnlabeledBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel([NotNull] MySqlParser.LabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel([NotNull] MySqlParser.LabelContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.beginEndBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBeginEndBlock([NotNull] MySqlParser.BeginEndBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.beginEndBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBeginEndBlock([NotNull] MySqlParser.BeginEndBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labeledControl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabeledControl([NotNull] MySqlParser.LabeledControlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labeledControl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabeledControl([NotNull] MySqlParser.LabeledControlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unlabeledControl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnlabeledControl([NotNull] MySqlParser.UnlabeledControlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unlabeledControl"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnlabeledControl([NotNull] MySqlParser.UnlabeledControlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.loopBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLoopBlock([NotNull] MySqlParser.LoopBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.loopBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLoopBlock([NotNull] MySqlParser.LoopBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.whileDoBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWhileDoBlock([NotNull] MySqlParser.WhileDoBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.whileDoBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWhileDoBlock([NotNull] MySqlParser.WhileDoBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.repeatUntilBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRepeatUntilBlock([NotNull] MySqlParser.RepeatUntilBlockContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.repeatUntilBlock"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRepeatUntilBlock([NotNull] MySqlParser.RepeatUntilBlockContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpDeclarations([NotNull] MySqlParser.SpDeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpDeclarations([NotNull] MySqlParser.SpDeclarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpDeclaration([NotNull] MySqlParser.SpDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpDeclaration([NotNull] MySqlParser.SpDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableDeclaration([NotNull] MySqlParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.variableDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableDeclaration([NotNull] MySqlParser.VariableDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.conditionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionDeclaration([NotNull] MySqlParser.ConditionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.conditionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionDeclaration([NotNull] MySqlParser.ConditionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpCondition([NotNull] MySqlParser.SpConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpCondition([NotNull] MySqlParser.SpConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sqlstate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSqlstate([NotNull] MySqlParser.SqlstateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sqlstate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSqlstate([NotNull] MySqlParser.SqlstateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandlerDeclaration([NotNull] MySqlParser.HandlerDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandlerDeclaration([NotNull] MySqlParser.HandlerDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.handlerCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterHandlerCondition([NotNull] MySqlParser.HandlerConditionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.handlerCondition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitHandlerCondition([NotNull] MySqlParser.HandlerConditionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursorDeclaration([NotNull] MySqlParser.CursorDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursorDeclaration([NotNull] MySqlParser.CursorDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.iterateStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIterateStatement([NotNull] MySqlParser.IterateStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.iterateStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIterateStatement([NotNull] MySqlParser.IterateStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.leaveStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLeaveStatement([NotNull] MySqlParser.LeaveStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.leaveStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLeaveStatement([NotNull] MySqlParser.LeaveStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.getDiagnostics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGetDiagnostics([NotNull] MySqlParser.GetDiagnosticsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.getDiagnostics"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGetDiagnostics([NotNull] MySqlParser.GetDiagnosticsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalAllowedExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignalAllowedExpr([NotNull] MySqlParser.SignalAllowedExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalAllowedExpr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignalAllowedExpr([NotNull] MySqlParser.SignalAllowedExprContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.statementInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatementInformationItem([NotNull] MySqlParser.StatementInformationItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.statementInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatementInformationItem([NotNull] MySqlParser.StatementInformationItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.conditionInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConditionInformationItem([NotNull] MySqlParser.ConditionInformationItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.conditionInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConditionInformationItem([NotNull] MySqlParser.ConditionInformationItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalInformationItemName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignalInformationItemName([NotNull] MySqlParser.SignalInformationItemNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalInformationItemName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignalInformationItemName([NotNull] MySqlParser.SignalInformationItemNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignalStatement([NotNull] MySqlParser.SignalStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignalStatement([NotNull] MySqlParser.SignalStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resignalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResignalStatement([NotNull] MySqlParser.ResignalStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resignalStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResignalStatement([NotNull] MySqlParser.ResignalStatementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signalInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignalInformationItem([NotNull] MySqlParser.SignalInformationItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signalInformationItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignalInformationItem([NotNull] MySqlParser.SignalInformationItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorOpen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursorOpen([NotNull] MySqlParser.CursorOpenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorOpen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursorOpen([NotNull] MySqlParser.CursorOpenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorClose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursorClose([NotNull] MySqlParser.CursorCloseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorClose"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursorClose([NotNull] MySqlParser.CursorCloseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.cursorFetch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCursorFetch([NotNull] MySqlParser.CursorFetchContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.cursorFetch"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCursorFetch([NotNull] MySqlParser.CursorFetchContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schedule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchedule([NotNull] MySqlParser.ScheduleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schedule"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchedule([NotNull] MySqlParser.ScheduleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnDefinition([NotNull] MySqlParser.ColumnDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnDefinition([NotNull] MySqlParser.ColumnDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkOrReferences"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckOrReferences([NotNull] MySqlParser.CheckOrReferencesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkOrReferences"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckOrReferences([NotNull] MySqlParser.CheckOrReferencesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.checkConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCheckConstraint([NotNull] MySqlParser.CheckConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.checkConstraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCheckConstraint([NotNull] MySqlParser.CheckConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintEnforcement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintEnforcement([NotNull] MySqlParser.ConstraintEnforcementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintEnforcement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintEnforcement([NotNull] MySqlParser.ConstraintEnforcementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableConstraintDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableConstraintDef([NotNull] MySqlParser.TableConstraintDefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableConstraintDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableConstraintDef([NotNull] MySqlParser.TableConstraintDefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.constraintName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraintName([NotNull] MySqlParser.ConstraintNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.constraintName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraintName([NotNull] MySqlParser.ConstraintNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldDefinition([NotNull] MySqlParser.FieldDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldDefinition([NotNull] MySqlParser.FieldDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnAttribute([NotNull] MySqlParser.ColumnAttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnAttribute([NotNull] MySqlParser.ColumnAttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnFormat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnFormat([NotNull] MySqlParser.ColumnFormatContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnFormat"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnFormat([NotNull] MySqlParser.ColumnFormatContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.storageMedia"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStorageMedia([NotNull] MySqlParser.StorageMediaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.storageMedia"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStorageMedia([NotNull] MySqlParser.StorageMediaContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.gcolAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGcolAttribute([NotNull] MySqlParser.GcolAttributeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.gcolAttribute"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGcolAttribute([NotNull] MySqlParser.GcolAttributeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.references"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReferences([NotNull] MySqlParser.ReferencesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.references"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReferences([NotNull] MySqlParser.ReferencesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.deleteOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeleteOption([NotNull] MySqlParser.DeleteOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.deleteOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeleteOption([NotNull] MySqlParser.DeleteOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyList([NotNull] MySqlParser.KeyListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyList([NotNull] MySqlParser.KeyListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyPart([NotNull] MySqlParser.KeyPartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyPart"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyPart([NotNull] MySqlParser.KeyPartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyListWithExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyListWithExpression([NotNull] MySqlParser.KeyListWithExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyListWithExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyListWithExpression([NotNull] MySqlParser.KeyListWithExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyPartOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyPartOrExpression([NotNull] MySqlParser.KeyPartOrExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyPartOrExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyPartOrExpression([NotNull] MySqlParser.KeyPartOrExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.keyListVariants"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterKeyListVariants([NotNull] MySqlParser.KeyListVariantsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.keyListVariants"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitKeyListVariants([NotNull] MySqlParser.KeyListVariantsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexType([NotNull] MySqlParser.IndexTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexType([NotNull] MySqlParser.IndexTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexOption([NotNull] MySqlParser.IndexOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexOption([NotNull] MySqlParser.IndexOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.commonIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommonIndexOption([NotNull] MySqlParser.CommonIndexOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.commonIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommonIndexOption([NotNull] MySqlParser.CommonIndexOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.visibility"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVisibility([NotNull] MySqlParser.VisibilityContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.visibility"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVisibility([NotNull] MySqlParser.VisibilityContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexTypeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexTypeClause([NotNull] MySqlParser.IndexTypeClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexTypeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexTypeClause([NotNull] MySqlParser.IndexTypeClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fulltextIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFulltextIndexOption([NotNull] MySqlParser.FulltextIndexOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fulltextIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFulltextIndexOption([NotNull] MySqlParser.FulltextIndexOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.spatialIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpatialIndexOption([NotNull] MySqlParser.SpatialIndexOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.spatialIndexOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpatialIndexOption([NotNull] MySqlParser.SpatialIndexOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataTypeDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataTypeDefinition([NotNull] MySqlParser.DataTypeDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataTypeDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataTypeDefinition([NotNull] MySqlParser.DataTypeDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dataType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDataType([NotNull] MySqlParser.DataTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dataType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDataType([NotNull] MySqlParser.DataTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nchar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNchar([NotNull] MySqlParser.NcharContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nchar"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNchar([NotNull] MySqlParser.NcharContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.realType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRealType([NotNull] MySqlParser.RealTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.realType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRealType([NotNull] MySqlParser.RealTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldLength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldLength([NotNull] MySqlParser.FieldLengthContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldLength"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldLength([NotNull] MySqlParser.FieldLengthContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldOptions([NotNull] MySqlParser.FieldOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldOptions([NotNull] MySqlParser.FieldOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetWithOptBinary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharsetWithOptBinary([NotNull] MySqlParser.CharsetWithOptBinaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetWithOptBinary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharsetWithOptBinary([NotNull] MySqlParser.CharsetWithOptBinaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ascii"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAscii([NotNull] MySqlParser.AsciiContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ascii"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAscii([NotNull] MySqlParser.AsciiContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.unicode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnicode([NotNull] MySqlParser.UnicodeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.unicode"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnicode([NotNull] MySqlParser.UnicodeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.wsNumCodepoints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWsNumCodepoints([NotNull] MySqlParser.WsNumCodepointsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.wsNumCodepoints"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWsNumCodepoints([NotNull] MySqlParser.WsNumCodepointsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.typeDatetimePrecision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeDatetimePrecision([NotNull] MySqlParser.TypeDatetimePrecisionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.typeDatetimePrecision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeDatetimePrecision([NotNull] MySqlParser.TypeDatetimePrecisionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharsetName([NotNull] MySqlParser.CharsetNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharsetName([NotNull] MySqlParser.CharsetNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.collationName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollationName([NotNull] MySqlParser.CollationNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.collationName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollationName([NotNull] MySqlParser.CollationNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTableOptions([NotNull] MySqlParser.CreateTableOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTableOptions([NotNull] MySqlParser.CreateTableOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOptionsSpaceSeparated"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTableOptionsSpaceSeparated([NotNull] MySqlParser.CreateTableOptionsSpaceSeparatedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOptionsSpaceSeparated"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTableOptionsSpaceSeparated([NotNull] MySqlParser.CreateTableOptionsSpaceSeparatedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createTableOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateTableOption([NotNull] MySqlParser.CreateTableOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createTableOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateTableOption([NotNull] MySqlParser.CreateTableOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ternaryOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTernaryOption([NotNull] MySqlParser.TernaryOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ternaryOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTernaryOption([NotNull] MySqlParser.TernaryOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultCollation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultCollation([NotNull] MySqlParser.DefaultCollationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultCollation"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultCollation([NotNull] MySqlParser.DefaultCollationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultEncryption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultEncryption([NotNull] MySqlParser.DefaultEncryptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultEncryption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultEncryption([NotNull] MySqlParser.DefaultEncryptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.defaultCharset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefaultCharset([NotNull] MySqlParser.DefaultCharsetContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.defaultCharset"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefaultCharset([NotNull] MySqlParser.DefaultCharsetContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionClause([NotNull] MySqlParser.PartitionClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionClause([NotNull] MySqlParser.PartitionClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefKey</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDefKey([NotNull] MySqlParser.PartitionDefKeyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefKey</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDefKey([NotNull] MySqlParser.PartitionDefKeyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefHash</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDefHash([NotNull] MySqlParser.PartitionDefHashContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefHash</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDefHash([NotNull] MySqlParser.PartitionDefHashContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>partitionDefRangeList</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDefRangeList([NotNull] MySqlParser.PartitionDefRangeListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>partitionDefRangeList</c>
	/// labeled alternative in <see cref="MySqlParser.partitionTypeDef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDefRangeList([NotNull] MySqlParser.PartitionDefRangeListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subPartitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubPartitions([NotNull] MySqlParser.SubPartitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subPartitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubPartitions([NotNull] MySqlParser.SubPartitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionKeyAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionKeyAlgorithm([NotNull] MySqlParser.PartitionKeyAlgorithmContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionKeyAlgorithm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionKeyAlgorithm([NotNull] MySqlParser.PartitionKeyAlgorithmContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDefinitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDefinitions([NotNull] MySqlParser.PartitionDefinitionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDefinitions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDefinitions([NotNull] MySqlParser.PartitionDefinitionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionDefinition([NotNull] MySqlParser.PartitionDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionDefinition([NotNull] MySqlParser.PartitionDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValuesIn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionValuesIn([NotNull] MySqlParser.PartitionValuesInContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValuesIn"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionValuesIn([NotNull] MySqlParser.PartitionValuesInContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionOption([NotNull] MySqlParser.PartitionOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionOption([NotNull] MySqlParser.PartitionOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.subpartitionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSubpartitionDefinition([NotNull] MySqlParser.SubpartitionDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.subpartitionDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSubpartitionDefinition([NotNull] MySqlParser.SubpartitionDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValueItemListParen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionValueItemListParen([NotNull] MySqlParser.PartitionValueItemListParenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValueItemListParen"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionValueItemListParen([NotNull] MySqlParser.PartitionValueItemListParenContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.partitionValueItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPartitionValueItem([NotNull] MySqlParser.PartitionValueItemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.partitionValueItem"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPartitionValueItem([NotNull] MySqlParser.PartitionValueItemContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.definerClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDefinerClause([NotNull] MySqlParser.DefinerClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.definerClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDefinerClause([NotNull] MySqlParser.DefinerClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfExists([NotNull] MySqlParser.IfExistsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfExists([NotNull] MySqlParser.IfExistsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ifNotExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIfNotExists([NotNull] MySqlParser.IfNotExistsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ifNotExists"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIfNotExists([NotNull] MySqlParser.IfNotExistsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureParameter([NotNull] MySqlParser.ProcedureParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureParameter([NotNull] MySqlParser.ProcedureParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionParameter([NotNull] MySqlParser.FunctionParameterContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionParameter"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionParameter([NotNull] MySqlParser.FunctionParameterContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCollate([NotNull] MySqlParser.CollateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.collate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCollate([NotNull] MySqlParser.CollateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.typeWithOptCollate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeWithOptCollate([NotNull] MySqlParser.TypeWithOptCollateContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.typeWithOptCollate"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeWithOptCollate([NotNull] MySqlParser.TypeWithOptCollateContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaIdentifierPair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaIdentifierPair([NotNull] MySqlParser.SchemaIdentifierPairContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaIdentifierPair"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaIdentifierPair([NotNull] MySqlParser.SchemaIdentifierPairContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewRefList([NotNull] MySqlParser.ViewRefListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewRefList([NotNull] MySqlParser.ViewRefListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdateList([NotNull] MySqlParser.UpdateListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdateList([NotNull] MySqlParser.UpdateListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.updateElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUpdateElement([NotNull] MySqlParser.UpdateElementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.updateElement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUpdateElement([NotNull] MySqlParser.UpdateElementContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.charsetClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCharsetClause([NotNull] MySqlParser.CharsetClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.charsetClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCharsetClause([NotNull] MySqlParser.CharsetClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldsClause([NotNull] MySqlParser.FieldsClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldsClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldsClause([NotNull] MySqlParser.FieldsClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldTerm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldTerm([NotNull] MySqlParser.FieldTermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldTerm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldTerm([NotNull] MySqlParser.FieldTermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.linesClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLinesClause([NotNull] MySqlParser.LinesClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.linesClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLinesClause([NotNull] MySqlParser.LinesClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lineTerm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineTerm([NotNull] MySqlParser.LineTermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lineTerm"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineTerm([NotNull] MySqlParser.LineTermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUserList([NotNull] MySqlParser.UserListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUserList([NotNull] MySqlParser.UserListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUserList([NotNull] MySqlParser.CreateUserListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUserList([NotNull] MySqlParser.CreateUserListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterUserList([NotNull] MySqlParser.AlterUserListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterUserList([NotNull] MySqlParser.AlterUserListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.createUserEntry"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCreateUserEntry([NotNull] MySqlParser.CreateUserEntryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.createUserEntry"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCreateUserEntry([NotNull] MySqlParser.CreateUserEntryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.alterUserEntry"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAlterUserEntry([NotNull] MySqlParser.AlterUserEntryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.alterUserEntry"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAlterUserEntry([NotNull] MySqlParser.AlterUserEntryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.retainCurrentPassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRetainCurrentPassword([NotNull] MySqlParser.RetainCurrentPasswordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.retainCurrentPassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRetainCurrentPassword([NotNull] MySqlParser.RetainCurrentPasswordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.discardOldPassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDiscardOldPassword([NotNull] MySqlParser.DiscardOldPasswordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.discardOldPassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDiscardOldPassword([NotNull] MySqlParser.DiscardOldPasswordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.replacePassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReplacePassword([NotNull] MySqlParser.ReplacePasswordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.replacePassword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReplacePassword([NotNull] MySqlParser.ReplacePasswordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.userIdentifierOrText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUserIdentifierOrText([NotNull] MySqlParser.UserIdentifierOrTextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.userIdentifierOrText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUserIdentifierOrText([NotNull] MySqlParser.UserIdentifierOrTextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUser([NotNull] MySqlParser.UserContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.user"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUser([NotNull] MySqlParser.UserContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.likeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLikeClause([NotNull] MySqlParser.LikeClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.likeClause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLikeClause([NotNull] MySqlParser.LikeClauseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.likeOrWhere"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLikeOrWhere([NotNull] MySqlParser.LikeOrWhereContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.likeOrWhere"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLikeOrWhere([NotNull] MySqlParser.LikeOrWhereContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.onlineOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOnlineOption([NotNull] MySqlParser.OnlineOptionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.onlineOption"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOnlineOption([NotNull] MySqlParser.OnlineOptionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.noWriteToBinLog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNoWriteToBinLog([NotNull] MySqlParser.NoWriteToBinLogContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.noWriteToBinLog"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNoWriteToBinLog([NotNull] MySqlParser.NoWriteToBinLogContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.usePartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUsePartition([NotNull] MySqlParser.UsePartitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.usePartition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUsePartition([NotNull] MySqlParser.UsePartitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.fieldIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFieldIdentifier([NotNull] MySqlParser.FieldIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.fieldIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFieldIdentifier([NotNull] MySqlParser.FieldIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnName([NotNull] MySqlParser.ColumnNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnName([NotNull] MySqlParser.ColumnNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnInternalRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnInternalRef([NotNull] MySqlParser.ColumnInternalRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnInternalRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnInternalRef([NotNull] MySqlParser.ColumnInternalRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnInternalRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnInternalRefList([NotNull] MySqlParser.ColumnInternalRefListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnInternalRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnInternalRefList([NotNull] MySqlParser.ColumnInternalRefListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.columnRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterColumnRef([NotNull] MySqlParser.ColumnRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.columnRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitColumnRef([NotNull] MySqlParser.ColumnRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.insertIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInsertIdentifier([NotNull] MySqlParser.InsertIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.insertIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInsertIdentifier([NotNull] MySqlParser.InsertIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexName([NotNull] MySqlParser.IndexNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexName([NotNull] MySqlParser.IndexNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.indexRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIndexRef([NotNull] MySqlParser.IndexRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.indexRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIndexRef([NotNull] MySqlParser.IndexRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableWild"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableWild([NotNull] MySqlParser.TableWildContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableWild"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableWild([NotNull] MySqlParser.TableWildContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaName([NotNull] MySqlParser.SchemaNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaName([NotNull] MySqlParser.SchemaNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.schemaRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSchemaRef([NotNull] MySqlParser.SchemaRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.schemaRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSchemaRef([NotNull] MySqlParser.SchemaRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureName([NotNull] MySqlParser.ProcedureNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureName([NotNull] MySqlParser.ProcedureNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.procedureRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProcedureRef([NotNull] MySqlParser.ProcedureRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.procedureRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProcedureRef([NotNull] MySqlParser.ProcedureRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionName([NotNull] MySqlParser.FunctionNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionName([NotNull] MySqlParser.FunctionNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.functionRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionRef([NotNull] MySqlParser.FunctionRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.functionRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionRef([NotNull] MySqlParser.FunctionRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerName([NotNull] MySqlParser.TriggerNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerName([NotNull] MySqlParser.TriggerNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.triggerRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTriggerRef([NotNull] MySqlParser.TriggerRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.triggerRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTriggerRef([NotNull] MySqlParser.TriggerRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewName([NotNull] MySqlParser.ViewNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewName([NotNull] MySqlParser.ViewNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.viewRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterViewRef([NotNull] MySqlParser.ViewRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.viewRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitViewRef([NotNull] MySqlParser.ViewRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespaceName([NotNull] MySqlParser.TablespaceNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespaceName([NotNull] MySqlParser.TablespaceNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tablespaceRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTablespaceRef([NotNull] MySqlParser.TablespaceRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tablespaceRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTablespaceRef([NotNull] MySqlParser.TablespaceRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfileGroupName([NotNull] MySqlParser.LogfileGroupNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfileGroupName([NotNull] MySqlParser.LogfileGroupNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.logfileGroupRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLogfileGroupRef([NotNull] MySqlParser.LogfileGroupRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.logfileGroupRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLogfileGroupRef([NotNull] MySqlParser.LogfileGroupRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.eventName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEventName([NotNull] MySqlParser.EventNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.eventName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEventName([NotNull] MySqlParser.EventNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.eventRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEventRef([NotNull] MySqlParser.EventRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.eventRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEventRef([NotNull] MySqlParser.EventRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.udfName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUdfName([NotNull] MySqlParser.UdfNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.udfName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUdfName([NotNull] MySqlParser.UdfNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterServerName([NotNull] MySqlParser.ServerNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitServerName([NotNull] MySqlParser.ServerNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.serverRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterServerRef([NotNull] MySqlParser.ServerRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.serverRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitServerRef([NotNull] MySqlParser.ServerRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.engineRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEngineRef([NotNull] MySqlParser.EngineRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.engineRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEngineRef([NotNull] MySqlParser.EngineRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableName([NotNull] MySqlParser.TableNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableName([NotNull] MySqlParser.TableNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.filterTableRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFilterTableRef([NotNull] MySqlParser.FilterTableRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.filterTableRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFilterTableRef([NotNull] MySqlParser.FilterTableRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRefWithWildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableRefWithWildcard([NotNull] MySqlParser.TableRefWithWildcardContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRefWithWildcard"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableRefWithWildcard([NotNull] MySqlParser.TableRefWithWildcardContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableRef([NotNull] MySqlParser.TableRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableRef([NotNull] MySqlParser.TableRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableRefList([NotNull] MySqlParser.TableRefListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableRefList([NotNull] MySqlParser.TableRefListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.tableAliasRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTableAliasRefList([NotNull] MySqlParser.TableAliasRefListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.tableAliasRefList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTableAliasRefList([NotNull] MySqlParser.TableAliasRefListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.parameterName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterName([NotNull] MySqlParser.ParameterNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.parameterName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterName([NotNull] MySqlParser.ParameterNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabelIdentifier([NotNull] MySqlParser.LabelIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabelIdentifier([NotNull] MySqlParser.LabelIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabelRef([NotNull] MySqlParser.LabelRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabelRef([NotNull] MySqlParser.LabelRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleIdentifier([NotNull] MySqlParser.RoleIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleIdentifier([NotNull] MySqlParser.RoleIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleRef([NotNull] MySqlParser.RoleRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleRef([NotNull] MySqlParser.RoleRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.pluginRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPluginRef([NotNull] MySqlParser.PluginRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.pluginRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPluginRef([NotNull] MySqlParser.PluginRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.componentRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComponentRef([NotNull] MySqlParser.ComponentRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.componentRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComponentRef([NotNull] MySqlParser.ComponentRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.resourceGroupRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterResourceGroupRef([NotNull] MySqlParser.ResourceGroupRefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.resourceGroupRef"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitResourceGroupRef([NotNull] MySqlParser.ResourceGroupRefContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.windowName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterWindowName([NotNull] MySqlParser.WindowNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.windowName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitWindowName([NotNull] MySqlParser.WindowNameContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.pureIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPureIdentifier([NotNull] MySqlParser.PureIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.pureIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPureIdentifier([NotNull] MySqlParser.PureIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] MySqlParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] MySqlParser.IdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierList([NotNull] MySqlParser.IdentifierListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierList([NotNull] MySqlParser.IdentifierListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierListWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierListWithParentheses([NotNull] MySqlParser.IdentifierListWithParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierListWithParentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierListWithParentheses([NotNull] MySqlParser.IdentifierListWithParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.qualifiedIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQualifiedIdentifier([NotNull] MySqlParser.QualifiedIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.qualifiedIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQualifiedIdentifier([NotNull] MySqlParser.QualifiedIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.simpleIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSimpleIdentifier([NotNull] MySqlParser.SimpleIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.simpleIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSimpleIdentifier([NotNull] MySqlParser.SimpleIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.dotIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDotIdentifier([NotNull] MySqlParser.DotIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.dotIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDotIdentifier([NotNull] MySqlParser.DotIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ulong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUlong_number([NotNull] MySqlParser.Ulong_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ulong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUlong_number([NotNull] MySqlParser.Ulong_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.real_ulong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReal_ulong_number([NotNull] MySqlParser.Real_ulong_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.real_ulong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReal_ulong_number([NotNull] MySqlParser.Real_ulong_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.ulonglong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUlonglong_number([NotNull] MySqlParser.Ulonglong_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.ulonglong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUlonglong_number([NotNull] MySqlParser.Ulonglong_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.real_ulonglong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReal_ulonglong_number([NotNull] MySqlParser.Real_ulonglong_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.real_ulonglong_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReal_ulonglong_number([NotNull] MySqlParser.Real_ulonglong_numberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLiteral([NotNull] MySqlParser.LiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.literal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLiteral([NotNull] MySqlParser.LiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.signedLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSignedLiteral([NotNull] MySqlParser.SignedLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.signedLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSignedLiteral([NotNull] MySqlParser.SignedLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.stringList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringList([NotNull] MySqlParser.StringListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.stringList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringList([NotNull] MySqlParser.StringListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextStringLiteral([NotNull] MySqlParser.TextStringLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextStringLiteral([NotNull] MySqlParser.TextStringLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextString([NotNull] MySqlParser.TextStringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textString"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextString([NotNull] MySqlParser.TextStringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringHash"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextStringHash([NotNull] MySqlParser.TextStringHashContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringHash"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextStringHash([NotNull] MySqlParser.TextStringHashContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextLiteral([NotNull] MySqlParser.TextLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextLiteral([NotNull] MySqlParser.TextLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringNoLinebreak"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextStringNoLinebreak([NotNull] MySqlParser.TextStringNoLinebreakContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringNoLinebreak"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextStringNoLinebreak([NotNull] MySqlParser.TextStringNoLinebreakContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textStringLiteralList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextStringLiteralList([NotNull] MySqlParser.TextStringLiteralListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textStringLiteralList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextStringLiteralList([NotNull] MySqlParser.TextStringLiteralListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.numLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumLiteral([NotNull] MySqlParser.NumLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.numLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumLiteral([NotNull] MySqlParser.NumLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.boolLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolLiteral([NotNull] MySqlParser.BoolLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.boolLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolLiteral([NotNull] MySqlParser.BoolLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.nullLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNullLiteral([NotNull] MySqlParser.NullLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.nullLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNullLiteral([NotNull] MySqlParser.NullLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.temporalLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTemporalLiteral([NotNull] MySqlParser.TemporalLiteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.temporalLiteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTemporalLiteral([NotNull] MySqlParser.TemporalLiteralContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.floatOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFloatOptions([NotNull] MySqlParser.FloatOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.floatOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFloatOptions([NotNull] MySqlParser.FloatOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.standardFloatOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStandardFloatOptions([NotNull] MySqlParser.StandardFloatOptionsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.standardFloatOptions"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStandardFloatOptions([NotNull] MySqlParser.StandardFloatOptionsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.precision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrecision([NotNull] MySqlParser.PrecisionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.precision"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrecision([NotNull] MySqlParser.PrecisionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.textOrIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTextOrIdentifier([NotNull] MySqlParser.TextOrIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.textOrIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTextOrIdentifier([NotNull] MySqlParser.TextOrIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lValueIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLValueIdentifier([NotNull] MySqlParser.LValueIdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lValueIdentifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLValueIdentifier([NotNull] MySqlParser.LValueIdentifierContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleIdentifierOrText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleIdentifierOrText([NotNull] MySqlParser.RoleIdentifierOrTextContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleIdentifierOrText"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleIdentifierOrText([NotNull] MySqlParser.RoleIdentifierOrTextContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.sizeNumber"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSizeNumber([NotNull] MySqlParser.SizeNumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.sizeNumber"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSizeNumber([NotNull] MySqlParser.SizeNumberContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.parentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParentheses([NotNull] MySqlParser.ParenthesesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.parentheses"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParentheses([NotNull] MySqlParser.ParenthesesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEqual([NotNull] MySqlParser.EqualContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.equal"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEqual([NotNull] MySqlParser.EqualContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.optionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOptionType([NotNull] MySqlParser.OptionTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.optionType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOptionType([NotNull] MySqlParser.OptionTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.varIdentType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVarIdentType([NotNull] MySqlParser.VarIdentTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.varIdentType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVarIdentType([NotNull] MySqlParser.VarIdentTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.setVarIdentType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSetVarIdentType([NotNull] MySqlParser.SetVarIdentTypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.setVarIdentType"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSetVarIdentType([NotNull] MySqlParser.SetVarIdentTypeContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeyword([NotNull] MySqlParser.IdentifierKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeyword([NotNull] MySqlParser.IdentifierKeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous1RolesAndLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeywordsAmbiguous1RolesAndLabels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous1RolesAndLabelsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous1RolesAndLabels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeywordsAmbiguous1RolesAndLabels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous1RolesAndLabelsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous2Labels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeywordsAmbiguous2Labels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous2LabelsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous2Labels"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeywordsAmbiguous2Labels([NotNull] MySqlParser.IdentifierKeywordsAmbiguous2LabelsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.labelKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabelKeyword([NotNull] MySqlParser.LabelKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.labelKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabelKeyword([NotNull] MySqlParser.LabelKeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous3Roles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeywordsAmbiguous3Roles([NotNull] MySqlParser.IdentifierKeywordsAmbiguous3RolesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous3Roles"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeywordsAmbiguous3Roles([NotNull] MySqlParser.IdentifierKeywordsAmbiguous3RolesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsUnambiguous"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeywordsUnambiguous([NotNull] MySqlParser.IdentifierKeywordsUnambiguousContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsUnambiguous"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeywordsUnambiguous([NotNull] MySqlParser.IdentifierKeywordsUnambiguousContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleKeyword([NotNull] MySqlParser.RoleKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleKeyword([NotNull] MySqlParser.RoleKeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.lValueKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLValueKeyword([NotNull] MySqlParser.LValueKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.lValueKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLValueKeyword([NotNull] MySqlParser.LValueKeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous4SystemVariables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierKeywordsAmbiguous4SystemVariables([NotNull] MySqlParser.IdentifierKeywordsAmbiguous4SystemVariablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.identifierKeywordsAmbiguous4SystemVariables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierKeywordsAmbiguous4SystemVariables([NotNull] MySqlParser.IdentifierKeywordsAmbiguous4SystemVariablesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrIdentifierKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleOrIdentifierKeyword([NotNull] MySqlParser.RoleOrIdentifierKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrIdentifierKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleOrIdentifierKeyword([NotNull] MySqlParser.RoleOrIdentifierKeywordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="MySqlParser.roleOrLabelKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRoleOrLabelKeyword([NotNull] MySqlParser.RoleOrLabelKeywordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="MySqlParser.roleOrLabelKeyword"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRoleOrLabelKeyword([NotNull] MySqlParser.RoleOrLabelKeywordContext context) { }

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
