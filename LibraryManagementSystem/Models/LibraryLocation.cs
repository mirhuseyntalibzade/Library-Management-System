using LibraryManagementSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal struct LibraryLocation
    {
        public int Aisle { get; set; }
        public int Shelf { get; set; }
        public BookGenre Genre { get; set; }

        public LibraryLocation(int aisle, int shelf, BookGenre genre)
        {
            Aisle = aisle;
            Shelf = shelf;
            Genre = genre;
        }
    }
}
