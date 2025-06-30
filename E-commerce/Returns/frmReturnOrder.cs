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

namespace E_commerce.Returns
{
    public partial class frmReturnOrder: Form
    {
        private int ReturnID;
        private int OrderID;
        private int ProductID;
        private int UserID;
        private int Quantity;
        private decimal RefundAmount;
        private string Reason;

        public frmReturnOrder(int orderID, int productID, int userID, int quantity, decimal refundAmount)
        {
            InitializeComponent();
            this.OrderID = orderID;
            this.ProductID = productID;
            this.UserID = userID;
            this.Quantity = quantity;
            this.RefundAmount = refundAmount;
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Reason = string.IsNullOrEmpty(txtReason.Text) ? "" : txtReason.Text;
                if (clsReturns.ReturnProduct(UserID, ProductID, OrderID, RefundAmount, Quantity, Reason, out ReturnID))
                {
                    MessageBox.Show($"Product returned successfully! ReturnID = {ReturnID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"${RefundAmount} has been added to your account successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to return product. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while returning the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
