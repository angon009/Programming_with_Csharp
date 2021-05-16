using System;

namespace Example_05
{
    class Program
    {
        public enum Gender : short
        {
            Male,
            Female,
            Others
        }

        public enum PaymentType
        {
            CashOnDelivery,
            MobileBanking,
            CardPayment
        }

        public static Gender SetGender { get; set; } = Gender.Others;
                                                       //Default Selection
        public static PaymentType Payment { get; set; } = PaymentType.CashOnDelivery;
                                                          //Default Selection
        static void Main(string[] args)
        {
            GenderSelection();
            PaymentTypeSelection();

        }

        public static void GenderSelection()
        {
            var male = Gender.Male;
            Console.WriteLine(male);

            var female = Gender.Female;
            Console.WriteLine(female);

            var others = Gender.Others;
            Console.WriteLine(others);
        }

        public static void PaymentTypeSelection()
        {
            var cash = PaymentType.CashOnDelivery;
            Console.WriteLine(cash);

            var mkash = PaymentType.MobileBanking;
            Console.WriteLine(mkash);

            var card = PaymentType.CardPayment;
            Console.WriteLine(card);
        }
    }
}
