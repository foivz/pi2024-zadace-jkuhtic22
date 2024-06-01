using System;
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
    public partial class FrmAddMaterijal : Form
    {
        public FrmAddMaterijal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("uspjesno spremljeno", "Spremi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Materijal materijal = new Materijal();
            materijal.Id = int.Parse(txtIdMaterijala.Text);
            materijal.NazivMaterijala = txtNazivMaterijala.Text;
            materijal.PostotakKapaciteta = txtPostotakKapaciteta.Text;
            materijal.CijenaPoKilogramu = txtCijenaPoKilogramu.Text;

            MaterijalRepozitorij.NoviMaterijal(materijal);
        }
    }
}
