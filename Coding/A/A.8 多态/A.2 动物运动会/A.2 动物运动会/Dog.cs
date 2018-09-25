using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Dog : Animal
    {
        public Dog() : base()
        {
        }


        public Dog(string inputName) : base(inputName)
        {
        }

        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "旺！ ";
            }
            return "I'm " + name + " 旺！" + result;
        }
    }
}
