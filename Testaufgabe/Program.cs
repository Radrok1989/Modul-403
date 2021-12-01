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
                    Console.Write("Die 6te Potenz einer Zahl    [2]: ");
                    int insert = Convert.ToInt32(Console.ReadLine());
                    int liste = 0;
                    


                    switch(insert)
                    {
                        case 1:
                            {
                                Console.Write("Wie viele Stellen soll deine Liste haben?: ");
                                liste = Convert.ToInt32(Console.ReadLine());
                                double[] array = new double[liste];
                                Console.WriteLine("Bitte gib nun die Zahlen "+liste+" Zahlen ein die du in deiner Liste haben möchtest.");
                                for (int i = 0; i <= array.Length-1; i++)
                                {
                                    Console.Write("{0}ste Zahl bitte: ",i+1);
                                    double arrayinsert = Convert.ToDouble(Console.ReadLine());
                                    array[i] = arrayinsert;

                                }
                                Console.WriteLine("Voilà dies ist ihre Liste:");
                                for (int j = 0; j < array.Length; j++)
                                {
                                    Console.Write("\t" + array[j]);
                                }

                                break;
                            }
                        case 2:
                            {
                                double eingabe = 0;
                                Console.WriteLine("Geben sie eine Zahl zwischen 1-10 ein");
                                eingabe = Convert.ToInt32(Console.ReadLine());
                                double pow = Math.Pow(eingabe,6);
                                Console.WriteLine($"Die 6te Potenz von {eingabe} ist {pow}");
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
