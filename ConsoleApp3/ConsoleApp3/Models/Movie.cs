using ConsoleApp3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class Movie
    {

        public string Name;
        public string Director;
        public Genre Genre;

        public Movie(string name,string director,Genre genre)
        {
            Name = name;
            Director = director;
            Genre = genre;
        }


        public override string ToString()
        {
            return $"Adi:{Name} Director:{Director} Genre:{Genre}";
        }

    }
}
