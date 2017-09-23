using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPrint.Models
{
    public class vmItems
    {
        public int ItemId { get; set; }
        public int ItemQty { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public double ItemTotal { get; set; }
        public bool IsChild { get; set; }
        public List<vmItems> vmChildItems { get; private set; }

        public vmItems(int id, int qty, string name, double price, double total, bool isChild)
        {
            ItemId = id;
            ItemQty = qty;
            ItemName = name;
            ItemPrice = price;
            ItemTotal = total;
            IsChild = isChild;
            vmChildItems = new List<vmItems>();
        }
    }
}
