using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2303_itsenäinen_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput; // Tallennetaan käyttäjän syöttämä arvo
            Console.WriteLine();
            Console.WriteLine("Harjoitus 23.3.");
            Console.Write("Anna pituus metreinä: ");
            userInput = Console.ReadLine(); // Käyttäjän syöttämä luku tallessa

            // Muokataan string arvo double dataksi
            double length = double.Parse(userInput);

            Console.Write("Anna leveys metreinä: ");
            userInput = Console.ReadLine();
            double width = double.Parse(userInput);

            double area = length * width;
            Console.WriteLine($"Alueen pinta-ala: {area}");



            Console.ReadKey();

        }
    }
}