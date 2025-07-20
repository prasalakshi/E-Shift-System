namespace e___Shift_System.Forms
{
    partial class Add_Lorries
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
            dataGridViewAddLorries = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            txtModel = new TextBox();
            label5 = new Label();
            txtRegNo = new TextBox();
            label2 = new Label();
            txtCapacity = new TextBox();
            btnDelete = new Button();
            btnBack = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            bntAdd = new Button();
            label3 = new Label();
            cmbStatus = new ComboBox();
            txtLorryId = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddLorries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAddLorries
            // 
            dataGridViewAddLorries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddLorries.Location = new Point(642, 168);
            dataGridViewAddLorries.Name = "dataGridViewAddLorries";
            dataGridViewAddLorries.RowHeadersWidth = 51;
            dataGridViewAddLorries.Size = new Size(747, 651);
            dataGridViewAddLorries.TabIndex = 79;
            dataGridViewAddLorries.CellClick += dataGridViewAddLorries_CellContentClick;
            dataGridViewAddLorries.CellContentClick += dataGridViewAddLorries_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(33, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 86);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 73;
            label1.Text = "Add Lorries";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 306);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 22);
            label9.TabIndex = 72;
            label9.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(220, 306);
            txtModel.Margin = new Padding(5, 3, 5, 3);
            txtModel.MaxLength = 10;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(377, 29);
            txtModel.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 237);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(171, 22);
            label5.TabIndex = 71;
            label5.Text = "Registration Number";
            // 
            // txtRegNo
            // 
            txtRegNo.Location = new Point(220, 237);
            txtRegNo.Margin = new Padding(5, 3, 5, 3);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(377, 29);
            txtRegNo.TabIndex = 66;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 373);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 69;
            label2.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(220, 373);
            txtCapacity.Margin = new Padding(5, 3, 5, 3);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(377, 29);
            txtCapacity.TabIndex = 68;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(327, 595);
            btnDelete.Margin = new Padding(5, 3, 5, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 48);
            btnDelete.TabIndex = 101;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(51, 682);
            btnBack.Margin = new Padding(5, 3, 5, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 48);
            btnBack.TabIndex = 100;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(51, 595);
            btnClear.Margin = new Padding(5, 3, 5, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 48);
            btnClear.TabIndex = 99;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(327, 511);
            btnEdit.Margin = new Padding(5, 3, 5, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 48);
            btnEdit.TabIndex = 98;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = SystemColors.ActiveCaption;
            bntAdd.Location = new Point(51, 511);
            bntAdd.Margin = new Padding(5, 3, 5, 3);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(176, 48);
            bntAdd.TabIndex = 97;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 444);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 103;
            label3.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(220, 441);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(377, 30);
            cmbStatus.TabIndex = 104;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtLorryId
            // 
            txtLorryId.Location = new Point(220, 169);
            txtLorryId.Margin = new Padding(5, 3, 5, 3);
            txtLorryId.Name = "txtLorryId";
            txtLorryId.ReadOnly = true;
            txtLorryId.Size = new Size(377, 29);
            txtLorryId.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 168);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 22);
            label4.TabIndex = 70;
            label4.Text = "Lorry ID";
            // 
            // Add_Lorries
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(cmbStatus);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnEdit);
            Controls.Add(bntAdd);
            Controls.Add(dataGridViewAddLorries);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(txtModel);
            Controls.Add(label5);
            Controls.Add(txtRegNo);
            Controls.Add(label4);
            Controls.Add(txtLorryId);
            Controls.Add(label2);
            Controls.Add(txtCapacity);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_Lorries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Lorries";
            Load += Add_Lorries_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddLorries).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAddLorries;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private TextBox txtModel;
        private Label label5;
        private TextBox txtRegNo;
        private Label label2;
        private TextBox txtCapacity;
        private Button btnDelete;
        private Button btnBack;
        private Button btnClear;
        private Button btnEdit;
        private Button bntAdd;
        private Label label3;
        private ComboBox cmbStatus;
        private TextBox txtLorryId;
        private Label label4;
    }
}