using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloodDonationManagement
{
    public class Receiver
    {
        public string receiverName;
        public string receiverCity;
        public int receiverAge;

        public string receiverGender;
        public string receiverBloodGroup;
        
        public string ReceiverPersonalInfo()
        {
            return $"Name : {receiverName} || Age : {receiverAge} || Address : {receiverCity}";
        }

        public string ReceiverHealthInfo()
        {
            return $"Gender : {receiverGender} || Blood Group : {receiverBloodGroup}";
        }


    }
}
