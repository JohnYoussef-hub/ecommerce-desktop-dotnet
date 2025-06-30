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

namespace E_commerce.Seller
{
    public partial class ctrlBecomeASeller : UserControl
    {
        enum enMode { AddSeller = 1, UpdateSeller = 2 }
        private enMode _mode;

        // Add a public event that other components can subscribe to
        //public event EventHandler<SellerEventArgs> SellerSaved;

        // Custom event args class to pass the seller data
        public class SellerEventArgs : EventArgs
        {
            public clsSeller Seller { get; set; }

            public SellerEventArgs(clsSeller seller)
            {
                Seller = seller;
            }
        }

        // Method to raise the event
        //protected virtual void OnSellerSaved(clsSeller seller)
        //{
        //    SellerSaved?.Invoke(this, new SellerEventArgs(seller));
        //}

        public ctrlBecomeASeller()
        {
            InitializeComponent();

            // Rename the controls to match their purpose
            txtStoreName.Name = "txtStoreName";
            txtStoreDescription.Name = "txtStoreDescription";

            // Set the default mode
            _mode = enMode.AddSeller;

            // Add event handler for save button
            //btnSave.Click += btnSave_Click;
        }

        private void ctrlBecomeASeller_Load(object sender, EventArgs e)
        {
        }

        public void FillForm(int SellerID)
        {
            // Get the seller information by ID
            clsSeller seller = clsSeller.GetSellerBySellerID(SellerID);

            if (seller != null)
            {
                // Update the form fields with seller data
                lblSellerID.Text = seller.SellerID.ToString();
                txtStoreName.Text = seller.StoreName;
                txtStoreDescription.Text = seller.StoreDescription;

                // Update UI elements to reflect update mode
                lblMainTitle.Text = "UPDATE SELLER INFO";
                btnSave.Text = "Update Seller";

                // Change the mode
                _mode = enMode.UpdateSeller;
            }
            else
            {
                MessageBox.Show("Seller not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrEmpty(txtStoreName.Text))
                {
                    MessageBox.Show("Please enter a store name.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtStoreDescription.Text))
                {
                    MessageBox.Show("Please enter a store description.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure user is logged in
                if (clsUser.CURRENT_USER == null)
                {
                    MessageBox.Show("You must be logged in to become a seller.", "Not Logged In",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(clsSeller.IsStoreNameExists(txtStoreName.Text))
                {
                    MessageBox.Show("Store name already exists. Please choose a different name.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create or update the seller
                clsSeller seller;

                if (lblSellerID.Text == "N/A") // Adding a new seller
                {
                    // Create a new seller
                    seller = new clsSeller
                    {
                        User = clsUser.CURRENT_USER,
                        StoreName = txtStoreName.Text,
                        StoreDescription = txtStoreDescription.Text
                    };
                }
                else // Updating an existing seller
                {
                    int sellerID = int.Parse(lblSellerID.Text);

                    // Get the existing seller
                    seller = clsSeller.GetSellerBySellerID(sellerID);

                    // Update the seller properties
                    seller.StoreName = txtStoreName.Text;
                    seller.StoreDescription = txtStoreDescription.Text;
                }

                // Save the seller
                if (seller.Save())
                {
                    MessageBox.Show("Seller information saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the UI to reflect the saved state
                    lblSellerID.Text = seller.SellerID.ToString();
                    lblMainTitle.Text = "UPDATE SELLER INFO";
                    btnSave.Text = "Update Seller";

                    // Set the mode to update
                    _mode = enMode.UpdateSeller;
                }
                else
                {
                    MessageBox.Show("Failed to save seller information.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving seller information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add a method to get the current seller object
        public clsSeller GetCurrentSeller()
        {
            if (lblSellerID.Text != "N/A")
            {
                return clsSeller.GetSellerBySellerID(int.Parse(lblSellerID.Text));
            }
            return null;
        }
    }
}
