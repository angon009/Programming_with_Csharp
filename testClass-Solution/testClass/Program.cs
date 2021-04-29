using System;

namespace testClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Main Class
            Teacher teacher = new Teacher();
            teacher.subjectName = "Programming";
            teacher.teacherId = 1234;
            teacher.teacherTitle = "Lecturer";

            Console.WriteLine(teacher.TeachersInfo());

            Student student = new Student();
            student.studentName = "Angon Chowdhury";
            student.studentID = 181006;

            Console.WriteLine(student.StudentInfo());
        }
    }
}
