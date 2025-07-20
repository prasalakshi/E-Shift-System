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
    public partial class Job_Management : Form
    {
        private readonly IJobService _jobService;
        private int _selectedJobId = -1;

        public Job_Management()
        {
            InitializeComponent();
            IJobRepository repo = new JobRepository();
            _jobService = new JobService(repo);
            LoadJobs();


        }

        private void LoadJobs()
        {
            dataGridViewJobManagement.DataSource = null;
            dataGridViewJobManagement.DataSource = _jobService.GetAllJobs();
            dataGridViewJobManagement.ClearSelection();
            ClearFields();
            _selectedJobId = -1;
            btnEdit.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void ClearFields()
        {
            txtJobID.Text = "";
            txtCusID.Text = "";
            txtStartLocation.Text = "";
            txtDestination.Text = "";
            txtShiftItems.Text = "";
            txtStatus.Text = "";
            dtpJobDate.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Please select a job first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form loadManagement = new Load_Management(_selectedJobId);
            loadManagement.Show();
            this.Hide();
        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewJobManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewJobManagement.Rows[e.RowIndex];

                txtJobID.Text = row.Cells["JobID"].Value?.ToString();
                txtCusID.Text = row.Cells["CustomerID"].Value?.ToString();
                txtStartLocation.Text = row.Cells["StartLocation"].Value?.ToString();
                txtDestination.Text = row.Cells["Destination"].Value?.ToString();
                txtShiftItems.Text = row.Cells["ShiftingItems"].Value?.ToString();
                txtStatus.Text = row.Cells["Status"].Value?.ToString();
                if (row.Cells["JobDate"].Value != null)
                    dtpJobDate.Value = Convert.ToDateTime(row.Cells["JobDate"].Value);

                _selectedJobId = Convert.ToInt32(row.Cells["JobID"].Value);

                // Optionally enable only for "Pending" jobs
                string status = row.Cells["Status"].Value?.ToString();
                btnEdit.Enabled = btnCancel.Enabled = (status == "Pending");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Select a 'Pending' job to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var updatedJob = new Job
            {
                JobID = _selectedJobId,
                CustomerID = Convert.ToInt32(txtCusID.Text),
                StartLocation = txtStartLocation.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                JobDate = dtpJobDate.Value,
                ShiftingItems = txtShiftItems.Text.Trim()
            };

            bool result = _jobService.UpdateJob(updatedJob, out string errorMessage);
            if (result)
            {
                MessageBox.Show("Job updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Please select a 'Pending' job to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result = _jobService.CancelJob(_selectedJobId, out string errorMessage);

            if (result)
            {
                MessageBox.Show("Job cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Cancel Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomerIDs()
        {
            // Example: get all unique customer IDs from jobs via your service
            var jobs = _jobService.GetAllJobs();

            // Get distinct customer IDs
            var customerIds = jobs.Select(j => j.CustomerID).Distinct().ToList();

            cmbFilterbyCusID.DataSource = null;
            cmbFilterbyCusID.DataSource = customerIds;

            cmbFilterbyCusID.SelectedIndex = -1;
        }

       

        private void Job_Management_Load(object sender, EventArgs e)
        {
            LoadCustomerIDs();
            
        }
        private void FilterJobsByCustomer()
        {
            if (int.TryParse(cmbFilterbyCusID.Text, out int customerId))
            {
                dataGridViewJobManagement.DataSource = _jobService.GetJobsByCustomerId(customerId);
            }
            else
            {
                dataGridViewJobManagement.DataSource = _jobService.GetAllJobs();
            }
        }

        private void FilterJobsByDate()
        {
            DateTime jobDate = dtpJobDate.Value;
            dataGridViewJobManagement.DataSource = _jobService.GetJobsByDate(jobDate);
        }

        private void cmbFilterbyCusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterJobsByCustomer();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();
        }

        private void txtJobID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbJobDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterJobsByDate();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmbFilterbyCusID.SelectedIndex = -1;

            // Set the DateTimePicker to today and uncheck it (filter disabled)
            dtpFilterJobDate.Value = DateTime.Today;
            dtpFilterJobDate.Checked = false;

            // Reload DataGridView with all jobs (no filters applied)
            dataGridViewJobManagement.DataSource = _jobService.GetAllJobs();


        }

        private void dtpFilterJobDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFilterJobDate.Checked)
            {
                DateTime selectedDate = dtpFilterJobDate.Value.Date;
                var filtered = _jobService.GetJobsByDate(selectedDate);
                dataGridViewJobManagement.DataSource = null;
                dataGridViewJobManagement.DataSource = filtered;
            }
            else
            {
                // If not checked, show all jobs
                dataGridViewJobManagement.DataSource = _jobService.GetAllJobs();
            }
        }
    }
}
