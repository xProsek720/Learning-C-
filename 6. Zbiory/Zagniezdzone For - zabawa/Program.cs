namespace Zagniezdzone_For___zabawa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrix = new int[3,3];
            int i, j, counter = 1;

            for (i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (j = 0; j < intMatrix.GetLength(1); j++)
                {
                    intMatrix[i, j] = counter++;
                }
            }
            Console.WriteLine("Macierz: ");
            for (i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (j = 0; j < intMatrix.GetLength(1); j++)
                {
                    Console.Write($"{intMatrix[i, j]} ");
                    Console.Write(" ");
                    if (j == 2) { Console.WriteLine(); }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Lewa Przekątna: ");
            for (i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (j = 0; j < intMatrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{intMatrix[i, j]} ");
                    }
                    Console.Write(" ");
                    if (j == 2) { Console.WriteLine(); }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Prawa Przekątna: ");
            for (i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (j = 0; j < intMatrix.GetLength(1); j++)
                {
                    if ((intMatrix.GetLength(0)-1-i) == j)
                    {
                        Console.Write($"{intMatrix[i, j]} ");
                    }
                    Console.Write(" ");
                    if (j == 2) { Console.WriteLine(); }
                }
            }
            Console.ReadLine();
        }
    }
}