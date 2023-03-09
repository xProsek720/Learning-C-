using System.Xml;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int licznik = 0;

            Console.WriteLine("Pierwszy While: ");

            while (licznik < 10) 
            {
                Console.WriteLine($"{licznik} jest mniejsze niż 10");
                licznik++;
            }


            Console.WriteLine("\nDrugi While: ");

            int licznikLudzi = 0;
            string text = $"Jest Ludzi: ";
            Console.WriteLine(text + "0");
            Console.WriteLine("Kliknij ENTER aby policzyć osobę!");
            Console.CursorTop-=2;
            while (licznikLudzi < 30) 
            {

                if (Console.Read() == 13) 
                {
                    Console.CursorTop--;
                    Console.CursorLeft = text.Length;
                    Console.WriteLine(licznikLudzi++ + 1);
                    Console.CursorTop--;
                }
            }
            Console.WriteLine("Wszyscy są!");

            Console.ReadKey();
        }
    }
}