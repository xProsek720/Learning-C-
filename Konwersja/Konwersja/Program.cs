using System;

namespace Konwersja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int leetINT;

            double leet = 13.37;

            leetINT = (int) leet;

            Console.WriteLine("Liczba przed konwersją: {0}", leet);
            Console.WriteLine("Liczba po konwersji: {0}", leetINT);
            Console.ReadKey();

        }
    }
}
