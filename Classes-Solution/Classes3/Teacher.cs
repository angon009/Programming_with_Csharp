using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Teacher
    {
        public string teacherName { get; set; } // Auto Property
        public string teacherId { get; set; }// Auto Property
        public string courseName { get; set; }// Auto Property
        public double totalSalary { get; set; }// Auto Property

        public string TeacherInfo()//Method
        {
            return $"Name : {teacherName} || ID : {teacherId} || Course : {courseName}";
        }

        public Teacher(string id, string name , double total) // Parameterized Constructor
        {
            teacherName = name;
            teacherId = id;
            courseName = "Not Taken";
            totalSalary = total;

        }

    }
}
