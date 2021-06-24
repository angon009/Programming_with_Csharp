using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Messi : IStriker
    {
        public string level;
        public void Pass()
        {
            level = "high";
        }
        public void Shoot()
        {
            level = "medium";
        }
        public void Dribble()
        {
            level = "high";
        }
        public void Freekick()
        {
            level = "high";
        }
    }
}
