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
    public partial class Transport_Unit_Management : Form
    {
        private readonly int _jobId;
        private readonly int _loadId;
        private readonly ITransportUnitService _service;

        public Transport_Unit_Management(int jobId, int loadId)
        {
            InitializeComponent();
            var repo = new TransportUnitRepository();
            _service = new TransportUnitService(repo);

            _jobId = jobId;
            _loadId = loadId;
        }

        private void Transport_Unit_Management_Load(object sender, EventArgs e)
        {
            txtJobID.ReadOnly = true;
            txtLoadID.ReadOnly = true;
            txtJobID.Text = _jobId.ToString();
            txtLoadID.Text = _loadId.ToString();

            LoadComboBoxes();

            LoadTransportUnitsGrid();
        }

        private void LoadComboBoxes()
        {
            // Lorry RegNo
            cmbLorry.DataSource = _service.GetAvailableLorries();
            cmbLorry.DisplayMember = "RegNo";
            cmbLorry.ValueMember = "LorryID";
            cmbLorry.SelectedIndex = -1;

            // ContainerNo
            cmbContainer.DataSource = _service.GetAvailableContainers();
            cmbContainer.DisplayMember = "ContainerNo";
            cmbContainer.ValueMember = "ContainerID";
            cmbContainer.SelectedIndex = -1;

            // Assistant (Name, but use ID as value)
            var assistants = _service.GetAvailableAssistants();
            cmbAssistant.DataSource = assistants;
            cmbAssistant.DisplayMember = "Name";
            cmbAssistant.ValueMember = "AssistantID";
            cmbAssistant.SelectedIndex = assistants.Count > 0 ? -1 : 0;

            // Driver (Name, but use ID as value)
            cmbDriver.DataSource = _service.GetAvailableDrivers();
            cmbDriver.DisplayMember = "Name";
            cmbDriver.ValueMember = "DriverID";
            cmbDriver.SelectedIndex = -1;
        }

        private void LoadTransportUnitsGrid()
        {
            dataGridViewTransportUnitManagement.DataSource = null;
            dataGridViewTransportUnitManagement.DataSource = _service.GetAllTransportUnits();
            dataGridViewTransportUnitManagement.ClearSelection();
        }


        private void dataGridViewTransportUnitManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTransportUnitManagement.Rows[e.RowIndex];

                // Example assignments (ensure your property/column names match!)
                txtTransportUnitID.Text = row.Cells["TransportUnitID"].Value?.ToString();
                cmbLorry.SelectedValue = row.Cells["LorryID"].Value;
                cmbDriver.SelectedValue = row.Cells["DriverID"].Value;
                cmbAssistant.SelectedValue = row.Cells["AssistantID"].Value is DBNull ? null : row.Cells["AssistantID"].Value;
                cmbContainer.SelectedValue = row.Cells["ContainerID"].Value;

                // If you have a status textbox/label:
                // txtStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            // Basic input validation
            if (cmbLorry.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a lorry.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbDriver.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a driver.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbContainer.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a container.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prepare the transport unit from selected inputs
            var unit = new TransportUnit
            {
                LorryID = Convert.ToInt32(cmbLorry.SelectedValue),
                DriverID = Convert.ToInt32(cmbDriver.SelectedValue),
                AssistantID = cmbAssistant.SelectedIndex >= 0 && cmbAssistant.SelectedValue != null
                                ? (int?)cmbAssistant.SelectedValue
                                : null,
                ContainerID = Convert.ToInt32(cmbContainer.SelectedValue),
                Status = "Assigned"
            };

            // Assign and link transport unit to current load
            string errorMsg;
            int unitId = _service.AddTransportUnit(unit, out errorMsg);

            if (unitId > 0 && string.IsNullOrEmpty(errorMsg))
            {
                // Update the Transport Unit record status to "Assigned"
                var assignedUnit = _service.GetTransportUnitById(unitId);
                if (assignedUnit != null)
                {
                    assignedUnit.Status = "Assigned";
                    _service.EditTransportUnit(assignedUnit, out string updateMsg);
                }

                // Show assigned Transport Unit ID in the textbox on this form
                txtTransportUnitID.Text = unitId.ToString();

                // Update associated Load's AssignedTransportUnitID and Status to "Assigned"
                ILoadRepository loadRepo = new LoadRepository();
                if (int.TryParse(txtLoadID.Text, out int loadId))
                {
                    var load = loadRepo.GetLoadById(loadId);
                    if (load != null)
                    {
                        load.AssignedTransportUnitID = unitId;
                        load.Status = "Assigned";
                        loadRepo.UpdateLoad(load);
                    }
                }

                MessageBox.Show("Transport unit assigned and load status updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally: Close the form or refresh controls as needed
                this.Close();
            }
            else
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMsg) ? errorMsg : "Assignment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTransportUnitID.Text, out int unitId))
            {
                MessageBox.Show("Select a unit to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var unit = new TransportUnit
            {
                TransportUnitID = unitId,
                LorryID = (int)cmbLorry.SelectedValue,
                DriverID = (int)cmbDriver.SelectedValue,
                AssistantID = cmbAssistant.SelectedIndex >= 0 ? (int?)cmbAssistant.SelectedValue : null,
                ContainerID = (int)cmbContainer.SelectedValue,
                Status = "Assigned"
            };
            _service.EditTransportUnit(unit, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Updated successfully.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransportUnitsGrid();
                ClearFields();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTransportUnitID.Clear();
            cmbLorry.SelectedIndex = -1;
            cmbDriver.SelectedIndex = -1;
            cmbAssistant.SelectedIndex = -1;
            cmbContainer.SelectedIndex = -1;
            txtTransportUnitID.Text = _service.GetAllTransportUnits().Count > 0 ?
                (_service.GetAllTransportUnits().Max(u => u.TransportUnitID) + 1).ToString() : "1";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTransportUnitID.Text, out int unitId)) return;
            _service.DeleteTransportUnit(unitId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Transport unit deleted successfully.");
                LoadTransportUnitsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loadManagementForm = new Load_Management(_jobId); // _jobId is your field holding the Job ID
            loadManagementForm.StartPosition = FormStartPosition.CenterScreen;
            loadManagementForm.Show();

            // Close the current Transport Unit Management form
            this.Close();
        }

        private void cmbLorry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear()
        {

            txtTransportUnitID.Clear();

            // Reset all ComboBoxes to unselected
            cmbLorry.SelectedIndex = -1;
            cmbDriver.SelectedIndex = -1;
            cmbAssistant.SelectedIndex = -1;
            cmbContainer.SelectedIndex = -1;

            // Optionally clear any extra text fields or reset labels as required
            // Example: txtSomeOtherField.Clear();

            // If you want to ensure dropdown lists are up-to-date (in case availability changed):
            LoadComboBoxes();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void dataGridViewTransportUnitManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenReport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF (*.pdf)|*.pdf", FileName = "TransportUnitsReport.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dgv = dataGridViewTransportUnitManagement; // Use your actual DataGridView name

                        PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count)
                        {
                            WidthPercentage = 100,
                            DefaultCell = { Padding = 3, BorderWidth = 1 }
                        };

                        // Headers
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                            {
                                BackgroundColor = new BaseColor(230, 230, 230)
                            };
                            pdfTable.AddCell(cell);
                        }

                        // Data rows
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString() ?? "");
                                }
                            }
                        }

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Title (bold, centered)
                            var fontTitle = FontFactory.GetFont("Arial", 16, iTextSharp.text.Font.BOLD);
                            Paragraph title = new Paragraph("Transport Unit Management Report", fontTitle)
                            {
                                Alignment = Element.ALIGN_CENTER,
                                SpacingAfter = 10f
                            };
                            pdfDoc.Add(title);

                            // Date
                            Paragraph date = new Paragraph($"Report generated on {DateTime.Now:yyyy-MM-dd}")
                            {
                                Alignment = Element.ALIGN_CENTER,
                                SpacingAfter = 10f
                            };
                            pdfDoc.Add(date);

                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                        }
                        MessageBox.Show("PDF report created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}