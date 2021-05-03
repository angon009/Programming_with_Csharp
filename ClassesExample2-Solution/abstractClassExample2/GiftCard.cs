using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample2
{
    public class GiftCard : Item
    {
        public override double GetDiscount(double originalPrice)
        {
            return (originalPrice * 10) / 100;
        }

       public GiftCard(double price)
            :base(price)
        {
             
        }
    }
}
