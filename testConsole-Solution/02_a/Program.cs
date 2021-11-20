using System;

namespace _02_a
{
    public class K
    {
        static int object_no = 0;
        private char ch;

        public K(char ch)
        {
            Console.WriteLine($"Constructing K #{++object_no}");
            this.ch = ch;
        }
    }
    class Program
    {
        public static K make_k(char ch)
        {
            return new K(ch);
        }
        static void Main(string[] args)
        {
            K k1 = make_k('a');
            K k2 = make_k('b');
            K k3 = make_k('c');
        }
    }
}
