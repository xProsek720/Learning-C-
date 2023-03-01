namespace Wstęp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 15;

            Console.WriteLine($"Temperatura wynosi: {temperatura}");

            if (temperatura < 0) 
            {
                Console.WriteLine("Jest mróz! Ubierz się ciepło!");
            }

            if (temperatura > 0 && temperatura < 10) 
            {
                Console.WriteLine("Weź bluzę, czapkę i długie spodnie!");
            }

            if (temperatura > 10 && temperatura < 20) 
            {
                Console.WriteLine("Weź bluzę!");
            }

            if (temperatura > 20) 
            {
                Console.WriteLine("Dzisiaj jak w lato! B)");
            }
        }
    }
}