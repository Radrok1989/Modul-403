using System;

namespace Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(int i=0;i<10;i++)
            {
                greeting();
            }

            greeting();
            Console.WriteLine(greetings());
            Console.WriteLine(pi());
            greeting();
            greeting();
            greeting();
            */

            /*
            int a = 1, b = 7;
            Console.WriteLine($"{a} {b}");
            swap(ref a,ref b);
            Console.WriteLine($"{a} {b}");
            */



            Console.ReadKey();
        }

        static void greeting()
        {
            Console.WriteLine("Saleeee");
        }

        static string greetings()
        {
            return "stinker";
        }

        static double pi()
        {
            return Math.PI;
        }

        static void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"SWAP x = {x}, y = {y}");
        }

    }
}
