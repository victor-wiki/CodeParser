using Antlr4.Runtime;
using System.Collections.Generic;
using System.IO;


/// <summary>
/// All lexer methods that used in grammar (IsStrictMode)
/// should start with Upper Case Char similar to Lexer rules.
/// </summary>
public abstract class JavaScriptBaseLexer : Lexer
{
    /// <summary>
    /// Stores values of nested modes. By default mode is strict or
    /// defined externally(useStrictDefault)
    /// </summary>
    private Stack<bool> scopeStrictModes = new Stack<bool>();

    private IToken _lastToken = null;

    /// <summary>
    /// Default value of strict mode
    /// Can be defined externally by changing UseStrictDefault
    /// </summary>
    private bool _useStrictDefault = false;

    /// <summary>
    /// Current value of strict mode
    /// Can be defined during parsing, see StringFunctions.js and StringGlobal.js samples
    /// </summary>
    private bool _useStrictCurrent = false;

    public const int
    HashBangLine = 1, MultiLineComment = 2, SingleLineComment = 3, RegularExpressionLiteral = 4,
    OpenBracket = 5, CloseBracket = 6, OpenParen = 7, CloseParen = 8, OpenBrace = 9,
    CloseBrace = 10, SemiColon = 11, Comma = 12, Assign = 13, QuestionMark = 14, Colon = 15,
    Ellipsis = 16, Dot = 17, PlusPlus = 18, MinusMinus = 19, Plus = 20, Minus = 21, BitNot = 22,
    Not = 23, Multiply = 24, Divide = 25, Modulus = 26, Power = 27, NullCoalesce = 28,
    Hashtag = 29, RightShiftArithmetic = 30, LeftShiftArithmetic = 31, RightShiftLogical = 32,
    LessThan = 33, MoreThan = 34, LessThanEquals = 35, GreaterThanEquals = 36, Equals_ = 37,
    NotEquals = 38, IdentityEquals = 39, IdentityNotEquals = 40, BitAnd = 41, BitXOr = 42,
    BitOr = 43, And = 44, Or = 45, MultiplyAssign = 46, DivideAssign = 47, ModulusAssign = 48,
    PlusAssign = 49, MinusAssign = 50, LeftShiftArithmeticAssign = 51, RightShiftArithmeticAssign = 52,
    RightShiftLogicalAssign = 53, BitAndAssign = 54, BitXorAssign = 55, BitOrAssign = 56,
    PowerAssign = 57, ARROW = 58, NullLiteral = 59, BooleanLiteral = 60, DecimalLiteral = 61,
    HexIntegerLiteral = 62, OctalIntegerLiteral = 63, OctalIntegerLiteral2 = 64,
    BinaryIntegerLiteral = 65, BigHexIntegerLiteral = 66, BigOctalIntegerLiteral = 67,
    BigBinaryIntegerLiteral = 68, BigDecimalIntegerLiteral = 69, Break = 70, Do = 71,
    Instanceof = 72, Typeof = 73, Case = 74, Else = 75, New = 76, Var = 77, Catch = 78,
    Finally = 79, Return = 80, Void = 81, Continue = 82, For = 83, Switch = 84, While = 85,
    Debugger = 86, Function = 87, This = 88, With = 89, Default = 90, If = 91, Throw = 92,
    Delete = 93, In = 94, Try = 95, As = 96, From = 97, Class = 98, Enum = 99, Extends = 100,
    Super = 101, Const = 102, Export = 103, Import = 104, Async = 105, Await = 106, Implements = 107,
    Let = 108, Private = 109, Public = 110, Interface = 111, Package = 112, Protected = 113,
    Static = 114, Yield = 115, Identifier = 116, StringLiteral = 117, TemplateStringLiteral = 118,
    WhiteSpaces = 119, LineTerminator = 120, HtmlComment = 121, CDataComment = 122,
    UnexpectedCharacter = 123;

    public JavaScriptBaseLexer(ICharStream input)
        : base(input)
    {
    }

    public JavaScriptBaseLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
    : base(input, output, errorOutput)
    {

    }

    public bool IsStartOfFile()
    {
        return _lastToken == null;
    }

    public bool UseStrictDefault
    {
        get
        {
            return _useStrictDefault;
        }
        set
        {
            _useStrictDefault = value;
            _useStrictCurrent = value;
        }
    }

    public bool IsStrictMode()
    {
        return _useStrictCurrent;
    }

    /// <summary>
    /// Return the next token from the character stream and records this last
    /// token in case it resides on the default channel. This recorded token
    /// is used to determine when the lexer could possibly match a regex
    /// literal.
    /// 
    /// </summary>
    /// <returns>
    /// The next token from the character stream.
    /// </returns>
    public override IToken NextToken()
    {
        // Get the next token.
        IToken next = base.NextToken();

        if (next.Channel == DefaultTokenChannel)
        {
            // Keep track of the last token on the default channel.
            _lastToken = next;
        }

        return next;
    }

    protected void ProcessOpenBrace()
    {
        _useStrictCurrent = scopeStrictModes.Count > 0 && scopeStrictModes.Peek() ? true : UseStrictDefault;
        scopeStrictModes.Push(_useStrictCurrent);
    }

    protected void ProcessCloseBrace()
    {
        _useStrictCurrent = scopeStrictModes.Count > 0 ? scopeStrictModes.Pop() : UseStrictDefault;
    }

    protected void ProcessStringLiteral()
    {
        if (_lastToken == null || _lastToken.Type == OpenBrace)
        {
            if (Text.Equals("\"use strict\"") || Text.Equals("'use strict'"))
            {
                if (scopeStrictModes.Count > 0)
                    scopeStrictModes.Pop();
                _useStrictCurrent = true;
                scopeStrictModes.Push(_useStrictCurrent);
            }
        }
    }

    /// <summary>
    /// Returns true if the lexer can match a regex literal.
    /// </summary>
    protected bool IsRegexPossible()
    {
        if (_lastToken == null)
        {
            // No token has been produced yet: at the start of the input,
            // no division is possible, so a regex literal _is_ possible.
            return true;
        }

        switch (_lastToken.Type)
        {
            case Identifier:
            case NullLiteral:
            case BooleanLiteral:
            case This:
            case CloseBracket:
            case CloseParen:
            case OctalIntegerLiteral:
            case DecimalLiteral:
            case HexIntegerLiteral:
            case StringLiteral:
            case PlusPlus:
            case MinusMinus:
                // After any of the tokens above, no regex literal can follow.
                return false;
            default:
                // In all other cases, a regex literal _is_ possible.
                return true;
        }
    }
}
