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
                this.Write($"begin to parse file:{file.Name}");
                this.WriteLeftBoundaryLine();
                this.Parse(file);
                this.WriteRightBoundaryLine();
            }
        }

        protected void WriteLine()
        {
            this.Write("");
        }

        protected void WriteLeftBoundaryLine()
        {
            this.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }

        protected void WriteRightBoundaryLine()
        {
            this.Write("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
        }

        protected void WriteLeftBrace()
        {
            this.Write("{");
        }

        protected void WriteRightBrace()
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
