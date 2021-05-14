﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_07
{
    public class Pizzas : Foods 
    {
        public override double FoodDiscount(double offerDiscount) // Overridden in child class
        {
            if (offerDiscount >= 0 && offerDiscount <= 20)
                return FoodPrice * offerDiscount / 100.0;
            else
                throw new InvalidOperationException();
        }

        public new string FoodName()
        {
            return "Pizza";
        }

         
    }
}
