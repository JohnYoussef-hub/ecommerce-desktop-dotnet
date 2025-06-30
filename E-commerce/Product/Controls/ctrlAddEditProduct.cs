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
using E_commerce.Global_Classes;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace E_commerce.Product
{
    public partial class ctrlAddEditProduct : UserControl
    {
        public ctrlAddEditProduct()
        {
            InitializeComponent();
            ddCategories.DataSource = clsCategory.GetAllCategories();
        }

        //private void ctrlAddEditProduct_Load(object sender, EventArgs e)
        //{
        //    ddCategories.DataSource = clsCategory.GetAllCategories();
        //}
        private void ValidateTextField(Bunifu.UI.WinForms.BunifuTextBox textBox, Func<string, bool> validationFunc, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !validationFunc(textBox.Text))
                errorProvider1.SetError(textBox, errorMessage);
            else
                errorProvider1.SetError(textBox, "");
        }
        private void txtProductName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtProductName, clsValidation.IsValidName, "Please enter a valid product name", e);
        }
        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 1)
                errorProvider1.SetError(txtPrice, "Please enter a valid price greater than 1$");
            else
                errorProvider1.SetError(txtPrice, "");
        }
        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
                errorProvider1.SetError(txtQuantity, "Please enter a valid quantity (0 or more)");
            else
                errorProvider1.SetError(txtQuantity, "");
        }
        private void ddCategories_Validating(object sender, CancelEventArgs e)
        {
            if (ddCategories.SelectedIndex == -1)
                errorProvider1.SetError(ddCategories, "Please select a category");
            else
                errorProvider1.SetError(ddCategories, "");
        }
        private void pbProductImage_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pbProductImage.ImageLocation))
                errorProvider1.SetError(pbProductImage, "Please upload a product image");
            else
                errorProvider1.SetError(pbProductImage, "");
        }

        public void fillForm(int productID)
        {
            clsProduct product = clsProduct.GetProductByID(productID);
            if (product != null)
            {
                lblMainTitle.Text = "UPDATE PRODUCT";
                lblProductID.Text = product.productID.ToString();
                txtProductName.Text = product.name;
                txtDescription.Text = product.description;
                txtPrice.Text = product.price.ToString();
                txtQuantity.Text = product.quantity.ToString();

                ddCategories.SelectedIndex = product.categoryID - 1;
                // TODO: fix the error here

                pbProductImage.ImageLocation = product.imagePath;
                chkIsAvailable.Checked = product.isAvailable;
            }
        }

        public void SaveAddUpdate()
        {
            clsProduct product;

            if (lblProductID.Text == "N/A")
            {
                product = new clsProduct()
                {
                    productID = 0,
                    name = txtProductName.Text,
                    description = txtDescription.Text,
                    price = decimal.Parse(txtPrice.Text),
                    quantity = int.Parse(txtQuantity.Text),
                    categoryID = ddCategories.SelectedIndex + 1,
                    sellerID = clsSeller.GetSellerByUserID(clsUser.CURRENT_USER.userID).SellerID,
                    imagePath = string.IsNullOrEmpty(pbProductImage.ImageLocation) ? null : pbProductImage.ImageLocation,
                    isAvailable = chkIsAvailable.Checked
                };

                // TODO: make My Products section and add products for sellers
            }
            else
            {
                int productID = int.Parse(lblProductID.Text);
                clsProduct existingProduct = clsProduct.GetProductByID(productID);
                product = new clsProduct(productID,
                    txtProductName.Text,
                    txtDescription.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtQuantity.Text),
                    ddCategories.SelectedIndex + 1,
                    existingProduct.sellerID,
                    string.IsNullOrEmpty(pbProductImage.ImageLocation) ? null : pbProductImage.ImageLocation,
                    chkIsAvailable.Checked
                    );
            }

            if (product.Save())
            {
                MessageBox.Show("Product saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMainTitle.Text = "UPDATE PRODUCT";
                lblProductID.Text = product.productID.ToString();
                txtProductName.Text = product.name;
                txtDescription.Text = product.description;
                txtPrice.Text = product.price.ToString();
                txtQuantity.Text = product.quantity.ToString();
                ddCategories.SelectedIndex = product.categoryID - 1;
                pbProductImage.ImageLocation = product.imagePath;
                chkIsAvailable.Checked = product.isAvailable;
            }
            else
            {
                MessageBox.Show("Failed to save product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasErrors = false;

            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    hasErrors = true;
                    break;
                }
            }

            if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(txtQuantity.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) ||
                hasErrors)
            {
                MessageBox.Show("Please fill in all required fields and correct any errors.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveAddUpdate();
            }
        }


        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Get product or create a new one if in add mode
            clsProduct product = null;
            if (lblProductID.Text != "N/A")
            {
                int productID;
                if (int.TryParse(lblProductID.Text, out productID))
                {
                    product = clsProduct.GetProductByID(productID);
                }
            }

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Save the original image path to delete if needed
                string oldImagePath = pbProductImage.ImageLocation;

                // First set image location to the selected file
                pbProductImage.ImageLocation = openFileDialog1.FileName;

                // If updating product and image path has changed, delete the old image
                if (product != null && !string.IsNullOrEmpty(oldImagePath) &&
                    oldImagePath != openFileDialog1.FileName)
                {
                    if (File.Exists(oldImagePath))
                    {
                        try
                        {
                            File.Delete(oldImagePath);
                        }
                        catch (Exception ex)
                        {
                            // Just log the error but continue
                            System.Diagnostics.Debug.WriteLine("Error deleting old image: " + ex.Message);
                        }
                    }
                }

                // Copy the selected image to a permanent location
                string filePath = openFileDialog1.FileName;
                string uniqueId = Guid.NewGuid().ToString();
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string destinationFolder = Path.Combine(documentsFolder, "UploadedImages_Ecommerce");

                // Create directory if it doesn't exist
                if (!Directory.Exists(destinationFolder))
                    Directory.CreateDirectory(destinationFolder);

                // Create the new filename with the unique ID
                string newFileName = uniqueId + Path.GetExtension(filePath);
                string destinationPath = Path.Combine(destinationFolder, newFileName);

                // Copy the file to our destination folder
                File.Copy(filePath, destinationPath);

                // Update the image location in the picture box
                pbProductImage.ImageLocation = destinationPath;

                // Update button text
                btnAddImage.Text = "Update Image";
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(pbProductImage.ImageLocation))
                {
                    string imagePath = pbProductImage.ImageLocation;

                    // Delete the file if it exists
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }

                    // Clear the image location and set to default product image
                    pbProductImage.ImageLocation = null;
                    pbProductImage.Image = Properties.Resources.product; // Assuming you have a default product image

                    MessageBox.Show("Product image deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update button text
                    btnAddImage.Text = "Add Image";
                }
                else
                {
                    MessageBox.Show("No product image to delete.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product image: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
