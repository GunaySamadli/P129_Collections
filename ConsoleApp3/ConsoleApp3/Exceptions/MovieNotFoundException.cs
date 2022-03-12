using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Exceptions
{
    class MovieNotFoundException:Exception
    {
        public MovieNotFoundException(string message):base(message)
        {

        }
    }
}
