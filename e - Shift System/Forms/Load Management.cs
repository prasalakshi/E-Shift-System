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
    public partial class Load_Management : Form
    {
        private readonly ILoadService _loadService;
        private readonly int _jobId;
        public Load_Management(int jobId)
        {
            InitializeComponent();
            ILoadRepository repo = new LoadRepository();
            _loadService = new LoadService(repo);
            _jobId = jobId;
            txtJobId.Text = _jobId.ToString();
            txtJobId.ReadOnly = true;

            txtLoadId.Text = _jobId.ToString();
            txtLoadId.ReadOnly = true;
            txtStatus.ReadOnly = true;
            LoadLoadsGrid();
        }

        private void LoadLoadsGrid()
        {
            dataGridViewLoadManagement.DataSource = null;
            dataGridViewLoadManagement.DataSource = _loadService.GetLoadsByJobId(_jobId);
            dataGridViewLoadManagement.ClearSelection();
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form jobmanagement = new Job_Management();
            jobmanagement.Show();
            this.Hide();
        }

        private void btnAssignUnit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoadId.Text, out int loadId) || !int.TryParse(txtJobId.Text, out int jobId))
            {
                MessageBox.Show("Please select a valid load and job.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var transportForm = new Transport_Unit_Management(jobId, loadId))
            {
                transportForm.StartPosition = FormStartPosition.CenterParent;
                transportForm.ShowDialog(this);
                this.Hide(); // Hide current form after transport unit assignment
            }

            LoadLoadsGrid(); // Refresh grid/status
            var load = _loadService.GetLoadById(loadId);
            if (load != null)
                txtStatus.Text = load.Status;
        }

        private void dataGridViewLoadManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewLoadManagement.Rows[e.RowIndex];
                txtLoadId.Text = row.Cells["LoadID"].Value?.ToString();
                txtJobId.Text = row.Cells["JobID"].Value?.ToString();
                txtLoadDescription.Text = row.Cells["LoadDescription"].Value?.ToString();
                dtpPickupDate.Value = row.Cells["PickupDate"].Value != null ? Convert.ToDateTime(row.Cells["PickupDate"].Value) : DateTime.Today;
                dtpDeliveredDate.Value = row.Cells["DeliveredDate"].Value != null ? Convert.ToDateTime(row.Cells["DeliveredDate"].Value) : DateTime.Today;
                txtStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Load load = new Load
            {
                JobID = _jobId,
                LoadDescription = txtLoadDescription.Text.Trim(),
                Status = "Pending",
                PickupDate = dtpPickupDate.Value,
                DeliveredDate = null
            };

            string errorMsg;
            int newId = _loadService.RegisterLoad(load, out errorMsg);

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Load created successfully.");
                LoadLoadsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoadId.Text, out int loadId)) return;
            Load load = new Load
            {
                LoadID = loadId,
                JobID = _jobId,
                LoadDescription = txtLoadDescription.Text.Trim(),
                PickupDate = dtpPickupDate.Value,
                DeliveredDate = dtpDeliveredDate.Value
            };
            _loadService.EditLoad(load, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Load updated successfully.");
                LoadLoadsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLoadId.Text, out int loadId)) return;
            _loadService.DeleteLoad(loadId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Load marked as cancelled.");
                LoadLoadsGrid();
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
            txtLoadId.Clear();
            txtLoadDescription.Clear();
            txtStatus.Text = "Pending";
            dtpPickupDate.Value = DateTime.Today;
            dtpDeliveredDate.Value = DateTime.Today;            
            txtLoadId.Text = _loadService.GetNextLoadId().ToString();
        }

        private void Load_Management_Load(object sender, EventArgs e)
        {
            txtLoadId.ReadOnly = true;
            txtLoadId.Text = _loadService.GetNextLoadId().ToString();
        }

        private void dtpPickupDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Load_Management_Load_1(object sender, EventArgs e)
        {
            Load_Management_Load(sender, e);
        }
    }
}
