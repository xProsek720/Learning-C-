namespace Pustka
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();
            NapiszCos();
            NapiszCos("testing");
            NapiszCos("do zobaczenia przy klawiaturze ;)");
            p.NapiszLOL();                                  // DON'T DO IT PLS 
            Console.Read();
        }
        public void NapiszLOL() 
        {
            Console.WriteLine("LOL");
        }
        
        public static void NapiszCos(string tekst = "domyślny tekst") 
        {
            Console.WriteLine($"Tekst, który miał się wyświetlić to: {tekst}");
        }
    }
}