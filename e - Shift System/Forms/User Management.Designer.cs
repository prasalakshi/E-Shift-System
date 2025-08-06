namespace e___Shift_System.Forms
{
    partial class User_Management
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
            pictureBox1 = new PictureBox();
            dataGridViewUserManagement = new DataGridView();
            label9 = new Label();
            txtConNo = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUN = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(-48, 35);
            pictureBox1.Margin = new Padding(6, 4, 6, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewUserManagement
            // 
            dataGridViewUserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserManagement.Location = new Point(515, 186);
            dataGridViewUserManagement.Name = "dataGridViewUserManagement";
            dataGridViewUserManagement.RowHeadersWidth = 51;
            dataGridViewUserManagement.Size = new Size(860, 607);
            dataGridViewUserManagement.TabIndex = 62;
            dataGridViewUserManagement.CellClick += dataGridViewUserManagement_CellContentClick;
            dataGridViewUserManagement.CellContentClick += dataGridViewUserManagement_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 344);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 75;
            label9.Text = "Contact Number";
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(209, 341);
            txtConNo.Margin = new Padding(5, 3, 5, 3);
            txtConNo.MaxLength = 10;
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(279, 29);
            txtConNo.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 269);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 73;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(209, 266);
            txtEmail.Margin = new Padding(5, 3, 5, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 29);
            txtEmail.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 197);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 72;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 195);
            txtName.Margin = new Padding(5, 3, 5, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(279, 29);
            txtName.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 410);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 70;
            label2.Text = "Username";
            // 
            // txtUN
            // 
            txtUN.Location = new Point(209, 407);
            txtUN.Margin = new Padding(5, 3, 5, 3);
            txtUN.Name = "txtUN";
            txtUN.ReadOnly = true;
            txtUN.Size = new Size(279, 29);
            txtUN.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 89);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 28);
            label1.TabIndex = 69;
            label1.Text = "User Management";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(36, 577);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 77;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(36, 483);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 44);
            btnEdit.TabIndex = 76;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ActiveCaption;
            btnDel.Location = new Point(300, 483);
            btnDel.Margin = new Padding(4, 3, 4, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(188, 44);
            btnDel.TabIndex = 78;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1246, 147);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 22);
            linkLabel1.TabIndex = 79;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(36, 29);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 80;
            pictureBox3.TabStop = false;
            // 
            // User_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(pictureBox3);
            Controls.Add(linkLabel1);
            Controls.Add(btnDel);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(label9);
            Controls.Add(txtConNo);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtUN);
            Controls.Add(label1);
            Controls.Add(dataGridViewUserManagement);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "User_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Management";
            Load += User_Management_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridViewUserManagement;
        private Label label9;
        private TextBox txtConNo;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUN;
        private Label label1;
        private Button btnBack;
        private Button btnEdit;
        private Button btnDel;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
    }
}