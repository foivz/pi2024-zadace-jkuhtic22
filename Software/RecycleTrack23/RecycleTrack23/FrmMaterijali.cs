using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace RecycleTrack23
{
    public partial class FrmMaterijali : Form
    {
        private MaterijalRepozitorij materijalRepozitorij = new MaterijalRepozitorij();
        public FrmMaterijali()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<Materijal> materijali = materijalRepozitorij.GetAll();
            dgvMaterijali.DataSource = materijali;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Materijal> materijali = materijalRepozitorij.Search(txtSearch.Text);
            dgvMaterijali.DataSource = materijali;
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMaterijali.SelectedCells.Count > 0)
            {
                int rowIndex = dgvMaterijali.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMaterijali.Rows[rowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nazivMaterijala = selectedRow.Cells["NazivMaterijala"].Value.ToString();
                string postotakKapaciteta = selectedRow.Cells["PostotakKapaciteta"].Value.ToString();
                string cijenaPoKilogramu = selectedRow.Cells["CijenaPoKilogramu"].Value.ToString();

                Materijal materijal = new Materijal
                {
                    Id = id,
                    NazivMaterijala = nazivMaterijala,
                    PostotakKapaciteta=postotakKapaciteta,
                    CijenaPoKilogramu = cijenaPoKilogramu
                    
                };

                FrmEditMaterijal frmEditMaterijal = new FrmEditMaterijal(materijal);
                if (frmEditMaterijal.ShowDialog() == DialogResult.OK)
                {
                    materijalRepozitorij.Update(frmEditMaterijal.Materijal);
                    LoadData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaterijali.SelectedCells.Count > 0)
            {
                int rowIndex = dgvMaterijali.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMaterijali.Rows[rowIndex];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                materijalRepozitorij.Delete(id);
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddMaterijal frmAddMaterijal = new FrmAddMaterijal();
            frmAddMaterijal.ShowDialog();
            this.Close();
        }
    }
}