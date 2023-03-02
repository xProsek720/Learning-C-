namespace Zagniezdzone_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jestAdminem = false;
            bool jestZarejestrowany = false;

            string[] admini = { "xProsek720", "m0rph3u5" };
            string[] zarejestrowani = { "xProsek720", "m0rph3u5", "test", "gosiak2", "kontempner" };

            Console.Write("Podaj nazwe użytkownika: ");
            string nazwaUzytkownika = Console.ReadLine();
            Console.Clear();

            foreach (string s in zarejestrowani) 
            {
                if (s.Equals(nazwaUzytkownika)) 
                {
                    jestZarejestrowany = true;
                    break;
                }
            }

            foreach (string s in admini) 
            {
                if (s.Equals(nazwaUzytkownika)) 
                {
                    jestAdminem = true;
                    break;
                }
            }

            if (jestZarejestrowany)
            {
                Console.WriteLine($"Witaj {nazwaUzytkownika}!");
                if (jestAdminem)
                {
                    Console.WriteLine($"Jesteś Administratorem tego CLI!");
                }
            }
            else 
            {
                Console.WriteLine("Przykro mi, ale nie jesteś zarejestrowanym użytkownikiem!");
            }
            Console.Read();
        }
    }
}