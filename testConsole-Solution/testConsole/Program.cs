using System;

namespace testConsole
{
    class Program
    {
		static double func(double x)
		{
			return x * x * x - 9 * x + 1;
		}


		static void bisection(double a, double b)
		{
			if (func(a) * func(b) >= 0)
			{
                Console.WriteLine("You have not assumed right a and b");
				return;
			}

			double c = a;
			while ((b - a) >= 0.0005)
			{

				c = (a + b) / 2;


				if (func(c) == 0.0)
					break;


				else if (func(c) * func(a) < 0)
					b = c;
				else
					a = c;
			}
            Console.WriteLine("The value of root is : " + c);
		}
		static void Main(string[] args)
        {
            Console.Write("a = ");
			double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
			double b = double.Parse(Console.ReadLine());
			
			bisection(a, b);
		}
    }
}
