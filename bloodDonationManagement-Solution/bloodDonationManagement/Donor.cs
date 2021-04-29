using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloodDonationManagement
{
    public class Donor
    {
        public string donorName;
        public string donorGender;
        public string donorCity;


        public string donorBloodGroup;
        public int donorWeight;
        public int donorAge;
         

        public string DonorHealthInfo()
        {
            return $"Blood Group : {donorBloodGroup} || Age : {donorAge} || Weight : {donorWeight}";
        }

        public string DonorPersonalInfo()
        {
            return $"Name : {donorName} || Gender : {donorGender} || Address : {donorCity}";
        }

    }
}
