using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleC.Tree
{
    using SimpleC.Interpreter;
    public class StringNode : IExprNode
    {
        public StringNode(string stringValue)
        {
            _stringValue = stringValue;
        }

        public String StringValue { get { return _stringValue; } }
        public Int32 IntValue { get { return _intValue; } }

        public void Evaluate(Scope parentScope)
        {
            // Really nothing to do here
        }

        public void Print(string indent)
        {
            Console.WriteLine(indent + StringValue.ToString());
        }

        protected String _stringValue;

        protected Int32 _intValue;
    }
}
