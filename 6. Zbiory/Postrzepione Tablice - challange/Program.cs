namespace Postrzepione_Tablice___challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rodzinaMarcela = new string[] { "Magda", "Mietek"};

            string[][] kumpleIRodzinyy = new string[][] 
            {
                new string[] {"Zbigniew", "Klaudia"},
                new string[] {"Julia", "Dorota"},
                new string[] {"Kamila", "Filip"},
                rodzinaMarcela
            };

            foreach (string[] kumpel in kumpleIRodzinyy) 
            {
                Console.WriteLine($"Cześć {kumpel[0]}, poznaj {kumpel[1]}!");
            }
            Console.Read();
        }
    }
}