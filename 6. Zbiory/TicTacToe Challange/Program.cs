namespace TicTacToe_Challange
{
    internal class Program
    {

        //Udemy CHALLANGE
        public static void Main() 
        {
            Game();
        }

        public static void Game() 
        {
            bool gameRunning = true;
            int gameStatus = 0;
            int selRow, selCol;
            string[,] board = new string[3,3];
            Console.WriteLine("You are X!");
            while (gameRunning)
            {
                Console.WriteLine("Here is board:");
                PrintBoard(board);
                selRow = ChooseRow();
                selCol = ChooseColumn();
                if (CheckPlace(board, selRow, selCol))
                {
                    board[selRow, selCol] = "X";
                }
                else
                {
                    Console.WriteLine("Occupied!");
                    PrintBoard(board);
                    selRow = ChooseRow();
                    selCol = ChooseColumn();
                    if (CheckPlace(board, selRow, selCol))
                    {
                        board[selRow, selCol] = "X";
                    }
                }
                gameStatus = Checker(board);
                if (gameStatus == 1 || gameStatus == 2 || gameStatus == 3)
                {
                    Console.WriteLine("GAME HAS ENDED!");
                    PrintBoard(board);
                    gameRunning = false;
                    break;
                }
                board = BotMove(board);
                PrintBoard(board);
                gameStatus = Checker(board);
                if (gameStatus == 1 || gameStatus == 2 || gameStatus == 3) 
                {
                    Console.WriteLine("GAME HAS ENDED!");
                    PrintBoard(board);
                    gameRunning= false;
                    break;
                }
            }
            if (gameStatus == 1)
            { Console.WriteLine("YOU WON!"); }
            else if (gameStatus == 3) 
            { Console.WriteLine("DRAW!"); }
            else
            { Console.WriteLine("YOU LOST!"); }
            Console.ReadLine();   
        }
        
        public static string[,] BotMove(string[,] board) 
        {
            Random rnd = new Random();
            bool occupied = true;
            int row = -1, col = -1;
            while (occupied) 
            {
                row = rnd.Next(board.GetLength(0));
                col = rnd.Next(board.GetLength(1));
                if (CheckPlace(board, row, col)) 
                {
                    occupied= false;
                }
            }
            board[row, col] = "O";
            return board;
        }
        public static bool CheckDraw(string[,] board) 
        {
            foreach (var item in board) 
            {
                if (item == null) { return false; }
            }
            return true;
        }
        public static bool CheckPlace(string[,] board, int row, int col) 
        {
            if (row>=0 && col>=0 && row <=2 && col <= 2) 
            {
                if (board[row, col] == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
           
        }
        public static int ChooseRow()
        {
            Console.Write("Row(0-2): ");
            char input = Console.ReadKey().KeyChar;

            int row = int.Parse(input.ToString());
            if (row >= 0 && row <= 2)
            {
                return row;
            }
            else
            {
                return -1;
            }
        }
        public static int ChooseColumn()
        {
            Console.Write(" Column(0-2): ");
            char input = Console.ReadKey().KeyChar;
            Console.Write('\n');
            int col = int.Parse(input.ToString());
            if (col >= 0 && col <= 2)
            {
                return col;
            }
            else
            {
                return -1;
            }
        }

        public static void PrintBoard(string[,]board) 
        {
            int counterX = 0;
            int counterY = 0;
            foreach (var item in board)
            {
                counterX++;
                
                if (item == null)
                {
                    Console.Write($"- ");
                }
                else
                { 
                    Console.Write($"{item} ");
                }
                if (counterX == 3)
                {
                    Console.Write("\n");
                    counterY++;
                    counterX = 0;
                }
            }
        }


        public static int GetCharQuantity(string[] text, string letter)
        {
            int counter = 0;
            foreach (var c in text)
            {
                if (c == letter)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int Checker(string[,] board)
        {
            string[] rDiag = new string[3];
            string[] lDiag = new string[3];
            string[] fV = new string[3];
            string[] sV = new string[3];
            string[] tV = new string[3];
            string[] fC = new string[3];
            string[] sC = new string[3];
            string[] tC = new string[3];
            for (int i = 0; i <= board.GetLength(0) - 1; i++)
            {
                rDiag[i] = board[i, i];
                lDiag[i] = board[i, (board.GetLength(0) - 1 - i)];
                fV[i] = board[0, i];
                sV[i] = board[1, i];
                tV[i] = board[2, i];
                fC[i] = board[i, 0];
                sC[i] = board[i, 1];
                tC[i] = board[i, 2];
            }
            string[] chars = { "X", "O" };
            foreach (string c in chars)
            {
                bool end = false;
                bool X = false;
                if (GetCharQuantity(rDiag, c) == 3) end = true;
                if (GetCharQuantity(lDiag, c) == 3) end = true;
                if (GetCharQuantity(fV, c) == 3) end = true;
                if (GetCharQuantity(sV, c) == 3) end = true;
                if (GetCharQuantity(tV, c) == 3) end = true;
                if (GetCharQuantity(fC, c) == 3) end = true;
                if (GetCharQuantity(sC, c) == 3) end = true;
                if (GetCharQuantity(tC, c) == 3) end = true;
                if (c == "X" && end == true) 
                {
                    return 1;
                }
                if (c == "O" && end == true) 
                {
                    return 2; 
                }
            }
            if (CheckDraw(board)) 
            {
                return 3;
            }
            return 0;
        }
    }
}