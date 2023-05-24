using Shparfin.Models;
using Shparfin.Repositories;
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
            ShowTroskove();
        }

        private void ShowTroskove()
        {
            List<Trosak> troskovi = TrosakRepository.GetTroskove();
            dgvTrosak.DataSource = troskovi;
        }
    }
}
