﻿namespace RecycleTrack23
{
    partial class FrmAddMaterijal
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMaterijala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivMaterijala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostotakKapaciteta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCijenaPoKilogramu = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj materijal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txtIdMaterijala
            // 
            this.txtIdMaterijala.Location = new System.Drawing.Point(34, 155);
            this.txtIdMaterijala.Name = "txtIdMaterijala";
            this.txtIdMaterijala.Size = new System.Drawing.Size(100, 26);
            this.txtIdMaterijala.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Naziv";
            // 
            // txtNazivMaterijala
            // 
            this.txtNazivMaterijala.Location = new System.Drawing.Point(34, 239);
            this.txtNazivMaterijala.Name = "txtNazivMaterijala";
            this.txtNazivMaterijala.Size = new System.Drawing.Size(100, 26);
            this.txtNazivMaterijala.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Postotak kapaciteta";
            // 
            // txtPostotakKapaciteta
            // 
            this.txtPostotakKapaciteta.Location = new System.Drawing.Point(34, 329);
            this.txtPostotakKapaciteta.Name = "txtPostotakKapaciteta";
            this.txtPostotakKapaciteta.Size = new System.Drawing.Size(100, 26);
            this.txtPostotakKapaciteta.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cijena po kilogramu";
            // 
            // txtCijenaPoKilogramu
            // 
            this.txtCijenaPoKilogramu.Location = new System.Drawing.Point(34, 397);
            this.txtCijenaPoKilogramu.Name = "txtCijenaPoKilogramu";
            this.txtCijenaPoKilogramu.Size = new System.Drawing.Size(100, 26);
            this.txtCijenaPoKilogramu.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(385, 381);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddMaterijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtCijenaPoKilogramu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPostotakKapaciteta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNazivMaterijala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdMaterijala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddMaterijal";
            this.Text = "FrmAddMaterijal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMaterijala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazivMaterijala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPostotakKapaciteta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCijenaPoKilogramu;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button button1;
    }
}