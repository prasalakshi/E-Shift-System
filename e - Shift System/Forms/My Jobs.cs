using e___Shift_System.Business.Interface;
using e___Shift_System.Business.Services;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using e___Shift_System.Repository.Services;

namespace e___Shift_System.Forms
{
    public partial class My_Jobs : Form
    {
        private readonly IJobService _jobService;
        private readonly int _customerId;
        private int _selectedJobId = -1;
        private Customer _customer;

        public My_Jobs(int customerId, Customer customer)
        {
            InitializeComponent();
            IJobRepository repo = new JobRepository();
            _jobService = new JobService(repo);
            _customerId = customerId; // Assign the passed parameter to the field
            _customer = customer ?? throw new ArgumentNullException(nameof(customer)); // Ensure _customer is assigned and not null
            LoadJobs();
        }

        private void LoadJobs()
        {
            jobsDataGridView.DataSource = null;
            jobsDataGridView.DataSource = _jobService.GetJobsByCustomerId(_customerId);
            _selectedJobId = -1;
            Clear();
            txtCusID.Text = _customerId.ToString();
            SetButtonStates();
        }

        private void Clear()
        {
            txtStartLocation.Text = string.Empty;
            txtDestination.Text = string.Empty;
            dtpJobDate.Text = string.Empty;

        }

        private void My_Jobs_Load(object sender, EventArgs e)
        {
            txtCusID.Text = _customerId.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("Customer information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer_Dashboard customerDashboard = new Customer_Dashboard(_customer);
            customerDashboard.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var job = new Job
            {
                CustomerID = _customerId,
                StartLocation = txtStartLocation.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                ShiftingItems = txtShiftItems.Text.Trim(),
                JobDate = dtpJobDate.Value
            };
            _jobService.AddJob(job, out string errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Job created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void jobsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = jobsDataGridView.Rows[e.RowIndex];

                    // Populate the job editing textboxes with data from the selected row
                    txtStartLocation.Text = row.Cells["StartLocation"].Value?.ToString();
                    txtDestination.Text = row.Cells["Destination"].Value?.ToString();
                    txtShiftItems.Text = row.Cells["ShiftingItems"].Value?.ToString();
                    dtpJobDate.Value = (DateTime)row.Cells["JobDate"].Value;

                    // If you want to keep track of which job is selected for editing/cancellation
                    _selectedJobId = Convert.ToInt32(row.Cells["JobID"].Value);

                    // Optionally, enable or disable Edit/Cancel buttons based on the status:
                    string status = row.Cells["Status"].Value?.ToString();
                    btnEdit.Enabled = (status == "Pending");
                    btnCancel.Enabled = (status == "Pending");
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Please select a pending job to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _jobService.CancelJob(_selectedJobId, out string errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Job cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Cancel Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetButtonStates()
        {
            if (jobsDataGridView.CurrentRow == null ||
        jobsDataGridView.CurrentRow.Cells["Status"].Value == null)
            {
                btnCancel.Enabled = false;
                return;
            }
            string status = jobsDataGridView.CurrentRow.Cells["Status"].Value?.ToString() ?? string.Empty;
            btnCancel.Enabled = status == "Pending";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var updatedJob = new Job
            {
                JobID = _selectedJobId, // Should be set when row is selected
                CustomerID = _customerId, // Already tracking logged-in customer
                StartLocation = txtStartLocation.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                JobDate = dtpJobDate.Value,
                ShiftingItems = txtShiftItems.Text.Trim() // Add any other fields if needed
            };

            // 2. Update the job via business layer, with validation
            _jobService.UpdateJob(updatedJob, out string errorMessage);

            // 3. Show feedback, refresh grid
            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Job updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
