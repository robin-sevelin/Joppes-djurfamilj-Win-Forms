using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Puppy : Dog
    {
        //fält
        public int months;

        // konstruktor
        public Puppy(int _age, int _months, string _name, string _fav_food, string _breed) : base(_age, _name, _fav_food, _breed)
        {
            this.months = _months;
        }

        // properties till fält
        public int Months { get; set; }



        public override string ToString() // skriver över basklassens returvärden
        {
            return string.Format("Namn: {0}, Ålder: {1} månader, Ras: {2}", name, months, breed); // retunerar name, months, breed

        }
    }
}
