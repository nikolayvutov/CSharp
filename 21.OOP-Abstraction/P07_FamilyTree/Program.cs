using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {
            var familyTree = new List<Person>();
            string mainPersonInput = Console.ReadLine();

            Person mainPerson = Person.CreatePerson(mainPersonInput);
            familyTree.Add(mainPerson);

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                ParseInput(input, familyTree);
            }

            PrintPersonTree(mainPerson);
        }

        private static void PrintPersonTree(Person mainPerson)
        {
            Console.WriteLine(mainPerson);
            Console.WriteLine("Parents:");
            foreach (var p in mainPerson.Parents)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Children:");
            foreach (var c in mainPerson.Children)
            {
                Console.WriteLine(c);
            }
        }

        private static void ParseInput(string input, List<Person> familyTree)
        {
            string[] tokens = input.Split(" - ");
            if (tokens.Length > 1)
            {
                string parentInput = tokens[0];
                string childInput = tokens[1];

                SetParentChildRelation(parentInput, childInput, familyTree);
            }
            else
            {
                tokens = tokens[0].Split();
                string name = $"{tokens[0]} {tokens[1]}";
                string birthday = tokens[2];

                SetFullInfo(familyTree, name, birthday);
            }
        }

        private static void SetFullInfo(List<Person> familyTree, string name, string birthday)
        {
            var person = familyTree
                    .FirstOrDefault(p => p.Name == name || p.Birthday == birthday);

            if (person == null)
            {
                person = new Person();
                familyTree.Add(person);
            }
            person.Name = name;
            person.Birthday = birthday;

            CheckForDuplicate(familyTree, person);



        }

        private static void CheckForDuplicate(List<Person> familyTree, Person person)
        {
            string name = person.Name;
            string birthday = person.Birthday;

            Person duplicate = familyTree
                .Where(p => p.Name == name || p.Birthday == birthday)
                .Skip(1)
                .FirstOrDefault();

            if (duplicate != null)
            {
                RemoveDuplicate(person, duplicate, familyTree);
            }
        }

        private static void RemoveDuplicate(Person person, Person duplicate, List<Person> familyTree)
        {
            familyTree.Remove(duplicate);

            person.Parents.AddRange(duplicate.Parents);
            //person.Parents = person.Parents.Distinct().ToList();
            foreach (var parent in duplicate.Parents)
            {
                ReplaceDuplicate(person, duplicate, parent.Children);
            }

            person.Children.AddRange(duplicate.Children);
            //person.Children = person.Children.Distinct().ToList();
            foreach (var child in duplicate.Children)
            {
                ReplaceDuplicate(person, duplicate, child.Parents);
            }
        }

        private static void SetParentChildRelation(string parentInput, string childInput, List<Person> familyTree)
        {
            Person currentPerson = familyTree
                .FirstOrDefault(p => p.Birthday == parentInput || p.Name == parentInput);

            if (currentPerson == null)
            {
                currentPerson = Person.CreatePerson(parentInput);
                familyTree.Add(currentPerson);
            }

            SetChild(familyTree, currentPerson, childInput);
        }

        private static void ReplaceDuplicate(Person original, Person duplicate, List<Person> collection)
        {
            int duplicateIndex = collection.IndexOf(duplicate);
            if (duplicateIndex > -1)
            {
                collection[duplicateIndex] = original;
            }
            else
            {
                collection.Add(original);
            }
        }

        private static void SetChild(List<Person> familyTree, Person parent, string childInput)
        {
            var child = familyTree
                .FirstOrDefault(c => c.Name == childInput || c.Birthday == childInput);

            if (child == null)
            {
                child = Person.CreatePerson(childInput);
                familyTree.Add(child);
            }

            parent.Children.Add(child);
            child.Parents.Add(parent);
        }
    }

