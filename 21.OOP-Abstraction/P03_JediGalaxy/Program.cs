using System;
using System.Linq;

class Program
{
    private static int[,] matrix;
    private static long sum;

    static void Main()
    {
        int[] dimestions = Console.ReadLine()
                          .Split(new string[] { " " }, 
                         StringSplitOptions
                         .RemoveEmptyEntries)
                          .Select(int.Parse).ToArray();
        
        int x = dimestions[0];
        int y = dimestions[1];

        FillMatrix(x, y);
        sum = 0;
        string command;
        while ((command = Console.ReadLine())!= "Let the Force be with you")
        {
            int[] ivoS = command
                .Split(new string[] { " " }, 
               StringSplitOptions
               .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int[] evil = Console.ReadLine()
                .Split(new string[] { " " }, 
               StringSplitOptions
               .RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            
            int xEvil = evil[0];
            int yEvil = evil[1];

            EvilCollectedStars(xEvil, yEvil);

            int xIvos = ivoS[0];
            int yIvos = ivoS[1];
            sum = IvoCollectedStarsSum(xIvos, yIvos);

        }
        Console.WriteLine(sum);
    }
    private static long IvoCollectedStarsSum(int xIvo, int yIvo)
    {
        while (xIvo >= 0 && yIvo < matrix.GetLength(1))
        {
            if (IsInBounds(xIvo, yIvo))
            {
                sum += matrix[xIvo, yIvo];
            }

            yIvo++;
            xIvo--;
        }
        return sum;
    }

    private static void EvilCollectedStars(int xEvil, int yEvil)
    {
        while (xEvil >= 0 && yEvil >= 0)
        {
            if (IsInBounds(xEvil, yEvil))
            {
                matrix[xEvil, yEvil] = 0;
            }
            xEvil--;
            yEvil--;
        }
    }

    private static bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }

    private static void FillMatrix(int x, int y)
    {
        matrix = new int[x, y];

        int value = 0;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                matrix[i, j] = value++;
            }
        }
    }
}

