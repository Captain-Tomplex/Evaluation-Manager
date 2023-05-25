using Shparfin.Models;
using Shparfin.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shparfin
{
    public partial class FrmTroskovi : Form
    {
        public FrmTroskovi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

        private void FrmTroskovi_Load(object sender, EventArgs e)
        {
            ShowKategorije();
            ShowTroskove();
            

            dgvTrosak.Columns["IdKategorijaTrosak"].DisplayIndex = 0;
            dgvTrosak.Columns["IdKategorijaTrosak"].HeaderText = "Šifra";
            dgvTrosak.Columns["IdTrosak"].Visible = false;
            dgvTrosak.Columns["Komentar"].DisplayIndex = 1;
            dgvTrosak.Columns["Iznos"].DisplayIndex = 2;
            dgvTrosak.Columns["Datum"].DisplayIndex = 3;


        }


        private void ShowTroskove()
        {
            List<Trosak> troskovi = TrosakRepository.GetTroskove();
            dgvTrosak.DataSource = troskovi;
        }

        private void ShowKategorije()
        {
            List<KategorijaTrosak> kategorije = KategorijaRepository.GetKategorije();
            dgvTrosak.DataSource = kategorije;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
