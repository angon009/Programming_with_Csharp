using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public class Teacher : Authority , IAuthority
    {
        public int teacherSalary { get; set; }
        public override string IdFormat
        {
            get
            {
                return "T-";
            }
        }
        public string TeacherInfo(string name, string id, string department)
        {
            return $"Name : {name} || ID : {id} || Department : {department}";
        }
    }
}
