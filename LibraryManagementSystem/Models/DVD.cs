using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class DVD : LibraryItem
    {
        private static int _id;
        public int Id { get; set; }
        public DVD(string title, DateTime publicationYear) : base(title, publicationYear)
        {
            Id = _id++;
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"""
            Title of the DVD: {Title}
            Publish date of the DVD: {PublicationYear}
            """);
        }
    }
}
