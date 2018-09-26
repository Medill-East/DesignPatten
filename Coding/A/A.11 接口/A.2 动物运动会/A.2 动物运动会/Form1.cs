using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A._2_动物运动会
{
    public partial class Form1 : Form
    {
        private Animal[] arrayAnimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void 猫叫_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("nekopara");
            cat.ShoutNum = 5;
            MessageBox.Show(cat.Shout());

        }

        private void 狗叫_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.ShoutNum = 5;
            MessageBox.Show(dog.Shout());
        }

        private void 动物报名_Click(object sender, EventArgs e)
        {
            arrayAnimal = new Animal[5];

            arrayAnimal[0] = new Cat("neko ichi");
            arrayAnimal[1] = new Dog("inu ichi");
            arrayAnimal[2] = new Dog("inu ni");
            arrayAnimal[3] = new Cat("neko ni");
            arrayAnimal[4] = new Cat("neko san");
        }

        private void 叫声比赛_Click(object sender, EventArgs e)
        {
            foreach (Animal item in arrayAnimal)
            {
                MessageBox.Show(item.Shout());
            }
        }

        private void 变_Click(object sender, EventArgs e)
        {
            MachineCat mcat = new MachineCat("叮当");
            StoneMonkey wukong = new StoneMonkey("孙悟空");
            SkyPig bajie = new SkyPig("八戒");

            IChange[] array = new IChange[3];
            array[0] = mcat;
            array[1] = wukong;
            array[2] = bajie;

            MessageBox.Show(array[0].ChangeThing("各种各样的东西！"));
            MessageBox.Show(array[1].ChangeThing("各种各样的东西！"));
            MessageBox.Show(array[2].ChangeThing("各种各样的东西！"));

        }
    }
}
