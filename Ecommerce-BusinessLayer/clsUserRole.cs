using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsUserRole
    {
        public int userID { get; set; }
        public int roleID { get; set; }

        public clsUserRole()
        {
            this.userID = -1;
            this.roleID = -1;
        }

        public clsUserRole(int userID, int roleID)
        {
            this.userID = userID;
            this.roleID = roleID;
        }

        public static int GetUserRole(int userID)
        {
            return clsUserRoleData.GetUserRole(userID);
        }

    }
}
