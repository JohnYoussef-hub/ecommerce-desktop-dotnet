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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace E_commerce.User.Controls
{
    public partial class ctrlAddEditUser: UserControl
    {
        enum enMode { AddUser = 1, UpdateUser = 2 }
        private enMode _mode;



        public ctrlAddEditUser()
        {
            InitializeComponent();
            rbMale.Checked = true;
            pbPersonImage.Image = Properties.Resources.Man_User;

            // Load countries into the combo box
            List<string> countries = clsCountry.GetAllCountries();
            foreach (string country in countries)
            {
                cbCountry.Items.Add(country);
            }
            cbCountry.SelectedIndex = 51; // Default to Egypt
        }

        public void FillForm(int UserID)
        {
            clsUser user = clsUser.GetUserByUserID(UserID);
            clsPerson person = user.person;

            lblUserID.Text = user.userID.ToString();
            txtFirstName.Text = person.firstName;
            txtSecondName.Text = person.secondName;
            txtThirdName.Text = person.thirdName;
            txtLastName.Text = person.lastName;
            txtEmail.Text = person.email;
            txtPhone.Text = person.phone;
            txtAddress.Text = person.address;
            dtpDateOfBirth.Value = person.dateOfBirth;
            cbCountry.SelectedIndex = person.countryID - 1;
            pbPersonImage.ImageLocation = person.imagePath;
            if (person.gender == 1)
            {
                rbMale.Checked = true;
                rbFemale.Checked = false;
                pbPersonImage.Image = Properties.Resources.Man_User;
            }
            else
            {
                rbMale.Checked = false;
                rbFemale.Checked = true;
                pbPersonImage.Image = Properties.Resources.Woman_User;
            }

            txtPassword.Enabled = false;
            txtUserName.Enabled = false;

            lblMainTitle.Text = "UPDATE USER";
            btnAddImage.Text = "Update Image";
            btnRemoveImage.Visible = true;
            btnSave.Text = "Update User";

            pbVisible.Enabled = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                pbPersonImage.Image = Properties.Resources.Woman_User;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                pbPersonImage.Image = Properties.Resources.Man_User;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            pbVisible.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.invisible : Properties.Resources.see;
        }



        // For validations
        private void ValidateTextField(Bunifu.UI.WinForms.BunifuTextBox textBox, Func<string, bool> validationFunc, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || !validationFunc(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }


        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtFirstName, clsValidation.IsValidName, "Please enter a valid first name", e);
        }
        private void txtSecondName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtSecondName, clsValidation.IsValidName, "Please enter a valid second name", e);
        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtLastName, clsValidation.IsValidName, "Please enter a valid last name", e);
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtEmail, clsValidation.IsValidEmail, "Please enter a valid email", e);
        }
        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtPhone, clsValidation.IsValidPhoneNumber, "Please enter a valid phone number", e);
        }
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtAddress, clsValidation.IsValidAddress, "Please enter a valid address", e);
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextField(txtUserName, clsValidation.IsValidUserName, "This user name already taken or invalid, choose another one!", e);
        }

        ////////////////////////////////////////////////////////////////////////


        public void SaveAddUpdate()
        {
            clsPerson person;
            clsUser user;

            if (lblUserID.Text == "N/A") // Adding a new user
            {
                // Create a new person using the parameterized constructor
                person = new clsPerson()
                {
                    firstName = txtFirstName.Text,
                    secondName = txtSecondName.Text,
                    thirdName = string.IsNullOrWhiteSpace(txtThirdName.Text) ? "" : txtThirdName.Text,
                    lastName = txtLastName.Text,
                    email = txtEmail.Text,
                    phone = txtPhone.Text,
                    gender = rbMale.Checked ? 1 : 0,
                    dateOfBirth = dtpDateOfBirth.Value,
                    countryID = cbCountry.SelectedIndex + 1,
                    address = txtAddress.Text,
                    imagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation) ? null : pbPersonImage.ImageLocation
                };

                // Create a new user using the parameterized constructor
                user = new clsUser()
                {
                    userID = -1, // Assuming -1 indicates a new user
                    person = person,
                    userName = txtUserName.Text,
                    passwordHash = clsSecure.ComputeHash(txtPassword.Text)
                };
            }
            else // Updating an existing user
            {
                int userID = int.Parse(lblUserID.Text);

                // Initialize the person object with retrieved data
                clsUser getUser = clsUser.GetUserByUserID(userID);

                person = new clsPerson(
                    firstName: getUser.person.firstName,
                    secondName: getUser.person.secondName,
                    thirdName: getUser.person.thirdName,
                    lastName: getUser.person.lastName,
                    email: getUser.person.email,
                    phone: getUser.person.phone,
                    gender: getUser.person.gender,
                    dateOfBirth: getUser.person.dateOfBirth,
                    countryID: getUser.person.countryID,
                    address: getUser.person.address,
                    imagePath: getUser.person.imagePath
                );

                user = new clsUser(
                    userID: userID,
                    person: person,
                    userName: getUser.userName,
                    passwordHash: getUser.passwordHash
                );



                // Update the person's properties with form data
                person.firstName = txtFirstName.Text;
                person.secondName = txtSecondName.Text;
                person.thirdName = string.IsNullOrWhiteSpace(txtThirdName.Text) ? "" : txtThirdName.Text;
                person.lastName = txtLastName.Text;
                person.gender = rbMale.Checked ? 1 : 0;
                person.email = txtEmail.Text;
                person.phone = txtPhone.Text;
                person.address = txtAddress.Text;
                person.dateOfBirth = dtpDateOfBirth.Value;
                person.countryID = cbCountry.SelectedIndex + 1;
                person.imagePath = string.IsNullOrEmpty(pbPersonImage.ImageLocation) ? null : pbPersonImage.ImageLocation;

                if (string.IsNullOrEmpty(person.imagePath))
                {
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.Man_User : Properties.Resources.Woman_User;
                }

                // Create a user object for the update
                user = new clsUser(
                    userID: int.Parse(lblUserID.Text),
                    person: person,
                    userName: string.IsNullOrEmpty(txtUserName.Text) ? getUser.userName : txtUserName.Text,
                    passwordHash: string.IsNullOrEmpty(txtPassword.Text) ? getUser.passwordHash : clsSecure.ComputeHash(txtPassword.Text)
                );
            }

            // Save the user object
            if (user.Save())
            {
                MessageBox.Show("User saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMainTitle.Text = "UPDATE USER";

                // Update the form with saved data
                txtFirstName.Text = person.firstName;
                txtSecondName.Text = person.secondName;
                txtThirdName.Text = person.thirdName;
                txtLastName.Text = person.lastName;
                txtEmail.Text = person.email;
                txtPhone.Text = person.phone;
                txtAddress.Text = person.address;
                dtpDateOfBirth.Value = person.dateOfBirth;
                cbCountry.SelectedIndex = person.countryID - 1;
                pbPersonImage.ImageLocation = person.imagePath;
                lblUserID.Text = user.userID.ToString();
            }
            else
            {
                MessageBox.Show("Failed to save user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {


            bool hasErrors = false;

            // Validate all controls for errors
            foreach (Control control in this.Controls)
            {
                if (!string.IsNullOrEmpty(errorProvider1.GetError(control)))
                {
                    hasErrors = true;
                    break;
                }
            }

            // Check required fields for adding a new user
            if (lblUserID.Text == "N/A" && (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text)))
            {
                MessageBox.Show("Username and Password are required for adding a new user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check other required fields
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtSecondName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
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
            clsUser user;
            if (lblUserID.Text == "N/A") user = new clsUser();
            else user = clsUser.GetUserByUserID(int.Parse(lblUserID.Text));

            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;

                if (user.person.imagePath != pbPersonImage.ImageLocation && lblUserID.Text != "N/A")
                {
                    if (File.Exists(user.person.imagePath)) File.Delete(user.person.imagePath);
                }

                string filePath = openFileDialog1.FileName;
                string uniqueId = Guid.NewGuid().ToString();
                string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string destinationFolder = Path.Combine(documentsFolder, "UploadedImages_Ecommerce");
                if (!Directory.Exists(destinationFolder)) Directory.CreateDirectory(destinationFolder);
                string newFileName = uniqueId + Path.GetExtension(filePath);
                string destinationPath = Path.Combine(destinationFolder, newFileName);

                File.Copy(filePath, destinationPath);
                pbPersonImage.ImageLocation = destinationPath;
                btnAddImage.Text = "Update Image";
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbPersonImage.ImageLocation != null)
                {
                    string imagePath = pbPersonImage.ImageLocation;
                    if (File.Exists(imagePath)) File.Delete(imagePath);

                    pbPersonImage.ImageLocation = null;
                    pbPersonImage.Image = rbMale.Checked ? Properties.Resources.Man_User : Properties.Resources.Woman_User;

                    MessageBox.Show("Image deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnAddImage.Text = "Add Image";
                }
                else
                {
                    MessageBox.Show("No image to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged2(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {

        }

        private void ctrlAddEditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
