using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsCategory
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public clsCategory()
        {
            this.categoryID = 0;
            this.categoryName = string.Empty;
            this.description = string.Empty;
        }
        public clsCategory(int categoryID, string categoryName, string description, bool isActive)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.description = description;
        }
        public static List<string> GetAllCategories()
        {
            return clsCategoryData.GetAllCatigories();
        }

        public static string GetCategoryNameByCategoryID(int categoryID)
        {
            string categoryName = string.Empty;
            List<string> categories = clsCategoryData.GetAllCatigories();
            return categories[categoryID];
        }

        public static int GetCategoryIDByCategoryName(string categoryName)
        {
            List<string> categories = clsCategoryData.GetAllCatigories();
            return categories.IndexOf(categoryName) + 1;
        }
    }
}
