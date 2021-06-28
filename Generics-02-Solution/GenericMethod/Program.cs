using System;

namespace GenericMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Receipe receipe = new Receipe();

            var result1 = receipe.TestTaste<Taste, Level>(new Level());
             
            var result2 = receipe.TestTaste<Taste, Level>(null);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            
        }
    }
}
