namespace PAKOPointOfSale.Transactions.Discounts
{
    partial class DiscountTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountTypes));
            cmbDiscountTypes = new ComboBox();
            btnOk = new Button();
            lblNote = new Label();
            btnCancel = new Button();
            panel1 = new Panel();
            num_customDiscount = new NumericUpDown();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_customDiscount).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cmbDiscountTypes
            // 
            cmbDiscountTypes.BackColor = SystemColors.ActiveBorder;
            cmbDiscountTypes.FlatStyle = FlatStyle.Popup;
            cmbDiscountTypes.Font = new Font("Roboto", 14.25F);
            cmbDiscountTypes.FormattingEnabled = true;
            cmbDiscountTypes.Items.AddRange(new object[] { "None", "Senior Citizen 5%", "Senior Citizen 20%", "Person With Disability 5%", "Person With Disability 20%", "National Athletes and Coaches 20%", "Regular Discount" });
            cmbDiscountTypes.Location = new Point(131, 111);
            cmbDiscountTypes.Name = "cmbDiscountTypes";
            cmbDiscountTypes.Size = new Size(419, 31);
            cmbDiscountTypes.TabIndex = 0;
            cmbDiscountTypes.SelectedIndexChanged += cmbDiscountTypes_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(33, 39, 56);
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Roboto", 9.75F);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(133, 57);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(74, 24);
            btnOk.TabIndex = 1;
            btnOk.Text = "Apply";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblNote
            // 
            lblNote.Anchor = AnchorStyles.None;
            lblNote.AutoSize = true;
            lblNote.BackColor = Color.Transparent;
            lblNote.Font = new Font("Roboto", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.Black;
            lblNote.Location = new Point(16, 13);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(400, 23);
            lblNote.TabIndex = 2;
            lblNote.Text = "Note: You can ONLY choose ONE Discount Type";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(213, 57);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(74, 24);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOk);
            panel1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(131, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(419, 88);
            panel1.TabIndex = 15;
            // 
            // num_customDiscount
            // 
            num_customDiscount.DecimalPlaces = 2;
            num_customDiscount.Font = new Font("Roboto", 14.25F);
            num_customDiscount.Location = new Point(246, 148);
            num_customDiscount.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_customDiscount.Name = "num_customDiscount";
            num_customDiscount.Size = new Size(304, 30);
            num_customDiscount.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(131, 156);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 17;
            label1.Text = "Custom Discount:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 39, 56);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 69);
            panel2.TabIndex = 197;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(224, 12);
            label2.Name = "label2";
            label2.Size = new Size(253, 42);
            label2.TabIndex = 194;
            label2.Text = "Apply Discount";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(237, 242, 239);
            label8.Location = new Point(62, 12);
            label8.Name = "label8";
            label8.Size = new Size(127, 42);
            label8.TabIndex = 191;
            label8.Text = "ATPOS";
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
            // DiscountTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(674, 339);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(num_customDiscount);
            Controls.Add(cmbDiscountTypes);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountTypes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply Discount";
            Load += DiscountTypes_Load;
            KeyDown += DiscountTypes_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_customDiscount).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDiscountTypes;
        private Button btnOk;
        private Label lblNote;
        private Button btnCancel;
        private Panel panel1;
        private NumericUpDown num_customDiscount;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}