using System;
using System.IO;

namespace CodeParser.Test
{
    public abstract class CodeParserTest
    {       
        public virtual string SubFolder { get; set; }  
        public abstract string Language { get; }

        protected int indent = 0;       

        public void Parse(ParserInfo info)
        {
            DirectoryInfo di = new DirectoryInfo("Examples" + (!string.IsNullOrEmpty(this.SubFolder) ? ("/" + this.SubFolder) : ""));

            FileInfo[] files = di.GetFiles("*" + info.FileExtension);

            foreach (var file in files)
            {
                this.WriteLine();
                this.WriteLine($"{file.Name}");
                this.WriteBeginBoundaryLine();
                this.Parse(file);
                this.WriteEndBoundaryLine();
            }
        }

        protected void WriteLine()
        {
            this.WriteLine("");
        }

        protected void WriteBeginBoundaryLine()
        {
            this.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        protected void WriteEndBoundaryLine()
        {
            this.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        protected void WriteBeginBrace(int indent = 0)
        {
            this.WriteLine(this.GetIndent(indent) + "{");
        }

        protected void WriteEndBrace(int indent = 0)
        {
            this.WriteLine(this.GetIndent(indent) + "}");
        }

        public virtual void Parse(FileInfo file) { }

        protected void WriteKeyValue(string key, string value, int indent=0)
        {
            this.WriteLine(this.GetIndent(indent) + $"{key}:{value}");
        }       

        protected void WriteLine(string text, int indent=0)
        {
            Console.WriteLine(this.GetIndent(indent) + text);
        }

        protected void Write(string text, int indent = 0)
        {
            Console.Write(this.GetIndent(indent) + text);
        }

        private string GetIndent(int indent)
        {
            return "".PadLeft(indent, ' ');
        }
    }
}
