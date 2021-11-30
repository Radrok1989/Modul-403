using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace repetition
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            // Eine Forschleife von 0-100. Finden sie alle Zahlen die durch 7 Teilbar sind, addieren sie diese und rechnen sie den Durchschnitt aus.
            double summe = 0;
            int teiler = 0;
            for (int i= 1; i<=100; i++)
            {
                if (i%7==0)
                {
                    summe += i;
                    teiler++;
                    
                }
                
            }
            Console.WriteLine($" Die Summe beträgt {summe} und der Durchschnitt beträgt {summe / teiler}");
            Console.WriteLine($" Es gibt {teiler} Zahlen");
            */


            //3 Versuche, Eingaben von 10-20, Mit einem Switchcase  - Fakultät, Quadratsumme, Alle geraden zahlen von 0-eingabe
            /*int eingabe = 0;
            int menu = 0;
            int insert = 0;

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(  "_____ \n" +
                                    "   // \n" +
                                    "  //    /'\'  |  | |\n" +
                                    " //    /__'\' |__| |\n" +
                                    "//____/    '\'|  | |__\n\n\n");

                    Console.WriteLine("Bitte geben Sie eine Zahl zwischen 10-20 ein.");
                    eingabe = Convert.ToInt32(Console.ReadLine());
                    if (eingabe < 10 || eingabe > 20)
                    {
                        Console.WriteLine("Sie sollten eine Zahl eingeben die zwischen 10 und 20 liegt");
                    }
                    else
                    {
                        Console.WriteLine("Was möchten Sie jetzt mit dieser Zahl anstellen?");
                        Console.WriteLine("Die Fakultät ausrechnen                      [1]");
                        Console.WriteLine("Die Quadratsumme ausrechnen                  [2]");
                        Console.Write("Alle geraden Zahlen anzeigen von 0-Eingabe   [3]  ");
                        insert = Convert.ToInt32(Console.ReadLine());

                        switch (insert)
                        {
                            case 1:
                                int fak = 1;
                                for (int z = 1; z <= eingabe; z++)
                                {
                                    fak *= z;
                                }
                                Console.WriteLine($"Die Fakultät beträgt {fak}");
                                
                                break;
                            case 2:
                                int a = 0;
                                for (int quad = 1; quad <= eingabe; quad++)
                                {
                                    a += quad * quad;
                                }
                                Console.WriteLine($"Die Quadratsumme beträgt {a}");
                                break;
                            case 3:
                                for (int y = 0; y <= eingabe; y += 2)
                                {
                                    Console.Write($"\t{y}");
                                }
                                Console.WriteLine("");
                                break;
                            default:
                                Console.WriteLine("Man sollte schon zwischen 1-3 auswählen können.");
                                break;
                        }
                    }

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            } */



            //10 Eingaben zwischen 20-50 berechnen max min durchschnitt
            /*
            try
            {
                double zahl = 0;
                double max = 0;
                double min = 0;
                double schnitt = 0;

                Console.WriteLine("Ich hätte gerne 10 Zahlen von 20-50.");
                for (int i = 1; i<=10;i++)
                {
                    Console.WriteLine($"Bitte geben sie Ihre {i} Zahl ein");
                    zahl = Convert.ToDouble(Console.ReadLine());
                    if (zahl <= 50 && zahl >=20)
                    {
                        if (i == 1)
                        {
                            max = zahl;
                            min = zahl;
                        }
                        if (zahl < max)
                        {
                            max = zahl;
                        }
                        if (min < zahl)
                        {
                            min = zahl;
                        }

                        schnitt += zahl;
                    }
                    else
                    {
                        Console.WriteLine("Zwischen 20-50!");
                        break;
                    }

                }
                Console.WriteLine($"Max = {max}, Min = {min}, Durchschnitt = {schnitt/10} ");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            */

            //while 20 Prozent Rabatt berechnen

            while(true)
            {
                try
                {
                    Console.WriteLine(" Bitte wählen Sie : ");
                    Console.WriteLine(" Datum ausgeben      [1] : ");
                    Console.WriteLine(" Leerzeichen/Kommas  [2] :");
                    Console.Write(" Ende mit            [0] :\t");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y==0)
                    {
                        Console.WriteLine("Hasta La Vista Baby");
                        break;
                    }
                    switch(y)
                    {

                        case 1:
                            DateTime t = DateTime.Now;
                            Console.WriteLine($"Das heutige Datum ist {t.ToLongDateString()}");
                            break;
                        case 2:
                            Console.WriteLine("Geben Sie bitte einen String mit Leerzeichen und Kommas ein.");
                            string insert = Console.ReadLine();
                            int comma=0, space=0;
                            for (int i=0;i<insert.Length;i++)
                            {
                                if (insert[i] == ' ' )
                                {
                                    space ++;
                                }
                                if (insert[i] == ',')
                                {
                                    comma++;
                                }
                            }
                            Console.WriteLine($"In Ihrem String hat es {comma} Kommas und {space} Leerzeichen");
                            break;
                        default:
                            Console.WriteLine("Falsche Eingabe.");
                            break;

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



            Console.ReadKey();
        }
    }
}

