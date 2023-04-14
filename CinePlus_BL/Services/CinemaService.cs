using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{

    public class CinemaService : ICinemaService
    {
        private readonly CinePlusDBContext _context;

        public CinemaService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Cinema> GetCinemas()
        {
            return _context.Cinemas.ToList();
        }

        public Cinema GetCinema(int id)
        {
            return _context.Cinemas.FirstOrDefault(cinema => cinema.ID == id);
        }

        public void SaveCinema(CinemaDTO cinemaDto)
        {
            var createdBy = _context.People.Find(cinemaDto.CreatedById);

            if (createdBy == null)
            {
                throw new ArgumentException("Created by person not found.");
            }

            var cinema = new Cinema()
            {
                Name = cinemaDto.Name,
                Address = cinemaDto.Address,
                CreatedById = createdBy.ID,
                createdAt = DateTime.Now,
            };

            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
        }

        public void UpdateCinema(CinemaDTO cinemaDto, int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.ID == id);

            if (cinema == null)
            {
                throw new ArgumentException("Cinema not found.");
            }
           

            cinema.Name = cinemaDto.Name;
            cinema.Address = cinemaDto.Address;
            cinema.modifiedAt = DateTime.Now;


                var modifiedBy = _context.People.FirstOrDefault(person => person.ID == cinemaDto.ModifiedById.Value);

                if (modifiedBy == null)
                {
                    throw new ArgumentException("Modified by person not found.");
                }

                cinema.ModifiedById = cinemaDto.ModifiedById.Value;
 
     

            _context.SaveChanges();
        }

        public void DeleteCinema(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.ID == id);

            if (cinema == null)
            {
                throw new ArgumentException("Cinema not found.");
            }

            _context.Cinemas.Remove(cinema);
            _context.SaveChanges();
        }
    }

}

