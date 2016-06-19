using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("请输入数字 A: ");
			double numberA = Convert.ToDouble(Console.ReadLine());
			Console.Write("请选择运算符号(+ - * /): ");
			string oper = Console.ReadLine();
			Console.Write("请输入数字 B: ");
			double numberB = Convert.ToDouble(Console.ReadLine());

			Operation operation = OperationFactory.CreateOperation(oper);
			double result = operation.GetResult(numberA, numberB);

			Console.WriteLine("运算结果是: " + result);
			Console.ReadLine();
		}
	}
}
