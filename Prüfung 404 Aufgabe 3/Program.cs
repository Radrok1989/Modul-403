using System;

namespace Prüfung_404_Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Möchten sie mit dem Programm weiterfahren? j/J, n/N");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                    break;
                if (answer == "j" || answer == "J")
                {
                    Console.Write("Bitte geben sie die Zahl x ein: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Bitte geben sie die Zahl y ein: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (x >= y)
                        Console.WriteLine("Biete die 1te Zahl soll < (kleiner) als die 2te sein. ");
                    else if (x<y)
                    {
                        SWAP(ref x, ref y);
                        Console.WriteLine($"Ihre Zahlen wurden getauscht: x = {x} y = {y}");
                    }
                }
                else
                    Console.WriteLine("Bittte: j/J oder n/N");
            }
        }
        static void SWAP(ref int x , ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}
