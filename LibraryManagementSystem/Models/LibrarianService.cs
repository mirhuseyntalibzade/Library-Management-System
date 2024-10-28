using LibraryManagementSystem.CustomException;
using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class LibrarianService : ILibrarianService
    {
        Librarian[] _librarians;

        public LibrarianService()
        {
            _librarians = new Librarian[0];
        }
        public void CreateLibrarian(Librarian librarian)
        {
            Array.Resize(ref _librarians, _librarians.Length + 1);
            _librarians[_librarians.Length - 1] = librarian;
        }

        public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
        {
            if (IsSoftDelete)
            {
                librarian.isDeleted = true;
            }
            else
            {
                Librarian[] temporaryArray = new Librarian[_librarians.Length - 1];
                int index = 0;
                foreach (Librarian item in _librarians)
                {
                    if (item != librarian)
                    {
                        temporaryArray[index] = item;
                        index++;
                    }
                }

                _librarians = temporaryArray;
            }
        }

        public Librarian[] GetAllLibrarians()
        {
            return _librarians;
        }

        public Librarian GetLibrarianById(int id)
        {
            foreach (var item in _librarians)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
