namespace e___Shift_System.Forms
{
    partial class Admin_Login
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
            label3 = new Label();
            txtAdminPW = new TextBox();
            label2 = new Label();
            linkLForgotPW = new LinkLabel();
            btnLogin = new Button();
            txtAdminUN = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            linkLableExit = new LinkLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 351);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // txtAdminPW
            // 
            txtAdminPW.Location = new Point(648, 347);
            txtAdminPW.Margin = new Padding(4, 3, 4, 3);
            txtAdminPW.Name = "txtAdminPW";
            txtAdminPW.PasswordChar = '.';
            txtAdminPW.Size = new Size(324, 29);
            txtAdminPW.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 281);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 15;
            label2.Text = "Username";
            // 
            // linkLForgotPW
            // 
            linkLForgotPW.AutoSize = true;
            linkLForgotPW.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLForgotPW.Location = new Point(648, 403);
            linkLForgotPW.Margin = new Padding(4, 0, 4, 0);
            linkLForgotPW.Name = "linkLForgotPW";
            linkLForgotPW.Size = new Size(123, 18);
            linkLForgotPW.TabIndex = 4;
            linkLForgotPW.TabStop = true;
            linkLForgotPW.Text = "Forgot password?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Location = new Point(605, 497);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtAdminUN
            // 
            txtAdminUN.Location = new Point(648, 278);
            txtAdminUN.Margin = new Padding(4, 3, 4, 3);
            txtAdminUN.Name = "txtAdminUN";
            txtAdminUN.Size = new Size(324, 29);
            txtAdminUN.TabIndex = 1;
            txtAdminUN.TextChanged += txtAdminUN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(577, 183);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 11;
            label1.Text = "Login as an Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(34, 29);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(0, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(34, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(64, 737);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // linkLableExit
            // 
            linkLableExit.AutoSize = true;
            linkLableExit.LinkColor = Color.Red;
            linkLableExit.Location = new Point(1332, 38);
            linkLableExit.Name = "linkLableExit";
            linkLableExit.Size = new Size(39, 22);
            linkLableExit.TabIndex = 6;
            linkLableExit.TabStop = true;
            linkLableExit.Text = "Exit";
            linkLableExit.LinkClicked += linkLableExit_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(642, 587);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 22);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(linkLabel1);
            Controls.Add(linkLableExit);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txtAdminPW);
            Controls.Add(label2);
            Controls.Add(linkLForgotPW);
            Controls.Add(btnLogin);
            Controls.Add(txtAdminUN);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login";
            Load += Admin_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox txtAdminPW;
        private Label label2;
        private LinkLabel linkLForgotPW;
        private Button btnLogin;
        private TextBox txtAdminUN;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnBack;
        private LinkLabel linkLableExit;
        private LinkLabel linkLabel1;
    }
}