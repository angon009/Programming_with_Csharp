using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes3
{
    public class Authority
    {

        public string CgpaRule(double cgpa) // Method
        {
            if (cgpa < 2.00)
                return "Suspended";
            else
                return "OK";
        }



        public double TeacherSalary(double teacherSalary) // Method
        {

            if (teacherSalary >= 20000)
                return  teacherSalary - 800;
            else
                return teacherSalary;

        }

        public double StudentWaiver(double cgpa) //Method
        {
            if (cgpa >= 3.50)
                return 10000;
            else
                return 0;
        }


    }
}
