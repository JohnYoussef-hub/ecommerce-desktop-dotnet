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

namespace E_commerce.Cart
{
    public partial class frmCart: Form
    {
        clsProduct product;
        private int productID;
        public frmCart(int productID)
        {
            InitializeComponent();
            this.productID = productID;
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            product = clsProduct.GetProductByID(productID);

            ddNumberOfQuantity.Items.Clear();

            if (product != null && product.quantity > 0)
            {
                for (int i = 1; i <= product.quantity; i++)
                {
                    ddNumberOfQuantity.Items.Add(i);
                }
                ddNumberOfQuantity.SelectedIndex = 0;
            }
            else
            {
                ddNumberOfQuantity.Items.Add(0);
                ddNumberOfQuantity.SelectedIndex = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int UserID = clsUser.CURRENT_USER.userID;
            int Quantity = Convert.ToInt32(ddNumberOfQuantity.SelectedItem);
            int ProductID = product.productID;

            try
            {
                if(clsCart.AddProductToCart(UserID, ProductID, Quantity))
                {
                    MessageBox.Show("Product added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }


                else
                    MessageBox.Show("Failed to add product to cart. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product to cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
