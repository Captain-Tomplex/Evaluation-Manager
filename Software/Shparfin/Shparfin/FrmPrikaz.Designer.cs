namespace Shparfin
{
    partial class FrmPrikaz
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPrihod = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrosak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrihod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrosak
            // 
            this.dgvTrosak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrosak.Location = new System.Drawing.Point(12, 94);
            this.dgvTrosak.Name = "dgvTrosak";
            this.dgvTrosak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrosak.Size = new System.Drawing.Size(444, 426);
            this.dgvTrosak.TabIndex = 0;
            this.dgvTrosak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Unesi novi trošak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPrihod
            // 
            this.dgvPrihod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrihod.Location = new System.Drawing.Point(462, 94);
            this.dgvPrihod.Name = "dgvPrihod";
            this.dgvPrihod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrihod.Size = new System.Drawing.Size(425, 426);
            this.dgvPrihod.TabIndex = 2;
            this.dgvPrihod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrihod_CellContentClick);
            // 
            // FrmPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 532);
            this.Controls.Add(this.dgvPrihod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTrosak);
            this.Name = "FrmPrikaz";
            this.Text = "FrmTroskovi";
            this.Load += new System.EventHandler(this.FrmTroskovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrosak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrihod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrosak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPrihod;
    }
}