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
    public partial class Customer_Management : Form
    {
        private int _selectedCustomerId;
        private readonly ICustomerService _customerService;
        public Customer_Management()
        {
            InitializeComponent();
            ICustomerRepository repo = new CustomerRepository();
            _customerService = new CustomerService(repo);
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            dataGridViewCustomerManagement.DataSource = null;
            dataGridViewCustomerManagement.DataSource = _customerService.GetAllCustomers();

            if (dataGridViewCustomerManagement.Columns["PasswordHash"] != null)
            {
                dataGridViewCustomerManagement.Columns["PasswordHash"].Visible = false;

            }
            _selectedCustomerId = -1;
        }
        private void Customer_Management_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCustomerManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCustomerManagement.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtConNo.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtUN.Text = row.Cells["Username"].Value?.ToString();

                // Track selected customer ID for edit/delete actions
                _selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);

                // Optional: enable Edit/Delete only for active customers
                string status = row.Cells["Status"].Value?.ToString();
                btnEdit.Enabled = btnDel.Enabled = (status == "Active");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _customerService.DeleteCustomer(_selectedCustomerId, out string errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Customer disabled successfully.", "Success");
                LoadCustomers(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void dataGridViewCustomerManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabelRegistercustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form cutomerRegistration = new Customer_Registration();
            cutomerRegistration.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form AdminDashboard = new Admin_Dashboard();
            AdminDashboard.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _customerService.EditCustomer(_selectedCustomerId, txtEmail.Text.Trim(), txtConNo.Text.Trim(), out string errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show("Customer updated successfully.", "Success");
                LoadCustomers(); 
            }
            else
            {
                MessageBox.Show(errorMessage, "Error");
            }
        }

        
    }
}
