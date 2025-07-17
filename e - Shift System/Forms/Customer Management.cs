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
            LoadAdmins();
        }
        private void LoadAdmins()
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


                _selectedCustomerId = Convert.ToInt32(row.Cells["AdminID"].Value);
                string status = row.Cells["Status"].Value?.ToString();
                btnEdit.Enabled = btnDel.Enabled = (status == "Active");
            }
            if (dataGridViewCustomerManagement.Columns["PasswordHash"] != null)
            {
                dataGridViewCustomerManagement.Columns.Remove("PasswordHash");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _customerService.DeleteCustomer(_selectedCustomerId, out string errorMessage);
            MessageBox.Show(string.IsNullOrEmpty(errorMessage) ? "Admin deleted (disabled) successfully." : errorMessage,
                            string.IsNullOrEmpty(errorMessage) ? "Success" : "Error");
            LoadAdmins();
        }

        private void dataGridViewCustomerManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
