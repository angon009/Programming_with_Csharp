using System;

namespace ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer 
            { 
                Name = "Angon",
                Product = "Mobile" 
            };

            Customer customer2 = customer1; // It will copy the memory address
             
            customer1.Name = "John";
            customer1.Product = "Laptop";

            Console.WriteLine($"Customer 01 Name : {customer1.Name} Product : {customer1.Product}");
            Console.WriteLine($"Customer 02 Name : {customer2.Name} Product : {customer2.Product}");

            //In reference type copy it actualy copy the memory address.It does not create another variable or value, its just copy the address 

            customer2.Name = "Kevin";
            customer2.Product = "Earphone";

            //Even any change on any object will change other object

            Console.WriteLine($"Customer 01 Name : {customer1.Name} Product : {customer1.Product}");
            Console.WriteLine($"Customer 02 Name : {customer2.Name} Product : {customer2.Product}");

        }

         
    }
}
