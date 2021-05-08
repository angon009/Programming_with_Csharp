using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class Student
    {
        private string _name;
        public string Name 
        { 
            private get 
            {
                    return _name;
            }
            set 
            {
                if (value == String.Empty)
                      _name = "Undefined";
                else
                     _name = value;
            }
        }

        public int Id { get; set; }

        private string hobby; // This can be accessible only by this class

        protected int classSerial; //This can be accessible by this class and it's child class

        protected internal string className; //This can be accessible by the whole project solution and by its child 

        public string Info()
        {
            return $"Name : {Name} || ID : {Id}";
        }
    }
}
