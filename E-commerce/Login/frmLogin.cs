using E_commerce.Global_Classes;
using E_commerce.User;
using Ecommerce_BusinessLayer;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commerce
{
    public partial class frmLogin: Form
    {

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public event Action OnSaveCredentialsEvent;
        public event Action OnUnSaveCredentialsEvent;

        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmLogin_KeyDown);

            LoadLoginInfo();
            OnSaveCredentialsEvent += SaveLoginInfo;
            OnUnSaveCredentialsEvent += UnSaveLoginInfo;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Handled)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, e);
            }
        }


        const string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\E-commerce";

        private void SaveLoginInfo()
        {
            Registry.SetValue(keyPath, "UserName", txtUserName.Text ?? "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "PasswordHash", txtPassword.Text ?? "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "SaveState", "true", RegistryValueKind.String);
        }

        private void UnSaveLoginInfo()
        {
            Registry.SetValue(keyPath, "UserName", "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "PasswordHash", "", RegistryValueKind.String);
            Registry.SetValue(keyPath, "SaveState", "false", RegistryValueKind.String);
        }

        private void LoadLoginInfo()
        {
            string value1Data = Registry.GetValue(keyPath, "UserName", null) as string;
            string value2Data = Registry.GetValue(keyPath, "PasswordHash", null) as string;
            bool saveState = Registry.GetValue(keyPath, "SaveState", null) as string == "true";

            txtUserName.Text = value1Data ?? "";
            txtPassword.Text = value2Data ?? "";
            chkRememberMe.Checked = saveState;
        }

        private void pbSeePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            pbSeePass.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.invisible : Properties.Resources.see;
        }

        private bool LoginProccess(string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Please enter username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!clsLogin.IsValidLogin(UserName, Password))
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pbSeePass.Image = Properties.Resources.invisible;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginProccess(txtUserName.Text, clsSecure.ComputeHash(txtPassword.Text)))
            {
                (chkRememberMe.Checked ? OnSaveCredentialsEvent : OnUnSaveCredentialsEvent)?.Invoke();

                clsUser currentUser = clsUser.GetUserByUsername(txtUserName.Text);
                clsUser.CURRENT_USER = currentUser;
                this.Hide();
                frmStore frmMain = new frmStore();
                frmMain.ShowDialog();
                this.Close();
            }
        }

        private void lblClose_Click(object sender, EventArgs e) => this.Close();

        private void lnkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
        }
    }
}
