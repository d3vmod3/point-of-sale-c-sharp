namespace PAKOPointOfSale.Products.Filters
{
    partial class Stocks
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
            label1 = new Label();
            btnFilter = new Button();
            num_quantity = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)num_quantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto SemiBold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(377, 15);
            label1.TabIndex = 0;
            label1.Text = "Please input the minimum quantity you want to apply for this filter";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(33, 39, 56);
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Roboto", 9.75F);
            btnFilter.ForeColor = Color.FromArgb(237, 242, 239);
            btnFilter.Location = new Point(241, 73);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(75, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // num_quantity
            // 
            num_quantity.BackColor = SystemColors.Window;
            num_quantity.DecimalPlaces = 2;
            num_quantity.Location = new Point(12, 44);
            num_quantity.Name = "num_quantity";
            num_quantity.Size = new Size(377, 23);
            num_quantity.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(249, 112, 104);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Roboto", 9.75F);
            btnCancel.ForeColor = Color.FromArgb(237, 242, 239);
            btnCancel.Location = new Point(323, 73);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(66, 23);
            btnCancel.TabIndex = 117;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 239);
            ClientSize = new Size(400, 118);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(num_quantity);
            Controls.Add(btnFilter);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Stocks";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filter Stocks";
            Load += Stocks_Load;
            KeyDown += Stocks_KeyDown;
            ((System.ComponentModel.ISupportInitialize)num_quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFilter;
        private NumericUpDown num_quantity;
        private Button btnCancel;
    }
}