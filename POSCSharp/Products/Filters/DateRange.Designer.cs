namespace PAKOPointOfSale.Products.Filters
{
    partial class DateRange
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
            dtFrom = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtTo = new DateTimePicker();
            btnFilter = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // dtFrom
            // 
            dtFrom.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dtFrom.Location = new Point(80, 29);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(234, 23);
            dtFrom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(4, 35);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Date From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Date To:";
            // 
            // dtTo
            // 
            dtTo.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dtTo.Location = new Point(80, 74);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(234, 23);
            dtTo.TabIndex = 2;
            dtTo.Value = new DateTime(2026, 10, 16, 0, 0, 0, 0);
            dtTo.ValueChanged += dtTo_ValueChanged;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(33, 39, 56);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilter.Location = new Point(180, 115);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(62, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(248, 115);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(66, 23);
            btnCancel.TabIndex = 115;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // DateRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(326, 150);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            Controls.Add(label2);
            Controls.Add(dtTo);
            Controls.Add(label1);
            Controls.Add(dtFrom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DateRange";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter by";
            Load += DateRange_Load;
            KeyDown += DateRange_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtFrom;
        private Label label1;
        private Label label2;
        private DateTimePicker dtTo;
        private Button btnFilter;
        private Button btnCancel;
    }
}