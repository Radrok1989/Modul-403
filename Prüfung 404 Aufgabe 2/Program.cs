using System;
using System.Collections.Generic;

namespace Prüfung_404_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while(true)
                {
                    Console.WriteLine("Möchten Sie das Programm fortführen? j/J oder n/N");
                    string answer = Console.ReadLine();
                    if (answer == "n" || answer == "N")
                        break;
                    if (answer == "j"|| answer =="J")
                    {
                        int choose = 0;
                        Console.WriteLine("Wählen Sie");
                        Console.WriteLine("Normale Liste    [1]");
                        Console.Write("Sortierte Liste  [2]:  ");
                        choose = Convert.ToInt32(Console.ReadLine());
                        switch(choose)
                        { 
                            case 1:
                                List<string> Nliste = new List<string>();
                                Console.WriteLine("Bitte geben sie 5 Namen ein");
                                for (int i = 0;i<5;i++)
                                {
                                    string name;
                                    Console.Write($"\nGeben sie den {i+1}sten Namen ein: ");
                                    name = Console.ReadLine();
                                    Nliste.Add(name);
                                }
                                foreach (var x in Nliste)
                                {
                                    if (x =="Batman")
                                        Nliste.Remove("Batman");
                                }
                                Nliste.Sort();
                                Nliste.Reverse();
                                foreach(var x in Nliste)
                                    Console.WriteLine(x);

                                break;

                            case 2:
                                SortedList<string, string> Sliste = new SortedList<string, string>();
                                for (int i = 0;i<5;i++)
                                {
                                    string name; string note;
                                    Console.Write("Geben Sie den Namen des Schülers ein: ");
                                    name = Console.ReadLine();
                                    Console.Write($"\n Geben sie die Note von {name} ein: ");
                                    note = Console.ReadLine();
                                    Sliste.Add(note, name);
                                }
                                
                                foreach (KeyValuePair<string,string> x in Sliste)
                                    Console.WriteLine($"\t Name = {x.Value}, Note = {x.Key}");
                                break;
                            }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
