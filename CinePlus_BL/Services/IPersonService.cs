using CinePlus_BL.Dtos;
using CinePlus_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinePlus_BL.Services
{
    public interface IPersonService
    {
        public IEnumerable<Person> GetPeople();
        public IEnumerable<Person> SearchPeopleName(string text);
        public IEnumerable<Person> SearchPeopleLastName(string text);
        public Person GetPerson(int id);
        public void SavePerson(PersonDto preguntaDto);
        public void UpdatePerson(PersonDto preguntaDto, int id);
        public void DeletePerson(int id);
    }
}
