using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }
        public DateTime? PublicationYear { get; set; }
        public LibraryItem(string title, DateTime publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }
        public abstract void DisplayInfo();
    }
}
