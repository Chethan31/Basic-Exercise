
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
 
        public Book(string title, string author, bool available):this(title)
        { 
            this.author = author;   
            this.available = available;
        }
        public Book(string title, string author):this(title, author, true)
        {
        }
        public Book(string title)
        {
            this.title = title;
        }
        public Book()
        {
            title = "untitled";
            author = "anonymous";
            available = true;
        }
        public void display()
        {
            Console.WriteLine(title);
            if(author!=null)
                Console.WriteLine(author);
            Console.WriteLine(available);
            Console.WriteLine();    
        }
    }
}
