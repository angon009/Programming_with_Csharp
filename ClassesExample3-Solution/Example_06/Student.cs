using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public class Student : Authority , IAuthority
    {
        public int studentFees { get; set; }

        public override string IdFormat
        {
            get
            {
                return "S-";
            }
        }

        public string StudentInfo(string name, string id, string department)
        {
            return $"Name : {name} || {id} || {department}";
        }

         

        
    }
}
