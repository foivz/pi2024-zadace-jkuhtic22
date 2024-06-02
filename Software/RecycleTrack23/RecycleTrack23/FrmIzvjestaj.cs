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

        
    
    }
}
