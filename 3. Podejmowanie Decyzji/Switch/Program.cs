namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nrOpcji;
            Console.Write("Podaj opcje(1-4): ");
            string txtOpcja = Console.ReadLine();
            if (!int.TryParse(txtOpcja, out nrOpcji)) 
            {
                Console.WriteLine("Nie udało się skonwertować opcji na numer! :(");
            }

            switch (nrOpcji) 
            {
                case 1: 
                    {
                        Console.WriteLine("Wygrałeś piwo!");
                        break;
                    }
                case 2: 
                    {
                        Console.WriteLine("Wygrałeś nissana!");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Stawiasz piwo! ;)");   
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Stawiasz nissana! ;)");
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Wybrałeś błędną opcję!");
                        break;
                    }
            }
            Console.Read();
        }
    }
}