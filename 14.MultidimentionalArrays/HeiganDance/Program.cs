using System;
using System.Linq;

namespace HeiganDance
{
    class Program
    {
        const int min = 0;
        const int max = 14;

        static int playerRow = 7;
        static int playerCol = 7;

        static void Main(string[] args)
        {
            const int cloudDamage = 3500;
            const int eruptionDamage = 6000;

            double heiganHealth = 3_000_000.0;
            int playerHealth = 18_500;
            bool hasCloud = false;
            string causeOfDeath = "";

            double playerDamage = double.Parse(Console.ReadLine());

            while (playerHealth > 0)
            {
                heiganHealth -= playerDamage;

                if (hasCloud)
                {
                    playerHealth -= cloudDamage;
                    hasCloud = false;
                    causeOfDeath = "Plague Cloud";
                }

                if (heiganHealth <= 0 || playerHealth <= 0)
                {
                    break;
                }

                string[] spellTokens = Console.ReadLine().Split();
                string spellName = spellTokens[0];
                int rowHit = int.Parse(spellTokens[1]);
                int colHit = int.Parse(spellTokens[2]);

                int[][] damageArea = GetDamageArea(rowHit, colHit);

                if (IsPlayerInDamageZone(damageArea))
                {
                    int rowAbove = playerRow - 1;
                    int rowBelow = playerRow + 1;
                    int leftCol = playerCol - 1;
                    int rightCol = playerCol + 1;

                    if (rowAbove >= min && !damageArea[0].Contains(rowAbove))
                    {
                        playerRow = rowAbove;
                    }
                    else if (rightCol <= max && !damageArea[1].Contains(rightCol))
                    {
                        playerCol = rightCol;
                    }
                    else if (rowBelow <= max && !damageArea[0].Contains(rowBelow))
                    {
                        playerRow = rowBelow;
                    }
                    else if (leftCol <= max && !damageArea[1].Contains(leftCol))
                    {
                        playerCol = leftCol;
                    }

                    else
                    {
                        if (spellName == "Cloud")
                        {
                            playerHealth -= cloudDamage;
                            hasCloud = true;
                            causeOfDeath = "Plague Cloud";
                        }
                        else
                        {
                            playerHealth -= eruptionDamage;
                            causeOfDeath = "Eruption";
                        }
                    }
                }
            }

            string heiganFinish = heiganHealth > 0 ? heiganHealth.ToString("f2") : "Defeated!";
            string playerFinish = playerHealth > 0 ? playerHealth.ToString() : $"Killed by {causeOfDeath}";

            Console.WriteLine($"Heigan: {heiganFinish}");
            Console.WriteLine($"Player: {playerFinish}");
            Console.WriteLine($"Final position: {playerRow}, {playerCol}");

        }

        private static bool IsPlayerInDamageZone(int[][] damageArea)
        {
            

            bool isInRowsHit = damageArea[0].Contains(playerRow);

            bool isInColsHit = damageArea[1].Contains(playerRow);

            return isInRowsHit && isInColsHit;
        }

        private static int[][] GetDamageArea(int rowHit, int colHit)
        {
            int[][] damageArea = new int[2][];

            damageArea[0] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                damageArea[0][i] = rowHit + i - 1;

            }

            damageArea[1] = new int[3];
            for (int i = 0; i < 3; i++)
            {
                damageArea[1][i] = colHit + i - 1;

            }

            return damageArea;
        }
    }
}
