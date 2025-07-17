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
            btnProfile = new Button();
            btnTransportInfo = new Button();
            btnMyLoads = new Button();
            btnMyJobs = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            label1.Location = new Point(578, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 34);
            label1.TabIndex = 36;
            label1.Text = "Admin Dashboard";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = SystemColors.ActiveCaption;
            btnProfile.Font = new Font("Tahoma", 12F);
            btnProfile.Location = new Point(210, 372);
            btnProfile.Margin = new Padding(4, 3, 4, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(391, 100);
            btnProfile.TabIndex = 35;
            btnProfile.Text = "Job Management";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnTransportInfo
            // 
            btnTransportInfo.BackColor = SystemColors.ActiveCaption;
            btnTransportInfo.Font = new Font("Tahoma", 12F);
            btnTransportInfo.Location = new Point(813, 372);
            btnTransportInfo.Margin = new Padding(4, 3, 4, 3);
            btnTransportInfo.Name = "btnTransportInfo";
            btnTransportInfo.Size = new Size(391, 100);
            btnTransportInfo.TabIndex = 34;
            btnTransportInfo.Text = "Load Management";
            btnTransportInfo.UseVisualStyleBackColor = false;
            // 
            // btnMyLoads
            // 
            btnMyLoads.BackColor = SystemColors.ActiveCaption;
            btnMyLoads.Font = new Font("Tahoma", 12F);
            btnMyLoads.Location = new Point(813, 223);
            btnMyLoads.Margin = new Padding(4, 3, 4, 3);
            btnMyLoads.Name = "btnMyLoads";
            btnMyLoads.Size = new Size(391, 100);
            btnMyLoads.TabIndex = 33;
            btnMyLoads.Text = "Customer Management";
            btnMyLoads.UseVisualStyleBackColor = false;
            btnMyLoads.Click += btnMyLoads_Click;
            // 
            // btnMyJobs
            // 
            btnMyJobs.BackColor = SystemColors.ActiveCaption;
            btnMyJobs.Font = new Font("Tahoma", 12F);
            btnMyJobs.Location = new Point(210, 223);
            btnMyJobs.Margin = new Padding(4, 3, 4, 3);
            btnMyJobs.Name = "btnMyJobs";
            btnMyJobs.Size = new Size(391, 100);
            btnMyJobs.TabIndex = 32;
            btnMyJobs.Text = "User Management";
            btnMyJobs.UseVisualStyleBackColor = false;
            btnMyJobs.Click += btnMyJobs_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Tahoma", 12F);
            button1.Location = new Point(210, 686);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(391, 100);
            button1.TabIndex = 41;
            button1.Text = "Audit Logs";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Tahoma", 12F);
            button2.Location = new Point(813, 686);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(391, 100);
            button2.TabIndex = 40;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Tahoma", 12F);
            button3.Location = new Point(813, 527);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(391, 100);
            button3.TabIndex = 39;
            button3.Text = "Reports";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Tahoma", 12F);
            button4.Location = new Point(210, 527);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(391, 100);
            button4.TabIndex = 38;
            button4.Text = "Transport Unit Management";
            button4.UseVisualStyleBackColor = false;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(linkLabelLogout);
            Controls.Add(label1);
            Controls.Add(btnProfile);
            Controls.Add(btnTransportInfo);
            Controls.Add(btnMyLoads);
            Controls.Add(btnMyJobs);
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
        private Button btnProfile;
        private Button btnTransportInfo;
        private Button btnMyLoads;
        private Button btnMyJobs;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}