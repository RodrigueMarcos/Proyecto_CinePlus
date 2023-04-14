using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(int id);
        void SaveMovie(MovieDTO movieDto);
        void UpdateMovie(MovieDTO movieDto, int id);
        void DeleteMovie(int id);
        IEnumerable<Genere> GetMovieGenres(int id);
        IEnumerable<Person> GetMoviePeople(int id);
    }
}
