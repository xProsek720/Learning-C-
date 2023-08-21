using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._IEnumerable___wstep
{
    internal class CatShelter : IEnumerable<Cat>
    {
        public List<Cat> Cats= new List<Cat>();

        public CatShelter()
        {
            Cat cat1 = new Cat("Lusia", false);
            Cat cat2 = new Cat("Lolek", true);
            Cat cat3 = new Cat("Tera", true);
            Cat cat4 = new Cat("Koka", false);
            Cat cat5 = new Cat("Pente", false);

            Cats.Add(cat1);
            Cats.Add(cat2);
            Cats.Add(cat3);
            Cats.Add(cat4);
            Cats.Add(cat5);
        }

        IEnumerator<Cat> IEnumerable<Cat>.GetEnumerator()
        {
            return Cats.GetEnumerator();
        }

        //Non generic type - maybe later
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
