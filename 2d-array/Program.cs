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

        }
    }
}
