using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_BusinessLayer
{
    public class clsPromocodes
    {
        public int codeID { get; set; }
        public string codeString { get; set; }
        public int discountRate { get; set; }
        public int sellerID { get; set; }

        public clsPromocodes()
        {
            codeID = 0;
            codeString = string.Empty;
            sellerID = 0;
            discountRate = 0;
        }
        public clsPromocodes(int codeID, string codeString, int discountRate, int sellerID)
        {
            this.codeID = codeID;
            this.codeString = codeString;
            this.sellerID = sellerID;
            this.discountRate = discountRate;
        }



        public static clsPromocodes GetPromocodeByCodeID(int codeID)
        {
            try
            {
                var dt = Ecommerce_DataAccessLayer.clsPromocodesData.GetPromocodeByCodeID(codeID);
                if (dt.Rows.Count > 0)
                {
                    return new clsPromocodes
                    {
                        codeID = Convert.ToInt32(dt.Rows[0]["CodeID"]),
                        codeString = dt.Rows[0]["CodeString"].ToString(),
                        sellerID = Convert.ToInt32(dt.Rows[0]["SellerID"]),
                        discountRate = Convert.ToInt32(dt.Rows[0]["DiscountRate"])
                    };
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving promocode by CodeID: {ex.Message}", ex);
            }
        }

        public static bool IsPromocodeExists(string codeString, int sellerID)
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.IsPromocodeExists(codeString, sellerID);
        }


        public static bool AddNewPromocode(string codeString, int discountRate, int sellerID)
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.AddNewPromocode(codeString, discountRate, sellerID);
        }

        public static bool RemovePromocode(int codeID)
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.RemovePromocode(codeID);
        }

        public static bool IsPromocodeExistsByCodeString(string codeString)
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.IsPromocodeExistsByCodeString(codeString);
        }

        public static System.Data.DataTable GetAllPromocodesBySellerID(int sellerID)
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.GetAllPromocodesBySellerID(sellerID);
        }

        public static clsPromocodes GetPromocodeBySellerID(int sellerID, string codeString)
        {
            try
            {
                var dt = Ecommerce_DataAccessLayer.clsPromocodesData.GetPromocodeBySellerID(sellerID, codeString);
                if (dt.Rows.Count > 0)
                {
                    return new clsPromocodes
                    {
                        codeID = Convert.ToInt32(dt.Rows[0]["CodeID"]),
                        codeString = dt.Rows[0]["CodeString"].ToString(),
                        discountRate = Convert.ToInt32(dt.Rows[0]["DiscountRate"]),
                    };
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving promocode by SellerID: {ex.Message}", ex);
            }
        }


        public static DataTable GetAllPromocodesForStore()
        {
            return Ecommerce_DataAccessLayer.clsPromocodesData.GetAllPromocodesForStore();
        }


    }
}
