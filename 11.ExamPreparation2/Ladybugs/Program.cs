using System;
using System.Linq;
using System.Collections.Generic;

class LadyBugs
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            if (indexes.Contains(i))
            {
                array[i] = 1;
            }
        }

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] commands = input.Split(' ');
            int ladyBugIndex = int.Parse(commands[0]);
            string direction = commands[1];
            int moves = int.Parse(commands[2]);

            if (ladyBugIndex < 0 || ladyBugIndex >= array.Length)
            {
                continue;
            }
            if (array[ladyBugIndex] == 0)
            {
                continue;
            }

            else
            {
                if (direction == "right")
                {
                    if (moves > 0)
                    {
                        MoveRight(array, ladyBugIndex, moves);
                    }
                    else if (moves < 0)
                    {
                        MoveLeft(array, ladyBugIndex, moves);
                    }
                }
                if (direction == "left")
                {
                    if (moves > 0)
                    {
                        MoveLeft(array, ladyBugIndex, moves);
                    }
                    else if (moves < 0)
                    {
                        MoveRight(array, ladyBugIndex, moves);
                    }
                }
            }


        }

        Console.WriteLine(string.Join(" ", array));
    }

    static void MoveRight(int[] array, int index, int moves)
    {
        if (index + moves >= array.Length)
        {
            array[index] = 0;
        }
        else
        {
            moves = Math.Abs(moves);
            array[index] = 0;
            for (int i = index + moves; i < array.Length; i+= moves)
            {
                if (array[i] == 1)
                {
                    continue;
                }

                else
                {
                    array[i] = 1;
                    break;
                }
            }
        }
        return;

    }

    static void MoveLeft(int[] array, int index, int moves)
    {
        if (index - moves < 0)
        {
            array[index] = 0;
        }
        else
        {
            moves = Math.Abs(moves);
            array[index] = 0;
            for (int i = index - moves; i >= 0; i-= moves)
            {
                if (array[i] == 1)
                {
                    continue;
                }
                else
                {
                    array[i] = 1;
                    break;
                }
            }
        }
        return;
    }
}

