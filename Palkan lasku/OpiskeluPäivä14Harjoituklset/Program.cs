using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpiskeluPäivä14Harjoituklset
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine(Greet("Toni"));

            // Jos halua koodissa verrata arvoja
            if (Greet("Ryan") == "Hello, Ryan how are you doing today?")
            {
                Console.WriteLine("Metodi toimii!");
            }
            else
            {
                Console.WriteLine("Metodi ei toimii!");
            }

            // Testaus
            if(CountPositivesSumNagatives(new int[] { 5, 3, 8, -5, -9, 3 }) == new int[] {4, -14 })
            {
               // Kun verrataan objekteja "== vertailu", ainoastaan tarkistaa viitaako muttujat samaan objektiin muistissa
               // Se ei tutki objektien sisältöä
                Console.WriteLine("Metodi toimii!");
            }

            Console.ReadKey();
        }

        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        public static int[] CountPositivesSumNagatives(int[] input)
            {
              
            // Jos taukko on null palautetaan tyhjä taukko
            
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }
            
            
            // Luodaan uusi taulukko, johon tallennetaan palautettavat arvot
               int[] result = new int[2];


            //   foreach (int number in input)
            //{
            //   // Tarkistettaan, etta arvo on positiivinen
        //    if (number > 0)
        //    {
        //        result[0]++;
        //    }
        //    else
        //    {
        //        result[1] += NotFiniteNumberException;
        //    }
        //}

               for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    // Kasvatetaan positiivise arvojen lukumäärän laskua
                    result[0]++;
                }
                else //Negat. arvot
                {
                    // Sumataa negatiiviset arvot
                    result[1] = result[1] + input[i];



                }
            }

               // Sumataan neg. arvot 


             // return an array 
            return result;
            }
    }
}
