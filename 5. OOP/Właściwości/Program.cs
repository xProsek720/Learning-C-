namespace Właściwości
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int counter = 1;
            Pudelko[] arr = new Pudelko[4];
            Pudelko p1 = new Pudelko();
            arr[0] = p1;
            Pudelko p2 = new Pudelko(1);
            arr[1] = p2;
            Pudelko p3 = new Pudelko(1,2);
            arr[2] = p3;
            Pudelko p4 = new Pudelko(1,2,3);
            arr[3] = p4;
            foreach( Pudelko p in arr ) 
            {
                Console.WriteLine( $"Pudełko nr {counter++}: ");
                PrintPudelko(p);
                Console.WriteLine();
            }
            
        }
        public static void PrintPudelko(Pudelko p) 
        {
            Console.WriteLine($"    Długość: {p.ZwrocDlugosc()}");
            Console.WriteLine($"    Szerokość: {p.ZwrocSzerokosc()}");
            Console.WriteLine($"    Wysokość: {p.ZwrocWysokosc()}");
            Console.WriteLine($"    Objętość: {p.ZwrocObjetosc()}");
        }
    }
}