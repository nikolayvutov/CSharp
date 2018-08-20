using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var readStream = new StreamReader("word.txt"))
            {
                string line;
                var dict = new Dictionary<string, int>();

                while((line = readStream.ReadLine()) != null)
                {
                    dict.Add(line, 0);
                }

                using (var secondReadStream = new StreamReader("text.txt"))
                {
                    using (var writeStream = new StreamWriter("Answer.txt"))
                    {

                        var inputLine = secondReadStream.ReadLine();
                        while ((inputLine) != null)
                        {
                            var tokens = inputLine.ToLower().Split(new char[]{' ', '-', ',',
                        '.', '!', '?'}).ToArray();

                            foreach (var item in tokens)
                            {
                                if (dict.ContainsKey(item))
                                {
                                    dict[item] += 1;
                                }
                            }

                            inputLine = secondReadStream.ReadLine();
                        }


                    foreach (var i in dict.OrderByDescending(x => x.Value))
                        {
                            writeStream.WriteLine($"{i.Key} - {i.Value}");
                        }
                    }
                }
            }
        }
    }
}
