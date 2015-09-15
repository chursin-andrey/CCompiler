namespace MathLang
{
  public class ParserBase
  {
    // ���������� ������� �� ���������
    public const string DEFAULT_WHITESPACES = " \n\r\t";


    // ����������� ������
    private string source = null;
    // ������� ���������
    private int pos = 0;


    public ParserBase(string source) {
      this.source = source;
    }


    public string Source {
      get {
        return source;
      }
    }

    public int Pos {
      get {
        return pos;
      }
    }


    // ������������� ������������� ������ ��������� �� ������� �������;
    // � ���� ������ ���������� (char)0, ��� �������� ����� ������� ������
    protected char this[int index] {
      get {
        return index < source.Length ? source[index] : (char)0;
      }
    }

    // ������ � ������� ������� ���������
    public char Current {
      get {
        return this[Pos];
      }
    }

    // ����������, ��������� �� ����� ������
    public bool End {
      get {
        return Current == 0;
      }
    }

    // ����������� ��������� �� ���� ������
    public void Next() {
      if (!End)
        pos++;
    }

    // ���������� ���������� (����������) �������
    public virtual void Skip() {
      while (DEFAULT_WHITESPACES.IndexOf(this[pos])>=0)
        Next();
    }


    // ���������� ���� �� �����;
    // ��� ���� ��������� ��������� � ������������ ���������� �������;
    // ���� �� ���� �� ����� ���������� ������, �� ������������ null
    protected string MatchNoExcept(params string[] a) {
      int pos = Pos;
      foreach (string s in a) {
        bool match = true;
        foreach (char c in s)
          if (Current == c)
            Next();
          else {
            this.pos = pos;
            match = false;
            break;
          }
        if (match) {
          Skip();
          return s;
        }
      }
      return null;
    }


    // ���������, ����� �� � ������� ������� ���������, ���������� ���� �� �����;
    // ��������� �� ���������;
    public bool IsMatch(params string[] a) {
      int pos = Pos;
      string result = MatchNoExcept(a);
      this.pos = pos;
      return result != null;
    }


    // ���������� ���� �� �����;
    // ��� ���� ��������� ��������� � ������������ ���������� �������;
    // ���� �� ���� �� ����� ���������� ������, �� ������������� ����������
    public string Match(params string[] a) {
      int pos = Pos;
      string result = MatchNoExcept(a);
      if (result == null) {
        string message = "��������� ���� �� �����: ";
        bool first = true;
        foreach (string s in a) {
          if (!first)
            message += ", ";
          message += string.Format("\"{0}\"", s);
          first = false;
        }
        throw new ParserBaseException(string.Format("{0} (pos={1})", message, pos));
      }
      return result;
    }

    // �� ��, ��� � Match(params string[] a), ��� ��������
    public string Match(string s) {
      int pos = Pos;
      try {
        return Match(new string[] { s });
      }
      catch {
        throw new ParserBaseException(s.Length == 1 ? string.Format("�������� ������: '{0}' (pos={1})", s, pos)
                                                    : string.Format("��������� ������: \"{0}\" (pos={1})", s, pos));
      }
    }
  }
}
