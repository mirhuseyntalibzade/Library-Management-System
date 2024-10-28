using LibraryManagementSystem.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class LibraryCatalog
    {
        Book[] books;
        public LibraryCatalog()
        {
            books = new Book[0];
        }

        public Book[] AddBooks(params Book[] inputBooks)
        {
            Array.Resize(ref books, books.Length + inputBooks.Length);
            return books;
        }

        public Book this[int id]
        {
            get
            {
                foreach (var book in books)
                {
                    if (book.Id == id)
                    {
                        return book;
                    }
                }

                throw new CustomBookError($"The book with ID {id} is not found in the catalog.");
            }
            set
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Id == id)
                    {
                        books[i] = value;
                    }
                }

                throw new CustomBookError($"The book with ID {id} is not found in the catalog.");
            }
        }
    }
}
