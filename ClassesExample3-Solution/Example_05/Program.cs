using System;

namespace Example_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Gadgets gadgets = new GadgetRating();

            string name = gadgets.GadgetName = "Earphone";
            string type = gadgets.GadgetType = "Mobile Accessories";
            gadgets.GadgetPrice = 250.15;

            gadgets.GadgetInfo(name , type);

            gadgets.GadgetDiscount();

            //gadgets.Reviews(); 

            GadgetsBill gadgetsBill = new GadgetRating();

            gadgetsBill.TotalSold = int.Parse(Console.ReadLine());
             
            gadgetsBill.CustomerComment = Console.ReadLine();
            gadgetsBill.Reviews();
        }
    }
}
