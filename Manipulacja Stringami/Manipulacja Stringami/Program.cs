using System;
using System.Threading;

namespace Manipulacja_Stringami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int printCounter = 1;                
            int wiek = 22;
            string imie = "Filip";

            Console.WriteLine("{0}.Konkatynacja Stringów: ", printCounter++);
            Console.WriteLine("Witaj jestem " + imie + " i mam " + wiek + "lata.\n");
            Console.ReadKey();

            Console.WriteLine("{0}.Formatowanie Stringów: ", printCounter++);
            Console.WriteLine("Witaj jestem {0} i mam {1}lata.\n", imie, wiek);
            Console.ReadKey();
            
            //Chyba najlepsze wg mnie
            Console.WriteLine("{0}.Interpolacja Stringów: ", printCounter++);
            Console.WriteLine($"Witaj jestem {imie} i mam {wiek}lata.\n");
            Console.ReadKey();

            //Łatwo opisać jednym przymiotnikiem i jednym rzeczownikiem RAW STRING
            Console.WriteLine("{0}.Dosłowna interpretacja Stringów: ", printCounter++);
            Console.WriteLine(@"C:\Windows\System32> rm -r -fo .");             //Taaa WRAJTLAJNEM System32 będę usuwał XD
            Thread.Sleep(42); Console.Write("\nDELETING ALL FOLDER AND FILES"); Thread.Sleep(42); Console.Write("."); Thread.Sleep(42); Console.Write("."); Thread.Sleep(42); Console.WriteLine("."); Thread.Sleep(500); Console.WriteLine("DONE!"); Console.Write(@"C:\Windows> "); Console.ReadLine();
            Console.ReadKey();                                                  //To jest learning, a nie produkcja!
                                                                                //
        }
    }
}
