using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä hinta: ");
            double price = double.Parse(Console.ReadLine());
            double discountedPrice;

            if(price > 100)
            {
                discountedPrice = price * 0.75;
            }
            else
            {
                discountedPrice= price * 0.90;
            }

            Console.WriteLine($"Alennettu hinta on {discountedPrice} euroa");

            Console.ReadKey();

        }
    }
}
