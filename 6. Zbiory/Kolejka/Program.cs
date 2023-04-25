namespace Kolejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int helper;
            Queue<int> kolejka = new Queue<int>();

            if (kolejka.TryPeek(out helper)) 
            {
                Console.WriteLine(helper);
            }
            //Dodawanie wartości do kolejki
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);
            kolejka.Enqueue(5);
            kolejka.Enqueue(6);

            //Pewne Podglądanie wartości z kolejki
            Console.WriteLine($"Nastepny nr z kolejki to: {kolejka.Peek()}");

            //Wyciąganie wartości z kolejki
            //Warto dodać ifa
            while (kolejka.Count > 1) 
            {
                Console.WriteLine($"Proszony nr z kolejki: {kolejka.Dequeue()}");
                Console.WriteLine($"Nastepny nr z kolejki to: {kolejka.Peek()}");
            }
            Console.WriteLine($"Proszony nr z kolejki: {kolejka.Dequeue()}");
            Console.WriteLine();



            Queue<Zamowienie> kolejkaZamowien = new Queue<Zamowienie>();
            ForEachKolejka(kolejkaZamowien, JedenCiagZamowien());
            ForEachKolejka(kolejkaZamowien, DrugiCiagZamowien());

            while (kolejkaZamowien.Count > 0) 
            {
                Zamowienie biezaceZamowienie = kolejkaZamowien.Dequeue();
                biezaceZamowienie.PrzetworzZamowienie();
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        public static void ForEachKolejka(Queue<Zamowienie> kolejkaZamowien, Zamowienie[] funkcja) 
        {
            foreach (Zamowienie z in funkcja)
            {
                kolejkaZamowien.Enqueue(z);
            }
        }

        public static Zamowienie[] JedenCiagZamowien()
        {
            Zamowienie[] zamowienia = new Zamowienie[]
            {
                new Zamowienie(3, 2, 420),
                new Zamowienie(4, 1, 77),
                new Zamowienie(5, 1, 500)
            };
            return zamowienia;
        }
        public static Zamowienie[] DrugiCiagZamowien()
        {
            Zamowienie[] zamowienia = new Zamowienie[]
            {
                new Zamowienie(0, 5, 420),
                new Zamowienie(1, 5, 77),
                new Zamowienie(2, 3, 510)
            };
            return zamowienia;
        }
    }
}