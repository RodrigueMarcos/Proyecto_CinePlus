using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public interface IMovieService
    {
        public IEnumerable<Movie> GetMovies();
        public Movie GetMovie(int id);
        public void SaveMovie(MovieDto movieDto);
        public void UpdateMovie(MovieDto movieDto, int id);
        public void DeleteMovie(int id);
    }
}
