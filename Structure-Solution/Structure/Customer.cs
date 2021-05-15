using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Customer
    {
        public string Name { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
        public void Bill()
        {
            Console.WriteLine($"Name : {Name} Type : {ProductType} Price : {ProductPrice}");
        }
    }
}
