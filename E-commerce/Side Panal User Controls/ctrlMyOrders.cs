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

namespace E_commerce.Side_Panal_User_Controls
{
    public partial class ctrlMyOrders : UserControl
    {
        public ctrlMyOrders()
        {
            InitializeComponent();
        }

        private void RefreshOrdersTable()
        {
            dgvOrders.DataSource = clsOrder.GetAllOrdersByUserID(clsUser.CURRENT_USER.userID);
            dgvOrders.Columns["ProductID"].Visible = false;
        }

        private void RefreshReturnsTable()
        {
            dgvReturns.DataSource = clsReturns.GetAllReturnsByUserID(clsUser.CURRENT_USER.userID);
        }

        private void ctrlMyOrders_Load(object sender, EventArgs e)
        {
            RefreshOrdersTable();
            RefreshReturnsTable();
            lblTotalReturns.Text = dgvReturns.Rows.Count.ToString();
            lblTotalOrders.Text = dgvOrders.Rows.Count.ToString();
        }

        private void returnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order to return.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["OrderID"].Value);
            int productID = Convert.ToInt32(dgvOrders.CurrentRow.Cells["ProductID"].Value);
            int userID = clsUser.CURRENT_USER.userID;
            int quantity = Convert.ToInt32(dgvOrders.CurrentRow.Cells["Quantity"].Value);
            decimal refundAmount = Convert.ToDecimal(dgvOrders.CurrentRow.Cells["Total Price $"].Value);

            // Open the return order form and pass the order details
            using (var frm = new E_commerce.Returns.frmReturnOrder(orderID, productID, userID, quantity, refundAmount))
            {
                frm.ShowDialog();
                RefreshOrdersTable();
                RefreshReturnsTable();
            }
        }

        private void dgvReturns_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalReturns.Text = dgvReturns.Rows.Count.ToString();
        }
        private void dgvReturns_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalReturns.Text = dgvReturns.Rows.Count.ToString();
        }

        private void dgvOrders_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalOrders.Text = dgvOrders.Rows.Count.ToString();
        }
        private void dgvOrders_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalOrders.Text = dgvOrders.Rows.Count.ToString();
        }
    }
}
