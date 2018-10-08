using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._14_委托与事件
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            cat.CatShout += new Cat.CatShoutEventHandler(mouse1.Run);
            cat.CatShout += new Cat.CatShoutEventHandler(mouse2.Run);

            cat.Shout();

            Console.Read();
        }
    }
}
