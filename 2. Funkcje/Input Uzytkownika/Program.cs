namespace Input_Uzytkownika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LadneDodawanie();
            Console.Read();
        }

        public static void LadneDodawanie() 
        {
            int a, b;
            Console.WriteLine("Podasz dwie liczby które zostaną dodane do siebie!");
            Console.Write("");
            a = int.Parse(Console.ReadLine());

            //To wygląda pięknie
            Console.CursorTop--;
            Console.CursorLeft = a.ToString().Length;

            Console.Write(" + ");
            b = int.Parse(Console.ReadLine());

            //Oj taaak byczqu <3
            Console.CursorTop--;
            Console.CursorLeft = a.ToString().Length + 3 + b.ToString().Length;

            Console.WriteLine($" = {a + b}");
        }
    }
}