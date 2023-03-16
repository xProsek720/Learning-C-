namespace Challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inputuje = true;
            double suma = 0;
            int ilosc = 0;
            while (inputuje)
            {
                Console.Write("Podaj ocene (0-20): ");
                string userInput = Console.ReadLine();
                int parsedInt;
                if (int.TryParse(userInput, out parsedInt))
                {
                    if (parsedInt == -1) 
                    {
                        break;
                    }
                    if (!(parsedInt >= 0 && parsedInt <= 20))
                    {
                        Console.WriteLine($"INPUT ERR!: {parsedInt} nie należy do przedziału 0-20");
                        continue;
                    }
                }
                else 
                {
                    Console.WriteLine($"CONVERTION ERR!: {userInput} nie da się przekonwertować na liczbę całkowitą.");
                    continue;
                }
                suma += parsedInt;
                ilosc++;
            }
            Console.WriteLine($"Średnia tej osoby wynosi: {suma / ilosc}");
            Console.ReadKey();
        }
    }
}


/*Imagine you are a developer and get a job in which you need to create a program for a teacher. 
 * He needs a program written in c# that calculates the average score of his students. 
 * So he wants to be able to enter each score individually and then get the final average score once he enters -1.
So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores, 
the program should write onto the console what the average score is.
The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
Test your program thoroughly.
 */