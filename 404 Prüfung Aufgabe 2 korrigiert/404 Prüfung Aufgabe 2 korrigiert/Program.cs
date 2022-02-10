// See https://aka.ms/new-console-template for more information

/*
Implementieren Sie eine endlose while Schleife in der Main Methode.Verlagen Sie vom User 2 integer Zahlen
und in der integer Variablen x, y speichern.Dann überprüfen Sie ob(x)< (y)ist und falls(x)< (y)ist, 
lassen Sie die zwei Variablen x, y mittels eine Swap Methode, die in der Parameter-Liste 
Call by Reference Variablen enthält, tauschen und lassen Sie die zwei Variablen x, y im Bildschirm 
anzeigen.Sonst(Falls x >= y) geben Sie eine Message(“ Biete die 1te Zahl soll < (kleiner)als die 2te sein“). 
Mit n/ N Eingabe soll ich die while Schleife verlassen.*/

while(true)
{
    try
    {

        Console.Write("Bitte geben Sie die Zahl X ein : ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nBitte geben Sie die Zahl Y ein : ");
        int  y = Convert.ToInt32(Console.ReadLine());

        if (x < y)
        {
            Swap(ref x, ref y);
            Console.WriteLine($"\nX = {x}, Y = {y}\n");
        }
        else if (x >= y)
            Console.WriteLine("Bitte die erste Zahl soll kleiner als die zweite sein.\n");

        Console.Write("Falls Sie das Programm beenden möchten drücken Sie n/N : ");
        string insert=Console.ReadLine();
        if (insert == "n" || insert == "N")
            break;

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

static void Swap(ref int x,ref int y)
{
    int z = x;
    x = y;
    y = z;
}
