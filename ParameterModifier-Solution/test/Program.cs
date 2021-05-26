using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem-03 Solution
            while (true)
            {
                string text = Console.ReadLine().ToLower();

                char[] charArray = new char[text.Length];

                for (var i = 0; i < text.Length; i++)
                {
                    charArray[i] = text[i];
                }

                int length = text.Length, count = 0;


                if (text == "end")
                {
                    break;
                }
                else
                {
                    for (int i = 0, j = length - 1; i < length && j >= 0; i++, j--)
                    {
                        if (charArray[i] == charArray[j])
                        {
                            count++;
                        }
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine("Not Palindrome");
                }
                else
                {
                    Console.WriteLine("Palindrome");
                }
            }

        }
    }
}