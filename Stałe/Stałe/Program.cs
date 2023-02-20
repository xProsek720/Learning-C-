using System;

namespace Stałe
{
    internal class Program
    {
        //Najlepiej stałe tworzyć poza metodą w klasie
        //ale chyba nie jest to zasada.

        //Jak nazwa mówi są niezmienne przez cały proces wykonywania programu
        const double shortPI = 3.14159265359;

        static void Main(string[] args)
        {
            Console.WriteLine($"Skrócone PI to: {shortPI}");
            Console.Write("Teraz specjalnie spróbujemy zmienić naszą stałą!");
            //shortPI = Math.Sin(shortPI);                                          //Bez zakomentowania tej lini program nie skompiluje się poprawinie
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" (FUNKCJA WYŁĄCZONA!)");        
            Console.ResetColor();
        }
    }
}
