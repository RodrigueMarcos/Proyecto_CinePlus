using System;
using System.Collections.Generic;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Dtos
{
    public interface IGenereService
    {
        public IEnumerable<Genere> GetGeneres();
        public Genere GetGenere(int id);
        public void SaveGenere(GenereDto genereDto);
        public void UpdateGenere(GenereDto genereDto, int id);
        public void DeleteGenere(int id);
    }

}
