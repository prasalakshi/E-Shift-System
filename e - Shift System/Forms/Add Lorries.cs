using e___Shift_System.Business.Interface;
using e___Shift_System.Business.Services;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using e___Shift_System.Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e___Shift_System.Forms
{
    public partial class Add_Lorries : Form
    {
        private ILorryService _lorryService;
        public Add_Lorries()
        {
            InitializeComponent();
            ILorryRepository repo = new LorryRepository();
            _lorryService = new LorryService(repo);
            cmbStatus.Items.AddRange(new string[] { "Available", "Inactive", "In Maintenance" });
            LoadLorriesGrid();
        }

        private void LoadLorriesGrid()
        {
            dataGridViewAddLorries.DataSource = null;
            dataGridViewAddLorries.DataSource = _lorryService.GetAllLorries();
            dataGridViewAddLorries.ClearSelection();
            ClearFields();
        }


        private void dataGridViewAddLorries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAddLorries.Rows[e.RowIndex];
                txtLorryId.Text = row.Cells["LorryID"].Value?.ToString();
                txtRegNo.Text = row.Cells["RegNo"].Value?.ToString();
                txtModel.Text = row.Cells["Model"].Value?.ToString();
                txtCapacity.Text = row.Cells["Capacity"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }

        private void AddLorryForm_Load(object sender, EventArgs e)
        {
            txtLorryId.ReadOnly = true;
            txtLorryId.Text = _lorryService.GetNextLorryId().ToString();
        }

        private void Add_Lorries_Load(object sender, EventArgs e)
        {
            AddLorryForm_Load(sender, e);
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Lorry lorry = new Lorry
            {
                RegNo = txtRegNo.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Capacity = int.TryParse(txtCapacity.Text, out var cap) ? cap : 0,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };

            string errorMsg;
            int newId = _lorryService.RegisterLorry(lorry, out errorMsg);

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Lorry added successfully.");
                txtLorryId.Text = newId.ToString(); // <- Auto-fill new LorryID
                LoadLorriesGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLorryId.Text, out int lorryId)) return;
            Lorry lorry = new Lorry
            {
                LorryID = lorryId,
                RegNo = txtRegNo.Text.Trim(),
                Model = txtModel.Text.Trim(),
                Capacity = int.TryParse(txtCapacity.Text, out var cap) ? cap : 0,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            _lorryService.EditLorry(lorry, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Lorry updated successfully.");
                LoadLorriesGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLorryId.Text, out int lorryId)) return;
            _lorryService.DeleteLorry(lorryId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Lorry marked as inactive.");
                LoadLorriesGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtRegNo.Clear();
            txtModel.Clear();
            txtCapacity.Clear();
            cmbStatus.SelectedIndex = -1;

            txtLorryId.ReadOnly = true;
            txtLorryId.Text = _lorryService.GetNextLorryId().ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
