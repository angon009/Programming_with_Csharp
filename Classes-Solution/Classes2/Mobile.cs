using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Mobile
    {
        public string mobileName { get; set; }

        public string mobileCategory { get; private set; }

        public int mobileRating { private get;  set; }

        public double mobileWeight { get; private set; }

        public Mobile(string category , double weight)  // Parameterized Property
        {
            mobileCategory = category;
            mobileWeight = weight;
        }

        public Mobile( ) // Empty Constructor || It is used to set default parameter
        {
            mobileCategory = "Hongmeng";
            mobileName = "Huawei";
            mobileWeight = 300;
        }



    }
}
