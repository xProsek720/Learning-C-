using System.Globalization;

namespace Zadanko_do_Metod
{
    /*Metoda która przywita 3 przyjaciół bez zwracania, pobiera stringa*/
    internal class Program
    {
        static void Main(string[] args)
        {
            PowitajPrzyjaciela("Marcel");
            PowitajPrzyjaciela("Frank");
            PowitajPrzyjaciela("Krystian");
        }

        private static void PowitajPrzyjaciela(string imie)
        {
            Console.WriteLine($"Witaj {imie}, mój przyjacielu!");
        }
    }
}