using System;

namespace MetodyKonsoli
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Definicja kolorów Konsoli i "wyczyszczenie", aby zastosować.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //Zwraca linie.
            Console.Write("Podaj tekst i naciśnij enter: ");
            string inputTekst = Console.ReadLine();
            Console.WriteLine("Podany tekst to: {0}", inputTekst);

            //Zwraca kod ASCI jednej literki.
            Console.Write("Podaj literke i naciśnij enter: ");
            int inputAsciVal = Console.Read();
            Console.WriteLine("Kod ASCI podanej literki to: {0}", inputAsciVal);

            //Reset, żeby późniejsze użytkowanie konsoli nie było z nadanymi kolorami programu.
            Console.ResetColor();

        }
    }
}
