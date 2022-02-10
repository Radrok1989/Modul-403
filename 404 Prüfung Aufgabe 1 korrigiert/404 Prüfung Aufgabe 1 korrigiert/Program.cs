// See https://aka.ms/new-console-template for more information
/*
Definieren Sie zuerst ein int Array 2-Dimensionen (Matrix) mit 3 Zeilen, 4 Spalten und 
12 Elementen (3,5,18,-2/12,17,6,-7/20,-3,19,99). Implementieren Sie biete ein kurzes Programm mit nur eine Schleife !!!!
so, dass ich a) alle Zahlen auf dem Bildschirm im Tafel/Matrix Form erscheinen und b) das Min, Max, Durchschnitt, 
Anzahl der geraden, ungeraden und negativen Zahlen der Matrix raussuchen und im Bildschirm anzeigen lassen.   */

int[,] array = new int[3,4] { {3,5,18,-2}, {12,17,6,-7}, {20,-3,19,99} };
int min = array[0,0], max = array[0,0], even = 0, odd = 0, sub = 0;
double d = 0;

for (int i=0; i<array.GetLength(0);i++)
{
    for (int j=0;j<array.GetLength(1);j++)
    {
        Console.Write($"\t{array[i, j]}");
        if (array[i, j]>max)
            max = array[i, j];
        if (array[i, j]<min)
            min = array[i, j];
        if (array[i, j] < 0)
            sub++;
        if ((array[i, j] % 2 == 1) || (array[i, j] % 2 == -1))
            odd++;
        else
            even++;
        d+=array[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine($"Max = {max}, Min {min}, Gerade Zahlen = {even}, Ungerade Zahlen = {odd}, Negative Zahlen = {sub}, Durchschnitt {d/(array.GetLength(0)*array.GetLength(1))}");

Console.ReadKey();
