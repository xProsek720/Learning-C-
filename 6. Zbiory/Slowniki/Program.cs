namespace Slowniki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, string> slownik1 = new Dictionary<int, string>() 
            {
                {1, "one"},
                {2, "two"},
                {3, "three" }
            };

            Dictionary<string, string> kody = new Dictionary<string, string>();
            kody.Add("KTW", "Katowice");
            kody["BCN"] = "Barcelona";
                        
            for (int i = 1; i <= slownik1.Count; i++) 
            {
                Console.WriteLine($"slownik1[{i}] = { slownik1[i]}");
            }
            
            Console.WriteLine();
            foreach (string klucz in kody.Keys) 
            {
                Console.WriteLine($"{klucz}: {kody[klucz]}");
            }

            SprawdzKod("AMS", kody);

            Console.WriteLine();
            Console.WriteLine("Zasymulujmy dodanie lotu do Amsterdamu");
            kody.Add("AMS", "Amsterdam");
            SprawdzKod("AMS", kody);

            
            Console.ReadLine();

        }

        public static void SprawdzKod(string kod, Dictionary<string, string> kody) 
        {
            if (kody.ContainsKey(kod))
            {
                Console.WriteLine($"Istnieje połączenie dzisiaj z {kod} - {kody[kod]}");
            }
            else
            {
                Console.WriteLine($"Dzisiaj nie ma żadnego połączenia z {kod}");
            }
        }
    }
}