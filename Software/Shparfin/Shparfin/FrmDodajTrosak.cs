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
        private string iznos;
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
            iznos = txtIznos.Text;
            
            datum = DateTime.Parse(dtpDatum.Value.ToString());
            idPodKategorijaTrosak = (int)cboPodkategorija.SelectedValue;
            idKategorijaTrosak = (int)cboKategorija.SelectedValue;

            // Call the InsertTrosak method from TrosakRepository
            TrosakRepository.InsertTrosak(komentar, iznos, datum, idPodKategorijaTrosak, idKategorijaTrosak);

            // Close the form or perform additional actions as needed
            this.Close();

        }

        

        /* private List<PodKategorijaTrosak> GetAllowedPodkategorije(int selectedKategorijaId)
         {
             List<PodKategorijaTrosak> allowedPodkategorije = new List<PodKategorijaTrosak>();

             // Assuming you have a list of Podkategorija objects available, filter them based on the selected kategorija
             foreach (PodKategorijaTrosak podkategorija in PodKategorijaTrosak)
             {
                 if (selectedKategorijaId == 1 && (podkategorija.IdPodKategorijaTrosak == 11 || podkategorija.IdPodKategorijaTrosak == 12))
                 {
                     allowedPodkategorije.Add(podkategorija);
                 }
                 // Add other conditions for different kategorija values and their corresponding allowed podkategorije
                 else if (selectedKategorijaId == 2 && (podkategorija.IdPodKategorijaTrosak == 21 || podkategorija.IdPodKategorijaTrosak == 22))
                 {
                     allowedPodkategorije.Add(podkategorija);
                 }
                 // Add more conditions as needed for other kategorija values
             }

             return allowedPodkategorije;
         }
     */
    }
}
