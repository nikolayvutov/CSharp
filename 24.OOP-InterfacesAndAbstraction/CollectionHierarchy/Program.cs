using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());

        var addCollection = new AddCollection();
        var addRemoveCollection = new AddRemoveCollection();
        var myList = new MyList();

        var addList = new List<string>();
        var addRemoveList = new List<string>();
        var list = new List<string>();

        foreach (var item in input)
        {
            addList.Add(addCollection.Add(item));
            addRemoveList.Add(addRemoveCollection.Add(item));
            list.Add(myList.Add(item));
        }

        Console.WriteLine(string.Join(" ", addList));
        Console.WriteLine(string.Join(" ", addRemoveList));
        Console.WriteLine(string.Join(" ", list));

        addRemoveList.Clear();
        list.Clear();

        for (int i = 0; i < n; i++)
        {
            addRemoveList.Add(addRemoveCollection.Remove());
            list.Add(myList.Remove());
        }

        Console.WriteLine(string.Join(" ", addRemoveList));
        Console.WriteLine(string.Join(" ", list));
    }

}

