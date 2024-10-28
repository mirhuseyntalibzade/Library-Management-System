using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Magazine : LibraryItem
    {
        private static int _id;
        public int Id { get; set; }
        public Magazine(string title, DateTime publicationYear) : base(title, publicationYear)
        {
            Id = _id++;
            Title = title;
            PublicationYear = publicationYear;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"""
            Title of the Magazine: {Title}
            Publish date of the Magazine: {PublicationYear}
            """);
        }
    }
}
