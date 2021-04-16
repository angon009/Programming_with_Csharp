using System;
 
namespace SwithStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vowel - Consonant Detector
            //By using Switch - Case Statement

            Console.Write("Enter a letter = ");
            var  Input =  Console.ReadLine();

            var letterInput = Input.ToLower(); // Tranforming to lowercase letter to lessen the number of case
            var letter = char.Parse(letterInput); //String to a single Character
            

            switch (letter)
            {
                case 'a':
                    Console.WriteLine("It's a Vowel" ) ;
                    break;
                case 'e':
                    Console.WriteLine("It's a vowel");
                    break;
                case 'i':
                    Console.WriteLine("It's a vowel");
                    break;
                case 'o':
                    Console.WriteLine("It's a vowel");
                    break;
                case 'u':
                    Console.WriteLine("It's a vowel");
                    break;
                default :
                    Console.WriteLine("It's a consonant");
                    break;

            }
        }
    }
}
