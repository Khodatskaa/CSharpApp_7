using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_7
{
    public abstract class Book
    {
        public string? Title { get; protected set; }
        public string? Author { get; protected set; }

        public abstract string GetDescription();
    }

    public class ElectronicBook : Book
    {
        public ElectronicBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string GetDescription()
        {
            return "This is an electronic book";
        }
    }

    public class PrintedBook : Book
    {
        public PrintedBook(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string GetDescription()
        {
            return "This is a printed book";
        }
    }
}
