using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Sheep:Animal
    {
        public Sheep() : base()
        {
        }


        public Sheep(string inputName) : base(inputName)
        {
        }

        public override string getShoutSound()
        {
            return "咩";
        }
    }
}
