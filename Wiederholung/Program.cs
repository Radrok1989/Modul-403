using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            /* AUFGABE 1
            int count = 1; double s = 0;
            for (int i=100; i>=50; i-=2)
            {
                try
                {
                    if (i != 80)
                    {
                        s += i;
                        count++;
                        Console.Write("\t" + i);
                    }


                }
                

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"\nAlle geraden Zahlen zwischen 100 und 50 addiert ergeben {s} und der Durchschnitt daraus beträgt {s / count}");
            Console.ReadKey();
            */

            /* AUFGABE 2
            for (int i=1;i<=3;i++)
            {
                string pswd = "1234"; string username = "Batman";
                Console.Write("Bitte geben sie Ihren Username ein: ");
                string user=Console.ReadLine();
                Console.WriteLine();
                Console.Write("Bitte geben sie Ihr Passwort ein: ");
                string password = Console.ReadLine();


                if (user==username && password==pswd)
                {
                    Console.WriteLine($"\nSalee {username} richtig eingeben.");
                    break;
                }
                if (i==1)
                {
                    Console.WriteLine("\nSie haben noch 2 Versuche.");
                    Console.WriteLine("_______________________________________");
                }
                else if (i==2)
                {
                    Console.WriteLine("\nSie haben noch 1 Versuch.");
                    Console.WriteLine("_______________________________________");
                }
                else if (i==3)
                {
                    Console.WriteLine("\nVerkackt jetzt müssen sie 30 Minuten warten bis sie es wieder versuchen können.");
                    
                }


            }
            Console.ReadKey();
            */

            /* AUFGABE 3
            int[] array = new int[3];
            try
            {

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Geben sie die {i+1} Zahl ein");
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
                foreach (int x in array)
                {
                    Console.Write($"\t {x}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
            */

            /* AUFGABE 4
            int[] array = {10,1,9,2,8,3,7,4,6,5};
            int max = array[0]; int min = array[0];double d = 0;
            for (int i=0;i<array.Length;i++)
            {
                if (max < i)
                {
                    max = i;
                }
                if (min > i)
                {
                    min = i;
                }
                d += array[i];
            }
            Console.WriteLine($"Max = {max}, Min = {min}, Durchschnitt = {d/array.Length}");
            */



            /* AUFGABE 5
            Console.WriteLine("Zahl eingeben");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];

            Console.WriteLine($"Die Grösse des Arrays ist {array.Length}");
            */
            /*
            int[,] array = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8, }, { 9, 8, 7, 6 } };
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);i++)
                {

                }
            }

            */
            
            Console.ReadKey();
        }
    }
}
