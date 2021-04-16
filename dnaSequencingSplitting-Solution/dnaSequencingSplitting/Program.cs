using System;

namespace dnaSequencingSplitting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DNA Sequence Splitting");

            Console.WriteLine("Enter Sequence : ");
            var sequence = Console.ReadLine();

            var result = sequence.Split(':');

            var nucleotidePart = int.Parse(result[0]);
            var nucleosidePart = double.Parse(result[1]);
            var satChrormosome = decimal.Parse(result[2]);
            var isXYChromsomePresent = bool.Parse(result[3]);

            Console.WriteLine(nucleotidePart);
            Console.WriteLine(nucleosidePart);
            Console.WriteLine(satChrormosome);
            Console.WriteLine(isXYChromsomePresent);



        }
    }
}
