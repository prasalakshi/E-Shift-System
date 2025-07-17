namespace e___Shift_System.Forms
{
    partial class Customer_Login
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
            label1 = new Label();
            btnSignIn = new Button();
            linkLForgotPW = new LinkLabel();
            txtCusUN = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCusPW = new TextBox();
            label5 = new Label();
            linkLSignUp = new LinkLabel();
            pictureBox2 = new PictureBox();
            btnBack = new Button();
            linkLableExit = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 174);
            label1.Name = "label1";
            label1.Size = new Size(248, 28);
            label1.TabIndex = 0;
            label1.Text = "Login as a Customer";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = SystemColors.ActiveCaption;
            btnSignIn.Location = new Point(632, 465);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(150, 40);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // linkLForgotPW
            // 
            linkLForgotPW.AutoSize = true;
            linkLForgotPW.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLForgotPW.Location = new Point(659, 377);
            linkLForgotPW.Name = "linkLForgotPW";
            linkLForgotPW.Size = new Size(123, 18);
            linkLForgotPW.TabIndex = 3;
            linkLForgotPW.TabStop = true;
            linkLForgotPW.Text = "Forgot password?";
            // 
            // txtCusUN
            // 
            txtCusUN.Location = new Point(659, 263);
            txtCusUN.Name = "txtCusUN";
            txtCusUN.Size = new Size(260, 29);
            txtCusUN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 266);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 329);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // txtCusPW
            // 
            txtCusPW.Location = new Point(659, 326);
            txtCusPW.Name = "txtCusPW";
            txtCusPW.PasswordChar = '.';
            txtCusPW.Size = new Size(260, 29);
            txtCusPW.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F);
            label5.Location = new Point(536, 569);
            label5.Name = "label5";
            label5.Size = new Size(255, 21);
            label5.TabIndex = 9;
            label5.Text = "If you haven't an account please ";
            // 
            // linkLSignUp
            // 
            linkLSignUp.AutoSize = true;
            linkLSignUp.Font = new Font("Tahoma", 10.2F);
            linkLSignUp.Location = new Point(785, 569);
            linkLSignUp.Name = "linkLSignUp";
            linkLSignUp.Size = new Size(66, 21);
            linkLSignUp.TabIndex = 5;
            linkLSignUp.TabStop = true;
            linkLSignUp.Text = "Sign Up";
            linkLSignUp.LinkClicked += linkLSignUp_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(40, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(79, 738);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // linkLableExit
            // 
            linkLableExit.AutoSize = true;
            linkLableExit.LinkColor = Color.Red;
            linkLableExit.Location = new Point(1314, 38);
            linkLableExit.Name = "linkLableExit";
            linkLableExit.Size = new Size(39, 22);
            linkLableExit.TabIndex = 7;
            linkLableExit.TabStop = true;
            linkLableExit.Text = "Exit";
            linkLableExit.LinkClicked += linkLableExit_LinkClicked;
            // 
            // Customer_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(linkLableExit);
            Controls.Add(btnBack);
            Controls.Add(pictureBox2);
            Controls.Add(linkLSignUp);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtCusPW);
            Controls.Add(label2);
            Controls.Add(linkLForgotPW);
            Controls.Add(btnSignIn);
            Controls.Add(txtCusUN);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Customer_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Login";
            Load += Customer_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSignIn;
        private LinkLabel linkLForgotPW;
        private TextBox txtCusUN;
        private Label label2;
        private Label label3;
        private TextBox txtCusPW;
        private Label label5;
        private LinkLabel linkLSignUp;
        private PictureBox pictureBox2;
        private Button btnBack;
        private LinkLabel linkLableExit;
    }
}