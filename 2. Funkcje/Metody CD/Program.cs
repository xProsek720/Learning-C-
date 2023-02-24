namespace Metody_CD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("16 - 2 = ");
            Console.WriteLine(OdejmowanieInt(16,2));
            //Da się jak widać wywołać metode jako argument metody
            Console.Write("18-2-2 = ");
            Console.WriteLine(OdejmowanieInt(OdejmowanieInt(18,2),2));
            Console.WriteLine("DzielenieDouble:Musze zacząć używać rozwiązania w jednym folderze. Jest to lepsze rozwiązanie na GitHub'a. Dodatkowo przeszedłem na .Net 7.0 po pytaniu instruktora czy można z .Net 5.0");
            Console.Write("10 / 3 = ");
            Console.WriteLine(DzielenieDouble(10, 3));
            Console.WriteLine("DzielenieInt:");
            Console.Write("10 / 3 = ");
            Console.WriteLine(DzielenieInt(10, 3));
            Console.ReadKey();
        }

        public static int OdejmowanieInt(int a, int b) 
        {
            return a - b;
        }
             //static zeby nie trzeba było inicjować klasy Program 
        public static double DzielenieDouble(double a, double b) 
        {
            return a/b;
        }
        public static double DzielenieInt(int a, int b) 
        {
            return a/b;
        }
    }
}