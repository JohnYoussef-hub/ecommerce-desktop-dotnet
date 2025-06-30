using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsOrder
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public clsOrder()
        {
            OrderID = 0;
            ProductID = 0;
            UserID = 0;
            OrderDate = DateTime.Now;
            TotalAmount = 0.0m;
        }
        public clsOrder(int orderId, int productId, int userID, DateTime orderDate, decimal totalAmount)
        {
            OrderID = orderId;
            ProductID = productId;
            UserID = userID;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }

        public static bool PlaceOrder(int userID, int productID, int quantity, decimal totalAmount, out int orderID)
        {
            return clsOrderData.PlaceOrder(userID, productID, quantity, totalAmount, out orderID);
        }
        public static DataTable GetAllOrdersByUserID(int userID)
        {
            return clsOrderData.GetAllOrdersByUserID(userID);
        }

    }
}
