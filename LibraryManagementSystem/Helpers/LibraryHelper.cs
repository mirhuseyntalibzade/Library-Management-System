using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Helpers
{
    internal static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            int currentYear = DateTime.Now.Year;
            int publicationYear = item.PublicationYear.Value.Year;
            return currentYear - publicationYear;
        }

        public static string ToTitleCase(this string title)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(title[0]));
            sb.Append(title.Substring(1, title.Length-1).ToLower());
            return sb.ToString();
        }
    }
}
