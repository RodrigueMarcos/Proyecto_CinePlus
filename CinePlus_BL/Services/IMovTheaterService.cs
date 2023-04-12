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
        public IEnumerable<MovTheater> GetMovTheaters();
        public MovTheater GetMovTheater(int id);
        public void SaveMovTheater(MovTheaterDto movTheaterDto);
        public void UpdateMovTheater(MovTheaterDto movTheaterDto, int id);
        public void DeleteMovTheater(int id);
    }
}
