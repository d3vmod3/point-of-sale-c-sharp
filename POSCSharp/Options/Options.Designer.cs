namespace PAKOPointOfSale.Options
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            lstOptions = new ListBox();
            grpBoxActivityLogs = new GroupBox();
            dgvActivityLogs = new DataGridView();
            timestamp = new DataGridViewTextBoxColumn();
            user = new DataGridViewTextBoxColumn();
            module = new DataGridViewTextBoxColumn();
            action = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            payload = new DataGridViewTextBoxColumn();
            btnExport = new Button();
            btnFilter = new Button();
            label4 = new Label();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            dtpFrom = new DateTimePicker();
            grpBoxBackupDatabase = new GroupBox();
            btnBackup = new Button();
            btnChoosePath = new Button();
            btnSaveDbaseBackupLocation = new Button();
            label1 = new Label();
            txtDbaseLocation = new TextBox();
            lblDescription = new Label();
            folderBrowserDialogDbaseBackupLocation = new FolderBrowserDialog();
            addActivityLogsTableBindingSource = new BindingSource(components);
            addActivityLogsTableBindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            grpBoxActivityLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).BeginInit();
            grpBoxBackupDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lstOptions
            // 
            lstOptions.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOptions.FormattingEnabled = true;
            lstOptions.ItemHeight = 18;
            lstOptions.Items.AddRange(new object[] { "Activity Logs", "Backup Database" });
            lstOptions.Location = new Point(3, 75);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(129, 418);
            lstOptions.TabIndex = 0;
            lstOptions.SelectedIndexChanged += lstOptions_SelectedIndexChanged;
            // 
            // grpBoxActivityLogs
            // 
            grpBoxActivityLogs.Controls.Add(dgvActivityLogs);
            grpBoxActivityLogs.Controls.Add(btnExport);
            grpBoxActivityLogs.Controls.Add(btnFilter);
            grpBoxActivityLogs.Controls.Add(label4);
            grpBoxActivityLogs.Controls.Add(dtpTo);
            grpBoxActivityLogs.Controls.Add(label3);
            grpBoxActivityLogs.Controls.Add(dtpFrom);
            grpBoxActivityLogs.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            grpBoxActivityLogs.Location = new Point(138, 75);
            grpBoxActivityLogs.Name = "grpBoxActivityLogs";
            grpBoxActivityLogs.Size = new Size(1220, 725);
            grpBoxActivityLogs.TabIndex = 0;
            grpBoxActivityLogs.TabStop = false;
            grpBoxActivityLogs.Text = "Activity Logs";
            grpBoxActivityLogs.Enter += grpBoxActivityLogs_Enter;
            // 
            // dgvActivityLogs
            // 
            dgvActivityLogs.AllowUserToAddRows = false;
            dgvActivityLogs.AllowUserToDeleteRows = false;
            dgvActivityLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActivityLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivityLogs.Columns.AddRange(new DataGridViewColumn[] { timestamp, user, module, action, description, payload });
            dgvActivityLogs.Location = new Point(6, 61);
            dgvActivityLogs.Name = "dgvActivityLogs";
            dgvActivityLogs.ReadOnly = true;
            dgvActivityLogs.RowHeadersVisible = false;
            dgvActivityLogs.Size = new Size(1214, 658);
            dgvActivityLogs.TabIndex = 0;
            dgvActivityLogs.CellContentClick += dgvActivityLogs_CellContentClick;
            // 
            // timestamp
            // 
            timestamp.DataPropertyName = "timestamp";
            timestamp.HeaderText = "Time Stamp";
            timestamp.Name = "timestamp";
            timestamp.ReadOnly = true;
            // 
            // user
            // 
            user.DataPropertyName = "user";
            user.HeaderText = "User";
            user.Name = "user";
            user.ReadOnly = true;
            // 
            // module
            // 
            module.DataPropertyName = "module";
            module.HeaderText = "Module";
            module.Name = "module";
            module.ReadOnly = true;
            // 
            // action
            // 
            action.DataPropertyName = "action";
            action.HeaderText = "Action";
            action.Name = "action";
            action.ReadOnly = true;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // payload
            // 
            payload.DataPropertyName = "payload";
            payload.HeaderText = "Payload";
            payload.Name = "payload";
            payload.ReadOnly = true;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(209, 214, 70);
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Roboto", 9.75F);
            btnExport.Location = new Point(519, 32);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 160;
            btnExport.Text = "Export CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(33, 39, 56);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Roboto", 9.75F);
            btnFilter.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilter.Location = new Point(438, 32);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 159;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 9.75F);
            label4.Location = new Point(221, 15);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 158;
            label4.Text = "Date To:";
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(220, 33);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(212, 23);
            dtpTo.TabIndex = 157;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9.75F);
            label3.Location = new Point(6, 15);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 156;
            label3.Text = "Date From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(6, 33);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(208, 23);
            dtpFrom.TabIndex = 155;
            // 
            // grpBoxBackupDatabase
            // 
            grpBoxBackupDatabase.Controls.Add(btnBackup);
            grpBoxBackupDatabase.Controls.Add(btnChoosePath);
            grpBoxBackupDatabase.Controls.Add(btnSaveDbaseBackupLocation);
            grpBoxBackupDatabase.Controls.Add(label1);
            grpBoxBackupDatabase.Controls.Add(txtDbaseLocation);
            grpBoxBackupDatabase.Controls.Add(lblDescription);
            grpBoxBackupDatabase.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            grpBoxBackupDatabase.Location = new Point(138, 75);
            grpBoxBackupDatabase.Name = "grpBoxBackupDatabase";
            grpBoxBackupDatabase.Size = new Size(520, 220);
            grpBoxBackupDatabase.TabIndex = 1;
            grpBoxBackupDatabase.TabStop = false;
            grpBoxBackupDatabase.Text = "Backup Database";
            grpBoxBackupDatabase.Enter += grpBoxBackupDatabase_Enter;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(209, 214, 70);
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackup.Location = new Point(275, 173);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(101, 23);
            btnBackup.TabIndex = 5;
            btnBackup.Text = "Backup Now";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // btnChoosePath
            // 
            btnChoosePath.BackColor = Color.FromArgb(33, 39, 56);
            btnChoosePath.FlatStyle = FlatStyle.Flat;
            btnChoosePath.Font = new Font("Roboto", 9.75F);
            btnChoosePath.ForeColor = Color.FromArgb(237, 242, 239);
            btnChoosePath.Location = new Point(328, 26);
            btnChoosePath.Name = "btnChoosePath";
            btnChoosePath.Size = new Size(75, 23);
            btnChoosePath.TabIndex = 4;
            btnChoosePath.Text = "Select Folder";
            btnChoosePath.UseVisualStyleBackColor = false;
            btnChoosePath.Click += btnChoosePath_Click;
            // 
            // btnSaveDbaseBackupLocation
            // 
            btnSaveDbaseBackupLocation.BackColor = Color.FromArgb(33, 39, 56);
            btnSaveDbaseBackupLocation.FlatStyle = FlatStyle.Flat;
            btnSaveDbaseBackupLocation.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveDbaseBackupLocation.ForeColor = Color.FromArgb(237, 242, 239);
            btnSaveDbaseBackupLocation.Location = new Point(141, 173);
            btnSaveDbaseBackupLocation.Name = "btnSaveDbaseBackupLocation";
            btnSaveDbaseBackupLocation.Size = new Size(101, 23);
            btnSaveDbaseBackupLocation.TabIndex = 3;
            btnSaveDbaseBackupLocation.Text = "Save Changes";
            btnSaveDbaseBackupLocation.UseVisualStyleBackColor = false;
            btnSaveDbaseBackupLocation.Click += btnSaveDbaseBackupLocation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 137);
            label1.Name = "label1";
            label1.Size = new Size(513, 15);
            label1.TabIndex = 2;
            label1.Text = "Note: If the textbox is empty, the file will be saved in the same location as the application.";
            // 
            // txtDbaseLocation
            // 
            txtDbaseLocation.Font = new Font("Roboto", 9.75F);
            txtDbaseLocation.Location = new Point(13, 55);
            txtDbaseLocation.Multiline = true;
            txtDbaseLocation.Name = "txtDbaseLocation";
            txtDbaseLocation.ReadOnly = true;
            txtDbaseLocation.Size = new Size(486, 79);
            txtDbaseLocation.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(6, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(316, 15);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Choose where the backup database file will be stored.";
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
            panel1.Size = new Size(1385, 69);
            panel1.TabIndex = 194;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(588, 12);
            label2.Name = "label2";
            label2.Size = new Size(165, 42);
            label2.TabIndex = 193;
            label2.Text = "OPTIONS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1185, 0);
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
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1385, 749);
            Controls.Add(panel1);
            Controls.Add(grpBoxActivityLogs);
            Controls.Add(lstOptions);
            Controls.Add(grpBoxBackupDatabase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Options";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            Load += Options_Load;
            grpBoxActivityLogs.ResumeLayout(false);
            grpBoxActivityLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivityLogs).EndInit();
            grpBoxBackupDatabase.ResumeLayout(false);
            grpBoxBackupDatabase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)addActivityLogsTableBindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOptions;
        private GroupBox grpBoxActivityLogs;
        private DataGridView dgvActivityLogs;
        private GroupBox grpBoxBackupDatabase;
        private Button btnSaveDbaseBackupLocation;
        private Label label1;
        private TextBox txtDbaseLocation;
        private Label lblDescription;
        private Button btnChoosePath;
        private FolderBrowserDialog folderBrowserDialogDbaseBackupLocation;
        private Button btnBackup;
        private BindingSource addActivityLogsTableBindingSource;
        private BindingSource addActivityLogsTableBindingSource1;
        private Button btnExport;
        private Button btnFilter;
        private Label label4;
        private DateTimePicker dtpTo;
        private Label label3;
        private DateTimePicker dtpFrom;
        private DataGridViewTextBoxColumn timestamp;
        private DataGridViewTextBoxColumn user;
        private DataGridViewTextBoxColumn module;
        private DataGridViewTextBoxColumn action;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn payload;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label2;
    }
}