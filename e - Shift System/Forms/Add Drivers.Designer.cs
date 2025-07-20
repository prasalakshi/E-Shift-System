namespace e___Shift_System.Forms
{
    partial class Add_Drivers
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
            txtLicenseNo = new TextBox();
            label5 = new Label();
            txtDriverName = new TextBox();
            label4 = new Label();
            txtDriverID = new TextBox();
            label2 = new Label();
            txtDriverConNo = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnBack = new Button();
            dataGridViewAddDrivers = new DataGridView();
            btnDelete = new Button();
            cmbStatus = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddDrivers).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 310);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 22);
            label9.TabIndex = 57;
            label9.Text = "License Number";
            // 
            // txtLicenseNo
            // 
            txtLicenseNo.Location = new Point(212, 310);
            txtLicenseNo.Margin = new Padding(5, 3, 5, 3);
            txtLicenseNo.MaxLength = 10;
            txtLicenseNo.Name = "txtLicenseNo";
            txtLicenseNo.Size = new Size(377, 29);
            txtLicenseNo.TabIndex = 52;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 235);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 22);
            label5.TabIndex = 56;
            label5.Text = "Driver Name";
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(212, 235);
            txtDriverName.Margin = new Padding(5, 3, 5, 3);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(377, 29);
            txtDriverName.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 163);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 55;
            label4.Text = "Driver ID";
            // 
            // txtDriverID
            // 
            txtDriverID.Location = new Point(212, 164);
            txtDriverID.Margin = new Padding(5, 3, 5, 3);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.Size = new Size(377, 29);
            txtDriverID.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 376);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 22);
            label2.TabIndex = 54;
            label2.Text = "Contact Number";
            // 
            // txtDriverConNo
            // 
            txtDriverConNo.Location = new Point(212, 376);
            txtDriverConNo.Margin = new Padding(5, 3, 5, 3);
            txtDriverConNo.Name = "txtDriverConNo";
            txtDriverConNo.Size = new Size(377, 29);
            txtDriverConNo.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(25, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 81);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 58;
            label1.Text = "Add Drivers";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(319, 515);
            btnEdit.Margin = new Padding(5, 3, 5, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 48);
            btnEdit.TabIndex = 61;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(43, 515);
            btnAdd.Margin = new Padding(5, 3, 5, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 48);
            btnAdd.TabIndex = 60;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(43, 599);
            btnClear.Margin = new Padding(5, 3, 5, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 48);
            btnClear.TabIndex = 62;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(43, 684);
            btnBack.Margin = new Padding(5, 3, 5, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 48);
            btnBack.TabIndex = 63;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewAddDrivers
            // 
            dataGridViewAddDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddDrivers.Location = new Point(634, 163);
            dataGridViewAddDrivers.Name = "dataGridViewAddDrivers";
            dataGridViewAddDrivers.RowHeadersWidth = 51;
            dataGridViewAddDrivers.Size = new Size(747, 651);
            dataGridViewAddDrivers.TabIndex = 64;
            dataGridViewAddDrivers.CellClick += dataGridViewAddDrivers_CellContentClick;
            dataGridViewAddDrivers.CellContentClick += dataGridViewAddDrivers_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(319, 599);
            btnDelete.Margin = new Padding(5, 3, 5, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 48);
            btnDelete.TabIndex = 81;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(212, 440);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(377, 30);
            cmbStatus.TabIndex = 106;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 443);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 105;
            label3.Text = "Status";
            // 
            // Add_Drivers
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewAddDrivers);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(txtLicenseNo);
            Controls.Add(label5);
            Controls.Add(txtDriverName);
            Controls.Add(label4);
            Controls.Add(txtDriverID);
            Controls.Add(label2);
            Controls.Add(txtDriverConNo);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_Drivers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Drivers";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private TextBox txtLicenseNo;
        private Label label5;
        private TextBox txtDriverName;
        private Label label4;
        private TextBox txtDriverID;
        private Label label2;
        private TextBox txtDriverConNo;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnClear;
        private Button btnBack;
        private DataGridView dataGridViewAddDrivers;
        private Button btnDelete;
        private ComboBox cmbStatus;
        private Label label3;
    }
}