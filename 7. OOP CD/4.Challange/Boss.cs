using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Challange
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; set; }
        public Boss(string Name, string FirstName, int Salary, string CompanyCar) : base(Name, FirstName, Salary)
        {
            this.CompanyCar = CompanyCar;
        }

        public void Lead() 
        {
            Console.WriteLine("Boss is leading...");
        }
    }
}
