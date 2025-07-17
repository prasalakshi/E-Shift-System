namespace e___Shift_System.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btnLoginAsCus = new Button();
            btnLoginAsAdmin = new Button();
            pictureBox1 = new PictureBox();
            linkLableExit = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(319, 287);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(860, 41);
            label1.TabIndex = 0;
            label1.Text = "Welcome to E -Shift Householding Goods Shifting";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLoginAsCus
            // 
            btnLoginAsCus.BackColor = SystemColors.ActiveCaption;
            btnLoginAsCus.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginAsCus.Location = new Point(564, 440);
            btnLoginAsCus.Margin = new Padding(4);
            btnLoginAsCus.Name = "btnLoginAsCus";
            btnLoginAsCus.Size = new Size(340, 40);
            btnLoginAsCus.TabIndex = 1;
            btnLoginAsCus.Text = "Login as a Customer";
            btnLoginAsCus.UseVisualStyleBackColor = false;
            btnLoginAsCus.Click += button1_Click;
            // 
            // btnLoginAsAdmin
            // 
            btnLoginAsAdmin.BackColor = SystemColors.ActiveCaption;
            btnLoginAsAdmin.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoginAsAdmin.Location = new Point(564, 519);
            btnLoginAsAdmin.Margin = new Padding(4);
            btnLoginAsAdmin.Name = "btnLoginAsAdmin";
            btnLoginAsAdmin.Size = new Size(340, 40);
            btnLoginAsAdmin.TabIndex = 2;
            btnLoginAsAdmin.Text = "Login as an Admin";
            btnLoginAsAdmin.UseVisualStyleBackColor = false;
            btnLoginAsAdmin.Click += btnLoginAsAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(636, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // linkLableExit
            // 
            linkLableExit.AutoSize = true;
            linkLableExit.LinkColor = Color.Red;
            linkLableExit.Location = new Point(1325, 43);
            linkLableExit.Name = "linkLableExit";
            linkLableExit.Size = new Size(39, 22);
            linkLableExit.TabIndex = 30;
            linkLableExit.TabStop = true;
            linkLableExit.Text = "Exit";
            linkLableExit.LinkClicked += linkLableExit_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1422, 853);
            ControlBox = false;
            Controls.Add(linkLableExit);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoginAsAdmin);
            Controls.Add(btnLoginAsCus);
            Controls.Add(label1);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLoginAsCus;
        private Button btnLoginAsAdmin;
        private PictureBox pictureBox1;
        private LinkLabel linkLableExit;
    }
}