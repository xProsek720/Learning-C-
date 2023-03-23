namespace Member_i_Destruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            Czlonek nieznany = new Czlonek();
            Czlonek mL = new Czlonek("Maryla", 99);
            Czlonek kL = new Czlonek("Karolina", 20, "Sekretarka", 10000);
            
            Console.WriteLine($"Osoba {counter++}:");
            nieznany.NazwaStanowiska = "Sprzątacz";
            nieznany.PrzedstawSie(false);

            Console.WriteLine($"Osoba {counter++}:");
            mL.PrzedstawSie(false);

            Console.WriteLine($"Osoba {counter++}:");
            kL.PrzedstawSie(true);
        }
    }
}