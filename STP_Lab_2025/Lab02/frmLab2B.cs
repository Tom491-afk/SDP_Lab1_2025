using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace STP_Lab_2025.Lab02
{
    public partial class frmLab2B : Form
    {
     
        public frmLab2B()
        {
            InitializeComponent();
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            label2.Text = "It’s going to be a cloudy day today, " + textBox1.Text + ".";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            label2.Text = "It’s going to be a rainy day today, " + textBox1.Text + ".";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSunny.Visible = false;
            label2.Text = "It’s going to be a snowy day today, " + textBox1.Text + ".";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pic1.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = true;
            label2.Text = "It’s going to be a sunny day today, " + textBox1.Text + ".";
        }


    }
}
