using System;

namespace Hausaufgaben_Musterlösung_Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnumber = 12;
            double secondnumber = 1000000000;
            int[] array = { 6, 1, 10, 2, 9, 3, 8, 4, 7, 6, 5 };
            Max(array);
            Min(array);
            Dur(array);
            Even(array);
            Odd(array);
            Sort(array);

            Console.WriteLine($"{firstnumber} und {secondnumber} vor dem Swap");
            Swap(ref firstnumber,ref secondnumber);
            Console.WriteLine($"{firstnumber} und {secondnumber} nach dem Swap");

            Console.ReadKey();
        }

        static void Max(int[] x)
        {
            int max = x[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i]>max)
                {
                    max = x[i];
                }
            }
            Console.WriteLine($"Max = {max}");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Min(int[] x)
        {
            int min = x[0];
            for (int i=0; i<x.Length; i++)
            {
                if (x[i]<min)
                {
                    min = x[i];
                }
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Dur(int [] x)
        {
            double d = 0;
            for (int i = 0; i < x.Length; i++)
            {
                d += x[i];
            }
            d = d / x.Length;
            Console.WriteLine($"Der Durchschnitt beträgt {d}");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Even(int [] x)
        {
            foreach(var y in x)
            {
                if (y % 2 == 0)
                {
                    Console.Write($"\t {y}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Odd(int [] x)
        {
            foreach(var y in x)
            {
                if (y%2==1)
                {
                    Console.Write($"\t {y}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Sort(int[] x)
        {
            Array.Sort(x);
            foreach(var y in x)
            {
                Console.Write($"\t{y}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void  Swap(ref double a, ref double b)
        {
            double c = a;
            a = b;
            b = c;
        }

    }
}
