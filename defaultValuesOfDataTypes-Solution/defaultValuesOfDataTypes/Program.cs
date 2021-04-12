using System;

namespace defaultValuesOfDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intType = default;
            float floatType = default;
            double doubleType = default;
            double decimalType = default;

            char charType = default;
            bool boolType = default;

            Console.WriteLine("Default Values of Integer Type of Data : " + intType);
            Console.WriteLine("Default Values of Float Type of Data : " + floatType);
            Console.WriteLine("Default Values of Double Type of Data : " + doubleType);
            Console.WriteLine("Default Values of Character Type of Data : " + charType);
            Console.WriteLine("Default Values of Decimal Type of Data : " + decimalType);
            Console.WriteLine("Default Values of Boolean Type of Data : " + boolType);
        }
    }
}
