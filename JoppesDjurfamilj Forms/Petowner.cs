using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Petowner
    {
        // fält
        private int age;

        // lista
        private List<Animals> pets = new List<Animals>
        {
            new Dog(5, "Bosse", "Lasange", "Mops"),
            new Dog(10, "Lars", "Frasvåfflor", "Pitbull"),
            new Cat(11, "Fia", "Torrfoder", "Bondkatt"),
            new Puppy(0, 5, "Frida", "Torrfoder för valpar", "Tax"),
        };


        // konstruktor
        public Petowner(int _age)
        {
            age = _age;
        }

        // properties till fält
        public string Age { get; set; }


        public List<Animals> List_animals() // metod för att skriva ut listan
        {
            return pets;

        }

        public string Play(int menyval) // metod för att leka med djur
        {

            return "Joppe kastar sin boll till " + pets[menyval -1].Interact(); // anropar metoden interact och vald input minus 1
        }

        public string Feed(int menyval) // metod för att mata djur
        {
            return pets[menyval - 1].Eat(); // anropar metoden eat och vald input minus 1
        }

        public int Print_joppe() // metod för att skriva ut Joppes ålder
        {
            return age; // retunerar age
        }

        public override string ToString() // returvärden
        {
            return string.Format("{0}", age);
        }

    }

}



