using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public class MovScreeningService : IMovScreeningService
    {
        private readonly CinePlusDBContext _context;

        public MovScreeningService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<MovScreening> GetMovScreenings()
        {
            return _context.MovScreenings.ToList();
        }

        public MovScreening GetMovScreening(int id)
        {
            return _context.MovScreenings.FirstOrDefault(movScreen => movScreen.ID == id);
        }

        public void SaveMovScreening(MovScreeningDto movScreeningDto)
        {
            var movScreening = new MovScreening
            {
                movTheater = movScreeningDto.movTheaterID,
                movie = movScreeningDto.movID,
                date = movScreeningDto.startDateTime,
                createdAt = DateTime.Now,
                createdBy = movScreeningDto.createdByID,
            };
            _context.MovScreenings.Add(movScreening);
            _context.SaveChanges();
        }

        public void UpdateMovScreening(MovScreeningDto movScreeningDto, int id)
        {
            var movScreening = _context.MovScreenings.FirstOrDefault(movScreen => movScreen.ID == id);
            if (movScreening != null)
            {
                movScreening.movTheater = movScreeningDto.movTheaterID;
                movScreening.movie = movScreeningDto.movID;
                movScreening.date = movScreeningDto.startDateTime;
                movScreening.modifiedAt = movScreeningDto.modifiedAt;
                movScreening.modifiedBy = movScreeningDto.modifiedByID;
                _context.SaveChanges();
            }
        }

        public void DeleteMovScreening(int id)
        {
            var movScreening = _context.MovScreenings.FirstOrDefault(movScreen => movScreen.ID == id);
            if (movScreening != null)
            {
                _context.MovScreenings.Remove(movScreening);
                _context.SaveChanges();
            }
        }
    }
}
