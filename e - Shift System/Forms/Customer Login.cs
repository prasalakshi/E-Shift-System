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
    public partial class Customer_Login : Form
    {
        private readonly ICustomerService _customerService;

        public Customer_Login()
        {
            InitializeComponent();
            ICustomerRepository repo = new CustomerRepository();
            _customerService = new CustomerService(repo);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtCusUN.Text.Trim();
            string password = txtCusPW.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Customer customer = _customerService.AuthenticateCustomer(username, password);
                if (customer != null)
                {
                    // Check customer status before proceeding
                    if (customer.Status != "Active")
                    {
                        MessageBox.Show("Account is inactive. Please contact support.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Login successful!", "Welcome");
                    Customer_Dashboard dashboard = new Customer_Dashboard(customer);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging in: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void linkLSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form customerRegistration = new Customer_Registration();
            customerRegistration.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {
        }

        private void linkLableExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }

}

        
