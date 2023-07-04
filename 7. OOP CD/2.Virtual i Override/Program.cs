namespace _2.Virtual_i_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(0, "Szarik", 14);
            Dog dog2 = new Dog(1, "Łajka", 6);

            Console.WriteLine(dog1.ToString());
            Console.WriteLine(dog2.ToString());

            dog1.Eat();
            dog2.Eat();

            dog2.Eat();

            dog1.MakeSound();
            dog2.MakeSound();
        }
    }
}