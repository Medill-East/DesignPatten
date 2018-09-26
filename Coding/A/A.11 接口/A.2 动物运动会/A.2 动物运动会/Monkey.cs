using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Monkey : Animal
    {
        public Monkey() : base()
        {
        }


        public Monkey(string inputName) : base(inputName)
        {
        }

        protected override string getShoutSound()
        {
            return "噢";
        }
    }
}
