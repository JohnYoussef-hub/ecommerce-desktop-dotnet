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
using E_commerce.Promocodes;

namespace E_commerce.Side_Panal_User_Controls
{
    public partial class ctrlPromocodes: UserControl
    {
        public ctrlPromocodes()
        {
            InitializeComponent();
        }

        clsSeller seller;
        private void RefreshTable(int sellerID)
        {
            DataTable dt = clsPromocodes.GetAllPromocodesBySellerID(sellerID);
            dgvPromocodes.DataSource = dt;
        }

        private void ctrlPromocodes_Load(object sender, EventArgs e)
        {
            seller = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID);
            RefreshTable(seller.SellerID);
            lblTotalPromocodes.Text = dgvPromocodes.Rows.Count.ToString();
        }

        private void dgvPromocodes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalPromocodes.Text = dgvPromocodes.Rows.Count.ToString();
        }

        private void dgvPromocodes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalPromocodes.Text = dgvPromocodes.Rows.Count.ToString();
        }

        private void btnAddNewPromocode_Click(object sender, EventArgs e)
        {
            frmAddNewPromocode frmAddNewPromocode = new frmAddNewPromocode();
            frmAddNewPromocode.ShowDialog();
            RefreshTable(seller.SellerID);
        }

        private void deletePromocodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this promocode?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dgvPromocodes.SelectedRows.Count > 0)
                {
                    int promocodeID = Convert.ToInt32(dgvPromocodes.SelectedRows[0].Cells["CodeID"].Value);
                    if (clsPromocodes.RemovePromocode(promocodeID))
                    {
                        MessageBox.Show("Promocode deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTable(seller.SellerID);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete promocode. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a promocode to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
