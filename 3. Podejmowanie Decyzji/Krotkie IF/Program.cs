namespace Krotkie_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coś = warunek ? TRU : !TRU;
            //coś = warunek ? TRU : warunek2(!TRU) ? TRU2 : !TRU2;

            int temperatura = 100;
            string stanMaterii;

            stanMaterii = temperatura < 0 ? "lód" : temperatura < 100 ? "woda" : "para";

            Console.WriteLine($"Gdy H20 wynosi {temperatura}*C to jej stan materii to {stanMaterii}!");
            Console.WriteLine("[Przy zachowaniu idealnych warunków kontrolnych!]");
            Console.Read();
        }
    }
}