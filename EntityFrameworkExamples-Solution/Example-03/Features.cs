using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Features
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal rating { get; set; }

        //Product Information
        public int ProductId { get; set; }
        public Product Products { get; set; }
    }
}
