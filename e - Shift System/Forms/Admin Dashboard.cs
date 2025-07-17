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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void menuStripUserManage_Click(object sender, EventArgs e)
        {
            Form User_Management = new User_Management();
            User_Management.Show();
            this.Hide();
        }

        private void menuStripCusManage_Click(object sender, EventArgs e)
        {
            Form Customer_Management = new Customer_Management();
            Customer_Management.Show();
            this.Hide();
        }

        private void menuStripJobManage_Click(object sender, EventArgs e)
        {
            Form Job_Management = new Job_Management();
            Job_Management.Show();
            this.Hide();
        }

        private void menuStripLoadManage_Click(object sender, EventArgs e)
        {
            Form Load_Management = new Load_Management();
            Load_Management.Show();
            this.Hide();
        }

        private void menuStripTransportManage_Click(object sender, EventArgs e)
        {
            Form Transport_Unit_Management = new Transport_Unit_Management();
            Transport_Unit_Management.Show();
            this.Hide();
        }

        private void menuStripReport_Click(object sender, EventArgs e)
        {
            Form Reports = new Reports();
            Reports.Show();
            this.Hide();
        }

        private void menuStripSetting_Click(object sender, EventArgs e)
        {
            Form Setting = new Setting();
            Setting.Show();
            this.Hide();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStripLogoutA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form Customer_Login = new Customer_Login();
                Customer_Login.Show();
                this.Hide();
            }
        }

        private void btnMyJobs_Click(object sender, EventArgs e)
        {
            Form userManagement = new User_Management();
            userManagement.Show();
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

        private void btnMyLoads_Click(object sender, EventArgs e)
        {
            Form customerManegement = new Customer_Management();
            customerManegement.Show();
            this.Hide();
        }
    }
}
