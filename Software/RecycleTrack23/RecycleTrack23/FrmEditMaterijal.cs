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
    public partial class FrmEditMaterijal : Form
    {
        public Materijal Materijal { get; set; }

        public FrmEditMaterijal(Materijal materijal)
        {
            InitializeComponent();  // Ovo se mora pozvati kako bi se inicijalizirale kontrole
            Materijal = materijal;
            txtNazivMaterijala.Text = materijal.NazivMaterijala;
            txtCijenaPoKilogramuUEurima.Text = materijal.CijenaPoKilogramuUEurima;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Materijal.NazivMaterijala = txtNazivMaterijala.Text;
            Materijal.CijenaPoKilogramuUEurima = txtCijenaPoKilogramuUEurima.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtNazivMaterijala_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
