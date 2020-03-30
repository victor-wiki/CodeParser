/*
PHP grammar.
The MIT License (MIT).
Copyright (c) 2015-2017, Ivan Kochurkin (kvanttt@gmail.com), Positive Technologies.
Copyright (c) 2019, Thierry Marianne (thierry.marianne@weaving-the-web.org)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using Antlr4.Runtime;
using System.IO;
// Replace PhpParser with its fully qualified name below
//using static PhpLexer;

namespace CodeParser
{
    public abstract class PhpBaseLexer : Lexer
    {     
        protected bool AspTags = true;
        protected bool _scriptTag;
        protected bool _styleTag;
        protected string _heredocIdentifier;
        protected int _prevTokenType;
        protected string _htmlNameText;
        protected bool _phpScript;
        protected bool _insideString;
        public const int
         PhpComments = 2, ErrorLexem = 3, SkipChannel = 4;
        public const int
         XML = 1, INSIDE = 2, HtmlQuoteStringMode = 3, HtmlDoubleQuoteStringMode = 4, SCRIPT = 5,
         STYLE = 6, PHP = 7, InterpolationString = 8, SingleLineCommentMode = 9, HereDoc = 10;

        public const int
            SeaWhitespace = 1, HtmlText = 2, XmlStart = 3, PHPStart = 4, HtmlScriptOpen = 5,
            HtmlStyleOpen = 6, HtmlComment = 7, HtmlDtd = 8, HtmlOpen = 9, Shebang = 10, Error = 11,
            XmlText = 12, XmlClose = 13, PHPStartInside = 14, HtmlClose = 15, HtmlSlashClose = 16,
            HtmlSlash = 17, HtmlEquals = 18, HtmlStartQuoteString = 19, HtmlStartDoubleQuoteString = 20,
            HtmlHex = 21, HtmlDecimal = 22, HtmlSpace = 23, HtmlName = 24, ErrorInside = 25,
            PHPStartInsideQuoteString = 26, HtmlEndQuoteString = 27, HtmlQuoteString = 28,
            ErrorHtmlQuote = 29, PHPStartDoubleQuoteString = 30, HtmlEndDoubleQuoteString = 31,
            HtmlDoubleQuoteString = 32, ErrorHtmlDoubleQuote = 33, ScriptText = 34, ScriptClose = 35,
            PHPStartInsideScript = 36, StyleBody = 37, PHPEnd = 38, Whitespace = 39, MultiLineComment = 40,
            SingleLineComment = 41, ShellStyleComment = 42, Abstract = 43, Array = 44, As = 45,
            BinaryCast = 46, BoolType = 47, BooleanConstant = 48, Break = 49, Callable = 50,
            Case = 51, Catch = 52, Class = 53, Clone = 54, Const = 55, Continue = 56, Declare = 57,
            Default = 58, Do = 59, DoubleCast = 60, DoubleType = 61, Echo = 62, Else = 63, ElseIf = 64,
            Empty = 65, EndDeclare = 66, EndFor = 67, EndForeach = 68, EndIf = 69, EndSwitch = 70,
            EndWhile = 71, Eval = 72, Exit = 73, Extends = 74, Final = 75, Finally = 76, FloatCast = 77,
            For = 78, Foreach = 79, Function = 80, Global = 81, Goto = 82, If = 83, Implements = 84,
            Import = 85, Include = 86, IncludeOnce = 87, InstanceOf = 88, InsteadOf = 89, Int8Cast = 90,
            Int16Cast = 91, Int64Type = 92, IntType = 93, Interface = 94, IsSet = 95, List = 96,
            LogicalAnd = 97, LogicalOr = 98, LogicalXor = 99, Namespace = 100, New = 101, Null = 102,
            ObjectType = 103, Parent_ = 104, Partial = 105, Print = 106, Private = 107, Protected = 108,
            Public = 109, Require = 110, RequireOnce = 111, Resource = 112, Return = 113, Static = 114,
            StringType = 115, Switch = 116, Throw = 117, Trait = 118, Try = 119, Typeof = 120,
            UintCast = 121, UnicodeCast = 122, Unset = 123, Use = 124, Var = 125, While = 126,
            Yield = 127, From = 128, LambdaFn = 129, Get = 130, Set = 131, Call = 132, CallStatic = 133,
            Constructor = 134, Destruct = 135, Wakeup = 136, Sleep = 137, Autoload = 138, IsSet__ = 139,
            Unset__ = 140, ToString__ = 141, Invoke = 142, SetState = 143, Clone__ = 144, DebugInfo = 145,
            Namespace__ = 146, Class__ = 147, Traic__ = 148, Function__ = 149, Method__ = 150,
            Line__ = 151, File__ = 152, Dir__ = 153, Spaceship = 154, Lgeneric = 155, Rgeneric = 156,
            DoubleArrow = 157, Inc = 158, Dec = 159, IsIdentical = 160, IsNoidentical = 161,
            IsEqual = 162, IsNotEq = 163, IsSmallerOrEqual = 164, IsGreaterOrEqual = 165,
            PlusEqual = 166, MinusEqual = 167, MulEqual = 168, Pow = 169, PowEqual = 170, DivEqual = 171,
            Concaequal = 172, ModEqual = 173, ShiftLeftEqual = 174, ShiftRightEqual = 175,
            AndEqual = 176, OrEqual = 177, XorEqual = 178, BooleanOr = 179, BooleanAnd = 180,
            NullCoalescing = 181, NullCoalescingEqual = 182, ShiftLeft = 183, ShiftRight = 184,
            DoubleColon = 185, ObjectOperator = 186, NamespaceSeparator = 187, Ellipsis = 188,
            Less = 189, Greater = 190, Ampersand = 191, Pipe = 192, Bang = 193, Caret = 194, Plus = 195,
            Minus = 196, Asterisk = 197, Percent = 198, Divide = 199, Tilde = 200, SuppressWarnings = 201,
            Dollar = 202, Dot = 203, QuestionMark = 204, OpenRoundBracket = 205, CloseRoundBracket = 206,
            OpenSquareBracket = 207, CloseSquareBracket = 208, OpenCurlyBracket = 209, CloseCurlyBracket = 210,
            Comma = 211, Colon = 212, SemiColon = 213, Eq = 214, Quote = 215, BackQuote = 216,
            VarName = 217, Label = 218, Octal = 219, Decimal = 220, Real = 221, Hex = 222, Binary = 223,
            BackQuoteString = 224, SingleQuoteString = 225, DoubleQuote = 226, StartNowDoc = 227,
            StartHereDoc = 228, ErrorPhp = 229, CurlyDollar = 230, UnicodeEscape = 231, StringPart = 232,
            Comment = 233, PHPEndSingleLineComment = 234, CommentEnd = 235, HereDocText = 236,
            XmlText2 = 237;

        public PhpBaseLexer(ICharStream input)
            : base(input)
        {
        }

        public PhpBaseLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
        : base(input, output, errorOutput)
        {
        }

        public override IToken NextToken()
        {
            CommonToken token = (CommonToken)base.NextToken();

            if (token.Type == PHPEnd || token.Type == PHPEndSingleLineComment)
            {
                if (CurrentMode == SingleLineCommentMode) 
                {
                    // SingleLineCommentMode for such allowed syntax:
                    // <?php echo "Hello world"; // comment ?>
                    PopMode(); // exit from SingleLineComment mode.
                }
                PopMode(); // exit from PHP mode.

                if (string.Equals(token.Text, "</script>", System.StringComparison.Ordinal))
                {
                    _phpScript = false;
                    token.Type = ScriptClose;
                }
                else
                {
                    // Add semicolon to the end of statement if it is absente.
                    // For example: <?php echo "Hello world" ?>
                    if (_prevTokenType == SemiColon || _prevTokenType == Colon
                        || _prevTokenType == OpenCurlyBracket || _prevTokenType == CloseCurlyBracket)
                    {
                        token.Channel = SkipChannel;
                    }
                    else
                    {
                        token.Type = SemiColon;
                    }
                }
            }
            else if (token.Type == HtmlName)
            {
                _htmlNameText = token.Text;
            }
            else if (token.Type == HtmlDoubleQuoteString)
            {
                if (string.Equals(token.Text, "php", System.StringComparison.OrdinalIgnoreCase) &&
                    string.Equals(_htmlNameText, "language"))
                {
                    _phpScript = true;
                }
            }
            else if (CurrentMode == HereDoc)
            {
                // Heredoc and Nowdoc syntax support: http://php.net/manual/en/language.types.string.php#language.types.string.syntax.heredoc
                switch (token.Type)
                {
                    case StartHereDoc:
                    case StartNowDoc:
                        _heredocIdentifier = token.Text.Substring(3).Trim().Trim('\'');
                        break;

                    case HereDocText:
                        if (CheckHeredocEnd(token.Text))
                        {
                            PopMode();

                            var heredocIdentifier = GetHeredocIdentifier(token.Text);
                            if (token.Text.Trim().EndsWith(";"))
                            {
                                token.Text = heredocIdentifier + ";\n";
                                token.Type = SemiColon;
                            }
                            else
                            {
                                token = (CommonToken)base.NextToken();
                                token.Text = heredocIdentifier + "\n;";
                            }
                        }
                        break;
                }
            }
            else if (CurrentMode == PHP)
            {
                if (Channel != Hidden)
                {
                    _prevTokenType = token.Type;
                }
            }

            return token;
        }

        protected string GetHeredocIdentifier(string text)
        {
            text = text.Trim();
            bool semi = text.Length > 0 ? text[text.Length - 1] == ';' : false;
            return semi ? text.Substring(0, text.Length - 1) : text;
        }

        protected bool CheckHeredocEnd(string text)
        {
            return string.Equals(GetHeredocIdentifier(text), _heredocIdentifier, System.StringComparison.Ordinal);
        }

        protected bool IsNewLineOrStart(int pos)
        {
            return InputStream.LA(pos) <= 0 || InputStream.LA(pos) == '\r' || InputStream.LA(pos) == '\n';
        }

        protected void PushModeOnHtmlClose()
        {
            PopMode();
            if (_scriptTag)
            {
                if (!_phpScript)
                {
                    PushMode(SCRIPT);
                }
                else
                {
                    PushMode(PHP);
                }
                _scriptTag = false;
            }
            else if (_styleTag)
            {
                PushMode(STYLE);
                _styleTag = false;
            }
        }

        protected bool HasAspTags()
        {
            return AspTags;
        }

        protected bool HasPhpScriptTag()
        {
            return _phpScript;
        }

        protected void PopModeOnCurlyBracketClose()
        {
            if (_insideString)
            {
                _insideString = false;
                Channel = SkipChannel;
                PopMode();
            }
        }

        protected bool ShouldPushHereDocMode(int pos)
        {
            return InputStream.LA(pos) == '\r' || InputStream.LA(pos) == '\n';
        }

        protected bool IsCurlyDollar(int pos) {
            return InputStream.LA(pos) == '$';
        }

        protected void SetInsideString() {
            _insideString = true;
        }
    }
}