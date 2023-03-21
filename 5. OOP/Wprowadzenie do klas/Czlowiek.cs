using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wprowadzenie_do_klas
{
    internal class Czlowiek
    {
        private string stdERR = "ERR:nieUstawiono";
        private string imie = "ERR:nieUstawiono";
        private string nazwisko = "ERR:nieUstawiono";
        private int rokUrodzenia = -1;
        private string kolorOczu = "ERR:nieUstawiono";

        public Czlowiek()
        {

        }
        public Czlowiek(string imie)
        {
            this.imie = imie;
        }

        public Czlowiek(string imie, string nazwisko) 
        {
            this.imie = imie;
            this.nazwisko= nazwisko;
        }
        public Czlowiek(string imie, string nazwisko, int rokUrodzenia) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.rokUrodzenia = rokUrodzenia;
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
            //Te warunki można by zrobić ładniej, przepraszam

            if (kolorOczu.Equals(stdERR) && rokUrodzenia == -1 && !(imie.Equals(stdERR) && nazwisko.Equals(stdERR)) && !nazwisko.Equals(stdERR))
            {
                Console.WriteLine($"Cześć, nazywam sie {imie} {nazwisko}.");
            }
            else if (kolorOczu.Equals(stdERR) && !(imie.Equals(stdERR) && nazwisko.Equals(stdERR)) && !nazwisko.Equals(stdERR))
            {
                Console.WriteLine($"Cześć, nazywam sie {imie} {nazwisko}.\nUrodziłem się w {rokUrodzenia}");
            }
            else if (nazwisko.Equals(stdERR) && !imie.Equals(stdERR)) 
            {
                Console.WriteLine($"Cześć, nazywam sie {imie}.");
            }
            else if (imie.Equals(stdERR) && nazwisko.Equals(stdERR))
            {
                Console.WriteLine($"Błąd krytyczny wczytania tego człowieka! :(");
            }
            else
            {
                Console.WriteLine($"Cześć, nazywam sie {imie} {nazwisko}.\nUrodziłem się w {rokUrodzenia}\nMam oczy koloru: {kolorOczu}");
            }
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
