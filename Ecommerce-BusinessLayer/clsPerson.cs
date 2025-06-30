using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_BusinessLayer
{
    public class clsPerson
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string thirdName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int countryID { get; set; }
        public string address { get; set; }
        public string imagePath { get; set; }


        public clsPerson()
        {
        }


        public clsPerson(string firstName, string secondName, string thirdName, string lastName, string email, string phone, int gender, DateTime dateOfBirth, int countryID, string address, string imagePath)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.thirdName = thirdName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.countryID = countryID;
            this.address = address;
            this.imagePath = imagePath;
        }
    }
}
