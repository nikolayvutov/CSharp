using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ID { get; set; }
        public decimal Price { get; set; }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }
    }

    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime
                    .ParseExact(input[3], "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                string id = input[4];
                decimal price = decimal.Parse(input[5]);


                Book book = new Book();
                book.Title = title;
                book.Author = author;
                book.Publisher = publisher;
                book.ReleaseDate = releaseDate;
                book.ID = id;
                book.Price = price;

                Library library = new Library();

                library.Name = book.Author;
                library.ListOfBooks = new List<Book>();

                library.ListOfBooks.Add(book);

                foreach (var b in library.ListOfBooks)
                {
                    if (!dict.ContainsKey(book.Author))
                    {
                        dict.Add(book.Author, book.Price);
                    }
                    else
                    {
                        dict[book.Author] += book.Price;
                    }
                }
            }

            var sorted = dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }
    }
}
