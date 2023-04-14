using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public class GenereService : IGenereService
    {
        private readonly CinePlusDBContext _context;

        public GenereService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Genere> GetGeneres()
        {
            return _context.Generes.ToList();
        }

        public Genere GetGenere(int id)
        {
            return _context.Generes.FirstOrDefault(genere => genere.ID == id);
        }

        public void SaveGenere(GenereDTO genereDto)
        {
            var createdBy = _context.People.Find(genereDto.CreatedById);

            if (createdBy == null)
            {
                throw new ArgumentException("Created by person not found.");
            }

            var genere = new Genere()
            {
                Title = genereDto.Title,
                createdAt = DateTime.Now,
                CreatedById = createdBy.ID,
            };

            _context.Generes.Add(genere);
            _context.SaveChanges();
        }

        public void UpdateGenere(GenereDTO genereDto, int id)
        {
            var genere = _context.Generes.FirstOrDefault(genere => genere.ID == id);

            if (genere == null)
            {
                throw new ArgumentException("Genere not found.");
            }

            genere.Title = genereDto.Title;
            genere.modifiedAt = DateTime.Now;

            
                var modifiedBy = _context.People.FirstOrDefault(person => person.ID == genereDto.ModifiedById.Value);

                if (modifiedBy == null)
                {
                    throw new ArgumentException("Modified by person not found.");
                }
                genere.ModifiedById = genereDto.ModifiedById.Value;           

            _context.SaveChanges();
        }

        public void DeleteGenere(int id)
        {
            var genere = _context.Generes.FirstOrDefault(genere => genere.ID == id);

            if (genere == null)
            {
                throw new ArgumentException("Genere not found.");
            }

            _context.Generes.Remove(genere);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetMoviesByGenere(int genereId)
        {
            var movies = _context.MovieGeneres
                .Where(movgenre => movgenre.GenereID == genereId)
                .Select(movgenre => movgenre.Movie)
                .ToList();

            return movies;
        }
    }
}