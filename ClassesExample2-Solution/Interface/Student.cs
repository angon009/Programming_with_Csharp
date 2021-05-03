using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : UserBase 
    {
        public override string IdFormat
        { 
            get
            {
                return "S-10101";
            }
        }

        public override void Register(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
