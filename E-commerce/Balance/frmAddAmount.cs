using Ecommerce_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce.Balance
{
    public partial class frmAddAmount : Form
    {
        public frmAddAmount()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            decimal amount = txtAmount.Text == string.Empty ? 0 : Convert.ToDecimal(txtAmount.Text);
            if (amount < 1)
                errorProvider1.SetError(txtAmount, "Amount must be greater than zero.");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal amount = txtAmount.Text == string.Empty ? 0 : Convert.ToDecimal(txtAmount.Text);
            if (amount < 1)
            {
                MessageBox.Show("Amount must be greater than zero.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                int userID = clsUser.CURRENT_USER.userID;
                if (clsAccountBalance.AddBalanceToAccount(userID, amount))
                {
                    MessageBox.Show("Amount added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Failed to add amount. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
