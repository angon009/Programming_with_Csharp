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

        private string hobby; // This can be accessible only by this class

        protected int classSerial; //This can be accessible by this class and it's child class

        public string Info()
        {
            return $"Name : {name} || ID : {id}";
        }
    }
}
