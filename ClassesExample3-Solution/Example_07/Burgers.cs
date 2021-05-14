using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_07
{
    public class Burgers : Foods
    {
        public override double FoodDiscount(double offerDiscount) // Overridden in child class
        {
             
            //base.FoodDiscount(offerDiscount); // Used to call parent class implementation
            if (offerDiscount >= 0 && offerDiscount <= 50)
                return FoodPrice * offerDiscount / 100.0;
            else
                throw new InvalidOperationException();
        }

        public new string FoodName()
        {
            return "Burgers";
        }

         
    }
}
