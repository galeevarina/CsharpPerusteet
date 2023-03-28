using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // UUsi aihe: Ohjausrakene - Control
            // 1. if 

            // if (ehto - condition) // lopputulos true / false
            // {
            //if condition == true
            // Suoritetaan if blokin koodi

            // }
            // jos condition == false
            // hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if (5 > 10) // false
            {
                Console.WriteLine("sisällä if");
            }
            Console.WriteLine("Jälkeen if");

            // 2. if - else
            //  Joko suoritetaan if code block
            // Tai suoritetaan else code block

            Console.WriteLine("enne if");
            if ("moi" == "terve")
            {
                Console.WriteLine("inside if");
            }
            else
            {
                Console.WriteLine("inside else");
            }
            {
                Console.WriteLine("after if-else");
            }


            // 3. if - sile if - else
            // Rakentessa voi olla myös 


            if ( 5.5 >= 5.5 )
            {
                Console.WriteLine("inside if");
            }
            else if (10 <= 10 )
            {
                Console.WriteLine("inside else-if");
            }
            else 
            {
                Console.WriteLine("inside else");
            }


            // Vertailioperaattorit - Comparison operators
            // Vertailujen 
            // true / false
            // == samat arvot
            // != eri arvot
            // < vasen pienempi kuin oikea
            // > vasen isompi kuin oikea
            // <= vasen pienempi tai yhtä suuri kuin oikea
            // >= vasen isompi tai yhtä suuri kuin oikea

            // Loogiset operaattorit - Logical operators
            // Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta -and-
            // >= ageLimit && lenght == targetHeight

            // || ( ctrl + alt + <)  toinen totta -or-
            // >= ageLimit || lenght == targetHeight

            // ! kääntää totuusarvon
            // bool accountDeleted = true;
            // if(!accountDeleted)


            // 4. Silmukat - Loops
            // while(condition)
            // {
            //    Execute done
            //    As long as condition == true
            //}

            // kommentointi ctr + k sitten ctrl + c
            // poisto ctr + k sitten ctrl + u
            // while (true)
            //{
            //    console.write("moi");
            //}

            string input = ""; 
            while (input != "exit")
            {
                Console.Write("Choose action: ");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");

            }

            //11 C# Valinta: Luvun vertailu




            Console.ReadKey();
        }


    }
}
