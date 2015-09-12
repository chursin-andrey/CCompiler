using CCompiler.Compiler.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCompiler.Compiler
{
    public class CompilerManager
    {
        private static CompilerManager INSTANSE = new CompilerManager();

        public CompilerManager()
        {

        }

        public static CompilerManager Initialize()
        {
            return CompilerManager.INSTANSE;
        }
        
        /// <summary>
        /// Compilation file 
        /// </summary>
        /// <param name="inputFilepath">Input file with code</param>
        /// <param name="outputFilepath">Output file after code generation</param>
        public void Compilation(String inputFilepath, String outputFilepath)
        {
            try
            {
                SyntacticAnalysis(inputFilepath);
                SemanticAnalysis(inputFilepath);
                CodeGeneration(inputFilepath, outputFilepath);
            }
            catch (CompilerException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void SyntacticAnalysis(String filepath)
        {
            // TODO
            throw new CompilerException("Method [Compiler.SyntacticAnalysis] is not implemented!");
        }

        private void SemanticAnalysis(String filepath)
        {
            // TODO
            throw new CompilerException("Method [Compiler.SemanticAnalysis] is not implemented!");
        }


        private void CodeGeneration(String inputFilepath, String outputFilepath)
        {
            // TODO
            throw new CompilerException("Method [Compiler.CodeGeneration] is not implemented!");
        }
        
    }
}
