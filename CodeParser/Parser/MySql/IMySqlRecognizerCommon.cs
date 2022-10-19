using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

public interface IMySqlRecognizerCommon
{
    int serverVersion { get; set; }
    MySqlMode sqlMode { get; set; }

    IParseTree contextFromPosition(IParseTree root, int position);
    string dumpTree(RuleContext context, IVocabulary vocabulary);
    IParseTree getNext(IParseTree tree);
    IParseTree getNextSibling(IParseTree tree);
    IParseTree getPrevious(IParseTree tree);
    IParseTree getPreviousSibling(IParseTree tree);
    bool isSqlModeActive(MySqlMode mode);
    bool isSqlModeActive(int mode);
    string sourceTextForContext(ParserRuleContext ctx, bool keepQuotes);
    string sourceTextForRange(IParseTree start, IParseTree stop, bool keepQuotes);
    string sourceTextForRange(IToken start, IToken stop, bool keepQuotes);
    void sqlModeFromString(string modes);
}