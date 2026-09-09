using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethdsAndClasses
{
    internal class Library
    {
        public string Name { get; set; }
        private List<Book> books;
        public int bookcount
        {
            get { return books.Count;}
        }


        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        //5.printall
        public void PrintAll()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Describe());
            }
        }
        public void FindByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (title == book.Title)
                {
                    Console.WriteLine(book.Describe());
                }               
                else
                {
                    Console.WriteLine("not found");
                }
            }
        }
        public void AvaliableBook()
        {
            foreach (Book book in books)
            {
                if (book.IsAvelabe)
                {
                    Console.WriteLine(book.Describe());
                }
            }
        }





    }
}
