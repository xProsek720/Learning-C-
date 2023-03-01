namespace If_z_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wiekParsed;
            Console.Write("Podaj swój wiek: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out wiekParsed))
            {
                Console.WriteLine("Udało się poprawnie wczytać wiek!");
            }
            else 
            {
                Console.WriteLine("Przykro mi, ale był problem z odczytaniem wieku!");
            }

            Console.Write($"Masz {wiekParsed}lat i możesz iść sobie kupić ");
            if (wiekParsed >= 18)
            {
                Console.WriteLine("piwko.");
            }
            else 
            {
                Console.WriteLine("soczek.");
            }
        }
    }
}