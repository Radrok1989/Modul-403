using System;

namespace Hausaufgaben_Methode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Wenn sie das Programm beenden möchten drücken sie j und sonst Enter/Return");
                    string abort = Console.ReadLine();
                    if (abort == "j")
                        break;
                    else
                    {
                        Console.WriteLine("Wählen Sie:");
                        Console.WriteLine("Möchten Sie Max?                 [1]");
                        Console.WriteLine("Möchten Sie Min?                 [2]");
                        Console.WriteLine("Möchten Sie den Durchschnitt?    [3]");
                        Console.WriteLine("Möchten Sie gerade Zahlen?       [4]");
                        Console.WriteLine("Möchten sie ungerade Zahlen?     [5]");
                        Console.Write("Möchten sie den array sortieren? [6]:  ");
                        int switchcase = Convert.ToInt32(Console.ReadLine());
                        int[] array = { 6, 1, 10, 2, 9, 3, 8, 4, 7, 6, 5 };

                        switch (switchcase)
                        {
                            case 1:
                                int max = 0;
                                my_max(array, ref max);
                                Console.WriteLine($"Max = {max}");
                                break;
                            case 2:
                                int min = 0;
                                my_min(array, ref min);
                                Console.WriteLine($"Min = {min}");
                                break;
                            case 3:
                                double d = 0;
                                average(array, ref d);
                                Console.WriteLine($"Durchschnitt = {d}");
                                break;
                            case 4:
                                even(array);
                                break;
                            case 5:
                                odd(array);
                                break;
                            case 6:
                                sort(array);
                                break;
                            default:
                                Console.WriteLine("Musste schon 1-6 eingeben!");
                                break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static void my_max(int[] array, ref int max)
        {
            max = array[0];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i])
                        max = array[i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static void my_min(int[] array, ref int min)
        {
            min = array[0];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (min > array[i])
                        min = array[i];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void average(int[] array, ref double d)
        {
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    d += array[i];
                }
                d = d / array.Length;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void even(int[] array)
        {
            try
            {
                foreach (var x in array)
                {
                    if (x % 2 == 0)
                    {
                        Console.Write($"\t{x}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void odd(int[] array)
        {
            try
            {
                foreach (var x in array)
                {
                    if (x % 2 == 1)
                        Console.Write($"\t{x}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void sort(int[] array)
        {
            try
            {
                Array.Sort(array);
                foreach (var x in array)
                    Console.Write($"\t{x}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
