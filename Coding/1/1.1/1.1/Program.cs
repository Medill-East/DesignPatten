using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("请输入数字A：");
            string A = Console.ReadLine();
            Console.Write("请选择运算符号(+、-、*、/):");
            string B = Console.ReadLine();
            Console.Write("请输入数字B：");
            string C = Console.ReadLine();
            string D = "";

            if(B == "+")
            {
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            }
            if (B == "-")
            {
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            }
            if (B == "*")
            {
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            }
            if (B == "/")
            {
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            }

            Console.WriteLine("结果是：" + D);
        }
    }
}
