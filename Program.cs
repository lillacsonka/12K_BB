namespace MethdsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("a", "n", 300);
            Book b = new Book("b", "n", 300);
            //List<Book> Books = filemanager.ReadFile("books.txt");
            //Console.WriteLine(Books[1].Describe);

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(Books[i]);
            //}
            Library libraries = new Library("library");
            libraries.AddBook(a);
            libraries.AddBook(b);



        }

    }
    
}
