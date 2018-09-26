using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._2_动物运动会
{
    abstract class Animal
    {
        /// <summary>
        /// 字段
        /// </summary>
        protected string name = "";
        protected int shoutNum = 3;

        /// <summary>
        /// 属性
        /// </summary>
        public int ShoutNum
        {
            get { return shoutNum; }    //可调用
            set
            {
                if (value <= 10)
                {
                    shoutNum = value;
                }
                else
                {
                    shoutNum = 10;
                }
            }   //可赋值
        }

        public Animal()
        {
            this.name = "no one";
        }


        public Animal(string inputName)
        {
            this.name = inputName;
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += getShoutSound() + "~";
            }
            return "I'm " + name + " " + result;
        }

        protected abstract string getShoutSound();



    }
}
