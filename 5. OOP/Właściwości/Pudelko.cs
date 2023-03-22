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
        //private int szerokosc;
        private int wysokosc;
        private int objetosc;

        //skrocona własciwość
        public int Szerokosc{ get; set; }

        //właściwość
        public int Wysokosc 
        {
            get 
            {
                return wysokosc;
            }
            set
            {
                if (value < 0)
                {
                    wysokosc = -value;
                }
                else 
                {
                    wysokosc = value;
                }
            }
        }

        public int Objetosc 
        {
            get
            {
                if (dlugosc > 0 && Wysokosc > 0 && Szerokosc > 0)
                {
                    return this.dlugosc * this.Szerokosc * this.Wysokosc;
                }
                else 
                {
                    return 0;
                }
            }
        }
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
            this.Szerokosc = szerokosc;
        }
        public Pudelko(int dlugosc, int szerokosc, int wysokosc)
        {
            this.dlugosc = dlugosc;
            this.Szerokosc = szerokosc;
            this.wysokosc = wysokosc;
        }
        public void UstawDlugosc(int dlugosc) 
        {
            if (dlugosc < 0) 
            {
                throw new Exception("int dlugosc should be greater than 0!");
            }
            this.dlugosc = dlugosc;
        }
        public int ZwrocDlugosc()
        {
            return this.dlugosc;
        }
    }
}
