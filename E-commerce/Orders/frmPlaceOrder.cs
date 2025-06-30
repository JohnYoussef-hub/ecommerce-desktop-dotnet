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

namespace E_commerce.Orders
{
    public partial class frmPlaceOrder : Form
    {

        private int userID;
        private int productID;
        private int quantity;
        private decimal totalAmount;

        public frmPlaceOrder(int userID, int productID, int quantity, decimal totalAmount)
        {
            InitializeComponent();
            this.userID = userID;
            this.productID = productID;
            this.quantity = quantity;
            this.totalAmount = totalAmount;


        }

        private void frmPlaceOrder_Load(object sender, EventArgs e)
        {
            lblQuantity.Text = quantity.ToString();
            lblTotalAmount.Text = totalAmount.ToString("C2");

            clsAccountBalance accountBalance = clsAccountBalance.GetAccountBalanceByUserID(userID);
            lblYourBalance.Text = accountBalance.balance.ToString("C2");

            // load ctrlShowProductInformation
            ctrlShowProductInformation1.fillForm(productID);

            lblAmountAfterDiscount.Visible = false;

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (!clsProduct.IsProductAvailable(productID))
            {
                MessageBox.Show("Product is not available for order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalAmount;
            if(lblAmountAfterDiscount.Visible == true)
            {
                totalAmount = decimal.Parse(lblAmountAfterDiscount.Text, System.Globalization.NumberStyles.Currency);
            }
            else
            {
                totalAmount = decimal.Parse(lblTotalAmount.Text, System.Globalization.NumberStyles.Currency);
            }

            // Check if user has sufficient balance
            clsAccountBalance accountBalance = clsAccountBalance.GetAccountBalanceByUserID(userID);
            if (accountBalance.balance < totalAmount)
            {
                MessageBox.Show("Insufficient balance to place the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int orderId;
                bool success = Ecommerce_BusinessLayer.clsOrder.PlaceOrder(
                    userID,
                    productID,
                    quantity,
                    totalAmount,
                    out orderId
                );

                if (success)
                {
                    MessageBox.Show($"Order placed successfully! Order ID: {orderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"${totalAmount} has been deducted from your account successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to place order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sellerID = clsProduct.GetSellerIDFromProductID(productID);

            if (clsPromocodes.IsPromocodeExists(txtPromocode.Text, sellerID))
            {
                clsPromocodes promocode = clsPromocodes.GetPromocodeBySellerID(sellerID, txtPromocode.Text);
                if (promocode != null)
                {
                    decimal discountAmount = (totalAmount * promocode.discountRate) / 100;
                    decimal amountAfterDiscount = totalAmount - discountAmount;
                    lblTotalAmount.Font = new Font(lblTotalAmount.Font, FontStyle.Strikeout);
                    lblAmountAfterDiscount.Text = amountAfterDiscount.ToString("C2");
                    lblAmountAfterDiscount.Visible = true;
                }
                else
                {
                    MessageBox.Show("Promocode not found for this seller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Promocode does not exist for this seller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtPromocode.Clear();
            lblAmountAfterDiscount.Visible = false;
            lblTotalAmount.Font = new Font(lblTotalAmount.Font, FontStyle.Bold);

        }
    }
}

