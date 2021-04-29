using System;

namespace generalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character Methods
            //General Methods

            char testChar1 = 'A';
            char testChar2 = 'B';
            char testChar3 = 'F';
            char testChar4 = 'g';
            char testChar5 = '3';

            //charName.CompareTo(char);   return type : int
            //To calculate difference of ASCII values of two characters

            int result = testChar1.CompareTo(testChar2);
            Console.WriteLine($"Comparing {testChar1} with {testChar2} = {result}");

            result = testChar1.CompareTo(testChar3);
            Console.WriteLine($"Comparing {testChar1} with {testChar3} = {result}");

            result = testChar1.CompareTo(testChar4);
            Console.WriteLine($"Comparing {testChar1} with {testChar4} = {result}");



            //charName.Equals(char);  return type : bool
            //To check similarity of two different characters(Boolean Result)

            bool result2 = testChar1.Equals('a');
            Console.WriteLine(result2);

            result2 = testChar5.Equals('3');
            Console.WriteLine(result2);


            //Char.GetNumericValue(charName);  return type : double
            //To convert a character type number to double type number

            double result3 = Char.GetNumericValue(testChar5);
            Console.WriteLine($"Numeric Value of {testChar5} = {result3}");


            //Char.IsDigit(charName)   return type : bool
            //To check a character is digit or not

            result2 = Char.IsDigit(testChar3);
            Console.WriteLine($"{testChar3} is digit????Answer : {result2}");

            result2 = Char.IsDigit(testChar5);
            Console.WriteLine($"{testChar5} is digit????Answer : {result2}");


            //Char.IsLetter(charName)  return type : bool
            //To check a character is letter or not

            result2 = Char.IsLetter(testChar3);
            Console.WriteLine($"{testChar3} is letter????Answer : {result2}");

            result2 = Char.IsLetter(testChar5);
            Console.WriteLine($"{testChar5} is letter????Answer : {result2}");



            //Char.IsLower(charName)  return type : bool
            //To check a character is lower case letter or not


            result2 = Char.IsLower(testChar1);

            if (result2 == true)
            {
                Console.WriteLine(testChar1 + " is a Lowercase Letter");
            }
            else {
                Console.WriteLine(testChar1 + " is a Uppercase Letter");
            }


            //Char.IsUpper(charName)  return type : bool
            //To check a character is upper case letter or not

            result2 = Char.IsLower(testChar4);

            if (result2 == true)
            {
                Console.WriteLine(testChar4 + " is a Lowercase Letter");
            }
            else
            {
                Console.WriteLine(testChar4 + " is a Uppercase Letter");
            }


            //Char.ToLower(charName) return type : char
            //To convert a character to lower case letter

            char result4 = Char.ToLower(testChar1);
            Console.WriteLine(result4);

            result4 = Char.ToUpper(testChar4);
            Console.WriteLine(result4);


        }
    }
}
