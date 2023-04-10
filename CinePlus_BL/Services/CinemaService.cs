using System;
using System.Collections.Generic;
using System.Linq;
using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;

namespace CinePlus_BL.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly CinePlusContext _context;

        public CinemaService(CinePlusContext context)
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

        public void SaveCinema(CinemaDto cinemaDto)
        {
            var cinema = new Cinema
            {
                name = cinemaDto.name,
                address = cinemaDto.address,
                MovTheaters = new List<MovTheater>(),
                employees = new List<Person>(),
                createdAt = DateTime.Now,
                createdBy = cinemaDto.createdByID
            };

            if (cinemaDto.movTheaterIDs != null)
            {
                cinema.MovTheaters = _context.MovTheaters.Where(movTheaters => cinemaDto.movTheaterIDs.Contains(movTheaters.ID)).ToList();
            }

            if (cinemaDto.employeeIDs != null)
            {
                cinema.employees = _context.People.Where(employ => cinemaDto.employeeIDs.Contains(employ.ID)).ToList();
            }

            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
        }

        public void UpdateCinema(CinemaDto cinemaDto, int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.ID == id);

            if (cinema != null)
            {
                cinema.name = cinemaDto.name;
                cinema.address = cinemaDto.address;
                cinema.modifiedAt = DateTime.Now;
                cinema.modifiedBy = cinemaDto.modifiedByID;

                if (cinemaDto.movTheaterIDs != null)
                {
                    cinema.MovTheaters = _context.MovTheaters.Where(movTheaters => cinemaDto.movTheaterIDs.Contains(movTheaters.ID)).ToList();
                }
                else
                {
                    cinema.MovTheaters = new List<MovTheater>();
                }

                if (cinemaDto.employeeIDs != null)
                {
                    cinema.employees = _context.People.Where(employ => cinemaDto.employeeIDs.Contains(employ.ID)).ToList();
                }
                else
                {
                    cinema.employees = new List<Person>();
                }

                _context.SaveChanges();
            }
        }

        public void DeleteCinema(int id)
        {
            var cinema = _context.Cinemas.FirstOrDefault(c => c.ID == id);

            if (cinema != null)
            {
                _context.Cinemas.Remove(cinema);
                _context.SaveChanges();
            }
        }
    }
}
