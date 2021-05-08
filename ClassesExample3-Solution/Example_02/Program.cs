using System;

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseOwner houseOwner = new HouseOwner();

            Console.Write("Residence Name : ");
            houseOwner.houseName = Console.ReadLine();

            Console.Write("Address : ");
            houseOwner.houseAddress = Console.ReadLine();

            Console.Write("Monthly Rent : ");
            houseOwner.houseRent = int.Parse(Console.ReadLine());

            Console.Write("Advance Payment : ");
            houseOwner.AdvancePay = int.Parse(Console.ReadLine());

            Console.WriteLine("House Information : ");
            Console.WriteLine(houseOwner.HouseInfo());



            HouseSeeker houseSeeker = new HouseSeeker();

            Console.Write("Name : ");
            houseSeeker.seekerName = Console.ReadLine();

            Console.Write("Age : ");
            houseSeeker.seekerAge = int.Parse(Console.ReadLine());

            Console.Write("Type : (Bachelor,Family,Roommate)");
            houseSeeker.Type = Console.ReadLine();

            Console.Write("Gender : ");
            houseSeeker.Gender = Console.ReadLine();


            Console.WriteLine(houseSeeker.SeekerInfo());
        }
    }
}
