using System;
using System.Text; 

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*All types of string modification will create a new string after each modification
            But old string remains as before internally
            So if you do so many modification on string it will create too many string which
            will take spaces from your computer*/

            //StringBuilder(A special data structure and a special data type)
            //StringBuilder don't create a new string after modification


            //Header file : using System.Text;


            //StringBuilder declaration
            StringBuilder builderString = new StringBuilder();


            //StringBuilder Example

            string dnaSequence = "ATGCCGAAATTTCCCGGAATATCCGCGCGATTCG";

            StringBuilder dnaSequenceBuilder = new StringBuilder(dnaSequence);

            //Replace all T with U
            for (var i = 0; i < dnaSequence.Length; i++)
            {
                if (dnaSequenceBuilder[i] == 'T')
                {
                    dnaSequenceBuilder[i] = 'U';
                }
            }
            dnaSequence = dnaSequenceBuilder.ToString();
            Console.WriteLine(dnaSequence);
        }
    }
}
