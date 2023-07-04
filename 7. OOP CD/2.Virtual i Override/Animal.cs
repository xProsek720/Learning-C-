using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Virtual_i_Override
{
    public class Animal
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public bool JestGlodny { get; set; }

        public Animal(int id, string imie, int wiek) 
        {
            this.Id = id;
            this.Imie = imie;
            this.Wiek = wiek;
            this.JestGlodny = true;
        }

        //Jeśli dajemy virtual to można przy dziedziczeniu nadpisać funkcjonalność
        //  metody

        public virtual void MakeSound() 
        {
        
        }
        public virtual void Eat() 
        {
            if (JestGlodny) 
            {
                Console.WriteLine($"{this.Imie} powinien zostać nakarmiony/na!");
                this.JestGlodny = false;
            }
            else 
            {
                Console.WriteLine($"{this.Imie} jest nakarmiony/na!");
            }
        }

    }
}
