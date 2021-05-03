using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Teacher : UserBase , IUser
    {
        public override string IdFormat
        {
            get
            {
                return "T-1000";
            }
        }

        public override void Register(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
