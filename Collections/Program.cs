using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> liste = new List<double>() { 7.3, 3.1, 6.5 };

            foreach (var x in liste)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine();
            liste.Add(99.99);

            foreach (var x in liste)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"\tAnzahl der Elemente: {liste.Count}");
            Console.WriteLine("\n");
            liste.Sort();
            foreach (var x in liste)
            {
                Console.Write($"\t {x}");
            }
            liste.Add(6.5);
            liste.Remove(6.5);
            Console.WriteLine("\n");

            foreach (var x in liste)
            {
                Console.Write($"\t {x}");
            }

            List<string> listeS = new List<string>() { "Basil", "Oliver", "Gian-Marco", "Alain", "Carlo" };
            //listeS.Clear();
            listeS.Add("Sarah");
            //listeS.Remove("Alain");
            if (listeS.Contains("Carlo"))
                listeS.Remove("Carlo");
            Console.WriteLine();
            foreach (var x in listeS)
            {
                Console.Write($"\t {x}");
            }


            Console.ReadKey();
        }
    }
}
