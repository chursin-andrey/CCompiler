using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCompiler.Compiler;

namespace CCompiler
{
    class CCompiler
    {
        static void Main(string[] args)
        {
            if (!ArgumentValidation(args))
            {
                return;
            }

            String inputFilename = args[0];
            String outputFilename = args[1];

            CompilerManager compiler = CompilerManager.Initialize();
            compiler.Compilation(inputFilename, outputFilename);
        }

        static bool ArgumentValidation(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please enter the two parameters (incoming file to compile and output file name)");
                return false;
            }
            return true;
        }
    }
}
