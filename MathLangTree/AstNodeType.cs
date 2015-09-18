namespace MathLang
{
  public class AstNodeType
  {
    public const int UNKNOWN = 0;

    public const int NUMBER  = 1;
    public const int IDENT     = 5;

    public const int ADD     = 11;
    public const int SUB     = 12;
    public const int MUL     = 13;
    public const int DIV     = 14;

    public const int ASSIGN  = 51;
    public const int INPUT   = 52;
    public const int PRINT   = 53;

    public const int IF = 54;
    public const int THEN = 55;
    public const int ELSE = 56;
    public const int WHILE = 57;


    public const int BLOCK   = 100;
    public const int PROGRAM = 101;


    public static string AstNodeTypeToString(int type) {
      switch(type) {
        case UNKNOWN:
          return "?";
        case NUMBER:
          return "NUM";
        case IDENT:
          return "ID";
        case ADD:
          return "+";
        case SUB:
          return "-";
        case MUL:
          return "*";
        case DIV:
          return "/";
        case ASSIGN:
          return "=";
        case INPUT:
          return "input";
        case PRINT:
          return "print";
        case BLOCK:
          return "..";
        case PROGRAM:
          return "program";
        case IF:
          return "if";
        case THEN:
          return "then";
        case ELSE:
          return "else";
        case WHILE:
          return "while";
        default:
          return "";
      }
    }
  }
}
