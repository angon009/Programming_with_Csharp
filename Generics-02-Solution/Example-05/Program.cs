using System;

namespace Example_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Cricket<ICricketer> testSachin = new Cricket<ICricketer>(new Sachin());
            Console.WriteLine(testSachin.TestAccuracy());

            Cricket<ICricketer> testTamim = new Cricket<ICricketer>(new Tamim());
            Console.WriteLine(testTamim.TestAccuracy());

            Cricket<ICricketer> testLara = new Cricket<ICricketer>(new BrainLara());
            Console.WriteLine(testLara.TestAccuracy());




            Sachin sachin = (Sachin)testSachin.experince;
            Tamim tamim = (Tamim)testTamim.experince;
            BrainLara brainLara = (BrainLara)testLara.experince;

             


             
        }
    }
}
