namespace ForEach_Switch_Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz coś: ");
            string input = Console.ReadLine();

            Console.WriteLine("Co to jest za typ danych?");
            Console.WriteLine("1. String");
            Console.WriteLine("2. Integer");
            Console.WriteLine("3. Double");
            Console.WriteLine("4. Boolean");

            Console.Write(": ");
            string input2 = Console.ReadLine();

            int input2Parsed;
            if (int.TryParse(input2, out input2Parsed)) 
            {
                switch (input2Parsed) 
                {
                    case 1:
                        {
                            bool passedTest = true;
                            foreach (char litera in input) 
                            {
                                if (!char.IsLetter(litera))
                                {
                                    passedTest = false;
                                }
                                else 
                                {
                                    passedTest = true;
                                }
                            }
                            if (passedTest) 
                            {
                                Console.WriteLine($"Wpisałeś: ,,{input}\'\'.");
                            }
                            else 
                            {
                                Console.WriteLine($"Podałeś same liczby: {input}");
                            }
                            break;
                        }
                    case 2: 
                        {
                            int parsed;
                            if (int.TryParse(input, out parsed))
                            {
                                Console.WriteLine($"Wpsiałeś: {parsed}");
                            }
                            else 
                            {
                                Console.WriteLine($"Problem z konwersją do Integer.");
                            }
                            break;
                        }
                    case 3:
                        {
                            double parsed;
                            if (double.TryParse(input, out parsed))
                            {
                                Console.WriteLine($"Wpisałeś {parsed}.");
                            }
                            else 
                            {
                                Console.WriteLine("Problem z konwersją do Double.");
                            }
                            break;  
                        }
                    case 4:
                        {
                            bool parsed;
                            if (bool.TryParse(input, out parsed))
                            {
                                Console.WriteLine($"Podałeś {parsed}.");
                            }
                            else 
                            {
                                Console.WriteLine("Problem z konwersją do Boolean.");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nie wybrano żadnej z powyższych opcji.");
                            break;
                        }
                }
            }
        }
    }
}