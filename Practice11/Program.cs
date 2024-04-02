using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice11
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            CSharpCompiler cSharpCompiler = new CSharpCompiler();
            PythonCompiler pythonCompiler = new PythonCompiler();
            List<ICompiler> compilerList = new List<ICompiler>();
            compilerList.Add(pythonCompiler);
            compilerList.Add(cSharpCompiler);

            string name = OpenFile();
            foreach(ICompiler compiler in compilerList)
            {
                compiler.isFileSupported(name);
            }
            //OpenFileDialog file = new OpenFileDialog();
            //DialogResult result = file.ShowDialog();
            Console.ReadLine();
        }
        public static string OpenFile()
        {
            using(OpenFileDialog openFileDialog =new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFileDialog.SafeFileName;
                    return filename;
                }
                return "";
            }
        }
    }
}
