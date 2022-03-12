using ConsoleApp3.Enums;
using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Interfaces
{
    interface IParkCinemaManager
    {
         List<Movie> Movie { get; }

         void Add(Movie movie);
         Movie ShowInfo(string ad);
        List<Movie> Search(string value);
        List<Movie> Filter(string director, Genre genre);





    }
}
