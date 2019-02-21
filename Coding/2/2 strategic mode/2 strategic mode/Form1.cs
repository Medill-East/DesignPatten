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

        private void 商场收银系统_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "正常收费","打八折","打七折","打五折" });
            cbxType.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalPrices = 0d;
            switch (cbxType.SelectedIndex)
            {
                case 0:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
                    break;
                case 1:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
                    break;
                case 2:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
                    break;
                case 3:
                    totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.5;
                    break;
                default:
                    break;
            }

            //double totalPrice = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);

            total = total + totalPrices;

            lbxList.Items.Add("单价： " + txtPrice.Text + " 数量： "
                + txtNum.Text + " 合计： " + totalPrices.ToString());
            lblResult.Text = total.ToString();
        }


    }
}
