using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsLogin
    {
        public static bool IsValidLogin(string userName, string passwordHash)
        {
            // Validate the login credentials using the Data Access Layer
            return Ecommerce_DataAccessLayer.clsLoginData.IsValidLogin(userName, passwordHash);
        }
    }
}
