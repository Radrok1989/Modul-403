using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlo_Kaufmann_Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=100;i>=80;i--)
            {
                if (i % 2 == 0)
                {
                    if (i != 90)
                    {
                        Console.Write($"\t{i + 10}");
                    }
                }
                else
                {
                    if (i != 90)
                    {
                        Console.Write($"\t{i}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
