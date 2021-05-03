using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            PrintIdCard(teacher);

            var student = new Student();
            PrintIdCard(student);

            var admin = new Admin();
            PrintIdCard(admin);

            var support = new Support();
            PrintIdCard(support);
        }

        static void PrintIdCard(IUser user)
        {
            Console.WriteLine(user.IdFormat);
        }
    }
}
