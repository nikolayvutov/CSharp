using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] board = new char[n][];

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }

            int maxRow = 0;
            int maxCol = 0;
            int countOfRemovedKnights = 0;
            int maxAttackedPosition = 0;

            do
            {
                if (maxAttackedPosition > 0)
                {
                    board[maxRow][maxCol] = '0';
                    maxAttackedPosition = 0;
                    countOfRemovedKnights++;
                }
                int currAttackedPositions = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (board[i][j] == 'K')
                        {
                            currAttackedPositions = CalculateAttackedPositions(i, j, board);

                            if (currAttackedPositions > maxAttackedPosition)
                            {
                                maxAttackedPosition = currAttackedPositions;
                                maxRow = i;
                                maxCol = j;
                            }
                        }
                    }
                }
            }
            while (maxAttackedPosition > 0);

            Console.WriteLine(countOfRemovedKnights);
        }

        private static int CalculateAttackedPositions(int row, int column, char[][] board)
        {
            var currentAttackPositions = 0;
            if (IsPositionAttacked(row - 2, column - 1, board)) currentAttackPositions++;
            if (IsPositionAttacked(row - 2, column + 1, board)) currentAttackPositions++;
            if (IsPositionAttacked(row - 1, column - 2, board)) currentAttackPositions++;
            if (IsPositionAttacked(row - 1, column + 2, board)) currentAttackPositions++;
            if (IsPositionAttacked(row + 1, column - 2, board)) currentAttackPositions++;
            if (IsPositionAttacked(row + 1, column + 2, board)) currentAttackPositions++;
            if (IsPositionAttacked(row + 2, column - 1, board)) currentAttackPositions++;
            if (IsPositionAttacked(row + 2, column + 1, board)) currentAttackPositions++;

            return currentAttackPositions;
        }

        private static bool IsPositionAttacked(int row, int column, char[][] board)
        {
            return IsInMatrix(row, column, board[0].Length) &&
                board[row][column] == 'K';
        }

        private static bool IsInMatrix(int row, int col, int n)
        {
            return 0 <= row && row < n && 0 <= col && col < n;
        }
    }
}
