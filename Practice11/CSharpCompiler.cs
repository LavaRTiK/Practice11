using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    internal class CSharpCompiler : ICompiler
    {
        public CSharpCompiler() { }
        public CSharpCompiler(string compilerName) { }

        public void isFileSupported(string name)
        {
            string cs = "cs";
            if (name.EndsWith(cs))
            {
                PrintCommand(name);
            }
            else
            {
                Console.WriteLine("Не підхоить  CSharp ");
            }
        }

        public void PrintCommand(string name)
        {
            Console.WriteLine("CSharp " + name);
        }
    }
}
