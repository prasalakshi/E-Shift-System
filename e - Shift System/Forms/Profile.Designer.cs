namespace e___Shift_System.Forms
{
    partial class Profile
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
            label9 = new Label();
            txtConNo = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUN = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            label3 = new Label();
            txtCusId = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(307, 440);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 45;
            label9.Text = "Contact Number";
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(553, 436);
            txtConNo.Margin = new Padding(5, 3, 5, 3);
            txtConNo.MaxLength = 10;
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(567, 29);
            txtConNo.TabIndex = 35;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo1;
            pictureBox2.Location = new Point(56, 42);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 365);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 22);
            label5.TabIndex = 43;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(553, 362);
            txtEmail.Margin = new Padding(5, 3, 5, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(567, 29);
            txtEmail.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(307, 294);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 42;
            label4.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(553, 290);
            txtName.Margin = new Padding(5, 3, 5, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(567, 29);
            txtName.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 506);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 40;
            label2.Text = "Username";
            // 
            // txtUN
            // 
            txtUN.Location = new Point(553, 502);
            txtUN.Margin = new Padding(5, 3, 5, 3);
            txtUN.Name = "txtUN";
            txtUN.ReadOnly = true;
            txtUN.Size = new Size(567, 29);
            txtUN.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(639, 145);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 39;
            label1.Text = "Customer Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(56, 35);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(461, 600);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 44);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 232);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 50;
            label3.Text = "Customer ID";
            // 
            // txtCusId
            // 
            txtCusId.Location = new Point(553, 228);
            txtCusId.Margin = new Padding(5, 3, 5, 3);
            txtCusId.Name = "txtCusId";
            txtCusId.ReadOnly = true;
            txtCusId.Size = new Size(567, 29);
            txtCusId.TabIndex = 49;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(832, 600);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 51;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(txtCusId);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(txtConNo);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtUN);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtConNo;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUN;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Label label3;
        private TextBox txtCusId;
        private Button btnBack;
    }
}