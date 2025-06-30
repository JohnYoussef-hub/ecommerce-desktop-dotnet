using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_BusinessLayer
{
    public class clsDashboard
    {
        public static int GetTotalProductsBySellerID(int sellerID)
        {
            return Ecommerce_DataAccessLayer.clsDashboardData.GetTotalProductsBySellerID(sellerID);
        }

        public static decimal GetTotalEarningsBySellerID(int sellerID)
        {
            return Ecommerce_DataAccessLayer.clsDashboardData.GetTotalEarningsBySellerID(sellerID);
        }
    }
}
