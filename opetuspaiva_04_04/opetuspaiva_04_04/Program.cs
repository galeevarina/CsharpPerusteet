using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opetuspaiva_04_04
{
    class Program
    {
        static void Main(string[] args)
        {

            //            // 28 C# Toisto: Parillinen Pariton
            //            // Tee ohjelma, joka tulostaa luvut 1:stä käyttäjän antamaan lukuun saakka.

            //            // 1. pyydetään käyttäjältä luku

            //            // 2. Luetaan ja  Tallennetaan luku muttujaan

            //            Console.Write("Syötä luku, johon asti tulostetaan: ");
            //            int number = int.Parse(Console.ReadLine());


            //            // 3. luodaan silmukka, joka suoritetaan  niin monta kuin 1 - käyttäjä luku on
            //            //  -while, pitää miettiä jokin sopiva ehto
            //            // -jotta voidaan tulostaa numeroita 1 alkaen, tarvitaan muttuyja, joka on alussa 1

            //            int i = 1; // ITEROINTI: 1++ => i++ => i == 3 jhe

            //            // kysytään käyttäjältä halutaanko parillinen vai pariton
            //            Console.Write("Parillinen / Pariton: ");
            //            string input = Console.ReadLine();

            //            while (i <= number)
            //            { 
            //            if (i % 2 != 0 && input == "Pariton")
            //            {
            //               // Lisätään ehto, joka tulostaa vain parittoman numeron

            //               Console.WriteLine(i);
            //             }
            //            else if (i % 2 == 0 && input == "Parillinen")
            //                        {
            //                    Console.WriteLine(i);
            //                }
            //                    i++; // suoritataan iteraatio jokaisella silmukan kierroksella

            //}


            //    //            // 4. silmukassa tulostetaan numero 1, jota iteroidaan joka kierros

            //    const string EVEN_TEXT = "Parillinen";
            //    const string ODD_TEXT = "Pariton";

            //    Console.Write("Syötä luku, johon asti tulostetaan: ");
            //    int number = int.Parse(Console.ReadLine());


            //    string input = ""; // Muttuja luodaan enne silmukkaa, jotta sitä voi käyttää ehdossa
            //    bool inputFalse = true;

            //    while (inputFalse == true)
            //    { 
            //    {
            //        Console.Write($"{EVEN_TEXT} / {ODD_TEXT}:");
            //        input = Console.ReadLine();
            //    }
            //    if (input == EVEN_TEXT)
            //    {
            //        inputFalse = false;
            //    }
            //    else if (input == ODD_TEXT)
            //    {
            //        inputFalse = false;
            //    }
            //}

            //    // Käyttäjän syöte Ttarkistetaan aiemmin
            //    int startingPoint = input == EVEN_TEXT ? 2 : 1;

            //    for (int i = startingPoint; i <= number; i += 2)
            //    {
            //        Console.WriteLine(i);
            //    }


            // 27 C# Toisto: Tähtien tulostus 

            // 1. Pyydetään käyttäjältä numero ja tallennetaan se muuttujan 

            // Console.Write("Syötä numero: ");
            // int number = int.Parse(Console.ReadLine());

            // // 2. Lisätään silmukka, joka suoritetaan käyttäjän syöttämän numeron verran 

            // // Tulostataan yksi tähti, toistetaan käyttäjän syöttämän numeron verran
            // // while / do while
            // // for
            // // foreach

            ////muuttuja; ehto; iteraatio

            //// jos numero = 5 ja i = 1; 1, 2, 3, 4, 5 => suoritetaan 5 kertaa

            // for (int i = 1; i <= number; i++)
            // {
            //     Console.WriteLine("*");
            // }

            // 30 C# Toisto: Kertymä

            //Console.Write("Syötä numero: ");
            //int loops = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < loops; i++)
            //{ // summataan, tervitaan muuttuja

            //    sum = sum + i;
            //}


            //Console.WriteLine($"{loops} kierrosta Kertymäksi saatin: {sum}");


            // 31B C# Toisto: Lukujen summa ja keskiarvo 
            // 5
            // 11
            // 5
            // 8
            // 4
            // 56
            Console.Write("Montako lukua summataan: ");
            int numbersToSum = int.Parse(Console.ReadLine());
            double sum = 0; // luodaan summa muuttuja silmukan ulkopuolella; muuten 
            // silmukka, joka tapahtuu käyttäjän syöttämän luvun verran
            for (int i = 0; i < numbersToSum; i++)
            {
                Console.Write($"Anna luku {i}: ");
                sum = sum + int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Summa on:{sum} ja summan keskiarvo on:{sum / numbersToSum}");

            Console.ReadKey();

        }
    }
}
