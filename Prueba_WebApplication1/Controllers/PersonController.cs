using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinePlus;
using CinePlus_DAL.Models;
using CinePlus_BL.Services;
using CinePlus_BL.Dtos;

namespace CinePlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //field privado de solo lectura
        private readonly IPersonService _questionsService;

        //Inyección de dependencia
        //Dependency injection
        public PersonController(IPersonService questionsService)
        {
            _questionsService = questionsService;
        }

        //Traer todo
        [HttpGet]
        public List<Person> GetPeople()
        {
            return _questionsService.GetPeople().ToList();
        }

        //Traer 1
        [HttpGet("{id}")]
        public Person GetPerson(int id)
        {
            return _questionsService.GetPerson(id);
        }

        //Buscar preguntas por texto
        [HttpGet("search/{text}")]
        public IEnumerable<Person> SearchPeopleName(string text)
        {
            return _questionsService.SearchPeopleName(text).ToList();
        }

        //Crear
        [HttpPost]
        public void PostPerson(PersonDto person)
        {
            _questionsService.SavePerson(person);
        }

        //Actualizar 1
        [HttpPut("{id}")]
        public void UpdatePerson(int id, PersonDto preguntaDto)
        {
            _questionsService.UpdatePerson(preguntaDto, id);
        }

        //Borrar 1
        [HttpDelete("{id}")]
        public void DeleteQuestion(int id)
        {

        }
    }
}
