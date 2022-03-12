using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Exemptions
{
    class SameMoviealreadyAddedExpection:Exception
    {
        public SameMoviealreadyAddedExpection(string message):base(message)
        {

        }
    }
}
