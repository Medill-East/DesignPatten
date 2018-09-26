using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class Cattle:Animal
    {
        public Cattle() : base()
        {
        }


        public Cattle(string inputName) : base(inputName)
        {
        }

        protected override string getShoutSound()
        {
            return "哞";
        }
    }
}
