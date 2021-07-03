using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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

            #region Making Relationship with Buyer table and Product id

            ////Creating new Buyer
            //var buyer = new Buyer();
            //buyer.name = "Rahim Uddin";
            //buyer.totalBill = 345;
            //buyer.purchaseDate = DateTime.Now;

            ////Creating new Product and adding a product in buyer table
            //var product = new Product();
            //product.productType = "Vegetables";
            //product.expireDate = DateTime.Parse("07-04-2021");

            //product.sellList = new List<Buyer>();
            //product.sellList.Add(buyer);

            //context.products.Add(product);
            //context.SaveChanges();
            #endregion

            #region Picking up a buyers's table data from product table

            //var products = context.products.Where(x => x.productType == "Vegetables")
            //    .Include("sellList").FirstOrDefault();

            #endregion


            var buyer = new Buyer();
            buyer.name = "Rahim Uddin";
            buyer.totalBill = 345;
            buyer.purchaseDate = DateTime.Now;


            var productSell = new BuyerProduct();
            productSell.buyer = buyer;
            productSell.purchaseDate = DateTime.Now;

            
            var product = new Product();
            product.productType = "Vegetables";
            product.expireDate = DateTime.Parse("07-04-2021");

            product.ProductBuyers = new List<BuyerProduct>();
            product.ProductBuyers.Add(productSell);

            context.products.Add(product);
            context.SaveChanges();
            Console.WriteLine("Done");

        }
    }
}
