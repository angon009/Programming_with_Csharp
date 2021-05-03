using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClassExample
{
    public class Student : UserType
    {
        public override string userInfo(string name, string type, string category)
        {
            return $"Name : {name} || Type : {type} || Category : {category}";
        }
    }
}
