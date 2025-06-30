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

namespace E_commerce.Product
{
    public partial class ctrlShowProductInformation : UserControl
    {
        public ctrlShowProductInformation()
        {
            InitializeComponent();
        }


        public void fillForm(int ProductID)
        {
            clsProduct product = clsProduct.GetProductByID(ProductID);
            if (product != null)
            {
                lblProductName.Text = product.name;
                txtDescription.Text = product.description;
                lblPrice.Text = product.price.ToString("C");
                lblQuantity.Text = product.quantity.ToString();
                lblCategory.Text = clsCategory.GetCategoryNameByCategoryID(product.categoryID - 1);
                lblStoreName.Text = clsSeller.GetSellerBySellerID(product.sellerID).StoreName;
                lblIsAvailable.Text = product.isAvailable ? "Yes" : "No";

                if (product.imagePath != null)
                    pbProductImage.ImageLocation = product.imagePath;
            }

        }

        private void btnClose_Click(object sender, EventArgs e) => ParentForm.Close();

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}