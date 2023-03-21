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
            Console.WriteLine("Teraz pora uzupełnić brakujace dane i ponowić pętle!");
            Console.ReadKey();
            //p1
            arr[0].UstawDlugosc(2); arr[0].UstawSzerokosc(2); arr[0].UstawWysokosc(2);
            //p2
            arr[1].UstawSzerokosc(3); arr[1].UstawWysokosc(3);
            //p3
            arr[2].UstawWysokosc(4);
            //reset countera
            counter = 1;
            //clear
            Console.Clear();

            foreach (Pudelko p in arr)
            {
                Console.WriteLine($"Pudełko nr {counter++}: ");
                PrintPudelko(p);
                Console.WriteLine();
            }
            Console.ReadKey();
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