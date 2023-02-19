using System;

namespace Zmienne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rok;
            int wiek;
            double d1;
            double d2;
            float f1;
            float f2;
            long l1;

            d1 = 3.14152;
            d2 = 5.1231;
            f1 = 3.14152f;
            f2 = 5.1231f;

            //l1 = 8902139218453945;

            wiek = 18;
            rok = 2023;

            int dataUrodzenia = rok - wiek;
            
            double dDiv = d2 / d1;
            double fDiv = f2 / f1;
            double dIDiv = d1 / wiek;
            
            Console.WriteLine("Osoba urodzona w " + dataUrodzenia + " będzie miała " + wiek + "lat w obecnym roku (tj. 2023).");
            Console.WriteLine("d2: " + d2 + " dzielone przez d1: " + d1 + " równa się " + dDiv);
            Console.WriteLine("f2: " + f2 + " dzielone przez f1: " + f1 + " równa się " + fDiv);
            Console.WriteLine("d1: " + d1 + " dzielone przez wiek: " + wiek + " równa się " + dIDiv);
            Console.WriteLine("Hello World!");
            Console.WriteLine("a raczej, ale ten czas zapierdala!");
            Console.ReadKey();

        }
    }
}
