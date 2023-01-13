using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_6
{
    internal class TrafficLights
    {
        private string _color;

        private void ChageColor()
        {
            if (_color == "Red")
                this._color = "Green";

            else if (_color == "Green")
                this._color = "Yellow";

            else if (_color == "Yellow")
                this._color = "Red";
        }
       
    }
}
