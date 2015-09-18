namespace MathLang
{
  public class MathLangParser: ParserBase
  {
    public MathLangParser(string source)
      : base(source) {
    }


    /*
      Грамматика языка для вычислений имеет вид:

        NUMBER  ->   <число>
        IDENT   ->   <идентификатор>
        group   ->   "("  term  ")"
                   | IDENT
                   | NUMBER
        mult    ->   group  ( ( "*" | "/" )  group )*
        add     ->   mult   ( ( "+" | "-" )  mult  )*
        term    ->   add
        expr    ->   "print"  term
                   | "input"  IDENT
                   | IDENT  "="  term
                   | "if" "(" add ")" then expr "else" expr
     *             | "while" "(" add ")" expr
        program ->   (  Expr  )*
        result  ->   program
    */


    // далее идут реализации в виде функций правил описанной грамматики


    /*  NUMBER  ->   <число>
    */
    public AstNode NUMBER() {
      string number = "";
      while (Current == '.' || char.IsDigit(Current)) {
        number += Current;
        Next();
      }
      if (number.Length == 0)
        throw new ParserBaseException(string.Format("Ожидалось число (pos={0})", Pos));
      Skip();

      return new AstNode(AstNodeType.NUMBER, number);
    }


    /*  IDENT   ->   <идентификатор>
    */
    public AstNode IDENT() {
      string identifier = "";
      if (char.IsLetter(Current)) {
        identifier += Current;
        Next();
        while (char.IsLetterOrDigit(Current)) {
          identifier += Current;
          Next();
        }
      }
      else
        throw new ParserBaseException(string.Format("Ожидался идентификатор (pos={0})", Pos));
      Skip();

      return new AstNode(AstNodeType.IDENT, identifier);
    }


    /*  group   ->   "("  term  ")"
                   | IDENT                    
                   | NUMBER
    */
    public AstNode Group() {
      if (IsMatch("(")) {
        Match("(");
        AstNode result = Term();
        Match(")");
        return result;
      }
      else if (char.IsLetter(Current)) {
        int pos = Pos;
        return IDENT();        
      }
      else
        return NUMBER();
    }


    /*  mult    ->   group  ( ( "*" | "/" )  group )*
    */
    public AstNode Mult() {
      AstNode result = Group();
      while (IsMatch("*", "/")) {
        string oper = Match("*", "/");
        AstNode temp = Group();
        result = oper == "*" ? new AstNode(AstNodeType.MUL, result, temp)
                             : new AstNode(AstNodeType.DIV, result, temp);
      }
      return result;
    }


    /*  add     ->   mult   ( ( "+" | "-" )  mult  )*
    */
    public AstNode Add() {
      AstNode result = Mult();
      while (IsMatch("+", "-")) {
        string oper = Match("+", "-");
        AstNode temp = Mult();
        result = oper == "+" ? new AstNode(AstNodeType.ADD, result, temp)
                             : new AstNode(AstNodeType.SUB, result, temp);
      }
      return result;
    }


    /*  term    ->   add
    */
    public AstNode Term() {
      return Add();
    }


    /* expr    ->   "print"  term
                   | "input"  IDENT
                   | IDENT  "="  term
                   | "if" "(" add ")" "then" expr "else" expr
                   | "while" "(" add ")" expr
    */
    public AstNode Expr() {
      if (IsMatch("print")) {
        Match("print");
        AstNode value = Term();
        return new AstNode(AstNodeType.PRINT, value);
      }
      else if (IsMatch("input")) {
        Match("input");
        AstNode identifier = IDENT();
        return new AstNode(AstNodeType.INPUT, identifier);
      }
      else if (IsMatch("if"))
      {
          Match("if");
          Match("(");
          AstNode ifNode = new AstNode(AstNodeType.IF, Term());
          Match(")");
          Match("then");
          ifNode.AddChild(Expr());
          if (IsMatch("else"))
          {
              Match("else");
              ifNode.AddChild(Expr());
          }
          return ifNode;
      }
      else if (IsMatch("while"))
      {
          Match("while");
          Match("(");
          AstNode whileNode = new AstNode(AstNodeType.WHILE, Term());
          Match(")");
          whileNode.AddChild(Expr());
          return whileNode;
      }
      else
      {
          AstNode identifier = IDENT();
          Match("=");
          AstNode value = Term();
          return new AstNode(AstNodeType.ASSIGN, identifier, value);
      }
    }


    /*  program ->   (  expr  )*
    */
    public AstNode Program() {
      AstNode programNode = new AstNode(AstNodeType.PROGRAM);
      while (!End)
        programNode.AddChild(Expr());
      return programNode;
    }


    /*  result  ->   program
    */
    public AstNode Result() {
      return Program();
    }


    public AstNode Parse() {
      Skip();
      AstNode result = Result();
      if (End)
        return result;
      else
        throw new ParserBaseException(string.Format("Лишний символ '{0}' (pos={1})", Current, Pos));
    }


    public static AstNode Parse(string source) {
      MathLangParser mlp = new MathLangParser(source);
      return mlp.Parse();
    }
  }
}
