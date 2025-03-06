using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STP_Lab_2025.Lab03
{
    public partial class frmLab3B : Form
    {
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int year = 0;
            double amount2 = 0;
            double amount = Convert.ToDouble(txtAmount.Text);
            double r = Convert.ToDouble(txtRate.Text);
            double value10 = amount * Math.Pow((1 + r), 10);
            while (amount2 < 1000000)
                {
                    amount2 = amount * Math.Pow((1 + r), year);
                    year++;
                }
            lblValue2.Text = value10.ToString();
            lblMillion2.Text = year.ToString();
        }
    }
}
