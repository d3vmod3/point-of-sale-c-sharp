namespace PAKOPointOfSale.UAC
{
    partial class UAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UAC));
            cmbRole = new ComboBox();
            userTypeBindingSource = new BindingSource(components);
            label1 = new Label();
            btnUpdate = new Button();
            btnClose = new Button();
            module_name = new DataGridViewTextBoxColumn();
            can_view = new DataGridViewCheckBoxColumn();
            can_add = new DataGridViewCheckBoxColumn();
            can_edit = new DataGridViewCheckBoxColumn();
            can_delete = new DataGridViewCheckBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            permissionBindingSource2 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usertypeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            module_name2 = new DataGridViewTextBoxColumn();
            can_view2 = new DataGridViewCheckBoxColumn();
            can_add2 = new DataGridViewCheckBoxColumn();
            can_edit2 = new DataGridViewCheckBoxColumn();
            can_delete2 = new DataGridViewCheckBoxColumn();
            userTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            permissionBindingSource = new BindingSource(components);
            permissionBindingSource3 = new BindingSource(components);
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource3).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.DataSource = userTypeBindingSource;
            cmbRole.DisplayMember = "name";
            cmbRole.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(93, 114);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(328, 23);
            cmbRole.TabIndex = 0;
            cmbRole.ValueMember = "id";
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            cmbRole.SelectedValueChanged += cmbRole_SelectedValueChanged;
            // 
            // userTypeBindingSource
            // 
            userTypeBindingSource.DataSource = typeof(UserType);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Role:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(33, 39, 56);
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Roboto", 9.75F);
            btnUpdate.ForeColor = Color.FromArgb(237, 242, 239);
            btnUpdate.Location = new Point(1153, 111);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 26);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Changes";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(249, 112, 104);
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Roboto", 9.75F);
            btnClose.ForeColor = Color.FromArgb(237, 242, 239);
            btnClose.Location = new Point(1269, 111);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 26);
            btnClose.TabIndex = 150;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // module_name
            // 
            module_name.DataPropertyName = "module_name";
            module_name.Frozen = true;
            module_name.HeaderText = "Module";
            module_name.MinimumWidth = 300;
            module_name.Name = "module_name";
            module_name.ReadOnly = true;
            module_name.Width = 300;
            // 
            // can_view
            // 
            can_view.DataPropertyName = "can_view";
            can_view.Frozen = true;
            can_view.HeaderText = "View";
            can_view.MinimumWidth = 250;
            can_view.Name = "can_view";
            can_view.Width = 250;
            // 
            // can_add
            // 
            can_add.DataPropertyName = "can_add";
            can_add.Frozen = true;
            can_add.HeaderText = "Add";
            can_add.MinimumWidth = 250;
            can_add.Name = "can_add";
            can_add.Width = 250;
            // 
            // can_edit
            // 
            can_edit.DataPropertyName = "can_edit";
            can_edit.Frozen = true;
            can_edit.HeaderText = "Edit";
            can_edit.MinimumWidth = 250;
            can_edit.Name = "can_edit";
            can_edit.Width = 250;
            // 
            // can_delete
            // 
            can_delete.DataPropertyName = "can_delete";
            can_delete.HeaderText = "Delete";
            can_delete.MinimumWidth = 300;
            can_delete.Name = "can_delete";
            can_delete.Visible = false;
            can_delete.Width = 300;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            userTypeDataGridViewTextBoxColumn.HeaderText = "userType";
            userTypeDataGridViewTextBoxColumn.MinimumWidth = 300;
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.Visible = false;
            userTypeDataGridViewTextBoxColumn.Width = 300;
            // 
            // permissionBindingSource2
            // 
            permissionBindingSource2.DataSource = typeof(Model.Permission);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiBold", 9.75F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, usertypeidDataGridViewTextBoxColumn, module_name2, can_view2, can_add2, can_edit2, can_delete2, userTypeDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = permissionBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1342, 634);
            dataGridView1.TabIndex = 152;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            usertypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // module_name2
            // 
            module_name2.DataPropertyName = "module_name";
            module_name2.HeaderText = "Module";
            module_name2.Name = "module_name2";
            // 
            // can_view2
            // 
            can_view2.DataPropertyName = "can_view";
            can_view2.HeaderText = "View";
            can_view2.Name = "can_view2";
            // 
            // can_add2
            // 
            can_add2.DataPropertyName = "can_add";
            can_add2.HeaderText = "Add";
            can_add2.Name = "can_add2";
            // 
            // can_edit2
            // 
            can_edit2.DataPropertyName = "can_edit";
            can_edit2.HeaderText = "Edit";
            can_edit2.Name = "can_edit2";
            // 
            // can_delete2
            // 
            can_delete2.DataPropertyName = "can_delete";
            can_delete2.HeaderText = "Delete";
            can_delete2.Name = "can_delete2";
            can_delete2.Visible = false;
            // 
            // userTypeDataGridViewTextBoxColumn1
            // 
            userTypeDataGridViewTextBoxColumn1.DataPropertyName = "userType";
            userTypeDataGridViewTextBoxColumn1.HeaderText = "userType";
            userTypeDataGridViewTextBoxColumn1.Name = "userTypeDataGridViewTextBoxColumn1";
            userTypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // permissionBindingSource
            // 
            permissionBindingSource.DataSource = typeof(Model.Permission);
            // 
            // permissionBindingSource3
            // 
            permissionBindingSource3.DataSource = typeof(Model.Permission);
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
            panel1.Size = new Size(1367, 69);
            panel1.TabIndex = 197;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(237, 242, 239);
            label2.Location = new Point(513, 12);
            label2.Name = "label2";
            label2.Size = new Size(411, 42);
            label2.TabIndex = 193;
            label2.Text = "USER ACCESS CONTROL";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTime, 0, 1);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(1167, 0);
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
            // UAC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1367, 770);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UAC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Access Control";
            Load += UAC_Load;
            KeyDown += UAC_KeyDown;
            ((System.ComponentModel.ISupportInitialize)userTypeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)permissionBindingSource3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbRole;
        private Label label1;
        private BindingSource userTypeBindingSource;
        private Button btnUpdate;
        private Button btnClose;
        private DataGridViewTextBoxColumn module_name;
        private DataGridViewCheckBoxColumn can_view;
        private DataGridViewCheckBoxColumn can_add;
        private DataGridViewCheckBoxColumn can_edit;
        private DataGridViewCheckBoxColumn can_delete;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private BindingSource permissionBindingSource2;
        private DataGridView dataGridView1;
        private BindingSource permissionBindingSource3;
        private BindingSource permissionBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usertypeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn module_name2;
        private DataGridViewCheckBoxColumn can_view2;
        private DataGridViewCheckBoxColumn can_add2;
        private DataGridViewCheckBoxColumn can_edit2;
        private DataGridViewCheckBoxColumn can_delete2;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn1;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}