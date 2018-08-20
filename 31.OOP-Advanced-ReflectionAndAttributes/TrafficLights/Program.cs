using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficLights
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            List<Color> list = new List<Color>();

            foreach (var item in input)
            {
                Color light;
                var isValid = Enum.TryParse(item, out light);

                if (isValid)
                {
                    list.Add(light);
                }
            }
            while (n-- > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    switch (list[i])
                    {
                        case Color.Red:
                            list[i] = Color.Green;
                            break;
                        case Color.Green:
                            list[i] = Color.Yellow;
                            break;
                        case Color.Yellow:
                            list[i] = Color.Red;
                            break;
                    }
                }
                Console.WriteLine(string.Join(" ", list));
            }
        }
    }
}
