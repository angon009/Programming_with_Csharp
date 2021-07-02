using System;

namespace Example_03
{
    class Program
    {
        static void Main(string[] args)
        {
            DbContextConfig context = new DbContextConfig();

            #region Adding Data in Product Table

            //var product = new Product();
            //product.productType = "Biscuits";
            //product.expireDate = DateTime.Parse("07-10-2021");

            //context.products.Add(product);
            //context.SaveChanges();


            //var product2 = new Product();
            //product2.productType = "Fruits";
            //product2.expireDate = DateTime.Parse("07-07-2021");

            //context.products.Add(product2);
            //context.SaveChanges();


            //var product3 = new Product();
            //product3.productType = "Mashroom";
            //product3.expireDate = DateTime.Parse("07-15-2021");

            //context.products.Add(product3);
            //context.SaveChanges();
            #endregion


            #region Adding Data in BuyerTable

            //var buyer = new Buyer();
            //buyer.name = "Osman";
            //buyer.purchaseDate = DateTime.Parse("07-05-2021");

            //context.buyers.Add(buyer);
            //context.SaveChanges();

            //var buyer2 = new Buyer();
            //buyer2.name = "Osman";
            //buyer2.purchaseDate = DateTime.Parse("07-05-2021");

            //context.buyers.Add(buyer2);
            //context.SaveChanges();


            //var buyer3 = new Buyer();
            //buyer3.name = "Abu";
            //buyer3.purchaseDate = DateTime.Parse("07-05-2021");

            //context.buyers.Add(buyer3);
            //context.SaveChanges();


            //var buyer4 = new Buyer();
            //buyer4.name = "Devendra";
            //buyer4.purchaseDate = DateTime.Parse("07-05-2021");

            //context.buyers.Add(buyer4);
            //context.SaveChanges();
            #endregion


            #region Adding data in Seller table
            //var seller1 = new Seller();
            //seller1.name = "Manmohon";
            //seller1.license = "BRTC BSTI GOVt";

            //context.sellers.Add(seller1);
            //context.SaveChanges();


            //var seller2 = new Seller();
            //seller2.name = "Muhammad";
            //seller2.license = "BUET BSTI GOVT";

            //context.sellers.Add(seller2);
            //context.SaveChanges();
            #endregion
        }
    }
}
