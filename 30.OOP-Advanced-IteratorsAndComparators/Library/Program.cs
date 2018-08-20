using System;

class Program
{
    public static void Main()
    {
        Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
        Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
        Book bookThree = new Book("The Documents in the Case", 1930);

        Library libraryOne = new Library();
        Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

        BookComparator bc = new BookComparator();

        foreach (var book in libraryTwo)
        {
            Console.WriteLine(book);
        }


        //BookComparator bc = new BookComparator();

        //Console.WriteLine(bc.Compare(bookOne, bookTwo) == -1);
        //Console.WriteLine(bc.Compare(bookThree, bookOne) == 1);
        //Console.WriteLine(bc.Compare(bookOne, bookOne) == 0);
        //Console.WriteLine(bc.Compare(bookTwo, bookThree) == -1);
    }
}

