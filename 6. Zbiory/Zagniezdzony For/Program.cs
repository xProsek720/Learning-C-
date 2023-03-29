namespace Zagniezdzony_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mam świadomość, że już to zrobiłem w Wielowymiarowości
            //ale w poradniku jest uzyta ciekawa metoda dlatego powtorze
            //przy okazji utrwale sobie tworzenie wielowymiarowych tablic
            //w C#

            int i, j, k;
            int[,,] intMatrix = new int[10, 10, 10];
            
            Random rnd = new Random();

            Console.WriteLine("Nacisnij Enter, aby wygenerować 1000 losowych liczb od 0 do 1000...");
            Console.ReadLine();
            Console.Clear();

            for (i = 0; i < 10; i++) 
            {
                for (j = 0; j < 10; j++) 
                {
                    for (k = 0; k < 10; k++) 
                    {
                        intMatrix[i, j, k] = rnd.Next(0, 1000);
                    }
                }
            }
            Console.WriteLine("Ukończono!");
            Thread.Sleep(1000);
            Console.Clear();
            
            Console.WriteLine("Nacisnij Enter, aby wyświetlić te liczby...");
            Console.ReadLine();

            //EDIT: Piszę o fajnej metodzie, a zapomniałem jej wcześniej użyć
            for (i = 0; i < intMatrix.GetLength(0); i++)
            {
                for (j = 0; j < intMatrix.GetLength(1); j++)
                {
                    for (k = 0; k < intMatrix.GetLength(2); k++)
                    {
                        Console.WriteLine($"intMatrix[{i}, {j}, {k}] = {intMatrix[i, j, k]}"); ;
                    }
                }
            }
            Console.WriteLine("Nacisnij Enter, aby zakończyć program...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}