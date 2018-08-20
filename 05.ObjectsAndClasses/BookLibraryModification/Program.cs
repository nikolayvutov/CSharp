using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibraryModification
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

            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

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
                    if (!dict.ContainsKey(book.Title))
                    {
                        dict.Add(book.Title, book.ReleaseDate);
                    }
                    else
                    {
                        dict[book.Title] = book.ReleaseDate;
                    }
                }
            }

            DateTime currentDate = DateTime.ParseExact(Console.ReadLine(),
                                                       "dd.MM.yyyy",
                                                       CultureInfo
                                                       .InvariantCulture);



            var sorted = dict.Where(x => x.Value > currentDate).OrderBy(x => x.Value).ThenBy(x => x.Key);

            foreach (var pair in sorted)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}",pair.Key, pair.Value );
            }
        }
    }
}
