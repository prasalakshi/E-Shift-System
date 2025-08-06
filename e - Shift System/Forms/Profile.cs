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
    public partial class Profile : Form
    {
        private readonly ICustomerService _customerService;
        private Customer _customer;

        public Profile(int customerId)
        {
            InitializeComponent();
            ICustomerRepository repo = new CustomerRepository();
            _customerService = new CustomerService(repo);
            _customer = _customerService.GetCustomerById(customerId);
            LoadProfile();
        }

        private void LoadProfile()
        {
            txtCusId.Text = _customer.CustomerID.ToString();
            txtName.Text = _customer.Name;
            txtUN.Text = _customer.Username;
            txtEmail.Text = _customer.Email;
            txtConNo.Text = _customer.ContactNumber;
        }


        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string contact = txtConNo.Text.Trim();

            if (!_customerService.ValidateCustomerProfile(email, contact, out string validationError))
            {
                MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _customer.Email = email;
            _customer.ContactNumber = contact;

            _customerService.UpdateCustomerProfile(_customer, out string updateError);

            if (string.IsNullOrEmpty(updateError))
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProfile();
            }
            else
            {
                MessageBox.Show(updateError, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Dashboard = new Customer_Dashboard(_customer);
            Dashboard.Show();
            this.Hide();
        }
    }
}
