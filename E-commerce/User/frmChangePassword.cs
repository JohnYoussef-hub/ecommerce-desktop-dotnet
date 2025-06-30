using E_commerce.Global_Classes;
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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void pbVisible_Click(object sender, EventArgs e)
        {
            txtOldPassword.UseSystemPasswordChar = !txtOldPassword.UseSystemPasswordChar;
            txtNewPassword.UseSystemPasswordChar = !txtNewPassword.UseSystemPasswordChar;
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;
            pbVisible.Image = txtOldPassword.UseSystemPasswordChar ? Properties.Resources.invisible : Properties.Resources.see;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsSecure.ComputeHash(txtOldPassword.Text) != clsUser.CURRENT_USER.passwordHash)
            {
                MessageBox.Show("Old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    int currentUserID = clsUser.CURRENT_USER.userID;
                    clsUser.ChangePasswordByUserID(currentUserID, clsSecure.ComputeHash(txtNewPassword.Text));
                    clsUser.CURRENT_USER.passwordHash = clsSecure.ComputeHash(txtNewPassword.Text);
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error while changing password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
