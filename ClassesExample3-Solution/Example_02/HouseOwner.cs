using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    public class HouseOwner
    {
        public string houseName { get; set; }
        public string houseAddress { get; set; }
        public int houseRent { get; set; }

        private int _advancePay;
        public int AdvancePay 
        {
            private get
            {
                if (_advancePay > 3 * houseRent)
                    return _advancePay = 3*houseRent;
                else
                    return _advancePay;
            }
            set
            {
                if (_advancePay > 3 * houseRent)
                    _advancePay = 3 * houseRent;
                else
                     _advancePay = value;
                 
            }
        }

        public string HouseInfo()
        {
            return $"House Name : {houseName} || Address : {houseAddress} || Rent : {houseRent} || Advance : {AdvancePay}";
        }

    }
}
