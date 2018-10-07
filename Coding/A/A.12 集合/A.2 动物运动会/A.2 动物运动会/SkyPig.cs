using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class SkyPig : Pig, IChange
    {
        public SkyPig() : base()
        {
        }

        public SkyPig(string inputName) : base(inputName)
        {
        }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有三十六变，我可变成： " + thing;
        }
    }
}
