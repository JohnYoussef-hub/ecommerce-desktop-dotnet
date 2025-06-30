using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecommerce_BusinessLayer;
using E_commerce.Product;

namespace E_commerce.Side_Panal_User_Controls
{
    public partial class ctrlCart : UserControl
    {
        public ctrlCart()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvCart.DataSource = clsCart.GetAllCartByUserID(clsUser.CURRENT_USER.userID);
            dgvCart.Columns["CartID"].Visible = false;
            dgvCart.Columns["ProductID"].Visible = false;
        }

        private void ctrlCart_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void dgvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalProducts.Text = dgvCart.Rows.Count.ToString();
        }
        private void dgvCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalProducts.Text = dgvCart.Rows.Count.ToString();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void showProductInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmShowProductInformation(Convert.ToInt32(dgvCart.SelectedRows[0].Cells["ProductID"].Value));
            form.ShowDialog();
        }

        private void PlaceOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to place an order.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvCart.SelectedRows[0];
            int userID = clsUser.CURRENT_USER.userID;
            int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
            decimal totalAmount = Convert.ToDecimal(row.Cells["Total Price $"].Value);

            Form frm = new Orders.frmPlaceOrder(userID, productId, quantity, totalAmount);
            frm.ShowDialog();
            RefreshTable();




            //int orderId;
            //bool success = Ecommerce_BusinessLayer.clsOrder.PlaceOrder(
            //    userID,
            //    productId,
            //    quantity,
            //    totalAmount,
            //    out orderId
            //);

            //if (success)
            //{
            //    MessageBox.Show($"Order placed successfully! Order ID: {orderId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    // Optionally, refresh the cart or remove the ordered item
            //}
            //else
            //{
            //    MessageBox.Show("Failed to place order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cartID = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["CartID"].Value);
            try
            {
                if(MessageBox.Show("Are you sure you want to remove this product from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsCart.RemoveProductFromCart(cartID))
                    {
                        MessageBox.Show("Product removed from cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove product from cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
