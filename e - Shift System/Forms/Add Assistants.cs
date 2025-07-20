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
    public partial class Add_Assistants : Form
    {
        private readonly IAssistantService _assistantService;
        public Add_Assistants()
        {
            InitializeComponent();
            IAssistantRepository repo = new AssistantRepository();
            _assistantService = new AssistantService(repo);
            cmbStatus.Items.AddRange(new string[] { "Available", "Inactive", "In Maintenance" });
            LoadAssistantsGrid();
        }

        private void Add_Assistants_Load(object sender, EventArgs e)
        {
            txtAssistantId.ReadOnly = true;
            txtAssistantId.Text = _assistantService.GetNextAssistantId().ToString();
        }

        private void LoadAssistantsGrid()
        {
            dataGridViewAddAssistants.DataSource = null;
            dataGridViewAddAssistants.DataSource = _assistantService.GetAllAssistants();
            dataGridViewAddAssistants.ClearSelection();
            ClearFields();
        }

        private void ClearFields()
        {
            txtAssistantName.Clear();
            txtConNo.Clear();
            cmbStatus.SelectedIndex = -1;

            txtAssistantId.ReadOnly = true;
            txtAssistantId.Text = _assistantService.GetNextAssistantId().ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAssistantId.Text, out int assistantId)) return;
            Assistant assistant = new Assistant
            {
                AssistantID = assistantId,
                Name = txtAssistantName.Text.Trim(),
                Contact = txtConNo.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            _assistantService.EditAssistant(assistant, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Assistant updated successfully.");
                LoadAssistantsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAddAssistants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAddAssistants.Rows[e.RowIndex];
                txtAssistantId.Text = row.Cells["AssistantID"].Value?.ToString();
                txtAssistantName.Text = row.Cells["Name"].Value?.ToString();
                txtConNo.Text = row.Cells["Contact"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Assistant assistant = new Assistant
            {
                Name = txtAssistantName.Text.Trim(),
                Contact = txtConNo.Text.Trim(),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Available"
            };
            string errorMsg;
            int newId = _assistantService.RegisterAssistant(assistant, out errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Assistant added successfully.");
                txtAssistantId.Text = newId.ToString();
                LoadAssistantsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAssistantId.Text, out int assistantId)) return;
            _assistantService.DeleteAssistant(assistantId, out string errorMsg);
            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show("Assistant marked as inactive.");
                LoadAssistantsGrid();
            }
            else
            {
                MessageBox.Show(errorMsg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
