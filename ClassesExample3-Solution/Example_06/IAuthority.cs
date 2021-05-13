using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public interface IAuthority
    {
        public string Register(string name, string type, string id, string password);

        public string Login(string type , string id , string password);

        public string IdFormat { get; }

        //public string testVariable; // Not possible because Interface can't contain field
        

        /*public IAuthority()
        {

        }
        */ // Not possible because Interface can't contain Constructor
    }
}
