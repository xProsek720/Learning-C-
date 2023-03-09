namespace Pętla_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsza pętla For:");
            //  wart. start     warunek    zwiekszanie
            for (int licznik = 0; licznik < 10; licznik++)
            {
                Console.WriteLine($"{licznik + 1} jest mniejsze od 10");
            }
            Console.ReadKey();

            Console.WriteLine("\nDruga pętla For:");
            // można zwiększać np. o 5
            for (int licznik = 0; licznik < 50; licznik+=5)
            {
                Console.WriteLine($"{licznik + 1} jest mniejsze od 50");
            }
            Console.ReadKey();

            Console.WriteLine("\nTrzecia pętla For:");
            for (int licznik = 1; licznik < 21; licznik += 2) 
            {
                Console.WriteLine($"{licznik} jest liczbą nieparzystą mniejszą od 20");
            }
            Console.ReadKey();
        }
    }
}