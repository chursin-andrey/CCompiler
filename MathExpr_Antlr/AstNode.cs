using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MathLang
{
    public class AstNode : CommonTree
    {
        public AstNode()
      : base() {
    }

    public AstNode(IToken t)
      : base(t) {
    }

    public AstNode(CommonTree node)
      : base(node) {
    }


    public DataType DataType { get; set; }


    public override string ToString()
    {
        string result = base.ToString();
        if (DataType != DataType.Void)
            result += ", " + MathLangIntepreter.DataTypeToStr(DataType);
        return result;
    }
  }


  public class AstNodeTreeAdapter: CommonTreeAdaptor
  {
      public override object Create(IToken payload)
      {
          return new AstNode(payload);
      }
  
    }
}
