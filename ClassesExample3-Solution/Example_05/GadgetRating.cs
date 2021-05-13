using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_05
{
    public class GadgetRating : GadgetsBill
    {
        private string Rating()
        {
            if(TotalSold >= 100 && CustomerComment != "bad")
            {
                return "Good Product";
            }
            else
            {
                return "Bad Product";
            }
        }
        public override void Reviews()
        {
            Console.WriteLine($"{Rating()} || Comments : {CustomerComment}");
        }
    }
}
