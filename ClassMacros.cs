using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Diagnostics;

namespace ExtendedTextEditor
{
    class ClassMacros
    {
        private List<string> assemblyList = new List<string>();

        public void AddAssembly(string assemblyName)
        {
            

        }

        public string Compile(string pathToFile)
        {
            if (!pathToFile.EndsWith("cs"))
            {
                System.Windows.Forms.MessageBox.Show("Macros must be written on C# and it have an .cs extension. ");
                return null;
            }

            StreamReader reader = new StreamReader(pathToFile, Encoding.Default);
            string macroCode = reader.ReadToEnd();
            reader.Close();

            var csProv = CSharpCodeProvider.CreateProvider("CSharp");
            CompilerParameters csParams = new CompilerParameters();

            csParams.ReferencedAssemblies.Add("system.dll");
            csParams.GenerateExecutable = true;
            csParams.GenerateInMemory = false;
            csParams.OutputAssembly = "output.exe";

            CompilerResults compResults = csProv.CompileAssemblyFromSource(csParams, macroCode);

            if (compResults.Errors.Count > 0)
            {
                foreach (var er in compResults.Errors) System.Windows.Forms.MessageBox.Show(er.ToString());
                return null;
            }
            else return csParams.OutputAssembly;
        }

        public void Run(string pathToFile, string[] args)
        {
            Process.Start(pathToFile, args + " -command");
        }

        public void RunMacro(string assemblyName)
        {
            if (!assemblyName.EndsWith("cs"))
            {
                System.Windows.Forms.MessageBox.Show("Macros must be written on C# and it have an .cs extension. ");
                return;
            }

            StreamReader reader = new StreamReader(assemblyName, Encoding.Default);
            string macroCode = reader.ReadToEnd();
            reader.Close();

            var csProv = CSharpCodeProvider.CreateProvider("CSharp");
            CompilerParameters csParams = new CompilerParameters();

            csParams.ReferencedAssemblies.Add("system.dll");
            csParams.GenerateExecutable = true;
            csParams.GenerateInMemory = false;
            csParams.OutputAssembly = "output.exe";

            CompilerResults compResults = csProv.CompileAssemblyFromSource(csParams, macroCode);

            if (compResults.Errors.Count > 0) foreach (var er in compResults.Errors) System.Windows.Forms.MessageBox.Show(er.ToString());
            else Process.Start("output.exe", "-command");
        }
    }
}
