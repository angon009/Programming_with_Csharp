using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class SupplyBottle
    {
        public static int productionSerial = 0;

        public SupplyBottle()
        {
            productionSerial++;
        }
    }
}
