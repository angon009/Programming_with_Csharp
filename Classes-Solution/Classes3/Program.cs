using System;

namespace Classes3
{
    class Program
    {
        static int v = 10;
        static void Main(string[] args)
        {
            Authority authority = new Authority();



            Console.Write("Student Name : ");
            string studentName = Console.ReadLine();

            Console.Write("Student ID : ");
            string studentId = Console.ReadLine();

            Console.Write("Student CGPA : ");
            double studentCgpa = double.Parse(Console.ReadLine());

            Student student = new Student(studentName,studentId,studentCgpa);

            Console.WriteLine(student.StudentInfo());
            Console.WriteLine("Status : " + authority.CgpaRule(studentCgpa));
            Console.WriteLine("Waiver : " + authority.StudentWaiver(studentCgpa));

             

            Console.Write("Teacher Name : ");
            string teacherName = Console.ReadLine();

            Console.Write("Teacher ID : ");
            string teacherId = Console.ReadLine();

            Console.Write("Teacher Basic : ");
            double teacherSalary = double.Parse(Console.ReadLine());

            Teacher teacher = new Teacher(teacherId, teacherName,teacherSalary);

            Console.WriteLine(teacher.TeacherInfo());
            Console.WriteLine("Salary : " + authority.TeacherSalary(teacherSalary));
           

        }
    }
}
