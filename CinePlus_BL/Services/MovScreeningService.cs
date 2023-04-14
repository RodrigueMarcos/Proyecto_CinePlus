using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;
using Microsoft.EntityFrameworkCore;

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
            return _context.MovScreenings.Include(movie => movie.Movie).Include(movie => movie.MovTheater).ToList();
        }

        public MovScreening GetMovScreening(int id)
        {
            return _context.MovScreenings.Include(movie => movie.Movie).Include(movie => movie.MovTheater).FirstOrDefault(m => m.ID == id);
        }

        public void SaveMovScreening(MovScreeningDTO movScreeningDto)
        {
            var movie = _context.Movies.Find(movScreeningDto.MovieId);
            var movTheater = _context.MovTheaters.Find(movScreeningDto.MovTheaterId);
            var createdBy = _context.People.Find(movScreeningDto.CreatedById);

            if (movie == null || movTheater == null || createdBy == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            var movScreening = new MovScreening()
            {
                Date = movScreeningDto.Date,
                MovieId = movie.ID,
                MovTheaterId = movTheater.ID,
                MovType = movScreeningDto.MovType.ToString(),
                CreatedById = createdBy.ID,
                createdAt = DateTime.Now,
            };

            _context.MovScreenings.Add(movScreening);
            _context.SaveChanges();
        }

        public void UpdateMovScreening(MovScreeningDTO movScreeningDto, int id)
        {
            var movScreening = _context.MovScreenings.Include(m => m.Movie).Include(m => m.MovTheater).FirstOrDefault(m => m.ID == id);

            if (movScreening == null)
            {
                throw new ArgumentException("MovScreening not found.");
            }

            var movie = _context.Movies.Find(movScreeningDto.MovieId);
            var movTheater = _context.MovTheaters.Find(movScreeningDto.MovTheaterId);
            var createdBy = _context.People.Find(movScreeningDto.CreatedById);

            if (movie == null || movTheater == null || createdBy == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            movScreening.Date = movScreeningDto.Date;
            movScreening.MovieId = movie.ID;
            movScreening.MovTheaterId = movTheater.ID;
            movScreening.MovType = movScreeningDto.MovType.ToString();

            var modifiedBy = _context.People.FirstOrDefault(person => person.ID == movScreeningDto.ModifiedById.Value);

            if (modifiedBy == null)
            {
                throw new ArgumentException("Modified by person not found.");
            }
            movScreening.ModifiedById = movScreeningDto.ModifiedById.Value;
            movScreening.modifiedAt = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteMovScreening(int id)
        {
            var movScreening = _context.MovScreenings.Find(id);

            if (movScreening == null)
            {
                throw new ArgumentException("MovScreening not found.");
            }

            _context.MovScreenings.Remove(movScreening);
            _context.SaveChanges();
        }
    }
}
