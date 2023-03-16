namespace break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
                if (i == 6) 
                {
                    Console.WriteLine("Zatrzymujemy się na 6.");
                    break;
                }
            }
            Console.Read();

            for (int i = 0; i <= 12; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine($"We skip {i}.");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}