namespace Shparfin
{
    partial class FrmDodajTrosak
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
            this.cboKategorija = new System.Windows.Forms.ComboBox();
            this.cboPodkategorija = new System.Windows.Forms.ComboBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblPodkategorija = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.btnDodajForma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboKategorija
            // 
            this.cboKategorija.FormattingEnabled = true;
            this.cboKategorija.Location = new System.Drawing.Point(98, 48);
            this.cboKategorija.Name = "cboKategorija";
            this.cboKategorija.Size = new System.Drawing.Size(121, 21);
            this.cboKategorija.TabIndex = 0;
            // 
            // cboPodkategorija
            // 
            this.cboPodkategorija.FormattingEnabled = true;
            this.cboPodkategorija.Location = new System.Drawing.Point(98, 116);
            this.cboPodkategorija.Name = "cboPodkategorija";
            this.cboPodkategorija.Size = new System.Drawing.Size(121, 21);
            this.cboPodkategorija.TabIndex = 1;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(98, 182);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(121, 20);
            this.txtKomentar.TabIndex = 2;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(98, 240);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(121, 20);
            this.txtIznos.TabIndex = 3;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(98, 296);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(121, 20);
            this.dtpDatum.TabIndex = 4;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(127, 32);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 5;
            this.lblKategorija.Text = "Kategorija";
            // 
            // lblPodkategorija
            // 
            this.lblPodkategorija.AutoSize = true;
            this.lblPodkategorija.Location = new System.Drawing.Point(123, 100);
            this.lblPodkategorija.Name = "lblPodkategorija";
            this.lblPodkategorija.Size = new System.Drawing.Size(72, 13);
            this.lblPodkategorija.TabIndex = 6;
            this.lblPodkategorija.Text = "Podkategorija";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(127, 166);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(52, 13);
            this.lblKomentar.TabIndex = 7;
            this.lblKomentar.Text = "Komentar";
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(136, 224);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(32, 13);
            this.lblIznos.TabIndex = 8;
            this.lblIznos.Text = "Iznos";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(130, 280);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Datum";
            // 
            // btnDodajForma
            // 
            this.btnDodajForma.Location = new System.Drawing.Point(115, 351);
            this.btnDodajForma.Name = "btnDodajForma";
            this.btnDodajForma.Size = new System.Drawing.Size(80, 23);
            this.btnDodajForma.TabIndex = 10;
            this.btnDodajForma.Text = "Dodaj Trošak";
            this.btnDodajForma.UseVisualStyleBackColor = true;
            this.btnDodajForma.Click += new System.EventHandler(this.btnDodajForma_Click);
            // 
            // FrmDodajTrosak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 395);
            this.Controls.Add(this.btnDodajForma);
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
            this.Name = "FrmDodajTrosak";
            this.Text = "FrmDodajTrosak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKategorija;
        private System.Windows.Forms.ComboBox cboPodkategorija;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblPodkategorija;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Button btnDodajForma;
    }
}