using System;
using System.Collections;

namespace stack_und_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            
            Stack karten = new Stack();
            karten.Push("Herz 2");
            karten.Push("Karo 3");
            karten.Push("Pik 7");
            karten.Push("Kreuz 10");
            karten.Push("Herz Ass");
            karten.Push("Pik König");

            //Das oberste aus dem Stack ausgeben und dann entfernen
            Console.WriteLine(karten.Pop()+"\n\n");

            //Das oberste aus dem Stack entfernen
            karten.Pop();

            //Den Stack von oben nach unten ausgeben
            foreach (var x in karten)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine(karten.Peek());
            
            //Praktische Aufgabe
            Console.WriteLine("\n\n");
            Stack a21 = new Stack();
            a21.Push("Basil");
            a21.Push("Gian-Marco");
            a21.Push("Oliver");
            a21.Push("Sarah");
            a21.Push("Alain");
            a21.Push("Beni");

            foreach(var x in a21)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n\n");

            foreach(var x in a21)
            {
                if(x=="Oliver")
                {
                    break;
                }

                Console.WriteLine(x);

            }
            a21.Push("Carlo");
            a21.Push("Nick");

            Console.WriteLine("\n\n");

            foreach (var x in a21)
            {
                Console.WriteLine(x);
            }
            

            //Queue
            Queue warteschlange = new Queue();
            //Der Queue etwas hinzufügen
            warteschlange.Enqueue("Basil");
            warteschlange.Enqueue("Batman");
            warteschlange.Enqueue("Superman");
            warteschlange.Enqueue("Joker");
            warteschlange.Enqueue("Iron Man");
            warteschlange.Enqueue("Captain America");
            warteschlange.Enqueue("Green Arrow");


            //Das Ende der Warteschlange ausgeben
            Console.WriteLine(warteschlange.Peek()+"\n\n");

            //Warteschlange ausgeben
            foreach(var x in warteschlange)
            {
                Console.WriteLine(x);
            }
            //Den vordersten in der Warteschlange rausnehmen. Mit cw kann man es auch anzeigen
            warteschlange.Dequeue();
            
            // Die 3 vordersten in der Warteschlange rausnehmen
            for (int i = 0; i < 3; i++)
                warteschlange.Dequeue();
            
            Console.ReadKey();
        }
    }
}
