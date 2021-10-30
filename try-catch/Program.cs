using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dienstag 21.10.21
            try
            {
                /*Console.Write("Geben Sie eine Zahl ein: ");
                int insert = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ihre Zahl ist: " + insert);*/

                //Vergleichsoperatoren - ==, !=, >, >=, <, <=
                //Logische Operatoren - &&, ||, !

                /*bool x = 3 + 5 < 9 + 2; //false
                bool x = 5 + 8 < 9 || 11 == 5 / 2;  //false
                bool x = 5 + 8 > 9 && 11 != 5 / 2;  //true
                Console.Write($" X ist gleich: {x}");*/
                /*int x = 5;
                if (x > 5)
                {
                    x += 7;
                }
                else
                {
                    Console.WriteLine("Leider ist X nicht grösser als 5");
                }
                Console.Write($" X ist gleich: {x}");*/

                



            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey();
        }
    }
}
