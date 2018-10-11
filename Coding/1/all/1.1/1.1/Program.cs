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
            try
            {
                Console.Write("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号(+、-、*、/):");
                string strOperation = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";

                Operation oper;
                oper = OperationFactory.createOperation(strOperation);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                double result = oper.GetResult();
                
                Console.WriteLine("结果是：" + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错：" + ex.Message);
            }

        }
    }
}
