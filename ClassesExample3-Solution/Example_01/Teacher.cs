using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class Teacher   // Class can't be declared as Private,Protected,Protected internal
    {
        public string name; 

        public int id; 

        public string Info()
        {
            return $"Name : {name} || ID : {id}";
        }

        //Default type of field and methods are "Private"
        //Default type of Class are "Internal"
    }
}
