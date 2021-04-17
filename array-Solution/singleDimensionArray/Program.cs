using System;

namespace singleDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            //Array Declarization

            /*int[] firstArray = new int[20];
            Console.WriteLine(firstArray.Length);

            firstArray[0] = 2;
            firstArray[1] = 2;
            firstArray[2] = 2;
            firstArray[19] = 2;
            firstArray[18] = 2;
             

            int[] secondArray = new int[] {1 , 2 , 3 , 4 , 5 , 6};
            Console.WriteLine(secondArray.Length);

            int[] thirdArray = {1 , 3 , 5 , 7 , 9};
            Console.WriteLine(thirdArray.Length);

            Console.Write("Size = ");
            int size = int.Parse(Console.ReadLine()); //Taking the size of array
            int[] fourthArray = new int[size];

            Console.WriteLine("Enter the values of the Array : ");
            for(var i = 0; i < size; i++) //Taking elements for that array
            {
                Console.Write("Array[" + i + "] = ");
                int values = int.Parse(Console.ReadLine());  // Assigning Values 
                fourthArray[i] = values;
            }
            Console.WriteLine("Created Array : "); //Showing elements of that array
            for(var i = 0; i < size; i++)
            {
                Console.Write(fourthArray[i] + "  ");
            }
            */

            //Creating a string by using Array

            char[] countryName = new char[10];

            for(var i = 0; i < 10; i++) // Taking Characters
            {
                Console.Write("Enter the " + (i+1) + "'th Letter of your Country : ");
                char letter = char.Parse(Console.ReadLine().ToUpper());
                countryName[i] = letter;
            }

            Console.Write("Your Country Name : ");
            for(var i = 0; i < 10; i++) // Showing Characters like a single String
            {
                Console.Write(countryName[i]);
            }
            


           


        }
    }
}
