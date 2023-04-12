using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinePlus_BL.Services
{
    public class GenereService : IGenereService
    {
        private readonly CinePlusContext _context;

        public GenereService(CinePlusContext context)
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

        public void SaveGenere(GenereDto genereDto)
        {
            Genere genere = new Genere()
            {
                title = genereDto.title,
                createdAt = DateTime.Now,
                createdBy = genereDto.createdByID
            };
            _context.Generes.Add(genere);
            _context.SaveChanges();
        }

        public void UpdateGenere(GenereDto genereDto, int id)
        {
            Genere genere = _context.Generes.FirstOrDefault(genere => genere.ID == id);
            if (genere != null)
            {
                genere.title = genereDto.title;
                genere.modifiedAt = DateTime.Now;
                genere.modifiedBy = genereDto.modifiedByID;
                _context.SaveChanges();
            }
        }

        public void DeleteGenere(int id)
        {
            Genere genere = _context.Generes.FirstOrDefault(genere => genere.ID == id);
            if (genere != null)
            {
                _context.Generes.Remove(genere);
                _context.SaveChanges();
            }
        }
    }
}

