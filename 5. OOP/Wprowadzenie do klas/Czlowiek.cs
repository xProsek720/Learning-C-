using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprowadzenie_do_klas
{
    internal class Czlowiek
    {
        public string imie = "ERR:nieUstawiono";
        private string nazwisko = "ERR:nieUstawiono";

        public Czlowiek() 
        {
        
        }
        public Czlowiek(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }


        public Czlowiek(string imie, string nazwisko) 
        {
            this.imie = imie;
            this.nazwisko= nazwisko;
        }

        public void PrzedstawSie() 
        {
            Console.WriteLine($"Cześć, nazywam sie {imie} {nazwisko}.");
        }
        public void UstawNazwisko(string nazwisko) 
        {
            this.nazwisko = nazwisko; 
        }


    }
}
