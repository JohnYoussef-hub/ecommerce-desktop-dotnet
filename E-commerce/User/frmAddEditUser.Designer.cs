﻿namespace E_commerce.User
{
    partial class frmAddEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlAddEditUser1 = new E_commerce.User.Controls.ctrlAddEditUser();
            this.SuspendLayout();
            // 
            // ctrlAddEditUser1
            // 
            this.ctrlAddEditUser1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddEditUser1.Name = "ctrlAddEditUser1";
            this.ctrlAddEditUser1.Size = new System.Drawing.Size(1130, 630);
            this.ctrlAddEditUser1.TabIndex = 0;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 633);
            this.Controls.Add(this.ctrlAddEditUser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlAddEditUser ctrlAddEditUser1;
    }
}