using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;

public abstract class MySqlBaseLexer: Lexer
{
    public HashSet<string> charsets;
    public bool inVersionComment;
    private List<IToken> _pendingTokens;
    private Dictionary<string, int> _symbols;
    public MySqlMode sqlMode { get => mySqlRecognizerCommon.sqlMode; set => mySqlRecognizerCommon.sqlMode = value; }

    protected IMySqlRecognizerCommon mySqlRecognizerCommon;
    public int serverVersion { get => mySqlRecognizerCommon.serverVersion; set => mySqlRecognizerCommon.serverVersion = value; }

    public MySqlBaseLexer(
           ICharStream input,
           TextWriter output,
           TextWriter errorOutput,
           IMySqlRecognizerCommon mySqlRecognizerCommon = null
           ) : base(input, output, errorOutput)
    {
        charsets = new HashSet<string>();
        _pendingTokens = new List<IToken>();
        this.mySqlRecognizerCommon = mySqlRecognizerCommon ?? new MySqlRecognizerCommon();
    }

    public MySqlBaseLexer(ICharStream input, IMySqlRecognizerCommon mySqlRecognizerCommon = null) : base(input)
    {
        this.mySqlRecognizerCommon = mySqlRecognizerCommon ?? new MySqlRecognizerCommon();
        charsets = new HashSet<string>();
        _symbols = new Dictionary<string, int>();
        serverVersion = 0;
        sqlMode = MySqlMode.NoMode;
        inVersionComment = false;
    }

    protected void emitDot()
    {
        _pendingTokens.Add(this.TokenFactory.Create(
            new Tuple<ITokenSource, ICharStream>(this, this.InputStream as ICharStream),
            MySqlLexer.DOT_SYMBOL,
            this.Text,
            this.Channel,
            TokenStartCharIndex,
            TokenStartCharIndex,
            TokenStartLine,
            TokenStartLine //tokenStartCharPositionInLine
        ));

        Skip(); //TokenStartCharIndex = TokenStartCharIndex + 1;
    }

    protected int determineFunction(int proposed)
    {
        // Skip any whitespace character if the sql mode says they should be ignored,
        // before actually trying to match the open parenthesis.
        if (isSqlModeActive((int)MySqlMode.IgnoreSpace))
        {
            int input = this.InputStream.LA(1);
            while (input == ' ' || input == '\t' || input == '\r' || input == '\n')
            {
                this.Interpreter.Consume(this.InputStream as ICharStream);
                this.Channel = Lexer.Hidden;
                this.Type = MySqlLexer.WHITESPACE;
                input = this.InputStream.LA(1);
            }
        }

        return this.InputStream.LA(1) == '(' ? proposed : MySqlLexer.IDENTIFIER;
    }

    protected int determineNumericType(string text)
    {
        const string long_str = "2147483647";
        const int long_len = 10;
        const string signed_long_str = "-2147483648";
        const string longlong_str = "9223372036854775807";
        const int longlong_len = 19;
        const string signed_longlong_str = "-9223372036854775808";
        const int signed_longlong_len = 19;
        const string unsigned_longlong_str = "18446744073709551615";
        const int unsigned_longlong_len = 20;

        // The original code checks for leading +/- but actually that can never happen, neither in the
        // server parser (as a digit is used to trigger processing in the lexer) nor in our parser
        // as our rules are defined without signs. But we do it anyway for maximum compatibility.
        int length = text.Length - 1;
        var strIndex = 0;
        if (length < long_len) // quick normal case
            return MySqlLexer.INT_NUMBER;
        int negative = 0;

        if (text[strIndex] == '+') // Remove sign and pre-zeros
        {
            strIndex++;
            length--;
        }
        else if (text[strIndex] == '-')
        {
            strIndex++;
            length--;
            negative = 1;
        }

        while (text[strIndex] == '0' && length != 0)
        {
            strIndex++;
            length--;
        }

        if (length < long_len)
            return MySqlLexer.INT_NUMBER;

        int smaller, bigger;
        int cmpIndex = 0;
        string cmp = string.Empty;
        if (negative != 0)
        {
            if (length == long_len)
            {
                cmp = signed_long_str + 1;
                smaller = MySqlLexer.INT_NUMBER; // If <= signed_long_str
                bigger = MySqlLexer.LONG_NUMBER; // If >= signed_long_str
            }
            else if (length < signed_longlong_len)
                return MySqlLexer.LONG_NUMBER;
            else if (length > signed_longlong_len)
                return MySqlLexer.DECIMAL_NUMBER;
            else
            {
                cmp = signed_longlong_str + 1;
                smaller = MySqlLexer.LONG_NUMBER; // If <= signed_longlong_str
                bigger = MySqlLexer.DECIMAL_NUMBER;
            }
        }
        else
        {
            if (length == long_len)
            {
                cmp = long_str;
                smaller = MySqlLexer.INT_NUMBER;
                bigger = MySqlLexer.LONG_NUMBER;
            }
            else if (length < longlong_len)
                return MySqlLexer.LONG_NUMBER;
            else if (length > longlong_len)
            {
                if (length > unsigned_longlong_len)
                    return MySqlLexer.DECIMAL_NUMBER;
                cmp = unsigned_longlong_str;
                smaller = MySqlLexer.ULONGLONG_NUMBER;
                bigger = MySqlLexer.DECIMAL_NUMBER;
            }
            else
            {
                cmp = longlong_str;
                smaller = MySqlLexer.LONG_NUMBER;
                bigger = MySqlLexer.ULONGLONG_NUMBER;
            }
        }

        while (!string.IsNullOrEmpty(cmp) && cmpIndex++ == strIndex++)
            ;

        //return ((unsigned char)strIndex[-1] <= (unsigned char)cmpIndex[-1]) ? smaller: bigger;
        return (text[strIndex - 1] <= text[cmpIndex - 1]) ? smaller : bigger;
    }

    	private bool VERSION_COMMENT_START_sempred(RuleContext _localctx, int predIndex) {
		switch (predIndex) {
		case 151: return checkVersion(getText());
		}
		return true;
	}

    protected bool checkVersion(string text)
    {
        if (text.Length < 8) // Minimum is: /*!12345
            return false;

        // Skip version comment introducer.
        long version = long.Parse(text.Substring(3));
        if (version <= serverVersion)
        {
            inVersionComment = true;
            return true;
        }
        return false;
    }

    protected int checkCharset(string text)
    {
        //return charsets.Count > 0 ? MySqlLexer.UNDERSCORE_CHARSET : MySqlLexer.IDENTIFIER;
        return charsets.Contains(text) ? MySqlLexer.UNDERSCORE_CHARSET : MySqlLexer.IDENTIFIER;

    }

    public bool isSqlModeActive(MySqlMode mode) => isSqlModeActive((int)mode);

    public bool isSqlModeActive(int mode) => mySqlRecognizerCommon.isSqlModeActive(mode);

    public void setType(int type) => this.Type = type;
    public int getType() => this.Type;

    public void setText(string text) => this.Text = text;
    public string getText() => this.Text;
}