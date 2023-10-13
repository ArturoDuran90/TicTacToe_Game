namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];

            string[] playerNames = { "Player 1", "Player 2" };

            char[] playerSymbols = { 'X', 'O' }; //Letter O

            bool bDone = false;//done with game flag

            int turn = 0;//whose turn it is
            int totalTurns = 0; //total turns which have happened
            bool wasATie = false;

            //do loop to keep game going...
            do
            {
                Console.WriteLine();
                for(int row = 0; row < board.GetLength(0); row++)
                {
                    //Console.WriteLine("-----------");
                    for (int col = 2; col < board.GetLength(1); col++)
                    {
                        Console.Write(" {0} | {1} | {2}", board[row, col], board[row, col], board[row, col]);
                        

                    }
                    Console.WriteLine();
                    Console.WriteLine("--------");
                    //finsish Console.WriteLine stuff here...
                    //dasher like this -----

                }

                int chosenRow, chosenCol;
                bool validInput = false;
                do
                {
                    //get position from keyboard
                    Console.WriteLine("{0} enter row (1-3):", playerNames[turn]);
                    bool validRow = int.TryParse(Console.ReadLine(), out chosenRow);

                    //get column
                    //you do this...
                    Console.WriteLine("{0} enter column (1-3)", playerNames[turn]);
                    bool validCol = int.TryParse(Console.ReadLine(), out chosenCol);

                    //if not validInput tell the user there is a problem
                    if()
                    {
                        Console.WriteLine("There was a problem.");
                    }


                } while (!validInput);

                //set board spot as owned by player

                //if CheckForWinner then break; //break = jump out of loop

            } while (!bDone);

            //if was a tie, tell them
            //else tell them who the winner is...


        }

        static bool CheckForWinner(char[,] board, char playerSymbol)
        {
            if (board[0,1] == 'X')
            {

            }

            //check vertical
            //check horizontal
            //check diagonal, top-left to bottom-right
            //check diagonal, top-right to bottom-left

            return false;
        }
    }
}
