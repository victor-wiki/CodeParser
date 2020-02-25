using Antlr4.Runtime;
using System.IO;

namespace CodeParser
{
    /// <summary>
    /// All parser methods that used in grammar (p, prev, notLineTerminator, etc.)
    /// should start with lower case char similar to parser rules.
    /// </summary>
    public abstract class JavaScriptBaseParser : Parser
    {
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

        public JavaScriptBaseParser(ITokenStream input)
            : base(input)
        {
        }

        public JavaScriptBaseParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
        : base(input, output, errorOutput)
        {

        }

        /// <summary>
        /// Short form for prev(String str)
        /// </summary>
        protected bool p(string str)
        {
            return prev(str);
        }

        /// <summary>
        /// Whether the previous token value equals to str
        /// </summary>
        protected bool prev(string str)
        {
            return TokenStream.LT(-1).Text.Equals(str);
        }

        // Short form for next(String str)
        protected bool n(string str)
        {
            return next(str);
        }

        // Whether the next token value equals to @param str
        protected bool next(string str)
        {
            return TokenStream.LT(1).Text.Equals(str);
        }

        protected bool notLineTerminator()
        {
            return !here(LineTerminator);
        }

        protected bool notOpenBraceAndNotFunction()
        {
            int nextTokenType = TokenStream.LT(1).Type;
            return nextTokenType != OpenBrace && nextTokenType != Function;
        }

        protected bool closeBrace()
        {
            return TokenStream.LT(1).Type == CloseBrace;
        }

        /// <summary>Returns true if on the current index of the parser's
        /// token stream a token of the given type exists on the
        /// Hidden channel.
        /// </summary>
        /// <param name="type">
        /// The type of the token on the Hidden channel to check.
        /// </param>
        protected bool here(int type)
        {
            // Get the token ahead of the current index.
            int possibleIndexEosToken = CurrentToken.TokenIndex - 1;
            IToken ahead = TokenStream.Get(possibleIndexEosToken);

            // Check if the token resides on the Hidden channel and if it's of the
            // provided type.
            return ahead.Channel == Lexer.Hidden && ahead.Type == type;
        }

        /// <summary>
        /// Returns true if on the current index of the parser's
        /// token stream a token exists on the Hidden channel which
        /// either is a line terminator, or is a multi line comment that
        /// contains a line terminator.
        /// </summary>
        protected bool lineTerminatorAhead()
        {
            // Get the token ahead of the current index.
            int possibleIndexEosToken = CurrentToken.TokenIndex - 1;
            IToken ahead = TokenStream.Get(possibleIndexEosToken);

            if (ahead.Channel != Lexer.Hidden)
            {
                // We're only interested in tokens on the Hidden channel.
                return false;
            }

            if (ahead.Type == LineTerminator)
            {
                // There is definitely a line terminator ahead.
                return true;
            }

            if (ahead.Type == WhiteSpaces)
            {
                // Get the token ahead of the current whitespaces.
                possibleIndexEosToken = CurrentToken.TokenIndex - 2;
                ahead = TokenStream.Get(possibleIndexEosToken);
            }

            // Get the token's text and type.
            string text = ahead.Text;
            int type = ahead.Type;

            // Check if the token is, or contains a line terminator.
            return (type == MultiLineComment && (text.Contains("\r") || text.Contains("\n"))) ||
                    (type == LineTerminator);
        }
    }
}
