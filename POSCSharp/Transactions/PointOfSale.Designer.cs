
namespace PAKOPointOfSale.Transactions
{
    partial class PointOfSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSale));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            productBindingSource = new BindingSource(components);
            userTypeBindingSource = new BindingSource(components);
            btnSearchProduct = new Button();
            btnPark = new Button();
            btnApplyDiscount = new Button();
            btnClearCart = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            timeAndDate = new System.Windows.Forms.Timer(components);
            btnParkedTransactions = new Button();
            btnScan = new Button();
            btnRemove = new Button();
            btnTransactions = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEndShift = new Button();
            txtScannedBarcode = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            lblFullName = new Label();
            panel3 = new Panel();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            lblPendingNumber = new Label();
            splitContainer1 = new SplitContainer();
            dtgvCart = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            unit_of_measurement = new DataGridViewTextBoxColumn();
            appliedQty = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            discountType = new DataGridViewTextBoxColumn();
            discountAmount = new DataGridViewTextBoxColumn();
            subTotal = new DataGridViewTextBoxColumn();
            vatableSales = new DataGridViewTextBoxColumn();
            vatAmount = new DataGridViewTextBoxColumn();
            vatExempt = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnConfirm = new Button();
            groupBox1 = new GroupBox();
            lblChange = new Label();
            lblDiscountAmount = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnKey1 = new Button();
            btnKey2 = new Button();
            btnKey3 = new Button();
            btnKey4 = new Button();
            btnKey5 = new Button();
            btnKey6 = new Button();
            btnKey7 = new Button();
            btnKey8 = new Button();
            btnKey9 = new Button();
            btnClearCash = new Button();
            btnDot = new Button();
            btn00 = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn1h = new Button();
            btn1k = new Button();
            btn2h = new Button();
            btn5h = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            num_cash = new NumericUpDown();
            label4 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCart).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_cash).BeginInit();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(WinFormsApp1.Model.Product);
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.BackColor = Color.FromArgb(87, 196, 229);
            btnSearchProduct.Dock = DockStyle.Fill;
            btnSearchProduct.FlatStyle = FlatStyle.Popup;
            btnSearchProduct.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchProduct.ForeColor = Color.FromArgb(33, 39, 56);
            btnSearchProduct.Location = new Point(3, 3);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(152, 38);
            btnSearchProduct.TabIndex = 3;
            btnSearchProduct.Text = "Search Product [SPACE]";
            btnSearchProduct.UseVisualStyleBackColor = false;
            btnSearchProduct.Click += btnSearchProduct_Click;
            // 
            // btnPark
            // 
            btnPark.BackColor = Color.FromArgb(87, 196, 229);
            btnPark.Dock = DockStyle.Fill;
            btnPark.FlatStyle = FlatStyle.Popup;
            btnPark.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnPark.ForeColor = Color.FromArgb(33, 39, 56);
            btnPark.Location = new Point(319, 3);
            btnPark.Name = "btnPark";
            btnPark.Size = new Size(152, 38);
            btnPark.TabIndex = 7;
            btnPark.Text = "Set as Pending [F5]";
            btnPark.UseVisualStyleBackColor = false;
            btnPark.Click += button2_Click_Park;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BackColor = Color.FromArgb(87, 196, 229);
            btnApplyDiscount.Dock = DockStyle.Fill;
            btnApplyDiscount.FlatStyle = FlatStyle.Popup;
            btnApplyDiscount.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnApplyDiscount.ForeColor = Color.FromArgb(33, 39, 56);
            btnApplyDiscount.Location = new Point(161, 3);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.Size = new Size(152, 38);
            btnApplyDiscount.TabIndex = 45;
            btnApplyDiscount.Text = "Apply Discount [F4]";
            btnApplyDiscount.UseVisualStyleBackColor = false;
            btnApplyDiscount.Click += button1_Click_2;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(87, 196, 229);
            btnClearCart.Dock = DockStyle.Fill;
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.FromArgb(33, 39, 56);
            btnClearCart.Location = new Point(635, 3);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(152, 38);
            btnClearCart.TabIndex = 45;
            btnClearCart.Text = "Clear Cart [F1] ";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += button1_Click_clear;
            // 
            // timeAndDate
            // 
            timeAndDate.Enabled = true;
            timeAndDate.Interval = 1000;
            timeAndDate.Tick += timer1_Tick;
            // 
            // btnParkedTransactions
            // 
            btnParkedTransactions.BackColor = Color.FromArgb(87, 196, 229);
            btnParkedTransactions.Dock = DockStyle.Fill;
            btnParkedTransactions.FlatStyle = FlatStyle.Popup;
            btnParkedTransactions.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnParkedTransactions.ForeColor = Color.FromArgb(33, 39, 56);
            btnParkedTransactions.Location = new Point(477, 3);
            btnParkedTransactions.Name = "btnParkedTransactions";
            btnParkedTransactions.Size = new Size(152, 38);
            btnParkedTransactions.TabIndex = 159;
            btnParkedTransactions.Text = "Pending Transactions [F3]";
            btnParkedTransactions.UseVisualStyleBackColor = false;
            btnParkedTransactions.Click += btnParkedTransactions_Click;
            // 
            // btnScan
            // 
            btnScan.BackColor = Color.FromArgb(87, 196, 229);
            btnScan.Dock = DockStyle.Fill;
            btnScan.FlatStyle = FlatStyle.Popup;
            btnScan.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnScan.ForeColor = Color.FromArgb(33, 39, 56);
            btnScan.Location = new Point(793, 3);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(152, 38);
            btnScan.TabIndex = 160;
            btnScan.Text = "Scan Barcode [Shift]";
            btnScan.UseVisualStyleBackColor = false;
            btnScan.Click += btnScan_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(87, 196, 229);
            btnRemove.Dock = DockStyle.Fill;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnRemove.ForeColor = Color.FromArgb(33, 39, 56);
            btnRemove.Location = new Point(951, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(152, 38);
            btnRemove.TabIndex = 161;
            btnRemove.Text = "Remove Selected Item(s) [F2]";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(87, 196, 229);
            btnTransactions.Dock = DockStyle.Fill;
            btnTransactions.FlatStyle = FlatStyle.Popup;
            btnTransactions.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnTransactions.ForeColor = Color.FromArgb(33, 39, 56);
            btnTransactions.Location = new Point(1109, 3);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(152, 38);
            btnTransactions.TabIndex = 162;
            btnTransactions.Text = "Transactions  [F6]";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 9;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1116047F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1071606F));
            tableLayoutPanel3.Controls.Add(btnEndShift, 8, 0);
            tableLayoutPanel3.Controls.Add(btnSearchProduct, 0, 0);
            tableLayoutPanel3.Controls.Add(btnApplyDiscount, 1, 0);
            tableLayoutPanel3.Controls.Add(btnPark, 2, 0);
            tableLayoutPanel3.Controls.Add(btnTransactions, 7, 0);
            tableLayoutPanel3.Controls.Add(btnParkedTransactions, 3, 0);
            tableLayoutPanel3.Controls.Add(btnRemove, 6, 0);
            tableLayoutPanel3.Controls.Add(btnClearCart, 4, 0);
            tableLayoutPanel3.Controls.Add(btnScan, 5, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 78);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1428, 44);
            tableLayoutPanel3.TabIndex = 195;
            // 
            // btnEndShift
            // 
            btnEndShift.BackColor = Color.FromArgb(249, 112, 104);
            btnEndShift.Dock = DockStyle.Fill;
            btnEndShift.FlatStyle = FlatStyle.Popup;
            btnEndShift.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnEndShift.ForeColor = Color.FromArgb(237, 242, 239);
            btnEndShift.Location = new Point(1267, 3);
            btnEndShift.Name = "btnEndShift";
            btnEndShift.Size = new Size(158, 38);
            btnEndShift.TabIndex = 163;
            btnEndShift.Text = "END SHIFT";
            btnEndShift.UseVisualStyleBackColor = false;
            btnEndShift.Click += btnEndShift_Click;
            // 
            // txtScannedBarcode
            // 
            txtScannedBarcode.Location = new Point(772, 557);
            txtScannedBarcode.Name = "txtScannedBarcode";
            txtScannedBarcode.Size = new Size(100, 23);
            txtScannedBarcode.TabIndex = 196;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel6.Controls.Add(splitContainer1, 0, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1434, 797);
            tableLayoutPanel6.TabIndex = 198;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.BackColor = Color.FromArgb(33, 39, 56);
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel7, 2, 0);
            tableLayoutPanel9.Controls.Add(panel3, 0, 0);
            tableLayoutPanel9.Controls.Add(lblPendingNumber, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Top;
            tableLayoutPanel9.ForeColor = SystemColors.ControlLightLight;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(1428, 69);
            tableLayoutPanel9.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel7.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel7.Controls.Add(lblFullName, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Right;
            tableLayoutPanel7.Location = new Point(1142, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(283, 63);
            tableLayoutPanel7.TabIndex = 192;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Roboto", 11.25F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(192, 22);
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
            lblDate.Location = new Point(178, 1);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(102, 18);
            lblDate.TabIndex = 159;
            lblDate.Text = "MM/DD/YYYY";
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Right;
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Roboto SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(209, 214, 70);
            lblFullName.Location = new Point(184, 42);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(96, 21);
            lblFullName.TabIndex = 184;
            lblFullName.Text = "Full Name";
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 63);
            panel3.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(237, 242, 239);
            label8.Location = new Point(54, 9);
            label8.Name = "label8";
            label8.Size = new Size(127, 42);
            label8.TabIndex = 191;
            label8.Text = "ATPOS";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-6, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 189;
            pictureBox4.TabStop = false;
            // 
            // lblPendingNumber
            // 
            lblPendingNumber.AutoSize = true;
            lblPendingNumber.Dock = DockStyle.Fill;
            lblPendingNumber.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            lblPendingNumber.ForeColor = Color.FromArgb(237, 242, 239);
            lblPendingNumber.Location = new Point(479, 0);
            lblPendingNumber.Name = "lblPendingNumber";
            lblPendingNumber.Size = new Size(470, 69);
            lblPendingNumber.TabIndex = 157;
            lblPendingNumber.Text = "Pending Number:";
            lblPendingNumber.TextAlign = ContentAlignment.MiddleCenter;
            lblPendingNumber.Visible = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 128);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Transparent;
            splitContainer1.Panel1.Controls.Add(dtgvCart);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1428, 666);
            splitContainer1.SplitterDistance = 995;
            splitContainer1.TabIndex = 197;
            // 
            // dtgvCart
            // 
            dtgvCart.AllowUserToAddRows = false;
            dtgvCart.AllowUserToDeleteRows = false;
            dtgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCart.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCart.Columns.AddRange(new DataGridViewColumn[] { id, product, brand, unit_of_measurement, appliedQty, unit_price, category, discountType, discountAmount, subTotal, vatableSales, vatAmount, vatExempt });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgvCart.DefaultCellStyle = dataGridViewCellStyle4;
            dtgvCart.Dock = DockStyle.Fill;
            dtgvCart.Location = new Point(0, 0);
            dtgvCart.Name = "dtgvCart";
            dtgvCart.RowHeadersVisible = false;
            dtgvCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtgvCart.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvCart.Size = new Size(995, 666);
            dtgvCart.TabIndex = 4;
            dtgvCart.CellClick += dtgvCart_CellClick;
            dtgvCart.CellContentClick += dtgvCart_CellContentClick;
            dtgvCart.CellEndEdit += dtgvCart_CellEndEdit;
            dtgvCart.CellValueChanged += dtgvCart_CellValueChanged;
            dtgvCart.EditingControlShowing += dtgvCart_EditingControlShowing;
            dtgvCart.KeyPress += SalesInvoice_KeyPress;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            // 
            // product
            // 
            product.HeaderText = "Product";
            product.Name = "product";
            product.ReadOnly = true;
            // 
            // brand
            // 
            brand.HeaderText = "Brand";
            brand.Name = "brand";
            brand.ReadOnly = true;
            // 
            // unit_of_measurement
            // 
            unit_of_measurement.HeaderText = "Unit";
            unit_of_measurement.Name = "unit_of_measurement";
            unit_of_measurement.ReadOnly = true;
            // 
            // appliedQty
            // 
            appliedQty.HeaderText = "Quantity";
            appliedQty.Name = "appliedQty";
            // 
            // unit_price
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            unit_price.DefaultCellStyle = dataGridViewCellStyle2;
            unit_price.HeaderText = "Price";
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "Category";
            category.Name = "category";
            category.ReadOnly = true;
            category.Visible = false;
            // 
            // discountType
            // 
            discountType.DataPropertyName = "discountType";
            discountType.HeaderText = "Discount Type";
            discountType.Name = "discountType";
            discountType.ReadOnly = true;
            // 
            // discountAmount
            // 
            discountAmount.DataPropertyName = "discountAmount";
            discountAmount.HeaderText = "Discount Amount";
            discountAmount.Name = "discountAmount";
            discountAmount.ReadOnly = true;
            discountAmount.Visible = false;
            // 
            // subTotal
            // 
            subTotal.DataPropertyName = "subTotal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            subTotal.DefaultCellStyle = dataGridViewCellStyle3;
            subTotal.HeaderText = "Total";
            subTotal.Name = "subTotal";
            subTotal.ReadOnly = true;
            // 
            // vatableSales
            // 
            vatableSales.DataPropertyName = "vatableSales";
            vatableSales.HeaderText = "VATable Sales";
            vatableSales.Name = "vatableSales";
            vatableSales.ReadOnly = true;
            vatableSales.Visible = false;
            // 
            // vatAmount
            // 
            vatAmount.DataPropertyName = "vatAmount";
            vatAmount.HeaderText = "VAT Amount";
            vatAmount.Name = "vatAmount";
            vatAmount.ReadOnly = true;
            vatAmount.Visible = false;
            // 
            // vatExempt
            // 
            vatExempt.DataPropertyName = "vatExempt";
            vatExempt.HeaderText = "VAT Exempt";
            vatExempt.Name = "vatExempt";
            vatExempt.ReadOnly = true;
            vatExempt.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 666);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnConfirm, 0, 4);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.52632F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.1052628F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel1.Size = new Size(429, 666);
            tableLayoutPanel1.TabIndex = 46;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(209, 214, 70);
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.FromArgb(33, 39, 56);
            btnConfirm.Location = new Point(3, 535);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(423, 128);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "CONFIRM [ENTER]";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblChange);
            groupBox1.Controls.Add(lblDiscountAmount);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 160);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            lblChange.ForeColor = Color.FromArgb(237, 242, 239);
            lblChange.Location = new Point(102, 101);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(54, 25);
            lblChange.TabIndex = 12;
            lblChange.Text = "0.00";
            // 
            // lblDiscountAmount
            // 
            lblDiscountAmount.AutoSize = true;
            lblDiscountAmount.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            lblDiscountAmount.ForeColor = Color.FromArgb(237, 242, 239);
            lblDiscountAmount.Location = new Point(108, 55);
            lblDiscountAmount.Name = "lblDiscountAmount";
            lblDiscountAmount.Size = new Size(54, 25);
            lblDiscountAmount.TabIndex = 10;
            lblDiscountAmount.Text = "0.00";
            lblDiscountAmount.Click += lblDiscountAmount_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(237, 242, 239);
            lblTotal.Location = new Point(139, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 25);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(237, 242, 239);
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 7;
            label3.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(6, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 6;
            label2.Text = "Change:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(237, 242, 239);
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 5;
            label1.Text = "Grand Total:";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnKey1, 0, 0);
            tableLayoutPanel2.Controls.Add(btnKey2, 1, 0);
            tableLayoutPanel2.Controls.Add(btnKey3, 2, 0);
            tableLayoutPanel2.Controls.Add(btnKey4, 0, 1);
            tableLayoutPanel2.Controls.Add(btnKey5, 1, 1);
            tableLayoutPanel2.Controls.Add(btnKey6, 2, 1);
            tableLayoutPanel2.Controls.Add(btnKey7, 0, 2);
            tableLayoutPanel2.Controls.Add(btnKey8, 1, 2);
            tableLayoutPanel2.Controls.Add(btnKey9, 2, 2);
            tableLayoutPanel2.Controls.Add(btnClearCash, 2, 3);
            tableLayoutPanel2.Controls.Add(btnDot, 1, 3);
            tableLayoutPanel2.Controls.Add(btn00, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(423, 259);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // btnKey1
            // 
            btnKey1.BackColor = Color.FromArgb(87, 196, 229);
            btnKey1.Dock = DockStyle.Fill;
            btnKey1.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey1.FlatAppearance.BorderSize = 3;
            btnKey1.FlatStyle = FlatStyle.Flat;
            btnKey1.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey1.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey1.Location = new Point(3, 3);
            btnKey1.Name = "btnKey1";
            btnKey1.Size = new Size(134, 58);
            btnKey1.TabIndex = 32;
            btnKey1.Text = "1";
            btnKey1.UseVisualStyleBackColor = false;
            btnKey1.Click += button6_Click;
            // 
            // btnKey2
            // 
            btnKey2.BackColor = Color.FromArgb(87, 196, 229);
            btnKey2.Dock = DockStyle.Fill;
            btnKey2.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey2.FlatAppearance.BorderSize = 3;
            btnKey2.FlatStyle = FlatStyle.Flat;
            btnKey2.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey2.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey2.Location = new Point(143, 3);
            btnKey2.Name = "btnKey2";
            btnKey2.Size = new Size(134, 58);
            btnKey2.TabIndex = 33;
            btnKey2.Text = "2";
            btnKey2.UseVisualStyleBackColor = false;
            btnKey2.Click += btnKey2_Click;
            // 
            // btnKey3
            // 
            btnKey3.BackColor = Color.FromArgb(87, 196, 229);
            btnKey3.Dock = DockStyle.Fill;
            btnKey3.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey3.FlatAppearance.BorderSize = 3;
            btnKey3.FlatStyle = FlatStyle.Flat;
            btnKey3.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey3.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey3.Location = new Point(283, 3);
            btnKey3.Name = "btnKey3";
            btnKey3.Size = new Size(137, 58);
            btnKey3.TabIndex = 34;
            btnKey3.Text = "3";
            btnKey3.UseVisualStyleBackColor = false;
            btnKey3.Click += btnKey3_Click;
            // 
            // btnKey4
            // 
            btnKey4.BackColor = Color.FromArgb(87, 196, 229);
            btnKey4.Dock = DockStyle.Fill;
            btnKey4.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey4.FlatAppearance.BorderSize = 3;
            btnKey4.FlatStyle = FlatStyle.Flat;
            btnKey4.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey4.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey4.Location = new Point(3, 67);
            btnKey4.Name = "btnKey4";
            btnKey4.Size = new Size(134, 58);
            btnKey4.TabIndex = 35;
            btnKey4.Text = "4";
            btnKey4.UseVisualStyleBackColor = false;
            btnKey4.Click += btnKey4_Click;
            // 
            // btnKey5
            // 
            btnKey5.BackColor = Color.FromArgb(87, 196, 229);
            btnKey5.Dock = DockStyle.Fill;
            btnKey5.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey5.FlatAppearance.BorderSize = 3;
            btnKey5.FlatStyle = FlatStyle.Flat;
            btnKey5.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey5.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey5.Location = new Point(143, 67);
            btnKey5.Name = "btnKey5";
            btnKey5.Size = new Size(134, 58);
            btnKey5.TabIndex = 38;
            btnKey5.Text = "5";
            btnKey5.UseVisualStyleBackColor = false;
            btnKey5.Click += btnKey5_Click;
            // 
            // btnKey6
            // 
            btnKey6.BackColor = Color.FromArgb(87, 196, 229);
            btnKey6.Dock = DockStyle.Fill;
            btnKey6.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey6.FlatAppearance.BorderSize = 3;
            btnKey6.FlatStyle = FlatStyle.Flat;
            btnKey6.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey6.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey6.Location = new Point(283, 67);
            btnKey6.Name = "btnKey6";
            btnKey6.Size = new Size(137, 58);
            btnKey6.TabIndex = 40;
            btnKey6.Text = "6";
            btnKey6.UseVisualStyleBackColor = false;
            btnKey6.Click += btnKey6_Click;
            // 
            // btnKey7
            // 
            btnKey7.BackColor = Color.FromArgb(87, 196, 229);
            btnKey7.Dock = DockStyle.Fill;
            btnKey7.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey7.FlatAppearance.BorderSize = 3;
            btnKey7.FlatStyle = FlatStyle.Flat;
            btnKey7.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey7.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey7.Location = new Point(3, 131);
            btnKey7.Name = "btnKey7";
            btnKey7.Size = new Size(134, 58);
            btnKey7.TabIndex = 36;
            btnKey7.Text = "7";
            btnKey7.UseVisualStyleBackColor = false;
            btnKey7.Click += btnKey7_Click;
            // 
            // btnKey8
            // 
            btnKey8.BackColor = Color.FromArgb(87, 196, 229);
            btnKey8.Dock = DockStyle.Fill;
            btnKey8.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey8.FlatAppearance.BorderSize = 3;
            btnKey8.FlatStyle = FlatStyle.Flat;
            btnKey8.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey8.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey8.Location = new Point(143, 131);
            btnKey8.Name = "btnKey8";
            btnKey8.Size = new Size(134, 58);
            btnKey8.TabIndex = 39;
            btnKey8.Text = "8";
            btnKey8.UseVisualStyleBackColor = false;
            btnKey8.Click += btnKey8_Click;
            // 
            // btnKey9
            // 
            btnKey9.BackColor = Color.FromArgb(87, 196, 229);
            btnKey9.Dock = DockStyle.Fill;
            btnKey9.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnKey9.FlatAppearance.BorderSize = 3;
            btnKey9.FlatStyle = FlatStyle.Flat;
            btnKey9.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnKey9.ForeColor = Color.FromArgb(33, 39, 56);
            btnKey9.Location = new Point(283, 131);
            btnKey9.Name = "btnKey9";
            btnKey9.Size = new Size(137, 58);
            btnKey9.TabIndex = 37;
            btnKey9.Text = "9";
            btnKey9.UseVisualStyleBackColor = false;
            btnKey9.Click += btnKey9_Click;
            // 
            // btnClearCash
            // 
            btnClearCash.BackColor = Color.FromArgb(87, 196, 229);
            btnClearCash.Dock = DockStyle.Fill;
            btnClearCash.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnClearCash.FlatAppearance.BorderSize = 3;
            btnClearCash.FlatStyle = FlatStyle.Flat;
            btnClearCash.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnClearCash.ForeColor = Color.FromArgb(33, 39, 56);
            btnClearCash.Location = new Point(283, 195);
            btnClearCash.Name = "btnClearCash";
            btnClearCash.Size = new Size(137, 61);
            btnClearCash.TabIndex = 41;
            btnClearCash.Text = "CLEAR";
            btnClearCash.UseVisualStyleBackColor = false;
            btnClearCash.Click += btnClearCash_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(87, 196, 229);
            btnDot.Dock = DockStyle.Fill;
            btnDot.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btnDot.FlatAppearance.BorderSize = 3;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btnDot.ForeColor = Color.FromArgb(33, 39, 56);
            btnDot.Location = new Point(143, 195);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(134, 61);
            btnDot.TabIndex = 43;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btn00
            // 
            btn00.BackColor = Color.FromArgb(87, 196, 229);
            btn00.Dock = DockStyle.Fill;
            btn00.FlatAppearance.BorderColor = Color.FromArgb(33, 39, 56);
            btn00.FlatAppearance.BorderSize = 3;
            btn00.FlatStyle = FlatStyle.Flat;
            btn00.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btn00.ForeColor = Color.FromArgb(33, 39, 56);
            btn00.Location = new Point(3, 195);
            btn00.Name = "btn00";
            btn00.Size = new Size(134, 61);
            btn00.TabIndex = 44;
            btn00.Text = "0";
            btn00.UseVisualStyleBackColor = false;
            btn00.Click += btn00_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(btn1h, 3, 0);
            tableLayoutPanel4.Controls.Add(btn1k, 0, 0);
            tableLayoutPanel4.Controls.Add(btn2h, 2, 0);
            tableLayoutPanel4.Controls.Add(btn5h, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(423, 60);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btn1h
            // 
            btn1h.BackColor = Color.FromArgb(33, 39, 56);
            btn1h.Dock = DockStyle.Fill;
            btn1h.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 239);
            btn1h.FlatAppearance.BorderSize = 3;
            btn1h.FlatStyle = FlatStyle.Flat;
            btn1h.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btn1h.ForeColor = Color.FromArgb(237, 242, 239);
            btn1h.Location = new Point(318, 3);
            btn1h.Name = "btn1h";
            btn1h.Size = new Size(102, 54);
            btn1h.TabIndex = 31;
            btn1h.Text = "₱100";
            btn1h.UseVisualStyleBackColor = false;
            btn1h.Click += btn1h_Click;
            // 
            // btn1k
            // 
            btn1k.BackColor = Color.FromArgb(33, 39, 56);
            btn1k.Dock = DockStyle.Fill;
            btn1k.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 239);
            btn1k.FlatAppearance.BorderSize = 3;
            btn1k.FlatStyle = FlatStyle.Flat;
            btn1k.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btn1k.ForeColor = Color.FromArgb(237, 242, 239);
            btn1k.Location = new Point(3, 3);
            btn1k.Name = "btn1k";
            btn1k.Size = new Size(99, 54);
            btn1k.TabIndex = 0;
            btn1k.Text = "₱1000";
            btn1k.UseVisualStyleBackColor = false;
            btn1k.Click += button1_Click_1;
            // 
            // btn2h
            // 
            btn2h.BackColor = Color.FromArgb(33, 39, 56);
            btn2h.Dock = DockStyle.Fill;
            btn2h.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 239);
            btn2h.FlatAppearance.BorderSize = 3;
            btn2h.FlatStyle = FlatStyle.Flat;
            btn2h.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btn2h.ForeColor = Color.FromArgb(237, 242, 239);
            btn2h.Location = new Point(213, 3);
            btn2h.Name = "btn2h";
            btn2h.Size = new Size(99, 54);
            btn2h.TabIndex = 30;
            btn2h.Text = "₱200";
            btn2h.UseVisualStyleBackColor = false;
            btn2h.Click += btn2h_Click;
            // 
            // btn5h
            // 
            btn5h.BackColor = Color.FromArgb(33, 39, 56);
            btn5h.Dock = DockStyle.Fill;
            btn5h.FlatAppearance.BorderColor = Color.FromArgb(237, 242, 239);
            btn5h.FlatAppearance.BorderSize = 3;
            btn5h.FlatStyle = FlatStyle.Flat;
            btn5h.Font = new Font("Roboto SemiBold", 12F, FontStyle.Bold);
            btn5h.ForeColor = Color.FromArgb(237, 242, 239);
            btn5h.Location = new Point(108, 3);
            btn5h.Name = "btn5h";
            btn5h.Size = new Size(99, 54);
            btn5h.TabIndex = 29;
            btn5h.Text = "₱500";
            btn5h.UseVisualStyleBackColor = false;
            btn5h.Click += btn5h_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel5.Controls.Add(num_cash, 1, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 334);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(423, 29);
            tableLayoutPanel5.TabIndex = 47;
            // 
            // num_cash
            // 
            num_cash.BackColor = Color.White;
            num_cash.DecimalPlaces = 2;
            num_cash.Dock = DockStyle.Fill;
            num_cash.Font = new Font("Roboto", 14.25F);
            num_cash.ForeColor = Color.Black;
            num_cash.InterceptArrowKeys = false;
            num_cash.Location = new Point(108, 3);
            num_cash.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            num_cash.Name = "num_cash";
            num_cash.Size = new Size(312, 30);
            num_cash.TabIndex = 45;
            num_cash.TextAlign = HorizontalAlignment.Right;
            num_cash.ThousandsSeparator = true;
            num_cash.ValueChanged += num_cash_ValueChanged;
            num_cash.KeyPress += num_cash_KeyPress;
            num_cash.Leave += num_cash_Leave;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(237, 242, 239);
            label4.Location = new Point(3, 2);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 8;
            label4.Text = "Cash:";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Location = new Point(558, 196);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(8, 8);
            tableLayoutPanel8.TabIndex = 199;
            // 
            // PointOfSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1434, 797);
            Controls.Add(tableLayoutPanel8);
            Controls.Add(tableLayoutPanel6);
            Controls.Add(txtScannedBarcode);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "PointOfSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Invoice";
            WindowState = FormWindowState.Maximized;
            Load += SalesInvoice_Load;
            KeyDown += SalesInvoice_KeyDown;
            KeyPress += SalesInvoice_KeyPress;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCart).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_cash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private BindingSource productBindingSource;
        private BindingSource userTypeBindingSource;
        private Button btnSearchProduct;
        private Button btnPark;
        private Button btnApplyDiscount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timeAndDate;
        private Button btnParkedTransactions;
        private Button btnClearCart;
        private Button btnScan;
        private Button btnRemove;
        private Button btnTransactions;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtScannedBarcode;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private SplitContainer splitContainer1;
        private DataGridView dtgvCart;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn unit_of_measurement;
        private DataGridViewTextBoxColumn appliedQty;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn discountType;
        private DataGridViewTextBoxColumn discountAmount;
        private DataGridViewTextBoxColumn subTotal;
        private DataGridViewTextBoxColumn vatableSales;
        private DataGridViewTextBoxColumn vatAmount;
        private DataGridViewTextBoxColumn vatExempt;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnConfirm;
        private GroupBox groupBox1;
        private Label lblChange;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnKey5;
        private Button btnKey1;
        private Button btnKey8;
        private Button btnKey2;
        private Button btnKey9;
        private Button btnKey6;
        private Button btn00;
        private Button btnKey7;
        private Button btnClearCash;
        private Button btnKey4;
        private Button btnDot;
        private Button btnKey3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn1h;
        private Button btn1k;
        private Button btn2h;
        private Button btn5h;
        private TableLayoutPanel tableLayoutPanel5;
        private NumericUpDown num_cash;
        private Label label4;
        private Label lblPendingNumber;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
        private Label lblFullName;
        private Button btnEndShift;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel3;
    }
}