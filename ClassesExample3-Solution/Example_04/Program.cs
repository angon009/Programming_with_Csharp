using System;

namespace Example_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Admin admin = new Admin(); // Not Possible because we can't create instance for abstract class


            Admin admin = new Student();
            Student student  = new Student(); // We can assign child class in base class


            //Student student1 = new Admin(); // Not possible because We can't assign base class in child class

             
            Console.WriteLine($"{student.StudentInfo("Angon" , 6)} || {student.StudentFees(10,5)}");
            Console.WriteLine($"{admin.StudentInfo("Angon", 6)} || {admin.StudentFees(10, 5)}");



        }
    }
}
