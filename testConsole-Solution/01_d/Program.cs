using System;

namespace _01_d
{
    class Student
    {
        public string name;
        public int semester;
        public string address;


        public void Show()
        {
            Console.WriteLine($"{name}       {semester}        {address}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            first.name = "Sumon";
            first.semester = 2;
            first.address = "Bombay, India";

            Student second = new Student();
            second.name = "Hassan";
            second.semester = 1;
            second.address = "Dhaka, Bangladesh ";

            Student third = new Student();
            third.name = "Ahad";
            third.semester = 3;
            third.address = "Kuala lumpur, Malaysia";


            Console.WriteLine("Name       Semester        Address");
            Console.WriteLine("===================================");
            first.Show();
            second.Show();
            third.Show();

        }
    }
}
