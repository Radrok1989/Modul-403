/*
Wenn man(1) eingibt, rufe ich die Methode Eingabe() mit zwei Call By Reference double Variablen und hole ich vom User per 
    Tastatur zwei double Zahlen. Mit  (2) rufe ich die Methode  Swap() mit zwei Call By Reference double Variablen, damit ich die 
    Eingaben : x und y  tauschen kann, nur wenn x<y ist!!!. Wenn x>y ist, dann sollen Sie die Meldung geben 
    (“ Biete die 1te Zahl soll < (kleiner) als die 2te sein“). In Main sollen Sie zuerst die Methode Eingabe() und dann die 
    Methode Swap() aufrufen.

    Mit eine Console.WriteLine() sollen Sie in Output :“ Sie haben Eingabe1=……..  , Eingabe2 =……….gegeben  
    und nach dem Tausch sind Eingabe1=……..  , Eingabe2 =……….“

    (Bitte implementieren sie eine (switch case) bei der Wahl der Methoden.  Bei default geben Sie „Sie haben Keinen gültigen Zahl 
    eingegeben!!!!!“  
*/

while(true)
{
    try
    {
        double a = 0, b = 0;
        Console.WriteLine("Wählen Sie eine Methode:");
        Console.WriteLine("Eingabe()            [1]" );
        Console.WriteLine("Swap()               [2]");
        Console.Write("Beenden              [0]: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 0)
        {
            break;
        }
        switch(input)
        {
            case 1:
                Eingabe(ref a, ref b);
                break;

            case 2:
                Console.Write("Bitte geben Sie die Zahl X ein : ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nBitte geben Sie die Zahl Y ein : ");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x < y)
                {
                    Swap(ref a, ref b);
                    Console.WriteLine($"\nX = {x}, Y = {y}\n");
                }
                else if (x >= y)
                    Console.WriteLine("Bitte die erste Zahl soll kleiner als die zweite sein.\n");
                break;

            default:
                Console.WriteLine("Sie haben Keinen gültigen Zahl eingegeben!!!!!");
                break;
        }
        


    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void Eingabe(ref double a,ref double b)
{
    Console.Write("Bitte Geben Sie die erste Zahl ein  : ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\nBitte geben Sie die zweite Zahl ein  : ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
}
static void Swap(ref double x, ref double y)
{
    double z = x;
    x = y;
    y = z;
}


Console.ReadKey();