using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_07
{
    public class Foods
    {
         
        public double FoodPrice { get; set; }
        public virtual double FoodDiscount(double offerDiscount) // Default Method // Can be override in its child class
        {
            if (offerDiscount >= 0 && offerDiscount <= 100)
                return FoodPrice * offerDiscount / 100.0;
            else
                throw new InvalidOperationException();
        }

        public string FoodName()
        {
            return "Foods";
        }


    }
}
