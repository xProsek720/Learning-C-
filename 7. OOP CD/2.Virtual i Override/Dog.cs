using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Virtual_i_Override
{
    internal class Dog : Animal
    {
        public bool JestHapi { get; set; }
        public Dog (int id, string imie, int wiek) : base (id, imie, wiek) 
        {
            this.JestHapi = true;
        }

        public override void MakeSound()
        {
            if (this.JestHapi) 
            {
                Console.WriteLine($"{this.Imie}: Woof!");
            }
            else 
            {
                Console.WriteLine($"{this.Imie}: Wrau!");
            }
        }
        public override void Eat()
        {
            base.Eat();
            if (!this.JestGlodny) 
            {
                this.JestHapi = true;
            }
        }
        public string ToString() 
        {
            return $"{this.Id}. {this.Imie}: {this.Wiek} - Głodny: {this.JestGlodny} - Hapi: {this.JestHapi}";
        }
    }
}
