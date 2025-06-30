using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsUser
    {
        public static clsUser CURRENT_USER { get; set; }


        public enum enMode { AddUser = 1, UpdateUser = 2 }
        private enMode _mode;
        

        public int userID { get; set; }
        public clsPerson person { get; set; }
        public string userName { get; set; }
        public string passwordHash { get; set; }

        public clsUser()
        {
            this.userID = -1;
            this.person = new clsPerson();
            this.userName = string.Empty;
            this.passwordHash = string.Empty;
            this._mode = enMode.AddUser;
        }

        public clsUser(int userID, clsPerson person, string userName, string passwordHash)
        {
            this.userID = userID;
            this.person = person;
            this.userName = userName;
            this.passwordHash = passwordHash;
            this._mode = enMode.UpdateUser;
        }


        private void _AddUser()
        {
            string firstName = this.person.firstName;
            string secondName = this.person.secondName;
            string thirdName = this.person.thirdName;
            string lastName = this.person.lastName;
            string email = this.person.email;
            string phone = this.person.phone;
            DateTime dateOfBirth = this.person.dateOfBirth;
            int countryID = this.person.countryID;
            int gender = this.person.gender;
            string address = this.person.address;
            string imagePath = this.person.imagePath;
            string userName = this.userName;
            string passwordHash = this.passwordHash;

            this.userID = clsUserData.AddUser(firstName, secondName, thirdName, lastName, email,
                phone, dateOfBirth, countryID, address, gender, imagePath, userName, passwordHash);
        }

        private bool _UpdateUser()
        {
            int userID = this.userID;
            string firstName = this.person.firstName;
            string secondName = this.person.secondName;
            string thirdName = this.person.thirdName;
            string lastName = this.person.lastName;
            string email = this.person.email;
            string phone = this.person.phone;
            DateTime dateOfBirth = this.person.dateOfBirth;
            int countryID = this.person.countryID;
            int gender = this.person.gender;
            string address = this.person.address;
            string imagePath = this.person.imagePath;
            string userName = this.userName;
            string passwordHash = this.passwordHash;

            return clsUserData.UpdateUser(userID, firstName, secondName, thirdName, lastName, email,
                phone, dateOfBirth, countryID, address, gender, imagePath, userName, passwordHash);
        }



        public bool Save()
        {
            switch(this._mode)
            {
                case enMode.AddUser:
                    _AddUser();
                    this._mode = enMode.UpdateUser;
                    return true;
                case enMode.UpdateUser:
                    return _UpdateUser() ? true : false;
                default:
                    return false;
            }
        }


        public static bool IsUserExistsByUserID(int userID)
        {
            return clsUserData.IsUserExistsByUserID(userID);
        }

        public static bool IsUserExistsByUserName(string userName)
        {
            return clsUserData.IsUserExistsByUserName(userName);
        }

        public static clsUser GetUserByUserID(int userID)
        {
            DataTable dt = clsUserData.GetUserByUserID(userID);

            if (dt.Rows.Count == 0) return null; // Return null if no user is found

            DataRow row = dt.Rows[0];

            // Extract user details from the DataTable
            string firstName = row["FirstName"].ToString();
            string secondName = row["SecondName"].ToString();
            string thirdName = row["ThirdName"].ToString();
            string lastName = row["LastName"].ToString();
            string email = row["Email"].ToString();
            string phone = row["Phone"].ToString();
            DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            int countryID = Convert.ToInt32(row["CountryID"]);
            string address = row["Address"].ToString();
            int gender = Convert.ToInt32(row["Gender"]);
            string imagePath = row["ImagePath"] == DBNull.Value ? null : row["ImagePath"].ToString();
            string userName = row["UserName"].ToString();
            string passwordHash = row["PasswordHash"].ToString();

            // Create a clsPerson object
            clsPerson person = new clsPerson(
                firstName, secondName, thirdName, lastName, email, phone, gender, 
                dateOfBirth, countryID, address, imagePath
            );

            // Create and return a clsUser object
            return new clsUser(userID, person, userName, passwordHash);
        }

        public static clsUser GetUserByUsername(string userName)
        {
            DataTable dt = clsUserData.GetUserByUsername(userName);

            if (dt.Rows.Count == 0) return null; // Return null if no user is found

            DataRow row = dt.Rows[0];

            // Extract user details from the DataTable
            string firstName = row["FirstName"].ToString();
            string secondName = row["SecondName"].ToString();
            string thirdName = row["ThirdName"].ToString();
            string lastName = row["LastName"].ToString();
            string email = row["Email"].ToString();
            string phone = row["Phone"].ToString();
            DateTime dateOfBirth = Convert.ToDateTime(row["DateOfBirth"]);
            int countryID = Convert.ToInt32(row["CountryID"]);
            string address = row["Address"].ToString();
            int gender = Convert.ToInt32(row["Gender"]);
            string imagePath = row["ImagePath"] == DBNull.Value ? null : row["ImagePath"].ToString();
            int userID = Convert.ToInt32(row["UserID"]);
            string passwordHash = row["PasswordHash"].ToString();

            // Create a clsPerson object
            clsPerson person = new clsPerson(
                firstName, secondName, thirdName, lastName, email, phone, gender,
                dateOfBirth, countryID, address, imagePath
            );

            // Create and return a clsUser object
            return new clsUser(userID, person, userName, passwordHash);
        }

        public static bool ChangePasswordByUserID(int userID, string passwordHash)
        {
            return clsUserData.ChangePasswordByUserID(userID, passwordHash);
        }

        public static bool IsUserSeller(int userID)
        {
            return clsUserData.IsUserSeller(userID);
        }


    }
}
