using e___Shift_System.Business.Interface;
using e___Shift_System.Business.Services;
using e___Shift_System.Repository.Interface;
using e___Shift_System.Repository.Services;
using e___Shift_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e___Shift_System.Forms
{
    public partial class Add_containers : Form
    {
        private readonly IContainerService _containerService;
        public Add_containers()
        {
            InitializeComponent();
            IContainerRepository repo = new ContainerRepository();
            _containerService = new ContainerService(repo);
            cmbStatus.Items.AddRange(new string[] { "Available", "Inactive", "In Maintenance" });
            LoadContainersGrid();
        }



        private void Add_Containers_Load(object sender, EventArgs e)
        {
            txtContainerID.ReadOnly = true;
            txtContainerID.Text = _containerService.GetNextContainerId().ToString();
        }

        private void LoadContainersGrid()
        {
            dataGridViewAddContainers.DataSource = null;
            dataGridViewAddContainers.DataSource = _containerService.GetAllContainers();
            dataGridViewAddContainers.ClearSelection();
            ClearFields();
        }

        private void dataGridViewAddContainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAddContainers.Rows[e.RowIndex];
                txtContainerID.Text = row.Cells["ContainerID"].Value?.ToString();
                txtContainerNumber.Text = row.Cells["ContainerNo"].Value?.ToString();
                txtContainerType.Text = row.Cells["Type"].Value?.ToString();
                txtcontainerCapacity.Text = row.Cells["Capacity"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtContainerID.Text, out int containerId)) return;
            Container container = new Container
            {
                ContainerID = containerId,
                ContainerNo = txtContainerNumber.Text.Trim(),
                Type = txtContainerType.Text.Trim(),
                Capacity = int.TryParse(txtcontainerCapacity.Text, out var cap) ? cap : 0,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            _containerService.EditContainer(container, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Container updated successfully.");
                LoadContainersGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Container container = new Container
            {
                ContainerNo = txtContainerID.Text.Trim(),
                Type = txtContainerType.Text.Trim(),
                Capacity = int.TryParse(txtcontainerCapacity.Text, out var cap) ? cap : 0,
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            string errorMsg;
            int newId = _containerService.RegisterContainer(container, out errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Container added successfully.");
                txtContainerID.Text = newId.ToString();
                LoadContainersGrid();
            }
            else
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtContainerID.Text, out int containerId)) return;
            _containerService.DeleteContainer(containerId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Container marked as inactive.");
                LoadContainersGrid();
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
            txtContainerNumber.Clear();
            txtContainerType.Clear();
            txtcontainerCapacity.Clear();
            cmbStatus.SelectedIndex = -1;

            txtContainerID.ReadOnly = true;
            txtContainerID.Text = _containerService.GetNextContainerId().ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();

        }
    }
}
