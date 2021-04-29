using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClass
{
    class Teacher
    {
        public string subjectName;

        public string teacherTitle;

        public int teacherId;

        public string TeachersInfo()
        {
            return subjectName + " Title : " + teacherTitle + " Id : " + teacherId;
        }
    }
}
