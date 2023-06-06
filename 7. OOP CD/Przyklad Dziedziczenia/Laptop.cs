using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyklad_Dziedziczenia
{
    internal class Laptop : ElektryczneUrzadzenie
    {

        public Laptop() 
        {
        }
        
        public Laptop(string Marka) 
        {
            this.Marka = Marka;
        }
        public string SprawdzStan()
        {
            if (!JestWlaczone)
            {
                return $"Laptop {Marka} jest wyłączony!";
            }
            return $"Laptop {Marka} jest włączony!";
        }


    }
}
