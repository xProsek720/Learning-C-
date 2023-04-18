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

            //Wyciągnięcie wartości ze stosu (usuwa ją)
            //Ze sprawdzeniem czy na pewno coś jest na stosie
            //W innym wypadku może wyskoczyć błąd
            if (stos.Count > 0)
                popInt = stos.Pop();
            Console.WriteLine($"Wyciągnięto ze stosu: {popInt}");
        
        }
    }
}