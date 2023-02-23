using System;

namespace Konwersja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double convertedFloatToDouble;

            float testFloat;
            
            long testLong;

            int leetInt;
            int testInt;

            bool programIsRunning = true;

            double leet = 13.37;
            double testDouble = 99.99;

            testFloat = 321.5f;

            //Ten sposób obcina nam liczbę po przecinku
            //więc czasem warto zaokrąglić Math.Round b4
            leetInt = (int) leet;
            testInt = (int) testDouble;

            //Bezpośrednia konwersja
            testLong = leetInt;
            convertedFloatToDouble = testFloat;

            //Konwersja na tekst
            string convertedFloatToText = testFloat.ToString();                                                             //JAVA! XD
            string convertedBooleanToText = programIsRunning.ToString();

            Console.WriteLine("Liczby przed konwersją: {0}; {1}; {2}; {3}", leet, testDouble, leetInt, testFloat);
            Console.WriteLine("Liczby po konwersji: {0}; {1}; {2}; {3}", leetInt, testInt, testLong, convertedFloatToDouble);
            Console.WriteLine("Teksty powstałe z konwersji: {0}; {1}", convertedFloatToText, convertedBooleanToText);       //do WriteLine jest to zbędne
            Console.ReadKey();

        }
    }
}
