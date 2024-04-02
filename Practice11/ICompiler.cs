using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    internal interface ICompiler
    {
        void isFileSupported(string name);
        void PrintCommand(string name);


    }
}
