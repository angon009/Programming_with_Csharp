﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Ronaldo : IStriker
    {
        public string level;
        public void Pass()
        {
            level = "high";
        }
        public void Shoot()
        {
            level = "high";
        }
        public void Dribble()
        {
            level = "medium";
        }
        public void Freekick()
        {
            level = "medium";
        }
    }
}
