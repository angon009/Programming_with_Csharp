using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Angon Chowdhury";
            student.id = 6666;

            Console.WriteLine(student.Info());

            Teacher teacher = new Teacher();
            teacher.name = "Jalal Uddin";
            teacher.id = 1111;

            Console.WriteLine(teacher.Info());

            //student.hobby //Not Possible beacause it is a Private field//

        }
    }
}
