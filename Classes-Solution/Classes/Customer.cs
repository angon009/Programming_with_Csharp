using System;


namespace Classes
{
    public class Customer
    {
        public string customerName { get; set; }// auto - property

        public double totalPrice { get; set; }// auto - property

        public string MakeBill()
        {
            return customerName + "   Bill Amount = " + totalPrice;
        }
    }
}
