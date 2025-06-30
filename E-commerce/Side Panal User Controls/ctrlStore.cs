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
using E_commerce.Cart;

namespace E_commerce.Side_Panal_User_Controls
{
    public partial class ctrlStore : UserControl
    {
        // Add a field to store the original DataTable
        private DataTable _productsDataTable;

        private void RefreshStoreTable()
        {
            _productsDataTable = clsProduct.GetAllProducts();
            dgvMyProducts.DataSource = _productsDataTable;
            dgvMyProducts.Columns["ProductID"].Visible = false;
        }
        private void RefreshPromocodesTable()
        {
            dgvPromocodes.DataSource = clsPromocodes.GetAllPromocodesForStore();
        }

        public ctrlStore()
        {
            InitializeComponent();
            RefreshStoreTable();
            RefreshPromocodesTable();
        }
        private void ctrlStore_Load(object sender, EventArgs e)
        {
            RefreshPromocodesTable();
            RefreshStoreTable();
            ddFilterBy.SelectedIndex = 0;
        }
        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalProducts.Text = dgvMyProducts.Rows.Count.ToString();
        }
        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalProducts.Text = dgvMyProducts.Rows.Count.ToString();
        }

        private void showProductInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMyProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to view its information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int productID = Convert.ToInt32(dgvMyProducts.SelectedRows[0].Cells["ProductID"].Value);
            frmShowProductInformation frm = new frmShowProductInformation(productID);
            frm.ShowDialog();
        }

        private void addToCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isAvaiable = Convert.ToBoolean(dgvMyProducts.SelectedRows[0].Cells["IsAvailable"].Value);
            if (!isAvaiable)
            {
                MessageBox.Show("This product is not available for purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dgvMyProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to add to cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int productID = Convert.ToInt32(dgvMyProducts.SelectedRows[0].Cells["ProductID"].Value);
            var frm = new frmCart(productID);
            frm.ShowDialog();
        }

        private void ApplyFilterBy()
        {
            if (_productsDataTable == null)
            {
                RefreshStoreTable(); // Ensure data is loaded
                RefreshPromocodesTable();
            }
                

            DataView dv = new DataView(_productsDataTable);

            string filterColumn = "";
            string filterValue = "";

            // Determine the filter column and value based on the selected filter type
            switch (ddFilterBy.SelectedItem?.ToString())
            {
                case "Product Name":
                    filterColumn = "Product Name";
                    filterValue = txtFilterValue.Text.Trim().Replace("'", "''");
                    break;
                case "Store Name":
                    filterColumn = "StoreName";
                    filterValue = txtFilterValue.Text.Trim().Replace("'", "''");
                    break;
                case "Category":
                    filterColumn = "Category";
                    filterValue = ddCategories.SelectedItem?.ToString().Replace("'", "''") ?? "";
                    break;
                default:
                    dgvMyProducts.DataSource = _productsDataTable; // Reset to original data
                    return;
            }

            // Apply the filter if the filter value is not empty
            try
            {
                if (!string.IsNullOrEmpty(filterValue))
                {
                    if (ddFilterBy.SelectedItem?.ToString() == "Category")
                    {
                        if(filterValue == "All")
                            dv.RowFilter = ""; // No filter for "All Categories"
                        else
                            dv.RowFilter = $"{filterColumn} = '{filterValue}'"; // Exact match for category
                    }
                    else
                    {
                        dv.RowFilter = $"[{filterColumn}] LIKE '%{filterValue}%'";
                        // Partial match for text
                    }
                }
                dgvMyProducts.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvMyProducts.DataSource = _productsDataTable; // Reset on error
            }
        }

        private void ddFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = ""; // Clear previous filter value
            if (ddFilterBy.SelectedItem?.ToString() == "Product Name")
            {
                RefreshStoreTable();
                ddCategories.Visible = false;
                txtFilterValue.Visible = true;
            }
            else if (ddFilterBy.SelectedItem?.ToString() == "Store Name")
            {
                RefreshStoreTable();
                ddCategories.Visible = false;
                txtFilterValue.Visible = true;
            }
            else if (ddFilterBy.SelectedItem?.ToString() == "Category")
            {
                ddCategories.SelectedIndex = 0;
                ddCategories.Visible = true;
                txtFilterValue.Visible = false;
            }
            else
            {
                ddCategories.Visible = false;
                txtFilterValue.Visible = false;
                ApplyFilterBy(); // Reset filter if no valid option is selected
            }
        }

        private void ddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterBy();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterBy();
        }

        private void dgvPromocodes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalPromocodes.Text = dgvPromocodes.Rows.Count.ToString();
        }
        private void dgvPromocodes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalPromocodes.Text = dgvPromocodes.Rows.Count.ToString();
        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }
    }
}