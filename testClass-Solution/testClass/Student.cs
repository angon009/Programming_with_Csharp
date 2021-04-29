using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClass
{
    public class Student
    {
        public string studentName;

        public int studentID;

        public string StudentInfo()
        {
            return studentName + " ID : " + studentID;
        }

    }
}
