using System;

namespace _02_c
{
    class Program
    {
        public static string getCondensedName(string fullName)
        {
            string condensedName = string.Empty;
            string[] splittedName = fullName.Split(' ');

            condensedName += splittedName[0] + " ";

            for (int i = 1; i < splittedName.Length; i++)
            {
                condensedName += char.ToUpper(splittedName[i][0]) + ". ";
            }
            return condensedName;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string condensedName = getCondensedName(name);
            Console.WriteLine(condensedName);
        }
    }
}
