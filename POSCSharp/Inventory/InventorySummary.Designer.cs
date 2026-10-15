namespace PAKOPointOfSale.Inventory
{
    partial class InventorySummary
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventorySummary));
            dgvRecentlyAdded = new DataGridView();
            product_name = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            txSearchQuery = new TextBox();
            label4 = new Label();
            btnSubmit = new Button();
            dgvLowStocks = new DataGridView();
            product_name2 = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            dgvOutOfStocks = new DataGridView();
            product_name3 = new DataGridViewTextBoxColumn();
            supplier3 = new DataGridViewTextBoxColumn();
            cmbShowItemsRecentyAdded = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbShowItemsLowStocks = new ComboBox();
            label7 = new Label();
            cmbShowItemsOutOfStocks = new ComboBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            grbxRecentlyAdded = new GroupBox();
            grpbxLowStocks = new GroupBox();
            grpbxOutOfStock = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvRecentlyAdded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutOfStocks).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            grbxRecentlyAdded.SuspendLayout();
            grpbxLowStocks.SuspendLayout();
            grpbxOutOfStock.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRecentlyAdded
            // 
            dgvRecentlyAdded.AllowUserToAddRows = false;
            dgvRecentlyAdded.AllowUserToDeleteRows = false;
            dgvRecentlyAdded.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentlyAdded.BackgroundColor = Color.FromArgb(237, 242, 239);
            dgvRecentlyAdded.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentlyAdded.Columns.AddRange(new DataGridViewColumn[] { product_name, created_at });
            dgvRecentlyAdded.Dock = DockStyle.Bottom;
            dgvRecentlyAdded.Location = new Point(3, 65);
            dgvRecentlyAdded.Name = "dgvRecentlyAdded";
            dgvRecentlyAdded.ReadOnly = true;
            dgvRecentlyAdded.RowHeadersVisible = false;
            dgvRecentlyAdded.Size = new Size(425, 538);
            dgvRecentlyAdded.TabIndex = 123;
            // 
            // product_name
            // 
            product_name.DataPropertyName = "product_name";
            product_name.HeaderText = "Product";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Date Created";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // txSearchQuery
            // 
            txSearchQuery.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txSearchQuery.Location = new Point(109, 3);
            txSearchQuery.MaxLength = 50;
            txSearchQuery.Name = "txSearchQuery";
            txSearchQuery.Size = new Size(232, 26);
            txSearchQuery.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 7;
            label4.Text = "Search Product:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(33, 39, 56);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Roboto", 9.75F);
            btnSubmit.ForeColor = Color.FromArgb(237, 242, 239);
            btnSubmit.Location = new Point(347, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 26);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dgvLowStocks
            // 
            dgvLowStocks.AllowUserToAddRows = false;
            dgvLowStocks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvLowStocks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvLowStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLowStocks.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLowStocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLowStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStocks.Columns.AddRange(new DataGridViewColumn[] { product_name2, quantity, supplier });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLowStocks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLowStocks.Dock = DockStyle.Bottom;
            dgvLowStocks.Location = new Point(3, 65);
            dgvLowStocks.Name = "dgvLowStocks";
            dgvLowStocks.ReadOnly = true;
            dgvLowStocks.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dgvLowStocks.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvLowStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLowStocks.Size = new Size(425, 538);
            dgvLowStocks.TabIndex = 12;
            dgvLowStocks.CellContentClick += dgvLowStocks_CellContentClick;
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
            // dgvOutOfStocks
            // 
            dgvOutOfStocks.AllowUserToAddRows = false;
            dgvOutOfStocks.AllowUserToDeleteRows = false;
            dgvOutOfStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOutOfStocks.BackgroundColor = Color.FromArgb(237, 242, 239);
            dgvOutOfStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutOfStocks.Columns.AddRange(new DataGridViewColumn[] { product_name3, supplier3 });
            dgvOutOfStocks.Dock = DockStyle.Bottom;
            dgvOutOfStocks.Location = new Point(3, 65);
            dgvOutOfStocks.Name = "dgvOutOfStocks";
            dgvOutOfStocks.ReadOnly = true;
            dgvOutOfStocks.RowHeadersVisible = false;
            dgvOutOfStocks.Size = new Size(426, 538);
            dgvOutOfStocks.TabIndex = 13;
            // 
            // product_name3
            // 
            product_name3.DataPropertyName = "product_name";
            product_name3.HeaderText = "Product";
            product_name3.Name = "product_name3";
            product_name3.ReadOnly = true;
            // 
            // supplier3
            // 
            supplier3.DataPropertyName = "supplier";
            supplier3.HeaderText = "Supplier";
            supplier3.Name = "supplier3";
            supplier3.ReadOnly = true;
            // 
            // cmbShowItemsRecentyAdded
            // 
            cmbShowItemsRecentyAdded.FormattingEnabled = true;
            cmbShowItemsRecentyAdded.Items.AddRange(new object[] { "25", "50", "100", "All" });
            cmbShowItemsRecentyAdded.Location = new Point(86, 18);
            cmbShowItemsRecentyAdded.Name = "cmbShowItemsRecentyAdded";
            cmbShowItemsRecentyAdded.Size = new Size(339, 23);
            cmbShowItemsRecentyAdded.TabIndex = 14;
            cmbShowItemsRecentyAdded.SelectedIndexChanged += cmbShowItemsRecentyAdded_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 15;
            label5.Text = "Show Items:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 17;
            label6.Text = "Show Items:";
            // 
            // cmbShowItemsLowStocks
            // 
            cmbShowItemsLowStocks.FormattingEnabled = true;
            cmbShowItemsLowStocks.Items.AddRange(new object[] { "25", "50", "100", "All" });
            cmbShowItemsLowStocks.Location = new Point(87, 16);
            cmbShowItemsLowStocks.Name = "cmbShowItemsLowStocks";
            cmbShowItemsLowStocks.Size = new Size(308, 23);
            cmbShowItemsLowStocks.TabIndex = 16;
            cmbShowItemsLowStocks.SelectedIndexChanged += cmbShowItemsLowStocks_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 19;
            label7.Text = "Show Items:";
            // 
            // cmbShowItemsOutOfStocks
            // 
            cmbShowItemsOutOfStocks.FormattingEnabled = true;
            cmbShowItemsOutOfStocks.Items.AddRange(new object[] { "0", "25", "50", "100", "All" });
            cmbShowItemsOutOfStocks.Location = new Point(88, 16);
            cmbShowItemsOutOfStocks.Name = "cmbShowItemsOutOfStocks";
            cmbShowItemsOutOfStocks.Size = new Size(309, 23);
            cmbShowItemsOutOfStocks.TabIndex = 18;
            cmbShowItemsOutOfStocks.SelectedIndexChanged += cmbShowItemsOutOfStocks_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 39, 56);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 69);
            panel1.TabIndex = 193;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1112, 0);
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
            // grbxRecentlyAdded
            // 
            grbxRecentlyAdded.Controls.Add(label5);
            grbxRecentlyAdded.Controls.Add(cmbShowItemsRecentyAdded);
            grbxRecentlyAdded.Controls.Add(dgvRecentlyAdded);
            grbxRecentlyAdded.Dock = DockStyle.Fill;
            grbxRecentlyAdded.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            grbxRecentlyAdded.Location = new Point(3, 38);
            grbxRecentlyAdded.Name = "grbxRecentlyAdded";
            grbxRecentlyAdded.Size = new Size(431, 606);
            grbxRecentlyAdded.TabIndex = 194;
            grbxRecentlyAdded.TabStop = false;
            grbxRecentlyAdded.Text = "Recently Added";
            // 
            // grpbxLowStocks
            // 
            grpbxLowStocks.Controls.Add(cmbShowItemsLowStocks);
            grpbxLowStocks.Controls.Add(label6);
            grpbxLowStocks.Controls.Add(dgvLowStocks);
            grpbxLowStocks.Dock = DockStyle.Fill;
            grpbxLowStocks.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            grpbxLowStocks.Location = new Point(440, 38);
            grpbxLowStocks.Name = "grpbxLowStocks";
            grpbxLowStocks.Size = new Size(431, 606);
            grpbxLowStocks.TabIndex = 195;
            grpbxLowStocks.TabStop = false;
            grpbxLowStocks.Text = "Low Stocks";
            // 
            // grpbxOutOfStock
            // 
            grpbxOutOfStock.Controls.Add(label7);
            grpbxOutOfStock.Controls.Add(cmbShowItemsOutOfStocks);
            grpbxOutOfStock.Controls.Add(dgvOutOfStocks);
            grpbxOutOfStock.Dock = DockStyle.Fill;
            grpbxOutOfStock.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            grpbxOutOfStock.Location = new Point(877, 38);
            grpbxOutOfStock.Name = "grpbxOutOfStock";
            grpbxOutOfStock.Size = new Size(432, 606);
            grpbxOutOfStock.TabIndex = 196;
            grpbxOutOfStock.TabStop = false;
            grpbxOutOfStock.Text = "Out of Stock";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(grbxRecentlyAdded, 0, 1);
            tableLayoutPanel2.Controls.Add(grpbxLowStocks, 1, 1);
            tableLayoutPanel2.Controls.Add(grpbxOutOfStock, 2, 1);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1312, 647);
            tableLayoutPanel2.TabIndex = 197;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(txSearchQuery);
            flowLayoutPanel1.Controls.Add(btnSubmit);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(440, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(431, 29);
            flowLayoutPanel1.TabIndex = 197;
            // 
            // InventorySummary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1312, 716);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InventorySummary";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Summary";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecentlyAdded).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLowStocks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutOfStocks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            grbxRecentlyAdded.ResumeLayout(false);
            grbxRecentlyAdded.PerformLayout();
            grpbxLowStocks.ResumeLayout(false);
            grpbxLowStocks.PerformLayout();
            grpbxOutOfStock.ResumeLayout(false);
            grpbxOutOfStock.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRecentlyAdded;
        private TextBox txSearchQuery;
        private Label label4;
        private Button btnSubmit;
        private DataGridView dgvLowStocks;
        private DataGridViewTextBoxColumn product_name2;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn created_at;
        private DataGridView dgvOutOfStocks;
        private DataGridViewTextBoxColumn product_name3;
        private DataGridViewTextBoxColumn supplier3;
        private ComboBox cmbShowItemsRecentyAdded;
        private Label label5;
        private Label label6;
        private ComboBox cmbShowItemsLowStocks;
        private Label label7;
        private ComboBox cmbShowItemsOutOfStocks;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
        private GroupBox grbxRecentlyAdded;
        private GroupBox grpbxLowStocks;
        private GroupBox grpbxOutOfStock;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}