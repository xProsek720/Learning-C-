namespace Obsluga_Bledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pobranaLiczba = podajLiczbe();
            wyswietlLiczbe(pobranaLiczba);
        }
        public static int podajLiczbe() 
        {
            int parsed = new int();
            Console.Write("Podaj liczbę: ");
            string toParse = Console.ReadLine();

            try
            {
                parsed = int.Parse(toParse);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Coś jest nie tak z twoim numerem! (Prawdopodobnie to litera)\nErr: {e.Message}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Liczba jest zbyt duża lub zbyt mała!\nErr: {e.Message}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Podałeś pustą wartość!\nErr: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ogólny wyjątek!\nZgłoś adminowi!\nErr: {e.Message}");
            }
            finally 
            {
                Console.WriteLine("Koniec Funckcji podajLiczbe()");
            }
            return parsed;
        }

        public static void wyswietlLiczbe(int liczba) 
        {
            Console.WriteLine($"Podana liczba to: {liczba}");
        }
    }
}