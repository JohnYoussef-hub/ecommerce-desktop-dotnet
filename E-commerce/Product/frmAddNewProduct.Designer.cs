namespace E_commerce.Product
{
    partial class frmAddNewProduct
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
            this.ctrlAddEditProduct1 = new E_commerce.Product.ctrlAddEditProduct();
            this.SuspendLayout();
            // 
            // ctrlAddEditProduct1
            // 
            this.ctrlAddEditProduct1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAddEditProduct1.Name = "ctrlAddEditProduct1";
            this.ctrlAddEditProduct1.Size = new System.Drawing.Size(978, 566);
            this.ctrlAddEditProduct1.TabIndex = 0;
            // 
            // frmAddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 575);
            this.Controls.Add(this.ctrlAddEditProduct1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddEditProduct ctrlAddEditProduct1;
    }
}