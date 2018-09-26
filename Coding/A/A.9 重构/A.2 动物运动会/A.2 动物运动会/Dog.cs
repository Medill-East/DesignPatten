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

        public override string getShoutSound()
        {
            return " 旺！";
        }
    }
}
