using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Cat : Animals
    {

        //konstruktor
        public Cat(int _age, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {

        }

        public override string Interact() // skriver över basklassens interact
        {
            if (hungry)
            {
                return string.Format("{0}, {0} är hungring och vill inte leka", name); // retunerar name

            }

            return string.Format(", {0} leker hellre med sitt snöre", name); // retunenrar name
        }

        public override string ToString() // basklassens returvärden
        {
            return base.ToString();
        }
    }
}
