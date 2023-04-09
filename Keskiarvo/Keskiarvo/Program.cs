using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Console.Write("Anna luku 1: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku 2: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku 3: ");
            int value3 = int.Parse(Console.ReadLine());

            double resultError = (value1 + value2 + value3) / 3; 
            double result = (value1 + value2 + value3) / 3d;
            Console.WriteLine($"Keskiarvo: {resultError} - Virhe");
            Console.WriteLine($"Keskiarvo: {result}");

            Console.ReadKey();
        }
    }
}
