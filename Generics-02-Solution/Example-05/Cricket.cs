using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_05
{
    public class Cricket<T> where T : ICricketer //Generic Constraint
    {
        private T _accuracy;

        public T experince
        {
            get
            {
                return _accuracy;
            }
        }

        public Cricket(T player) //Constructor
        {
            _accuracy = player;
        }
        public string TestAccuracy()
        {
            if(_accuracy.CoverDrive() <= 100 && _accuracy.Defense() >= 50 && _accuracy.LoftedDrive() >= 70 && _accuracy.StraightDrive() >= 70 )
            { 
                return "Excellent Player";
            }
            else
            {             
                return "Bad Player";
            }
        }

         



    }
}
