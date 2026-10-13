namespace PAKOPointOfSale
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            btnClose = new Button();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 39, 56);
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(706, 515);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(286, 31);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtPassword.Location = new Point(742, 435);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 35);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtUsername.Location = new Point(742, 376);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 35);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.KeyDown += txtUsername_KeyDown;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(237, 242, 239);
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(697, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(237, 242, 239);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(697, 435);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 39, 56);
            label1.Location = new Point(741, 296);
            label1.Name = "label1";
            label1.Size = new Size(222, 29);
            label1.TabIndex = 7;
            label1.Text = "Welcome to ATPOS";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(237, 242, 239);
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 622);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(87, 196, 229);
            checkBox1.Location = new Point(873, 476);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1072, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 31);
            btnClose.TabIndex = 46;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(694, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(298, 277);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(33, 39, 56);
            label2.Location = new Point(769, 333);
            label2.Name = "label2";
            label2.Size = new Size(147, 14);
            label2.TabIndex = 48;
            label2.Text = "Please login your account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1119, 622);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(btnClose);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAKO Point-Of-Sale";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button btnClose;
        private PictureBox pictureBox4;
        private Label label2;
    }
}
