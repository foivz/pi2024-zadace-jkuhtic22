﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleTrack23
{
    public partial class FrmEditMaterijal : Form
    {
        public Materijal Materijal { get; set; }

        public FrmEditMaterijal(Materijal materijal)
        {
            InitializeComponent();  
            Materijal = materijal;
            txtNazivMaterijala.Text = materijal.NazivMaterijala;
            txtPostotakKapaciteta.Text = materijal.PostotakKapaciteta;
            txtCijenaPoKilogramu.Text = materijal.CijenaPoKilogramu;
            

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Materijal.NazivMaterijala = txtNazivMaterijala.Text;
            Materijal.PostotakKapaciteta = txtPostotakKapaciteta.Text;
            Materijal.CijenaPoKilogramu = txtCijenaPoKilogramu.Text;
            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNazivMaterijala_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMaterijali frmMaterijali = new FrmMaterijali();
            frmMaterijali.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditMaterijal_Load(object sender, EventArgs e)
        {

        }
    }
}