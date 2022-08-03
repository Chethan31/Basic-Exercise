using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookTest
    {
        public static void Main()
        {
            Book book1 = new Book("asa","asas",true);
            book1.display();
            Book book2 = new Book("dsdas", "dssfsd");
            book2.display();
            Book book3 = new Book("asa");
            book3.display();
            Book book4 = new Book();
            book4.display();
        }
    }
}
