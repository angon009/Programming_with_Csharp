using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile("Android" , 200.35);

            Console.Write("Enter Mobile Brand Name : ");
            var brand = mobile.mobileName = Console.ReadLine();

            Console.Write("Enter Mobile Rating : ");
            var rating = mobile.mobileRating = int.Parse(Console.ReadLine());

            Console.WriteLine($"Brand : {brand} || OS : {mobile.mobileCategory} || Rating : {rating} || Weight : {mobile.mobileWeight}");

            Mobile mobile2 = new Mobile();
             

            Console.Write("Enter Mobile Rating : ");
            var rating2 = mobile.mobileRating = int.Parse(Console.ReadLine());

            Console.WriteLine($"Brand : {mobile2.mobileName} || OS : {mobile2.mobileCategory} || Rating : {rating2} || Weight : {mobile2.mobileWeight}");
        }
    }
}
