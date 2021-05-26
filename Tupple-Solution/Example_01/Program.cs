using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Calculator(2,4,6,6);
            Console.WriteLine("Summation  : " + result.sum); // Console.WriteLine("Summation  : " + result.Item1);
            Console.WriteLine("Multiplication : " + result.mul); // Console.WriteLine("Multiplication : " + result.Item2);
            Console.WriteLine("Average : " + result.avrg); //Console.WriteLine("Average : " + result.Item3);
        }

        public static (int sum , int mul , double avrg) Calculator(params int[] numbers) // Tuple
        {
            int sum = 0 , mul = 1;
             
            foreach (var item in numbers)
            {
                sum = sum + item;
                mul = mul * item;
            }           
            return (sum , mul, sum * 1.0 / numbers.Length);
            
        }
    }
}
