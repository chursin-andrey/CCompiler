using System.Collections.Generic;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathLang
{
  public class MathAstNode: CommonTree
  {
    public MathAstNode()
      : base() {
    }

    public MathAstNode(IToken t)
      : base(t) {
    }

    public MathAstNode(CommonTree node)
      : base(node) {
    }
  }
}
