
namespace PAKOPointOfSale
{
    partial class MDIParent1
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            menuStrip = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            activityLogsToolStripMenuItem = new ToolStripMenuItem();
            backupDatabaseToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            dtgvTop5SellingProducts = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            total_quantity_sold = new DataGridViewTextBoxColumn();
            total_sales = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            dtpFrom = new DateTimePicker();
            gbTop5Sellings = new GroupBox();
            btnExportTop5Selling = new Button();
            btnFilter = new Button();
            comboBoxSalesFilter = new ComboBox();
            label3 = new Label();
            dtpFromSales = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpToSales = new DateTimePicker();
            btnFilterDateSales = new Button();
            gbSales = new GroupBox();
            lblGrossSales = new Label();
            lblNetSales = new Label();
            label8 = new Label();
            btnClearFilters = new Button();
            label4 = new Label();
            timeReloadData = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            lblDate = new Label();
            button2 = new Button();
            btnPos = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnSuppliers = new Button();
            btnTransactions = new Button();
            btnUsers = new Button();
            btnUac = new Button();
            timerDateandTime = new System.Windows.Forms.Timer(components);
            lblFullName = new Label();
            gbLowStocks = new GroupBox();
            dtgvLowStocks = new DataGridView();
            product_name2 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).BeginInit();
            gbTop5Sellings.SuspendLayout();
            gbSales.SuspendLayout();
            gbLowStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLowStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Transparent;
            menuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.RightToLeft = RightToLeft.Yes;
            menuStrip.Size = new Size(1378, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.BackColor = Color.Transparent;
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activityLogsToolStripMenuItem, backupDatabaseToolStripMenuItem });
            optionsToolStripMenuItem.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            optionsToolStripMenuItem.ForeColor = Color.FromArgb(237, 242, 239);
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(63, 20);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            optionsToolStripMenuItem.MouseLeave += optionsToolStripMenuItem_MouseLeave;
            optionsToolStripMenuItem.MouseHover += optionsToolStripMenuItem_MouseHover;
            // 
            // activityLogsToolStripMenuItem
            // 
            activityLogsToolStripMenuItem.Name = "activityLogsToolStripMenuItem";
            activityLogsToolStripMenuItem.Size = new Size(174, 22);
            activityLogsToolStripMenuItem.Text = "Activity Logs";
            activityLogsToolStripMenuItem.Click += activityLogsToolStripMenuItem_Click;
            // 
            // backupDatabaseToolStripMenuItem
            // 
            backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            backupDatabaseToolStripMenuItem.Size = new Size(174, 22);
            backupDatabaseToolStripMenuItem.Text = "Backup Database";
            backupDatabaseToolStripMenuItem.Click += backupDatabaseToolStripMenuItem_Click;
            // 
            // toolTip
            // 
            toolTip.Popup += toolTip_Popup;
            // 
            // dtgvTop5SellingProducts
            // 
            dtgvTop5SellingProducts.AllowUserToAddRows = false;
            dtgvTop5SellingProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dtgvTop5SellingProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgvTop5SellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTop5SellingProducts.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvTop5SellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTop5SellingProducts.Columns.AddRange(new DataGridViewColumn[] { product_name, total_quantity_sold, total_sales });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Roboto", 9.75F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtgvTop5SellingProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dtgvTop5SellingProducts.Location = new Point(13, 72);
            dtgvTop5SellingProducts.Name = "dtgvTop5SellingProducts";
            dtgvTop5SellingProducts.ReadOnly = true;
            dtgvTop5SellingProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dtgvTop5SellingProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgvTop5SellingProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvTop5SellingProducts.Size = new Size(547, 331);
            dtgvTop5SellingProducts.TabIndex = 11;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // total_quantity_sold
            // 
            total_quantity_sold.DataPropertyName = "total_quantity_sold";
            total_quantity_sold.HeaderText = "Total Quantity Sold";
            total_quantity_sold.Name = "total_quantity_sold";
            total_quantity_sold.ReadOnly = true;
            // 
            // total_sales
            // 
            total_sales.DataPropertyName = "total_sales";
            total_sales.HeaderText = "Total Sales";
            total_sales.Name = "total_sales";
            total_sales.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(205, 18);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Roboto", 9.75F);
            dtpTo.Location = new Point(205, 36);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(185, 23);
            dtpTo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 9.75F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarMonthBackground = Color.White;
            dtpFrom.Font = new Font("Roboto", 9.75F);
            dtpFrom.Location = new Point(13, 36);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(187, 23);
            dtpFrom.TabIndex = 6;
            // 
            // gbTop5Sellings
            // 
            gbTop5Sellings.BackColor = Color.FromArgb(87, 196, 229);
            gbTop5Sellings.Controls.Add(dtgvTop5SellingProducts);
            gbTop5Sellings.Controls.Add(btnExportTop5Selling);
            gbTop5Sellings.Controls.Add(dtpFrom);
            gbTop5Sellings.Controls.Add(label1);
            gbTop5Sellings.Controls.Add(dtpTo);
            gbTop5Sellings.Controls.Add(label2);
            gbTop5Sellings.Controls.Add(btnFilter);
            gbTop5Sellings.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTop5Sellings.ForeColor = Color.Black;
            gbTop5Sellings.Location = new Point(7, 40);
            gbTop5Sellings.Name = "gbTop5Sellings";
            gbTop5Sellings.Size = new Size(575, 421);
            gbTop5Sellings.TabIndex = 13;
            gbTop5Sellings.TabStop = false;
            gbTop5Sellings.Text = "Top 5 Selling Products";
            gbTop5Sellings.Enter += gbTop5Sellings_Enter;
            // 
            // btnExportTop5Selling
            // 
            btnExportTop5Selling.BackColor = Color.FromArgb(209, 214, 70);
            btnExportTop5Selling.FlatStyle = FlatStyle.Popup;
            btnExportTop5Selling.Font = new Font("Roboto", 9.75F);
            btnExportTop5Selling.ForeColor = Color.Black;
            btnExportTop5Selling.Location = new Point(485, 37);
            btnExportTop5Selling.Name = "btnExportTop5Selling";
            btnExportTop5Selling.Size = new Size(75, 23);
            btnExportTop5Selling.TabIndex = 16;
            btnExportTop5Selling.Text = "Export";
            btnExportTop5Selling.UseVisualStyleBackColor = false;
            btnExportTop5Selling.Click += btnExportTop5Selling_Click;
            // 
            // btnFilter
            // 
            btnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilter.BackColor = Color.FromArgb(33, 39, 56);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilter.Location = new Point(398, 36);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 15;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // comboBoxSalesFilter
            // 
            comboBoxSalesFilter.Font = new Font("Roboto", 9.75F);
            comboBoxSalesFilter.FormattingEnabled = true;
            comboBoxSalesFilter.Items.AddRange(new object[] { "Today", "This Week", "This Month", "This Year" });
            comboBoxSalesFilter.Location = new Point(466, 36);
            comboBoxSalesFilter.Name = "comboBoxSalesFilter";
            comboBoxSalesFilter.Size = new Size(102, 23);
            comboBoxSalesFilter.TabIndex = 18;
            comboBoxSalesFilter.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 9.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(448, 18);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 19;
            label3.Text = "Choose Quick Filter:";
            // 
            // dtpFromSales
            // 
            dtpFromSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpFromSales.CalendarMonthBackground = Color.White;
            dtpFromSales.CalendarTrailingForeColor = SystemColors.AppWorkspace;
            dtpFromSales.Font = new Font("Roboto", 9.75F);
            dtpFromSales.Location = new Point(6, 36);
            dtpFromSales.Name = "dtpFromSales";
            dtpFromSales.Size = new Size(144, 23);
            dtpFromSales.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(11, 19);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 23;
            label6.Text = "From:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 9.75F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(156, 18);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 25;
            label7.Text = "To:";
            // 
            // dtpToSales
            // 
            dtpToSales.CalendarFont = new Font("Segoe UI", 8.25F);
            dtpToSales.CalendarTitleBackColor = SystemColors.MenuHighlight;
            dtpToSales.Font = new Font("Roboto", 9.75F);
            dtpToSales.Location = new Point(156, 36);
            dtpToSales.Name = "dtpToSales";
            dtpToSales.Size = new Size(149, 23);
            dtpToSales.TabIndex = 24;
            // 
            // btnFilterDateSales
            // 
            btnFilterDateSales.BackColor = Color.FromArgb(33, 39, 56);
            btnFilterDateSales.FlatStyle = FlatStyle.Popup;
            btnFilterDateSales.Font = new Font("Roboto", 9.75F);
            btnFilterDateSales.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilterDateSales.Location = new Point(311, 36);
            btnFilterDateSales.Name = "btnFilterDateSales";
            btnFilterDateSales.Size = new Size(74, 24);
            btnFilterDateSales.TabIndex = 27;
            btnFilterDateSales.Text = "Filter";
            btnFilterDateSales.UseVisualStyleBackColor = false;
            btnFilterDateSales.Click += button2_Click;
            // 
            // gbSales
            // 
            gbSales.BackColor = Color.FromArgb(87, 196, 229);
            gbSales.Controls.Add(lblGrossSales);
            gbSales.Controls.Add(lblNetSales);
            gbSales.Controls.Add(label8);
            gbSales.Controls.Add(btnClearFilters);
            gbSales.Controls.Add(label4);
            gbSales.Controls.Add(label6);
            gbSales.Controls.Add(comboBoxSalesFilter);
            gbSales.Controls.Add(label3);
            gbSales.Controls.Add(dtpFromSales);
            gbSales.Controls.Add(dtpToSales);
            gbSales.Controls.Add(label7);
            gbSales.Controls.Add(btnFilterDateSales);
            gbSales.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSales.ForeColor = Color.Black;
            gbSales.Location = new Point(585, 41);
            gbSales.Name = "gbSales";
            gbSales.Size = new Size(574, 420);
            gbSales.TabIndex = 17;
            gbSales.TabStop = false;
            gbSales.Text = "Sales";
            gbSales.Enter += groupBox2_Enter;
            // 
            // lblGrossSales
            // 
            lblGrossSales.AutoSize = true;
            lblGrossSales.Font = new Font("Roboto SemiBold", 26.25F, FontStyle.Bold);
            lblGrossSales.ForeColor = Color.Black;
            lblGrossSales.Location = new Point(324, 128);
            lblGrossSales.Name = "lblGrossSales";
            lblGrossSales.Size = new Size(88, 42);
            lblGrossSales.TabIndex = 4;
            lblGrossSales.Text = "0.00";
            // 
            // lblNetSales
            // 
            lblNetSales.AutoSize = true;
            lblNetSales.Font = new Font("Roboto SemiBold", 26.25F, FontStyle.Bold);
            lblNetSales.ForeColor = Color.Black;
            lblNetSales.Location = new Point(324, 71);
            lblNetSales.Name = "lblNetSales";
            lblNetSales.Size = new Size(88, 42);
            lblNetSales.TabIndex = 3;
            lblNetSales.Text = "0.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto SemiBold", 26.25F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 128);
            label8.Name = "label8";
            label8.Size = new Size(216, 42);
            label8.TabIndex = 1;
            label8.Text = "Gross Sales:";
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(209, 214, 70);
            btnClearFilters.FlatStyle = FlatStyle.Popup;
            btnClearFilters.Font = new Font("Roboto", 9.75F);
            btnClearFilters.ForeColor = Color.Black;
            btnClearFilters.Location = new Point(391, 36);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(69, 24);
            btnClearFilters.TabIndex = 177;
            btnClearFilters.Text = "Clear ";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto SemiBold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 71);
            label4.Name = "label4";
            label4.Size = new Size(179, 42);
            label4.TabIndex = 0;
            label4.Text = "Net Sales:";
            // 
            // timeReloadData
            // 
            timeReloadData.Interval = 5000;
            timeReloadData.Tick += timeReloadData_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Roboto", 11.25F);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(206, 42);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(129, 18);
            lblTime.TabIndex = 160;
            lblTime.Text = "hh:mm:ss AM/PM";
            lblTime.Click += lblTime_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Roboto", 11.25F);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(206, 24);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(102, 18);
            lblDate.TabIndex = 159;
            lblDate.Text = "MM/DD/YYYY";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 112, 104);
            button2.Dock = DockStyle.Bottom;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 672);
            button2.Name = "button2";
            button2.Size = new Size(197, 47);
            button2.TabIndex = 162;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // btnPos
            // 
            btnPos.BackColor = Color.FromArgb(237, 242, 239);
            btnPos.BackgroundImageLayout = ImageLayout.Stretch;
            btnPos.FlatStyle = FlatStyle.Flat;
            btnPos.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnPos.Location = new Point(1, 93);
            btnPos.Name = "btnPos";
            btnPos.Size = new Size(200, 47);
            btnPos.TabIndex = 4;
            btnPos.Text = "POINT OF SALE";
            btnPos.UseVisualStyleBackColor = false;
            btnPos.Click += button1_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.FromArgb(237, 242, 239);
            btnCategories.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.Location = new Point(1, 1);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(200, 47);
            btnCategories.TabIndex = 164;
            btnCategories.Text = "CATEGORIES";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(237, 242, 239);
            btnProducts.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnProducts.Location = new Point(1, 139);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 47);
            btnProducts.TabIndex = 165;
            btnProducts.Tag = "";
            btnProducts.Text = "PRODUCTS";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.FromArgb(237, 242, 239);
            btnSuppliers.BackgroundImageLayout = ImageLayout.Stretch;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnSuppliers.Location = new Point(1, 185);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(200, 47);
            btnSuppliers.TabIndex = 166;
            btnSuppliers.Text = "SUPPLIERS";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.FromArgb(237, 242, 239);
            btnTransactions.BackgroundImageLayout = ImageLayout.Stretch;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnTransactions.Location = new Point(1, 231);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(200, 47);
            btnTransactions.TabIndex = 167;
            btnTransactions.Text = "TRANSACTIONS";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(237, 242, 239);
            btnUsers.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnUsers.Location = new Point(1, 323);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(200, 47);
            btnUsers.TabIndex = 168;
            btnUsers.Text = "USERS";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnUac
            // 
            btnUac.BackgroundImageLayout = ImageLayout.Stretch;
            btnUac.FlatStyle = FlatStyle.Flat;
            btnUac.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            btnUac.Location = new Point(1, 277);
            btnUac.Name = "btnUac";
            btnUac.Size = new Size(200, 47);
            btnUac.TabIndex = 169;
            btnUac.Text = "USER ACCESS CONTROL";
            btnUac.UseVisualStyleBackColor = true;
            btnUac.Click += btnUac_Click;
            // 
            // timerDateandTime
            // 
            timerDateandTime.Enabled = true;
            timerDateandTime.Interval = 1000;
            timerDateandTime.Tick += timer1_Tick_1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.WhiteSmoke;
            lblFullName.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(8, 9);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 183;
            lblFullName.Text = "Full Name";
            // 
            // gbLowStocks
            // 
            gbLowStocks.BackColor = Color.FromArgb(87, 196, 229);
            gbLowStocks.Controls.Add(dtgvLowStocks);
            gbLowStocks.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            gbLowStocks.ForeColor = Color.Black;
            gbLowStocks.Location = new Point(8, 467);
            gbLowStocks.Name = "gbLowStocks";
            gbLowStocks.Size = new Size(574, 240);
            gbLowStocks.TabIndex = 185;
            gbLowStocks.TabStop = false;
            gbLowStocks.Text = "Low Stock Products";
            gbLowStocks.Enter += gbLowStocks_Enter;
            // 
            // dtgvLowStocks
            // 
            dtgvLowStocks.AllowUserToAddRows = false;
            dtgvLowStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dtgvLowStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dtgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLowStocks.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgvLowStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLowStocks.Columns.AddRange(new DataGridViewColumn[] { product_name2, quantity, supplier });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Window;
            dataGridViewCellStyle7.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dtgvLowStocks.DefaultCellStyle = dataGridViewCellStyle7;
            dtgvLowStocks.Location = new Point(6, 22);
            dtgvLowStocks.Name = "dtgvLowStocks";
            dtgvLowStocks.ReadOnly = true;
            dtgvLowStocks.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dtgvLowStocks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dtgvLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLowStocks.Size = new Size(553, 212);
            dtgvLowStocks.TabIndex = 11;
            // 
            // product_name2
            // 
            product_name2.DataPropertyName = "product_name";
            product_name2.HeaderText = "Product";
            product_name2.Name = "product_name2";
            product_name2.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "quantity";
            quantity.HeaderText = "Remaining Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // supplier
            // 
            supplier.DataPropertyName = "supplier";
            supplier.HeaderText = "Supplier";
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(237, 242, 239);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            button1.Location = new Point(1, 47);
            button1.Name = "button1";
            button1.Size = new Size(200, 47);
            button1.TabIndex = 188;
            button1.Text = "INVENTORY";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
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
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(237, 242, 239);
            label5.Location = new Point(62, 12);
            label5.Name = "label5";
            label5.Size = new Size(127, 42);
            label5.TabIndex = 191;
            label5.Text = "ATPOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(menuStrip);
            panel1.Controls.Add(lblDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1378, 69);
            panel1.TabIndex = 192;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 242, 239);
            panel3.Controls.Add(lblFullName);
            panel3.Controls.Add(gbLowStocks);
            panel3.Controls.Add(gbTop5Sellings);
            panel3.Controls.Add(gbSales);
            panel3.Location = new Point(199, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1367, 788);
            panel3.TabIndex = 195;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 242, 239);
            panel2.Controls.Add(btnUsers);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnUac);
            panel2.Controls.Add(btnTransactions);
            panel2.Controls.Add(btnCategories);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnSuppliers);
            panel2.Controls.Add(btnPos);
            panel2.Controls.Add(btnProducts);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 719);
            panel2.TabIndex = 189;
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1378, 788);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MDIParent1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Super Admin";
            TransparencyKey = Color.White;
            Load += SuperAdminForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTop5SellingProducts).EndInit();
            gbTop5Sellings.ResumeLayout(false);
            gbTop5Sellings.PerformLayout();
            gbSales.ResumeLayout(false);
            gbSales.PerformLayout();
            gbLowStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvLowStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private DataGridView dtgvTop5SellingProducts;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn total_quantity_sold;
        private DataGridViewTextBoxColumn total_sales;
        private Label label2;
        private DateTimePicker dtpTo;
        private Label label1;
        private DateTimePicker dtpFrom;
        private GroupBox gbTop5Sellings;
        private Button btnFilter;
        private ComboBox comboBoxSalesFilter;
        private Label label3;
        private DateTimePicker dtpFromSales;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpToSales;
        private Button btnFilterDateSales;
        private GroupBox gbSales;
        private Label lblGrossSales;
        private Label lblNetSales;
        private Label label8;
        private Label label4;
        private System.Windows.Forms.Timer timeReloadData;
        private Label lblTime;
        private Label lblDate;
        private Button button2;
        private Button btnPos;
        private Button btnCategories;
        private Button btnProducts;
        private Button btnSuppliers;
        private Button btnTransactions;
        private Button btnUsers;
        private Button btnUac;
        private Button btnClearFilters;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerDateandTime;
        private Label lblFullName;
        private Button btnExportTop5Selling;
        private GroupBox gbLowStocks;
        private DataGridView dtgvLowStocks;
        private DataGridViewTextBoxColumn product_name2;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn supplier;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem activityLogsToolStripMenuItem;
        private ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private Button button1;
        private PictureBox pictureBox4;
        private Label label5;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}



