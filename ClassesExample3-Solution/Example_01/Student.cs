using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class Student
    {
        public string name;

        public int id;

        public string Info()
        {
            return $"Name : {name} || ID : {id}";
        }
    }
}
