namespace _4.Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Senior Dev.", "Kamil", 4200);
            Boss b1 = new Boss("CEO", "Filip", 10000, "Ferrari");
            Trainee t1 = new Trainee("Front-end", "Maciek", 2100, 15, 14);



            b1.Lead();
            e1.Work();
            t1.Learn();
            t1.Pause();
            t1.Work();
            e1.Pause();
            t1.Pause();
            t1.Work();
            e1.Work();
            e1.Pause();
            t1.Pause();
        }
    }
}