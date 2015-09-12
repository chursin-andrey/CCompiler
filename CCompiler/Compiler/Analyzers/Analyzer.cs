using CCompiler.Compiler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCompiler.Compiler.Analyzers
{
    public abstract class Analyzer
    {
        public void Analyses(string filePath)
        {
            throw new NotImplementedException();
        }

        public void GenerateCompilerException(String message)
        {
            throw new CompilerException(message);
        }

        public void GenerateCompilerException(int line, int position, String message)
        {
            throw new CompilerException(line, position, message);
        }
    }
}
