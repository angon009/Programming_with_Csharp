using System;

namespace bloodDonationManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is Main Class

            Console.WriteLine("Sign- Up as : ");
            Console.WriteLine("1. Blood Donor ");
            Console.WriteLine("2. Blood Receiver ");
            int userType = int.Parse(Console.ReadLine());


            Donor donor = new Donor();
            Receiver receiver = new Receiver();

            //Creating Donors Profile
            if (userType == 1)
            {
                

                Console.Write("Enter Name : ");
                donor.donorName = Console.ReadLine();

                Console.Write("Enter Gender : ");
                donor.donorGender = Console.ReadLine();

                Console.Write("Enter City Name : ");
                donor.donorCity = Console.ReadLine();

                Console.Write("Enter Blood Group : ");
                donor.donorBloodGroup = Console.ReadLine();

                Console.Write("Enter Weight : ");
                donor.donorWeight = int.Parse(Console.ReadLine());

                Console.Write("Enter Age : ");
                donor.donorAge = int.Parse(Console.ReadLine());
            }
            //Creating Receivers Profile
            else 
            {
                 

                Console.Write("Enter Name : ");
                receiver.receiverName = Console.ReadLine();

                Console.Write("Enter City : ");
                receiver.receiverCity = Console.ReadLine();

                Console.Write("Enter Age : ");
                receiver.receiverAge = int.Parse(Console.ReadLine());

                Console.Write("Enter Gender : ");
                receiver.receiverGender = Console.ReadLine();

                Console.Write("Enter Blood Group : ");
                receiver.receiverBloodGroup = Console.ReadLine();
            }

            //Showing Profile

            if (userType == 1) 
            {
                Console.WriteLine(donor.DonorHealthInfo());
                Console.WriteLine(donor.DonorPersonalInfo());
            }
            else 
            {
                Console.WriteLine(receiver.ReceiverHealthInfo());
                Console.WriteLine(receiver.ReceiverPersonalInfo());
            }
             
             
        }
    }
}
