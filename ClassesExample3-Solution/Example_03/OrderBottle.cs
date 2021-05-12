using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class OrderBottle
    {
        public string Colour { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public int Total { get; set; }

        public readonly int maxCapacity; //Readonly variable

        public const string material = "Plastic"; // Constant variable

        public static int productionSerial = 0;


         
        //Parameterized Constructor
        public OrderBottle(string colour,double height,double weight , int maxWater)  
        {
            Colour = colour;
            Height = height;
            Weight = weight;
            maxCapacity = maxWater;
            //material = "Glass"; // Not possible because it is a const variable
            productionSerial++;
        }
        public OrderBottle(double height,double weight)  
        {
            Colour = "Transparent";
            Height = height;
            Weight = weight;
            productionSerial++;
        }
        public OrderBottle(double weight)  
            :this(100 , weight) //Constructor Chaining
        {
             
        }

        public OrderBottle()
            :this(null , 100 , 100 , 500) //Constructor Chaining
        {
            
        }

        //Desctructor , Known as "Finalizer" in C sharp
        //It is used to destroy big sized objects
        FileStream fileStream;
        ~OrderBottle()
        {
            fileStream.Dispose();
        }

        public void TestMethod()
        {
            //maxCapacity = 100; // Not possible because readonly variable can be assigned only in constructor
            //material = "Glass"; // Not possible because it is a const variable
        }
    }
}
