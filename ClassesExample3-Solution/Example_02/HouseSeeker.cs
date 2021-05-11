using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    public class HouseSeeker
    {
        public string seekerName { get; set; }
        private string _seekerType { get; set; }

        public string Type
        {
            private get
            {
                if (_seekerType.ToLower() == "bachelor" || _seekerType.ToLower() == "family" || _seekerType.ToLower() == "roommate")
                    return _seekerType;
                else
                    return _seekerType = "Invalid";
            }
            set
            {
                if (value.ToLower() == "bachelor" || value.ToLower() == "family" || value.ToLower() == "roommate")
                     _seekerType = value;
                else
                    _seekerType = "Invalid";
            }
        }
        public int seekerAge { get; set; }

        private string _gender;
        public string Gender
        {
            get 
            {
                if (_gender.ToLower() == "male" || _gender.ToLower() == "female")
                    return _gender;
                else
                    return _gender = "Others";
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                     _gender = value;
                else
                    _gender = "Others";
            }

        }

        public string SeekerInfo()
        {
            return $"Name : {seekerName} || Type : {Type} || Age : {seekerAge} || Gender : {Gender}";
        }



    }
}
