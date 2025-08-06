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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


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
            // Prompt for save location
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = "JobsReport.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Create a PDF table with the same number of columns as the DataGridView
                    PdfPTable pdfTable = new PdfPTable(dataGridViewJobManagement.Columns.Count)
                    {
                        WidthPercentage = 100,
                        DefaultCell = { Padding = 3, BorderWidth = 1 }
                    };

                    // Add header row
                    foreach (DataGridViewColumn column in dataGridViewJobManagement.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = new BaseColor(230, 230, 230)
                        };
                        pdfTable.AddCell(cell);
                    }

                    // Add all visible rows
                    foreach (DataGridViewRow row in dataGridViewJobManagement.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }
                    }

                    // Write to PDF file
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Title
                        pdfDoc.Add(new Paragraph("E-Shift - Job Management Report")
                        {
                            Alignment = Element.ALIGN_CENTER,
                            SpacingAfter = 10f,
                            
                        });
                        pdfDoc.Add(new Paragraph("Report Date: " + DateTime.Now.ToString("yyyy-MM-dd")));
                        pdfDoc.Add(new Paragraph(" ")); // Extra space

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("PDF report created successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting PDF: " + ex.Message, "Export Error");
                }
            }
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
                btnConfirm.Enabled = (status == "Pending");
                btnCreateLoads.Enabled = (status == "Pending");
                btnCreateLoads.Enabled = (status == "Confirmed");
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_selectedJobId == -1)
            {
                MessageBox.Show("Please select a 'Pending' job to confirm.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: check if job is currently "Pending"
            var job = _jobService.GetJobById(_selectedJobId);
            if (job == null)
            {
                MessageBox.Show("Job not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (job.Status != "Pending")
            {
                MessageBox.Show("Only jobs in 'Pending' status can be confirmed.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = _jobService.ConfirmJob(_selectedJobId, out string errorMessage);
            if (result)
            {
                MessageBox.Show("Job confirmed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadJobs();
            }
            else
            {
                MessageBox.Show(errorMessage, "Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtJobID.Clear();
            txtCusID.Clear();
            txtStartLocation.Clear();
            txtDestination.Clear();
            txtShiftItems.Clear();
            txtStatus.Clear();
            dtpJobDate.Value = DateTime.Today;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
