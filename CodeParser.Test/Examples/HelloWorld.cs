using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Demo
{
    public interface ISpeech
    {
        string Name { get; }
        void SayHello(string word);
    }

    public delegate void SayHelloHandler(string word);

    public class CSharpHelloWord : ISpeech
    {
        public event SayHelloHandler OnSayHello;

        public string owner;
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public void SayHello(string word)
        {
            Console.WriteLine(word);
        }
    }

    public enum SayMode
    {
        Default,
        Custom
    }
}
