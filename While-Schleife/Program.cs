using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                double d = 0;
                double ins = 0;
            Console.WriteLine("Geben sie eine Zahl zwischen 1 und 20 ein");
                ins = Convert.ToDouble(Console.ReadLine());
                double count = 1;
                if (ins >= 1 && ins <= 20)
                {
                    while (count <= ins)
                    {
                        d += count;
                        count++;
                    }
                    Console.WriteLine($"Der Durchschnitt beträgt {d / ins}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*try
            {
                while (true)
                {
                    Console.WriteLine("If you write stop, i will stop!");
                    string insert = Console.ReadLine();
                    if (insert == "stop")
                    {
                        Console.Clear();
                        Console.WriteLine("ok");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You didn't say stop");
                        Console.Clear();
                    }
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            /*while (true)
            {
            try
            {
                Console.Write("Mit j/J weiter, mit n/N ende.");
                string str = Console.ReadLine();
                Console.Clear();
                if (str == "n" || str == "N")
                {
                    Console.WriteLine("Ende");
                    break;
                }
                if (str == "j" || str == "J")
                {
                    Console.WriteLine("\n Wählen sie bitte:");
                    Console.WriteLine("\n Addieren \t\t(1)");
                    Console.WriteLine("\n Subtrahieren \t\t(2)");
                    Console.WriteLine("\n Multiplizieren \t(3)");
                    Console.Write("\n Dividieren \t\t(4) \t");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\n Geben sie die erste Zahl ein: ");
                    double first = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Geben sie die zweite Zahl ein: ");
                    double second = Convert.ToInt32(Console.ReadLine());

                    switch(x)
                    {
                        case 1:
                            Console.WriteLine($"{first} + {second} = {first + second}");
                            break;
                        case 2:
                            Console.WriteLine($"{first} - {second} = {first - second}");
                            break;
                        case 3:
                            Console.WriteLine($"{first} * {second} = {first * second}");
                            break;
                        case 4:
                            if (second == 0)
                            {
                                Console.WriteLine("Imagine that you have zero cookies and you split them evenly among zero friends. How many cookies does each person get?");
                                Console.WriteLine("See ? It doesn’t make sense.And Cookie Monster is sad that there are no cookies.And you are sad that you have no friends.");
                                break;
                            }
                            Console.WriteLine($"{first} : {second} = {first / second}");
                            break;
                        default:
                            Console.WriteLine("Musse du scho richtige Sache eingeben!");
                            break;


                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }*/

           /* while (true)
            {
                try
                {
                    Console.Write("Mit j/J weiter, mit n/N ende.");
                    string str = Console.ReadLine();
                    Console.Clear();
                    if (str == "n" || str == "N")
                    {
                        Console.WriteLine("Ende");
                        break;
                    }
                    if (str == "j" || str == "J")

                    {
                        Console.WriteLine("\n Wählen sie bitte:");
                        Console.WriteLine("\n Alter berechnen \t\t(1)");
                        Console.WriteLine("\n Rabatt 3% berechnen \t\t(2)");
                        Console.Write("\n Urlaubstage berechnen \t\t(3): ");

                        int y = Convert.ToInt32(Console.ReadLine());

                        switch (y)
                        {
                            case 1:
                                Console.Write($"Geben Sie Ihren Jahrgang ein ");
                                int year = Convert.ToInt32(Console.ReadLine());
                                if (year >= 1901 && year <= 2021)
                                {
                                    Console.WriteLine($"Sie sind {2021 - year} Jahre alt");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Das kann nicht sein!");
                                    break;
                                }
                            case 2:
                                Console.Write($"Geben Sie den Betrag ein. ");
                                double money = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"3% von Ihrem Betrag sind: {money * 0.03}");

                                break;
                            case 3:
                                Console.Write($"Wie viele Monate haben sie dieses Jahr gearbeitet? ");
                                double arbeit = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine($"Sie haben {arbeit * 2,4} Tage Urlaub zu gute.");
                                break;

                            default:
                                Console.WriteLine("Musse du scho richtige Sache eingeben!");
                                break;
                        }

                    }
                    Console.ReadKey();
                }
               

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }*/

            while (true)
            {
                try
                {
                    Console.WriteLine("Gib ein a, b, oder c");
                    string i = Console.ReadLine();
                    Console.Clear();
                    switch(i)
                    {
                        case "a":
                            Console.WriteLine("Du bist der beste.");
                            break;
                        case "A":
                            Console.WriteLine("Du bist der beste.");
                            break;
                        case "b":
                            Console.WriteLine("Du bist nicht der beste, aber immerhin zweiter.");
                            break;
                        case "B":
                            Console.WriteLine("Du bist nicht der beste, aber immerhin zweiter.");
                            break;
                        case "c":
                            Console.WriteLine("Du solltest noch etwas weiterüben.");
                            break;
                        case "C":
                            Console.WriteLine("Du solltest noch etwas weiterüben.");
                            break;

                        default:
                            Console.WriteLine("Du solltest a, b, und c schon von anderen Zeichen unterscheiden können.");
                            break;
                    }
                    Console.WriteLine("______________________________________");
                    Console.WriteLine();
                    Console.WriteLine("Falls du das Programm beenden möchtest drücke n/N");
                    string exit = Console.ReadLine();
                    if (exit == "n" || exit == "N")
                    {
                        break;
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
           
        }
    }
}


// a du bist super, b du bist 2ter, c übe weiter  if =n break