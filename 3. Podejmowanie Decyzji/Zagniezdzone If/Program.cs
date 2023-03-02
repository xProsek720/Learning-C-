namespace Zagniezdzone_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jestAdminem = true;
            bool jestZarejestrowany = true;

            string nazwaUzytkownika = "xProsek";

            if (jestZarejestrowany) 
            {
                Console.WriteLine($"Witaj {nazwaUzytkownika}!");
                if (jestAdminem) 
                {
                    Console.WriteLine($"Jesteś Administratorem tego CLI!");
                }
            }
            Console.Read();
        }
    }
}