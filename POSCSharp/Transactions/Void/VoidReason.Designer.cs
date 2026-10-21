namespace PAKOPointOfSale.Transactions.Void
{
    partial class VoidReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidReason));
            btnSubmit = new Button();
            label1 = new Label();
            txtReason = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(33, 39, 56);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Roboto", 9.75F);
            btnSubmit.ForeColor = Color.FromArgb(237, 242, 239);
            btnSubmit.Location = new Point(287, 159);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 31);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(309, 17);
            label1.TabIndex = 4;
            label1.Text = "Please indicate the reason why you want to void?";
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Roboto", 9.75F);
            txtReason.Location = new Point(12, 46);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(431, 107);
            txtReason.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 112, 104);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 9.75F);
            button1.ForeColor = Color.FromArgb(237, 242, 239);
            button1.Location = new Point(368, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 14;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // VoidReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(455, 202);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtReason);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VoidReason";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Void Reason";
            Load += VoidReason_Load;
            KeyDown += VoidReason_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label label1;
        private TextBox txtReason;
        private Button button1;
    }
}