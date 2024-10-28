using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Book : LibraryItem
    {

        private static int _id;
        public int Id { get; set; }
        public string Genre { get; set; }
        public Book(string title, DateTime publicationYear) : base(title, publicationYear)
        {
            Id = _id++;
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"""
            Title of the book: {Title}
            Publish date of the book: {PublicationYear}
            Genre of the book: {Genre}
            """);
        }
    }
}
