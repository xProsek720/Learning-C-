using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprowadzenie_do_klas
{
    internal class Czlowiek
    {
        private string imie = "ERR:nieUstawiono";
        private string nazwisko = "ERR:nieUstawiono";
        private int rokUrodzenia = -1;
        private string kolorOczu = "ERR:nieUstawiono";


        public Czlowiek() 
        {
        
        }

        public Czlowiek(string imie, string nazwisko) 
        {
            this.imie = imie;
            this.nazwisko= nazwisko;
        }
        public Czlowiek(string imie, string nazwisko, int rokUrodzenia, string kolorOczu) 
        {
            this.imie = imie;
            this.nazwisko= nazwisko;
            this.rokUrodzenia= rokUrodzenia;
            this.kolorOczu= kolorOczu;
        }

        public void PrzedstawSie() 
        {
            Console.WriteLine($"Cześć, nazywam sie {imie} {nazwisko}.");
        }
        public void UstawImie(string imie) 
        {
            this.imie = imie;
        }
        public void UstawNazwisko(string nazwisko) 
        {
            this.nazwisko = nazwisko; 
        }
        public int DajRokUrodzenia() 
        {
            return rokUrodzenia;
        }
        public string DajKolorOczu() 
        {
            return kolorOczu;
        }


    }
}
