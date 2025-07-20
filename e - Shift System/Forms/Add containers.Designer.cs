namespace e___Shift_System.Forms
{
    partial class Add_containers
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
            btnBack = new Button();
            btnClear = new Button();
            btnEdit = new Button();
            bntAdd = new Button();
            dataGridViewAddContainers = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label9 = new Label();
            txtContainerType = new TextBox();
            label5 = new Label();
            txtContainerNumber = new TextBox();
            label4 = new Label();
            txtContainerID = new TextBox();
            label2 = new Label();
            txtcontainerCapacity = new TextBox();
            cmbStatus = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddContainers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Location = new Point(327, 586);
            btnDelete.Margin = new Padding(5, 3, 5, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 48);
            btnDelete.TabIndex = 117;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(51, 673);
            btnBack.Margin = new Padding(5, 3, 5, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 48);
            btnBack.TabIndex = 116;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Location = new Point(51, 586);
            btnClear.Margin = new Padding(5, 3, 5, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(176, 48);
            btnClear.TabIndex = 115;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(327, 502);
            btnEdit.Margin = new Padding(5, 3, 5, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 48);
            btnEdit.TabIndex = 114;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // bntAdd
            // 
            bntAdd.BackColor = SystemColors.ActiveCaption;
            bntAdd.Location = new Point(51, 502);
            bntAdd.Margin = new Padding(5, 3, 5, 3);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(176, 48);
            bntAdd.TabIndex = 113;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = false;
            bntAdd.Click += bntAdd_Click;
            // 
            // dataGridViewAddContainers
            // 
            dataGridViewAddContainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAddContainers.Location = new Point(642, 168);
            dataGridViewAddContainers.Name = "dataGridViewAddContainers";
            dataGridViewAddContainers.RowHeadersWidth = 51;
            dataGridViewAddContainers.Size = new Size(747, 651);
            dataGridViewAddContainers.TabIndex = 112;
            dataGridViewAddContainers.CellClick += dataGridViewAddContainers_CellContentClick;
            dataGridViewAddContainers.CellContentClick += dataGridViewAddContainers_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(33, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 111;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 86);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 110;
            label1.Text = "Add Containers";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 315);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 22);
            label9.TabIndex = 109;
            label9.Text = "Type";
            // 
            // txtContainerType
            // 
            txtContainerType.Location = new Point(220, 315);
            txtContainerType.Margin = new Padding(5, 3, 5, 3);
            txtContainerType.MaxLength = 10;
            txtContainerType.Name = "txtContainerType";
            txtContainerType.Size = new Size(377, 29);
            txtContainerType.TabIndex = 104;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 240);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 108;
            label5.Text = "Container Number";
            // 
            // txtContainerNumber
            // 
            txtContainerNumber.Location = new Point(220, 240);
            txtContainerNumber.Margin = new Padding(5, 3, 5, 3);
            txtContainerNumber.Name = "txtContainerNumber";
            txtContainerNumber.Size = new Size(377, 29);
            txtContainerNumber.TabIndex = 103;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 168);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 22);
            label4.TabIndex = 107;
            label4.Text = "Container ID";
            // 
            // txtContainerID
            // 
            txtContainerID.Location = new Point(220, 169);
            txtContainerID.Margin = new Padding(5, 3, 5, 3);
            txtContainerID.Name = "txtContainerID";
            txtContainerID.Size = new Size(377, 29);
            txtContainerID.TabIndex = 102;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 381);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 106;
            label2.Text = "Capacity";
            // 
            // txtcontainerCapacity
            // 
            txtcontainerCapacity.Location = new Point(220, 381);
            txtcontainerCapacity.Margin = new Padding(5, 3, 5, 3);
            txtcontainerCapacity.Name = "txtcontainerCapacity";
            txtcontainerCapacity.Size = new Size(377, 29);
            txtcontainerCapacity.TabIndex = 105;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(220, 441);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(377, 30);
            cmbStatus.TabIndex = 119;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 444);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 22);
            label3.TabIndex = 118;
            label3.Text = "Status";
            // 
            // Add_containers
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
            Controls.Add(dataGridViewAddContainers);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(txtContainerType);
            Controls.Add(label5);
            Controls.Add(txtContainerNumber);
            Controls.Add(label4);
            Controls.Add(txtContainerID);
            Controls.Add(label2);
            Controls.Add(txtcontainerCapacity);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_containers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_containers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAddContainers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnBack;
        private Button btnClear;
        private Button btnEdit;
        private Button bntAdd;
        private DataGridView dataGridViewAddContainers;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label9;
        private TextBox txtContainerType;
        private Label label5;
        private TextBox txtContainerNumber;
        private Label label4;
        private TextBox txtContainerID;
        private Label label2;
        private TextBox txtcontainerCapacity;
        private ComboBox cmbStatus;
        private Label label3;
    }
}