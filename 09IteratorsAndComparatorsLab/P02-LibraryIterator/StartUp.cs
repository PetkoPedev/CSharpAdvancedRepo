using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book("Harry Potter", 2000, "J.K. Rowling"),
                new Book("Hitchicker Guide to the Galaxy", 1998, "Hulk"),
                new Book("I, Robot", 2000, "Asimov"),
                new Book("Programming Basics", 1998, "Hulk"),
                new Book("Programming Fundamentals", 2000, "Nakov", "Big Joe"),
                new Book("ABC", 1998, "Hulk")
            };

            var library = new Library(books);

            foreach (var book in library)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
