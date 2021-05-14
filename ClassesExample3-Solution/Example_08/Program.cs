using System;

namespace Example_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Angon" , "CSE" , "Spring");

            Console.WriteLine(student.StudentBasicInfo());

            student.ShowID();

            Student student1 = new Student();
            
        }
    }
}
