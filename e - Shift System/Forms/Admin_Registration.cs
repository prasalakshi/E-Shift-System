using e___Shift_System.Business.Interface;
using e___Shift_System.Business.Services;
using e___Shift_System.Models;
using e___Shift_System.Repository.Interface;
using e___Shift_System.Repository.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e___Shift_System.Forms
{
    public partial class Admin_Registration : Form
    {

        private readonly IAdminService _adminService;

        public Admin_Registration()
        {
            InitializeComponent();
            IAdminRepository repo = new AdminRepository();
            _adminService = new AdminService(repo);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtConNo.Text.Trim();
            string username = txtUN.Text.Trim();
            string password = txtPW.Text;
            string confirmPassword = txtConfirmPW.Text;


            var admin = new Admin
            {
                Name = name,
                Email = email,
                ContactNumber = contactNumber,
                Username = username,
                PasswordHash = ComputeSha256Hash(password),
                Status = "Active" 
            };

            try
            {
                string errorMessage;
                bool success = _adminService.RegisterAdmin(admin, confirmPassword, out errorMessage);
                if (success)
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form adminLogin = new Admin_Login();
                    adminLogin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SHA-256 hash function for password security
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }



        private void Clear()
        {
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtConNo.Text = string.Empty;
            txtUN.Text = string.Empty;
            txtPW.Text = string.Empty;
            txtConfirmPW.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Admin_Registration_Load(object sender, EventArgs e)
        {

        }

        private void txtConNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
