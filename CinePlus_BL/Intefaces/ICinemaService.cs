using System;
using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public interface ICinemaService
    {
        IEnumerable<Cinema> GetCinemas();
        Cinema GetCinema(int id);
        void SaveCinema(CinemaDTO cinemaDto);
        void UpdateCinema(CinemaDTO cinemaDto, int id);
        void DeleteCinema(int id);
    }

}

