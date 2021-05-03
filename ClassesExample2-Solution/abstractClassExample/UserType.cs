using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample
{
    public abstract class UserType
    {
        public string userName = "Angon";

        public abstract string userInfo(string name, string type, string category);
    }
}
