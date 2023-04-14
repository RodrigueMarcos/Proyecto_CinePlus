using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_BL.Services
{
    public interface IMovTheaterService
    {
        IEnumerable<MovTheater> GetMovTheaters();
        MovTheater GetMovTheater(int id);
        void SaveMovTheater(MovTheaterDTO movTheaterDto);
        void UpdateMovTheater(MovTheaterDTO movTheaterDto, int id);
        void DeleteMovTheater(int id);
    }

}
