using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Aufgabe 2
             * try
            {
                Console.Write("Wie hoch sind die Wellen im Moment? Bitte geben sie in Metern an. ");
                double insert = Convert.ToDouble(Console.ReadLine());
                if(insert<=0.4 )
                {
                    Console.WriteLine("Viel Spass beim Baden.");
                }
                else
                {
                    Console.WriteLine("Es ist zu gefährlich, sie dürfen nicht baden gehen.");
                }


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();*/

            /*Aufgabe 3
             * try
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein.");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben Sie noch eine Zahl ein.");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine("Die erste Zahl ist grösser.");
                }
                else if(a < b)
                {
                    Console.WriteLine("Die zweite Zahl ist grösser.");
                }
                else
                {
                    Console.WriteLine("Beide Zahlen sind gleich gross.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*Aufgabe 4
             * try
            {
                Console.WriteLine("Wie alt sind sie?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine($"Sauf du {age}-jährige Sau!");
                }
                else
                {
                    Console.WriteLine($"Mit {age} Jahren darf man noch keinen Alkohol trinken. Sorry Bra!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*Aufgabe 5
             * try
            {
                Console.WriteLine("Was ist die Aussentemperatur?");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp > -15 && temp <7)
                {
                    Console.WriteLine("Ziehe eine Winterjacke an.");
                }
                else if (temp > 7 && temp < 17)
                {
                    Console.WriteLine("Ziehe eine leichte Jacke an.");
                }
                else if (temp > 18 && temp <25)
                {
                    Console.WriteLine("Ziehe ein T-shirt an.");
                }
                else if (temp > 26 && temp <27)
                {
                    Console.WriteLine("Gehe baden.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            /*Aufgabe 6
             * try
            {
                Console.WriteLine("Geben sie die erste Zahl ein.");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben sie die zweite Zahl ein.");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben sie die dritte Zahl ein.");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine("Die erste Zahl ist die grösste.");
                }
                if (b > a && b > c)
                {
                    Console.WriteLine("Die zweite Zahl ist die grösste.");
                }
                if (c > b && c > a)
                {
                    Console.WriteLine("Die dritte Zahl ist die grösste.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/


            /*Aufgabe 7
             * try
            {
                Console.WriteLine("Basil wie viel Geld hast du?");
                double basil = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Beni wie viel Geld hast du?");
                double beni = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Alää wie viel Geld hast du?");
                double aläää = Convert.ToDouble(Console.ReadLine());

                if (basil > beni && basil > aläää)
                {
                    Console.WriteLine("Basil ist ne Rich-Bitch");
                }
                else if (beni > basil && beni > aläää)
                {
                    Console.WriteLine("Chesus Beni du hast echt viel Geld");
                }
                else if (aläää > beni && aläää > basil)
                {
                    Console.WriteLine("Aläää hat ist der Toyboy einer alten frau und sie hat ihm viel Geld vererbt.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/


            /*Aufgabe 8
             * try
            {
                Console.WriteLine("Wie alt sind sie?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <18)
                {
                    Console.WriteLine("Du bist minderjährig.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("Du musst noch etwas arbeiten bis zur Rente.");
                }
                else if (age >= 65)
                {
                    Console.WriteLine("Du bekommst nicht genug AHV.");
                }
                else
                {
                    Console.WriteLine("Du Witzbold. Jünger als 0 geht nicht.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/


            /*Aufgabe 9
             * try
            {
                Console.WriteLine("Petra was hast du gewürfelt");
                int petradice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sandra was hast du gewürfelt.");
                int sandradice = Convert.ToInt32(Console.ReadLine());

                if (petradice > sandradice)
                {
                    Console.WriteLine("Petra du darfst beginnen");
                }
                else
                {
                    Console.WriteLine("Sandra du darfst beginnen.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/


            /*Aufgabe 10
             * try
            {
                Console.WriteLine("Gib die erste Zahl ein.");
                int a= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gib die zweite Zahl ein.");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = a + b;
                if (c == 0)
                {
                    Console.WriteLine("0 ist keine befriedigende Lösung");
                }
                else
                {
                    Console.WriteLine($"{a} + {b} = {c}");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/


            /* Aufgabe 11
             * try
            {
                int geheimzahl = 0;
                while(geheimzahl !=7)
                {
                    Console.WriteLine("Versuche die Geheimzahl zu erraten. Sie ist zwischen 0-10.");
                    int eingabe = Convert.ToInt32(Console.ReadLine());
                    if (eingabe > 7)
                    {
                        Console.WriteLine("Die Zahl ist zu hoch");
                    }
                    else if (eingabe <7)
                    {
                        Console.WriteLine("Die Zahl ist zu tief");
                    }
                    geheimzahl = eingabe;
                    Thread.Sleep(1000);
                    Console.Clear();
                    
                }
                Console.WriteLine($"Bravo du hast die Geheimzahl {geheimzahl} herausgefunden.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            //Aufgabe 12
              try
             {
                Console.WriteLine("Gib die erste Zahl ein.");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gib die zweite Zahl ein");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gib die dritte Zahl ein");
                double c = Convert.ToDouble(Console.ReadLine());

                if (a > b && a > c && b > c)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else if (a > b && a > c && c > b)
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }

                else if (b > a && b > c && a > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
                else if (b > a && b > c && c > a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
                else if (c > a && c > b && a > b)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
 
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

            


        }
    }
}

