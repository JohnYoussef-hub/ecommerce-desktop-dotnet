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

namespace E_commerce.Promocodes
{
    public partial class frmAddNewPromocode: Form
    {
        public frmAddNewPromocode()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsSeller seller = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID);

            if (string.IsNullOrEmpty(txtPromocode.Text))
            {
                MessageBox.Show("Please enter a promocode.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Ecommerce_BusinessLayer.clsPromocodes.IsPromocodeExists(txtPromocode.Text,seller.SellerID))
            {
                MessageBox.Show("This promocode already exists.", "Duplicate Promocode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (Ecommerce_BusinessLayer.clsPromocodes.AddNewPromocode(txtPromocode.Text, int.Parse(ddRate.SelectedItem.ToString()), seller.SellerID))
                {
                    MessageBox.Show("Promocode added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add promocode. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the promocode: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddNewPromocode_Load(object sender, EventArgs e)
        {
            ddRate.SelectedIndex = 0; 
        }
    }
}
