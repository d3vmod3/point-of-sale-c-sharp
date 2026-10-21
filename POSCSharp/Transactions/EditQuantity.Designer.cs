namespace PAKOPointOfSale.Transactions
{
    partial class EditQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuantity));
            btnOk = new Button();
            label4 = new Label();
            num_AppliedQty = new NumericUpDown();
            lblCurrentQty = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            btnClose = new Button();
            label5 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            txtProductName = new TextBox();
            txtProductBrand = new TextBox();
            txtUom = new TextBox();
            txtCurrentQuantity = new TextBox();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)num_AppliedQty).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(33, 39, 56);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Roboto", 9.75F);
            btnOk.ForeColor = Color.FromArgb(237, 242, 239);
            btnOk.Location = new Point(412, 337);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 28);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(120, 237);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantity:";
            // 
            // num_AppliedQty
            // 
            num_AppliedQty.BackColor = Color.White;
            num_AppliedQty.Font = new Font("Roboto", 14.25F);
            num_AppliedQty.ForeColor = Color.Black;
            num_AppliedQty.Location = new Point(184, 229);
            num_AppliedQty.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            num_AppliedQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_AppliedQty.Name = "num_AppliedQty";
            num_AppliedQty.Size = new Size(385, 30);
            num_AppliedQty.TabIndex = 5;
            num_AppliedQty.TextAlign = HorizontalAlignment.Right;
            num_AppliedQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            num_AppliedQty.ValueChanged += num_AppliedQty_ValueChanged;
            num_AppliedQty.KeyDown += num_AppliedQty_KeyDown;
            num_AppliedQty.KeyPress += num_AppliedQty_KeyPress;
            // 
            // lblCurrentQty
            // 
            lblCurrentQty.AutoSize = true;
            lblCurrentQty.BackColor = Color.Transparent;
            lblCurrentQty.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblCurrentQty.ForeColor = Color.Black;
            lblCurrentQty.Location = new Point(73, 202);
            lblCurrentQty.Name = "lblCurrentQty";
            lblCurrentQty.Size = new Size(105, 15);
            lblCurrentQty.TabIndex = 6;
            lblCurrentQty.Text = "Current Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(122, 94);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(133, 130);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(144, 166);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 10;
            label3.Text = "Unit:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(115, 274);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 13;
            label7.Text = "Category:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Roboto", 9.75F);
            btnClose.ForeColor = Color.FromArgb(237, 242, 239);
            btnClose.Location = new Point(493, 337);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(76, 28);
            btnClose.TabIndex = 115;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(111, 310);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Unit Price:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 39, 56);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(674, 69);
            panel2.TabIndex = 198;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(237, 242, 239);
            label6.Location = new Point(224, 12);
            label6.Name = "label6";
            label6.Size = new Size(245, 42);
            label6.TabIndex = 194;
            label6.Text = "Apply Quantity";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            // txtProductName
            // 
            txtProductName.Font = new Font("Roboto", 14.25F);
            txtProductName.Location = new Point(184, 85);
            txtProductName.MaxLength = 50;
            txtProductName.Multiline = true;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(385, 30);
            txtProductName.TabIndex = 199;
            // 
            // txtProductBrand
            // 
            txtProductBrand.Font = new Font("Roboto", 14.25F);
            txtProductBrand.Location = new Point(184, 121);
            txtProductBrand.MaxLength = 50;
            txtProductBrand.Multiline = true;
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(385, 30);
            txtProductBrand.TabIndex = 200;
            // 
            // txtUom
            // 
            txtUom.Font = new Font("Roboto", 14.25F);
            txtUom.Location = new Point(184, 157);
            txtUom.MaxLength = 50;
            txtUom.Multiline = true;
            txtUom.Name = "txtUom";
            txtUom.Size = new Size(385, 30);
            txtUom.TabIndex = 201;
            // 
            // txtCurrentQuantity
            // 
            txtCurrentQuantity.Font = new Font("Roboto", 14.25F);
            txtCurrentQuantity.Location = new Point(184, 193);
            txtCurrentQuantity.MaxLength = 50;
            txtCurrentQuantity.Multiline = true;
            txtCurrentQuantity.Name = "txtCurrentQuantity";
            txtCurrentQuantity.Size = new Size(385, 30);
            txtCurrentQuantity.TabIndex = 202;
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Roboto", 14.25F);
            txtCategory.Location = new Point(184, 265);
            txtCategory.MaxLength = 50;
            txtCategory.Multiline = true;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(385, 30);
            txtCategory.TabIndex = 203;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Roboto", 14.25F);
            txtUnitPrice.Location = new Point(184, 301);
            txtUnitPrice.MaxLength = 50;
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(385, 30);
            txtUnitPrice.TabIndex = 204;
            // 
            // EditQuantity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(674, 378);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtCurrentQuantity);
            Controls.Add(txtUom);
            Controls.Add(txtProductBrand);
            Controls.Add(txtProductName);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCurrentQty);
            Controls.Add(num_AppliedQty);
            Controls.Add(label4);
            Controls.Add(btnOk);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditQuantity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apply Quantity";
            Load += EditQuantity_Load;
            KeyDown += EditQuantity_KeyDown;
            ((System.ComponentModel.ISupportInitialize)num_AppliedQty).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOk;
        private Label label4;
        private NumericUpDown num_AppliedQty;
        private Label lblCurrentQty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Button btnClose;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
        private TextBox txtProductName;
        private TextBox txtProductBrand;
        private TextBox txtUom;
        private TextBox txtCurrentQuantity;
        private TextBox txtCategory;
        private TextBox txtUnitPrice;
    }
}