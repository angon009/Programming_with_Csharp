using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public abstract class Authority : IAuthority
    {
        public abstract string IdFormat { get; }

        public string Login(string type, string id, string password)
        {
            return "Log in Successfull";
        }

        public string Register(string name, string type, string id, string password)
        {
            return "Registration Successfull";
        }

         
         

        public string VarsityInfo(string name , string address)
        {
            return $"{name} , {address}";
        }

         

        public Authority(  )
        {
             
        }
    }
}
