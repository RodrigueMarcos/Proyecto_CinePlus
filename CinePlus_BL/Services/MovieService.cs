using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;
using CinePlus_BL.Dtos;
using CinePlus_DAL;

namespace CinePlus_BL.Services
{

    public class MovieService : IMovieService
    {
        private readonly CinePlusContext _context;

        public MovieService(CinePlusContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.FirstOrDefault(movie => movie.ID == id);
        }

        public void SaveMovie(MovieDto movieDto)
        {
            var movie = new Movie()
            {
                title = movieDto.title,
                duration = movieDto.duration,
                director = movieDto.directorID,
                synopsis = movieDto.synopsis,
                createdAt = DateTime.Now,
                createdBy = movieDto.createdByID,
            };

            if (movieDto.genereIDs != null)
            {
                movie.generes = new List<Genere>();
                foreach (var genereID in movieDto.genereIDs)
                {
                    movie.generes.Add(new Genere { ID = genereID });
                }
            }

            if (movieDto.actorIDs != null)
            {
                movie.actors = new List<Person>();
                foreach (var actorID in movieDto.actorIDs)
                {
                    movie.actors.Add(new Person { ID = actorID });
                }
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(MovieDto movieDto, int id)
        {
            var movie = _context.Movies.FirstOrDefault(movie => movie.ID == id);

            movie.title = movieDto.title;
            movie.duration = movieDto.duration;
            movie.director = movieDto.directorID;
            movie.synopsis = movieDto.synopsis;
            movie.modifiedAt = DateTime.Now;
            movie.modifiedBy = movieDto.modifiedByID;

            if (movieDto.genereIDs != null)
            {
                movie.generes = new List<Genere>();
                foreach (var genereID in movieDto.genereIDs)
                {
                    movie.generes.Add(new Genere { ID = genereID });
                }
            }

            if (movieDto.actorIDs != null)
            {
                movie.actors = new List<Person>();
                foreach (var actorID in movieDto.actorIDs)
                {
                    movie.actors.Add(new Person { ID = actorID });
                }
            }

            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.ID == id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }    
        }
    }
}
