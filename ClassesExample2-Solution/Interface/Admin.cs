using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Admin : UserBase
    {
        public override string IdFormat
        {
            get
            {
                return "A-1000";
            }
        }

        public override void Register(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
