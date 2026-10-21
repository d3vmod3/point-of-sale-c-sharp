namespace PAKOPointOfSale.Transactions
{
    partial class ViewAdjustmentReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAdjustmentReason));
            txtReason = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.BackColor = SystemColors.Window;
            txtReason.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReason.Location = new Point(12, 12);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ReadOnly = true;
            txtReason.Size = new Size(431, 138);
            txtReason.TabIndex = 0;
            txtReason.TextChanged += txtReason_TextChanged;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(33, 39, 56);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Roboto", 9.75F);
            btnBack.ForeColor = Color.FromArgb(237, 242, 239);
            btnBack.Location = new Point(368, 159);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewAdjustmentReason
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(455, 202);
            Controls.Add(btnBack);
            Controls.Add(txtReason);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAdjustmentReason";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Reason";
            Load += ViewAdjustmentReason_Load;
            KeyDown += ViewAdjustmentReason_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReason;
        private Button btnBack;
    }
}