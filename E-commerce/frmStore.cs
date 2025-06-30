using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_commerce.Seller;
using E_commerce.Side_Panal_User_Controls;
using E_commerce.User;
using Ecommerce_BusinessLayer;

namespace E_commerce
{
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
            timer1.Start();
            LoadUserControl(new Side_Panal_User_Controls.ctrlStore());
        }


        //public event EventHandler eventRefreshStoreTable;

        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);

        }


        private void ChangeIcon(object sender)
        {
            // reset all icons to white
            pbStore.Image = Properties.Resources.storeWhite;
            pbCart.Image = Properties.Resources.cartWhite;
            pbBalance.Image = Properties.Resources.moneyWhite;
            pbMyOrders.Image = Properties.Resources.ordersWhite;
            pbDashboard.Image = Properties.Resources.dashboardWhite;
            pbMyProducts.Image = Properties.Resources.myproductsWhite;
            pbPromocodes.Image = Properties.Resources.promoWhite;
            pbSellerSettings.Image = Properties.Resources.settingWhite;

            // reset all fonts to the defult font => Color: ControlDark, Font: Consolas, 15.75pt, style=Bold, Italic
            lblStore.ForeColor = SystemColors.ControlDark;
            lblCart.ForeColor = SystemColors.ControlDark;
            lblBalance.ForeColor = SystemColors.ControlDark;
            lblMyOrders.ForeColor = SystemColors.ControlDark;
            lblDashboard.ForeColor = SystemColors.ControlDark;
            lblMyProducts.ForeColor = SystemColors.ControlDark;
            lblPromocodes.ForeColor = SystemColors.ControlDark;
            lblSellerSettings.ForeColor = SystemColors.ControlDark;
            lblStore.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblCart.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblBalance.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblMyOrders.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblDashboard.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblMyProducts.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblPromocodes.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);
            lblSellerSettings.Font = new Font("Consolas", 15.75F, FontStyle.Bold | FontStyle.Italic);

            // change the icon of the selected panel to orange and change the font to => Color: ButtonFace, Font: Consolas, 20.25pt, style=Bold, Italic
            if (sender == pnlStore || sender == lblStore)
            {
                pbStore.Image = Properties.Resources.storeOrange;
                lblStore.ForeColor = SystemColors.ButtonFace;
                lblStore.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            }
            else if (sender == pnlCart || sender == lblCart)
            {
                pbCart.Image = Properties.Resources.cartOrange;
                lblCart.ForeColor = SystemColors.ButtonFace;
                lblCart.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            }
            //else if (sender == pnlBalance || sender == lblBalance)
            //{
            //    pbBalance.Image = Properties.Resources.moneyOrange;
            //    lblBalance.ForeColor = SystemColors.ButtonFace;
            //    lblBalance.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            //}
            else if (sender == pnlMyOrders || sender == lblMyOrders)
            {
                pbMyOrders.Image = Properties.Resources.ordersOrange;
                lblMyOrders.ForeColor = SystemColors.ButtonFace;
                lblMyOrders.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            }
            else if (sender == pnlDashboard || sender == lblDashboard)
            {
                pbDashboard.Image = Properties.Resources.dashboardOrange;
                lblDashboard.ForeColor = SystemColors.ButtonFace;
                lblDashboard.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            }
            else if (sender == pnlMyProducts || sender == lblMyProducts)
            {
                pbMyProducts.Image = Properties.Resources.myproductsOrange;
                lblMyProducts.ForeColor = SystemColors.ButtonFace;
                lblMyProducts.Font = new Font("Consolas", 18, FontStyle.Bold | FontStyle.Italic);
            }
            else if (sender == pnlPromocodes || sender == lblPromocodes)
            {
                pbPromocodes.Image = Properties.Resources.promoOrange;
                lblPromocodes.ForeColor = SystemColors.ButtonFace;
                lblPromocodes.Font = new Font("Consolas", 18, FontStyle.Bold | FontStyle.Italic);
            }
            else if (sender == pnlSettings || sender == lblSellerSettings)
            {
                pbSellerSettings.Image = Properties.Resources.settingOrange;
                lblSellerSettings.ForeColor = SystemColors.ButtonFace;
                lblSellerSettings.Font = new Font("Consolas", 20.25F, FontStyle.Bold | FontStyle.Italic);
            }

        }

        private bool CheckIfNotSeller()
        {
           return (!clsUser.IsUserSeller(clsUser.CURRENT_USER.userID)) ? true : false;
        }

        private void ChangeMainPanal(object sender, EventArgs e)
        {
            if (sender == pnlStore || sender == lblStore)
            {
                LoadUserControl(new Side_Panal_User_Controls.ctrlStore());
                ChangeIcon(sender);
            }

            else if (sender == pnlBalance || sender == lblBalance)
            {
                var frmBalance = new Balance.frmBalance(clsUser.CURRENT_USER.userID);
                frmBalance.ShowDialog();
            }

            else if (sender == pnlCart || sender == lblCart)
            {
                LoadUserControl(new Side_Panal_User_Controls.ctrlCart());
                ChangeIcon(sender);
            }
            else if (sender == pnlMyOrders || sender == lblMyOrders)
            {
                LoadUserControl(new Side_Panal_User_Controls.ctrlMyOrders());
                ChangeIcon(sender);
            }
            else if (sender == pnlDashboard || sender == lblDashboard)
            {
                if (CheckIfNotSeller())
                {
                    MessageBox.Show("You are not a seller. Please become a seller to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadUserControl(new Side_Panal_User_Controls.ctrlDashboard());
                ChangeIcon(sender);
            }
            else if (sender == pnlMyProducts || sender == lblMyProducts)
            {
                if (CheckIfNotSeller())
                {
                    MessageBox.Show("You are not a seller. Please become a seller to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadUserControl(new Side_Panal_User_Controls.ctrlMyProducts());
                ChangeIcon(sender);
            }
            else if (sender == pnlPromocodes || sender == lblPromocodes)
            {
                if (CheckIfNotSeller())
                {
                    MessageBox.Show("You are not a seller. Please become a seller to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadUserControl(new Side_Panal_User_Controls.ctrlPromocodes());
                ChangeIcon(sender);
            }
            else if (sender == pnlSettings || sender == lblSellerSettings)
            {
                if (CheckIfNotSeller())
                {
                    MessageBox.Show("You are not a seller. Please become a seller to access this feature.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                clsSeller seller = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID);
                frmBecomeASeller frm = new frmBecomeASeller(seller.SellerID);
                frm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
        }

        private void pbUserProfile_Click(object sender, EventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile();
            frmUserProfile.ShowDialog();
        }

        //TODO: make the cart 
    }
}
