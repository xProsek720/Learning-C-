namespace Wprowadzenie_do_klas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Czlowiek filip = new Czlowiek("Filip", "Proskowy");
            filip.PrzedstawSie();

            Czlowiek marcel = new Czlowiek();
            marcel.PrzedstawSie();
            marcel.imie = "Marcel";
            marcel.UstawNazwisko("Testowy");
            marcel.PrzedstawSie();
        }
    }
}