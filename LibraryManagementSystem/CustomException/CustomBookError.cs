using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.CustomException
{
    internal class CustomBookError : Exception
    {
        public CustomBookError()
        { }

        public CustomBookError(string message)
            : base(message)
        { }

        public CustomBookError(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
