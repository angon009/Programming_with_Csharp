using System;
 

namespace Classes
{
    public class Product
    {
        //Field Declaration
        public string productName { get; set; } // auto-property


        public double productQuantity { get; set; } // auto - property


        public string TotalProduct()
        {
            return productName + " = " + productQuantity;
        }

        protected double productRating { get; set; }// auto - property


        //Property
        private double _productPrice;

        public double ProductPrice
        {
            get
            {
                if (_productPrice <= 200)
                    return _productPrice = 300;
                else
                    return _productPrice;
            }
            set
            {
                if (value <= 200)
                    _productPrice = 300;
                else
                    _productPrice = value;
            }
        }

        public string ProductCost
        {
            get
            {
                return $"Product Name : {productName} || Product Cost : {_productPrice}";
            }
        }
   
    }
}
