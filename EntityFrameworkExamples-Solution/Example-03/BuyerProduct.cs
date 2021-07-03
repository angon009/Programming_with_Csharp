using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class BuyerProduct
    {
        public int productId { get; set; }
        public int buyerId { get; set; }
        public Product product { get; set; }
        public Buyer buyer { get; set; }
        public DateTime purchaseDate { get; set; }
    }
}
