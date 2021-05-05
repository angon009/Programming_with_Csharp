using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public sealed class Admin : Student
    {
        public Admin()
        {
            //hobby - > This field can't be accessed beacause it is declared as 'Private'
            classSerial = 2; // This field is accessible it is declared as 'Protected'
        }
    }
}
