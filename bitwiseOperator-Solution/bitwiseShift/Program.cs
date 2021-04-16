using System;

namespace bitwiseShift
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bitwise Shifting

            while (true)
            {
                Console.Write("Enter a number = ");
                int input = int.Parse(Console.ReadLine());

                Console.Write("How many bit left Shifting = ");
                int leftShiftBit = int.Parse(Console.ReadLine());

                Console.Write("How many bit right shifting = ");
                int rightShiftBit = int.Parse(Console.ReadLine());

                int leftShiftResult = input << leftShiftBit; // Left Shifting // Symbol pointing to left
                int rightShiftResult = input >> rightShiftBit; // Right Shifting // Symbol pointing to right


                Console.WriteLine("After " + leftShiftBit + "-bit Left Shifting = " + leftShiftResult);
                Console.WriteLine("After " + rightShiftBit + "-bit Right Shifting = " + rightShiftResult);
                
                /*
                 *Mathematical Observation of Arithmetic Bit Shifting
                 *For Left Shifting : number * (2 * how much bit shifting);
                 *For Right Shifting : int (number / (2 * how much bit shifting));
                 */
            } 


        }
    }
}
