namespace e___Shift_System.Forms
{
    partial class Customer_Management
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
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            txtConNo = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUN = new TextBox();
            label1 = new Label();
            dataGridViewCustomerManagement = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDel = new Button();
            btnBack = new Button();
            btnEdit = new Button();
            linkLabelRegistercustomer = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomerManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1618, 224);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 22);
            linkLabel1.TabIndex = 95;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Admin";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 352);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 91;
            label9.Text = "Contact Number";
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(185, 346);
            txtConNo.Margin = new Padding(6, 3, 6, 3);
            txtConNo.MaxLength = 10;
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(282, 29);
            txtConNo.TabIndex = 85;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 270);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 90;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(185, 263);
            txtEmail.Margin = new Padding(6, 3, 6, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 29);
            txtEmail.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 190);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 89;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 185);
            txtName.Margin = new Padding(6, 3, 6, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(282, 29);
            txtName.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 425);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 88;
            label2.Text = "Username";
            // 
            // txtUN
            // 
            txtUN.Location = new Point(185, 418);
            txtUN.Margin = new Padding(6, 3, 6, 3);
            txtUN.Name = "txtUN";
            txtUN.ReadOnly = true;
            txtUN.Size = new Size(282, 29);
            txtUN.TabIndex = 86;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(571, 89);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(284, 28);
            label1.TabIndex = 87;
            label1.Text = "Customer Management";
            // 
            // dataGridViewCustomerManagement
            // 
            dataGridViewCustomerManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomerManagement.Location = new Point(512, 185);
            dataGridViewCustomerManagement.Margin = new Padding(4, 3, 4, 3);
            dataGridViewCustomerManagement.Name = "dataGridViewCustomerManagement";
            dataGridViewCustomerManagement.RowHeadersWidth = 51;
            dataGridViewCustomerManagement.Size = new Size(863, 615);
            dataGridViewCustomerManagement.TabIndex = 82;
            dataGridViewCustomerManagement.CellClick += dataGridViewCustomerManagement_CellClick;
            dataGridViewCustomerManagement.CellContentClick += dataGridViewCustomerManagement_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, 80);
            pictureBox1.Margin = new Padding(8, 4, 8, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 80;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(35, 29);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 96;
            pictureBox3.TabStop = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ActiveCaption;
            btnDel.Location = new Point(279, 497);
            btnDel.Margin = new Padding(4, 3, 4, 3);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(188, 44);
            btnDel.TabIndex = 99;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(35, 591);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 98;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(35, 497);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 44);
            btnEdit.TabIndex = 97;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // linkLabelRegistercustomer
            // 
            linkLabelRegistercustomer.AutoSize = true;
            linkLabelRegistercustomer.Location = new Point(1221, 128);
            linkLabelRegistercustomer.Name = "linkLabelRegistercustomer";
            linkLabelRegistercustomer.Size = new Size(154, 22);
            linkLabelRegistercustomer.TabIndex = 100;
            linkLabelRegistercustomer.TabStop = true;
            linkLabelRegistercustomer.Text = "Register Customer";
            // 
            // Customer_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(linkLabelRegistercustomer);
            Controls.Add(btnDel);
            Controls.Add(btnBack);
            Controls.Add(btnEdit);
            Controls.Add(pictureBox3);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(txtConNo);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtUN);
            Controls.Add(label1);
            Controls.Add(dataGridViewCustomerManagement);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Customer_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Management";
            Load += Customer_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomerManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label9;
        private TextBox txtConNo;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUN;
        private Label label1;
        private DataGridView dataGridViewCustomerManagement;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnDel;
        private Button btnBack;
        private Button btnEdit;
        private LinkLabel linkLabelRegistercustomer;
    }
}