using Shparfin.Models;
using Shparfin.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Shparfin
{
    public partial class FrmDodajTrosak : Form
    {
        private string komentar;
        private int iznos;
        private DateTime datum;
        private int idPodKategorijaTrosak;
        private int idKategorijaTrosak;

        public FrmDodajTrosak()
        {
            InitializeComponent();
            DisplayKategorije();
            DisplayPodkategorije();
        }

        private void DisplayKategorije()
        {
            List<KategorijaTrosak> kategorije = KategorijaTrosakRepository.GetKategorije().ToList();
            cboKategorija.DataSource = kategorije;
            cboKategorija.DisplayMember = "Naziv";
            cboKategorija.ValueMember = "IDKategorijaTrosak";
        }

        private void DisplayPodkategorije()
        {
            List<PodKategorijaTrosak> podkategorije = PodKategorijaTrosakRepository.GetPodKategorije().ToList();
            cboPodkategorija.DataSource = podkategorije;
            cboPodkategorija.DisplayMember = "Naziv";
            cboPodkategorija.ValueMember = "IDPodKategorijaTrosak";
        }

        private void btnDodajForma_Click(object sender, EventArgs e)
        {


            komentar = txtKomentar.Text;
            try
            {
                iznos = int.Parse(txtIznos.Text);

                datum = DateTime.Parse(dtpDatum.Value.ToString());
                idPodKategorijaTrosak = (int)cboPodkategorija.SelectedValue;
                idKategorijaTrosak = (int)cboKategorija.SelectedValue;

                TrosakRepository.InsertTrosak(komentar, iznos.ToString(), datum, idPodKategorijaTrosak, idKategorijaTrosak);



                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Krivo unesen iznos!");
            }
            
            
            

        }

     
    }
}
