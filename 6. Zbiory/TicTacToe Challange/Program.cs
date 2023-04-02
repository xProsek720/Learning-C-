namespace TicTacToe_Challange
{
    internal class Program
    {

        //Udemy CHALLANGE

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
        public static bool Checker(string[,] board)
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
                if (GetCharQuantity(rDiag, c) == 3) return true;
                if (GetCharQuantity(lDiag, c) == 3) return true;
                if (GetCharQuantity(fV, c) == 3) return true;
                if (GetCharQuantity(sV, c) == 3) return true;
                if (GetCharQuantity(tV, c) == 3) return true;
                if (GetCharQuantity(fC, c) == 3) return true;
                if (GetCharQuantity(sC, c) == 3) return true;
                if (GetCharQuantity(tC, c) == 3) return true;
            }
            return false;
        }
    }
}