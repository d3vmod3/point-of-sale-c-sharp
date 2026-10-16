namespace PAKOPointOfSale.Products.Filters
{
    partial class Status
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
            cmbStatus = new ComboBox();
            label1 = new Label();
            btnFilter = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.Window;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "", "Good", "Deffective" });
            cmbStatus.Location = new Point(110, 24);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(188, 23);
            cmbStatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose Status:";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(33, 39, 56);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Roboto", 9.75F);
            btnFilter.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilter.Location = new Point(161, 58);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(69, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.FromArgb(237, 242, 239);
            btnCancel.Location = new Point(232, 58);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(66, 23);
            btnCancel.TabIndex = 116;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // Status
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(316, 93);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            Controls.Add(cmbStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Status";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Status";
            Load += Status_Load;
            KeyDown += Status_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private Label label1;
        private Button btnFilter;
        private Button btnCancel;
    }
}