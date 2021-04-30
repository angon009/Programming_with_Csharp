using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Student
    {
        public string studentName { get; set; } // Auto Property
        public string studentId { get; set; } // Auto Property
        public double studentCgpa { get; set; } // Auto Property

        public string StudentInfo() // Method
        {
            return $"Name : {studentName} || ID : {studentId} || CGPA : {studentCgpa}";
        }

        public Student(string name,string id, double cgpa) // Parameterized Constructor
        {
            studentName = name;
            studentId = id;
            studentCgpa = cgpa;
        }

        public Student() // Empty Constructor
        {
            studentName = "Not Registered";
            studentId = "Not Registered";
            studentCgpa = 0.00;
        }

    }
}
