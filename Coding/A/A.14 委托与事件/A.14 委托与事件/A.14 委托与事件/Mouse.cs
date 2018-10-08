using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._14_委托与事件
{
    class Mouse
    {
        private string name;

        public Mouse(string inputName)
        {
            name = inputName;
        }

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine($"Nico {args.Name} 来了，{name}快跑！");
        }

    }


}
