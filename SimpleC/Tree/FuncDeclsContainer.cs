using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SimpleC.Tree
{
	public static class FuncDeclsContainer
	{
		public static bool Contains(FuncDeclEquatable funcDeclEquatable)
		{
			foreach (FuncDeclNode decl in declarations_)
				if (decl.Equatable.Equals(funcDeclEquatable))
					return true;
			return false;
		}

		public static FuncDeclNode Get(FuncDeclEquatable funcDeclEquatable)
		{
			foreach (FuncDeclNode decl in declarations_)
				if (decl.Equatable.Equals(funcDeclEquatable))
					return decl;
			return null;
		}

		public static void Add(FuncDeclNode funcDecl)
		{
			Debug.Assert(funcDecl != null);
			FuncDeclNode previousDecl = Get(funcDecl.Equatable);
			if (previousDecl != null)
				declarations_.Remove(previousDecl);
			declarations_.Add(funcDecl);
		}

		public static void Clear()
		{
			declarations_.Clear();
		}

		public static List<FuncDeclNode> declarations_ = new List<FuncDeclNode>();
	}
}
