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

        public void SaveMovTheater(MovTheaterDTO movTheaterDto)
        {
            var cinema = _context.Cinemas.Find(movTheaterDto.CinemaId);
            var createdBy = _context.People.Find(movTheaterDto.CreatedById);

            if (cinema == null || createdBy == null)
            {
                throw new ArgumentException("Invalid input data.");
            }

            var movTheater = new MovTheater()
            {
                QtyRows = movTheaterDto.QtyRows,
                QtySeats = movTheaterDto.QtySeats,
                CinemaId = cinema.ID,
                createdAt = DateTime.Now,
                CreatedById = createdBy.ID,
            };

            _context.MovTheaters.Add(movTheater);
            _context.SaveChanges();
        }

        public void UpdateMovTheater(MovTheaterDTO movTheaterDto, int id)
        {
            var movTheater = _context.MovTheaters.FirstOrDefault(movTheater => movTheater.ID == id);

            if (movTheater == null)
            {
                throw new ArgumentException("MovTheater not found.");
            }

            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.ID == movTheaterDto.CinemaId);

            if (cinema == null)
            {
                throw new ArgumentException("Cinema not found.");
            }

            movTheater.QtyRows = movTheaterDto.QtyRows;
            movTheater.QtySeats = movTheaterDto.QtySeats;
            movTheater.CinemaId = cinema.ID;
            movTheater.createdAt = movTheaterDto.createdAt;

            movTheater.modifiedAt = DateTime.Now;

           
                    var modifiedBy = _context.People.FirstOrDefault(person => person.ID == movTheaterDto.ModifiedById.Value);

                    if (modifiedBy == null)
                    {
                        throw new ArgumentException("Modified by person not found.");
                    }
                    movTheater.ModifiedById = movTheaterDto.ModifiedById.Value;
    

                _context.SaveChanges();
            }

            public void DeleteMovTheater(int id)
            {
                var movTheater = _context.MovTheaters.FirstOrDefault(movTheater => movTheater.ID == id);

                if (movTheater == null)
                {
                    throw new ArgumentException("MovTheater not found.");
                }

                _context.MovTheaters.Remove(movTheater);
                _context.SaveChanges();
            }
        }

    }