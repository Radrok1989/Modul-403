using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = new int[5];
            array[0] = 10;
            array[1] = -3;
            array[2] = 7;
            array[3] = 24;
            array[4] = 50;

            double[] arrayd = {3.4, 5.1, 4.2, 10.7, 8.9};

            string[] arrays = { "Basil","Marco","Oliver","Lucian","Nitharsan" };

            for (int i = 0; i<array.Length; i++)
            {
                Console.Write("\t"+arrays[i]);
            }

            Console.WriteLine(); ;

            foreach(var x in array)
            {
                Console.Write("\t" + x);
            }
            Console.WriteLine();
            int max = array[0], min = array[0];
            double d = 0;
            for (int i= 0; i<array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
                else if (array[i]<min)
                {
                    min = array[i];
                }
                d += array[i];


            }
            Console.WriteLine($"\tMax = {max}, Min = {min}, Durchschnitt = {d/array.Length}");
            double miau = 0;
            foreach(var x in array)
            {
                if (x > max)
                {
                    max = x;
                }
                else if (x < min)
                {
                    min = x;
                }
                miau += x;
            }
            Console.WriteLine($"\tMax = {max}, Min = {min}, Durchschnitt = {d / array.Length}");
            */
            int[] array = { 3, 7, 1, 8, 2, 9, 4, 10, 5, 6 };
            Array.Sort(array);
            foreach(var x in array)
            {
                Console.WriteLine("\t"+x);
            }
            Console.WriteLine($"\n\n Max = {array[array.Length-1]}, Min = {array[0]}");

            int k = 0;
            int[] even = new int[array.Length];
            foreach(var x in array)
            {
                if(x % 2 == 0)
                {
                    even[k++] = x;
                    
                }
            }
            foreach(var x in even)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();

        }
    }
}