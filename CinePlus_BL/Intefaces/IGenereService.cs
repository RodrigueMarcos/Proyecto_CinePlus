using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public interface IGenereService
    {
        IEnumerable<Genere> GetGeneres();
        Genere GetGenere(int id);
        void SaveGenere(GenereDTO genereDto);
        void UpdateGenere(GenereDTO genereDto, int id);
        void DeleteGenere(int id);
        IEnumerable<Movie> GetMoviesByGenere(int genereId);
    }
}
