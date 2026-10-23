namespace PAKOPointOfSale.Users
{
    partial class UsersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersList));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            usertypeidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middlenameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthdayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suffixDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userType = new DataGridViewTextBoxColumn();
            createdatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            userBindingSource = new BindingSource(components);
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTime = new Label();
            lblDate = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(237, 242, 239);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, usertypeidDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, firstnameDataGridViewTextBoxColumn, middlenameDataGridViewTextBoxColumn, lastnameDataGridViewTextBoxColumn, birthdayDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, suffixDataGridViewTextBoxColumn, userType, createdatDataGridViewTextBoxColumn, is_active, edit });
            dataGridView1.DataSource = userBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto SemiBold", 9.75F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1342, 634);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // usertypeidDataGridViewTextBoxColumn
            // 
            usertypeidDataGridViewTextBoxColumn.DataPropertyName = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.HeaderText = "user_type_id";
            usertypeidDataGridViewTextBoxColumn.Name = "usertypeidDataGridViewTextBoxColumn";
            usertypeidDataGridViewTextBoxColumn.ReadOnly = true;
            usertypeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            middlenameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            middlenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            birthdayDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            suffixDataGridViewTextBoxColumn.DataPropertyName = "suffix";
            suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            suffixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userType
            // 
            userType.DataPropertyName = "user_type";
            userType.HeaderText = "Role";
            userType.Name = "userType";
            userType.ReadOnly = true;
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            createdatDataGridViewTextBoxColumn.HeaderText = "Date Created";
            createdatDataGridViewTextBoxColumn.MinimumWidth = 150;
            createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            createdatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // is_active
            // 
            is_active.DataPropertyName = "is_active";
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
            is_active.Resizable = DataGridViewTriState.True;
            is_active.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // edit
            // 
            edit.DataPropertyName = "id";
            edit.HeaderText = "";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            txtSearch.Location = new Point(77, 114);
            txtSearch.MaxLength = 20;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(391, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 39, 56);
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Roboto", 9.75F);
            btnAdd.ForeColor = Color.FromArgb(237, 242, 239);
            btnAdd.Location = new Point(1088, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 26);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(87, 196, 229);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 9.75F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1179, 110);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 7;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(249, 112, 104);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Roboto", 9.75F);
            button2.ForeColor = Color.FromArgb(237, 242, 239);
            button2.Location = new Point(1270, 110);
            button2.Name = "button2";
            button2.Size = new Size(85, 26);
            button2.TabIndex = 8;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            panel1.TabIndex = 196;
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
            label2.Size = new Size(125, 42);
            label2.TabIndex = 193;
            label2.Text = "USERS";
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
            // UsersList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(1367, 770);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersList";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += UsersList_Load;
            KeyDown += UsersList_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource userBindingSource;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usertypeidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userType;
        private DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewButtonColumn edit;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTime;
        private Label lblDate;
        private Label label8;
        private PictureBox pictureBox4;
    }
}