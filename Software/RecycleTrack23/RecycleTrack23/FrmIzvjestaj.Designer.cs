namespace RecycleTrack23
{
    partial class FrmIzvjestaj
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVrijeme = new System.Windows.Forms.ComboBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vremensko razdoblje";
            // 
            // cmbVrijeme
            // 
            this.cmbVrijeme.FormattingEnabled = true;
            this.cmbVrijeme.Location = new System.Drawing.Point(328, 25);
            this.cmbVrijeme.Name = "cmbVrijeme";
            this.cmbVrijeme.Size = new System.Drawing.Size(121, 28);
            this.cmbVrijeme.TabIndex = 1;
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(16, 138);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.RowHeadersWidth = 62;
            this.dgvIzvjestaj.RowTemplate.Height = 28;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(758, 250);
            this.dgvIzvjestaj.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(199)))), ((int)(((byte)(164)))));
            this.button1.Location = new System.Drawing.Point(378, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generiraj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Controls.Add(this.cmbVrijeme);
            this.Controls.Add(this.label1);
            this.Name = "FrmIzvjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbVrijeme;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.Button button1;
    }
}