using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethdsAndClasses
{
    public class Book
    {
        public string Title { get; set; }
        public static int count = 0;
        public string Author { get; set; }
        private int pageount;//-x => 0
        public bool IsAvelabe {  get; set; }


        public int PageCout
        {
            get { return pageount; }
            set
            {
                if (value < 0)
                {
                    pageount = 0;
                }
                else
                {
                    pageount = value;
                }
            }
        }
        public string Describe()
        {
            return $"{Title}, {Author}, {pageount}";
        }
        public bool IsLong()
        {
            return pageount > 300;
        }
        public bool borrow()
        {
            if (!IsAvelabe)
            {
                return false;
            }
            IsAvelabe = false;
            return true;
        }
        public bool Return()
        {
            if (IsAvelabe)
            {
                return false;
            }
            IsAvelabe = true;
            return true;
        }
        public Book(string title, string author, int pc)
        {
            Title = title;
            Author = author;
            pageount = pc;
            count++;

        }
        public Book(string[] data)
        {
            Title = data[0];
            Author = data[1];
            pageount = int.Parse(data[2]);
        }
    }
}
