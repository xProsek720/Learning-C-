using System;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parsedIntFromString;
            string inputFromUser;

            string stringForFloat = "0,67"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float parsedFloat = float.Parse(stringForFloat);
            int parsedInt = int.Parse(stringForInt);

            Console.WriteLine("Testowa suma: {0}", (float)parsedInt + parsedFloat);

            //Jeszcze nie pora na obsługę wyjątków
            //Nie moja wina :c
            Console.Write("Podaj liczbę całkowitą: ");
            inputFromUser = Console.ReadLine();
            parsedIntFromString = Int32.Parse(inputFromUser);
            Console.WriteLine("Out: {0}", parsedIntFromString + 1337);

            Console.ReadKey();

        }
    }
}
