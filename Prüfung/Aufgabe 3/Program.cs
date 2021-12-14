using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlo_Kyburz_Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("\nMöchten Sie das Programm beenden? Dann drücken sie j/J ansonsten drücken sie eine andere Taste");
                    string eingabe = Console.ReadLine();
                    Console.WriteLine();
                    if (eingabe == "j" || eingabe == "J")
                    {
                        Console.WriteLine("Programm wird heruntergefahren!");
                        break;
                    }
                    Console.WriteLine("Bitte wählen Sie:");
                    Console.WriteLine("Bei einem String die Leerstellen und A/a's zählen                                        [1]");
                    Console.WriteLine("Die Fakultät einer Zahl zwischen 1-20 ausgeben                                           [2]");
                    Console.Write("Einen Array mit gewünschter Grösse und davon Max, Min, Durchschnitt und gerade Zahlen    [3]: ");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.Write("Bitte geben sie einen String ein: ");
                            string str = Console.ReadLine();
                            int a = 0, space = 0;
                            {
                                for (int i = 0; i < str.Length; i++)
                                {
                                    if (str[i] == ' ')
                                    {
                                        space++;
                                    }
                                    if (str[i] == 'a' || str[i] == 'A')
                                    {
                                        a++;
                                    }
                                }
                            }
                            Console.WriteLine($"In Ihrem String hat es {a} a/A's und {space} Leerzeichen");
                            break;
                        case 2:
                            int fak = 1;
                            Console.WriteLine("\n\n");
                            Console.Write("Geben sie eine Zahl von 1-20 ein: ");
                            int insert = Convert.ToInt32(Console.ReadLine());
                            if (insert<1 || insert>20)
                            {
                                Console.WriteLine("Sie müssen schon die richtige Zahl eingeben!");
                                Console.WriteLine("\n\n");
                                break;
                            }
                            else
                            {
                                for (int j = 1;j<=insert;j++)
                                {
                                    fak *= j;
                                }
                                Console.WriteLine($"\n\nDie Fakultät von {insert} beträgt {fak}");
                                Console.WriteLine("\n");
                            }
                            break;
                        case 3:
                            int liste = 0;
                            Console.Write("\nWie viele Stellen soll deine Liste haben?: ");
                            liste = Convert.ToInt32(Console.ReadLine());
                            double[] array = new double[liste];
                            Console.WriteLine($"Bitte gib nun die {liste} Zahlen ein die du in deiner Liste haben möchtest.\n");
                            for (int k = 0; k <= array.Length - 1; k++)
                            {
                                Console.Write($"{k+1}ste Zahl bitte: ");
                                double arrayinsert = Convert.ToDouble(Console.ReadLine());
                                array[k] = arrayinsert;
              
                            }
                            double max = array[0]; double min = array[0]; double d = 0; int even = 0;
                            for (int l = 0; l<=array.Length-1;l++)
                            {
                                Console.Write($"\t{array[l]}");
                                if (array[l] > max) 
                                {
                                    max = array[l];
                                }
                                if (array[l] < min)
                                {
                                    min = array[l];
                                }
                                if (array[l]%2==0)
                                {
                                    even++;
                                }
                                d += array[l];
                            }
                            Console.WriteLine($"\nMax = {max}, Min = {min}, Durchschnitt = {d / array.Length} und es gab {even} gerade Zahlen.");
                            break;
                        default:
                            Console.WriteLine("Sie sollten schon 1, 2 oder 3 eingeben.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
