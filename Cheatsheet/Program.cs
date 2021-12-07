using System;

namespace Cheatsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Die Vergleichsoperatoren (==,!=,>,<,>=,<=) 
             * Arithmetische Operatoren (+,-,*,/,%,++,--)
             * Die logische Operatoren (||,&&,!)

            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String

            int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool	1 bit	Stores true or false values
            char	2 bytes	Stores a single character/letter, surrounded by single quotes
            string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
             
             
             */
             /*   
            Try-catch
              try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
             */
              


            /*
            if
            if (bedingung)
            {

            }
            else if (bedingung 2)
            {

            }
            else
            {

            }
            */


            /*
            switch (expression)
            {
                case x:
                    // code block
                    break;
                case y:
                    // code block
                    break;
                default:
                    // code block
                    break;
            }
            */


            /*
            while (condition)
            {
                // code block to be executed
            }
            */


            /*
            do
            {
                // code block to be executed
            }
            while (condition);
            */


            /*
            for (statement 1; statement 2; statement 3) 
            {
                // code block to be executed
            }
            */



            /*
             *             string[] product = new string[4];

            product[0] = "Nutella";
            product[1] = "Kracker";
            product[2] = "Banana";
            product[3] = "Sesam";

            foreach (string i in product) //string kann auch mit var ersetzt werden, var übernimmt die Speicherart automatisch
            {                            // der var i nimmt in jedem Schleifendurchlauf, den Wert des Arrayinhalts und gibt ihn mit dem cw heraus. 
                Console.WriteLine(i);   
            }
            */

            /* STRINGS
             * 
             int[] array = new int[5];
                        array[0] = 10;
                        array[1] = -3;
                        array[2] = 7;
                        array[3] = 24;
                        array[4] = 50;

                        double[] arrayd = {3.4, 5.1, 4.2, 10.7, 8.9};

                        string[] arrays = { "Basil","Marco","Oliver","Lucian","Nitharsan" };

                        for (int i = 0; i<array.Length; i++)
                        {
                            Console.Write("\t"+arrays[i]);
                        }
            */


            /*
                         Math:
            Math.Pow(x.y);    = Power of x; x mit Potenz y; z.b x=5, y=2 = 25
            Math.Abs(x);      = Die Absolute Funktion nimmt einen Wert an und gibt ihn in Positiv zurück.
            Math.Sign(x);     = Signum Funktion nimmt einnen Wert an und gibt entweder -1, 0 oder 1 zurück. Wenn der Wert (x) negativ
                                ist, bekommt man als Rückgabewert -1 zurück. Wenn der Wert positiv ist, bekommt man eine 1.
                                bei einem Wert von 0 ist auch der Rückgabewert 0.
            Math.sqrt(x)      = Die "Squerroot" Funktion gibt einem die Quadratwurzel einer eingegebener Zahl zurück.
            Math.Round(x,y)   = Diese Methode benutzt man zum Runden auf eine gegeben Nachkommastelle.
                                Der erste Parameter ist die Zahl und der zweiter Parameter ist die gewünschte Nachkommastelle.
            Math.Ceiling(x);  = Die " Dacj" Funktion rundet eine gebene Zahl auf die letzte Ganzzahl ab.
            Math.Floor(x)     = Die "Boden" Funktin rundet eine gebene Zahl aud die letzte Ganzzahl ab.
            */




        }
    }
}
