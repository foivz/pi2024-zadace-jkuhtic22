namespace RecycleTrack23
{
    partial class FrmEditMaterijal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNazivMaterijala;
        private System.Windows.Forms.TextBox txtCijenaPoKilogramu;
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
            this.txtCijenaPoKilogramu = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostotakKapaciteta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.txtNazivMaterijala.Location = new System.Drawing.Point(12, 101);
            this.txtNazivMaterijala.Name = "txtNazivMaterijala";
            this.txtNazivMaterijala.Size = new System.Drawing.Size(306, 26);
            this.txtNazivMaterijala.TabIndex = 0;
            this.txtNazivMaterijala.TextChanged += new System.EventHandler(this.txtNazivMaterijala_TextChanged);
            
            this.txtCijenaPoKilogramu.Location = new System.Drawing.Point(12, 165);
            this.txtCijenaPoKilogramu.Name = "txtCijenaPoKilogramu";
            this.txtCijenaPoKilogramu.Size = new System.Drawing.Size(306, 26);
            this.txtCijenaPoKilogramu.TabIndex = 1;
            
            this.btnSpremi.Location = new System.Drawing.Point(114, 288);
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
          
            this.txtPostotakKapaciteta.Location = new System.Drawing.Point(12, 229);
            this.txtPostotakKapaciteta.Name = "txtPostotakKapaciteta";
            this.txtPostotakKapaciteta.Size = new System.Drawing.Size(306, 26);
            this.txtPostotakKapaciteta.TabIndex = 6;
           
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postotak kapaciteta";
           
            this.ClientSize = new System.Drawing.Size(331, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostotakKapaciteta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtCijenaPoKilogramu);
            this.Controls.Add(this.txtNazivMaterijala);
            this.Name = "FrmEditMaterijal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostotakKapaciteta;
        private System.Windows.Forms.Label label4;
    }
}