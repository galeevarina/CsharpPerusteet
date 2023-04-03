using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_C_Kuukaudet
{
    class Program
    {
        static void Main(string[] args)
        {
            //16 C# Valinta: Kuukaudet 

            //1.  if else

            // Console.Write("Anna kuukausi: ");
            // string monthIF = Console.ReadLine();

            // // Muokataan teksti pieniksi kirjamiksi 
            // monthIF = monthIF.ToLower(); // ToLower() 

            //// tarkistetaan saman vuodenajan kuukaudet samassa if ehdossa
            // if (monthIF == "tammikuu" || monthIF == "helmikuu" || monthIF == "marraskuu" || monthIF == "maaliskuu" || monthIF == "joulukuu")
            // {
            //     Console.WriteLine("Kuuluu talveen.");
            // }
            // else if (monthIF == "huuhtikuu" || monthIF == "toukokuu")
            // {
            //     Console.WriteLine("Kuuluu kevääseen.");
            // }
            // else if (monthIF == "kesäkuu" || monthIF == "heinäkuu" || monthIF == "elokuu")
            // {
            //     Console.WriteLine("Kuuluu kesään.");
            // }
            // else if (monthIF == "syyskuu" || monthIF == "lokakuu")
            // {
            //     Console.WriteLine("Kuuluu syksyyn.");
            // }
            // else
            // {
            //     Console.WriteLine("Syöttämääsi kuukautta ei löytänyt");
            // }

            // Console.ReadKey();

            //2. Switch
            //Console.Write("Anna kuukausi: ");

            //int a = Convert.ToInt32(Console.ReadLine());
            //string season = "";
            //switch (a)
            //{
            //    case 11:
            //    case 12:
            //    case 1:
            //    case 2:
            //    case 3:
            //        season = "talvi";
            //        break;
            //    case 4:
            //    case 5:
            //        season = "kevät";
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        season = "kesä";
            //        break;
            //    case 9:
            //    case 10:
            //        season = "syksy";
            //        break;
            //}

            //Console.WriteLine($"Se on {season}");

            //Console.ReadKey();


            // 2.1 
            //Console.Write("Anna kuukausi numerona: ");
            //int monthSwitch = int.Parse(Console.ReadLine());

            //switch (monthSwitch)
            //{
            //    case 11:
            //    case 12:
            //    case 1:
            //    case 2:
            //    case 3:

            //        Console.WriteLine("Talvi kuukausi.");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Kevät kuukausi.");
            //        break;
            //    // C# 7 versiossa voidaan ilmaista myös tietty numero alue.
            //    case int xyz when (xyz >= 6 && xyz <= 8):
            //        Console.WriteLine("Kesä kuukausi");
            //        break;
            //     case int xyz when (xyz >= 9 && xyz <= 10):
            //        Console.WriteLine("Syys kuukausi");
            //        break;
            //    default:
            //        Console.WriteLine("Virheellinen numero!");
            //        break;

            //}


            //Console.ReadKey();

            //3. ternary
            Console.Write("Anna kuukausi numerona: ");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            // ternary vertailu
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
                monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
                monthTernary >= 6 && monthTernary <= 8 ? "Kesä" :
                monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                "Virheellinen arvo";

            Console.WriteLine(message);
            Console.ReadKey();


        }
    }
}
