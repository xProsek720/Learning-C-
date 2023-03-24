

namespace Tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oceny = new int[5];

            oceny[0] = 4;
            oceny[1] = 4;
            oceny[2] = 2;
            oceny[3] = 5;
            oceny[4] = 3;

            int index = 0;
            Console.WriteLine($"Ocena na indexie {index}: {oceny[index]}");

            Console.Write("Podaj nową ocene: ");
            string input = Console.ReadLine();
            int.TryParse( input, out oceny[0]);
            
            Console.WriteLine($"Ocena na indexie {index}: {oceny[index]}");
            Console.Read();

            int[] ocenyZMatmy = { 4, 4, 3, 5, 5, };

            int[] ocenyZPolskiego = new int[] { 3, 2, 5, 6, 4, 5};

            Console.WriteLine($"Uczen ma {ocenyZMatmy.Length} ocen z matematyki.");
            Console.WriteLine($"Uczen ma {ocenyZPolskiego.Length} ocen z j. polskiego.");
        }
    }
}