using System.Collections.Generic;


namespace MathLang
{
  public class AstNode
  {
    public virtual int Type { get; set; }
    public virtual string Text { get; set; }

    private AstNode parent = null;
    private IList<AstNode> childs = new List<AstNode>();


    public AstNode(int type, string text, AstNode child1, AstNode child2) {
      Type = type;
      Text = text;
      if(child1 != null)
        AddChild(child1);
      if(child2 != null)
        AddChild(child2);
    }

    public AstNode(int type, AstNode child1, AstNode child2)
      : this(type, null, child1, child2) {      
    }

    public AstNode(int type, AstNode child1)
      : this(type, child1, null) {
    }

    public AstNode(int type, string label)
      : this(type, label, null, null) {
    }    

    public AstNode(int type)
      : this(type, (string) null) {
    }


    public void AddChild(AstNode child) {
      if (child.Parent != null) {
        child.Parent.childs.Remove(child);
      }
      childs.Remove(child);
      childs.Add(child);
      child.parent = this;
    }


    public void RemoveChild(AstNode child) {
      childs.Remove(child);
      if (child.parent == this)
        child.parent = null;
    }


    public AstNode GetChild(int index) {
      return childs[index];
    }


    public int ChildCount {
      get {
        return childs.Count;
      }
    }


    public AstNode Parent {
      get {
        return parent;
      }
      set {
        value.AddChild(this);
      }
    }


    public int Index {
      get {
        return Parent == null ? -1
                              : Parent.childs.IndexOf(this);
      }
    }


    public override string ToString() {
      return Text != null ? Text
                           : AstNodeType.AstNodeTypeToString(Type);
    }
  }
}
