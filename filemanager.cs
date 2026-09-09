using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethdsAndClasses
{
    internal class filemanager
    {
        public static List<Book> ReadFile(string fileName)
        {
            List<Book> Bookss = new List<Book>();
            try
            {
                foreach (string line in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    Bookss.Add(new Book(line.Split(';')));
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return Bookss;
        }
    }
}
