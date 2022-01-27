using System;
using System.Collections.Generic;

namespace Testvorbereitung_404
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Namen werden abgefragt und der Liste hinzugefügt und das 5te Element entfernen
            List<string> liste = new List<string>();
            int count = 1;
            while(true)
            {
                Console.Write("Mit j/J Weiter und mit n/N Ende : ");
                string str = Console.ReadLine();
                if (str == "n" || str == "N")
                    break;
                else if(str == "j" || str == "J")
                {
                    Console.Write($"\n Den {count++}ten Namen bitte : ");
                    string name = Console.ReadLine();
                    liste.Add(name);
                }
                else
                    Console.WriteLine("\n Falsche Eingabe");
            }
            foreach(var x in liste)
                Console.WriteLine(x);
            //Das 5te Element löschen
            liste.RemoveAt(4);
            //Ist etwas in der Liste vorhanen? Falls nicht füge es hinzu
            if (liste.Contains("Batman"))
                Console.WriteLine("Batman ist in der Liste");
            else
            {
                Console.WriteLine("Batman ist nicht in der Liste");
                liste.Add("Batman");
            }
            //Liste Sortieren
            liste.Sort(); //liste.Reverse(); Sortiert in umgekehrter Reienfolge

            //Liste Korrigieren
            for (int i=0; i<liste.Count;i++)
            {
                if (liste[i] == "Carlos")
                    liste[i] = "Carlo";
            }

            //Alle Namen die mit S anfangen zählen
            int counter = 0;
            foreach (string x in liste)
            {
                if (x[0] == 'S')
                    counter++;
            }
            Console.WriteLine($"Es gibt {counter} Namen die mit S beginnen.");

            //Erstellen Sie eine Liste mit {10,1,9,2,8,3,7,4,6,5}, dann fügen sie die Zahl -3,-1, 50 und 100. Finden Sie Max,Min,Durchschnitt, Anzahl der gerade, Anzahl der Gerade und der negativen Zahlen.Zeigen Sie alle Ergebnisse im Bildschirm.

            List<int> liste = new List<int>() { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            int max = liste[0]; int min = liste[0]; double d = 0; int g = 0; int ug = 0; int sub = 0;
            liste.Add(-3); liste.Add(-1); liste.Add(50); liste.Add(100);
            foreach (var x in liste)
            {
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
                d += x;
                if (x % 2 == 0)
                    g++;
                if (x % 2 == 1||x % 2 == -1)
                    ug++;
                if (x < 0)
                    sub++;
            }
            Console.WriteLine($"Max = {max}, Min = {min}, Durchschnitt = {d / liste.Count}");
            Console.WriteLine($"Sie haben {g} gerade, {ug} ungerade und {sub} negative Zahlen");


            Console.ReadKey();
        }
    }
}
