using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    class StoneMonkey:Monkey,IChange
    {
        public StoneMonkey() : base()
        {
        }

        public StoneMonkey(string inputName) : base(inputName)
        {
        }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有七十二变，我可变成： " + thing;
        }
    }
}
