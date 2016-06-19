using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
	class OperationFactory
	{
		public static Operation CreateOperation(string oper)
		{
			switch (oper)
			{
				case "+":
					return new OperationAdd();
				case "-":
					return new OperationSub();
				case "*":
					return new OperationMul();
				case "/":
					return new OperationDiv();
				default:
					return null;
			}
		}
	}
}
