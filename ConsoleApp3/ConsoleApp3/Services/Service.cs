using ConsoleApp3.Enums;
using ConsoleApp3.Exceptions;
using ConsoleApp3.Exemptions;
using ConsoleApp3.Interfaces;
using ConsoleApp3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Services
{
    class Service : IParkCinemaManager
    {

        private List<Movie> _movies;
        public List<Movie> Movie => _movies ;

        public Service()
        {
            _movies = new List<Movie>();
        }

        public void Add(Movie movie)
        {
            if (_movies.Exists(m=>m.Name==movie.Name))
            {
                throw new SameMoviealreadyAddedExpection("Bu adda movie artiq movcuddur");
            }
            _movies.Add(movie);
        }

        public List<Movie> Filter(string director, Genre genre)
        {
            return _movies.FindAll(d => d.Director == director && d.Genre == genre);
        }

        public List<Movie> Search(string value)
        {
            return _movies.FindAll(d => d.Name.Contains(value));
        }

        public Movie ShowInfo(string ad)
        {
            if (_movies.Find(n=>n.Name==ad)!=null)
            {
                return _movies.Find(n => n.Name == ad);
            }
            throw new MovieNotFoundException("Daxil edilen adda movie yoxdur");
        }
    }
}
