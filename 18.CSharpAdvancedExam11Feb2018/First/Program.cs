using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine().Split(new[] { ' ' },
                                                        StringSplitOptions
                                                        .RemoveEmptyEntries)
                                      .Select(int.Parse).ToArray();
            var locksInput = Console.ReadLine().Split(new[] { ' ' },
                                                        StringSplitOptions
                                                        .RemoveEmptyEntries)
                                      .Select(int.Parse).ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(bulletsInput);
            var locks = new Queue<int>(locksInput);

            int count = 0;
            int money = 0;

            while (locks.Count > 0 && bullets.Count > 0)
            {
                int bulletSize = bullets.Pop();
                int locksSize = locks.Peek();

                if (bulletSize > locksSize)
                {
                    Console.WriteLine("Ping!");

                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                money++;
                count++;

                if (count == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                }
            }

            int finalMoney = intelligenceValue - (money * priceOfBullet);

            if (bullets.Any() || (bullets.Count == 0 && locks.Count == 0))
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${finalMoney}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
