using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CinePlus_BL.Services
{
    public class PersonService : IPersonService
    {
        private readonly CinePlusContext _context;

        public PersonService(CinePlusContext context)
        {
            _context = context;
        }

        public void DeletePerson(int id)
        {
            var person = _context.People.Find(id);
            if (person != null)
            {
                _context.People.Remove(person); // NO DEBE ELIMINAR PERSONAS DE LA BASE DE DATOS
                _context.SaveChanges();
            }

        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People;
        }

        public Person GetPerson(int id)
        {
            return _context.People.Find(id);
        }

        public void SavePerson(PersonDto personDto)
        {
            Person person = new Person()
            {
                role = personDto.role,
                name = personDto.name,
                lastName = personDto.lastName,
                createdAt = personDto.createdAt,
            };
            _context.People.Add(person);
            _context.SaveChanges();
        }


        public IEnumerable<Person> SearchPeopleName(string text)
        {
            return _context.People.Where(p => p.name.Contains(text));
        }
        public IEnumerable<Person> SearchPeopleLastName(string text)
        {
            return _context.People.Where(p => p.lastName.Contains(text));
        }

        public void UpdatePerson(PersonDto personDto, int id)
        {
            var person = _context.People.Find(id);
            if (person != null)
            {
               person.role = personDto.role;
               person.name = personDto.name;
               person.lastName = personDto.lastName;
               person.modifiedAt = personDto.modifiedAt;
               person.modifiedBy = (personDto.modifiedByID);

                _context.People.Update(person);
                _context.SaveChanges();

            }

        }
    }
}
