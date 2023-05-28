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
    public partial class FrmAzurirajTrosak : Form
    {
        public Trosak trosak;

        public List<KategorijaTrosak> kategorije;
        public List<PodKategorijaTrosak> podkategorije;
        public FrmAzurirajTrosak(Trosak trosak)
        {
            InitializeComponent();

            this.trosak = trosak;
        }

        private void DisplayKategorije()
        {
            kategorije = KategorijaTrosakRepository.GetKategorije().ToList();
            cboKategorija.DataSource = kategorije;
            cboKategorija.DisplayMember = "Naziv";
            cboKategorija.ValueMember = "IDKategorijaTrosak";
            
            int brojac = 0;

            foreach(KategorijaTrosak kat in kategorije )
            {
                if( kat.IdKategorijaTrosak == trosak.IdKategorijaTrosak)
                {
                    cboKategorija.SelectedIndex = brojac;
                }
                brojac++;
            }
        }

        private void DisplayPodkategorije()
        {
            podkategorije = PodKategorijaTrosakRepository.GetPodKategorije().ToList();
            cboPodkategorija.DataSource = podkategorije;
            cboPodkategorija.DisplayMember = "Naziv";
            cboPodkategorija.ValueMember = "IDPodKategorijaTrosak";

            int brojac = 0;

            foreach (PodKategorijaTrosak podkat in podkategorije)
            {
                if (podkat.IdPodKategorijaTrosak == trosak.IdPodKategorijaTrosak)
                {
                    cboPodkategorija.SelectedIndex = brojac;
                }
                brojac++;
            }
        }

        private void btnAzurirajForma_Click(object sender, EventArgs e)
        {

            Trosak azurirani = new Trosak();
            azurirani.IdTrosak = trosak.IdTrosak;

            KategorijaTrosak kategorija = new KategorijaTrosak();
            PodKategorijaTrosak podkategorija = new PodKategorijaTrosak();

            foreach (KategorijaTrosak kat in kategorije)
            {
                foreach(var item in cboKategorija.Items)
                {
                    if (cboKategorija.SelectedIndex == cboKategorija.Items.IndexOf(item))
                    {
                        kategorija = (KategorijaTrosak)item;
                    }                
                }
            }

            foreach (PodKategorijaTrosak podkat in podkategorije)
            {
                foreach (var item in cboPodkategorija.Items)
                {
                    if (cboPodkategorija.SelectedIndex == cboPodkategorija.Items.IndexOf(item))
                    {
                        podkategorija = (PodKategorijaTrosak)item;
                    }
                }
            }


            try
            {
                int iznos = int.Parse(txtIznos.Text);

                azurirani.IdKategorijaTrosak = kategorija.IdKategorijaTrosak;
                azurirani.IdPodKategorijaTrosak = podkategorija.IdPodKategorijaTrosak;
                azurirani.Komentar = txtKomentar.Text;
                azurirani.Iznos = iznos;
                azurirani.Datum = dtpDatum.Value;
                TrosakRepository.UpdateTrosak(azurirani);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Krivo unesen iznos!");
            }

            

        }

        private void FrmAzurirajTrosak_Load(object sender, EventArgs e)
        {
            DisplayKategorije();
            DisplayPodkategorije();
            txtKomentar.Text = trosak.Komentar;
            txtIznos.Text = trosak.Iznos.ToString();
            dtpDatum.Value = trosak.Datum;
        }
    }
}
