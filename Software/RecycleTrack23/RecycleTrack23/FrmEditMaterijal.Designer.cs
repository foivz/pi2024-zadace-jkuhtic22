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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNazivMaterijala
            // 
            this.txtNazivMaterijala.BackColor = System.Drawing.Color.Silver;
            this.txtNazivMaterijala.Location = new System.Drawing.Point(219, 90);
            this.txtNazivMaterijala.Name = "txtNazivMaterijala";
            this.txtNazivMaterijala.Size = new System.Drawing.Size(306, 26);
            this.txtNazivMaterijala.TabIndex = 0;
            this.txtNazivMaterijala.TextChanged += new System.EventHandler(this.txtNazivMaterijala_TextChanged);
            // 
            // txtCijenaPoKilogramu
            // 
            this.txtCijenaPoKilogramu.BackColor = System.Drawing.Color.Silver;
            this.txtCijenaPoKilogramu.Location = new System.Drawing.Point(219, 152);
            this.txtCijenaPoKilogramu.Name = "txtCijenaPoKilogramu";
            this.txtCijenaPoKilogramu.Size = new System.Drawing.Size(306, 26);
            this.txtCijenaPoKilogramu.TabIndex = 1;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(199)))), ((int)(((byte)(164)))));
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(394, 256);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 71);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cijena";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(194, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izmjena";
            // 
            // txtPostotakKapaciteta
            // 
            this.txtPostotakKapaciteta.BackColor = System.Drawing.Color.Silver;
            this.txtPostotakKapaciteta.Location = new System.Drawing.Point(219, 206);
            this.txtPostotakKapaciteta.Name = "txtPostotakKapaciteta";
            this.txtPostotakKapaciteta.Size = new System.Drawing.Size(306, 26);
            this.txtPostotakKapaciteta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Postotak kapaciteta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(199)))), ((int)(((byte)(164)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 71);
            this.button1.TabIndex = 8;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEditMaterijal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPostotakKapaciteta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtCijenaPoKilogramu);
            this.Controls.Add(this.txtNazivMaterijala);
            this.Name = "FrmEditMaterijal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmjena";
            this.Load += new System.EventHandler(this.FrmEditMaterijal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostotakKapaciteta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}