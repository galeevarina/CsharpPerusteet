using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpetusPäivä15Harjoitukset
{
    class Dice
    {
        // Properties
        private Random rng; // Jos luodaan static, tämäm jaetaan kaikkien

        public int MaxValue { get; set; } // Nopassa on lukuja 1 - tämä arvo


        public int Value { get; set; } // Nopan arvo, joka on ylöspäin

        // Jokin property, jolla voi tehdä "huijaus" nopan

        // Constructors
        public Dice(int maxValue)
        {
            rng = new Random();
            MaxValue = maxValue;
            Roll();
        }

        public Dice(int maxValue, int value) // Kahden parametrin overload
        {
            rng = new Random();
            MaxValue = maxValue;
            Value = value;
            Random random = new Random(4);
        }

        // Methods
        // Noppaa "heitetään" ja arvostaan siihen uusi sattunainen arvo
        public void Roll()
        {
            // Random random = new Random();
            Value = rng.Next(1, MaxValue + 1);
        }

    }

}
