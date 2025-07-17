using e___Shift_System.Business.Interface;
using e___Shift_System.Business.Services;
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
    public partial class User_Management : Form
    {
        private int _selectedAdminId;
        private readonly IAdminService _adminService;

        public User_Management()
        {
            InitializeComponent();
            IAdminRepository repo = new AdminRepository();
            _adminService = new AdminService(repo);
            LoadAdmins();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Admin_Registration = new Admin_Registration();
            Admin_Registration.Show();
            this.Hide();
        }

        private void dataGridViewUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUserManagement.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtConNo.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtUN.Text = row.Cells["Username"].Value?.ToString();

                
                _selectedAdminId = Convert.ToInt32(row.Cells["AdminID"].Value);
                string status = row.Cells["Status"].Value?.ToString();
                btnEdit.Enabled = btnDel.Enabled = (status == "Active");
            }
            if (dataGridViewUserManagement.Columns["PasswordHash"] != null)
            {   
                dataGridViewUserManagement.Columns.Remove("PasswordHash");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _adminService.EditAdmin(_selectedAdminId, txtEmail.Text.Trim(), txtConNo.Text.Trim(), out string errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Admin updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAdmins(); 
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _adminService.DeleteAdmin(_selectedAdminId, out string errorMessage);
            MessageBox.Show(string.IsNullOrEmpty(errorMessage) ? "Admin deleted (disabled) successfully." : errorMessage,
                            string.IsNullOrEmpty(errorMessage) ? "Success" : "Error");
            LoadAdmins();
        }

        private void LoadAdmins()
        {
            dataGridViewUserManagement.DataSource = null;
            dataGridViewUserManagement.DataSource = _adminService.GetAllAdmins();
                
            if (dataGridViewUserManagement.Columns["PasswordHash"] != null)
            {
                dataGridViewUserManagement.Columns["PasswordHash"].Visible = false;
                
            }
            _selectedAdminId = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            LoadAdmins();

        }
    }
}
