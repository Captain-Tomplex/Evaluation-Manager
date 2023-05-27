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
    public partial class FrmDodajTrosak : Form
    {
        private string komentar;
        private string iznos;
        private DateTime datum;
        private int idPodKategorijaTrosak;
        private int idKategorijaTrosak;

        public FrmDodajTrosak()
        {
            InitializeComponent();
            List<KategorijaTrosak> categories = KategorijaTrosakRepository.GetKategorije().ToList();
            cboKategorija.DataSource = categories;
            cboKategorija.DisplayMember = "Naziv";
            cboKategorija.ValueMember = "IDKategorijaTrosak";
        }


        private void btnDodajForma_Click(object sender, EventArgs e)
        {
            komentar = txtKomentar.Text;
            iznos = txtIznos.Text;
            datum = dtpDatum.Value;
           // idPodKategorijaTrosak = (int)cboPodkategorija.SelectedValue;
            idKategorijaTrosak = (int)cboKategorija.SelectedValue;

            // Call the InsertTrosak method from TrosakRepository
            TrosakRepository.InsertTrosak(komentar, iznos, datum, idPodKategorijaTrosak, idKategorijaTrosak);

            // Close the form or perform additional actions as needed
            this.Close();

        }
    }
}
