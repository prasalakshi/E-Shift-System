using e___Shift_System.Models;
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
    public partial class Customer_Dashboard : Form
    {
        private readonly Customer _customer;
        public Customer_Dashboard(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        public Customer_Dashboard()
        {
            InitializeComponent();
            _customer = new Customer(); // Initialize _customer with a default instance
        }

        private void menuStripMyJobs_Click(object sender, EventArgs e)
        {

        }

        private void menuStripMyLoads_Click(object sender, EventArgs e)
        {

        }

        private void menuStripTransportInfo_Click(object sender, EventArgs e)
        {


        }

        private void menuStripProfile_Click(object sender, EventArgs e)
        {

        }

        private void menuStripLogoutC_Click(object sender, EventArgs e)
        {
            
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnMyJobs_Click(object sender, EventArgs e)
        {
            My_Jobs myJobsForm = new My_Jobs(_customer.CustomerID, _customer);
            myJobsForm.Show();
            this.Hide();
        }

            
        private void btnMyLoads_Click(object sender, EventArgs e)
        {
            Form My_Loads = new My_Loads();
            My_Loads.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Form Profile = new Profile(_customer.CustomerID);
            Profile.Show();
            this.Hide();
        }

        private void btnTransportInfo_Click(object sender, EventArgs e)
        {
            Form Transport_Info = new Transport_Info();
            Transport_Info.Show();
            this.Hide();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form Customer_Login = new Customer_Login();
                Customer_Login.Show();
                this.Hide();
            }
        }
    }
}
