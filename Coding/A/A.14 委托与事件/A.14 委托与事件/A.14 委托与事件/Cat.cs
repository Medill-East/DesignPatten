using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._14_委托与事件
{
    class Cat
    {
        private string name;

        public Cat(string inputName)
        {
            name = inputName;
        }

        public delegate void CatShoutEventHandler(object sender,CatShoutEventArgs args);

        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine($"喵~,我是{name}.");

            if (CatShout != null)
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = name;
                CatShout(this,e);
            }
        }
    }
}
