using System;

namespace Example_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            PrintId(student);


            var teacher = new Teacher();
            PrintId(teacher);


            var staff = new Staff();
            PrintId(staff);
        }

        static void PrintId(IAuthority authority)
        {
            Console.WriteLine(authority);
        }
    }
}
