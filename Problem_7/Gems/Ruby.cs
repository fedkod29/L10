using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Problem_7.Gems
{
    internal class Ruby : BaseGem
    {
        public override string Clarity { get; set; }
        public override int Strength { get;}
        public override int Agility { get;}
        public override int Vitality { get;}

        public Ruby(string clarity)
        {
            this.Clarity = clarity;
        }

        private Ruby()
        {
            if(this.Clarity == "Chipped")
            {
                this.Strength = 8;
                this.Agility = 3;
                this.Vitality = 6;
            }

            else if (this.Clarity == "Regular")
            {
                this.Strength = 9;
                this.Agility = 4;
                this.Vitality = 7;
            }

            else if (this.Clarity == "Perfect")
            {
                this.Strength = 12;
                this.Agility = 7;
                this.Vitality = 10;
            }

            else if (this.Clarity == "Flawless")
            {
                this.Strength = 17;
                this.Agility = 12;
                this.Vitality = 16;
            }
        }
    }
}
