using System;
using System.Text;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Important String Methods



            //For converting an string to a character type array
            //stringName.ToCharArray();

            string myName = "Angon Chowdhury";

            char[] myNameArray = myName.ToCharArray();

            for (var i = 0; i < myNameArray.Length; i++)
            {
                Console.WriteLine(myNameArray[i]);
            }




            //To find the index number of a character from a string
            //stringName.IndexOf(char);    stringName.IndexOf(char , index)

            int position = myName.IndexOf("d");
            Console.WriteLine($"index of d is {position}"); // Index will start from 0

            int position2 = myName.IndexOf("n", 2); // It will show the index after certain position
                                                    //It is used to find the position of repeated character

            Console.WriteLine($"index of n after 2nd position = {position2}");





            //Trimming of string
            //stringName.Trim(characters);

            string demoString = "----Angon----Chowdhury-----";
            string trimmedString = demoString.Trim('-'); //It will cut the '-' from both sides but not from middle

            Console.WriteLine(trimmedString);

            string demoString2 = "       Angon      Chowdhury";
            string trimmedString2 = demoString2.Trim();//It will the spaces from both side but not from middle

            Console.WriteLine(trimmedString2);

            string demoString3 = "----~~~Angon--~~Chowdhury~~~---___%%^^";
            string trimmedString3 = demoString3.Trim('-', '~', '_', '%', '^');//It will cut multiple type of characters from both side

            Console.WriteLine(trimmedString3);




            //Replace a character with another character in a string
            //stringName.Replace(char , char);


            string fullName = "AngonChowdhury";
            fullName = fullName.Replace("C", " K"); //It will replace C with <space>K

            Console.WriteLine(fullName);



            //Find a substring from a string
            //stringName.Substring(index);

            //To find last name of name
            string fullName2 = "Angon Chowdhury";
            int spacePosition = fullName2.IndexOf(' ');

            fullName2 = fullName2.Substring(spacePosition + 1); //It will cut the string after space

            Console.WriteLine("Last Name = " + fullName2);


            //Find index of any character from a string
            //stringName.indexOfAny(new char[]{elements,....,....})

            string countryName = "Bangladeshe";
            int indexNumber = countryName.IndexOfAny(new char[] { 'a', 'd','e'});

            Console.WriteLine(indexNumber);






           
        }
    }
}
