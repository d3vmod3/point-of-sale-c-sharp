namespace PAKOPointOfSale.Transactions.Void
{
    partial class VoidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidForm));
            btnViewReceipt = new Button();
            btnConfirm = new Button();
            label2 = new Label();
            label3 = new Label();
            lblInvoiceNumber = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnViewReceipt
            // 
            btnViewReceipt.BackColor = Color.FromArgb(87, 196, 229);
            btnViewReceipt.FlatStyle = FlatStyle.Popup;
            btnViewReceipt.Font = new Font("Roboto", 9.75F);
            btnViewReceipt.ForeColor = Color.Black;
            btnViewReceipt.Location = new Point(98, 154);
            btnViewReceipt.Name = "btnViewReceipt";
            btnViewReceipt.Size = new Size(127, 36);
            btnViewReceipt.TabIndex = 0;
            btnViewReceipt.Text = "View Receipt";
            btnViewReceipt.UseVisualStyleBackColor = false;
            btnViewReceipt.Click += btnViewReceipt_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Red;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Roboto", 9.75F);
            btnConfirm.ForeColor = Color.FromArgb(237, 242, 239);
            btnConfirm.Location = new Point(231, 154);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(127, 36);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm Void";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnProceed_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(77, 28);
            label2.Name = "label2";
            label2.Size = new Size(315, 19);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to void this invoice?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(119, 59);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 4;
            label3.Text = "Invoice Number:";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.BackColor = Color.Transparent;
            lblInvoiceNumber.Font = new Font("Roboto", 14.25F, FontStyle.Bold | FontStyle.Italic);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(263, 59);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(76, 23);
            lblInvoiceNumber.TabIndex = 5;
            lblInvoiceNumber.Text = "000000";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(249, 112, 104);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 9.75F);
            button1.ForeColor = Color.FromArgb(237, 242, 239);
            button1.Location = new Point(364, 154);
            button1.Name = "button1";
            button1.Size = new Size(79, 36);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 92);
            label1.Name = "label1";
            label1.Size = new Size(366, 19);
            label1.TabIndex = 1;
            label1.Text = "Please review the receipt before voiding this receipt";
            // 
            // VoidForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(455, 202);
            Controls.Add(button1);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(btnViewReceipt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VoidForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Void";
            Load += VoidForm_Load;
            KeyDown += VoidForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewReceipt;
        private Button btnConfirm;
        private Label label2;
        private Label label3;
        private Label lblInvoiceNumber;
        private Button button1;
        private Label label1;
    }
}