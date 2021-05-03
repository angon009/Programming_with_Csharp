using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample2
{
    public class Product : Item
    {
        public override double GetDiscount(double originalPrice)
        {
            return originalPrice * 2;
        }

        public Product(double price)
            :base(price)
        {

        }
    }
}
