using System;

namespace Zmienne2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte bajt = 1;              //0+255
            sbyte bajt2 = -2;           //-128+127
            int calk = -23123;          // od -2 i 9 x 0 do ok 2 i 9x0
            uint calk2 = 232323;        // 0 do 4 i 9x0
            short krotkiCalk = 2323;    // -32tys do 32tys
            short parsed;
            //itd

            string tekst = "Mój tekst :D";
            string liczba = "659";
            parsed = short.Parse(liczba);


            Console.WriteLine($"{tekst}\nliczba({liczba}) + 4 to: {parsed + 4}");
        }
    }
}
