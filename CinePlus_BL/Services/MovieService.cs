using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;
using CinePlus_BL.Dtos;
using CinePlus_DAL;
using Microsoft.EntityFrameworkCore;

namespace CinePlus_BL.Services
{

    public class MovieService : IMovieService
    {
        private readonly CinePlusDBContext _context;

        public MovieService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(movie => movie.Director)
                .Include(movie => movie.MoviePersons).ThenInclude(movieperson => movieperson.Person)
                .Include(movie => movie.MovieGeneres).ThenInclude(moviegenre => moviegenre.Genere)
                .ToList();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.Include(movie => movie.Director)
                .Include(movie => movie.MoviePersons).ThenInclude(movieperson => movieperson.Person)
                .Include(movie => movie.MovieGeneres).ThenInclude(moviegenre => moviegenre.Genere)
                .FirstOrDefault(movie => movie.ID == id);
        }

        public void SaveMovie(MovieDTO movieDto)
        {
            var director = _context.People.Find(movieDto.DirectorID);

            if (director == null)
            {
                throw new ArgumentException("Invalid director ID.");
            }

            var createdBy = _context.People.Find(movieDto.CreatedById);

            if (createdBy == null)
            {
                throw new ArgumentException("Invalid created by person ID.");
            }

            var movie = new Movie()
            {
                Title = movieDto.Title,
                Duration = movieDto.Duration,
                DirectorID = director.ID,
                Director = director,
                Synopsis = movieDto.Synopsis,
                createdAt = DateTime.Now,
                CreatedById = createdBy.ID,
            };

            _context.Movies.Add(movie);

            if (movieDto.Genres != null)
            {
                foreach (var genereDto in movieDto.Genres)
                {
                    var genere = _context.Generes.Find(genereDto.ID);

                    if (genere != null)
                    {
                        movie.MovieGeneres.Add(new MovieGenere() { Movie = movie, Genere = genere });
                    }
                }
            }

            _context.SaveChanges();
        }

        public void UpdateMovie(MovieDTO movieDto, int id)
        {
            var movie = _context.Movies.Include(m => m.MovieGeneres)
                .FirstOrDefault(m => m.ID == id);

            if (movie == null)
            {
                throw new ArgumentException("Movie not found.");
            }

            var director = _context.People.Find(movieDto.DirectorID);
            if (director == null)
            {
                throw new ArgumentException("Invalid director ID.");
            }
            movie.Title = movieDto.Title;
            movie.Duration = movieDto.Duration;
            movie.DirectorID = director.ID;
            movie.Director = director;
            movie.Synopsis = movieDto.Synopsis;
            movie.modifiedAt = DateTime.Now;

            var modifiedBy = _context.People.FirstOrDefault(person => person.ID == movieDto.ModifiedById.Value);

            if (modifiedBy == null)
            {
                throw new ArgumentException("Modified by person not found.");
            }
            movie.ModifiedById = movieDto.ModifiedById.Value;
            movie.MovieGeneres.Clear();

            if (movieDto.Genres != null)
            {
                foreach (var genereDto in movieDto.Genres)
                {
                    var genere = _context.Generes.Find(genereDto.ID);

                    if (genere != null)
                    {
                        movie.MovieGeneres.Add(new MovieGenere() { Movie = movie, Genere = genere });
                    }
                }
            }
            _context.SaveChanges();
        }
        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);

            if (movie == null)
            {
                throw new ArgumentException("Movie not found.");
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Genere> GetMovieGenres(int id)
        {
            var movie = _context.Movies.Include(movie => movie.MovieGeneres)
                .FirstOrDefault(m => m.ID == id);

            if (movie == null)
            {
                throw new ArgumentException("Movie not found.");
            }

            var genres = movie.MovieGeneres.Select(moviegenre => moviegenre.Genere).ToList();

            return genres;
        }

        public IEnumerable<Person> GetMoviePeople(int id)
        {
            var movie = _context.Movies.Include(movie => movie.MoviePersons)
                .FirstOrDefault(movie => movie.ID == id);

            if (movie == null)
            {
                throw new ArgumentException("Movie not found.");
            }

            var people = movie.MoviePersons.Select(movieperson => movieperson.Person).ToList();

            return people;
        }
    }
}


