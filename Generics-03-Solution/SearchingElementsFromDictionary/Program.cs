using System;
using System.Collections.Generic;

namespace SearchingElementsFromDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> result = new Dictionary<int, double>(10);

            result.Add(101 , 3.68);
            result.Add(102 , 3.28);
            result.Add(103 , 3);
            result.Add(104 , 2.7);
            result.Add(105 , 3.98);
            result.Add(106 , 4.00);
            result.Add(107 , 1.34);

            //searching by keys
            Console.Write("Enter Your Id : ");
            int id = int.Parse(Console.ReadLine());

            if(result.ContainsKey(id))
            {
                Console.WriteLine("Your CGPA : " + result[id]);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            //searching by values
            Console.Write("Enter CGPA : ");
            double cg = double.Parse(Console.ReadLine());

            if(result.ContainsValue(cg))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            
        }
    }
}
