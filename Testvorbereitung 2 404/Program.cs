using System;
using System.Collections.Generic;

namespace Testvorbereitung_2_404
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // 2D-Array
            string[,] array = new string[2, 3]{ { "Basil", "Nick", "Gian-Marco" }, { "Oliver", "Lucian", "Nitharsan" } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\n Geben sie den {i+1}/{j+1} Namen ein : ");
                    string name = Console.ReadLine();
                    array[i, j] = name;
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == "Lucian")
                        Console.Write("\tWow");
                    else
                        Console.Write("\t"+array[i,j]);
                    
                }
                Console.WriteLine();
            }*/
            /*
            // Methode Fakultät siehe unten
            double x = 10; double q = 0;
            Console.WriteLine($"\n Fakultät von {x} = {Fakultaet(x)}");

            //Methode Quadrat siehe unten
            
            Qflaeche(x,ref q);
            Console.Write($"\n die Quadratfläche von {x} = {q}");
            */
            //Listen
            List<string> liste = new List<string>() { "Basil", "Ironman", "Batman" };
            //liste[0] = "Basil";
            //liste[1] = "Superman";
            foreach (var x in liste)
            {
                Console.Write("\n" + x);
            }
            Console.WriteLine($"\n{liste[1]} hat {liste[1].Length} Buchstaben");
            Console.ReadKey();
        }
        static double Fakultaet(double a)
        {
            double f = 1;
            for(int i=1;i<=a;i++)
            {
                f *= i; //f=f*i;
            }

            return f;
        }
        static void Qflaeche(double s, ref double q)
        {
            q=Math.Pow(s, 2);
        }
    }
}
