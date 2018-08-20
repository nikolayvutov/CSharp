using System;
using System.Linq;
using System.Text;

public class Book
{
    private string author;
    private string title;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get { return author; }
        protected set
        {
            var parts = value.Split();
            if (parts.Length > 1)
            {
                if (Char.IsDigit(parts[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            this.author = value;
        }
    }

    public string Title
    {
        get { return title; }
        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        protected set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f2}")
            .AppendLine();

        return sb.ToString();

    }
}
