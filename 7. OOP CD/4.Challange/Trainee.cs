using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Challange
{
    internal class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set;}

        public Trainee(string Name, string FirstName, int Salary, int WorkingHours, int SchoolHours) : base(Name, FirstName, Salary)
        {
            this.WorkingHours = WorkingHours;
            this.SchoolHours = SchoolHours;
        }
        public Trainee(string Name, string FirstName, int Salary) : base(Name, FirstName, Salary)
        {
            this.WorkingHours = 0;
            this.SchoolHours = 0;
        }

        public void Learn() 
        {
            Console.WriteLine($"{FirstName} is learning... \nLearning Time: {this.SchoolHours}");
            this.SchoolHours++;
        }

        public override void Work()
        {
            base.Work();
            Console.WriteLine($"Working Time: {this.WorkingHours}");
            this.WorkingHours++;
        }
    }
}
