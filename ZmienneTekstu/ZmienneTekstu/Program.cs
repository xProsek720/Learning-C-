using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace ZmienneTekstu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            string nazwisko;
            string tekst;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;


            imie = "Filip";
            nazwisko = "Wałęga";

            tekst = string.Format("Hello {0} {1}!", imie, nazwisko);

            Console.WriteLine(tekst);
            Console.WriteLine(tekst.ToLower());

            foreach (string arg in args) { Console.WriteLine(arg); }

            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
