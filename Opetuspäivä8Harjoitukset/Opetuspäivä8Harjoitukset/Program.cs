using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä8Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {
            // 34B C# Vokaalit taulukkoon
            // https://moodle.sakky.fi/mod/assign/view.php?id=1164552
            #region

            // 1. Lue käyttäjältä sana talteen

            Console.Write("Syötä sana: ");
            string userInput = Console.ReadLine();

            // 2. Luo taulukko sanan vokaaleille

            // Taulukon  pituus täytyy määrittää, sitä luodessa
            // Luodaan taulukon pituudeksi sama, 

           // datatyypi [] taulukon nimi = new datatyypi[taulukon pituus]
            char[] vocalsInWord = new char[userInput.Length];  // Taulukko

            // List<datatyypi> nimi = new List<datatyypi>();
            List<char> vocalsUsingList = new List<char>();  // Lista
            // Lista on oletuksena tyhjä ja sen pituus/Count on 0
           // vocalsUsingList[0] = 'n'; // Kaatuu, ArgumentOutOfRangeException, koska lista on tyhjä
           


            // Käy sanan merkit läpi silmukassa

            // indeksi (int i = 0) alkaa arvosta 0, koska indeksit alkavat nollasta

            // Silmukan ehtona on taulukon pituus / indeksien lukumäärä. Kun iteroitava muutuja i on 
            // taulukon indeksien ulkopuolella, silmukka päättyy.
            // Esim. "test".Lenght == 4, jonka indeksit ovat 0, 1, 2, 3. Kun i sapuu arvoon 4, 
            // eli 4 < 4 ole enää totta, silmukka pååttyy
            // Iterointi, i ++

            for (int i = 0; i < vocalsInWord.Length; i++)
            {
               // Kirjoitetaan merkit yksi kerrallaan, merkkiä voi käyttää syntassilla
                Console.WriteLine(userInput[i]);

            // 4. Tallenna merkki taulukkoon, jos se on vokaali.
            
            // Lisätään merkin tallennus ehdon sisälle, joka tarkistaa, että merkki on vokaali
             if (userInput[i] == 'a' || userInput[i] == 'e' || userInput[i] == 'i' || userInput[i] == 'o' || userInput[i] == 'u' || userInput[i] == 'y' ||
                    userInput[i] == 'ö' || userInput[i] == 'ä' )
                { 
                    vocalsInWord[i] = userInput[i];
                    vocalsUsingList.Add(userInput[i]); // Listan lisätään elementti .Add()-metodilla 
                }
             }
            
            // 5.Luo silmukka, jossa tulostetaan vokaalit taulukosta käyttäjälle.

            //  for olisi toinen vaihtoehto
            foreach (char symbol in vocalsInWord)
            {
               // Ei tulosteta tyhjiä elementtejä
               // char taulukon oletusarvo on 0, jos symbol on muutakin 0 (symbol != 0), tulostetaan merkki 
               if (symbol != 0)
                { 
                Console.WriteLine(symbol);
                 }
            }

            // Myös foreach toimisi
            for (int i = 0; i < vocalsUsingList.Count; i++) // Lista
            {
                Console.WriteLine("Lista: " + vocalsUsingList[i]);
            }


            #endregion

            // 37 C# String: Lämpötilan seuranta
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159662

            #region
            // 1.Luo taulukko ja lista arvoille

            int numberOfReadingsPerDay = 4;
            string[] measurementTimes = { "6:00", "12:00", "18:00", "24:00" };
            DateTime[] test = { DateTime.Now, DateTime.Now };

            double[] temperaruresArray = new double[measurementTimes.Length]; // Taulukko
            List<double> temperaturesList = new List<double>(); // Lista

           
            // 2.Lue silmukka, jossa käyttäjän arvo luetaan ja tallennetaan taulukkoon
            // ja listaan. (Arvo luetaan vain kerran per kierros ja se tallennetaan sekä taulukkoon ja listaan)

            for (int i = 0; i < numberOfReadingsPerDay; i++)
            {
                Console.Write($"Syötä kello {measurementTimes[i]} lämpötilä: ");
                double input = double.Parse(Console.ReadLine());
                temperaruresArray[i] = input; // Taulukko
                temperaturesList.Add(input); // Lista
            }

            // 3a.Ilmoita suurin, pienin ja keskilämpötila käyttämällä valmiita metodeja.

            Console.WriteLine($"Taulukon suurin lämpötila on: {temperaruresArray.Max()}");
            Console.WriteLine($"Taulukon pienen lämpötila on: {temperaruresArray.Min()}");
            Console.WriteLine($"Taulukon keskilämpötila on: {temperaruresArray.Average()}");

            Console.WriteLine($"Listan suurin lämpötila on: {temperaruresArray.Max()}");
            Console.WriteLine($"Listan pienen lämpötila on: {temperaruresArray.Min()}");
            Console.WriteLine($"Listan keskilämpötila on: {temperaruresArray.Average()}");

            // 3b.Suorita arvojen etsiminen omalla koodilla. (Kysy esim ChatGPT: How to find the smallest value in an array using for loop)

           
            //Algoritmi, termi koodille, joka suorittaa jonka 
            int count = 0;
            double sum = 0;

            foreach (double temp in temperaruresArray)
            {
                sum += temp;
                count++;
            }

            Console.WriteLine($"Taulukon keskiarvo on: {sum/count}");

            double value = 0;  // Tästä arvosta lähdetään liikkeelle ja tallennetaan suurin arvo.


            for (int i = 0; i < temperaturesList.Count; i++)

            {
                // Korvataan oletusarvo 0, ensimmäisellä kierroksella
                if (i == 0)
                {
                    value = temperaturesList[i];
                }

                // Onko uusi arvo suurempi kuin vanha arvo
                if (temperaturesList[i] > value)
                {
                    value = temperaturesList[i]; // Otetaan talteen isompi arvo
                }
            }

            Console.WriteLine($"Listan Suurin arvo on: {value}");

            // Tee algoritmi, joka hakee taulukosta pienimmän arvon

            double valueMin = 0;

            for (int i = 0; i < temperaturesList.Count; i++)

            {
                
                if (i == 0)
                {
                    valueMin = temperaturesList[i];
                }

                
                if (temperaturesList[i] < valueMin)
                {
                    valueMin = temperaturesList[i]; 
                }
            }

            Console.WriteLine($"Listan pienin arvo on: {valueMin}");




            // 4.Tulosta suurin, pienin ja keskilämpötila käyttäjälle.

            #endregion


            Console.WriteLine("Press any key to exit...");         
            Console.ReadKey();

        }
    }
}
