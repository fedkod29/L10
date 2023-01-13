using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7
{
    public abstract class BaseGem
    {
        private int strength;
        public abstract string Clarity { get; set; }
        public abstract int Strength { get;}
        public abstract int Agility { get;}
        public abstract int Vitality { get;}
    }
}
