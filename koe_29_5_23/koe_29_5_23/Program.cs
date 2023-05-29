using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koe_29_5_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main
            #region
            Console.WriteLine("Syötä puhelinnumero kansainvälisessä muodossa +358");
            string puhNum = Console.ReadLine();

            bool valid = puhNum.StartsWith("+358") && puhNum.Length == 13;

            if (valid)
            {
                Console.WriteLine("puhelinnumero on oikeassa muodossa");
            }
            else
            {
                Console.WriteLine("puhelinnumero ei ole oikeassa muodossa");
            }

            #endregion


            //Luokat
            // JavelinThrow
            #region

            List<JavelinThrow> javelinThrows = new List<JavelinThrow>();

            while (true)
                { 

            Console.WriteLine("Syötä heittäjän nimi: ");
            string athleteName = Console.ReadLine();

            Console.WriteLine("Syötä heiton metrit: ");
            int meters = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä heiton senttimetrit: ");
            int centimeters = int.Parse(Console.ReadLine());

                int id = javelinThrows.Count + 1;                
           
            JavelinThrow newThrow = new JavelinThrow(id, athleteName, meters, centimeters);
            javelinThrows.Add(newThrow);

                Console.WriteLine("Kiitos");

                Console.WriteLine("Syötä uuden heiton? (yes tai no)");
                string input = Console.ReadLine();

                if (input != "yes")
                    break;
            
            }
           
            Console.WriteLine("Heitot:");
            foreach (JavelinThrow javelinThrow in javelinThrows)
            {
                Console.WriteLine($"Id: {javelinThrow.Id}");
                Console.WriteLine($"Nimi: {javelinThrow.AthleteName}");
                Console.WriteLine($" {javelinThrow.Meters} metriä {javelinThrow.Centimeters} senttimetriä");
                Console.WriteLine();
            }

           




            #endregion

            // Product
            #region

            List<Product> products = new List<Product>();

            Console.WriteLine("Anna tuotetiedot");

            while (true)
            {
                Console.WriteLine("Syötä Id: ");
                string userInputId = Console.ReadLine();

                Console.WriteLine("Syötä name: ");
                string userInputName = Console.ReadLine();

                Console.WriteLine("Syötä price: ");
                string userInputPrice = Console.ReadLine();
                decimal price = decimal.Parse(userInputPrice);

                Product product = new Product(int.Parse(userInputId), userInputName, price);
                products.Add(product);

                Console.WriteLine("Syötä uuden tuote? (yes tai no)");
                string input = Console.ReadLine();

                if (input != "yes")
                    break;

                Console.WriteLine();
            }

            Console.WriteLine("Kaikki tuotteet:");

            foreach (Product product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}, Sale (20%): {product.CalculateDiscountedPrice(20m):C}");
            }





            #endregion


            //Funktio
            #region
            Console.WriteLine("Syötä etunimesi");
            string etunimi = Console.ReadLine();

            Console.WriteLine("Syötä sukunimesi");
            string sukunimi = Console.ReadLine();

            Console.WriteLine(etusukunim(etunimi, sukunimi));
            Console.ReadLine();

           


            #endregion

            Console.ReadKey();
        }

            public static string etusukunim(string etunimi, string sukunimi)
            {
                string etunimiTunnus = etunimi.Substring(0, Math.Min(etunimi.Length, 3));
                string sukunimiTunnus = sukunimi.Substring(0, Math.Min(etunimi.Length, 5));

                return etunimiTunnus + sukunimiTunnus;
            }

    }
}
