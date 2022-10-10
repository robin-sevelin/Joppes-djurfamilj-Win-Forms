using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoppesDjurfamilj
{
    public partial class Form1 : Form
    {
        Petowner petowner = new Petowner(20); // skapar instans av petowner
        Ball ball = new Ball("röd"); // skapar instans av ball


        public Form1()
        {

            InitializeComponent();
        }

        private void list_click(object sender, EventArgs e) // metod för att skriva ut lista
        {

            output.Text = "Här är alla Joppes djur \r\n";
            foreach (var pet in petowner.List_animals()) // metodanrop för att skriva ut listan av djur
            {
                output.Text += pet.ToString() + "\r\n"; // skriver ut djuret 
            }


        }

        private void play_click(object sender, EventArgs e) // knapp för att välja djur
        {

            output.Text = "Vilket djur ska Joppe umgås med? \r\n[1] Bosse \r\n[2] Lars \r\n[3] Fia \r\n[4] Frida\r\n";

        }


        private void boll_click(object sender, EventArgs e) // knapp för att titta på Joppes boll
        {
            output.Text = "Joppes boll har färgen " + ball.ToString(); // skriver ut bollens returvärden
        }


        private void om_joppe_click(object sender, EventArgs e) // knapp för att beskriva Joppe
        {
            output.Text = "Joppe är " + petowner.ToString() + " år gammal och samlar på djur"; // skriver ut Petowners returvärden
        }

        private void quit_click(object sender, EventArgs e) // metod för att avsluta programmet
        {
            Application.Exit();
        }

        private void ok_click(object sender, EventArgs e) // knapp för att leka med djur
        {

            try
            {
                int menyVal = int.Parse(input.Text); // input från användaren

                output.Text = petowner.Play(menyVal); // metodanrop metoden play med input som inparameter

            }
            catch (Exception)
            {
                output.Text = "Felaktigt menyval";
            }
        }

        private void button2_Click(object sender, EventArgs e) // knapp för att mata djur
        {
            

            try
            {
                int menyVal = int.Parse(input.Text); // input från användaren
                output.Text = petowner.Feed(menyVal); // metodanrop metoden feed med input som inparameter

            }
            catch (Exception)
            {
                output.Text = "Felaktigt menyval";
            }
      
        
        }

    }
}
