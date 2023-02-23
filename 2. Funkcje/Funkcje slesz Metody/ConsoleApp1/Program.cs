using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public int InputInt() 
        {
            Console.Write("Podaj liczbę: ");
            string inputInt = Console.ReadLine();
            int returnInt;
            if (int.TryParse(inputInt, out returnInt))
            { 
                return returnInt;
            }
            else 
            {
                return 0;
            }
        }

        public int AddInt(int x, int y)
        {
            return x + y;
        }
        

        static void Main(string[] args)
        {
            Program p = new Program();
            int a = p.InputInt();
            int b = p.InputInt();
            int suma = p.AddInt(a, b);
            Console.WriteLine($"Suma {a} + {b} wynosi: {suma}");
        }
    }
}
