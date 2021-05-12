using System;

namespace Example_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define colour , weight , height
            OrderBottle orderBottle1 = new OrderBottle("red",25.36,230,500);
            orderBottle1.Total = 50;
            Console.WriteLine($"Colour : {orderBottle1.Colour} || Height : {orderBottle1.Height} || Weight : {orderBottle1.Weight} || Total {orderBottle1.Total}");


            //Define weight,height
            OrderBottle orderBottle2 = new OrderBottle(30.22,200);
            orderBottle2.Total = 100;
            Console.WriteLine($"Colour : {orderBottle2.Colour} || Height : {orderBottle2.Height} || Weight : {orderBottle2.Weight} || Total {orderBottle2.Total}");


            //Define height 
            OrderBottle orderBottle3 = new OrderBottle(300);
            orderBottle3.Total = 200;
            Console.WriteLine($"Colour : {orderBottle3.Colour} || Height : {orderBottle3.Height} || Weight : {orderBottle3.Weight} || Total {orderBottle3.Total}");

            //Define nothing
            OrderBottle orderBottle4 = new OrderBottle();
            orderBottle4.Total = 100;
            Console.WriteLine($"Colour : {orderBottle4.Colour} || Height : {orderBottle4.Height} || Weight : {orderBottle4.Weight} || Total {orderBottle4.Total}");


            //readonly - const
            OrderBottle orderBottle5 = new OrderBottle();

            //orderBottle5.maxCapacity = 100; // Not possible because readonly variable can be assigned only in constructor
            //orderBottle5.material = "Glass"; // Not possible because it is a const variable


            Console.WriteLine(OrderBottle.productionSerial);

             
        }
    }
}
