using System;

namespace Sneaking
{
    class Program
    {
        static int playerRow;
        static int playerCol;
        static int nikoladzeRow;
        static int nikoladzeCol;

        static char[][] jagged;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            jagged = new char[n][];


            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = Console.ReadLine().ToCharArray();
            }
            var movement = Console.ReadLine().ToCharArray();

            string outputLine = string.Empty;

            foreach (var move in movement)
            {
                MoveEnemy();

                int[] previousLocation = SamMove(move);

                if (playerRow == nikoladzeRow)
                {
                    jagged[nikoladzeRow][nikoladzeCol] = 'X';
                    outputLine = "Nikoladze killed!";
                    break;
                }

                if (IsOnSameRowDead())
                {
                    Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                    break;
                }
            }

            PrintMatrix();

        }

        private static bool IsOnSameRowDead()
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j] == 'b' && playerRow == i)
                    {
                        if (playerCol > j)
                        {
                            return true;
                        }
                    }

                    if (jagged[i][j] == 'd' && playerRow == i)
                    {
                        if (playerCol < j)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[1].Length; col++)
                {
                    Console.Write(jagged[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static int[] SamMove(char input)
        {
            int[] previousLocation = { playerRow, playerCol };

            switch (input)
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
                case 'W':
                    break;
            }

            jagged[playerRow][playerCol] = 'S';

            int oldRow = previousLocation[0];
            int oldCol = previousLocation[1];

            jagged[oldRow][oldCol] = '.';

            return previousLocation;
        }

        private static void MoveEnemy()
        {
            int max = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < jagged[i].Length-1; j++)
                {
                    max++;
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    if (jagged[row][col] == 'N')
                    {
                        nikoladzeRow = row;
                        nikoladzeCol = col;
                    }

                    if (jagged[row][col] == 'b')
                    {
                        if (col != max)
                        {
                            jagged[row][col + 1] = 'b';
                            jagged[row][col] = '.';
                            break;
                        }
                        else
                        {
                            jagged[row][col] = 'd';
                            break;
                        }
                    }
                    else if (jagged[row][col] == 'd')
                    {
                        if (col != 0)
                        {
                            jagged[row][col - 1] = 'd';
                            jagged[row][col] = '.';
                            break;
                        }
                        else
                        {
                            jagged[row][col] = 'b';
                            break;
                        }
                    }

                }
            }
        }
    }
}
