using System;

namespace Konwersja
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int leetInt;
            int testInt;

            double leet = 13.37;
            double testDouble = 99.99;

            //Ten sposób obcina nam liczbę po przecinku
            //więc czasem warto zaokrąglić Math.Round b4
            leetInt = (int) leet;
            testInt = (int) testDouble;

            Console.WriteLine("Liczby przed konwersją: {0}; {1}", leet, testDouble);
            Console.WriteLine("Liczby po konwersji: {0}; {1}", leetInt, testInt);
            Console.ReadKey();

        }
    }
}
