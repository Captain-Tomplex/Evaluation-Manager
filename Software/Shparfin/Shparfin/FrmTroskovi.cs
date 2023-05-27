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


            dgvTrosak.Columns["IdTrosak"].Visible = false;
            dgvTrosak.Columns["Komentar"].DisplayIndex = 3;
            dgvTrosak.Columns["Iznos"].DisplayIndex = 4;
            dgvTrosak.Columns["Iznos"].HeaderText = "Iznos (kn)";
            dgvTrosak.Columns["Datum"].DisplayIndex = 5;
            dgvTrosak.Columns["IdPodKategorijaTrosak"].DisplayIndex = 1;
            dgvTrosak.Columns["IDPodKategorijaTrosak"].HeaderText = "Šifra pod kategorije";
            dgvTrosak.Columns["IdKorisnik"].Visible = false;
            dgvTrosak.Columns["IDKategorijaTrosak"].DisplayIndex = 0;
            dgvTrosak.Columns["IDKategorijaTrosak"].HeaderText = "Šifra kategorije";


        }

        private void btnDodajTrosak_Click(object sender, EventArgs e)
        {
            FrmDodajTrosak frmDodajTrosak = new FrmDodajTrosak();
            frmDodajTrosak.ShowDialog();

        }

        



        private void Pretraga()
        {
            string trazeno = txtPretraga.Text.Trim();

            List<Trosak> trazeniTrosak = TrosakRepository.GetTroskove()
                .Where(trag => trag.Komentar.Contains(trazeno)).ToList();

            dgvTrosak.DataSource = trazeniTrosak;
        }

        private void btnIzbrisiTrosak_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati odabrani trošak?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvTrosak.SelectedRows.Count > 0)
                {
                    Trosak selectedTrosak = dgvTrosak.SelectedRows[0].DataBoundItem as Trosak;

                    TrosakRepository.DeleteTrosak(selectedTrosak);

                    dgvTrosak.DataSource = null;
                    ShowTroskove();
                }

                else
                {
                    MessageBox.Show("Niste odabrali trošak!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPretraga_Click_1(object sender, EventArgs e)
        {
            {
                Pretraga();

                
                dgvTrosak.Columns["IdTrosak"].Visible = false;
                dgvTrosak.Columns["Komentar"].DisplayIndex = 3;
                dgvTrosak.Columns["Iznos"].DisplayIndex = 4;
                dgvTrosak.Columns["Iznos"].HeaderText = "Iznos (kn)";
                dgvTrosak.Columns["Datum"].DisplayIndex = 5;
                dgvTrosak.Columns["IdPodKategorijaTrosak"].DisplayIndex = 1;
                dgvTrosak.Columns["IDPodKategorijaTrosak"].HeaderText = "Šifra pod kategorije";
                dgvTrosak.Columns["IdKorisnik"].Visible = false;
                dgvTrosak.Columns["IDKategorijaTrosak"].DisplayIndex = 0;
                dgvTrosak.Columns["IDKategorijaTrosak"].HeaderText = "Šifra kategorije";
            }
        }

        private void btnIzbrisiTrosak_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite izbrisati odabrani trošak?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvTrosak.SelectedRows.Count > 0)
                {
                    Trosak selectedTrosak = dgvTrosak.SelectedRows[0].DataBoundItem as Trosak;

                    TrosakRepository.DeleteTrosak(selectedTrosak);

                    dgvTrosak.DataSource = null;
                    ShowTroskove();
                }

                else
                {
                    MessageBox.Show("Niste odabrali trošak!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAzurirajTrosak_Click(object sender, EventArgs e)
        {
            Trosak updatedTrosak = dgvTrosak.CurrentRow.DataBoundItem as Trosak;   
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // Create an instance of FrmDodajTrosak
            FrmDodajTrosak frmDodajTrosak = new FrmDodajTrosak();

            // Display the FrmDodajTrosak form
            frmDodajTrosak.Show();
        }
    }
}