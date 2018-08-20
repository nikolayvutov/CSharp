using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CubicArtillery
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int freeCapacity = capacity;

            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();

            Regex regex = new Regex("[a-zA-Z]");

            string input;

            while ((input = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = input.Split(new[] { ' ', '\t', '\n' },
                                         StringSplitOptions
                                         .RemoveEmptyEntries);


                foreach (var item in tokens)
                {
                    if (regex.IsMatch(item))
                    {
                        bunkers.Enqueue(item);
                    }
                    else
                    {
                        int weaponCapacity = int.Parse(item);
                        bool weaponContained = false;

                        while (bunkers.Count > 1)
                        {
                            if (freeCapacity >= weaponCapacity)
                            {
                                weapons.Enqueue(weaponCapacity);
                                freeCapacity -= weaponCapacity;
                                weaponContained = true;
                                break;
                            }

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> Empty");
                            }
                            else 
                            {
                                Console.WriteLine($"{bunkers.Peek()} -> {string.Join(", ", weapons)}");
                            }

                            bunkers.Dequeue();
                            weapons.Clear();
                            freeCapacity = capacity;

                        }


                        if (!weaponContained && bunkers.Count == 1)
                        {
                            if (capacity >= weaponCapacity)
                            {
                                if (freeCapacity < weaponCapacity)
                                {
                                    while (freeCapacity < weaponCapacity)
                                    {
                                        int removedWeapon = weapons.Dequeue();
                                        freeCapacity += removedWeapon;
                                    }
                                }

                                weapons.Enqueue(weaponCapacity);
                                freeCapacity -= weaponCapacity;
                            }
                        }
                    }
                }
            }
        }
    }
}
