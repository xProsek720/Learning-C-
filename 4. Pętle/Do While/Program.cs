namespace Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            Console.WriteLine("Pierwszy Do While:");
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 5);
            Console.ReadKey();

            counter = 0;
            Console.WriteLine("\nDrugi Do While:");
            do
            {
                Console.WriteLine(counter++);
            } while (counter < 5);
            Console.ReadKey();

            Console.WriteLine("\nTrzeci Do While:");
            int dlugoscTextu = 0;
            do 
            {
                Console.Write("Podaj imie przyjaciela: ");
                string imiePrzyjaciela = Console.ReadLine();
                dlugoscTextu += imiePrzyjaciela.Length;
            } while ( dlugoscTextu < 21);
            Console.WriteLine("Dzięki, starczy!");
            Console.ReadKey();
        
        }
    }
}