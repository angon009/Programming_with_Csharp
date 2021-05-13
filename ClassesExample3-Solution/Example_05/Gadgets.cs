using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_05
{
    public abstract class Gadgets
    {
        public string GadgetName { get; set; }
        public string GadgetType { get; set; }
        public double GadgetPrice { get; set; }
        public abstract void GadgetInfo(string name, string type); // Method Signature // We can write method without body in abstract
        public double GadgetDiscount()
        {
            return GadgetPrice * 25 / 100;
        }

         
    }
}
