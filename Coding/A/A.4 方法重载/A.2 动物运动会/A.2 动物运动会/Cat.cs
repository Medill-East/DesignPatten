using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Cat
    {
        private string name = "";

        public Cat()
        {
            this.name = "no one";
        }


        public Cat(string inputName)
        {
            this.name = inputName;
        }

        public string Shout()
        {
            return "I'm " + name + " 喵~";
        }
    }
}
