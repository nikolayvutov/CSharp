using System;
using System.Linq;

namespace TextFilter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',',' ')
                                          .Where(w => w.Length > 0)
                                          .ToArray();

            string text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                var replace = new string('*', word.Length);
                text = text.Replace(word, replace);
            }
            Console.WriteLine(text);
        }
    }
}
