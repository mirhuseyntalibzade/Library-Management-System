using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Librarian : Person
    {
        public bool isDeleted { get; set; }
        public DateTime HireDate { get; set; }
        public Librarian(string name) : base(name)
        {
            Name = name;
        }
    }
}
