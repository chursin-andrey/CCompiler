using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;
using MathExpr;


namespace MathLang
{
  public class Program
  {
    // "культуронезависимый" формат для чисел (с разделителем точкой)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();

    public static AstNode Check(string src, Context context)
    {
        ICharStream input = new ANTLRStringStream(src);
        CCompilerLexer lexer = new CCompilerLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        CCompilerParser parser = new CCompilerParser(tokens);
        parser.TreeAdaptor = new AstNodeTreeAdapter();
        AstNode program = (AstNode)parser.execute().Tree;
        MathLangIntepreter.Check((AstNode)program, context);
        return program;
    }

    public static void Main(string[] args) {
      try {
        Context context = new Context(null);
        // в зависимости от наличия параметров командной строки разбираем
        // либо файл с именем, переданным первым параметром, либо стандартный ввод
        ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                             : (ICharStream)new ANTLRReaderStream(Console.In);
        CCompilerLexer lexer = new CCompilerLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        CCompilerParser parser = new CCompilerParser(tokens);
        parser.TreeAdaptor = new AstNodeTreeAdapter();
        ITree program = (ITree)parser.execute().Tree;
        AstNodePrinter.Print(program);
        Console.WriteLine();
        //MathLangIntepreter.Execute(program);
        MathLangIntepreter.Check((AstNode)program, context);

      }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
      }
      Console.ReadLine();
    }
  }
}
