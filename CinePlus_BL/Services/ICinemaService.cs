using System;
using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public interface ICinemaService
    {
        public IEnumerable<Cinema> GetCinemas();
        public Cinema GetCinema(int id);
        public void SaveCinema(CinemaDto cinemaDto);
        public void UpdateCinema(CinemaDto cinemaDto, int id);
        public void DeleteCinema(int id);
    }
}

