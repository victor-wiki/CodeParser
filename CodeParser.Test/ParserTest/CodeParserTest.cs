using System;
using System.IO;

namespace CodeParser.Test
{
    public abstract class CodeParserTest
    {
        public abstract string Language { get; }
        public abstract string FileExtension { get; }

        public void Parse()
        {
            DirectoryInfo di = new DirectoryInfo("Examples");
            FileInfo[] files = di.GetFiles("*" + this.FileExtension);

            foreach (var file in files)
            {
                this.WriteLine();
                this.Write($"{file.Name}");
                this.WriteBeginBoundaryLine();
                this.Parse(file);
                this.WriteEndBoundaryLine();
            }
        }

        protected void WriteLine()
        {
            this.Write("");
        }

        protected void WriteBeginBoundaryLine()
        {
            this.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        protected void WriteEndBoundaryLine()
        {
            this.Write("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        protected void WriteBeginBrace()
        {
            this.Write("{");
        }

        protected void WriteEndBrace()
        {
            this.Write("}");
        }

        public virtual void Parse(FileInfo file) { }

        protected void WriteKeyValue(string key, string value)
        {
            this.Write($"{key}:{value}");
        }

        protected void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
