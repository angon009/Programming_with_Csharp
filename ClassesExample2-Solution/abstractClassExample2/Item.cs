using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample2
{
    public abstract class Item
    {
        public double Price { get; set; }
        public abstract double GetDiscount(double originalPrice);

        public Item(double price)
        {
            Price = price;
        }
    }
}
