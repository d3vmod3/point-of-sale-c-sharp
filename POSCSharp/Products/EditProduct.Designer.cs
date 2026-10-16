namespace PAKOPointOfSale.Products
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            chkIsActive = new CheckBox();
            cmbStatus = new ComboBox();
            num_quantity = new NumericUpDown();
            txtRemarks = new TextBox();
            num_unitPrice = new NumericUpDown();
            num_costPrice = new NumericUpDown();
            cmbUnitofMeasurements = new ComboBox();
            cmbCategory = new ComboBox();
            cmbSupplier = new ComboBox();
            dtpDateExpiration = new DateTimePicker();
            dtpDateReceived = new DateTimePicker();
            btnSubmit = new Button();
            lblDateExpiration = new Label();
            label7 = new Label();
            lblStatus = new Label();
            lblRemarks = new Label();
            lblUnitPrice = new Label();
            lblCostPrice = new Label();
            lblUnitofMeasurement = new Label();
            lblQuantity = new Label();
            txtSKU = new TextBox();
            txtProductCode = new TextBox();
            txtDescription = new TextBox();
            txtProductBrand = new TextBox();
            txtProductName = new TextBox();
            lblSKU = new Label();
            lblProductCode = new Label();
            lblProductDescription = new Label();
            lblProductBrand = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblSupplierID = new Label();
            btnClose = new Button();
            txtBarcode = new TextBox();
            label2 = new Label();
            num_low_quantity = new NumericUpDown();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_low_quantity).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Bold);
            chkIsActive.Location = new Point(1062, 685);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 142;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.DimGray;
            cmbStatus.FlatStyle = FlatStyle.Popup;
            cmbStatus.Font = new Font("Roboto", 14.25F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Good", "Deffective" });
            cmbStatus.Location = new Point(937, 288);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(369, 31);
            cmbStatus.TabIndex = 141;
            // 
            // num_quantity
            // 
            num_quantity.Font = new Font("Roboto", 14.25F);
            num_quantity.Location = new Point(520, 291);
            num_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(369, 30);
            num_quantity.TabIndex = 140;
            // 
            // txtRemarks
            // 
            txtRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(701, 471);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(605, 160);
            txtRemarks.TabIndex = 139;
            txtRemarks.Text = "(Optional)";
            // 
            // num_unitPrice
            // 
            num_unitPrice.DecimalPlaces = 2;
            num_unitPrice.Font = new Font("Roboto", 14.25F);
            num_unitPrice.Location = new Point(937, 231);
            num_unitPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_unitPrice.Name = "num_unitPrice";
            num_unitPrice.Size = new Size(369, 30);
            num_unitPrice.TabIndex = 138;
            num_unitPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // num_costPrice
            // 
            num_costPrice.DecimalPlaces = 2;
            num_costPrice.Font = new Font("Roboto", 14.25F);
            num_costPrice.Location = new Point(937, 175);
            num_costPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_costPrice.Name = "num_costPrice";
            num_costPrice.Size = new Size(369, 30);
            num_costPrice.TabIndex = 137;
            num_costPrice.TextAlign = HorizontalAlignment.Right;
            num_costPrice.ThousandsSeparator = true;
            // 
            // cmbUnitofMeasurements
            // 
            cmbUnitofMeasurements.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnitofMeasurements.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnitofMeasurements.BackColor = Color.DimGray;
            cmbUnitofMeasurements.FlatStyle = FlatStyle.Popup;
            cmbUnitofMeasurements.Font = new Font("Roboto", 14.25F);
            cmbUnitofMeasurements.FormattingEnabled = true;
            cmbUnitofMeasurements.Items.AddRange(new object[] { "Bag", "Box", "Bottle", "Bundle", "Can", "Carton", "Case", "Dozen", "Gallon", "Gram", "Hour", "Job", "Kit", "Kilogram", "Liter", "Milliliter", "Pair", "Pack", "Piece", "Roll", "Sheet", "Tray", "Tin", "Set" });
            cmbUnitofMeasurements.Location = new Point(519, 404);
            cmbUnitofMeasurements.Name = "cmbUnitofMeasurements";
            cmbUnitofMeasurements.Size = new Size(369, 31);
            cmbUnitofMeasurements.TabIndex = 136;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.BackColor = Color.DimGray;
            cmbCategory.FlatStyle = FlatStyle.Popup;
            cmbCategory.Font = new Font("Roboto", 14.25F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(84, 231);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(369, 31);
            cmbCategory.TabIndex = 135;
            // 
            // cmbSupplier
            // 
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSupplier.BackColor = Color.DimGray;
            cmbSupplier.FlatStyle = FlatStyle.Popup;
            cmbSupplier.Font = new Font("Roboto", 14.25F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(84, 175);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(369, 31);
            cmbSupplier.TabIndex = 134;
            // 
            // dtpDateExpiration
            // 
            dtpDateExpiration.Font = new Font("Roboto", 14.25F);
            dtpDateExpiration.Format = DateTimePickerFormat.Short;
            dtpDateExpiration.Location = new Point(937, 404);
            dtpDateExpiration.Name = "dtpDateExpiration";
            dtpDateExpiration.Size = new Size(369, 30);
            dtpDateExpiration.TabIndex = 133;
            // 
            // dtpDateReceived
            // 
            dtpDateReceived.Font = new Font("Roboto", 14.25F);
            dtpDateReceived.Format = DateTimePickerFormat.Short;
            dtpDateReceived.Location = new Point(937, 346);
            dtpDateReceived.Name = "dtpDateReceived";
            dtpDateReceived.Size = new Size(369, 30);
            dtpDateReceived.TabIndex = 132;
            dtpDateReceived.ValueChanged += dtpDateReceived_ValueChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(33, 39, 56);
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.FromArgb(237, 242, 239);
            btnSubmit.Location = new Point(1132, 679);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 27);
            btnSubmit.TabIndex = 131;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // lblDateExpiration
            // 
            lblDateExpiration.AutoSize = true;
            lblDateExpiration.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblDateExpiration.Location = new Point(937, 386);
            lblDateExpiration.Name = "lblDateExpiration";
            lblDateExpiration.Size = new Size(97, 15);
            lblDateExpiration.TabIndex = 130;
            lblDateExpiration.Text = "Date Expiration:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label7.Location = new Point(937, 328);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 129;
            label7.Text = "Date Received:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblStatus.Location = new Point(937, 270);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(48, 15);
            lblStatus.TabIndex = 128;
            lblStatus.Text = "Status:";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblRemarks.Location = new Point(701, 447);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(63, 15);
            lblRemarks.TabIndex = 127;
            lblRemarks.Text = "Remarks:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblUnitPrice.Location = new Point(937, 213);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(67, 15);
            lblUnitPrice.TabIndex = 126;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblCostPrice.Location = new Point(937, 157);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(71, 15);
            lblCostPrice.TabIndex = 125;
            lblCostPrice.Text = "Cost Price:";
            // 
            // lblUnitofMeasurement
            // 
            lblUnitofMeasurement.AutoSize = true;
            lblUnitofMeasurement.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblUnitofMeasurement.Location = new Point(519, 386);
            lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            lblUnitofMeasurement.Size = new Size(139, 15);
            lblUnitofMeasurement.TabIndex = 124;
            lblUnitofMeasurement.Text = "Unit of Measurements:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblQuantity.Location = new Point(519, 270);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(58, 15);
            lblQuantity.TabIndex = 123;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtSKU
            // 
            txtSKU.Font = new Font("Roboto", 14.25F);
            txtSKU.Location = new Point(519, 231);
            txtSKU.MaxLength = 32;
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(369, 30);
            txtSKU.TabIndex = 122;
            // 
            // txtProductCode
            // 
            txtProductCode.Font = new Font("Roboto", 14.25F);
            txtProductCode.Location = new Point(519, 175);
            txtProductCode.MaxLength = 12;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(369, 30);
            txtProductCode.TabIndex = 121;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(86, 470);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(605, 160);
            txtDescription.TabIndex = 120;
            txtDescription.Text = "(Optional)";
            // 
            // txtProductBrand
            // 
            txtProductBrand.Font = new Font("Roboto", 14.25F);
            txtProductBrand.Location = new Point(84, 405);
            txtProductBrand.MaxLength = 30;
            txtProductBrand.Name = "txtProductBrand";
            txtProductBrand.Size = new Size(369, 30);
            txtProductBrand.TabIndex = 119;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Roboto", 14.25F);
            txtProductName.Location = new Point(85, 291);
            txtProductName.MaxLength = 50;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(369, 30);
            txtProductName.TabIndex = 118;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblSKU.Location = new Point(519, 212);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(36, 15);
            lblSKU.TabIndex = 117;
            lblSKU.Text = "SKU:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblProductCode.Location = new Point(519, 157);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(89, 15);
            lblProductCode.TabIndex = 116;
            lblProductCode.Text = "Product Code:";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblProductDescription.Location = new Point(86, 447);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(124, 15);
            lblProductDescription.TabIndex = 115;
            lblProductDescription.Text = "Product Description:";
            lblProductDescription.Click += lblProductDescription_Click;
            // 
            // lblProductBrand
            // 
            lblProductBrand.AutoSize = true;
            lblProductBrand.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblProductBrand.Location = new Point(84, 383);
            lblProductBrand.Name = "lblProductBrand";
            lblProductBrand.Size = new Size(93, 15);
            lblProductBrand.TabIndex = 114;
            lblProductBrand.Text = "Product Brand:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblProductName.Location = new Point(84, 273);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(96, 15);
            lblProductName.TabIndex = 113;
            lblProductName.Text = "Product  Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblCategory.Location = new Point(85, 213);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 15);
            lblCategory.TabIndex = 112;
            lblCategory.Text = "Category:";
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblSupplierID.Location = new Point(84, 157);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(58, 15);
            lblSupplierID.TabIndex = 111;
            lblSupplierID.Text = "Supplier:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(237, 242, 239);
            btnClose.Location = new Point(1224, 679);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 27);
            btnClose.TabIndex = 146;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Roboto", 14.25F);
            txtBarcode.Location = new Point(86, 349);
            txtBarcode.MaxLength = 15;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(369, 30);
            txtBarcode.TabIndex = 148;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(86, 331);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 147;
            label2.Text = "Barcode:";
            // 
            // num_low_quantity
            // 
            num_low_quantity.Font = new Font("Roboto", 14.25F);
            num_low_quantity.Location = new Point(521, 346);
            num_low_quantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            num_low_quantity.Name = "num_low_quantity";
            num_low_quantity.Size = new Size(369, 30);
            num_low_quantity.TabIndex = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(519, 328);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 149;
            label3.Text = "Low In Stock Quantity:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 69);
            panel1.TabIndex = 197;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(237, 242, 239);
            label1.Location = new Point(542, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 42);
            label1.TabIndex = 194;
            label1.Text = "EDIT PRODUCT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1170, 0);
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
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1370, 747);
            Controls.Add(panel1);
            Controls.Add(num_low_quantity);
            Controls.Add(label3);
            Controls.Add(txtBarcode);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(chkIsActive);
            Controls.Add(cmbStatus);
            Controls.Add(num_quantity);
            Controls.Add(txtRemarks);
            Controls.Add(num_unitPrice);
            Controls.Add(num_costPrice);
            Controls.Add(cmbUnitofMeasurements);
            Controls.Add(cmbCategory);
            Controls.Add(cmbSupplier);
            Controls.Add(dtpDateExpiration);
            Controls.Add(dtpDateReceived);
            Controls.Add(btnSubmit);
            Controls.Add(lblDateExpiration);
            Controls.Add(label7);
            Controls.Add(lblStatus);
            Controls.Add(lblRemarks);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblCostPrice);
            Controls.Add(lblUnitofMeasurement);
            Controls.Add(lblQuantity);
            Controls.Add(txtSKU);
            Controls.Add(txtProductCode);
            Controls.Add(txtDescription);
            Controls.Add(txtProductBrand);
            Controls.Add(txtProductName);
            Controls.Add(lblSKU);
            Controls.Add(lblProductCode);
            Controls.Add(lblProductDescription);
            Controls.Add(lblProductBrand);
            Controls.Add(lblProductName);
            Controls.Add(lblCategory);
            Controls.Add(lblSupplierID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Product";
            Load += EditProduct_Load;
            KeyDown += EditProduct_KeyDown;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_costPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_low_quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsActive;
        private ComboBox cmbStatus;
        private NumericUpDown num_quantity;
        private TextBox txtRemarks;
        private NumericUpDown num_unitPrice;
        private NumericUpDown num_costPrice;
        private ComboBox cmbUnitofMeasurements;
        private ComboBox cmbCategory;
        private ComboBox cmbSupplier;
        private DateTimePicker dtpDateExpiration;
        private DateTimePicker dtpDateReceived;
        private Button btnSubmit;
        private Label lblDateExpiration;
        private Label label7;
        private Label lblStatus;
        private Label lblRemarks;
        private Label lblUnitPrice;
        private Label lblCostPrice;
        private Label lblUnitofMeasurement;
        private Label lblQuantity;
        private TextBox txtSKU;
        private TextBox txtProductCode;
        private TextBox txtDescription;
        private TextBox txtProductBrand;
        private TextBox txtProductName;
        private Label lblSKU;
        private Label lblProductCode;
        private Label lblProductDescription;
        private Label lblProductBrand;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblSupplierID;
        private Button btnClose;
        private TextBox txtBarcode;
        private Label label2;
        private NumericUpDown num_low_quantity;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}