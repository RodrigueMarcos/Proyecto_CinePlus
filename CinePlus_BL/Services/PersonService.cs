using CinePlus_BL.Dtos;
using CinePlus_DAL;
using CinePlus_DAL.Models;
using System.Data;


namespace CinePlus_BL.Services
{
    public class PersonService : IPersonService
    {
        private readonly CinePlusDBContext _context;

        public PersonService(CinePlusDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetPeople()
        {
            return _context.People.ToList();
        }

        public Person GetPerson(int id)
        {
            return _context.People.FirstOrDefault(person => person.ID == id);
        }

        public void SavePerson(PersonDTO personDto)
        {

            var person = new Person()
            {
                role = personDto.role.ToString(),
                name = personDto.name,
                lastName = personDto.lastName,
                createdAt = DateTime.Now,
                ModifiedById = personDto.ModifiedById,
            };

            _context.People.Add(person);
            _context.SaveChanges();
        }

        public void UpdatePerson(PersonDTO personDto, int id)
        {
            var person = _context.People.FirstOrDefault(person => person.ID == id);

            if (person == null)
            {
                throw new ArgumentException("Person not found.");
            }

            var modifiedBy = _context.People.FirstOrDefault(person => person.ID == personDto.ModifiedById);

            if (modifiedBy == null)
            {
                throw new ArgumentException("Modified by person not found.");
            }

            person.role = personDto.role.ToString();
            person.name = personDto.name;
            person.lastName = personDto.lastName;
            person.ModifiedById = personDto.ModifiedById;
            person.modifiedAt = DateTime.Now;

            _context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var person = _context.People.FirstOrDefault(person => person.ID == id);

            if (person == null)
            {
                throw new ArgumentException("Person not found.");
            }

            _context.People.Remove(person);
            _context.SaveChanges();
        }
    }
}

