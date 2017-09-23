using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPrint.Models;

namespace WFPrint.Data
{
    public class CartData
    {
        public static List<vmItems> GetData()
        {
            List<vmItems> data = null;
            try
            {
                var Item1 = new vmItems(1, 2, "Chicken Tikka", 3.50, 7.00, false);
                var Item2 = new vmItems(2, 1, "Kebab", 3.50, 3.50, false); Item2.vmChildItems.Add(new vmItems(1, 2, "Extra Hot", 1.50, 1.50, true));
                var Item3 = new vmItems(3, 3, "Chicken Masala", 3.50, 3.50, false);
                var Item4 = new vmItems(4, 1, "Faluda", 3.50, 3.50, false);
                data = new List<vmItems> { Item1, Item2, Item3, Item4 };
            }
            catch (Exception)
            {
                throw;
            }

            return data;
        }
    }
}
