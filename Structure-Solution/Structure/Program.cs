using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Name = "Angon",
                ProductType = "Mobile",
                ProductPrice = 1700.50
            };

            Customer customer2 = customer1;

            customer1.Name = "John";
            customer1.ProductType = "Laptop";
            customer1.ProductPrice = 332.66;


            Console.WriteLine($"Customer 1 Name : {customer1.Name} Type : {customer1.ProductType} Price : {customer1.ProductPrice}");
            Console.WriteLine($"Customer 2 Name : {customer2.Name} Type : {customer2.ProductType} Price : {customer2.ProductPrice}");

            customer2.Name = "Kevin";
            customer2.ProductType = "Earphone";
            customer2.ProductPrice = 33232.66;

            Console.WriteLine($"Customer 1 Name : {customer1.Name} Type : {customer1.ProductType} Price : {customer1.ProductPrice}");
            Console.WriteLine($"Customer 2 Name : {customer2.Name} Type : {customer2.ProductType} Price : {customer2.ProductPrice}");


            var OwnerTest = new Owner() { ProductPrice = 100 };
            var CustomerTest = new Customer() { ProductPrice = 100 };

            Modify(OwnerTest);
            Modify(CustomerTest);
             

            Console.WriteLine(OwnerTest.ProductPrice);
            Console.WriteLine(CustomerTest.ProductPrice);
             


        }
        //Using class as Reference type
        public static void Modify(Owner owner)
        {
            owner.ProductPrice = 500;
        }
        //Using class(structure) as Value Type
        public static void Modify(Customer customer) 
        {
            customer.ProductPrice = 500;
        }
         
    }
}
 