using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public interface IBookStore
    {
        void DisplayBookDetails(Book book);
    }

    public class OnlineBookStore : IBookStore
    {
        public void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"Online Book Store: {book.GetDescription()} - {book.Title} by {book.Author}");
        }
    }

    public class PhysicalBookStore : IBookStore
    {
        public void DisplayBookDetails(Book book)
        {
            Console.WriteLine($"Physical Book Store: {book.GetDescription()} - {book.Title} by {book.Author}");
        }
    }
}
