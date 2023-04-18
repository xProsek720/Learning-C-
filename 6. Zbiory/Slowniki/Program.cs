namespace Slowniki
{
    internal class Program
    {
        public static string Convert(int i)
        {
            string ret;
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };
            if (!(i <= 5 && i >= 0))
            {
                ret = "nope";
            }
            else
            {
                ret = dict[i];
            }
            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Convert(2));
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
            SprawdzKod2("AMS", kody);

            Console.WriteLine("Dodajmy jeszcze Dublin");
            kody.Add("DUB", "Dublin");
            WypiszWszytkie(kody);

            Console.WriteLine();
            SprawdzIDodaj(kody, "BER", "Berlin");
            SprawdzIDodaj(kody, "AMS", "TEST");

            SprawdzIDodaj(kody, "TST", "TEST");
            SprawdzIUsun(kody, "LOL");
            SprawdzIUsun(kody, "TST");
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
        public static void SprawdzKod2(string kod, Dictionary<string, string> kody)
        {
            string wartosc;
            if (kody.TryGetValue(kod, out wartosc))
            {
                Console.WriteLine($"Istnieje połączenie dzisiaj z {kod} - {kody[kod]}");
            }
            else
            {
                Console.WriteLine($"Dzisiaj nie ma żadnego połączenia z {kod}");
            }
        }

        public static void WypiszWszytkie(Dictionary<string, string> kody) 
        {
            Console.WriteLine();
            Console.WriteLine("Rozpoczynam wypisywanie:");
            for (int i = 0; i < kody.Count; i++) 
            {
                Console.WriteLine($"kody.ElementAt({i}): {kody.ElementAt(i).Key} - {kody.ElementAt(i).Value}");
            }
            Console.WriteLine("Zakończono!");
        }

        public static void SprawdzIDodaj(Dictionary<string, string> dict, string key, string value) 
        {
            if (dict.ContainsKey(key))
            {
                Console.WriteLine($"Przykro mi, ale już istnieje taki klucz ('{key}')! :(");
            }
            else 
            {
                dict.Add(key, value);
                //ewentualnie
                //dict[key] = value;
                Console.WriteLine($"Pomyślnie dodano: {key} - {value} do słownika.");
            }
        }

        public static void SprawdzIUsun(Dictionary<string, string> dict, string key) 
        {
            if (dict.ContainsKey(key))
            {
                dict.Remove(key);
                Console.WriteLine($"Pomyślnie usunięto: {key} ze słownika.");
            }
            else 
            {
                Console.WriteLine($"Przykro mi, ale nie istnieje taki klucz ('{key}')! :(");    
            }
        }


    }
}