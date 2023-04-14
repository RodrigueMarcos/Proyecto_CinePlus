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
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
        void SavePerson(PersonDTO personDto);
        void UpdatePerson(PersonDTO personDto, int id);
        void DeletePerson(int id);
    }
}
