using System;

namespace Lab15
{
    class Program
    {
        class Board
        {
            readonly int N = 5;
            void printSolution(int[,] board)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        Console.Write(" " + board[i, j]
                                          + " ");
                    Console.WriteLine();
                }
            }

            bool CheckOnSave(int[,] board, int row, int col)
            {
                int i, j;

                for (i = 0; i < col; i++)
                    if (board[row, i] == 1)
                        return false;

                for (i = row, j = col; i >= 0 &&
                     j >= 0; i--, j--)
                    if (board[i, j] == 1)
                        return false;

                for (i = row, j = col; j >= 0 &&
                              i < N; i++, j--)
                    if (board[i, j] == 1)
                        return false;
                return true;
            }

            bool execute(int[,] board, int col)
            {
                if (col >= N)
                    return true;

                for (int i = 0; i < N; i++)
                {
                    if (CheckOnSave(board, i, col))
                    {
                        board[i, col] = 1;

                        if (execute(board, col + 1) == true)
                            return true;

                        board[i, col] = 0;
                    }
                }
                return false;
            }


            bool solveNQ()
            {
                int[,] board = {{ 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0 },
                                { 0, 0, 0, 0, 0 }};

                if (execute(board, 0) == false)
                {
                    Console.Write("Solution is not exist");
                    return false;
                }
                printSolution(board);
                return true;
            }
            public static void Main(String[] args)
            {
                Board Queen = new Board();
                Queen.solveNQ();
            }
        }
    }
}
