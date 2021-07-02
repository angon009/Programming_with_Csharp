using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class Course
    {
        public int courseId { get; set; }
        public decimal courseFee { get; set; }
        public DateTime courseStartDate { get; set; }
        public List<Student> enrolledStudents { get; set; }
    }
}
