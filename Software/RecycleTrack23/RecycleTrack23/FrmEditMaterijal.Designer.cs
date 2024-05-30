namespace RecycleTrack23
{
    partial class FrmEditMaterijal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNazivMaterijala;
        private System.Windows.Forms.TextBox txtCijenaPoKilogramuUEurima;
        private System.Windows.Forms.Button btnSpremi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNazivMaterijala = new System.Windows.Forms.TextBox();
            this.txtCijenaPoKilogramuUEurima = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.txtNazivMaterijala.Location = new System.Drawing.Point(12, 101);
            this.txtNazivMaterijala.Name = "txtNazivMaterijala";
            this.txtNazivMaterijala.Size = new System.Drawing.Size(306, 26);
            this.txtNazivMaterijala.TabIndex = 0;
            this.txtNazivMaterijala.TextChanged += new System.EventHandler(this.txtNazivMaterijala_TextChanged);
            
            this.txtCijenaPoKilogramuUEurima.Location = new System.Drawing.Point(12, 165);
            this.txtCijenaPoKilogramuUEurima.Name = "txtCijenaPoKilogramuUEurima";
            this.txtCijenaPoKilogramuUEurima.Size = new System.Drawing.Size(306, 26);
            this.txtCijenaPoKilogramuUEurima.TabIndex = 1;
            
            this.btnSpremi.Location = new System.Drawing.Point(114, 205);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(103, 52);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cijena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv";
             
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(108, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izmjena";
             
            this.ClientSize = new System.Drawing.Size(357, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtCijenaPoKilogramuUEurima);
            this.Controls.Add(this.txtNazivMaterijala);
            this.Name = "FrmEditMaterijal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
