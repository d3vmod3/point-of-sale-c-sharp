namespace PAKOPointOfSale.Users
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            txtUsername = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtSuffix = new TextBox();
            dtpBirthdate = new DateTimePicker();
            cmbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbRole = new ComboBox();
            btnSubmit = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            chkIsActive = new CheckBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Roboto", 14.25F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(184, 85);
            txtUsername.MaxLength = 32;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(385, 30);
            txtUsername.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Roboto", 14.25F);
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(184, 121);
            txtFirstName.MaxLength = 20;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(385, 30);
            txtFirstName.TabIndex = 1;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.White;
            txtMiddleName.Font = new Font("Roboto", 14.25F);
            txtMiddleName.ForeColor = Color.Black;
            txtMiddleName.Location = new Point(184, 157);
            txtMiddleName.MaxLength = 20;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(385, 30);
            txtMiddleName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Roboto", 14.25F);
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(184, 193);
            txtLastName.MaxLength = 20;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(385, 30);
            txtLastName.TabIndex = 3;
            // 
            // txtSuffix
            // 
            txtSuffix.Font = new Font("Roboto", 14.25F);
            txtSuffix.ForeColor = Color.Black;
            txtSuffix.Location = new Point(184, 229);
            txtSuffix.MaxLength = 3;
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(385, 30);
            txtSuffix.TabIndex = 4;
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CalendarFont = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirthdate.Font = new Font("Roboto", 14.25F);
            dtpBirthdate.Location = new Point(184, 265);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(385, 30);
            dtpBirthdate.TabIndex = 5;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.White;
            cmbGender.FlatStyle = FlatStyle.Popup;
            cmbGender.Font = new Font("Roboto", 14.25F);
            cmbGender.ForeColor = SystemColors.WindowText;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cmbGender.Location = new Point(184, 301);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(385, 31);
            cmbGender.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(83, 94);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 7;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 130);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 8;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(68, 166);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 9;
            label3.Text = "Middle Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(81, 202);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(109, 238);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Suffix:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(91, 274);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "Birthdate:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(101, 310);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 13;
            label7.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(87, 347);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 15;
            label8.Text = "User Role:";
            label8.Click += label8_Click;
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.White;
            cmbRole.FlatStyle = FlatStyle.Popup;
            cmbRole.Font = new Font("Roboto", 14.25F);
            cmbRole.ForeColor = SystemColors.WindowText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(184, 338);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(385, 31);
            cmbRole.TabIndex = 14;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(33, 39, 56);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Roboto", 9.75F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(412, 405);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 28);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Roboto", 9.75F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(493, 405);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(76, 28);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 69);
            panel1.TabIndex = 198;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(237, 242, 239);
            label9.Location = new Point(262, 12);
            label9.Name = "label9";
            label9.Size = new Size(255, 42);
            label9.TabIndex = 194;
            label9.Text = "ADD SUPPLIER";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(474, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 69);
            tableLayoutPanel1.TabIndex = 192;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Roboto", 11.25F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(109, 42);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(88, 18);
            lblTime.TabIndex = 160;
            lblTime.Text = "hh:mm:ss tt";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Roboto", 11.25F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(95, 8);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(102, 18);
            lblDate.TabIndex = 159;
            lblDate.Text = "MM/DD/YYYY";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(237, 242, 239);
            label10.Location = new Point(62, 12);
            label10.Name = "label10";
            label10.Size = new Size(127, 42);
            label10.TabIndex = 191;
            label10.Text = "ATPOS";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 189;
            pictureBox4.TabStop = false;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Bold);
            chkIsActive.Location = new Point(347, 414);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 199;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            chkIsActive.CheckedChanged += chkIsActive_CheckedChanged;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(674, 485);
            ControlBox = false;
            Controls.Add(chkIsActive);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSubmit);
            Controls.Add(label8);
            Controls.Add(cmbRole);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthdate);
            Controls.Add(txtSuffix);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User";
            Load += AddUser_Load;
            KeyDown += AddUser_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtSuffix;
        private DateTimePicker dtpBirthdate;
        private ComboBox cmbGender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbRole;
        private Button btnSubmit;
        private Button btnClose;
        private Panel panel1;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label10;
        private PictureBox pictureBox4;
        private CheckBox chkIsActive;
    }
}