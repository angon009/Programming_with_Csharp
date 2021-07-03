using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Product
    {
        public int id { get; set; }
        public string productType { get; set; }
        public DateTime expireDate { get; set; }
        
        //public List<Buyer> sellList { get; set; }

        public List<Features> Features{ get; set; }
        public List<BuyerProduct> ProductBuyers { get; set; }
    }
}
