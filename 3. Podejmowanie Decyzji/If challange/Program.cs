namespace If_challange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            int highscore = 360;

            string highscorePlayer = "xProsek720";
            string playerName;

            Console.Write("Give me your nickname: ");
            playerName = Console.ReadLine();
            Random random = new Random();
            score = random.Next(0, 420);
            if (score > highscore) 
            {
                Console.WriteLine($"You've beaten {highscorePlayer}");
                highscore = score;
                highscorePlayer = playerName;
            }
            ShowScore(score, playerName);
            ShowHighscore(highscore, highscorePlayer);

            Console.Read();
        }

        public static void ShowScore(int score, string playerName) 
        {
            Console.WriteLine($"Score of {playerName} from this roll is {score}");
        }

        public static void ShowHighscore(int highscore, string highscorePlayer) 
        {
            Console.WriteLine($"Highscore of {highscorePlayer} is {highscore}");
        }


    }
}