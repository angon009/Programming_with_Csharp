using System;

namespace Example_09
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Season<Summer, Spring>();

            // Though the constraint of V is Summer but Spring is also possible because Spring is the child of Summer

            var test2 = new Season<Spring, Autumn>();

            // Though the constraint of V is Summer but Autumn is also possible because Autumn is the child of Spring

        }
    }
}
