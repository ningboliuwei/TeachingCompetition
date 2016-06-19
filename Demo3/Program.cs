using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("请输入数字 A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入数字 B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());

            Operation add = new OperationAdd();
            double result1 = add.GetResult(numberA, numberB);

            Operation sub = new OperationSub();
            double result2 = sub.GetResult(numberA, numberB);

            Operation mul = new OperationMul();
            double result3 = mul.GetResult(numberA, numberB);

            Operation div = new OperationDiv();
            double result4 = div.GetResult(numberA, numberB);

            Console.WriteLine("运算结果是: " + result1);
            Console.ReadLine();
        }
	}
}
