namespace e___Shift_System.Forms
{
    partial class Customer_Dashboard
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
            btnMyJobs = new Button();
            btnMyLoads = new Button();
            btnTransportInfo = new Button();
            btnProfile = new Button();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            linkLabelLogout = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(80, 56);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // btnMyJobs
            // 
            btnMyJobs.BackColor = SystemColors.ActiveCaption;
            btnMyJobs.Font = new Font("Tahoma", 12F);
            btnMyJobs.Location = new Point(220, 297);
            btnMyJobs.Margin = new Padding(4, 3, 4, 3);
            btnMyJobs.Name = "btnMyJobs";
            btnMyJobs.Size = new Size(391, 100);
            btnMyJobs.TabIndex = 4;
            btnMyJobs.Text = "My Jobs";
            btnMyJobs.UseVisualStyleBackColor = false;
            btnMyJobs.Click += btnMyJobs_Click;
            // 
            // btnMyLoads
            // 
            btnMyLoads.BackColor = SystemColors.ActiveCaption;
            btnMyLoads.Font = new Font("Tahoma", 12F);
            btnMyLoads.Location = new Point(823, 297);
            btnMyLoads.Margin = new Padding(4, 3, 4, 3);
            btnMyLoads.Name = "btnMyLoads";
            btnMyLoads.Size = new Size(391, 100);
            btnMyLoads.TabIndex = 5;
            btnMyLoads.Text = "My Loads";
            btnMyLoads.UseVisualStyleBackColor = false;
            btnMyLoads.Click += btnMyLoads_Click;
            // 
            // btnTransportInfo
            // 
            btnTransportInfo.BackColor = SystemColors.ActiveCaption;
            btnTransportInfo.Font = new Font("Tahoma", 12F);
            btnTransportInfo.Location = new Point(823, 479);
            btnTransportInfo.Margin = new Padding(4, 3, 4, 3);
            btnTransportInfo.Name = "btnTransportInfo";
            btnTransportInfo.Size = new Size(391, 100);
            btnTransportInfo.TabIndex = 6;
            btnTransportInfo.Text = "Transport Info";
            btnTransportInfo.UseVisualStyleBackColor = false;
            btnTransportInfo.Click += btnTransportInfo_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.ActiveCaption;
            btnProfile.Font = new Font("Tahoma", 12F);
            btnProfile.Location = new Point(220, 479);
            btnProfile.Margin = new Padding(4, 3, 4, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(391, 100);
            btnProfile.TabIndex = 7;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1604, 56);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 22);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(574, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 34);
            label1.TabIndex = 30;
            label1.Text = "Customer Dashboard";
            // 
            // linkLabelLogout
            // 
            linkLabelLogout.AutoSize = true;
            linkLabelLogout.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelLogout.LinkColor = Color.Red;
            linkLabelLogout.Location = new Point(1248, 56);
            linkLabelLogout.Name = "linkLabelLogout";
            linkLabelLogout.Size = new Size(71, 24);
            linkLabelLogout.TabIndex = 31;
            linkLabelLogout.TabStop = true;
            linkLabelLogout.Text = "Logout";
            linkLabelLogout.LinkClicked += linkLabelLogout_LinkClicked;
            // 
            // Customer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(linkLabelLogout);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnProfile);
            Controls.Add(btnTransportInfo);
            Controls.Add(btnMyLoads);
            Controls.Add(btnMyJobs);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Customer_Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            Load += Customer_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button btnMyJobs;
        private Button btnMyLoads;
        private Button btnTransportInfo;
        private Button btnProfile;
        private LinkLabel linkLabel1;
        private Label label1;
        private LinkLabel linkLabelLogout;
    }
}