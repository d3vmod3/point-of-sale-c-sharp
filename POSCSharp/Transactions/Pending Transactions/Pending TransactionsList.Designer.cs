namespace PAKOPointOfSale.Transactions.Parked_Transactions
{
    partial class ParkTransactionsList
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkTransactionsList));
            dtgvParkedTransactions = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            park_number = new DataGridViewTextBoxColumn();
            vat_amount = new DataGridViewTextBoxColumn();
            vatable_sales = new DataGridViewTextBoxColumn();
            vat_exempt = new DataGridViewTextBoxColumn();
            sub_total = new DataGridViewTextBoxColumn();
            grandtotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentmethodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashreceivedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashchangeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            remarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactiontypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            settle = new DataGridViewButtonColumn();
            salesinvoiceitemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cancel = new DataGridViewButtonColumn();
            transactionBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            label1 = new Label();
            btnClose = new Button();
            btnExport = new Button();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvParkedTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dtgvParkedTransactions
            // 
            dtgvParkedTransactions.AllowUserToAddRows = false;
            dtgvParkedTransactions.AllowUserToDeleteRows = false;
            dtgvParkedTransactions.AutoGenerateColumns = false;
            dtgvParkedTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvParkedTransactions.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgvParkedTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgvParkedTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvParkedTransactions.Columns.AddRange(new DataGridViewColumn[] { id, park_number, vat_amount, vatable_sales, vat_exempt, sub_total, grandtotalDataGridViewTextBoxColumn, paymentmethodDataGridViewTextBoxColumn, cashreceivedDataGridViewTextBoxColumn, cashchangeDataGridViewTextBoxColumn, status, remarksDataGridViewTextBoxColumn, transactiontypeDataGridViewTextBoxColumn, created_at, settle, salesinvoiceitemsDataGridViewTextBoxColumn, cancel });
            dtgvParkedTransactions.DataSource = transactionBindingSource;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgvParkedTransactions.DefaultCellStyle = dataGridViewCellStyle5;
            dtgvParkedTransactions.Location = new Point(12, 111);
            dtgvParkedTransactions.Name = "dtgvParkedTransactions";
            dtgvParkedTransactions.ReadOnly = true;
            dtgvParkedTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dtgvParkedTransactions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dtgvParkedTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvParkedTransactions.Size = new Size(978, 368);
            dtgvParkedTransactions.TabIndex = 0;
            dtgvParkedTransactions.CellContentClick += dtgvParkedTransactions_CellContentClick;
            dtgvParkedTransactions.CellFormatting += dtgvParkedTransactions_CellFormatting;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // park_number
            // 
            park_number.DataPropertyName = "park_number";
            park_number.HeaderText = "Pending Number";
            park_number.MinimumWidth = 150;
            park_number.Name = "park_number";
            park_number.ReadOnly = true;
            // 
            // vat_amount
            // 
            vat_amount.DataPropertyName = "vat_amount";
            vat_amount.HeaderText = "vat_amount";
            vat_amount.Name = "vat_amount";
            vat_amount.ReadOnly = true;
            vat_amount.Visible = false;
            // 
            // vatable_sales
            // 
            vatable_sales.DataPropertyName = "vatable_sales";
            vatable_sales.HeaderText = "vatable_sales";
            vatable_sales.Name = "vatable_sales";
            vatable_sales.ReadOnly = true;
            vatable_sales.Visible = false;
            // 
            // vat_exempt
            // 
            vat_exempt.DataPropertyName = "vat_exempt";
            vat_exempt.HeaderText = "vat_exempt";
            vat_exempt.Name = "vat_exempt";
            vat_exempt.ReadOnly = true;
            vat_exempt.Visible = false;
            // 
            // sub_total
            // 
            sub_total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sub_total.DataPropertyName = "sub_total";
            sub_total.HeaderText = "Sub Total";
            sub_total.MinimumWidth = 90;
            sub_total.Name = "sub_total";
            sub_total.ReadOnly = true;
            sub_total.Width = 90;
            // 
            // grandtotalDataGridViewTextBoxColumn
            // 
            grandtotalDataGridViewTextBoxColumn.DataPropertyName = "grand_total";
            grandtotalDataGridViewTextBoxColumn.HeaderText = "Total";
            grandtotalDataGridViewTextBoxColumn.Name = "grandtotalDataGridViewTextBoxColumn";
            grandtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentmethodDataGridViewTextBoxColumn
            // 
            paymentmethodDataGridViewTextBoxColumn.DataPropertyName = "payment_method";
            paymentmethodDataGridViewTextBoxColumn.HeaderText = "payment_method";
            paymentmethodDataGridViewTextBoxColumn.Name = "paymentmethodDataGridViewTextBoxColumn";
            paymentmethodDataGridViewTextBoxColumn.ReadOnly = true;
            paymentmethodDataGridViewTextBoxColumn.Visible = false;
            // 
            // cashreceivedDataGridViewTextBoxColumn
            // 
            cashreceivedDataGridViewTextBoxColumn.DataPropertyName = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.HeaderText = "cash_received";
            cashreceivedDataGridViewTextBoxColumn.Name = "cashreceivedDataGridViewTextBoxColumn";
            cashreceivedDataGridViewTextBoxColumn.ReadOnly = true;
            cashreceivedDataGridViewTextBoxColumn.Visible = false;
            // 
            // cashchangeDataGridViewTextBoxColumn
            // 
            cashchangeDataGridViewTextBoxColumn.DataPropertyName = "cash_change";
            cashchangeDataGridViewTextBoxColumn.HeaderText = "cash_change";
            cashchangeDataGridViewTextBoxColumn.Name = "cashchangeDataGridViewTextBoxColumn";
            cashchangeDataGridViewTextBoxColumn.ReadOnly = true;
            cashchangeDataGridViewTextBoxColumn.Visible = false;
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            remarksDataGridViewTextBoxColumn.DataPropertyName = "remarks";
            remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactiontypeDataGridViewTextBoxColumn
            // 
            transactiontypeDataGridViewTextBoxColumn.DataPropertyName = "transaction_type";
            transactiontypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type";
            transactiontypeDataGridViewTextBoxColumn.MinimumWidth = 150;
            transactiontypeDataGridViewTextBoxColumn.Name = "transactiontypeDataGridViewTextBoxColumn";
            transactiontypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Pending";
            created_at.MinimumWidth = 120;
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // settle
            // 
            settle.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            settle.DataPropertyName = "settle";
            settle.HeaderText = "";
            settle.MinimumWidth = 100;
            settle.Name = "settle";
            settle.ReadOnly = true;
            settle.Text = "Settle";
            settle.UseColumnTextForButtonValue = true;
            // 
            // salesinvoiceitemsDataGridViewTextBoxColumn
            // 
            salesinvoiceitemsDataGridViewTextBoxColumn.DataPropertyName = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.HeaderText = "sales_invoice_items";
            salesinvoiceitemsDataGridViewTextBoxColumn.Name = "salesinvoiceitemsDataGridViewTextBoxColumn";
            salesinvoiceitemsDataGridViewTextBoxColumn.ReadOnly = true;
            salesinvoiceitemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // cancel
            // 
            cancel.DataPropertyName = "cancel";
            cancel.HeaderText = "";
            cancel.MinimumWidth = 100;
            cancel.Name = "cancel";
            cancel.ReadOnly = true;
            cancel.Resizable = DataGridViewTriState.True;
            cancel.SortMode = DataGridViewColumnSortMode.Automatic;
            cancel.Text = "Cancel";
            cancel.UseColumnTextForButtonValue = true;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(Transaction);
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Roboto", 14.25F);
            txtSearch.Location = new Point(163, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(629, 30);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(7, 83);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 2;
            label1.Text = "Search Pending Number:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Roboto", 9.75F);
            btnClose.ForeColor = Color.FromArgb(237, 242, 239);
            btnClose.Location = new Point(906, 78);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(84, 24);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(87, 196, 229);
            btnExport.FlatStyle = FlatStyle.Popup;
            btnExport.Font = new Font("Roboto", 9.75F);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(798, 78);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(102, 25);
            btnExport.TabIndex = 154;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
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
            panel1.Size = new Size(1000, 69);
            panel1.TabIndex = 197;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(316, 12);
            label2.Name = "label2";
            label2.Size = new Size(380, 42);
            label2.TabIndex = 194;
            label2.Text = "Pending Sales Invoices";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(800, 0);
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
            // ParkTransactionsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1000, 480);
            Controls.Add(panel1);
            Controls.Add(btnExport);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dtgvParkedTransactions);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParkTransactionsList";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pending Sales Invoices";
            Load += ParkTransactionsList_Load_1;
            KeyDown += ParkTransactionsList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dtgvParkedTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvParkedTransactions;
        private BindingSource transactionBindingSource;
        private TextBox txtSearch;
        private Label label1;
        private Button btnClose;
        private Button btnExport;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn park_number;
        private DataGridViewTextBoxColumn vat_amount;
        private DataGridViewTextBoxColumn vatable_sales;
        private DataGridViewTextBoxColumn vat_exempt;
        private DataGridViewTextBoxColumn sub_total;
        private DataGridViewTextBoxColumn grandtotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentmethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashreceivedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashchangeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactiontypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewButtonColumn settle;
        private DataGridViewTextBoxColumn salesinvoiceitemsDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn cancel;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}