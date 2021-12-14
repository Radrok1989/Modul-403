using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlo_Kyburz_Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                string pswd = "1234"; string username = "Batman Jack";
                string passwort = "0007"; string name = "James Bond";

                Console.Write("Bitte geben sie Ihren Username ein: ");
                string user = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Bitte geben sie Ihr Passwort ein: ");
                string password = Console.ReadLine();
                if (user == username && password == pswd)
                {
                    Console.WriteLine($"\nSalee {username} richtig eingeben.");
                    break;
                }
                else if(user==name && password==passwort)
                {
                    Console.WriteLine($"\nSalee {name} richtig eingeben.");
                    break;
                }
                if (i == 1)
                {
                    Console.WriteLine("\nSie haben noch 2 Versuche.");
                    Console.WriteLine("_______________________________________");
                }
                else if (i == 2)
                {
                    Console.WriteLine("\nSie haben noch 1 Versuch.");
                    Console.WriteLine("_______________________________________");
                }
                else if (i == 3)
                {
                    Console.WriteLine("\nSie haben 3x das falsche Paswort eingegeben. Jetzt müssen Sie 30 Minuten warten bis sie es wieder versuchen können.");

                }
            }
            Console.ReadKey();
        }
    }
}
