namespace Przyklad_Dziedziczenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop l1 = new Laptop("Dell");
            Laptop l2 = new Laptop();

            l1.JestWlaczone = true;

            l2.Marka = "MSI";
            l2.JestWlaczone = false;

            Console.WriteLine(l1.SprawdzStan());
            Console.WriteLine(l2.SprawdzStan());
            Console.ReadLine();
        }
    }
}