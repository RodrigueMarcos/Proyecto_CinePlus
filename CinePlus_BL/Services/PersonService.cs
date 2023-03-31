using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_BL.Services
{
    public class PersonService : IPersonService
    {
        private readonly CinePlusDbContext _context;

        public PersonService(CinePlusDbContext context)
        {
            _context = context;
        }

        public void DeletePerson(int id)
        {
            var person = _context.Person.Find(id);
            if(person != null)
            {
                _context.Person.Remove(person); // NO DEBE ELIMINAR PERSONAS DE LA BASE DE DATOS
                _context.SaveChanges();
            }
            
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.Person;
        }

        public Person GetPerson(int id)
        {
            return _context.Person.Find(id);
        }

        public void SavePerson(PersonDto personDto)
        {
            Person person = new Person()
            {
                Name = personDto.Name,
                LastName = personDto.LastName,
            };
            _context.Person.Add(person);
            _context.SaveChanges();

        }

        public IEnumerable<Person> SearchPeopleName(string text)
        {
            return _context.Person.Where(p => p.Name.Contains(text));
        }
        public IEnumerable<Person> SearchPeopleLastName(string text)
        {
            return _context.Person.Where(p => p.LastName.Contains(text));
        }

        public void UpdatePerson(PersonDto preguntaDto, int id)
        {
            var person = _context.Person.Find(id);
            if(person != null)
            {
                person.Name = preguntaDto.Name;
                person.LastName = preguntaDto.LastName;
                _context.Person.Update(person);
                _context.SaveChanges();
                
            }
            
        }
    }
}
