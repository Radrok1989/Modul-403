using System;
using System.Collections.Generic;

namespace Aufgaben_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Erstellen Sie eine Liste mit Namen der Klasse ILB A21
            List<string> ilba21 = new List<string>() { "Basil", "Alain", "Beni", "Sarah", "Nithi", "Lucian", "Gian-Marco", "Oli", "Nick", "Carlo" };

            //2 Lassen Sie die Liste auf dem Monitor anzeigen
            foreach (var x in ilba21)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine();

            //3 Löschen Sie das 5 Element
            ilba21.RemoveAt(4);

            //4 Fügen Sie das Element wieder hinzu
            ilba21.Add("Nithi");

            //5 Untersuchen Sie in der Liste ob Batman existiert. Wenn nicht fügen sie ihn hinzu.
            if (ilba21.Contains("Batman"))
            {
                Console.WriteLine("Batman ist schon enthalten in der Liste");
            }
            else
            {
                ilba21.Add("Batman");
            }

            //6 Sortieren Sie die Liste und geben sie die Namen auf dem Monitor aus
            ilba21.Sort();
            foreach (var x in ilba21)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine();

            //7 Listen Sie alle Namen auf dem Bildschirm und wenn Carlo als Carlos geschrieben ist, bitte korrigieren Sie es
            if (ilba21.Contains("Carlos"))
            {
                ilba21.Remove("Carlos");
                ilba21.Add("Carlo");
            }
            foreach (var x in ilba21)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine();

            //8 Listen Sie alles rückwerts auf.
            ilba21.Reverse();
            foreach (var x in ilba21)
            {
                Console.Write($"\t {x}");
            }
            Console.WriteLine();

            //9 Zählen Sie alle Namen die mit S anfangen
            int count = 0;
            for(int i=0;i<ilba21.Count;i++)
            {
                bool result;
                result = ilba21[i].StartsWith("S");
                if (result == true)
                {
                    count++;
                }
            }
            Console.WriteLine($"In dieser Klasse gibt es {count} Person/en*in/innen die mit S beginnen.");

            //11 Erstellen Sie eine Liste mit {10,1,9,2,8,3,7,4,6,5}, dann fügen sie die Zahl -3,-1, 50 und 100. Finden Sie Max,Min, Durchschnitt, Anzahl der gerade, Anzahl der Gerade und der negativen Zahlen.Zeigen Sie alle Ergebnisse im Bildschirm.

            List<int> zahlen = new List<int>() { 10, 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            zahlen.Add(-3);
            zahlen.Add(-1);
            zahlen.Add(50);
            zahlen.Add(100);
            int max = zahlen[0]; int min = zahlen[0];
            double d = 0;
            int even = 0;
            int odd = 0;
            int sub = 0;
            for(int i=0;i<zahlen.Count;i++)
            {
                if (zahlen[i] > max)
                    max = zahlen[i];
                if (zahlen[i] < min)
                    min = zahlen[i];
                if (zahlen[i] % 2 == 0)
                    even++;
                if (zahlen[i] % 2 == 1)
                    odd++;
                if (zahlen[i] < 0)
                    sub++;
                d += zahlen[i];
            }
            Console.WriteLine($"Max = {max}, Min = {min}, Gerade Zahlen = {even}, Ungerade Zahlen = {odd}, Negative Zahlen = {sub}, Durchschnitt = {d/zahlen.Count}");

            //12 Erstellen sie eine ListeU und ListeG und übertragen sie alle geraden/ungeraden Zahlen
            List<int> listeg = new List<int>();
            List<int> listeu = new List<int>();
            for(int i = 0;i<zahlen.Count;i++)
            {
                if (zahlen[i] % 2 == 0)
                    listeg.Add(zahlen[i]);
                else
                    listeu.Add(zahlen[i]);
            }
            Console.WriteLine("Die geraden Zahlen sind: ");
            foreach (var x in listeg)
                Console.Write($"\t {x}");
            Console.WriteLine("\nDie ungeraden Zahlen sind: ");
            foreach (var x in listeu)
                Console.Write($"\t {x}");
            Console.WriteLine();

            //13 Quadratsumme aus listeg und listeu
            int qsug = 0;
            int qsuu = 0;
            foreach (var x in listeg)
                qsug += x * x;
            foreach (var x in listeu)
                qsuu += x * x;
            Console.WriteLine("Quadratsumme aus den Ungeraden: "+qsuu);
            Console.WriteLine("Quadratsumme aus den Geraden: "+qsug);
            Console.ReadKey();
        }
    }
}
