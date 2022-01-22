using System;
using System.Collections.Generic;

namespace Sortierte_listen_und_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> liste = new SortedList<string, string>();
            liste.Add("one", "Z");
            liste.Add("two", "H");
            liste.Add("three", "A");
            liste.Add("four", "I");
            liste.Add("eight", "B");

            for(int i=0;i<liste.Count;i++)
            {
                Console.WriteLine($"\t Key = {liste.Keys[i]}, Value = {liste.Values[i]}");
            }
            Console.WriteLine("\n\n");
            foreach(KeyValuePair<string, string> k in liste)
            {
                Console.WriteLine($"\t Key = {k.Key}, Value = {k.Value}");
            }

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("one", "Z");
            dict.Add("two", "H");
            dict.Add("three", "A");
            dict.Add("four", "I");
            dict.Add("eight", "B");

            foreach (KeyValuePair<string, string> d in dict)
            {
                Console.WriteLine($"\t Key = {d.Key}, Value = {d.Value}");
            }


            /*  foreach (var x in liste)
              {
                  Console.Write($"\t{x}");
              }*/

            Console.ReadKey();
        }
    }
}
