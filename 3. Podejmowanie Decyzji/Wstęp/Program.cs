namespace Wstęp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Smart stacja pogodowa ;p
            string tekstPowitalny = "Podaj temperature na zewnątrz [ w C* ]: ";
            Console.Write(tekstPowitalny);
            string temperaturaInput = Console.ReadLine();
            Console.Clear();
            try
            { 
                int temperaturaLiczba= int.Parse(temperaturaInput);

                Console.WriteLine($"Temperatura wynosi: {temperaturaInput}");

                if (temperaturaLiczba < 0)
                {
                    Console.WriteLine("Jest mróz! Ubierz się ciepło!");

                }
                else if (temperaturaLiczba > 0 && temperaturaLiczba < 10)
                {
                    Console.WriteLine("Weź bluzę, czapkę i długie spodnie!");
                }
                else if (temperaturaLiczba > 10 && temperaturaLiczba < 20)
                {
                    Console.WriteLine("Weź bluzę!");
                }
                else if (temperaturaLiczba < 30)
                {
                    Console.WriteLine("Dzisiaj jak w lato! B)");
                }
                else
                {
                    Console.WriteLine("Upał! Weź wodę!");
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