using System.Collections;
namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicjalizacja HashTable - coś jak Dict w pythonie
            Hashtable kodyLotnisk = new Hashtable();

            //Dodawanie wartości
            kodyLotnisk.Add("KTW", "Katowice");
            kodyLotnisk.Add("LTN", "London-Luton");
            kodyLotnisk.Add("BCN", "Barcelona");
            kodyLotnisk.Add("AMS", "Amsterdam");
            kodyLotnisk.Add("DUB", "Dublin");

            //Pojedynczy element wywołany z ID
            Console.WriteLine($"Lotnisko o kodzie KTW to {kodyLotnisk["KTW"]}");

            Console.WriteLine();
            Console.WriteLine("Wszystkie lotniska w Hashtable: ");

            //Wyświetylenie wszystkich wartości Hashtable
                //Hashtable jest wyświetlana w różnej kolejności
            foreach (DictionaryEntry lotnisko in kodyLotnisk) 
            {
                Console.WriteLine($"Kod: {lotnisko.Key}: {lotnisko.Value}");
            }

            //Podobno, gdy pracujemy z klasą należy zrobić cast z value jeśli pod value
            //  kryje się obiekt z klasy
            //Też można w foreach użyć np. kodyLotnisk.Values albo kodyLotnisk.Keys
            //  tzn można iterować tylko po wartościach albo tylko po kluczach.
        }
    }
}