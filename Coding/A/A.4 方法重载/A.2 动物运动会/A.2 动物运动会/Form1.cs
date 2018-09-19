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
        public Form1()
        {
            InitializeComponent();
        }

        private void 猫叫_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("nekopara");
            MessageBox.Show(cat.Shout());

        }
    }
}
