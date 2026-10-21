namespace PAKOPointOfSale.Transactions.Return
{
    partial class ReturnForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            lblInvoiceNumber = new Label();
            label3 = new Label();
            dgvReturnItems = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            product_brand = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            remainingQty = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            discount_type = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            total_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            transaction_id = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            salesInvoiceItemBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Font = new Font("Roboto", 14.25F, FontStyle.Bold | FontStyle.Italic);
            lblInvoiceNumber.ForeColor = Color.Black;
            lblInvoiceNumber.Location = new Point(163, 112);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(76, 23);
            lblInvoiceNumber.TabIndex = 7;
            lblInvoiceNumber.Text = "000000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 6;
            label3.Text = "Invoice Number:";
            // 
            // dgvReturnItems
            // 
            dgvReturnItems.AllowUserToAddRows = false;
            dgvReturnItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvReturnItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReturnItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnItems.BackgroundColor = Color.FromArgb(237, 242, 239);
            dgvReturnItems.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReturnItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReturnItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnItems.Columns.AddRange(new DataGridViewColumn[] { id, product_id, product_code, product_name, product_brand, quantity, remainingQty, unit_of_measurement, unit_price, discount_type, discount, total_amount, vatable_sales, vat_amount, vat_exempt, transaction_id, remove });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Roboto SemiBold", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReturnItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReturnItems.Location = new Point(12, 153);
            dgvReturnItems.Name = "dgvReturnItems";
            dgvReturnItems.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dgvReturnItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvReturnItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnItems.Size = new Size(1346, 623);
            dgvReturnItems.TabIndex = 8;
            dgvReturnItems.CellClick += dgvReturnItems_CellClick;
            dgvReturnItems.CellContentClick += dgvReturnItems_CellContentClick;
            dgvReturnItems.CellEndEdit += dgvReturnItems_CellEndEdit;
            dgvReturnItems.EditingControlShowing += dgvReturnItems_EditingControlShowing;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // product_id
            // 
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            // 
            // product_code
            // 
            product_code.DataPropertyName = "product_code";
            product_code.HeaderText = "Product Code";
            product_code.Name = "product_code";
            product_code.ReadOnly = true;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // product_brand
            // 
            product_brand.DataPropertyName = "product_brand";
            product_brand.HeaderText = "Brand";
            product_brand.Name = "product_brand";
            product_brand.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Quantity to Return";
            quantity.Name = "quantity";
            // 
            // remainingQty
            // 
            remainingQty.HeaderText = "Remaining Quantity to Return";
            remainingQty.Name = "remainingQty";
            remainingQty.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // unit_price
            // 
            unit_price.DataPropertyName = "unit_price";
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // discount_type
            // 
            discount_type.DataPropertyName = "discount_type";
            discount_type.HeaderText = "Discount Type";
            discount_type.Name = "discount_type";
            discount_type.ReadOnly = true;
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount Amount";
            discount.Name = "discount";
            discount.ReadOnly = true;
            // 
            // total_amount
            // 
            total_amount.DataPropertyName = "total_amount";
            total_amount.HeaderText = "Sub Total";
            total_amount.Name = "total_amount";
            total_amount.ReadOnly = true;
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "VATable Sales";
            vatable_sales.Name = "vatable_sales";
            vatable_sales.ReadOnly = true;
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "VAT Amount";
            vat_amount.Name = "vat_amount";
            vat_amount.ReadOnly = true;
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "VAT Exempt";
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            // 
            // transaction_id
            // 
            transaction_id.DataPropertyName = "transaction_id";
            transaction_id.HeaderText = "Transaction ID";
            transaction_id.Name = "transaction_id";
            transaction_id.ReadOnly = true;
            transaction_id.Visible = false;
            // 
            // remove
            // 
            remove.DataPropertyName = "id";
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.Text = "Remove Item";
            remove.UseColumnTextForButtonValue = true;
            // 
            // salesInvoiceItemBindingSource
            // 
            salesInvoiceItemBindingSource.DataSource = typeof(SalesInvoiceItem);
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 39, 56);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 9.75F);
            button1.ForeColor = Color.FromArgb(237, 242, 239);
            button1.Location = new Point(1146, 111);
            button1.Name = "button1";
            button1.Size = new Size(127, 36);
            button1.TabIndex = 9;
            button1.Text = "Confirm Return";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(318, 15);
            label1.TabIndex = 10;
            label1.Text = "Adjust the applied quantity for each item to be returned.";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Roboto", 9.75F);
            btnClose.ForeColor = Color.FromArgb(237, 242, 239);
            btnClose.Location = new Point(1279, 111);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 36);
            btnClose.TabIndex = 158;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1368, 69);
            panel1.TabIndex = 197;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(594, 12);
            label2.Name = "label2";
            label2.Size = new Size(263, 42);
            label2.TabIndex = 194;
            label2.Text = "RETURN ITEMS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1168, 0);
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
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1368, 788);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dgvReturnItems);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label3);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReturnForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Items";
            Load += ReturnForm_Load;
            KeyDown += ReturnForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dgvReturnItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)salesInvoiceItemBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInvoiceNumber;
        private Label label3;
        private DataGridView dgvReturnItems;
        private BindingSource salesInvoiceItemBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private Label label1;
        private DataGridViewTextBoxColumn trasaction_id;
        private Button btnClose;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn product_brand;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn remainingQty;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn discount_type;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn total_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewButtonColumn remove;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}