using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;
using System.Linq;
using System.Text;

public class MySqlRecognizerCommon : IMySqlRecognizerCommon
{
    public int serverVersion { get; set; }
    public MySqlMode sqlMode { get; set; }

    public MySqlRecognizerCommon(int serverVersion = MySqlServerVersion.MAX_SERVER_VERSION, MySqlMode sqlMode = MySqlMode.NoMode)
    {
        this.sqlMode = sqlMode;
        this.serverVersion = serverVersion;
    }

    public bool isSqlModeActive(MySqlMode mode) => isSqlModeActive((int)mode);

    public bool isSqlModeActive(int mode)
    {
        return ((int)sqlMode & mode) != 0;
    }

    public void sqlModeFromString(string modes)
    {
        sqlMode = MySqlMode.NoMode;
        modes = modes.ToUpperInvariant();
        foreach (var mode in modes.Split(',').Select(m => m.Trim()))
        {
            if (mode == "ANSI" || mode == "DB2" || mode == "MAXDB" || mode == "MSSQL" || mode == "ORACLE" || mode == "POSTGRESQL")
                sqlMode = sqlMode | MySqlMode.AnsiQuotes | MySqlMode.PipesAsConcat | MySqlMode.IgnoreSpace;
            else if (mode == "ANSI_QUOTES")
                sqlMode = sqlMode | MySqlMode.AnsiQuotes;
            else if (mode == "PIPES_AS_CONCAT")
                sqlMode = sqlMode | MySqlMode.PipesAsConcat;
            else if (mode == "NO_BACKSLASH_ESCAPES")
                sqlMode = sqlMode | MySqlMode.NoBackslashEscapes;
            else if (mode == "IGNORE_SPACE")
                sqlMode = sqlMode | MySqlMode.IgnoreSpace;
            else if (mode == "HIGH_NOT_PRECEDENCE" || mode == "mySql323" || mode == "mySql40")
                sqlMode = sqlMode | MySqlMode.HighNotPrecedence;
        }
    }

    public static string dumpTree(RuleContext context, IVocabulary vocabulary, string indentation = "")
    {
        var stream = new StringBuilder();
        for (int index = 0; index < context.ChildCount; index++)
        {
            IParseTree child = context.GetChild(index);
            if (child is RuleContext ruleContext && ruleContext != null)
            {
                if (child is MySqlParser.TextLiteralContext textLiteralContext && textLiteralContext != null)
                {
                    var interval = ruleContext.SourceInterval;
                    stream.Append($"{indentation}(index range: {interval.a}..{interval.b}, string literal) {MySqlBaseRecognizer.getText(ruleContext, true)} {Environment.NewLine} ");
                }
                else
                {
                    stream.Append(dumpTree(ruleContext, vocabulary, indentation.Length < 100 ? $"{indentation} " : indentation));
                }
            }
            else
            {
                stream.Append(indentation);
                var node = child as ITerminalNode;
                if (child is IErrorNode errorNode)
                {
                    stream.Append("Syntax Error: ");
                    var token = node.Symbol;
                    var type = token.Type;
                    var tokenName = type == TokenConstants.EOF ? "<EOF>" : vocabulary.GetSymbolicName(token.Type);
                    stream.Append($"(line: {token.Line}, offset: {token.Column}, index: {token.TokenIndex}, {tokenName} [{token.Type}]) {token.Text}{Environment.NewLine}");
                }
            }
        }
        return stream.ToString();
    }

    public string dumpTree(RuleContext context, IVocabulary vocabulary)
    {
        return dumpTree(context, vocabulary, "");
    }

    public string sourceTextForContext(ParserRuleContext ctx, bool keepQuotes)
    {
        return sourceTextForRange(ctx.Start, ctx.Stop, keepQuotes);
    }

    public string sourceTextForRange(Antlr4.Runtime.Tree.IParseTree start, Antlr4.Runtime.Tree.IParseTree stop, bool keepQuotes)
    {
        IToken startToken = start is ITerminalNode ? (start as ITerminalNode).Symbol : (start as ParserRuleContext).Start;
        IToken stopToken = stop is ITerminalNode ? (stop as ITerminalNode).Symbol : (stop as ParserRuleContext).Stop;
        return sourceTextForRange(startToken, stopToken, keepQuotes);
    }

    public string sourceTextForRange(IToken start, IToken stop, bool keepQuotes)
    {
        ICharStream cs = start.TokenSource.InputStream;
        int stopIndex = stop != null ? stop.StopIndex : int.MaxValue;
        string result = cs.GetText(new Antlr4.Runtime.Misc.Interval(start.StartIndex, stopIndex));
        if (keepQuotes || result.Length < 2)
            return result;

        char quoteChar = result[0];
        if ((quoteChar == '"' || quoteChar == '`' || quoteChar == '\'') && quoteChar == result.LastOrDefault())
        {
            if (quoteChar == '"' || quoteChar == '\'')
            {
                // Replace any double occurence of the quote char by a single one.
                result = result.Replace(new string(quoteChar, 2), new string(quoteChar, 1));
            }

            return result.Substring(1, result.Length - 2);
        }

        return result;
    }

