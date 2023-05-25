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
            this.btnDodajTrosak = new System.Windows.Forms.Button();
            this.btnUrediTrosak = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnIzbrisiTrosak = new System.Windows.Forms.Button();
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
            this.dgvTrosak.Size = new System.Drawing.Size(550, 336);
            this.dgvTrosak.TabIndex = 0;
            this.dgvTrosak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDodajTrosak
            // 
            this.btnDodajTrosak.Location = new System.Drawing.Point(595, 28);
            this.btnDodajTrosak.Name = "btnDodajTrosak";
            this.btnDodajTrosak.Size = new System.Drawing.Size(117, 23);
            this.btnDodajTrosak.TabIndex = 1;
            this.btnDodajTrosak.Text = "Dodaj novi trošak";
            this.btnDodajTrosak.UseVisualStyleBackColor = true;
            this.btnDodajTrosak.Click += new System.EventHandler(this.btnDodajTrosak_Click);
            // 
            // btnUrediTrosak
            // 
            this.btnUrediTrosak.Location = new System.Drawing.Point(595, 75);
            this.btnUrediTrosak.Name = "btnUrediTrosak";
            this.btnUrediTrosak.Size = new System.Drawing.Size(117, 23);
            this.btnUrediTrosak.TabIndex = 2;
            this.btnUrediTrosak.Text = "Uredi trošak";
            this.btnUrediTrosak.UseVisualStyleBackColor = true;
            this.btnUrediTrosak.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(30, 395);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(100, 20);
            this.txtPretraga.TabIndex = 3;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(155, 395);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 4;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnIzbrisiTrosak
            // 
            this.btnIzbrisiTrosak.Location = new System.Drawing.Point(595, 122);
            this.btnIzbrisiTrosak.Name = "btnIzbrisiTrosak";
            this.btnIzbrisiTrosak.Size = new System.Drawing.Size(117, 23);
            this.btnIzbrisiTrosak.TabIndex = 5;
            this.btnIzbrisiTrosak.Text = "Izbriši odabrani trošak";
            this.btnIzbrisiTrosak.UseVisualStyleBackColor = true;
            this.btnIzbrisiTrosak.Click += new System.EventHandler(this.btnIzbrisiTrosak_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Location = new System.Drawing.Point(30, 376);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(113, 13);
            this.lblPretraga.TabIndex = 6;
            this.lblPretraga.Text = "Pretraži po komentaru:";
            // 
            // FrmTroskovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 450);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnIzbrisiTrosak);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnUrediTrosak);
            this.Controls.Add(this.btnDodajTrosak);
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
        private System.Windows.Forms.Button btnDodajTrosak;
        private System.Windows.Forms.Button btnUrediTrosak;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnIzbrisiTrosak;
        private System.Windows.Forms.Label lblPretraga;
    }
}