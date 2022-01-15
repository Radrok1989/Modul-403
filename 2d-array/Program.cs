using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            
            int[,] array = new int[3, 4] { { 3, 2, 7, 5 }, { 8, 5, 10, 3 }, { 1, 5, 2, 9 } };
            for(int i = 0; i<array.GetLength(0);i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    Console.Write("\t"+array[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            */


            /*
            int[,] array = new int[3, 4] { { 3, 7, 1, 10 }, { 4, 6, 8, 2 } ,{ 5, 3, 9, 11 } };
            int max = array[0, 0]; int min = array[0, 0];double d = 0;int ung = 0;int count=0;
            for (int i=0; i<array.GetLength(0);i++)
            {
                for (int j = 0; j<array.GetLength(1);j++)
                {
                    Console.Write("\t"+array[i,j]);
                    if (max < array[i,j])
                    {
                        max = array[i, j];
                    }
                    if (min > array[i,j])
                    {
                        min = array[i, j];
                    }

                    d += array[i, j];

                    if (array[i,j]%2==1)
                    {
                        count++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Max = {max}, Min = {min}, Durchschnitt = {d/array.Length} und es gibt {count} ungerade Zahlen");
            Console.ReadKey();
            */

            /*
            int[,] array = new int[3, 4] { { 3, 7, 1, 10 }, { 4, 6, 8, 2 }, { 5, 3, 9, 11 } };
            int[,] garray = new int[3, 4];
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0; j<array.GetLength(1);j++)
                {
                    if (array[i,j]%2==0)
                    {
                        garray[i, j] = array[i, j];
                        Console.Write("\t"+garray[i,j]);
                    }
                    else
                    {
                        garray[i, j] = 1;
                        Console.Write("\t"+garray[i,j]);
                    }
                    
                }
                Console.WriteLine();
            }
            

            Console.ReadKey();

            */
            /* //WICHTIG

            int[,] array = new int[3, 4] { { 3, 7, 1, 10 }, { 4, 6, 8, 2 }, { 5, 3, 9, 11 } };
            int k = 0;
            foreach (var x in array)
            {
                Console.Write("\t"+x);
                if (k==3)
                {
                    Console.WriteLine();
                    k = -1;
                }
                k++;
            }
            Console.ReadKey();
            */

            /*

            int[,] array = new int[3, 4];int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Bitte geben sie die {array.Length-count}te Zahl ein: ");
                    array[ i,j ] = Convert.ToInt32(Console.ReadLine());
                    count++;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"\t {array[i,j]}");
                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */
            
            /*
            int summe = 0;
            int[,] array = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    if (i==j)
                    {
                       summe+=array[i,j];
                    }
                }
            }
            Console.WriteLine(summe);

            Console.ReadKey();

            */
        }
    }
}
