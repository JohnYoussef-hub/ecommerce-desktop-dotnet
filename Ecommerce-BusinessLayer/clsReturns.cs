using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsReturns
    {
        public int ReturnID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public decimal RefundAmount { get; set; }
        public string Reason { get; set; }
        public DateTime ReturnDate { get; set; }

        public clsReturns()
        {
            ReturnID = 0;
            OrderID = 0;
            ProductID = 0;
            UserID = 0;
            Quantity = 0;
            RefundAmount = 0.0m;
            Reason = string.Empty;
            ReturnDate = DateTime.Now;
        }
        public clsReturns(int returnID, int orderID, int productID, int userID, int quantity, decimal refundAmount, string reason, DateTime returnDate)
        {
            ReturnID = returnID;
            OrderID = orderID;
            ProductID = productID;
            UserID = userID;
            Quantity = quantity;
            RefundAmount = refundAmount;
            Reason = reason;
            ReturnDate = returnDate;
        }



        public static bool ReturnProduct(int userID, int productID, int orderID, decimal totalAmount, int quantity, string reason, out int returnID)
        {
            return clsReturnsData.ReturnProduct(userID, productID, orderID, totalAmount, quantity, reason, out returnID);
        }

        public static DataTable GetAllReturnsByUserID(int userID)
        {
            return clsReturnsData.GetAllReturnsByUserID(userID);
        }
    }
}
