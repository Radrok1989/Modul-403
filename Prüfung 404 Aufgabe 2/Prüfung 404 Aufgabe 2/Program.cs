// See https://aka.ms/new-console-template for more information

/*
Implementieren Sie eine endlose while Schleife in der Main Methode.Verlagen Sie vom User 2 integer Zahlen
und in der integer Variablen x, y speichern.Dann überprüfen Sie ob(x)< (y)ist und falls(x)< (y)ist, 
lassen Sie die zwei Variablen x, y mittels eine Swap Methode, die in der Parameter-Liste 
Call by Reference Variablen enthält, tauschen und lassen Sie die zwei Variablen x, y im Bildschirm 
anzeigen.Sonst(Falls x >= y) geben Sie eine Message(“ Biete die 1te Zahl soll < (kleiner)als die 2te sein“). 
Mit n/ N Eingabe soll ich die while Schleife verlassen.*/


while (true)
{
    try
    {
        Console.WriteLine("Falls sie das Programm beenden möchten drücken sie n/N und sonst eine andere Taste");
        string brechen = Console.ReadLine();
        if (brechen == "n" || brechen == "N")
        {
            break;
        }
        else
        {
            int x = 0;
            int y = 0;
            Console.Write("Bitte geben Sie Zahl x ein : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Bitte geben sie Zahl y ein : ");
            y = Convert.ToInt32(Console.ReadLine());


            if (x < y)
            {
                swap(ref x, ref y);
                Console.WriteLine($"Wie Sie sehen wurde x = {x} und y = {y} getauscht. MAGIC!");
            }
            else if (x >= y)
            {
                Console.WriteLine("Biete die 1te Zahl soll < (kleiner)als die 2te sein");
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

}
Console.ReadKey();

static void swap(ref int x, ref int y)
{
    int z = x;
    x = y;
    y = z;

}


