namespace Uzywanie_Tablicy_jako_Parametr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oceny = new int[] { 5, 5, 4, 4};

            WyswietlOceny(oceny);
            Console.WriteLine($"Średnia tego ucznia wynosi: {Srednia(oceny)}");
        }
        public static void WyswietlOceny(int[] oceny) 
        {
            Console.Write("Oceny tego ucznia: ");
            foreach (int ocena in oceny)
            {
                Console.Write($"{ocena} ");
            }
            Console.WriteLine();
        }
        public static double Srednia(int[] oceny) 
        {
            int dlugosc = oceny.Length;
            int sum = 0;
            double srednia;

            foreach (int i in oceny) 
            {
                sum += i;
            }
            srednia = (double) sum / (double) dlugosc;
            return srednia;
        }
    }
}