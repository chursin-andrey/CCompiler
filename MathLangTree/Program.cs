using System;
using System.IO;


namespace MathLang
{
  public class Program
  {
    static void Main(string[] args) {
      // в зависимости от наличия параметров командной строки разбираем
      // либо файл с именем, переданным первым параметром, либо стандартный ввод
      TextReader reader = args.Length >= 1 ? new StreamReader(args[0])
                                           : Console.In;
      String source = reader.ReadToEnd();
      try {
        AstNode program = MathLangParser.Parse(source);
        AstNodePrinter.Print(program);
        Console.WriteLine("------------------------");
        //MathLangIntepreter.Execute(program);
      }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
      }

      Console.ReadLine();
    }
  }
}
