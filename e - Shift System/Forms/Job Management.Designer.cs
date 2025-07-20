namespace e___Shift_System.Forms
{
    partial class Job_Management
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
            dataGridViewJobManagement = new DataGridView();
            label1 = new Label();
            cmbFilterbyCusID = new ComboBox();
            btnCancel = new Button();
            btnEdit = new Button();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            txtShiftItems = new TextBox();
            dtpJobDate = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            txtDestination = new TextBox();
            label2 = new Label();
            txtStartLocation = new TextBox();
            label7 = new Label();
            txtCusID = new TextBox();
            label8 = new Label();
            txtJobID = new TextBox();
            btnGenReport = new Button();
            btnCreateLoads = new Button();
            label9 = new Label();
            txtStatus = new TextBox();
            btnBack = new Button();
            label10 = new Label();
            btnClearFilter = new Button();
            dtpFilterJobDate = new DateTimePicker();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewJobManagement
            // 
            dataGridViewJobManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJobManagement.Location = new Point(487, 207);
            dataGridViewJobManagement.Margin = new Padding(4, 3, 4, 3);
            dataGridViewJobManagement.Name = "dataGridViewJobManagement";
            dataGridViewJobManagement.RowHeadersWidth = 51;
            dataGridViewJobManagement.Size = new Size(898, 498);
            dataGridViewJobManagement.TabIndex = 0;
            dataGridViewJobManagement.CellClick += dataGridViewJobManagement_CellContentClick;
            dataGridViewJobManagement.CellContentClick += dataGridViewJobManagement_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 155);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 22);
            label1.TabIndex = 1;
            label1.Text = "Filter by Customer ID";
            // 
            // cmbFilterbyCusID
            // 
            cmbFilterbyCusID.FormattingEnabled = true;
            cmbFilterbyCusID.Location = new Point(675, 151);
            cmbFilterbyCusID.Margin = new Padding(4, 3, 4, 3);
            cmbFilterbyCusID.Name = "cmbFilterbyCusID";
            cmbFilterbyCusID.Size = new Size(91, 30);
            cmbFilterbyCusID.TabIndex = 2;
            cmbFilterbyCusID.SelectedIndexChanged += cmbFilterbyCusID_SelectedIndexChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(263, 726);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 44);
            btnCancel.TabIndex = 109;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(32, 726);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 44);
            btnEdit.TabIndex = 108;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(25, 26);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 111;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(578, 86);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 28);
            label3.TabIndex = 112;
            label3.Text = "Job Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 428);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 122;
            label5.Text = "Shifting Items";
            // 
            // txtShiftItems
            // 
            txtShiftItems.Location = new Point(163, 425);
            txtShiftItems.Margin = new Padding(4, 3, 4, 3);
            txtShiftItems.Multiline = true;
            txtShiftItems.Name = "txtShiftItems";
            txtShiftItems.Size = new Size(288, 142);
            txtShiftItems.TabIndex = 121;
            // 
            // dtpJobDate
            // 
            dtpJobDate.Location = new Point(163, 364);
            dtpJobDate.Name = "dtpJobDate";
            dtpJobDate.Size = new Size(288, 29);
            dtpJobDate.TabIndex = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 364);
            label6.Name = "label6";
            label6.Size = new Size(80, 22);
            label6.TabIndex = 119;
            label6.Text = "Job Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 311);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 118;
            label4.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(163, 308);
            txtDestination.Margin = new Padding(4, 3, 4, 3);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(288, 29);
            txtDestination.TabIndex = 117;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 257);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 116;
            label2.Text = "Start Location";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(163, 254);
            txtStartLocation.Margin = new Padding(4, 3, 4, 3);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(288, 29);
            txtStartLocation.TabIndex = 115;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 202);
            label7.Name = "label7";
            label7.Size = new Size(110, 22);
            label7.TabIndex = 114;
            label7.Text = "Customer ID";
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(163, 199);
            txtCusID.Margin = new Padding(4, 3, 4, 3);
            txtCusID.Name = "txtCusID";
            txtCusID.ReadOnly = true;
            txtCusID.Size = new Size(288, 29);
            txtCusID.TabIndex = 113;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 155);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 124;
            label8.Text = "Job ID";
            // 
            // txtJobID
            // 
            txtJobID.Location = new Point(163, 152);
            txtJobID.Margin = new Padding(4, 3, 4, 3);
            txtJobID.Name = "txtJobID";
            txtJobID.ReadOnly = true;
            txtJobID.Size = new Size(288, 29);
            txtJobID.TabIndex = 123;
            txtJobID.TextChanged += txtJobID_TextChanged;
            // 
            // btnGenReport
            // 
            btnGenReport.BackColor = SystemColors.ActiveCaption;
            btnGenReport.Location = new Point(1197, 753);
            btnGenReport.Margin = new Padding(4, 3, 4, 3);
            btnGenReport.Name = "btnGenReport";
            btnGenReport.Size = new Size(188, 44);
            btnGenReport.TabIndex = 125;
            btnGenReport.Text = "Generate Report";
            btnGenReport.UseVisualStyleBackColor = false;
            btnGenReport.Click += btnGenReport_Click;
            // 
            // btnCreateLoads
            // 
            btnCreateLoads.BackColor = SystemColors.ActiveCaption;
            btnCreateLoads.Location = new Point(263, 661);
            btnCreateLoads.Margin = new Padding(4, 3, 4, 3);
            btnCreateLoads.Name = "btnCreateLoads";
            btnCreateLoads.Size = new Size(188, 44);
            btnCreateLoads.TabIndex = 126;
            btnCreateLoads.Text = "Create Load(s)";
            btnCreateLoads.UseVisualStyleBackColor = false;
            btnCreateLoads.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 599);
            label9.Name = "label9";
            label9.Size = new Size(59, 22);
            label9.TabIndex = 128;
            label9.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(163, 596);
            txtStatus.Margin = new Padding(4, 3, 4, 3);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(288, 29);
            txtStatus.TabIndex = 127;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(32, 797);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 129;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(811, 154);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(149, 22);
            label10.TabIndex = 130;
            label10.Text = "Filter by Job Date";
            // 
            // btnClearFilter
            // 
            btnClearFilter.BackColor = SystemColors.ActiveCaption;
            btnClearFilter.Location = new Point(1276, 144);
            btnClearFilter.Margin = new Padding(4, 3, 4, 3);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(109, 44);
            btnClearFilter.TabIndex = 132;
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += button1_Click_1;
            // 
            // dtpFilterJobDate
            // 
            dtpFilterJobDate.Location = new Point(967, 150);
            dtpFilterJobDate.Name = "dtpFilterJobDate";
            dtpFilterJobDate.Size = new Size(250, 29);
            dtpFilterJobDate.TabIndex = 133;
            dtpFilterJobDate.ValueChanged += dtpFilterJobDate_ValueChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.ActiveCaption;
            btnConfirm.Location = new Point(32, 661);
            btnConfirm.Margin = new Padding(4, 3, 4, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(188, 44);
            btnConfirm.TabIndex = 134;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // Job_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(btnConfirm);
            Controls.Add(dtpFilterJobDate);
            Controls.Add(btnClearFilter);
            Controls.Add(label10);
            Controls.Add(btnBack);
            Controls.Add(label9);
            Controls.Add(txtStatus);
            Controls.Add(btnCreateLoads);
            Controls.Add(btnGenReport);
            Controls.Add(label8);
            Controls.Add(txtJobID);
            Controls.Add(label5);
            Controls.Add(txtShiftItems);
            Controls.Add(dtpJobDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtDestination);
            Controls.Add(label2);
            Controls.Add(txtStartLocation);
            Controls.Add(label7);
            Controls.Add(txtCusID);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(cmbFilterbyCusID);
            Controls.Add(label1);
            Controls.Add(dataGridViewJobManagement);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Job_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job_Management";
            Load += Job_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJobManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewJobManagement;
        private Label label1;
        private ComboBox cmbFilterbyCusID;
        private Button btnCancel;
        private Button btnEdit;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label5;
        private TextBox txtShiftItems;
        private DateTimePicker dtpJobDate;
        private Label label6;
        private Label label4;
        private TextBox txtDestination;
        private Label label2;
        private TextBox txtStartLocation;
        private Label label7;
        private TextBox txtCusID;
        private Label label8;
        private TextBox txtJobID;
        private Button btnGenReport;
        private Button btnCreateLoads;
        private Label label9;
        private TextBox txtStatus;
        private Button btnBack;
        private Label label10;
        private Button btnClearFilter;
        private DateTimePicker dtpFilterJobDate;
        private Button btnConfirm;
    }
}