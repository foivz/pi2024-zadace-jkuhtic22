﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RecycleTrack23
{
    public partial class FrmLogin : Form
    {
        string username = "zaposlenik";
        string password = "test";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    this.Hide();
                    FrmMaterijali frmMaterijali = new FrmMaterijali();
                    frmMaterijali.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnZabLozinka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Korisničko ime: zaposlenik \n Lozinka: test", "Zaboravljena lozinka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
