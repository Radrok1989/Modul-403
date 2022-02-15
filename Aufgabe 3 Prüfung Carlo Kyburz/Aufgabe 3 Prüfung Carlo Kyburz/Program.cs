/*
Definieren Sie eine endlose While-Schleife, die eine Abbruchbedingung und eine (try-catch-Anweisung) besitzt, in der man ein Menü 
    mit 2 Wahlfunktionen anzeigt und vom User eine Wahl-Eingabe per Tastatur verlangt.
 Die Wahlfunktionen als Statische Methoden: 1)NListe() und 2)SListe().

 1) Eine Liste mit 3x Namen der A21-Schüler, die ich per Tastatur eingebe, absteigend sortieren und  falls ich den Schüler „Carlos“
    eingebe, dann soll ich ihm korrigieren, als “Carlo“. Am Ende sollen alle Namen auf den Monitor angezeigt werden.
    10p
 2) Eine sortierte Liste, die 5x A21-Schüler aufnehmen kann mit den Noten(key) und die Namen(Value) der A21-Schüler, 
    die ich per Tastatur eingebe und auf den Monitor absteigend auflisten kann. Falls der Schüler Carlo die Note zwischen 
    4,5 und 4,9 hat, dann sollst du die Note auf 5,5 korrigieren und alle Namen mit Noten auf den Monitor auflisten(absteigend).           
*/

while(true)
{
    try
    {
        Console.WriteLine("Wählen Sie:");
        Console.WriteLine("Nliste()     [1]");
        Console.Write("Sliste()     [2] : ");
        int insert = Convert.ToInt32(Console.ReadLine());
        switch (insert)
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

static void Nliste()
{
    List<string> namen = new List<string>();
    for (int i = 1; i < 4; i++)
    {
        Console.Write($"Bitte geben Sie den {i} Namen ein : ");
        string str = Console.ReadLine();
        namen.Add(str);
    }
    if (namen.Contains("Carlos"))
    {
        namen.Remove("Carlos");
        namen.Add("Carlo");
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
        if (namen == "Carlo")
        {
            if (note >= 4.5 && note <= 4.9)
            {
                liste.Add(5.5, namen);
            }
        }
        else
            liste.Add(note, namen);

    }
    int count = 0;
    foreach (KeyValuePair<double, string> x in liste.Reverse())
    {
 
        Console.WriteLine($" {count++}te Name : {x.Value} mit der Note {x.Key} ");

    }
    Console.WriteLine();

}




Console.ReadLine();