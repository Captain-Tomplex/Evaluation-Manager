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
            this.cboPodKategorija = new System.Windows.Forms.ComboBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboKategorija
            // 
            this.cboKategorija.FormattingEnabled = true;
            this.cboKategorija.Location = new System.Drawing.Point(74, 58);
            this.cboKategorija.Name = "cboKategorija";
            this.cboKategorija.Size = new System.Drawing.Size(121, 21);
            this.cboKategorija.TabIndex = 0;
            // 
            // cboPodKategorija
            // 
            this.cboPodKategorija.FormattingEnabled = true;
            this.cboPodKategorija.Location = new System.Drawing.Point(74, 106);
            this.cboPodKategorija.Name = "cboPodKategorija";
            this.cboPodKategorija.Size = new System.Drawing.Size(121, 21);
            this.cboPodKategorija.TabIndex = 1;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(74, 153);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(100, 20);
            this.txtKomentar.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(35, 207);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(106, 181);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 4;
            // 
            // FrmDodajTrosak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtKomentar);
            this.Controls.Add(this.cboPodKategorija);
            this.Controls.Add(this.cboKategorija);
            this.Name = "FrmDodajTrosak";
            this.Text = "FrmDodajTrosak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKategorija;
        private System.Windows.Forms.ComboBox cboPodKategorija;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtIznos;
    }
}