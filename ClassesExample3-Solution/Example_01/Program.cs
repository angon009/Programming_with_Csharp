using System;
using CodeLibrary;

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

            //student.hobby //Not Possible beacause it is a Private field

            //student.classSerial //Not Possible beacause it is Protected field 

            student.className = "Nine"; //field declared as Protected internal

            Class1 class1 = new Class1();

            Console.WriteLine(class1.codeLib);

        }
    }
}
