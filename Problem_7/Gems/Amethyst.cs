using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7.Gems
{
    internal class Amethyst : BaseGem
    {
        public override string Clarity { get; set; }
        public override int Strength { get; }
        public override int Agility { get; }
        public override int Vitality { get; }

        public Amethyst(string clarity)
        {
            this.Clarity = clarity;

        }

        private Amethyst()
        {
            if (this.Clarity == "Chipped")
            {
                this.Strength = 3;
                this.Agility = 9;
                this.Vitality = 5;
            }

            else if (this.Clarity == "Regular")
            {
                this.Strength = 4;
                this.Agility = 10;
                this.Vitality = 6;
            }

            else if (this.Clarity == "Perfect")
            {
                this.Strength = 7;
                this.Agility = 13;
                this.Vitality = 9;
            }

            else if (this.Clarity == "Flawless")
            {
                this.Strength = 12;
                this.Agility = 18;
                this.Vitality = 14;
            }
        }
    }    
}
