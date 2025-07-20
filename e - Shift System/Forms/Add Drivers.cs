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
using System.Xml.Linq;

namespace e___Shift_System.Forms
{
    public partial class Add_Drivers : Form
    {
        private readonly IDriverService _driverService;
        public Add_Drivers()
        {
            InitializeComponent();
            IDriverRepository repo = new DriverRepository();
            _driverService = new DriverService(repo);
            cmbStatus.Items.AddRange(new string[] { "Available", "Inactive", "In Maintenance" });
            LoadDriversGrid();
        }
        private void Add_Drivers_Load(object sender, EventArgs e)
        {
            txtDriverID.ReadOnly = true;
            txtDriverID.Text = _driverService.GetNextDriverId().ToString();
        }



        private void LoadDriversGrid()
        {
            dataGridViewAddDrivers.DataSource = null;
            dataGridViewAddDrivers.DataSource = _driverService.GetAllDrivers();
            dataGridViewAddDrivers.ClearSelection();
            ClearFields();
        }

        private void ClearFields()
        {
            txtDriverName.Clear();
            txtLicenseNo.Clear();
            txtDriverConNo.Clear();
            cmbStatus.SelectedIndex = -1;

            txtDriverID.ReadOnly = true;
            txtDriverID.Text = _driverService.GetNextDriverId().ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver
            {
                Name = txtDriverName.Text.Trim(),
                LicenseNo = txtLicenseNo.Text.Trim(),
                Contact = txtDriverConNo.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            string errorMsg;
            int newId = _driverService.RegisterDriver(driver, out errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Driver added successfully.");
                txtDriverID.Text = newId.ToString();
                LoadDriversGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAddDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAddDrivers.Rows[e.RowIndex];
                txtDriverID.Text = row.Cells["DriverID"].Value?.ToString();
                txtDriverName.Text = row.Cells["Name"].Value?.ToString();
                txtLicenseNo.Text = row.Cells["LicenseNo"].Value?.ToString();
                txtDriverConNo.Text = row.Cells["Contact"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDriverID.Text, out int driverId)) return;
            Driver driver = new Driver
            {
                DriverID = driverId,
                Name = txtDriverName.Text.Trim(),
                LicenseNo = txtLicenseNo.Text.Trim(),
                Contact = txtDriverConNo.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            _driverService.EditDriver(driver, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Driver updated successfully.");
                LoadDriversGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDriverID.Text, out int driverId)) return;
            _driverService.DeleteDriver(driverId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Driver marked as inactive.");
                LoadDriversGrid();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();
        }
    }
}
