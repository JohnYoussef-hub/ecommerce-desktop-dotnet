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
    public partial class frmBalance: Form
    {
        clsAccountBalance accountBalance;
        public frmBalance(int userID)
        {
            InitializeComponent();
            accountBalance = clsAccountBalance.GetAccountBalanceByUserID(userID);
            lblBalance.Text = accountBalance.balance.ToString("C2");
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            var addAmountForm = new frmAddAmount();
            addAmountForm.FormClosed += (s, args) =>
            {
                // Refresh the balance after adding amount
                accountBalance = clsAccountBalance.GetAccountBalanceByUserID(accountBalance.userID);
                lblBalance.Text = accountBalance.balance.ToString("C2");
            };
            addAmountForm.ShowDialog();

        }
    }
}
