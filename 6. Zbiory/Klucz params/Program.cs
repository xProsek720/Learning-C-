
namespace Klucz_params
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Gotowy Przykład
                             //String Format                     //Params
            Console.WriteLine("Ocena: {0} | PI: {1} | Waluta: {2}", 5, Math.PI, "PLN");
            Console.WriteLine();
            
            WypisWszystko("Makaron", "Passata", "Mozzarella", "Kurczak", "Oregano", "Bazylia");
            Console.WriteLine();    

            WypiszObiekty("TT", "A4", "A2", "SQ3", 3, 3.2424242, true);
            Console.ReadLine();
        }

        //Przygotowana metoda z params
        public static void WypisWszystko(params string[] input) 
        {
            Console.Write("Lista: ");
            for (int i = 0; i < input.Length; i++) 
            {
                if (i == input.Length - 1) 
                {
                    Console.Write($"{input[i]}.\n");
                }
                else 
                {
                    Console.Write($"{input[i]}, ");
                }
            }
        }

        public static void WypiszObiekty(params object[] obiekty) 
        {
            Console.Write("Obiekty: ");
            foreach (object o in obiekty) 
            {
                Console.Write($"{o}, ");
            }
            Console.CursorLeft -= 2;
            Console.WriteLine(".");
        }


    }
}