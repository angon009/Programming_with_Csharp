using System;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem - 03 Solution
            //Palindrome or Not
            while (true)
            {

                string text = Console.ReadLine().ToLower();

                if (text == "end")
                {
                    break;
                }
                else
                {
                    char[] textArray = new char[text.Length];

                    for (var i = 0; i < textArray.Length; i++)
                    {
                        textArray[i] = text[i];
                    }

                    int count = 0;
                    int length = textArray.Length;


                    for (int i = 0, j = length - 1; i < length && j >= 0; i++, j--)
                    {
                        if (textArray[i] == textArray[j])
                        {
                            continue;
                        }
                        else
                        {
                            count++;
                        }

                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("Not Palindrome");
                    }
                }
            }
        }
    }
}
