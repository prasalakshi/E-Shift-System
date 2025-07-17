namespace e___Shift_System.Forms
{
    partial class My_Jobs
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
            label1 = new Label();
            txtCusID = new TextBox();
            jobsDataGridView = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtStartLocation = new TextBox();
            label4 = new Label();
            txtDestination = new TextBox();
            label6 = new Label();
            dtpJobDate = new DateTimePicker();
            btnAdd = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            label5 = new Label();
            txtShiftItems = new TextBox();
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 34);
            label1.TabIndex = 0;
            label1.Text = "Create A Job";
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(203, 233);
            txtCusID.Margin = new Padding(4, 3, 4, 3);
            txtCusID.Name = "txtCusID";
            txtCusID.ReadOnly = true;
            txtCusID.Size = new Size(290, 29);
            txtCusID.TabIndex = 1;
            // 
            // jobsDataGridView
            // 
            jobsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jobsDataGridView.Location = new Point(516, 233);
            jobsDataGridView.Margin = new Padding(4, 3, 4, 3);
            jobsDataGridView.Name = "jobsDataGridView";
            jobsDataGridView.RowHeadersWidth = 51;
            jobsDataGridView.Size = new Size(873, 596);
            jobsDataGridView.TabIndex = 2;
            jobsDataGridView.CellClick += jobsDataGridView_CellContentClick;
            jobsDataGridView.CellContentClick += jobsDataGridView_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(40, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 236);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 29;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 302);
            label3.Name = "label3";
            label3.Size = new Size(119, 22);
            label3.TabIndex = 31;
            label3.Text = "Start Location";
            // 
            // txtStartLocation
            // 
            txtStartLocation.Location = new Point(203, 299);
            txtStartLocation.Margin = new Padding(4, 3, 4, 3);
            txtStartLocation.Name = "txtStartLocation";
            txtStartLocation.Size = new Size(290, 29);
            txtStartLocation.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 370);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 33;
            label4.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(203, 367);
            txtDestination.Margin = new Padding(4, 3, 4, 3);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(290, 29);
            txtDestination.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 439);
            label6.Name = "label6";
            label6.Size = new Size(80, 22);
            label6.TabIndex = 37;
            label6.Text = "Job Date";
            // 
            // dtpJobDate
            // 
            dtpJobDate.Location = new Point(203, 439);
            dtpJobDate.Name = "dtpJobDate";
            dtpJobDate.Size = new Size(290, 29);
            dtpJobDate.TabIndex = 38;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(41, 695);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 44);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnLogin_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ActiveCaption;
            btnEdit.Location = new Point(305, 695);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 44);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Location = new Point(41, 785);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 44);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(305, 785);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 44);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 505);
            label5.Name = "label5";
            label5.Size = new Size(121, 22);
            label5.TabIndex = 44;
            label5.Text = "Shifting Items";
            // 
            // txtShiftItems
            // 
            txtShiftItems.Location = new Point(203, 502);
            txtShiftItems.Margin = new Padding(4, 3, 4, 3);
            txtShiftItems.Multiline = true;
            txtShiftItems.Name = "txtShiftItems";
            txtShiftItems.Size = new Size(290, 142);
            txtShiftItems.TabIndex = 43;
            // 
            // My_Jobs
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(txtShiftItems);
            Controls.Add(btnBack);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dtpJobDate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtDestination);
            Controls.Add(label3);
            Controls.Add(txtStartLocation);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(jobsDataGridView);
            Controls.Add(txtCusID);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "My_Jobs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My_Jobs";
            Load += My_Jobs_Load;
            ((System.ComponentModel.ISupportInitialize)jobsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCusID;
        private DataGridView jobsDataGridView;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtStartLocation;
        private Label label4;
        private TextBox txtDestination;
        private Label label6;
        private DateTimePicker dtpJobDate;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnBack;
        private Label label5;
        private TextBox txtShiftItems;
    }
}