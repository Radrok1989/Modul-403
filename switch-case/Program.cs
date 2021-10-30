using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1
             * try
            {
                Console.WriteLine("Erste Zahl?");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zweite Zahl?");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Wählen sie Ihren Operatoren?");
                Console.WriteLine("1 = +");
                Console.WriteLine("2 = -");
                Console.WriteLine("3 = x");
                Console.WriteLine("4 = /");
                Console.WriteLine("5 = %");
                int mod = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ihr Resultat beträgt: ");

                switch (mod)
                {
                    case 1:
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        Console.WriteLine(x / y);
                        break;
                    case 5:
                        Console.WriteLine(x % y);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*Aufgabe 2
             try
            {
                String thirty = "Dieser Monat hat 30 Tage";
                String thirtyone = "Diese Monat hat 31 Tage";
                String twentyeight = "Dieser Monat hat 28 Tage ausser es ist ein Schaltjahr.";
                Console.WriteLine("Von welchem Monat möchten sie die Tage wissen (1-12)");
                int month = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                        Console.WriteLine(thirtyone);
                        break;
                    case 2:
                        Console.WriteLine(twentyeight);
                        break;
                     case 3:
                         Console.WriteLine(thirtyone);
                         break;
                    case 4:
                        Console.WriteLine(thirty);
                        break;
                    case 5:
                        Console.WriteLine(thirtyone);
                        break;
                    case 6:
                        Console.WriteLine(thirty);
                        break;
                    case 7:
                        Console.WriteLine(thirtyone);
                        break;
                    case 8:
                        Console.WriteLine(thirtyone);
                        break;
                    case 9:
                        Console.WriteLine(thirty);
                        break;
                    case 11:
                        Console.WriteLine(thirtyone);
                        break;
                    case 11:
                        Console.WriteLine(thirty);
                        break;
                       case 12:
                        Console.WriteLine(thirty);
                        break;
                    default:
                        Console.WriteLine("Es gibt nur 12 Monate du Pflock");
                        break;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*try
            {
                Console.WriteLine("Welchen Rang hast du beim letzten Marathon belegt? 1, 2 oder 3?");
                int rank = Convert.ToInt32(Console.ReadLine());
                switch(rank)
                {
                    case 1:
                        Console.WriteLine("Gratuliere du bist erster.");
                        break;
                    case 2:
                        Console.WriteLine("Gratuliere zum zweiten Platz.");
                        break;
                    case 3:
                        Console.WriteLine("Nur der dritte Platz?");
                        break;
                    default:
                        Console.WriteLine("Nicht auf dem Treppchen ist nicht erfüllt.");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/
        }
    }
}
