using System;


class Sneaking
{
    static char[][] room;
    static int[] samPosition;
    static int[] getEnemy;

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        room = new char[n][];

        FillMatrix(n);

        var moves = Console.ReadLine().ToCharArray();

        samPosition = FindSamInRoom();
        int count = 0;
        foreach (var m in moves)
        {
            EnemiesMoves();

            getEnemy = GetEnemy();

            PlayerDead();

            PlayerMoves(moves, count);

            FindEnemyInRoom();

            NikoladzeDead();

            count++;
        }
    }

    private static void NikoladzeDead()
    {
        if (room[getEnemy[0]][getEnemy[1]] == 'N' && samPosition[0] == getEnemy[0])
        {
            room[getEnemy[0]][getEnemy[1]] = 'X';
            Console.WriteLine("Nikoladze killed!");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }
    }

    private static int[] PlayerMoves(char[] moves, int count)
    {
        switch (moves[count])
        {
            case 'U':
                samPosition[0]--;
                break;
            case 'D':
                samPosition[0]++;
                break;
            case 'L':
                samPosition[1]--;
                break;
            case 'R':
                samPosition[1]++;
                break;
            default:
                break;
        }

        room[samPosition[0]][samPosition[1]] = 'S';

        return samPosition;
    }

    private static int[] GetEnemy()
    {
        getEnemy = new int[2];

        for (int j = 0; j < room[samPosition[0]].Length; j++)
        {
            if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')
            {
                getEnemy[0] = samPosition[0];
                getEnemy[1] = j;
            }
        }
        return getEnemy;
    }

    private static void FindEnemyInRoom()
    {
        for (int j = 0; j < room[samPosition[0]].Length; j++)
        {
            if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')
            {
                getEnemy[0] = samPosition[0];
                getEnemy[1] = j;
            }
        }
    }

    private static int[] FindSamInRoom()
    {
        samPosition = new int[2];
        for (int row = 0; row < room.Length; row++)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                if (room[row][col] == 'S')
                {
                    samPosition[0] = row;
                    samPosition[1] = col;
                }
            }
        }
        return samPosition;
    }

    private static void PlayerDead()
    {
        if (samPosition[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == samPosition[0])
        {
            room[samPosition[0]][samPosition[1]] = 'X';

            Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");

            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }
        else if (getEnemy[1] < samPosition[1] && room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == samPosition[0])
        {
            room[samPosition[0]][samPosition[1]] = 'X';
            Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        room[samPosition[0]][samPosition[1]] = '.';
    }

    private static void EnemiesMoves()
    {
        for (int row = 0; row < room.Length; row++)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                if (room[row][col] == 'b')
                {
                    if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                    {
                        room[row][col] = '.';
                        room[row][col + 1] = 'b';
                        col++;
                    }
                    else
                    {
                        room[row][col] = 'd';
                    }
                }
                else if (room[row][col] == 'd')
                {
                    if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                    {
                        room[row][col] = '.';
                        room[row][col - 1] = 'd';
                    }
                    else
                    {
                        room[row][col] = 'b';
                    }
                }
            }
        }
    }

    private static void FillMatrix(int n)
    {
        for (int row = 0; row < n; row++)
        {
            var input = Console.ReadLine().ToCharArray();
            room[row] = new char[input.Length];
            for (int col = 0; col < input.Length; col++)
            {
                room[row][col] = input[col];
            }
        }
    }
}

