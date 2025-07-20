namespace e___Shift_System.Forms
{
    partial class Add_Assistants
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
            btnDelete = new Button();
            dataGridViewAddAssistants = new DataGridView();
            btnBack = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            bntAdd = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            txtConNo = new TextBox();
            label5 = new Label();
            txtAssistantName = new TextBox();
            label4 = new Label();
            txtAssistantId = new TextBox();
            cmbStatus = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddAssistants).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(331, 557);
            btnDelete.Margin = new Padding(5, 3, 5, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 48);
            btnDelete.TabIndex = 96;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewAddAssistants
            // 
            dataGridViewAddAssistants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddAssistants.Location = new Point(642, 168);
            dataGridViewAddAssistants.Name = "dataGridViewAddAssistants";
            dataGridViewAddAssistants.RowHeadersWidth = 51;
            dataGridViewAddAssistants.Size = new Size(747, 651);
            dataGridViewAddAssistants.TabIndex = 95;
            dataGridViewAddAssistants.CellClick += dataGridViewAddAssistants_CellContentClick;
            dataGridViewAddAssistants.CellContentClick += dataGridViewAddAssistants_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(55, 644);
            btnBack.Margin = new Padding(5, 3, 5, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 48);
            btnBack.TabIndex = 94;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(55, 557);
            btnClear.Margin = new Padding(5, 3, 5, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 48);
            btnClear.TabIndex = 93;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(331, 473);
            btnEdit.Margin = new Padding(5, 3, 5, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 48);
            btnEdit.TabIndex = 92;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = SystemColors.ActiveCaption;
            bntAdd.Location = new Point(55, 473);
            bntAdd.Margin = new Padding(5, 3, 5, 3);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(176, 48);
            bntAdd.TabIndex = 91;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(33, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 86);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 89;
            label1.Text = "Add Assistants";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 315);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(138, 22);
            label9.TabIndex = 88;
            label9.Text = "Contact Number";
            // 
            // txtConNo
            // 
            txtConNo.Location = new Point(220, 315);
            txtConNo.Margin = new Padding(5, 3, 5, 3);
            txtConNo.MaxLength = 10;
            txtConNo.Name = "txtConNo";
            txtConNo.Size = new Size(377, 29);
            txtConNo.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 240);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 87;
            label5.Text = "Assistant Name";
            // 
            // txtAssistantName
            // 
            txtAssistantName.Location = new Point(220, 240);
            txtAssistantName.Margin = new Padding(5, 3, 5, 3);
            txtAssistantName.Name = "txtAssistantName";
            txtAssistantName.Size = new Size(377, 29);
            txtAssistantName.TabIndex = 82;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 168);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 86;
            label4.Text = "Assistan ID";
            // 
            // txtAssistantId
            // 
            txtAssistantId.Location = new Point(220, 169);
            txtAssistantId.Margin = new Padding(5, 3, 5, 3);
            txtAssistantId.Name = "txtAssistantId";
            txtAssistantId.Size = new Size(377, 29);
            txtAssistantId.TabIndex = 81;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(220, 385);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(377, 30);
            cmbStatus.TabIndex = 106;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 388);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 105;
            label3.Text = "Status";
            // 
            // Add_Assistants
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(dataGridViewAddAssistants);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(bntAdd);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(txtConNo);
            Controls.Add(label5);
            Controls.Add(txtAssistantName);
            Controls.Add(label4);
            Controls.Add(txtAssistantId);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_Assistants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Assistants";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddAssistants).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private DataGridView dataGridViewAddAssistants;
        private Button btnBack;
        private Button btnClear;
        private Button btnEdit;
        private Button bntAdd;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private TextBox txtConNo;
        private Label label5;
        private TextBox txtAssistantName;
        private Label label4;
        private TextBox txtAssistantId;
        private ComboBox cmbStatus;
        private Label label3;
    }
}