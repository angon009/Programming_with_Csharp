using System;
 

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(); // Creating object(instance)
            product.productName = "Angon Laptop MX100";
            product.productQuantity = 25;
            Console.WriteLine(product.TotalProduct());




            Product product2 = new Product();
            product2.productName = "Angon Headset MX150";
            product2.productQuantity = 10;
            Console.WriteLine(product2.TotalProduct());

            product2.ProductPrice = int.Parse(Console.ReadLine()); // We can use property like field
            Console.WriteLine(product2.ProductPrice);

            Console.WriteLine(product2.ProductCost);
             



            Customer customer = new Customer(); // Creating object(instance)
            customer.customerName = "Mr.John Wick";
            customer.totalPrice = 2050000; 
            Console.WriteLine(customer.MakeBill());

             

            
            
             
        }
    }
}
