using System;

namespace Prüfung_404_Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array = new int[3, 4] { { 3, 5, 18, -2 }, { 12, 17, 6, -7 }, { 20, -3, 19, 99 } };
            int max = array[0, 0];int min = array[0, 0]; double d = 0; int gerade = 0;int ungerade = 0; int negativ = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0;j<array.GetLength(1);j++)
                {
                    Console.Write("\t" + array[i, j]);

                    if (max < array[i, j])
                        max = array[i, j];
                    if (min > array[i, j])
                        min = array[i, j];
                    if (array[i, j] % 2 == 0)
                        gerade++;
                    if (array[i, j] % 2 == 1)
                        ungerade++;
                    if (array[i, j] < 0)
                        negativ++;
                    d += array[i, j];

                }
                Console.WriteLine();
            }
            Console.WriteLine($"Max = {max}, Min = {min}, Durchschnitt = {d/(array.GetLength(0)*array.GetLength(1))}, ungerade = {ungerade}, gerade = {gerade}, negative = {negativ}");
            Console.ReadKey();
        }
    }
}
