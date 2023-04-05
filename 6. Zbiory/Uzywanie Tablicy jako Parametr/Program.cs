namespace Uzywanie_Tablicy_jako_Parametr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oceny = new int[] { 5, 5, 4, 4};

            WyswietlOceny(oceny);
            Console.WriteLine($"Średnia tego ucznia wynosi: {Srednia(oceny)}");

            Console.WriteLine("\n");

            //Challange
            int[] szczescie = new int[] { 3, 3, 2, 3, 3 };
            PokazSzczescie(szczescie);
            ZwiekszSzczescie(szczescie);
            PokazSzczescie(szczescie);
            ZwiekszSzczescie(szczescie);
            PokazSzczescie(szczescie);
            Console.ReadLine();


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

        //Referencja i nie musi zwracać :D
        public static void ZwiekszSzczescie(int[] szczescie) 
        {
            Console.WriteLine("Zwiekszam poziomy szczęścia o 2");
            for (int i =0; i < szczescie.Length; i++) 
            {
                szczescie[i] += 2;
            }
        }

        public static void PokazSzczescie(int[] szczescie) 
        {
            Console.Write("Poziomy szczescia tego ucznia: ");
            foreach (int poziom in szczescie)
            {
                Console.Write($"{poziom} ");
            }
            Console.WriteLine();
        }
    }
}