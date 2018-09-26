using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class MachineCat : Cat, IChange
    {
        public MachineCat():base()
        {
        }

        public MachineCat(string inputName): base(inputName)
        {
        }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有万能口袋，我可变出： " + thing;
        }
    }
}
