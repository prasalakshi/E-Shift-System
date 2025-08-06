namespace e___Shift_System.Forms
{
    partial class Load_Management
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
            btnEdit = new Button();
            btnGenReport = new Button();
            label8 = new Label();
            txtLoadId = new TextBox();
            dtpPickupDate = new DateTimePicker();
            label6 = new Label();
            label2 = new Label();
            txtLoadDescription = new TextBox();
            label7 = new Label();
            txtJobId = new TextBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridViewLoadManagement = new DataGridView();
            label9 = new Label();
            txtStatus = new TextBox();
            dtpDeliveredDate = new DateTimePicker();
            label5 = new Label();
            btnAssignTransportUnit = new Button();
            btnClear = new Button();
            btnBack = new Button();
            label10 = new Label();
            txtTransportUnitId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadManagement).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(264, 555);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(204, 44);
            btnEdit.TabIndex = 147;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnGenReport
            // 
            btnGenReport.BackColor = SystemColors.ActiveCaption;
            btnGenReport.Location = new Point(1198, 706);
            btnGenReport.Margin = new Padding(4, 3, 4, 3);
            btnGenReport.Name = "btnGenReport";
            btnGenReport.Size = new Size(188, 44);
            btnGenReport.TabIndex = 146;
            btnGenReport.Text = "Generate Report";
            btnGenReport.UseVisualStyleBackColor = false;
            btnGenReport.Click += btnGenReport_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 132);
            label8.Name = "label8";
            label8.Size = new Size(73, 22);
            label8.TabIndex = 145;
            label8.Text = "Load ID";
            // 
            // txtLoadId
            // 
            txtLoadId.Location = new Point(180, 129);
            txtLoadId.Margin = new Padding(4, 3, 4, 3);
            txtLoadId.Name = "txtLoadId";
            txtLoadId.ReadOnly = true;
            txtLoadId.Size = new Size(288, 29);
            txtLoadId.TabIndex = 144;
            // 
            // dtpPickupDate
            // 
            dtpPickupDate.Location = new Point(180, 373);
            dtpPickupDate.Name = "dtpPickupDate";
            dtpPickupDate.Size = new Size(288, 29);
            dtpPickupDate.TabIndex = 141;
            dtpPickupDate.ValueChanged += dtpPickupDate_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 378);
            label6.Name = "label6";
            label6.Size = new Size(111, 22);
            label6.TabIndex = 140;
            label6.Text = "Pick Up Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 253);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 137;
            label2.Text = "Load Description";
            // 
            // txtLoadDescription
            // 
            txtLoadDescription.Location = new Point(180, 250);
            txtLoadDescription.Margin = new Padding(4, 3, 4, 3);
            txtLoadDescription.Name = "txtLoadDescription";
            txtLoadDescription.Size = new Size(288, 29);
            txtLoadDescription.TabIndex = 136;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 187);
            label7.Name = "label7";
            label7.Size = new Size(63, 22);
            label7.TabIndex = 135;
            label7.Text = "Job ID";
            // 
            // txtJobId
            // 
            txtJobId.Location = new Point(180, 184);
            txtJobId.Margin = new Padding(4, 3, 4, 3);
            txtJobId.Name = "txtJobId";
            txtJobId.ReadOnly = true;
            txtJobId.Size = new Size(288, 29);
            txtJobId.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(597, 72);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 133;
            label3.Text = "Load Management";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(21, 12);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 132;
            pictureBox3.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(21, 629);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 44);
            btnDelete.TabIndex = 131;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(21, 555);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 44);
            btnAdd.TabIndex = 130;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewLoadManagement
            // 
            dataGridViewLoadManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoadManagement.Location = new Point(504, 132);
            dataGridViewLoadManagement.Margin = new Padding(4, 3, 4, 3);
            dataGridViewLoadManagement.Name = "dataGridViewLoadManagement";
            dataGridViewLoadManagement.RowHeadersWidth = 51;
            dataGridViewLoadManagement.Size = new Size(882, 524);
            dataGridViewLoadManagement.TabIndex = 127;
            dataGridViewLoadManagement.CellClick += dataGridViewLoadManagement_CellContentClick;
            dataGridViewLoadManagement.CellContentClick += dataGridViewLoadManagement_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 320);
            label9.Name = "label9";
            label9.Size = new Size(59, 22);
            label9.TabIndex = 149;
            label9.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(180, 317);
            txtStatus.Margin = new Padding(4, 3, 4, 3);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(288, 29);
            txtStatus.TabIndex = 148;
            // 
            // dtpDeliveredDate
            // 
            dtpDeliveredDate.Location = new Point(180, 437);
            dtpDeliveredDate.Name = "dtpDeliveredDate";
            dtpDeliveredDate.Size = new Size(288, 29);
            dtpDeliveredDate.TabIndex = 152;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 442);
            label5.Name = "label5";
            label5.Size = new Size(124, 22);
            label5.TabIndex = 151;
            label5.Text = "Delivered Date";
            // 
            // btnAssignTransportUnit
            // 
            btnAssignTransportUnit.BackColor = SystemColors.ActiveCaption;
            btnAssignTransportUnit.Location = new Point(264, 629);
            btnAssignTransportUnit.Margin = new Padding(4, 3, 4, 3);
            btnAssignTransportUnit.Name = "btnAssignTransportUnit";
            btnAssignTransportUnit.Size = new Size(204, 44);
            btnAssignTransportUnit.TabIndex = 153;
            btnAssignTransportUnit.Text = "Assign Transport Unit";
            btnAssignTransportUnit.UseVisualStyleBackColor = false;
            btnAssignTransportUnit.Click += btnAssignUnit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(21, 706);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 44);
            btnClear.TabIndex = 154;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(264, 706);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(204, 44);
            btnBack.TabIndex = 155;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 496);
            label10.Name = "label10";
            label10.Size = new Size(149, 22);
            label10.TabIndex = 157;
            label10.Text = "Transport Unit ID";
            // 
            // txtTransportUnitId
            // 
            txtTransportUnitId.Location = new Point(180, 493);
            txtTransportUnitId.Margin = new Padding(4, 3, 4, 3);
            txtTransportUnitId.Name = "txtTransportUnitId";
            txtTransportUnitId.ReadOnly = true;
            txtTransportUnitId.Size = new Size(288, 29);
            txtTransportUnitId.TabIndex = 156;
            // 
            // Load_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(txtTransportUnitId);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnAssignTransportUnit);
            Controls.Add(dtpDeliveredDate);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(txtStatus);
            Controls.Add(btnEdit);
            Controls.Add(btnGenReport);
            Controls.Add(label8);
            Controls.Add(txtLoadId);
            Controls.Add(dtpPickupDate);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(txtLoadDescription);
            Controls.Add(label7);
            Controls.Add(txtJobId);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewLoadManagement);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Load_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Load_Management";
            Load += Load_Management_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoadManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateLoads;
        private Button btnGenReport;
        private Label label8;
        private TextBox txtLoadId;
        private TextBox txtShiftItems;
        private DateTimePicker dtpPickupDate;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox txtLoadDescription;
        private Label label7;
        private TextBox txtJobId;
        private Label label3;
        private PictureBox pictureBox3;
        private Button btnCancel;
        private Button btnEdit;
        private ComboBox cmbFilterbyCusID;
        private Label label1;
        private DataGridView dataGridViewLoadManagement;
        private Label label9;
        private TextBox txtStatus;
        private ComboBox comboBox1;
        private DateTimePicker dtpDeliveredDate;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnAssignTransportUnit;
        private Button btnClear;
        private Button btnBack;
        private Label label10;
        private TextBox txtTransportUnitId;
    }
}