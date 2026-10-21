using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAKOPointOfSale.Transactions.Return
{

    public partial class ReturnReason : Form
    {
        public event Action<string> Reason;
        public ReturnReason()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Reason?.Invoke(txtReason.Text.Trim());
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Return",
                description: "Clicked Submit button",
                payload: null
            );
            this.Close();
        }

        private void ReturnReason_Load(object sender, EventArgs e)
        {

        }

        private void ReturnReason_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Hide the current form
                e.Handled = true; // Prevent further processing of the key event
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActivityLogs.Log(
                user: LoggedInUser.FullName,
                action: "click",
                module: "Return > Return Reason",
                description: "Clicked Cancel button",
                payload: null
            );
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
