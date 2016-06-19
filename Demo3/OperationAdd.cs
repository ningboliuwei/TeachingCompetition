using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
	class OperationAdd : Operation
	{
		public override double GetResult(double numberA, double numberB)
		{
			return numberA + numberB;
		}
	}
}
