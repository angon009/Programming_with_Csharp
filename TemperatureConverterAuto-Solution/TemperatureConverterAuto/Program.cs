using System;

namespace TemperatureConverterAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============Temperature Converter=============");



            Console.WriteLine("Enter Your Choice : ");
            Console.WriteLine("Chose 1/2/3/4/5/6");


            Console.WriteLine("1. Celsius to Fahrenhet-");
            Console.WriteLine("2. Fahrenheit to Celsius-");
            Console.WriteLine("3. Celsius to Kelvin-");
            Console.WriteLine("4. Kelvin to Celsius-");
            Console.WriteLine("5. Fahrenheit to Kelvin-");
            Console.WriteLine("6. Kelvin to Fahrenheit-");

            string choice = Console.ReadLine();



            if (choice == "1")
            {
                Console.Write("Celsius = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                Console.WriteLine(tempValue);
                double fah = (9.00 / 5.00 * tempValue) + 32;

                Console.WriteLine("Fahrenheit = " + fah);
            }
            else if (choice == "2")
            {
                Console.Write("Fahrenheit = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                double cel = (5.00 / 9.00) * (tempValue - 32);

                Console.WriteLine("Celsius = " + cel);
            }
            else if (choice == "3")
            {
                Console.Write("Celsius = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                double kel = tempValue + 273;

                Console.WriteLine("Kelvin = " + kel);
            }
            else if (choice == "4")
            {
                Console.Write("Kelvin = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                double cel = tempValue - 273;

                Console.WriteLine("Celcius = " + cel);
            }
            else if (choice == "5")
            {
                Console.Write("Fahrenheit = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                double kel = ((5.00 / 9.00) * (tempValue - 32)) + 273;

                Console.WriteLine("Kelvin = " + kel);
            }
            else if (choice == "6")
            {
                Console.Write("Kelvin = ");

                string temp = Console.ReadLine();
                int tempValue = Convert.ToInt32(temp);
                double fah = ((9.00 / 5.00) * (tempValue - 273)) + 32;

                Console.WriteLine("Fahrenheit = " + fah);
            }
            else{
                Console.WriteLine("Wrong Input!!!!");
            }
        }
    }
}
