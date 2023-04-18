using System.Collections.Generic;
namespace Stos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int popInt = -1;
            Stack<int> stos = new Stack<int>();

            //Dodanie wartości do stosu
            stos.Push(1);

            //Podglądnięcie wartości na "górze" stosu
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");

            stos.Push(2);
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");
            stos.Push(3);
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");
            stos.Push(4);
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");
            stos.Push(5);
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");
            stos.Push(6);
            Console.WriteLine($"Na górze stosu znajduje się: {stos.Peek()}");

            //Wyciągnięcie wartości ze stosu (usuwa ją)
            //Ze sprawdzeniem czy na pewno coś jest na stosie
            //W innym wypadku może wyskoczyć błąd
            if (stos.Count > 0)
                popInt = stos.Pop();
            Console.WriteLine($"Wyciągnięto ze stosu: {popInt}");

            Console.WriteLine();
            Console.WriteLine("Test wypisującej stos Int: ");
            WyciagnijOrazWypisz(stos);

            Console.WriteLine();
            Console.WriteLine("Test metody odwracającej tablice Int: ");
            OdwrocTabliceInt((new int[] { 1, 2, 3, 4, 5, 6 }));

            Console.ReadLine();
        }

        public static void WyciagnijOrazWypisz(Stack<int> stos) 
        {
            int counter = 1;
            while (stos.Count > 0) 
            {
                Console.WriteLine($"{counter++}. {stos.Pop()}");
            }
            Console.WriteLine("Stos jest pusty!");
        }

        public static void OdwrocTabliceInt(int[] ints) 
        {
            Stack<int> revers = new Stack<int>();
            foreach (int liczba in ints) 
            {
                revers.Push(liczba);
            }
            WyciagnijOrazWypisz(revers);
        }

    }
}