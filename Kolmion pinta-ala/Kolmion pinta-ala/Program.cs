using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmion_pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Anna kolmion kanta: ");
           
            double triangleBase = double.Parse(Console.ReadLine());

            Console.Write("Anna kolmion korkeus: ");
            double triangleHeigth = double.Parse(Console.ReadLine());

            Console.WriteLine($"Kolmion pinta-ala on: {triangleBase* triangleHeigth / 2}");

           
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
