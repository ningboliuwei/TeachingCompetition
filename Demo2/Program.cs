using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("请输入数字 A: ");
			double numberA = Convert.ToDouble(Console.ReadLine());
			Console.Write("请输入数字 B: ");
			double numberB = Convert.ToDouble(Console.ReadLine());

			OperationAdd add = new OperationAdd();
			double result = add.GetResult(numberA, numberB);

			Console.WriteLine("运算结果是: " + result);
			Console.ReadLine();
		}
	}
}
