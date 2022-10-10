using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Ball
    {
        // fält
        private string color;

        // kostruktor
        public Ball(string _color)
        {
            color = _color;
        }

        // properties till fält
        public string Color { get; set; }


        public override string ToString() // returvärden
        {
            return string.Format("{0}", color); // retunerar color
        }
    }
}
