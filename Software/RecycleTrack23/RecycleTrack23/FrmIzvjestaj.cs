using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecycleTrack23
{
    public partial class FrmIzvjestaj : Form
    {
        public FrmIzvjestaj()
        {
            InitializeComponent();
            LoadComboBoxValues();
        }

        private void LoadComboBoxValues()
        {
            cmbVrijeme.Items.Add("1 dan");
            cmbVrijeme.Items.Add("1 tjedan");
            cmbVrijeme.Items.Add("1 mjesec");
            cmbVrijeme.Items.Add("1 godina");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            List<string> data = new List<string>();
            data.Add("1 dan");
            data.Add("1 tjedan");
            data.Add("1 mjesec");
            data.Add("1 godina");

            List<Izvjestaj> izvjestaji = MaterijalRepozitorij.GetAllIzvjestaj1(data.IndexOf(cmbVrijeme.SelectedItem as string));
            dgvIzvjestaj.DataSource = izvjestaji;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
