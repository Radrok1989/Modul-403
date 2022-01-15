using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufagaben_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe10
            /*
            int[,] array = new int[3, 3] { { 3, 5, 18 }, { 12, 17, 16 }, { 20, 2, 19 } };
            int min = array[0, 0];
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    Console.Write($"\t{array[i,j]}");
                    if (array[i, j] < min)
                        min = array[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine($"min = {min}");
            Console.ReadKey();*/


            //Aufgabe11
            /*
            int[,] array = new int[5, 5];
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    if (i==j)
                    {
                        array[i, j] = 1;
                    }
                    Console.Write($"\t{array[i,j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/


            //Aufgabe12
            int[,] my_array = new int[4, 4] { { 2, -1, 0, -10 }, { 3, -4, 7, -2 }, { 6, -7, 8, -3 }, { 5, -9, 11, -10 } };
            int[,] arrayp = new int[4, 4];
            int[,] arrayn = new int[4, 4];

            for (int i=0;i<my_array.GetLength(0);i++)
            {
                for (int j=0;j<my_array.GetLength(1);j++)
                {
                    if (my_array[i,j]<0)
                    {
                        arrayn[i, j] = my_array[i, j];
                    }
                    else
                    {
                        arrayp[i, j] = my_array[i, j];
                    }
                }
            }
            int k = 0;
            foreach (var x in my_array)
            {
                Console.Write("\t" + x);
                if (k == 3)
                {
                    Console.WriteLine();
                    k = -1;
                }
                k++;
            }
            int z = 0;
            foreach (var x in arrayp)
            {
                Console.Write("\t" + x);
                if (z == 3)
                {
                    Console.WriteLine();
                    z = -1;
                }
                z++;
            }
            int h = 0;
            foreach (var x in arrayn)
            {
                Console.Write("\t" + x);
                if (h == 3)
                {
                    Console.WriteLine();
                    h = -1;
                }
                h++;
            }
            Console.ReadKey();
        }
    }
}
