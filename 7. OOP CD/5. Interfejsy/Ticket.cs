using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Interfejsy
{
    internal class Ticket : IEquatable<Ticket>
    {

        public int DurationInHours { get; set; }

        public Ticket(int DurationInHours) 
        {
            this.DurationInHours = DurationInHours;
        }


        //Pozwala nam porównywać dwa obiekty typu Ticket, czy sa rowne
        // porównuje je ze względu na zmienną "DurationInHours".
        public bool Equals(Ticket other) 
        {
            return this.DurationInHours == other.DurationInHours;
        }

    }
}
