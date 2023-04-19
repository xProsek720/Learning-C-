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

        }
    }
}