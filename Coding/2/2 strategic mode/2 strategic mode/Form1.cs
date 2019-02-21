using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_strategic_mode
{
    public partial class 商场收银系统 : Form
    {
        double total = 0.0d;

        public 商场收银系统()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalPrice = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);

            total = total + totalPrice;

            lbxList.Items.Add("单价： " + txtPrice.Text + " 数量： "
                + txtNum.Text + " 合计： " + totalPrice.ToString());
            lblResult.Text = total.ToString();
        }
    }
}
