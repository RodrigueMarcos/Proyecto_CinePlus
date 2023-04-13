using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public class MovTheaterService : IMovTheaterService
    {
        private readonly CinePlusDBContext _context;

        public MovTheaterService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<MovTheater> GetMovTheaters()
        {
            return _context.MovTheaters.ToList();
        }

        public MovTheater GetMovTheater(int id)
        {
            return _context.MovTheaters.FirstOrDefault(movTheater => movTheater.ID == id);
        }

        public void SaveMovTheater(MovTheaterDto movTheaterDto)
        {
            var cinema = _context.Cinemas.Find(movTheaterDto.cinemaID);
            var createdBy = _context.People.Find(movTheaterDto.createdByID);

            if (cinema == null || createdBy == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            var movTheater = new MovTheater()
            {
                QtyRows = movTheaterDto.QtyRows,
                QtySeats = movTheaterDto.QtySeats,
                Cinema = cinema,
                createdAt = movTheaterDto.createdAt,
                createdBy = createdBy,
            };

            _context.MovTheaters.Add(movTheater);
            _context.SaveChanges();
        }

        public void UpdateMovTheater(MovTheaterDto movTheaterDto, int id)
        {
            var movTheater = _context.MovTheaters.FirstOrDefault(movTheater => movTheater.ID == id);

            if (movTheater == null)
            {
                throw new ArgumentException("MovTheater not found.");
            }

            var cinema = _context.Cinemas.FirstOrDefault(c => c.ID == movTheaterDto.cinemaID);

            if (cinema == null)
            {
                throw new ArgumentException("Cinema not found.");
            }

            movTheater.QtyRows = movTheaterDto.QtyRows;
            movTheater.QtySeats = movTheaterDto.QtySeats;
            movTheater.Cinema = cinema;
            movTheater.createdAt = movTheaterDto.createdAt;

            var createdBy = _context.People.FirstOrDefault(p => p.ID == movTheaterDto.createdByID);

            if (createdBy == null)
            {
                throw new ArgumentException("Created by person not found.");
            }

            movTheater.createdBy = createdBy;
            movTheater.modifiedAt = movTheaterDto.modifiedAt;

            if (movTheaterDto.modifiedByID.HasValue)
            {
                var modifiedBy = _context.People.FirstOrDefault(person => person.ID == movTheaterDto.modifiedByID.Value);

                if (modifiedBy == null)
                {
                    throw new ArgumentException("Modified by person not found.");
                }

                movTheater.modifiedBy = modifiedBy;
            }
            else
            {
                movTheater.modifiedBy = null;
            }

            _context.SaveChanges();
        }

        public void DeleteMovTheater(int id)
        {
            var movTheater = _context.MovTheaters.Find(id);
            if (movTheater == null)
            {
                throw new ArgumentException("MovTheater does not exist");
            }
            _context.MovTheaters.Remove(movTheater);
            _context.SaveChanges();
        }
    }
}