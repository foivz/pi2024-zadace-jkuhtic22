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
            dgvMaterijali.ReadOnly = true; // Postavite DataGridView kao ReadOnly na početku
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
            if (dgvMaterijali.SelectedRows.Count > 0)
            {
                dgvMaterijali.ReadOnly = false; // Omogućite uređivanje
                int id = Convert.ToInt32(dgvMaterijali.SelectedRows[0].Cells["Id"].Value);
                Materijal izmijenjeniMaterijal = new Materijal
                {
                    Id = id,
                    NazivMaterijala = "Izmijenjeni Materijal", // Zamijeni stvarnim vrijednostima
                    CijenaPoKilogramuUEurima = "0.00" // Zamijeni stvarnim vrijednostima
                };
                // Omogućite uređivanje kontrola
                EnableEditingControls(true);
                // Spremljeno kod za ažuriranje će se izvršiti nakon što korisnik potvrdi izmjene
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (dgvMaterijali.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMaterijali.SelectedRows[0].Cells["Id"].Value);
                Materijal izmijenjeniMaterijal = new Materijal
                {
                    Id = id,
                    NazivMaterijala = dgvMaterijali.SelectedRows[0].Cells["NazivMaterijala"].Value.ToString(),
                    CijenaPoKilogramuUEurima = dgvMaterijali.SelectedRows[0].Cells["CijenaPoKilogramuUEurima"].Value.ToString()
                };
                materijalRepozitorij.Update(izmijenjeniMaterijal);
                dgvMaterijali.ReadOnly = true; // Vraćanje DataGridView na ReadOnly
                LoadData();
                // Onemogućite uređivanje kontrola
                EnableEditingControls(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaterijali.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMaterijali.SelectedRows[0].Cells["Id"].Value);
                materijalRepozitorij.Delete(id);
                LoadData();
            }
        }

        private void EnableEditingControls(bool enable)
        {
            txtSearch.Enabled = !enable;
            btnSearch.Enabled = !enable;
            btnEdit.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnSaveEdit.Enabled = enable;
        }
    }
}
