namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    partial class Remarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remarks));
            txtRemarks = new TextBox();
            label1 = new Label();
            btnProceed = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(13, 56);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(430, 97);
            txtRemarks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 30);
            label1.TabIndex = 1;
            label1.Text = "Kindly provide remarks. This helps prevent mix-ups when retrieving pending\r\nsales invoices with your customer.";
            label1.Click += label1_Click;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.FromArgb(33, 39, 56);
            btnProceed.FlatStyle = FlatStyle.Popup;
            btnProceed.Font = new Font("Roboto", 9.75F);
            btnProceed.ForeColor = Color.FromArgb(237, 242, 239);
            btnProceed.Location = new Point(286, 159);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 31);
            btnProceed.TabIndex = 2;
            btnProceed.Text = "Pending";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.FromArgb(237, 242, 239);
            btnCancel.Location = new Point(367, 159);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Remarks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(455, 202);
            Controls.Add(btnCancel);
            Controls.Add(btnProceed);
            Controls.Add(label1);
            Controls.Add(txtRemarks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Remarks";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Remarks";
            Load += Remarks_Load;
            KeyDown += Remarks_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRemarks;
        private Label label1;
        private Button btnProceed;
        private Button btnCancel;
    }
}