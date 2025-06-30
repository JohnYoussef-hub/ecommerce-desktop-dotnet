using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_commerce.Product;
using Ecommerce_BusinessLayer;

namespace E_commerce.Side_Panal_User_Controls
{
    public partial class ctrlMyProducts : UserControl
    {
        public ctrlMyProducts()
        {
            InitializeComponent();
        }

        private void RefreshMyProductsTable()
        {
            clsSeller seller = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID);
            dgvMyProducts.DataSource = clsProduct.GetAllMyProducts(seller.SellerID);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            Form form = new frmAddNewProduct();
            form.ShowDialog();
            RefreshMyProductsTable();
        }

        private void dgvMyProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalProducts.Text = dgvMyProducts.Rows.Count.ToString();
        }

        private void dgvMyProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalProducts.Text = dgvMyProducts.Rows.Count.ToString();
        }

        

        private void ctrlMyProducts_Load(object sender, EventArgs e)
        {
            RefreshMyProductsTable();
            lblTotalProducts.Text = dgvMyProducts.Rows.Count.ToString();
            dgvMyProducts.Columns["ProductID"].Visible = false;
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(dgvMyProducts.SelectedRows[0].Cells["ProductID"].Value);
            Form frm = new frmAddNewProduct(productID);
            frm.ShowDialog();
            RefreshMyProductsTable();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int productID = Convert.ToInt32(dgvMyProducts.SelectedRows[0].Cells["ProductID"].Value);
                    clsProduct.DeleteProduct(productID);
                    RefreshMyProductsTable();
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
