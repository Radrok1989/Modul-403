using System;

namespace Testaufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("Wählen sie:");
                    Console.WriteLine("Ein Array erstellen          [1]");
                    Console.WriteLine("Die 6te Potenz einer Zahl    [2]: ");
                    int insert = Convert.ToInt32(Console.ReadLine());

                    switch(insert)
                    {
                        case 1:
                            {

                                break;
                            }
                        case 2:
                            {

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Idiota musche scho 1 oder 2 eingeben.");
                                break;
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
}
