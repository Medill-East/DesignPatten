using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Pig : Animal
    {
        public Pig() : base()
        {
        }


        public Pig(string inputName) : base(inputName)
        {
        }

        protected override string getShoutSound()
        {
            return "呵";
        }
    }
}