    public IParseTree getPreviousSibling(IParseTree tree)
    {
        IParseTree parent = tree.Parent;
        if (parent == null)
            return default(IParseTree);


        if (parent.ChildCount == 0 || parent.GetChild(0) == tree)
            return null;

        var children = Enumerable.Range(0, parent.ChildCount).Select(i => parent.GetChild(i));
        for (int childIndex = 0; childIndex < parent.ChildCount; childIndex++)
        {
            if (parent.GetChild(childIndex) == tree)
            {
                return parent.GetChild(childIndex - 1);
            }
        }
        return default(IParseTree);
    }

    public IParseTree getPrevious(IParseTree tree)
    {
        do
        {
            IParseTree sibling = getPreviousSibling(tree);
            if (sibling != null)
            {
                if (sibling is ITerminalNode terminalNode && terminalNode != null)
                    return sibling;

                tree = sibling;

                while (tree.ChildCount > 0)
                    tree = tree.GetChild(tree.ChildCount - 1);
                if (tree is ITerminalNode)
                    return tree;
            }
            else
                tree = tree.Parent;
        } while (tree != null);

        return null;
    }

    public IParseTree getNextSibling(IParseTree tree)
    {
        IParseTree parent = tree.Parent;
        if (parent == null)
            return null;

        if (parent.ChildCount == 0 || parent.GetChild(parent.ChildCount - 1) == tree)
            return null;

        for (int childIndex = 0; childIndex < parent.ChildCount; childIndex++)
        {
            var iterator = parent.GetChild(childIndex);
            if (iterator == tree)
            {
                return parent.GetChild(childIndex + 1);
            }
        }

        return null; // We actually never arrive here, but compilers want to be silenced.
    }

    public IParseTree getNext(IParseTree tree)
    {
        // If we have children return the first one.
        if (tree.ChildCount > 0)
        {
            do
            {
                tree = tree.GetChild(0);
            } while (tree.ChildCount > 0);
            return tree;
        }

        // No children, so try our next sibling (or that of our parent(s)).
        do
        {
            IParseTree sibling = getNextSibling(tree);
            if (sibling != null)
            {
                if (sibling is ITerminalNode)
                    return sibling;
                return getNext(sibling);
            }
            tree = tree.Parent;
        } while (tree != null);

        return null;
    }

    IParseTree terminalFromPosition(IParseTree root, (int first, int second) position)
    {
        do
        {
            root = getNext(root);
            if (root is ITerminalNode)
            {
                IToken token = (root as ITerminalNode)?.Symbol;
                if (token.Type == TokenConstants.EOF)
                    return getPrevious(root);

                // If we reached a position after the given one then we found a situation
                // where that position is between two terminals. Return the previous one in this case.
                if (position.second < token.Line)
                    return getPrevious(root);
                if (position.second == token.Line && position.first < token.Column)
                    return getPrevious(root);

                int length = token.StopIndex - token.StartIndex + 1;
                if (position.second == token.Line && (position.first < token.Column + length))
                    return root;
            }
        } while (root != null);

        return null;
    }

    public static bool treeContainsPosition(IParseTree node, int position)
    {
        var terminal = node as ITerminalNode;
        if (terminal != null)
        {
            return terminal.Symbol.StartIndex <= position && position <= terminal.Symbol.StopIndex;
        }

        var context = node as ParserRuleContext;
        if (context == null)
            return false;

        return context.Start.StartIndex <= position && position <= context.Stop.StopIndex;
    }

    public IParseTree contextFromPosition(IParseTree root, int position)
    {
        if (!treeContainsPosition(root, position))
            return null;
        for (int childIndex = 0; childIndex < root.ChildCount; childIndex++)
        {
            var child = root.GetChild(childIndex);
            var result = contextFromPosition(child, position);
            if (result != null)
                return result;
        }

        // No child contains the given position, so it must be in whitespaces between them. Return the root for that case.
        return root;
    }

    //public SymbolTable parsers::functionSymbolsForVersion(mySqlVersion version)
    //{
    //    static std::map<mySqlVersion, SymbolTable> functionSymbols;

    //    if (functionSymbols.count(version) == 0)
    //    {
    //        auto & functions = mySqlSymbolInfo::systemFunctionsForVersion(version);
    //        SymbolTable & symbolTable = functionSymbols[version]; // Creates the new symbol table.

    //        for (auto function : functions)
    //        {
    //            symbolTable.addNewSymbol<RoutineSymbol>(nullptr, function, nullptr);
    //        }
    //    }
    //    return &functionSymbols[version];
    //}

}
