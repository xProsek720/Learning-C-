namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool loggedIn = false;
            bool canTryLuck = false;


            Console.Write("Podaj login: ");
            string login = Console.ReadLine();
            switch (login) 
            {
                case "xProsek720":
                    {
                        Console.WriteLine("Czeka na ciebie losowanie!");
                        loggedIn = true;
                        canTryLuck = true;  
                        break;
                    }
                case "root": 
                    {
                        Console.WriteLine("Nie możesz brać udziału w losowaniu!");
                        loggedIn = true;    
                        break;
                    }
                case "zTosieq": 
                    {   
                        Console.WriteLine("Czeka na ciebie losowanie!");
                        loggedIn = true;    
                        canTryLuck= true;
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Nie rozpoznano użytkownika!");
                        break;
                    }
            }


            int nrOpcji;
            string txtOpcja = "0";
            if (loggedIn && canTryLuck) 
            { 
                Console.Write("Podaj opcje(1-4): ");
                txtOpcja = Console.ReadLine();
            }


            if (!int.TryParse(txtOpcja, out nrOpcji)) 
            {
                Console.WriteLine("Nie udało się skonwertować opcji na numer! :(");
            }


            //Oczywiście można użyć też stringa, ale chciałem użyć TryParse.
            if (canTryLuck) 
            { 
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
            }


            Console.Read();


        }
    }
}