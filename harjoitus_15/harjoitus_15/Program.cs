using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_15
{
    class Program
    {
        static void Main(string[] args)
        {

            int target = 11;
            bool correctGuess = false;

            while (correctGuess == false)
            {

                Console.Write("Arvaa luku(0-20): ");
                int guess = int.Parse(Console.ReadLine());


                if (guess == target) // oikea arvaus
                {
                    correctGuess = true;
                    Console.WriteLine("Oikea arvaus");
                }

                else if (guess < target) // liian pieni
                    {
                    Console.WriteLine("liian pieni");
                }

                else // liian suuri
                {
                    Console.WriteLine("Liian suuri");
                }
            }
            Console.ReadKey();
        }
    }
}
