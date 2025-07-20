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

            // Prepare the transport unit
            var unit = new TransportUnit
            {
                LorryID = Convert.ToInt32(cmbLorry.SelectedValue),
                DriverID = Convert.ToInt32(cmbDriver.SelectedValue),
                AssistantID = cmbAssistant.SelectedIndex >= 0 && cmbAssistant.SelectedValue != null
                                ? (int?)cmbAssistant.SelectedValue : null,
                ContainerID = Convert.ToInt32(cmbContainer.SelectedValue),
                Status = "Assigned"
            };

            // Assign and link transport unit to current load
            string errorMsg;
            int unitId = _service.AddTransportUnit(unit, out errorMsg);

            if (unitId > 0 && string.IsNullOrEmpty(errorMsg))
            {
                // After creation, link the unit to the load and update status
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
                this.Close(); // Close and let Load Management refresh if needed
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
            txtTransportUnitID.Text =   _service.GetAllTransportUnits().Count > 0 ? 
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
    }
}
