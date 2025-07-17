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
    public partial class Customer_Registration : Form
    {
        private readonly ICustomerService _customerService;
        public Customer_Registration()
        {
            InitializeComponent();
            ICustomerRepository repo = new CustomerRepository();
            _customerService = new CustomerService(repo);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Customer_Login = new Customer_Login();
            Customer_Login.Show();
            this.Hide();
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contactNumber = txtConNo.Text.Trim();
            string username = txtUN.Text.Trim();
            string password = txtPW.Text;
            string confirmPassword = txtConfirmPW.Text;
            

            var customer = new Customer
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
                bool success = _customerService.RegisterCustomer(customer, confirmPassword, out errorMessage);
                if (success)
                {
                    MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form Customer_Login = new Customer_Login();
                    Customer_Login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
        {

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

        private void linkLableExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }


}
