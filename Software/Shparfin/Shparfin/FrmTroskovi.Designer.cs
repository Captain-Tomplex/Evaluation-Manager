namespace Shparfin
{
    partial class FrmTroskovi
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
            this.dgvTrosak = new System.Windows.Forms.DataGridView();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnIzbrisiTrosak = new System.Windows.Forms.Button();
            this.btnAzurirajTrosak = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrosak)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrosak
            // 
            this.dgvTrosak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrosak.Location = new System.Drawing.Point(12, 12);
            this.dgvTrosak.Name = "dgvTrosak";
            this.dgvTrosak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrosak.Size = new System.Drawing.Size(550, 426);
            this.dgvTrosak.TabIndex = 0;
            this.dgvTrosak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(12, 469);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(110, 20);
            this.txtPretraga.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(128, 469);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click_1);
            // 
            // btnIzbrisiTrosak
            // 
            this.btnIzbrisiTrosak.Location = new System.Drawing.Point(626, 55);
            this.btnIzbrisiTrosak.Name = "btnIzbrisiTrosak";
            this.btnIzbrisiTrosak.Size = new System.Drawing.Size(128, 23);
            this.btnIzbrisiTrosak.TabIndex = 3;
            this.btnIzbrisiTrosak.Text = "Izbriši odabrani trošak";
            this.btnIzbrisiTrosak.UseVisualStyleBackColor = true;
            this.btnIzbrisiTrosak.Click += new System.EventHandler(this.btnIzbrisiTrosak_Click_1);
            // 
            // btnAzurirajTrosak
            // 
            this.btnAzurirajTrosak.Location = new System.Drawing.Point(626, 103);
            this.btnAzurirajTrosak.Name = "btnAzurirajTrosak";
            this.btnAzurirajTrosak.Size = new System.Drawing.Size(128, 23);
            this.btnAzurirajTrosak.TabIndex = 4;
            this.btnAzurirajTrosak.Text = "Ažuriraj odabrani trošak";
            this.btnAzurirajTrosak.UseVisualStyleBackColor = true;
            this.btnAzurirajTrosak.Click += new System.EventHandler(this.btnAzurirajTrosak_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(626, 153);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(128, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj novi trošak";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(12, 450);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(110, 13);
            this.lblPretraga.TabIndex = 6;
            this.lblPretraga.Text = "Pretraga po kategoriji:";
            // 
            // FrmTroskovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAzurirajTrosak);
            this.Controls.Add(this.btnIzbrisiTrosak);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.dgvTrosak);
            this.Name = "FrmTroskovi";
            this.Text = "FrmTroskovi";
            this.Load += new System.EventHandler(this.FrmTroskovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrosak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrosak;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnIzbrisiTrosak;
        private System.Windows.Forms.Button btnAzurirajTrosak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblPretraga;
    }
}