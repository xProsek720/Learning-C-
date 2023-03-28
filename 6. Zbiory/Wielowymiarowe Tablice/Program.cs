using System.Diagnostics.Metrics;

namespace Wielowymiarowe_Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2d
            string[,] macierz;

            //3d
            int[,,] macierz2;

            //inicjalizacja 2d tablicy
            int[,] macierz3 = new int[,] 
            {
                { 1,2,3}, 
                { 2,4,5}, 
                { 3,5,6}
            };
            Console.WriteLine($"Na środku macierzy jest {macierz3[1,1]}");
            Console.WriteLine($"Macierz[2,0]: {macierz3[2,0]}");
            Console.WriteLine($"Rząd(Wymiar) wynosi: {macierz3.Rank}");
            Console.Read();

            //inicjalizjacja 3d tablicy
            int counter = 1;
            macierz2 = new int[10, 10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    for (int k = 0; k < 10; k++)
                    {
                        macierz2[i, j, k] = counter++;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    for (int k = 0; k < 10; k++)
                    {
                        Console.WriteLine($"Macierz[{i}, {j}, {k}] = {macierz2[i, j, k]}");
                    }
                }
            }
            Console.WriteLine($"Rząd(Wymiar) wynosi: {macierz2.Rank}\n");
            Console.ReadLine();             //Don't work otherwise
            Console.ReadLine();

            //inna metoda inicjalizjacji
            bool[,] test = { { true, true }, { false, false } };
            int counterX = 0;
            int counterY = 0;
            foreach (var t in test) 
            {
                if (counterY == 2) 
                {
                    counterX++;
                    counterY = 0;
                }
                Console.WriteLine($"test[{counterX}, {counterY}] = {t}");    
                counterY++;
            }
            Console.ReadLine();
        }
    }
}