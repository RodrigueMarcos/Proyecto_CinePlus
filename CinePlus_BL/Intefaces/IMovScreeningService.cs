using CinePlus_DAL.Models;
using CinePlus_BL.Dtos;
using System;
using System.Collections.Generic;

namespace CinePlus_BL.Services
{
    public interface IMovScreeningService
    {
        IEnumerable<MovScreening> GetMovScreenings();
        MovScreening GetMovScreening(int id);
        void SaveMovScreening(MovScreeningDTO movScreeningDto);
        void UpdateMovScreening(MovScreeningDTO movScreeningDto, int id);
        void DeleteMovScreening(int id);
    }

}