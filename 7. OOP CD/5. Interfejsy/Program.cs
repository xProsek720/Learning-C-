namespace _5._Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(14);
            Ticket t2 = new Ticket(14);

            Console.WriteLine(t2.Equals(t1));

            t1.DurationInHours = 15;
            Console.WriteLine(t1.Equals(t2));
        }
    }
}