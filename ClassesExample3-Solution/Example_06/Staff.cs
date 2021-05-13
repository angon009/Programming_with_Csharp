using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public class Staff : Authority , IAuthority
    {
        public override string IdFormat
        {
            get
            {
                return "S-";
            }
        }


    }
}
