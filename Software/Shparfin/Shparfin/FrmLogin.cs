using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shparfin
{
    public partial class FrmLogin : Form
    {
        string pin = "2132";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == "")
            {
                MessageBox.Show("Pin nije unesen!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else
            {
                if (txtPin.Text == pin)
                {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmPrikaz frmTroskovi = new FrmPrikaz();
                    Hide();
                    frmTroskovi.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi pin unesen!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
