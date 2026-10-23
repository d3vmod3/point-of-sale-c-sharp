namespace PAKOPointOfSale
{
    partial class ResetPassword
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
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            label2 = new Label();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(134, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 0;
            label1.Text = "Please input new password.";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            txtPassword.Location = new Point(134, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(134, 79);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(250, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(33, 39, 56);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Roboto", 9.75F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(208, 139);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(85, 26);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(299, 139);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 26);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(32, 53);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "New Password:";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(87, 196, 229);
            chkShowPassword.Location = new Point(265, 108);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(119, 19);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password:";
            label3.Click += label3_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(414, 174);
            Controls.Add(label3);
            Controls.Add(chkShowPassword);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ResetPassword";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            Load += ResetPassword_Load;
            KeyDown += ResetPassword_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private Button btnCancel;
        private Label label2;
        private CheckBox chkShowPassword;
        private Label label3;
    }
}