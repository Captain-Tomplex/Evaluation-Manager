namespace Shparfin
{
    partial class FrmAzurirajTrosak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAzurirajForma = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblPodkategorija = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.cboPodkategorija = new System.Windows.Forms.ComboBox();
            this.cboKategorija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAzurirajForma
            // 
            this.btnAzurirajForma.Location = new System.Drawing.Point(99, 373);
            this.btnAzurirajForma.Name = "btnAzurirajForma";
            this.btnAzurirajForma.Size = new System.Drawing.Size(88, 23);
            this.btnAzurirajForma.TabIndex = 21;
            this.btnAzurirajForma.Text = "Ažuriraj Trošak";
            this.btnAzurirajForma.UseVisualStyleBackColor = true;
            this.btnAzurirajForma.Click += new System.EventHandler(this.btnAzurirajForma_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(114, 302);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 20;
            this.lblDatum.Text = "Datum";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(120, 246);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(32, 13);
            this.lblIznos.TabIndex = 19;
            this.lblIznos.Text = "Iznos";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(111, 188);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(52, 13);
            this.lblKomentar.TabIndex = 18;
            this.lblKomentar.Text = "Komentar";
            // 
            // lblPodkategorija
            // 
            this.lblPodkategorija.AutoSize = true;
            this.lblPodkategorija.Location = new System.Drawing.Point(107, 122);
            this.lblPodkategorija.Name = "lblPodkategorija";
            this.lblPodkategorija.Size = new System.Drawing.Size(72, 13);
            this.lblPodkategorija.TabIndex = 17;
            this.lblPodkategorija.Text = "Podkategorija";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(111, 54);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 16;
            this.lblKategorija.Text = "Kategorija";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatum.Location = new System.Drawing.Point(82, 318);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(121, 20);
            this.dtpDatum.TabIndex = 15;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(82, 262);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(121, 20);
            this.txtIznos.TabIndex = 14;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(82, 204);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(121, 20);
            this.txtKomentar.TabIndex = 13;
            // 
            // cboPodkategorija
            // 
            this.cboPodkategorija.FormattingEnabled = true;
            this.cboPodkategorija.Location = new System.Drawing.Point(82, 138);
            this.cboPodkategorija.Name = "cboPodkategorija";
            this.cboPodkategorija.Size = new System.Drawing.Size(121, 21);
            this.cboPodkategorija.TabIndex = 12;
            // 
            // cboKategorija
            // 
            this.cboKategorija.FormattingEnabled = true;
            this.cboKategorija.Location = new System.Drawing.Point(82, 70);
            this.cboKategorija.Name = "cboKategorija";
            this.cboKategorija.Size = new System.Drawing.Size(121, 21);
            this.cboKategorija.TabIndex = 11;
            // 
            // FrmAzurirajTrosak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.btnAzurirajForma);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblPodkategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.cboPodkategorija);
            this.Controls.Add(this.cboKategorija);
            this.Name = "FrmAzurirajTrosak";
            this.Text = "Ažuriranje troška";
            this.Load += new System.EventHandler(this.FrmAzurirajTrosak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajForma;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblPodkategorija;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.ComboBox cboPodkategorija;
        private System.Windows.Forms.ComboBox cboKategorija;
    }
}