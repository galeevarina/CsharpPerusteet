using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palkan_lasku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); 
            string input;
            double hourlySalary;
            double normalHours;
            double plus50PercentHours;
            double plus100PercentHours;
            double totalSalary;

            Console.Write("Anna tuntipalkka: ");
            input = Console.ReadLine();
            hourlySalary = double.Parse(input);

            Console.Write("Anna normaalit tunnit: ");
            
            normalHours = Double.Parse(Console.ReadLine());

            Console.Write("Anna 50% korotetut tunnit: ");
            plus50PercentHours = double.Parse(Console.ReadLine());

            Console.Write("Anna 100% korotetut tunnit: ");
            input = Console.ReadLine();
            plus100PercentHours = double.Parse(input);

            totalSalary = hourlySalary * normalHours +
                       hourlySalary * 1.5 * plus50PercentHours +
                       hourlySalary * 2 * plus100PercentHours;

            Console.WriteLine($"Kuukausi palkka on {totalSalary}");

            Console.ReadKey();
        }
    }
}
