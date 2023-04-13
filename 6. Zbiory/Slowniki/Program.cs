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
            Console.ReadLine();

        }
    }
}