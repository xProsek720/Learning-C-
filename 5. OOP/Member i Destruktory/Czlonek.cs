using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_i_Destruktory
{
    internal class Czlonek
    {

        private string _nazwaCzlonka;
        private string _nazwaStanowiska;
        private int _wyplata;

        public int wiek;

        public string NazwaStanowiska
        {
            get
            {
                return _nazwaStanowiska;
            }
            set
            {
                _nazwaStanowiska = value;
            }
        }
        public Czlonek() 
        {
        
        }
        public Czlonek(string _nazwaCzlonka, int wiek) 
        {
            this._nazwaCzlonka= _nazwaCzlonka;
            this.wiek = wiek;
        }
        public Czlonek(string _nazwaCzlonka, int wiek, string _nazwaStanowiska, int _wyplata) 
        {
            this._nazwaCzlonka = _nazwaCzlonka;
            this.wiek = wiek;
            this._nazwaStanowiska = _nazwaStanowiska;
            this._wyplata = _wyplata;
        }
        ~Czlonek() 
        {
            Console.WriteLine("Obiekt unicestwiony!");
        }
        public void PrzedstawSie(bool isFriend) 
        {
            if (_nazwaCzlonka != null) 
            {
                Console.WriteLine($"Nazywam się {_nazwaCzlonka}.");
            }
            if (_nazwaStanowiska != null) 
            {
                Console.WriteLine($"Pracuje jako {_nazwaStanowiska}.");
            }
            if (wiek != 0) 
            {
                Console.WriteLine($"Mam {wiek}lat.");
            }
            if (isFriend) 
            {
                PodzielSiePrywatnymiInformacjami();
            }
            Console.WriteLine();
        }
        private void PodzielSiePrywatnymiInformacjami() 
        {
            if (_wyplata > 0) 
            {
                Console.WriteLine($"Zarabiam {_wyplata}!");
            }
        }

    }
}
