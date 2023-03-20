namespace Wprowadzenie_do_klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek filip = new Czlowiek("Filip", "Proskowy", 1337, "zielono-niebieski");
            filip.PrzedstawSie();
            Console.WriteLine($"Urodzony: {filip.DajRokUrodzenia()}\t Kolor oczu: {filip.DajKolorOczu()}");

            Czlowiek marcel = new Czlowiek();
            marcel.PrzedstawSie();
            marcel.UstawImie("Marcel");
            marcel.UstawNazwisko("Testowy");
            marcel.PrzedstawSie();

        }
    }
}