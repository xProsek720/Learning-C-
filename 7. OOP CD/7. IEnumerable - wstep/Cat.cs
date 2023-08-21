using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._IEnumerable___wstep
{
    public class Cat
    {
        public string Name { get; set; }
        public bool IsABadCat {get; set; }

        public Cat() 
        {
            this.Name = "Uknown";
            this.IsABadCat = false;
        }
        public Cat(string name, bool isABadCat)
        {
            Name = name;
            IsABadCat = isABadCat;
        }

        public void FeedTheCat(int portions) 
        {
            Console.WriteLine($"{this.Name} the Cat has been fed {portions} times.");
        }

        public override string ToString() 
        {
            return $"Cat Name: {this.Name}\tIs a bad cat: {this.IsABadCat}";
        }

    }
}
