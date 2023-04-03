namespace Postrzepione_Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicjacja postrzepionej tablicy
            int[][] postrzepionaTablica = new int[3][];


            //Dodanie wartości do PT
            postrzepionaTablica[0] = new int[3];
            postrzepionaTablica[1] = new int[5];
            postrzepionaTablica[2] = new int[2];

            postrzepionaTablica[0] = new int[] { 1, 2, 3};
            
            postrzepionaTablica[1] = new int[] { 1, 2, 3, 4, 5 };
            
            postrzepionaTablica[2][0] = 1;
            postrzepionaTablica[2][1] = 7;

            //Zainicjowanie oraz Dodanie wartości do PT2
            int[][] postrzepionaTablica2 = new int[][]
            {
                new int[] { 1,2,3,4,5,6},
                new int[] { 1,2,3 },
                new int[] { 1,2,4,65}
            };

            //Wyświetlenie wartości PT
            Console.WriteLine("postrzępiona Tablica:");
            for (int i = 0; i < postrzepionaTablica.GetLength(0); i++)
            {
                for (int j = 0; j < postrzepionaTablica[i].GetLength(0); j++)
                {
                    Console.WriteLine($"PT[{i}][{j}] = {postrzepionaTablica[i][j]}");
                }
                Console.WriteLine();
            }

            //Wyświetlenie wartości PT2
            Console.WriteLine("postrzępiona Tablica2:");
            for (int i = 0; i < postrzepionaTablica2.GetLength(0); i++) 
            {
                for (int j = 0; j < postrzepionaTablica2[i].GetLength(0); j++) 
                {
                    Console.WriteLine($"PT2[{i}][{j}] = {postrzepionaTablica2[i][j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}