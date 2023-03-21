using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Właściwości
{
    internal class Pudelko
    {
        //member variable
        //to akurat po angielsku
        private int dlugosc;
        private int szerokosc;
        private int wysokosc;
        private int objetosc;

        public Pudelko()
        { 
        }
        public Pudelko(int dlugosc) 
        {
            this.dlugosc = dlugosc;
        }
        public Pudelko(int dlugosc, int szerokosc) 
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
        }
        public Pudelko(int dlugosc, int szerokosc, int wysokosc)
        {
            this.dlugosc = dlugosc;
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            PoliczObjetosc();
        }

        public void UstawDlugosc(int dlugosc) 
        {
            if (dlugosc < 0) 
            {
                throw new Exception("int dlugosc should be greater than 0!");
            }
            this.dlugosc = dlugosc;
        }
        public void UstawSzerokosc(int szerokosc)
        {
            if (szerokosc < 0)
            {
                throw new Exception("int szerokosc should be greater than 0!");
            }
            this.szerokosc = szerokosc;
        }
        public void UstawWysokosc(int wysokosc)
        {
            if (wysokosc < 0)
            {
                throw new Exception("int wysokosc should be greater than 0!");
            }
            this.wysokosc = wysokosc;
        }
        public int ZwrocDlugosc() 
        {
            return this.dlugosc;
        }
        public int ZwrocSzerokosc() 
        {
            return (this.szerokosc);
        }
        public int ZwrocWysokosc() 
        {
            return (this.wysokosc);
        }
        public int ZwrocObjetosc() 
        {
            PoliczObjetosc();
            if (objetosc > 0)
            {
                return (this.objetosc);
            }
            else { return 0; }
        }
        protected void PoliczObjetosc() 
        {
            if (wysokosc > 0 && szerokosc > 0 && dlugosc > 0) 
            {
                this.objetosc = wysokosc * szerokosc * dlugosc;
            }
        }

    }
}
