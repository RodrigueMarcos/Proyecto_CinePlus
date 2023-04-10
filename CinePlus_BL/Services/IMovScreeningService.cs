using CinePlus_DAL.Models;
using CinePlus_BL.Dtos;
using System;
using System.Collections.Generic;

namespace CinePlus_BL.Services
{
    public interface IMovScreeningService
    {
        public IEnumerable<MovScreening> GetMovScreenings();
        public MovScreening GetMovScreening(int id);
        public void SaveMovScreening(MovScreeningDto movScreeningDto);
        public void UpdateMovScreening(MovScreeningDto movScreeningDto, int id);
        public void DeleteMovScreening(int id);
    }
}