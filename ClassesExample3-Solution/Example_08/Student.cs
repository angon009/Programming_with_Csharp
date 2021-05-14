using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_08
{
    public partial class Student
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Session { get; set; }

        public Student( string name , string department, string session)
        {
            Name = name;
            Department = department;
            Session = session;
        }

        public string StudentBasicInfo()
        {
            return $"Name : {Name} || Department : {Department} || Session : {Session}";
        }
    }
}
