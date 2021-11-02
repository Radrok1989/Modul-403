using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Schleife
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                double d = 0;
                double ins = 0;
            Console.WriteLine("Geben sie eine Zahl zwischen 1 und 20 ein");
                ins = Convert.ToDouble(Console.ReadLine());
                double count = 1;
                if (ins >= 1 && ins <= 20)
                {
                    while (count <= ins)
                    {
                        d += count;
                        count++;
                    }
                    Console.WriteLine($"Der Durchschnitt beträgt {d / ins}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

            try
            {
                while (true)
                {
                    Console.WriteLine("If you write stop, i will stop!");
                    string insert = Console.ReadLine();
                    if (insert == "stop")
                    {
                        Console.Clear();
                        Console.WriteLine("ok");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You didn't say stop");
                        Console.Clear();
                    }
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
