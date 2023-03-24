using System.Diagnostics.Metrics;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numery = new int[10];
            int last = 0;

            for (int i = 0; i < numery.Length; i++) 
            {
                Random rnd = new Random();
                numery[i] = rnd.Next(1, 59);
            }

            Console.WriteLine();
            Console.WriteLine("Zwykły for:");
            Console.WriteLine();
            for (int j = 0; j < numery.Length; j++) 
            {
                Console.WriteLine($"NUMERY[{j}]{numery[j]}");
            }
            Console.WriteLine();

            Console.WriteLine("Foreach:");
            Console.WriteLine();
            int counter = 00;
            foreach (var k in numery)       ///można też int zamiast var
            {
                Console.WriteLine($"NUMERY[{counter++}]: {k}");
            }
            Console.WriteLine();
            Console.ReadLine();

            string[] przyjaciele = { "Uno", "Dos", "Tres", "Cuatro", "Cinco"};
            Console.Clear();
            Console.WriteLine("Ćwiczenie:");
            Console.WriteLine("");

            foreach (string x in przyjaciele) 
            {
                Console.WriteLine($"Witaj {x}!");
            }
            Console.ReadLine();

        }
    }
}