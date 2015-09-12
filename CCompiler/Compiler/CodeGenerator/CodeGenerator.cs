using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCompiler.Compiler.CodeGenerator
{
    public class CodeGenerator
    {
        private static CodeGenerator INSTANSE = new CodeGenerator();

        public CodeGenerator()
        {

        }

        public static CodeGenerator Initialize()
        {
            return INSTANSE;
        }

        public void Generate(String inputFile, String outputFile)
        {
            throw new NotImplementedException("Method [CodeGenerator.Generate] is not implemented!");
        }

    }
}
