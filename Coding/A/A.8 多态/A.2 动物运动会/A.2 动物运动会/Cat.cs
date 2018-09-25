using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Cat:Animal
    {

        public Cat():base()
        {
        }


        public Cat(string inputName) : base(inputName)
        {
        }

        public override string Shout()
        {
            string result = "";
            for(int i=0;i<shoutNum;i++)
            {
                result += "喵~ ";
            }
            return "I'm " + name + " 喵~" + result;
        }
    }
}
