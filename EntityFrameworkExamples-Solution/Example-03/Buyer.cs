using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Buyer
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime purchaseDate { get; set; }
        public decimal totalBill { get; set; }
        public List<BuyerProduct> ProductFeatures { get; set; }
    }
}
