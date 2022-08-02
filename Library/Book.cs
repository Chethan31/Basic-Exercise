
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        private string title; 
        private string author; 
        private bool available; 
 
        public Book(string title, string author, bool available)
        { 
            this.title = title;
            this.author = author;   
            this.available = available;
            Console.WriteLine(this.title);
            Console.WriteLine(this.author);
            Console.WriteLine(this.available);
        }
        public Book(string title, string author):this(title, author, true)
        {
        }
        public Book(string title)
        {
            this.title = title;
            Console.WriteLine(this.title);
        }
        public Book()
        {
            title = "untitled";
            author = "anonymous";
            available = true;
            Console.WriteLine(title);
            Console.WriteLine(author);
            Console.WriteLine(available);
        }
    }
}
