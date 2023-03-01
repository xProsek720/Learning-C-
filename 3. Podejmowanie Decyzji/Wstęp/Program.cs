namespace Wstęp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj temperature na zewnątrz [ w C* ]: ");
            string temperaturaInput = Console.ReadLine();
            try
            { 
                int temperaturaLiczba= int.Parse(temperaturaInput);

                Console.WriteLine($"Temperatura wynosi: {temperaturaInput}");

                if (temperaturaLiczba < 0)
                {
                    Console.WriteLine("Jest mróz! Ubierz się ciepło!");
                }

                if (temperaturaLiczba > 0 && temperaturaLiczba < 10)
                {
                    Console.WriteLine("Weź bluzę, czapkę i długie spodnie!");
                }

                if (temperaturaLiczba > 10 && temperaturaLiczba < 20)
                {
                    Console.WriteLine("Weź bluzę!");
                }

                if (temperaturaLiczba > 20)
                {
                    Console.WriteLine("Dzisiaj jak w lato! B)");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Był problem z konwersją podanej temperatury! :(");
                Console.WriteLine(ex.Message);
            }

        }
    }
}