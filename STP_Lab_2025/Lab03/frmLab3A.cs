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
    public partial class frmLab3A : Form
    {
        public frmLab3A()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult;
            DialogResult = MessageBox.Show($"You voted for \n{cboMovie.SelectedItem.ToString()}",
               "Vote Movie", MessageBoxButtons.YesNoCancel);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"You voted for \n{cboMovie.SelectedItem.ToString()}");
            }
            else if (DialogResult == DialogResult.No)
            {
                MessageBox.Show($"Cancel voting.");

            }
        }
    }
}