using System;
using System.Globalization;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace SimpleC
{
    public class Program
    {
        // "êóëüòóðîíåçàâèñèìûé" ôîðìàò äëÿ ÷èñåë (ñ ðàçäåëèòåëåì òî÷êîé)
        public static readonly NumberFormatInfo NFI = new NumberFormatInfo();


        public static void Main(string[] args)
        {
            try
            {
                // â çàâèñèìîñòè îò íàëè÷èÿ ïàðàìåòðîâ êîìàíäíîé ñòðîêè ðàçáèðàåì
                // ëèáî ôàéë ñ èìåíåì, ïåðåäàííûì ïåðâûì ïàðàìåòðîì, ëèáî ñòàíäàðòíûé ââîä
                ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                                     : (ICharStream)new ANTLRReaderStream(Console.In);
                Grammar.SimpleCLexer lexer = new Grammar.SimpleCLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                Grammar.SimpleCParser parser = new Grammar.SimpleCParser(tokens);
                ITree program = (ITree)parser.program().Tree;
                AstNodePrinter.Print(program);
                Console.WriteLine();
                SemanticChecker.Execute(program);

                CommonTreeNodeStream nodeStream = new CommonTreeNodeStream(program);

                Grammar.SimpleCTreeWalker treeWalker = new Grammar.SimpleCTreeWalker(nodeStream);
                Tree.RootNode rootNode = treeWalker.walk();

#if false
				if (rootNode == null)
					Console.WriteLine("NULL");
				else
					rootNode.Print();
#else
                Interpreter.Interpreter.Shared.Prepare(rootNode);
                Interpreter.Interpreter.Shared.Run();
#endif
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
        }
    }
}