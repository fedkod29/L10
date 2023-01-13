using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7.Gems
{
    internal class Emerald : BaseGem
    {
        public override string Clarity { get; set; }
        public override int Strength { get; }
        public override int Agility { get; }
        public override int Vitality { get; }

        public Emerald(string clarity)
        {
            this.Clarity = clarity;
        }

        private Emerald()
        {
            if (this.Clarity == "Chipped")
            {
                this.Strength = 2;
                this.Agility = 5;
                this.Vitality = 10;
            }

            else if (this.Clarity == "Regular")
            {
                this.Strength = 3;
                this.Agility = 6;
                this.Vitality = 11;
            }

            else if (this.Clarity == "Perfect")
            {
                this.Strength = 6;
                this.Agility = 9;
                this.Vitality = 14;
            }

            else if (this.Clarity == "Flawless")
            {
                this.Strength = 11;
                this.Agility = 14;
                this.Vitality = 19;
            }
        }
    }
}
