using E_commerce.Seller;
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

namespace E_commerce.User
{
    public partial class frmUserProfile: Form
    {
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            lblUsername.Text = clsUser.CURRENT_USER.userName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(clsUser.CURRENT_USER.userID);
            frmAddEditUser.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void btnBecomeASeller_Click(object sender, EventArgs e)
        {
            if (clsUser.IsUserSeller(clsUser.CURRENT_USER.userID))
            {
                MessageBox.Show("You are already a seller.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmBecomeASeller frm = new frmBecomeASeller();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new frmLogin();
            frm.ShowDialog();
            this.Close();
        }
    }
}
