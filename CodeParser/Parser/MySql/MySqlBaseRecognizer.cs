using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;
using System.Text;

public abstract class MySqlBaseRecognizer : Antlr4.Runtime.Parser, IMySqlRecognizerCommon
{
    #region IMySqlRecognizerCommon

    protected IMySqlRecognizerCommon mySqlRecognizerCommon = new MySqlRecognizerCommon();

    public int serverVersion { get => mySqlRecognizerCommon.serverVersion; set => mySqlRecognizerCommon.serverVersion = value; }
    public MySqlMode sqlMode { get => mySqlRecognizerCommon.sqlMode; set => mySqlRecognizerCommon.sqlMode = value; }

    public IParseTree contextFromPosition(IParseTree root, int position) => mySqlRecognizerCommon.contextFromPosition(root, position);

    public string dumpTree(RuleContext context, IVocabulary vocabulary) => mySqlRecognizerCommon.dumpTree(context, vocabulary);

    public IParseTree getNext(IParseTree tree) => mySqlRecognizerCommon.getNext(tree);

    public IParseTree getNextSibling(IParseTree tree) => mySqlRecognizerCommon.getNextSibling(tree);

    public IParseTree getPrevious(IParseTree tree) => mySqlRecognizerCommon.getPrevious(tree);

    public IParseTree getPreviousSibling(IParseTree tree) => mySqlRecognizerCommon.getPreviousSibling(tree);

    public bool isSqlModeActive(MySqlMode mode) => isSqlModeActive((int)mode);

    public bool isSqlModeActive(int mode) => mySqlRecognizerCommon.isSqlModeActive(mode);

    public string sourceTextForContext(ParserRuleContext ctx, bool keepQuotes) => mySqlRecognizerCommon.sourceTextForContext(ctx, keepQuotes);

    public string sourceTextForRange(IParseTree start, IParseTree stop, bool keepQuotes) => mySqlRecognizerCommon.sourceTextForRange(start, stop, keepQuotes);

    public string sourceTextForRange(IToken start, IToken stop, bool keepQuotes) => mySqlRecognizerCommon.sourceTextForRange(start, stop, keepQuotes);

    public void sqlModeFromString(string modes) => mySqlRecognizerCommon.sqlModeFromString(modes);
    #endregion

    public MySqlBaseRecognizer(Antlr4.Runtime.ITokenStream input, IMySqlRecognizerCommon mySqlRecognizerCommon = null) : base(input)
    { this.mySqlRecognizerCommon = mySqlRecognizerCommon ?? new MySqlRecognizerCommon(); }

    public MySqlBaseRecognizer(ITokenStream input, TextWriter output, TextWriter errorOutput, IMySqlRecognizerCommon mySqlRecognizerCommon = null) : base(input, output, errorOutput)
    { this.mySqlRecognizerCommon = mySqlRecognizerCommon ?? new MySqlRecognizerCommon(); }

    public static string getText(Antlr4.Runtime.RuleContext context, bool convertEscapes)
    {
        var result = new StringBuilder();
        if (context is MySqlParser.TextLiteralContext textLiteralContext && textLiteralContext != null)
        {
            var list = textLiteralContext.textStringLiteral();
            var lastType = Antlr4.Runtime.TokenConstants.InvalidType;
            var lastIndex = MySqlParsersCommon.InvalidIndex;
            foreach (var entry in list)
            {
                var token = entry.value;
                switch (token.Type)
                {
                    case MySqlParser.DOUBLE_QUOTED_TEXT:
                    case MySqlParser.SINGLE_QUOTED_TEXT:
                        var text = token.Text;
                        var quoteChar = text[0];
                        var doubledQuoteChar = new string(quoteChar, 2);
                        if (lastType == token.Type && lastIndex + 1 == token.TokenIndex)
                        {
                            result.Append(quoteChar);
                        }
                        lastType = token.Type;
                        lastIndex = token.TokenIndex;

                        text = text.Substring(1, text.Length - 2);
                        int position = text.IndexOf(doubledQuoteChar);
                        if (position >= 0)
                        { text = text.Replace(doubledQuoteChar, quoteChar.ToString()); }
                        result.Append(text);
                        break;
                }
            }
            if (convertEscapes)
            {
                var temp = result.ToString();
                result.Clear();
                var pendingEscape = false;
                for (int ci = 0; ci < temp.Length; ci++)
                {
                    var c = temp[ci];
                    if (pendingEscape)
                    {
                        pendingEscape = false;
                        switch (c)
                        {
                            case 'n':
                                c = '\n';
                                break;
                            case 't':
                                c = '\t';
                                break;
                            case 'r':
                                c = '\r';
                                break;
                            case 'b':
                                c = '\b';
                                break;
                            case '0':
                                c = '\u0000';
                                break; // ASCII null
                            case 'Z':
                                c = '\u0032';
                                break; // Win32 end of file
                        }
                    }
                    else if (c == '\\')
                    {
                        pendingEscape = true;
                        continue;
                    }
                    result.Append(c);
                }

                if (pendingEscape)
                { result.Append("\\"); }
            }
            return result.ToString();
        }

        return context.GetText();
    }

    public bool look(int position, int expected)
    {
        return this.InputStream.LA(position) == expected;
    }

    public bool containsLinebreak(string text)
    {
        return text.Contains("\r\n");
    }
}
