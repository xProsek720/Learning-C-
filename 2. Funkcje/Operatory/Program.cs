namespace Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numer1 = 3;
            int numer2 = 2;
            int numer3;
        
            //jednoargumentowe operator
            numer3 = -numer1;
            Console.WriteLine($"Zmienna numer3 wynosi: {numer3}");
            
            bool jestPochmurnie = !(true);
            Console.WriteLine($"Zmienna jestPochmirnie wynosi: {jestPochmurnie}");
            
            numer3++;
            Console.WriteLine($"Zmienna numer3 wynosi: {numer3}");
            
            numer3--;
            Console.WriteLine($"Zmienna numer3 wynosi: {numer3}");


            //dwuargumentowe operatory
            int wynik;

            wynik = numer1 + -numer2;
            Console.WriteLine($"Wynik z dodawania numer1 + -numer2 wynosi: {wynik}");
            
            wynik = numer1 - numer2;
            Console.WriteLine($"Wynik z dodawania numer1 -  numer2 wynosi: {wynik}");
             
            wynik = numer1 * numer2;
            Console.WriteLine($"Wynik z dodawania numer1 *  numer2 wynosi: {wynik}");
              
            wynik = numer1 / numer2;
            Console.WriteLine($"Wynik z dodawania numer1 /  numer2 wynosi: {wynik}");
                
            wynik = numer1 % numer2;
            Console.WriteLine($"Wynik z dodawania numer1 %  numer2 wynosi: {wynik}");


            //relacyjne i operatory typu
            bool jestMniejsze;
            jestMniejsze = numer1 < numer2;
            Console.WriteLine($"numer1 jest mniejszy od numer2 (<): {jestMniejsze}");

            bool jestRowne;
            jestRowne = numer1 == numer2;
            Console.WriteLine($"numer1 jest równy numer2 (==): {jestRowne}");

            bool nieJestRowne;
            nieJestRowne = numer1 != numer2;
            Console.WriteLine($"numer1 nie jest równy numer2 (!=): {nieJestRowne}");


            //warunkowe operatory
            bool jestMniejszeIPochmurno;
            jestMniejszeIPochmurno = jestMniejsze && jestPochmurnie;
            Console.WriteLine($"Jest mniejsze niż i pochmurno (&&): {jestMniejszeIPochmurno}");


            bool nieJestRowneLubPochmurno;
            nieJestRowneLubPochmurno = nieJestRowne || jestPochmurnie;
            Console.WriteLine($"Nie jest Rowne lub pochmurno (||): {nieJestRowneLubPochmurno}");

            Console.ReadKey();


        }
    }
}