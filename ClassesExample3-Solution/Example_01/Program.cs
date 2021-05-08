using System;
using CodeLibrary;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = Console.ReadLine();
            student.Id = 6666;

            //Console.WriteLine(student.Name); //It's not possible because 'get' is private

            Console.WriteLine(student.Info());

            Teacher teacher = new Teacher();
            teacher.Name = "Jalal Uddin";
            teacher.Id = 1111;

            Console.WriteLine(teacher.Info());

            //student.hobby //Not Possible beacause it is a Private field

            //student.classSerial //Not Possible beacause it is Protected field 

            student.className = "Nine"; //field declared as Protected internal



            Class1 class1 = new Class1(); // Getting codes from dll file
            Console.WriteLine(class1.codeLib);

            Console.Write("Enter Teacher Salary = ");
            teacher.Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Salary : " + teacher.Salary);

            Admin admin = new Admin(800,5000);

            //admin.TeacherFees = 6000; // It's not possible because 'set' is 'private'
            Console.WriteLine("Teacher Salary :  " + admin.TeacherSalary);
            Console.WriteLine("Student Fees : " + admin.StudentFees);

        }
    }
}
