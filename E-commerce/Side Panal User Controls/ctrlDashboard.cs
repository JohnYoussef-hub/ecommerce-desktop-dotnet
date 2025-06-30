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
    public partial class ctrlDashboard: UserControl
    {
        public ctrlDashboard()
        {
            InitializeComponent();
        }

        private void ctrlDashboard_Load(object sender, EventArgs e)
        {
            int sellerID = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID).SellerID;
            lblTotalEarnings.Text = clsDashboard.GetTotalEarningsBySellerID(sellerID).ToString("C");
            lblTotalProducts.Text = clsDashboard.GetTotalProductsBySellerID(sellerID).ToString();
        }

        private void lblTotalEarnings_Click(object sender, EventArgs e)
        {

        }
    }
}
