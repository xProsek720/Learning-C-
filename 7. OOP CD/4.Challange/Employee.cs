using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Challange
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string Name, string FirstName, int Salary) 
        {
            this.Name = Name;
            this.FirstName = FirstName;
            this.Salary = Salary;
        }

        virtual public void Work() 
        {
            Console.WriteLine($"{FirstName} is working...");
        }

        public void Pause() 
        {
            Console.WriteLine($"{FirstName} is taking a break...");
        }
    }
}
