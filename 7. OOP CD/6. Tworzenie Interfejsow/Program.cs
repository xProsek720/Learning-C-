namespace _6._Tworzenie_Interfejsow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car pojazd1 = new Car("Audi", 420f);
            Car pojazd2 = new Car("BWM", 124f, "M3", "Sport", "BOOM.mp3");
            Console.WriteLine($"{pojazd1} \n{pojazd2}");
            pojazd1.DestroySound = "BOOOM.mp3";
            pojazd1.Destroyables.Add(pojazd2);
            pojazd1.Destroy();
        }
    }
}