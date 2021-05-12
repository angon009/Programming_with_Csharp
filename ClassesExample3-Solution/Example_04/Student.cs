using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_04
{
    public class Student : Admin
    {
        public override string StudentFees(int studentClass, int totalSubject)
        {
            return $"Fees : {studentClass * totalSubject + 1000}";
        } 
    }
}
