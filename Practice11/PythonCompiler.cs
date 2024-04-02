using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    internal class PythonCompiler : ICompiler
    {
        public PythonCompiler() { }
        public PythonCompiler(string name) { }

        public  void isFileSupported(string name)
        {
            string py = ".py";
            if (name.EndsWith(py))
            {
                PrintCommand(name);
            }
            else
            {
                Console.WriteLine("Не підходть python");
            }
        }

        public void PrintCommand(string name)
        {
            Console.WriteLine("Python " + name);
        }
    }
}
