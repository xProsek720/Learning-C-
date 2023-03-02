namespace Zagniezdzone_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jestAdminem = false;
            bool jestZarejestrowany = false;
            bool jestZalogowany = false;

            string[] admini = { "xProsek720", "m0rph3u5" };
            string[] zarejestrowani = { "xProsek720", "m0rph3u5", "test", "gosiak2", "kontempner" };
            string[] haslaPlainTextSadFade = { "1111", "2222", "test", "3333", "4444" };

            Console.Write("Podaj nazwe użytkownika: ");
            string nazwaUzytkownika = Console.ReadLine();
            Console.Write("Podaj hasło: ");
            string haslo = Console.ReadLine();
            Console.Clear();

            foreach (string s in zarejestrowani) 
            {
                if (s.Equals(nazwaUzytkownika)) 
                {
                    jestZarejestrowany = true;
                    if (haslo.Equals(haslaPlainTextSadFade[Array.IndexOf(zarejestrowani, s)]))
                    {
                        jestZalogowany|= true;
                    }
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

            if (jestZarejestrowany && jestZalogowany)
            {
                Console.WriteLine($"Witaj {nazwaUzytkownika}!");
                if (jestAdminem)
                {
                    Console.WriteLine($"Jesteś Administratorem tego CLI!");
                }
            }
            else if (jestZarejestrowany)
            {
                Console.WriteLine("Przykro mi, ale nie udało się zalogować!");
            }
            else
            {
                Console.WriteLine("Przykro mi, ale nie jesteś zarejestrowanym użytkownikiem!");
            }
            Console.Read();
        }
    }
}