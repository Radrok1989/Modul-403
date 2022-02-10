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

while(true)
{
    try
    {
        Console.WriteLine("Wählen Sie:");
        Console.WriteLine("Nliste()     [1]");
        Console.Write("Sliste()     [2] : ");
        int insert = Convert.ToInt32(Console.ReadLine());
        switch(insert)
        {
            case 1:
                Nliste();
                break;
            case 2:
                Sliste();
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.ReadLine();

static void Nliste()
{
    List<string> namen = new List<string>();
    for (int i = 1; i < 6;i++)
    {
        Console.Write($"Bitte geben Sie den {i} Namen ein : ");
        string str = Console.ReadLine();
        namen.Add(str);
    }
    if (namen.Contains("Batman"))
        {
        namen.Remove("Batman");
        }
    namen.Sort();
    namen.Reverse();
    foreach (var x in namen)
    {
        Console.WriteLine($"\t {x}");
    }
    Console.WriteLine();
}
static void Sliste()
{
    SortedList<double, string> liste = new SortedList<double, string>();
    for (int i = 1; i < 6; i++)
    {
        Console.Write($"Bitte geben Sie den Namen des {i}ten Schülers ein : ");
        string namen = Console.ReadLine();
        Console.Write($"\n Bitte geben Sie die Note von {namen} ein : ");
        double note = Convert.ToDouble(Console.ReadLine());

        liste.Add(note, namen);

    }
    int count = 1;
    foreach(KeyValuePair<double, string> x in liste.Reverse())
    {
        Console.WriteLine($" {count++}te Name : {x.Value} mit der Note {x.Key} ");

    }
    for (int i = liste.Count-1; i >= 0; i--)
        Console.WriteLine($"\t Note = {liste.Keys[i]}, Name = {liste.Values[i]}");
}