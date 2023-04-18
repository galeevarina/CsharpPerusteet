using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opetuspäivä9Harjoitukset
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lisää tähän tiedostoon uusi metodi, joka ottaa vastaan parametrinä taulukon
            // int lukua ja palauttaa taulukon keskiarvon
            #region
            //    int[] someValues = new int[4];
            //    someValues[0] = 5;
            //    someValues[1] = 8;
            //    someValues[2] = 6;
            //    someValues[3] = 100;

            //    Console.WriteLine(average(someValues));

            //}

            //private static double average(int[] numbers)
            //{
            //    // Algoritmi, joka laskee keskiarvo
            //    int count = 0;
            //    double sum = 0;

            //    foreach (double temp in numbers)
            //    {
            //        sum += temp;
            //        count++;
            //    }

            //    return sum / count;

            #endregion



            //  C# Funktiot: Kolmion pinta ala 
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159673

            #region

            //Console.WriteLine("Syötä korkeus: ");
            //double heightTriangle = double.Parse(Console.ReadLine());

            //Console.WriteLine("Syötä kanta: ");
            //double baseTriangle = double.Parse(Console.ReadLine());

            //double area = heightTriangle * baseTriangle / 2;

            //double area = triangleArea(heightTriangle, baseTriangle);

            //Console.WriteLine($"Kolmion pinta-ala; {area}");


            #endregion

            //  C# Funktiot: Kolmion pinta ala 
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159673

            #region


            #endregion


            // C# Funktiot: Verolaskuri
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159678

            #region

            //Console.WriteLine("Syötä bruttopalkka: ");
            //double grossSalary = double.Parse(Console.ReadLine());

            //Console.WriteLine("Syötä bruttopalkka: ");
            //double taxPercentage = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Nettopalkka on: {netSalary(grossSalary, taxPercentage)}");

            //private static (decimal, decimal) netSalary(decimal grossSalary, decimal taxPercentage)
            //{
            //    (decimal,decimal) result = (0,0);

            //    //Tässä välissä lasketaan lopputulos
            //    result.Item1 = (grossSalary / 100) * (100 - taxPercentage);
            //    result.Item2 = grossSalary - (grossSalary / 100) * (100 - taxPercentage);

            //    return result;


            //}



            #endregion


            // Kalorit jouleiksi
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159676

            #region

            // 1 metodi

            Console.WriteLine("Syötä kalorit: ");
            double userCalories = double.Parse(Console.ReadLine());

            Console.WriteLine("Joulei on:" + userCalories * 4.1868);

            Console.WriteLine("Syötä joulei: ");
            double userJoulei = double.Parse(Console.ReadLine());

            Console.WriteLine("Kalorit: " + 4.1868 / userJoulei);

            // 2 metodi



            #endregion

            // Kalorit jouleiksi
            // https://moodle.sakky.fi/mod/assign/view.php?id=1159676

            #region


            //  Console.Write("Syötä kalorit: ");
            //  decimal calories = decimal.Parse(Console.ReadLine());

            //Console.Write("Syötä joulet: ");
            //  decimal calories = decimal.Parse(Console.ReadLine());

            Console.ReadLine();

            #endregion

        }// end of main function

        // Kalorit jouleiksi
        // https://moodle.sakky.fi/mod/assign/view.php?id=1159676

        #region

        private static decimal caloriesToJoules(decimal calories)
        {
            return calories * 4.184m;
        }

        private static decimal joulesCalories(decimal joules)
        {
            return joules * 0.2390m;
        }
        #endregion


        // while, joka toistuvasti pyytää muunnoksia
        // 

    }
}
