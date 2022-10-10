using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    abstract class Animals
    {
        // fält med defaulta värden
        protected int age;
        protected string name;
        protected string fav_food;
        protected string breed;
        protected bool hungry = true;


        // konstruktor
        public Animals(int _age, string _name, string _fav_food, string _breed)
        {
            this.age = _age;
            this.name = _name;
            this.fav_food = _fav_food;
            this.breed = _breed;
        }

        // properties till fält
        public int Age { get; set; }
        public string Name { get; set; }
        public string Fav_food { get; set; }
        public string Breed { get; set; }
        public bool Hungry { get; set; }


        public virtual string Interact() // metod för att leka med djur
        {
            
            if(hungry)
            {
                hungry = true;
                return string.Format("{0}, {0} är hungring och vill inte leka", name); // om djuret är hungrigt, retunerar name
            }

            return string.Format(", {0} leker med Joppes Boll", name); // retunerar name

        }


        public virtual string Eat() // metod för att djuret äter
        {
            hungry = false;
            return string.Format("{0} äter glatt {1}", name, fav_food); // returnerar name och fav_food
        }



        public override string ToString() // basklassens returvärden
        {
            return string.Format("Namn: {0}, Ålder: {1} år, Ras: {2}", name, age, breed); // retunerar name, age, breed
        }
    }
}
