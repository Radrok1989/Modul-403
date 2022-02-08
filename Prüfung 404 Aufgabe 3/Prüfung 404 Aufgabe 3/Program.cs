// See https://aka.ms/new-console-template for more information
/*
Definieren Sie eine endlose While-Schleife, die eine Abbruchbedingung und eine (try-catch-Anweisung) besitzt, 
 in der man ein Menü mit 2 Wahlfunktionen anzeigt und vom User eine Wahl-Eingabe per Tastatur verlangt.
 Die Wahlfunktionen als Statische Methoden: 1)NListe() und 2)SListe().
 1) Eine Liste mit 5x Namen der Schüler, die ich per Tastatur eingebe, absteigend sortieren und  falls ich den Schüler 
    „Batman“ eingebe, dann soll ich ihm entfernen. Am Ende sollen alle Namen auf den Monitor angezeigt werden.   10p
 2) Eine sortierte Liste, die 5x Schüler aufnehmen kann mit den Noten(key) und die Namen(Value) der Schüler, 
    die ich per Tastatur eingebe, und auf den Monitor absteigend auflisten kann.                                                                          
*/

while (true)
{
    try
    {
        Console.WriteLine("Falls Sie das Programm beenden möchten drücken sie n/N und sonst eine andere Taste");
        string brechen = Console.ReadLine();
        if (brechen == "n" || brechen == "N")
            break;
        else
        {
            Console.WriteLine("Bitte Wählen Sie");
            Console.WriteLine("Die Normale Liste    [1]");
            Console.Write("Die sorted list      [2] : ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    nListe();
                    break;
                case 2:
                    sListe();
                    break;
            }

        }

    }
    catch (Exception e)
    { Console.WriteLine(e.Message); }
}
Console.ReadKey();
static void nListe()
{
    List<string> namen = new List<string>();
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine($"\n Bitte geben sie den {i} Namen ein : ");
        namen.Add(Console.ReadLine());

    }
    if (namen.Contains("Batman"))
    {
        namen.Remove("Batman");
    }
    for (int i = 0;i<namen.Count;i++)
    {

            Console.Write("\t"+namen[i]);
    }
    Console.WriteLine();
    
    
}
static void sListe()
{
    SortedList<float , string> liste = new SortedList<float , string>();
    for (int i = 1; i < 6;i++)
    {
        Console.Write("Bitte geben Sie den Namen des Schülers ein : ");
        string namen = Console.ReadLine();
        Console.Write($"Bitte geben Sie die Noten von {namen} ein : ");
        float note = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        liste.Add(note, namen);
    }
    for (int i = 4; i >= 0; i--)
        Console.WriteLine($"\t Note = {liste.Keys[i]}, Name = {liste.Values[i]}");
}
