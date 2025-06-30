using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsCart
    {
        public static bool AddProductToCart(int UserID, int ProductID, int Quantity)
        {
            try
            {
                return clsCartData.AddProductToCart(UserID, ProductID, Quantity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding product to cart: {ex.Message}", ex);
            }
        }

        public static DataTable GetAllCartByUserID(int userID)
        {
            try
            {
                return clsCartData.GetAllCartByUserID(userID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving cart for user {userID}: {ex.Message}", ex);
            }
        }


        public static bool RemoveProductFromCart(int cartID)
        {
            return clsCartData.RemoveProductFromCart(cartID);
        }
    }

}
