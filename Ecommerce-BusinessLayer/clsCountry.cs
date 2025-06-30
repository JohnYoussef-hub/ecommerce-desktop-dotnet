using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce_DataAccessLayer;

namespace Ecommerce_BusinessLayer
{
    public class clsCountry
    {
        public static List<string> GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
