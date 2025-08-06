namespace e___Shift_System.Forms
{
    partial class Transport_Unit_Management
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
            label6 = new Label();
            txtTransportUnitID = new TextBox();
            label5 = new Label();
            btnBack = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnClear = new Button();
            btnAssign = new Button();
            label4 = new Label();
            cmbAssistant = new ComboBox();
            label3 = new Label();
            cmbDriver = new ComboBox();
            label2 = new Label();
            cmbContainer = new ComboBox();
            label1 = new Label();
            cmbLorry = new ComboBox();
            dataGridViewTransportUnitManagement = new DataGridView();
            label8 = new Label();
            txtJobID = new TextBox();
            label7 = new Label();
            txtLoadID = new TextBox();
            pictureBox3 = new PictureBox();
            btnGenReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransportUnitManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 185);
            label6.Name = "label6";
            label6.Size = new Size(143, 22);
            label6.TabIndex = 207;
            label6.Text = "Transport UnitID";
            // 
            // txtTransportUnitID
            // 
            txtTransportUnitID.Location = new Point(192, 182);
            txtTransportUnitID.Margin = new Padding(4, 3, 4, 3);
            txtTransportUnitID.Name = "txtTransportUnitID";
            txtTransportUnitID.ReadOnly = true;
            txtTransportUnitID.Size = new Size(288, 29);
            txtTransportUnitID.TabIndex = 206;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(534, 102);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(341, 28);
            label5.TabIndex = 205;
            label5.Text = "Transport Unit Management";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(44, 758);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 44);
            btnBack.TabIndex = 204;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(301, 681);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(179, 44);
            btnDelete.TabIndex = 203;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(301, 607);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(179, 44);
            btnEdit.TabIndex = 202;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(44, 681);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 44);
            btnClear.TabIndex = 201;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = SystemColors.ActiveCaption;
            btnAssign.Location = new Point(44, 607);
            btnAssign.Margin = new Padding(4, 3, 4, 3);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(175, 44);
            btnAssign.TabIndex = 200;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 541);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 199;
            label4.Text = "Assistant";
            // 
            // cmbAssistant
            // 
            cmbAssistant.FormattingEnabled = true;
            cmbAssistant.Location = new Point(192, 538);
            cmbAssistant.Name = "cmbAssistant";
            cmbAssistant.Size = new Size(288, 30);
            cmbAssistant.TabIndex = 198;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 484);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 197;
            label3.Text = "Driver";
            // 
            // cmbDriver
            // 
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(192, 481);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(288, 30);
            cmbDriver.TabIndex = 196;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 422);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 195;
            label2.Text = "Container";
            // 
            // cmbContainer
            // 
            cmbContainer.FormattingEnabled = true;
            cmbContainer.Location = new Point(192, 419);
            cmbContainer.Name = "cmbContainer";
            cmbContainer.Size = new Size(288, 30);
            cmbContainer.TabIndex = 194;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 362);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 193;
            label1.Text = "Lorry";
            // 
            // cmbLorry
            // 
            cmbLorry.FormattingEnabled = true;
            cmbLorry.Location = new Point(192, 359);
            cmbLorry.Name = "cmbLorry";
            cmbLorry.Size = new Size(288, 30);
            cmbLorry.TabIndex = 192;
            cmbLorry.SelectedIndexChanged += cmbLorry_SelectedIndexChanged;
            // 
            // dataGridViewTransportUnitManagement
            // 
            dataGridViewTransportUnitManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransportUnitManagement.Location = new Point(524, 182);
            dataGridViewTransportUnitManagement.Name = "dataGridViewTransportUnitManagement";
            dataGridViewTransportUnitManagement.RowHeadersWidth = 51;
            dataGridViewTransportUnitManagement.Size = new Size(859, 526);
            dataGridViewTransportUnitManagement.TabIndex = 191;
            dataGridViewTransportUnitManagement.CellClick += dataGridViewTransportUnitManagement_CellContentClick;
            dataGridViewTransportUnitManagement.CellContentClick += dataGridViewTransportUnitManagement_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 244);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 190;
            label8.Text = "Job ID";
            // 
            // txtJobID
            // 
            txtJobID.Location = new Point(192, 241);
            txtJobID.Margin = new Padding(4, 3, 4, 3);
            txtJobID.Name = "txtJobID";
            txtJobID.ReadOnly = true;
            txtJobID.Size = new Size(288, 29);
            txtJobID.TabIndex = 189;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 299);
            label7.Name = "label7";
            label7.Size = new Size(73, 22);
            label7.TabIndex = 188;
            label7.Text = "Load ID";
            // 
            // txtLoadID
            // 
            txtLoadID.Location = new Point(192, 296);
            txtLoadID.Margin = new Padding(4, 3, 4, 3);
            txtLoadID.Name = "txtLoadID";
            txtLoadID.ReadOnly = true;
            txtLoadID.Size = new Size(288, 29);
            txtLoadID.TabIndex = 187;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo1;
            pictureBox3.Location = new Point(40, 42);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 186;
            pictureBox3.TabStop = false;
            // 
            // btnGenReport
            // 
            btnGenReport.BackColor = SystemColors.ActiveCaption;
            btnGenReport.Location = new Point(1195, 758);
            btnGenReport.Margin = new Padding(4, 3, 4, 3);
            btnGenReport.Name = "btnGenReport";
            btnGenReport.Size = new Size(188, 44);
            btnGenReport.TabIndex = 208;
            btnGenReport.Text = "Generate Report";
            btnGenReport.UseVisualStyleBackColor = false;
            btnGenReport.Click += btnGenReport_Click;
            // 
            // Transport_Unit_Management
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(btnGenReport);
            Controls.Add(label6);
            Controls.Add(txtTransportUnitID);
            Controls.Add(label5);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnClear);
            Controls.Add(btnAssign);
            Controls.Add(label4);
            Controls.Add(cmbAssistant);
            Controls.Add(label3);
            Controls.Add(cmbDriver);
            Controls.Add(label2);
            Controls.Add(cmbContainer);
            Controls.Add(label1);
            Controls.Add(cmbLorry);
            Controls.Add(dataGridViewTransportUnitManagement);
            Controls.Add(label8);
            Controls.Add(txtJobID);
            Controls.Add(label7);
            Controls.Add(txtLoadID);
            Controls.Add(pictureBox3);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Transport_Unit_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transport_Unit_Management";
            Load += Transport_Unit_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransportUnitManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtTransportUnitID;
        private Label label5;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnClear;
        private Button btnAssign;
        private Label label4;
        private ComboBox cmbAssistant;
        private Label label3;
        private ComboBox cmbDriver;
        private Label label2;
        private ComboBox cmbContainer;
        private Label label1;
        private ComboBox cmbLorry;
        private DataGridView dataGridViewTransportUnitManagement;
        private Label label8;
        private TextBox txtJobID;
        private Label label7;
        private TextBox txtLoadID;
        private PictureBox pictureBox3;
        private Button btnGenReport;
    }
}