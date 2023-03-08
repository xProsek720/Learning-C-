namespace Krótkie_IFY___zadanko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTemperature, wiadomość, template, ifOutput;
            int parsedTemperature;

            wiadomość = "Podaj temperature: ";
            template = "...*C";

            Console.Write(wiadomość+template);
            Console.CursorLeft = wiadomość.Length;
            inputTemperature = Console.ReadLine();

            if (!int.TryParse(inputTemperature, out parsedTemperature)) 
            {
                Console.WriteLine("Problem z konwersją temperatury!");
            }

            ifOutput = parsedTemperature <= 15 ? "Zimno tu, brrr." : parsedTemperature < 29 ? "Temperatura jest okej." : "Tu jest gorąco!";
            Console.WriteLine(ifOutput);

        }
    }
}