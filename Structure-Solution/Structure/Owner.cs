using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public class Owner
    {
        public string OrderType { get; set; }
        public string OrderId { get; set; }
        public int ProductPrice { get; set; }

        public void OrderBill()
        {
            Console.WriteLine($"Type : {OrderType} ID : {OrderId} Price : {ProductPrice}");
        }
    }
}
