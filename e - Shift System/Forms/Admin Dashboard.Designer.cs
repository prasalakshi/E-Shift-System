namespace e___Shift_System.Forms
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            linkLabelLogout = new LinkLabel();
            label1 = new Label();
            btnLoadManagement = new Button();
            btnCustomerManagement = new Button();
            btnUserManagement = new Button();
            btnAddLorries = new Button();
            btnAddDrivers = new Button();
            btnReports = new Button();
            btnTransportUnitManagement = new Button();
            btnJobManagement = new Button();
            btnAddAssistants = new Button();
            btnAddContainers = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(32, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLogout.LinkColor = Color.Red;
            linkLabelLogout.Location = new Point(1224, 75);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(71, 24);
            linkLabelLogout.TabIndex = 37;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 34);
            label1.TabIndex = 36;
            label1.Text = "Admin Dashboard";
            // 
            // btnLoadManagement
            // 
            btnLoadManagement.BackColor = SystemColors.ActiveCaption;
            btnLoadManagement.Font = new Font("Tahoma", 12F);
            btnLoadManagement.Location = new Point(759, 283);
            btnLoadManagement.Margin = new Padding(4, 3, 4, 3);
            btnLoadManagement.Name = "btnLoadManagement";
            btnLoadManagement.Size = new Size(391, 101);
            btnLoadManagement.TabIndex = 34;
            btnLoadManagement.Text = "Load Management";
            btnLoadManagement.UseVisualStyleBackColor = false;
            btnLoadManagement.Click += btnLoadManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.BackColor = SystemColors.ActiveCaption;
            btnCustomerManagement.Font = new Font("Tahoma", 12F);
            btnCustomerManagement.Location = new Point(759, 162);
            btnCustomerManagement.Margin = new Padding(4, 3, 4, 3);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(391, 101);
            btnCustomerManagement.TabIndex = 33;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = false;
            btnCustomerManagement.Click += btnMyLoads_Click;
            // 
            // btnUserManagement
            // 
            btnUserManagement.BackColor = SystemColors.ActiveCaption;
            btnUserManagement.Font = new Font("Tahoma", 12F);
            btnUserManagement.Location = new Point(316, 162);
            btnUserManagement.Margin = new Padding(4, 3, 4, 3);
            btnUserManagement.Name = "btnUserManagement";
            btnUserManagement.Size = new Size(391, 101);
            btnUserManagement.TabIndex = 32;
            btnUserManagement.Text = "User Management";
            btnUserManagement.UseVisualStyleBackColor = false;
            btnUserManagement.Click += btnMyJobs_Click;
            // 
            // btnAddLorries
            // 
            btnAddLorries.BackColor = SystemColors.ActiveCaption;
            btnAddLorries.Font = new Font("Tahoma", 12F);
            btnAddLorries.Location = new Point(316, 537);
            btnAddLorries.Margin = new Padding(4, 3, 4, 3);
            btnAddLorries.Name = "btnAddLorries";
            btnAddLorries.Size = new Size(391, 101);
            btnAddLorries.TabIndex = 41;
            btnAddLorries.Text = "Add Lorries";
            btnAddLorries.UseVisualStyleBackColor = false;
            btnAddLorries.Click += btnAddLorries_Click;
            // 
            // btnAddDrivers
            // 
            btnAddDrivers.BackColor = SystemColors.ActiveCaption;
            btnAddDrivers.Font = new Font("Tahoma", 12F);
            btnAddDrivers.Location = new Point(759, 537);
            btnAddDrivers.Margin = new Padding(4, 3, 4, 3);
            btnAddDrivers.Name = "btnAddDrivers";
            btnAddDrivers.Size = new Size(391, 101);
            btnAddDrivers.TabIndex = 40;
            btnAddDrivers.Text = "Add Drivers";
            btnAddDrivers.UseVisualStyleBackColor = false;
            btnAddDrivers.Click += btnAddDrivers_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = SystemColors.ActiveCaption;
            btnReports.Font = new Font("Tahoma", 12F);
            btnReports.Location = new Point(759, 412);
            btnReports.Margin = new Padding(4, 3, 4, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(391, 101);
            btnReports.TabIndex = 39;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // btnTransportUnitManagement
            // 
            btnTransportUnitManagement.BackColor = SystemColors.ActiveCaption;
            btnTransportUnitManagement.Font = new Font("Tahoma", 12F);
            btnTransportUnitManagement.Location = new Point(316, 412);
            btnTransportUnitManagement.Margin = new Padding(4, 3, 4, 3);
            btnTransportUnitManagement.Name = "btnTransportUnitManagement";
            btnTransportUnitManagement.Size = new Size(391, 101);
            btnTransportUnitManagement.TabIndex = 38;
            btnTransportUnitManagement.Text = "Transport Unit Management";
            btnTransportUnitManagement.UseVisualStyleBackColor = false;
            // 
            // btnJobManagement
            // 
            btnJobManagement.BackColor = SystemColors.ActiveCaption;
            btnJobManagement.Font = new Font("Tahoma", 12F);
            btnJobManagement.Location = new Point(316, 293);
            btnJobManagement.Margin = new Padding(4, 3, 4, 3);
            btnJobManagement.Name = "btnJobManagement";
            btnJobManagement.Size = new Size(391, 101);
            btnJobManagement.TabIndex = 42;
            btnJobManagement.Text = "Job Management";
            btnJobManagement.UseVisualStyleBackColor = false;
            btnJobManagement.Click += btnJobManagement_Click;
            // 
            // btnAddAssistants
            // 
            btnAddAssistants.BackColor = SystemColors.ActiveCaption;
            btnAddAssistants.Font = new Font("Tahoma", 12F);
            btnAddAssistants.Location = new Point(316, 667);
            btnAddAssistants.Margin = new Padding(4, 3, 4, 3);
            btnAddAssistants.Name = "btnAddAssistants";
            btnAddAssistants.Size = new Size(391, 101);
            btnAddAssistants.TabIndex = 43;
            btnAddAssistants.Text = "Add Assistants";
            btnAddAssistants.UseVisualStyleBackColor = false;
            btnAddAssistants.Click += btnAddAssistants_Click;
            // 
            // btnAddContainers
            // 
            btnAddContainers.BackColor = SystemColors.ActiveCaption;
            btnAddContainers.Font = new Font("Tahoma", 12F);
            btnAddContainers.Location = new Point(759, 667);
            btnAddContainers.Margin = new Padding(4, 3, 4, 3);
            btnAddContainers.Name = "btnAddContainers";
            btnAddContainers.Size = new Size(391, 101);
            btnAddContainers.TabIndex = 44;
            btnAddContainers.Text = "Add Containers";
            btnAddContainers.UseVisualStyleBackColor = false;
            btnAddContainers.Click += btnAddContainers_Click;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(btnAddContainers);
            Controls.Add(btnAddAssistants);
            Controls.Add(btnJobManagement);
            Controls.Add(btnAddLorries);
            Controls.Add(btnAddDrivers);
            Controls.Add(btnReports);
            Controls.Add(btnTransportUnitManagement);
            Controls.Add(linkLabelLogout);
            Controls.Add(label1);
            Controls.Add(btnLoadManagement);
            Controls.Add(btnCustomerManagement);
            Controls.Add(btnUserManagement);
            Controls.Add(pictureBox2);
            Name = "Admin_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private LinkLabel linkLabelLogout;
        private Label label1;
        private Button btnLoadManagement;
        private Button btnCustomerManagement;
        private Button btnUserManagement;
        private Button btnAddLorries;
        private Button btnAddDrivers;
        private Button btnReports;
        private Button btnTransportUnitManagement;
        private Button btnJobManagement;
        private Button btnAddAssistants;
        private Button btnAddContainers;
    }
}