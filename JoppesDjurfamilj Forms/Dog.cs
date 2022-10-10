using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Dog : Animals
    {
        // konstruktor
        public Dog(int _age, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {

        }


        public override string ToString() // basklassens returvärden
        {
            return base.ToString();
        }
    }
}
