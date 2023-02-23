using System;
using System.Linq;

namespace Metody_Stringów
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char szukanaLitera;
            string imie, nazwisko, pelnaNazwa, tekst;

            Console.Write("Podaj tekst: ");
            tekst = Console.ReadLine();
            
            Console.WriteLine($"Wpisany tekst wielkimi literami: {tekst.ToUpper()}");
            Console.WriteLine($"Wpisany tekst małymi literami: {tekst.ToLower()}");
            Console.WriteLine($"Wpisany tekst bez zbędnych spacji: {tekst.Trim()}");
            Console.WriteLine($"Substring od indeksu 1: {tekst.Substring(1)}");

            Console.Write("\nPodaj literkę którą chciałbyś wyszukac w tekście: ");
            szukanaLitera = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nPozycja szukanej litery: {tekst.IndexOf(szukanaLitera)}");

            imie = "Filip";
            nazwisko = "W@";
            pelnaNazwa = String.Concat(imie, " ", nazwisko);
            Console.WriteLine($"\nPo połączeniu {imie}, ' ' i {nazwisko} otrzymamy {pelnaNazwa}");
            Console.ReadKey()

        }
    }
}
