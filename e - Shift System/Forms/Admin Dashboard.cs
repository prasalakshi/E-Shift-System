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

        }

        private void menuStripCusManage_Click(object sender, EventArgs e)
        {

        }

        private void menuStripJobManage_Click(object sender, EventArgs e)
        {

        }

        private void menuStripLoadManage_Click(object sender, EventArgs e)
        {

        }

        private void menuStripTransportManage_Click(object sender, EventArgs e)
        {

        }

        private void menuStripReport_Click(object sender, EventArgs e)
        {

        }

        private void menuStripSetting_Click(object sender, EventArgs e)
        {

        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStripLogoutA_Click(object sender, EventArgs e)
        {

        }

        private void btnMyJobs_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form Login = new Login();
                Login.Show();
                this.Hide();
            }
        }

        private void btnMyLoads_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnJobManagement_Click(object sender, EventArgs e)
        {
            Form jobManagement = new Job_Management();
            jobManagement.Show();
            this.Hide();
        }

        private void btnAddLorries_Click(object sender, EventArgs e)
        {
            Form AddLorry = new Add_Lorries();
            AddLorry.Show();
            this.Hide();
        }

        private void btnAddDrivers_Click(object sender, EventArgs e)
        {
            Form AddDrivers = new Add_Drivers();
            AddDrivers.Show();
            this.Hide();


        }

        private void btnAddAssistants_Click(object sender, EventArgs e)
        {
            Form AddAssistants = new Add_Assistants();
            AddAssistants.Show();
            this.Hide();
        }

        private void btnAddContainers_Click(object sender, EventArgs e)
        {
            Form AddContainers = new Add_containers();
            AddContainers.Show();
            this.Hide();
        }
    }
}
