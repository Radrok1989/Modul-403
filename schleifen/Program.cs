using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//TODO 13,14,15,21,22,23,24


namespace schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe 1
             * for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/

            /*Aufgabe 2
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */

            /*Aufgabe 3
             * for (int i = 0; i <= 20; i+= 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey(); */

            /*Aufgabe 4
            for (int i = 20; i >= 0; i--)
            {
                if (i % 2 == 1)
                    {
                    Console.WriteLine(i);
                } 
            }
            Console.ReadKey(); */

            /*Aufgabe 5
            for (int i = 0; i <= 50; i += 3)
            {
                if (i == 0) 
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("\t"+i);
                } 
            }
            Console.ReadKey(); */


             /*Aufgabe 6
            for (int i = 0; i <= 20; i ++)
            {
                if (i == 6 || i == 16)
                {
                    continue;
                }
                else
                {
                    Console.Write("\t"+i);
                }
                
            }
            
            Console.ReadKey();*/


            /*Aufgabe 7 
           int a = 0;
           for (int i = 0; i <= 20; i++)
           {
               a += i;

           }
           Console.WriteLine(a);
           Console.ReadKey();*/

            /* Aufgabe 8
            int a = 0;
            for (int i = 0; i <= 20; i+=2)
            {
                a += i;
                
            }
            Console.WriteLine(a);
            Console.ReadKey(); */

            /* Aufgabe 9
            int a = 0;
            for (int i = 1; i <= 19; i+=2)
            {
                a = a + i;
                Console.WriteLine(a);
            }
            Console.WriteLine(a);
            Console.ReadKey(); */


            /* Aufgabe 10
             int a = 1;
            for (int i = 1; i <= 10; i++)
            {
                a *= i;
                Console.WriteLine(a);
            }
            Console.WriteLine(a);
            Console.ReadKey();*/


            /* Aufgabe 11
            try
            {
                for (int i=1; i <=3;i++)
                {
                    Console.WriteLine("Bitte eine Zahl von 0-10 eingeben");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x >=0 && x<=10)
                    {
                        int qs = 0;
                        for(int j = 0; j <= x; j++)
                        {
                            qs += j * j;
                        }
                        Console.WriteLine($"Die Quadratsumme von 1-{x}={qs}");
                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe Motherfucker");
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();*/

            /* Aufgabe 12
            double b = 0;
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine("Geben sie eine Zahl ein.");
                double a = Convert.ToInt32(Console.ReadLine());
                b += a;
                if (i==10)

                {
                    Console.WriteLine($"Der Durchschnitt beträgt {b / i}.");

                }
            }

            Console.ReadKey();*/


            /* Aufgabe 16
            Console.WriteLine("Geben sie eine Zahl zwischen 1-20 ein.");
            long x = Convert.ToInt32(Console.ReadLine());
            long a = 1;
            for (long i = 1; i <= x; i++)
            {
                a *= i;
                if (i==x)
                {
                    Console.WriteLine($"Die Fakultät beträgt {a}");
                }

            }
            Console.ReadKey();*/


            /*Aufgabe 17
            Console.WriteLine("Geben sie zwei Zahlen ein.");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            if (y > x)
            {
                for (int i = x; i <= y; i++)
                {
                    a += i;
                    if (i==y)
                    {
                        Console.WriteLine($"Die Summe von {x} bis {y} ist {a}");
                    }
                }
            }

            else if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    a += i;
                    if (i == x)
                    {
                        Console.WriteLine($"Die Summe von {y} bis {x} ist {a}");
                    }
                }
            }

            else
            {
                Console.WriteLine("Die Summe ist 0");
            }

            Console.ReadKey();*/

            /* Aufgabe 18
            int g = 14;
            for (int i = 5; i <= 5; i--)
            {
                

                Console.WriteLine($"Leben : {i}");

                Console.WriteLine("Versuchen sie die Geheimzahl zu erraten. 0-30 ");
                int insert = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    Console.WriteLine(" Du hast alle deine Leben verspielt!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                }

                else if (insert == g)
                {
                    Console.WriteLine("Die Geheimzahl ist {0}. Grauliere du hast gewonnen!",g);
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                    
                }
                else if (insert > g)
                {
                    Console.WriteLine("Deine Eingabe war zu hoch.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                   
                }
                else if (insert < g)
                {
                    Console.WriteLine("Deine Eingabe war zu tief");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                    
                }
                else
                {
                    Console.WriteLine("Deine Eingabe ist ungültig.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                    
                }
                Console.ReadKey();*/

            /* Aufgabe 20
            int b = 1;
            for (int i = 1; i <11; i++)
            {
                Console.WriteLine($"{b} x {i} = {b * i}");
                if (i == 10)
                {
                    if (i==10 && b==10)
                    {
                        Thread.Sleep(3000);
                        break;
                    }

                    i = 1;
                    b++;
                }
            }

            Console.ReadKey();*/


        }
    }
}
