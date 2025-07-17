namespace e___Shift_System.Forms
{
    partial class Admin_Registration
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
            linkLableExit = new LinkLabel();
            btnClear = new Button();
            label9 = new Label();
            txtConNo = new TextBox();
            label6 = new Label();
            txtConfirmPW = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtPW = new TextBox();
            label2 = new Label();
            btnSignUp = new Button();
            txtUN = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLableExit
            // 
            linkLableExit.AutoSize = true;
            linkLableExit.LinkColor = Color.Red;
            linkLableExit.Location = new Point(1486, 50);
            linkLableExit.Margin = new Padding(4, 0, 4, 0);
            linkLableExit.Name = "linkLableExit";
            linkLableExit.Size = new Size(39, 22);
            linkLableExit.TabIndex = 50;
            linkLableExit.TabStop = true;
            linkLableExit.Text = "Exit";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(831, 628);
            btnClear.Margin = new Padding(5, 3, 5, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 48);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(328, 343);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 49;
            label9.Text = "Contact Number";
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(575, 339);
            txtConNo.Margin = new Padding(5, 3, 5, 3);
            txtConNo.MaxLength = 10;
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(535, 29);
            txtConNo.TabIndex = 36;
            txtConNo.TextChanged += txtConNo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 547);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(152, 22);
            label6.TabIndex = 48;
            label6.Text = "Confirm Password";
            // 
            // txtConfirmPW
            // 
            txtConfirmPW.Location = new Point(575, 544);
            txtConfirmPW.Margin = new Padding(5, 3, 5, 3);
            txtConfirmPW.Name = "txtConfirmPW";
            txtConfirmPW.PasswordChar = '.';
            txtConfirmPW.Size = new Size(535, 29);
            txtConfirmPW.TabIndex = 39;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(-130, 50);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 268);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 46;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(575, 264);
            txtEmail.Margin = new Padding(5, 3, 5, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(535, 29);
            txtEmail.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 196);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 45;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(575, 193);
            txtName.Margin = new Padding(5, 3, 5, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(535, 29);
            txtName.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 484);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 44;
            label3.Text = "Password";
            // 
            // txtPW
            // 
            txtPW.Location = new Point(575, 481);
            txtPW.Margin = new Padding(5, 3, 5, 3);
            txtPW.Name = "txtPW";
            txtPW.PasswordChar = '.';
            txtPW.Size = new Size(535, 29);
            txtPW.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 409);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 43;
            label2.Text = "Username";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Location = new Point(424, 628);
            btnSignUp.Margin = new Padding(5, 3, 5, 3);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(182, 48);
            btnSignUp.TabIndex = 40;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtUN
            // 
            txtUN.Location = new Point(575, 405);
            txtUN.Margin = new Padding(5, 3, 5, 3);
            txtUN.Name = "txtUN";
            txtUN.Size = new Size(535, 29);
            txtUN.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(598, 114);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 28);
            label1.TabIndex = 42;
            label1.Text = "Admin Registration";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(56, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // Admin_Registration
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(linkLableExit);
            Controls.Add(btnClear);
            Controls.Add(label9);
            Controls.Add(txtConNo);
            Controls.Add(label6);
            Controls.Add(txtConfirmPW);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtPW);
            Controls.Add(label2);
            Controls.Add(btnSignUp);
            Controls.Add(txtUN);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Admin_Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Registration";
            Load += Admin_Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLableExit;
        private Button btnClear;
        private Label label9;
        private TextBox txtConNo;
        private Label label6;
        private TextBox txtConfirmPW;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label3;
        private TextBox txtPW;
        private Label label2;
        private Button btnSignUp;
        private TextBox txtUN;
        private Label label1;
        private PictureBox pictureBox1;
    }
}